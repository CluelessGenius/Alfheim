using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alfheim_Model.TRIGGERS;
using Alfheim_Model;
using Alfheim_Model.DEVICES;

namespace Alfheim.GUI.UserControls
{
    public partial class TaskList : UserControl
    {
        private List<Alfheim_Model.Task> tasks;

        public List<Alfheim_Model.Task> Tasks
        {
            get
            {
                if (tasks == null)
                    tasks = new List<Alfheim_Model.Task>();
                return tasks;
            }
            set
            {
                tasks = value;
                RefreshTaskList();
            }
        }

        private Alfheim_Model.Task selectedTask;

        public Alfheim_Model.Task SelectedTask
        {
            get
            { 
                return selectedTask;
            }
            set
            {
                selectedTask = value;
            }
        }

        private int selectedRowIndex = -1;

        public TaskList()
        {
            InitializeComponent();

        }
        
        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            Alfheim_Model.Task newtask = new Alfheim_Model.Task();
            Tasks.Add(newtask);
            TaskListEntry entrycontrol = new TaskListEntry(newtask);
            entrycontrol.Width = pnl_tasks.Width - 30;
            entrycontrol.Clicked += Entry_Clicked;
            entrycontrol.Deleted += Entry_Deleted;
            pnl_tasks.Controls.Add(entrycontrol);
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                (pnl_tasks.Controls[selectedRowIndex] as TaskListEntry).BackColor = Color.Transparent;
            }
            Tasks.Remove((sender as TaskListEntry).Task);
            pnl_tasks.Controls.Remove((sender as TaskListEntry));
            selectedRowIndex = -1;
            SelectedTask = null;
            if (SelectionChanged != null)
            {
                SelectionChanged(this, EventArgs.Empty);
            }
        }
        
        public void SetTaskList(ref List<Alfheim_Model.Task> tasklist)
        {
            Tasks = tasklist;
        }

        public void RefreshTaskList()
        {
            if (tasks == null)
            {
                return;
            }
            SuspendLayout();
            pnl_tasks.Controls.Clear();
            List<TaskListEntry> entrycontrols = tasks.Select(t => (new TaskListEntry(t))).ToList();
            entrycontrols.ForEach(e => 
            {
                e.Width = pnl_tasks.Width - 30;
                e.Clicked += Entry_Clicked;
                e.Deleted += Entry_Deleted;
                pnl_tasks.Controls.Add(e);
            });
            selectedRowIndex = -1;
            SelectedTask = null;
            if (SelectionChanged != null)
            {
                SelectionChanged(this, EventArgs.Empty);
            }
            ResumeLayout();
        }


        public event EventHandler SelectionChanged;
        
        private void Entry_Clicked(object sender, EventArgs e)
        {
            ChangeSelection(pnl_tasks.Controls.IndexOf(sender as TaskListEntry));
        }

        private void ChangeSelection(int index)
        {
            if (index < 0 || index >= Tasks.Count || index == selectedRowIndex)
            {
                return;
            }
            if (selectedRowIndex >= 0)
            {
                (pnl_tasks.Controls[selectedRowIndex] as TaskListEntry).BackColor = Color.Transparent;
            }
            selectedRowIndex = index;
            SelectedTask = Tasks[index];
            (pnl_tasks.Controls[selectedRowIndex] as TaskListEntry).BackColor = Color.FromArgb(100,209, 65, 26);
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        private void pnl_tasks_SizeChanged(object sender, EventArgs e)
        {
            pnl_tasks.SuspendLayout();
            foreach (TaskListEntry ctrl in pnl_tasks.Controls)
            {
                ctrl.Width = pnl_tasks.Width - 30;
            }
            pnl_tasks.ResumeLayout();
            pnl_tasks.PerformLayout();
        }
    }
}
