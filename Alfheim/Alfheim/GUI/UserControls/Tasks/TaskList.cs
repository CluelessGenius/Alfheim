using Alfheim_Model;
using Alfheim_ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TaskList : UserControl
    {
        private int selectedRowIndex = -1;
        private DataMemberManager<Task> taskManager;

        public TaskList()
        {
            InitializeComponent();
        }

        public List<TaskListEntry> Entries
        {
            get
            {
                return pnl_tasks.Controls.OfType<TaskListEntry>().ToList();
            }
        }

        public DataMemberManager<Task> TaskManager
        {
            get
            {
                return taskManager;
            }
        }

        public void SetDataManager(DataMemberManager<Task> taskmanager)
        {
            taskManager = taskmanager;
            taskManager.PropertyChanged += TaskManager_PropertyChanged;
            RefreshTaskList();
        }

        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            taskManager.Create();
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            taskManager.Select(Entries.IndexOf(sender as TaskListEntry));
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            taskManager.Delete(pnl_tasks.Controls.IndexOf((sender as TaskListEntry)));
        }

        private void Entry_EnabledChanged(object sender, EventArgs e)
        {
            taskManager.Members[pnl_tasks.Controls.IndexOf(sender as TaskListEntry)].Enabled = (sender as TaskListEntry).TaskEnabled;
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

        private void RefreshTaskList(int selectedindex = -1)
        {
            SuspendLayout();
            pnl_tasks.Controls.Clear();
            foreach (Task task in taskManager.Members)
            {
                var tle = new TaskListEntry(task);
                tle.Width = pnl_tasks.Width - 30;
                tle.Clicked += Entry_Clicked;
                tle.Deleted += Entry_Deleted;
                tle.TaskEnabledChanged += Entry_EnabledChanged;
                if (taskManager.Members.IndexOf(task) == selectedindex)
                {
                    tle.BackColor = Color.FromArgb(100, 209, 65, 26);
                }
                pnl_tasks.Controls.Add(tle);
            }
            selectedRowIndex = selectedindex;
            ResumeLayout();
        }

        private void TaskManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is Task)
            {
                var tasksender = (sender as Task);
                switch (e.PropertyName)
                {
                    case nameof(tasksender.Enabled):
                        Entries.Single(le => le.TaskID == tasksender.ID).TaskEnabled=tasksender.Enabled;
                        break;
                    case nameof(tasksender.Triggers):
                        break;
                    default:
                        break;
                }
            }
            else if (sender is DataMemberManager<Task>)
            {
                var tasksender = (sender as DataMemberManager<Task>);
                switch (e.PropertyName)
                {
                    case nameof(tasksender.SelectedMember):
                        if (tasksender.SelectedMember == null)
                        {
                            return;
                        }
                        int index = tasksender.Members.IndexOf(tasksender.SelectedMember);
                        if (selectedRowIndex >= 0 && selectedRowIndex < Entries.Count)
                        {
                            Entries[selectedRowIndex].BackColor = Color.Transparent;
                        }
                        selectedRowIndex = index;
                        if (selectedRowIndex >= 0 && selectedRowIndex < Entries.Count)
                        {
                            Entries[selectedRowIndex].BackColor = Color.FromArgb(100, 209, 65, 26);
                        }
                        break;
                    case nameof(tasksender.Members):
                        RefreshTaskList();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}