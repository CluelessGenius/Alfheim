using Alfheim_Model.DEVICES;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class DevicePresetListEntry : UserControl
    {
        public DevicePresetListEntry(DevicePreset preset)
        {
            InitializeComponent();

            tbx_name.Text = preset.Name;
            if (preset.IsSelected)
            {
                BackColor = selectionColor;
            }
            else
            {
                BackColor = backgroundColor;
            }
            preset.PropertyChanged += Preset_PropertyChanged;
        }
        
        private void Preset_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            DevicePreset preset = (sender as DevicePreset);
            switch (e.PropertyName)
            {
                case nameof(preset.Name):
                    tbx_name.Text = preset.Name;
                    break;
                case nameof(preset.IsSelected):
                    if (preset.IsSelected)
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
        
        public event EventHandler<ValuechangedEventArgs> NameChanged;

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
        
        private void TriggerListEntry_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(this, e);
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

        private void tbx_name_TextChanged(object sender, EventArgs e)
        {
            if (NameChanged != null)
            {
                NameChanged(this, new ValuechangedEventArgs() { NewValue = (sender as AlphaBlendTextBox).Text });
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
    }
}