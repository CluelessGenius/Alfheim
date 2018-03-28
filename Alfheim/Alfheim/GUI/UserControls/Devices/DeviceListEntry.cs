using Alfheim_Model.DEVICES;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class DeviceListEntry : UserControl
    {
        public DeviceListEntry(Device device)
        {
            InitializeComponent();

            lbl_name.Text = device.Name;
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
            tgl_enabled.Checked = device.DeviceEnabled;

            device.PropertyChanged += Trigger_PropertyChanged;
        }

        private void Trigger_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Device trigger = (sender as Device);
            switch (e.PropertyName)
            {
                case nameof(trigger.Name):
                    lbl_name.Text = trigger.Name;
                    lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
                    break;
                case nameof(trigger.DeviceEnabled):
                    tgl_enabled.Checked = trigger.DeviceEnabled;
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
        
        public event EventHandler Deleted;

        public event EventHandler DeviceEnabledChanged;
        
        public bool DeviceEnabled { get { return tgl_enabled.Checked; } }

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
        
        private void tgl_enabled_Click(object sender, EventArgs e)
        {
            if (DeviceEnabledChanged != null)
                DeviceEnabledChanged(this, e);
        }
        
        private void TriggerListEntry_SizeChanged(object sender, EventArgs e)
        {
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
        }

        private void TriggerListEntry_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }
    }
}