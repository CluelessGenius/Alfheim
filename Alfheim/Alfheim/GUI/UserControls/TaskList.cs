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
            get { return tasks; }
            set
            {
                if (value != null)
                {
                    tasks = value;
                    RefreshTaskList();
                }
            }
        }

        public void RefreshTaskList()
        {
            if (tasks == null)
            {
                return;
            }
            pnl_tasks.Controls.Clear();
            List<TaskListEntry> entrycontrols = tasks.Select(t => (new TaskListEntry(t))).ToList();
            entrycontrols.ForEach(e => 
            {
                e.Width = pnl_tasks.Width - 20;
                e.Clicked += Entry_Clicked;
                e.Deleted += Entry_Deleted;
                pnl_tasks.Controls.Add(e);
            });
        }


        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            
            RefreshTaskList();
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            Tasks.Remove((sender as TaskListEntry).Task);
            pnl_tasks.Controls.Remove((sender as ParamListEntry));
            //triggerDetail1.DetailedParam = null;
        }

        public int SelectedRowIndex { get; set; }

        public Alfheim_Model.Task SelectedTask { get; set; }
        
        public TaskList()
        {
            InitializeComponent();
            tasks = new List<Alfheim_Model.Task>();
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            foreach (TaskListEntry entry in pnl_tasks.Controls)
            {
                if (entry.BackColor != Color.Transparent)
                {
                    entry.BackColor = Color.Transparent;
                    break;
                }
            }
            (sender as TaskListEntry).BackColor = Color.FromArgb(209, 65, 26);
            SelectedRowIndex = pnl_tasks.Controls.IndexOf(sender as TaskListEntry);
            SelectedTask = Tasks[SelectedRowIndex];
            //triggerDetail1.DetailedParam = SelectedTrigger;
        }

        
    }
}
