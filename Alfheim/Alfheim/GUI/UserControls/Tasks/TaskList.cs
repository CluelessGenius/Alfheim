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
        private DataManager dataManager;

        private int selectedRowIndex = -1;

        public TaskList()
        {
            InitializeComponent();
        }

        public DataManager DataManager
        {
            get
            {
                return dataManager;
            }
        }

        public void SetDataManager(ref DataManager datamanager)
        {
            dataManager = datamanager;
            RefreshTaskList();
        }

        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            dataManager.TaskManager.Create();
            RefreshTaskList(selectedRowIndex);
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            int index = pnl_tasks.Controls.IndexOf(sender as TaskListEntry);
            if (index == selectedRowIndex)
            {
                return;
            }
            try
            {
                (pnl_tasks.Controls[selectedRowIndex] as TaskListEntry).BackColor = Color.Transparent;
            }
            catch (Exception) { }
            selectedRowIndex = index;
            try
            {
                (pnl_tasks.Controls[selectedRowIndex] as TaskListEntry).BackColor = Color.FromArgb(100, 209, 65, 26);
            }
            catch (Exception) { }
            dataManager.TaskManager.Select(selectedRowIndex);
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            dataManager.TaskManager.Delete(pnl_tasks.Controls.IndexOf((sender as TaskListEntry)));
            RefreshTaskList();
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
            List<TaskListEntry> entrycontrols = dataManager.TaskManager.Members.Select(t => (new TaskListEntry(t))).ToList();
            entrycontrols.ForEach(e =>
            {
                e.Width = pnl_tasks.Width - 30;
                e.Clicked += Entry_Clicked;
                e.Deleted += Entry_Deleted;
                pnl_tasks.Controls.Add(e);
            });
            selectedRowIndex = selectedindex;
            try
            {
                (pnl_tasks.Controls[selectedRowIndex] as TaskListEntry).BackColor = Color.FromArgb(100, 209, 65, 26);
            }
            catch (Exception) { }
            dataManager.TaskManager.Select(selectedRowIndex);
            ResumeLayout();
        }
    }
}