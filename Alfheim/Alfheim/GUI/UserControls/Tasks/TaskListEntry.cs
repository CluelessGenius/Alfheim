using Alfheim_Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TaskListEntry : UserControl
    {
        private static Color selectionColor = Color.FromArgb(100, 209, 65, 26);

        private static Color backgroundColor = Color.FromArgb(100, 0, 0, 0);

        public TaskListEntry(Alfheim_Model.Task task)
        {
            InitializeComponent();
            
            tbx_name.Text = task.Name;
            tbx_description.Text = task.Description;
            tgl_enabled.Checked = task.Enabled;
            if (task.IsSelected)
            {
                BackColor = selectionColor;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
            }
            else
            {
                BackColor = backgroundColor;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
            }
            task.PropertyChanged += Task_PropertyChanged;
            UpdateIconsTrigger(task.TriggerInfos);
        }

        private void Task_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Task task = (sender as Task);
            switch (e.PropertyName)
            {
                case nameof(task.Name):
                    tbx_name.Text = task.Name;
                    break;
                case nameof(task.Enabled):
                    TaskEnabled = task.Enabled;
                    break;
                case nameof(task.IsSelected):
                    if (task.IsSelected)
                    {
                        BackColor = selectionColor;
                        panel1.BackColor = Color.Transparent;
                        panel2.BackColor = Color.Transparent;
                    }
                    else
                    {
                        BackColor = backgroundColor;
                        panel1.BackColor = Color.Transparent;
                        panel2.BackColor = Color.Transparent;
                    }
                    break;
                case nameof(task.TriggerInfos):
                    UpdateIconsTrigger(task.TriggerInfos);
                    break;
                default:
                    break;
            }
        }

        public event EventHandler<ValuechangedEventArgs> NameChanged;

        public event EventHandler<ValuechangedEventArgs> DescriptionChanged;

        public event EventHandler Deleted;

        public event EventHandler Clicked;

        public event EventHandler TaskEnabledChanged;
        
        public bool TaskEnabled { get { return tgl_enabled.Checked; } set { tgl_enabled.Checked = value; } }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (Deleted != null)
                Deleted(this, e);
        }
        
        private void TaskListEntry_Click(object sender, EventArgs e)
        {
            this.Focus();
            if (Clicked != null)
                Clicked(this, e);
        }

        private void tgl_enabled_Click(object sender, EventArgs e)
        {
            if (TaskEnabledChanged != null)
                TaskEnabledChanged(this, e);
        }

        public void UpdateIconsTrigger(List<TriggerInfo> infos)
        {
            if (infos==null)
            {
                return;
            }
            pnl_trigger.Controls.Clear();
            for (int i = 0; i < infos.Count; i++)
            {
                var ico = infos.GetRange(0, i).FirstOrDefault(info => info.Type == infos[i].Type);
                if (ico != null)
                {
                    toolTip1.SetToolTip(pnl_trigger.Controls[infos.IndexOf(ico)],
                                        toolTip1.GetToolTip(pnl_trigger.Controls[infos.IndexOf(ico)]) + "\r\n" + infos[i].ToString());
                }
                else
                {
                    var tpb = new PictureBox();
                    tpb.Height = tpb.Width = 16;
                    toolTip1.SetToolTip(tpb, infos[i].ToString());
                    tpb.Image = infos[i].Icon;
                    tpb.SizeMode = PictureBoxSizeMode.Zoom;
                    pnl_trigger.Controls.Add(tpb);
                }
            }
        }
        
        private void tbx_name_TextChanged(object sender, EventArgs e)
        {
            if (NameChanged != null)
            {
                NameChanged(this, new ValuechangedEventArgs() { NewValue = (sender as AlphaBlendTextBox).Text });
            }
        }

        private void tbx_description_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionChanged != null)
            {
                DescriptionChanged(this, new ValuechangedEventArgs() { NewValue = (sender as AlphaBlendTextBox).Text });
            }
        }

        private void tbx_description_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1)
            {
                tbx_description.EditingEnabled = true;
                tbx_description.Invalidate();
            }
            else
            {
                this.Focus();
                if (Clicked != null)
                    Clicked(this, e);
            }
        }

        private void tbx_name_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1)
            {
                tbx_name.EditingEnabled = true;
                tbx_name.Invalidate();
            }
            else
            {
                this.Focus();
                if (Clicked != null)
                    Clicked(this, e);
            }
        }
        
        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Focus();
                if (Clicked != null)
                    Clicked(this, e);
                DoDragDrop(this, DragDropEffects.Move);
            }
        }
    }
}
