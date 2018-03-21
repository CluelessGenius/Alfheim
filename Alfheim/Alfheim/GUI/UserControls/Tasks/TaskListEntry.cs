using Alfheim_Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TaskListEntry : UserControl
    {
        public Color Backcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public TaskListEntry(Alfheim_Model.Task task)
        {
            InitializeComponent();

            TaskID = task.ID;
            lbl_name.Text = task.Name;
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X - 30, Height);
            tgl_enabled.Checked = task.Enabled;

            task.PropertyChanged += Task_PropertyChanged;
        }

        private void Task_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Task task = (sender as Task);
            switch (e.PropertyName)
            {
                case nameof(task.Name):
                    lbl_name.Text = task.Name;
                    lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X - 30, Height);
                    break;
                case nameof(task.Enabled):
                    tgl_enabled.Checked = task.Enabled;
                    break;
                default:
                    break;
            }
        }

        public event EventHandler Deleted;

        public event EventHandler Clicked;

        public event EventHandler TaskEnabledChanged;

        public long TaskID { get; private set; }

        public bool TaskEnabled { get { return tgl_enabled.Checked; } set { tgl_enabled.Checked = value; } }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (Deleted != null)
                Deleted(this, e);
        }
        
        private void TaskListEntry_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(this, e);
        }

        private void tgl_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (TaskEnabledChanged != null)
                TaskEnabledChanged(this, e);
        }
    }
}
