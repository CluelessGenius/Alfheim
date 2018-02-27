using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TaskListEntry : UserControl
    {
        public Alfheim_Model.Task Task { get; set; }

        public Color Backcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public TaskListEntry(Alfheim_Model.Task task)
        {
            InitializeComponent();
            Task = task;
            lbl_name.DataBindings.Add(new Binding("Text",Task,"Name"));
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X- lbl_name.Location.X - 30, Height);
            tgl_enabled.DataBindings.Add(new Binding("Checked",Task,"Enabled"));
        }

        public event EventHandler Deleted;

        public event EventHandler Clicked;
        
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
    }
}
