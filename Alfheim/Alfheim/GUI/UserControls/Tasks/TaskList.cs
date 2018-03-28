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
            taskmanager.OrderChanged += Taskmanager_OrderChanged;
            RefreshTaskList();
        }

        private void Taskmanager_OrderChanged(object sender, EventArgs e)
        {
            var dict = sender as Dictionary<string, int>;
            if (dict["From"] == dict["To"])
            {
                return;
            }
            int indexto = pnl_tasks.Controls.IndexOf(Entries[dict["To"]]);
            if (dict["From"] < dict["To"])
            {
                pnl_tasks.Controls.SetChildIndex(Entries[dict["From"]], indexto+1);
            }
            else
            {
                pnl_tasks.Controls.SetChildIndex(Entries[dict["From"]], indexto);
            }
            pnl_tasks.Controls.SetChildIndex(Indicators[dict["From"] + 1], indexto + 1);
        }

        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            taskManager.Create();
            AddListEntry(taskManager.Members.OrderByDescending(m=>m.ID).First());
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            taskManager.Select(Entries.IndexOf(sender as TaskListEntry));
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            taskManager.Delete(Entries.IndexOf((sender as TaskListEntry)));
            int index = pnl_tasks.Controls.IndexOf(sender as TaskListEntry);
            pnl_tasks.Controls.RemoveAt(index);
            pnl_tasks.Controls.RemoveAt(index);
        }

        private void Entry_EnabledChanged(object sender, EventArgs e)
        {
            if (Entries.IndexOf(sender as TaskListEntry)==-1)
            {
                (sender as TaskListEntry).TaskEnabled = !(sender as TaskListEntry).TaskEnabled;
                return;
            }
            taskManager.Members.First(m => m.DisplayedPosition == Entries.IndexOf(sender as TaskListEntry)).Enabled = (sender as TaskListEntry).TaskEnabled;
        }

        private void pnl_tasks_SizeChanged(object sender, EventArgs e)
        {
            pnl_tasks.SuspendLayout();
            foreach (Control ctrl in pnl_tasks.Controls)
            {
                ctrl.Width = pnl_tasks.Width - 30;
            }
            pnl_tasks.ResumeLayout();
            pnl_tasks.PerformLayout();
        }

        private void AddDragDropIndicator()
        {
            var tle = new DragDropIndicater();
            tle.Width = pnl_tasks.Width - 30;
            tle.Height = 5;
            tle.Margin = new Padding() {Top=0,Bottom=0,Left=5,Right=5 };
            pnl_tasks.Controls.Add(tle);
        }

        private void AddListEntry(Task task)
        {
            var tle = new TaskListEntry(task);
            tle.Width = pnl_tasks.Width - 30;
            tle.Clicked += Entry_Clicked;
            tle.Deleted += Entry_Deleted;
            tle.NameChanged += Tle_NameChanged;
            tle.TaskEnabledChanged += Entry_EnabledChanged;
            tle.DescriptionChanged += Tle_DescriptionChanged;
            pnl_tasks.Controls.Add(tle);
            AddDragDropIndicator();
        }

        private void RefreshTaskList(int selectedindex = -1)
        {
            pnl_tasks.SuspendLayout();
            pnl_tasks.Controls.Clear();
            AddDragDropIndicator();
            foreach (Task task in taskManager.Members.OrderBy(m=>m.DisplayedPosition))
            {
                AddListEntry(task);
            }
            selectedRowIndex = selectedindex;
            pnl_tasks.ResumeLayout();
        }

        private void Tle_DescriptionChanged(object sender, ValuechangedEventArgs e)
        {
            taskManager.Members.First(m => m.DisplayedPosition == Entries.IndexOf(sender as TaskListEntry)).Description = e.NewValue.ToString();
        }

        private void Tle_NameChanged(object sender, ValuechangedEventArgs e)
        {
            taskManager.Members.First(m => m.DisplayedPosition == Entries.IndexOf(sender as TaskListEntry)).Name = e.NewValue.ToString();
        }

        private void TaskManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is DataMemberManager<Task>)
            {
                var tasksender = (sender as DataMemberManager<Task>);
                switch (e.PropertyName)
                {
                    case nameof(tasksender.SelectedMember):
                        if (tasksender.SelectedMember != null)
                        {
                            selectedRowIndex = tasksender.SelectedMember.DisplayedPosition;
                        }
                        break;
                    case nameof(tasksender.Members):
                        //RefreshTaskList();
                        break;
                    default:
                        break;
                }
            }
        }

        private List<DragDropIndicater> Indicators { get { return pnl_tasks.Controls.OfType<DragDropIndicater>().ToList(); } }

        private static Color indicatorColor = Color.FromArgb(209, 65, 26);
        
        private void pnl_tasks_DragOver(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(typeof(TaskListEntry));
            if (data == null )
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = DragDropEffects.Move;
            Point mouselocation = pnl_tasks.PointToClient(new Point(e.X, e.Y));
            var ini = Indicators.Select(i=>Math.Abs(mouselocation.Y - i.Location.Y)).ToList();
            for (int i = 0; i < Indicators.Count; i++)
            {
                //Indicators[i].SetText(ini[i].ToString()+" | "+Indicators[i].Location.Y+" | "+mouselocation.Y);
                if (i == ini.IndexOf(ini.Min()))
                {
                    Indicators[i].BackColor = indicatorColor;
                }
                else
                {
                    Indicators[i].BackColor = Color.Transparent;
                }
            }
        }

        private void pnl_tasks_DragDrop(object sender, DragEventArgs e)
        {
            int index = Indicators.IndexOf(Indicators.First(ind=>ind.BackColor==indicatorColor));
            for (int i = 0; i < Indicators.Count; i++)
            {
                Indicators[i].BackColor = Color.Transparent;
            }
            var d = (TaskListEntry)e.Data.GetData(typeof(TaskListEntry));
            int indexfrom = Entries.IndexOf(d);
            index = index>indexfrom?Math.Max(0, index-1):index;
            taskManager.Move(indexfrom, index);
        }

        private void pnl_tasks_DragLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < Indicators.Count; i++)
            {
                Indicators[i].BackColor = Color.Transparent;
            }
        }
    }
}