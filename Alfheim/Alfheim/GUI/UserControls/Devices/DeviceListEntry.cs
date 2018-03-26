using Alfheim_Model.TRIGGERS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class DeviceListEntry : UserControl
    {
        public DeviceListEntry(Trigger trigger)
        {
            InitializeComponent();

            lbl_name.Text = trigger.Name;
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
            tgl_enabled.Checked = trigger.TriggerEnabled;

            trigger.PropertyChanged += Trigger_PropertyChanged;
        }

        private void Trigger_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Trigger trigger = (sender as Trigger);
            switch (e.PropertyName)
            {
                case nameof(trigger.Name):
                    lbl_name.Text = trigger.Name;
                    lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
                    break;
                case nameof(trigger.TriggerEnabled):
                    tgl_enabled.Checked = trigger.TriggerEnabled;
                    break;
                case nameof(trigger.IsSelected):
                    if (trigger.IsSelected)
                    {
                        BackColor = selectionColor;
                    }
                    else
                    {
                        BackColor = backgroundColor;
                    }
                    break;
                default:
                    break;
            }
        }

        private static Color selectionColor = Color.FromArgb(209, 65, 26);

        private static Color backgroundColor = Color.FromArgb(100, 0, 0, 0);

        public event EventHandler Clicked;

        public event EventHandler Deleted;

        public event EventHandler TriggerEnabledChanged;
        
        public bool TriggerEnabled { get { return tgl_enabled.Checked; } }

        public void SetToggleEnabled(bool value)
        {
            tgl_enabled.Enabled = value;
        }

        public bool GetToggleEnabled()
        {
            return tgl_enabled.Enabled;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (Deleted != null)
                Deleted(this, e);
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(this, e);
        }

        private void tgl_enabled_Click(object sender, EventArgs e)
        {
            if (TriggerEnabledChanged != null)
                TriggerEnabledChanged(this, e);
        }

        private void TriggerListEntry_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(this, e);
        }

        private void TriggerListEntry_SizeChanged(object sender, EventArgs e)
        {
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
        }

        private void TriggerListEntry_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Focus();
                if (Clicked != null)
                    Clicked(this, e);
                DoDragDrop(this, DragDropEffects.Move);
            }
        }
    }
}