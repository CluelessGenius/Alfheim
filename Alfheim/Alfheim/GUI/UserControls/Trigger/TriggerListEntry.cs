using Alfheim_Model.TRIGGERS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TriggerListEntry : UserControl
    {
        public TriggerListEntry(Trigger trigger)
        {
            InitializeComponent();
            TriggerID = trigger.ID;
            lbl_name.Text = trigger.Name;
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
        }

        public event EventHandler Clicked;

        public event EventHandler Deleted;

        public event EventHandler TriggerEnabledChanged;

        public Color Backcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        
        public long TriggerID { get; private set; }

        public bool TriggerEnabled { get { return tgl_enabled.Checked; } }

        public void SetToggleEnabled(bool value)
        {
            tgl_enabled.Enabled = value;
        }
        
        public void Update(Trigger trigger)
        {
            TriggerID = trigger.ID;
            lbl_name.Text = trigger.Name;
            tgl_enabled.Checked = trigger.TriggerEnabled;
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
    }
}