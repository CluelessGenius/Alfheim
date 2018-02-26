using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TriggerListEntry : UserControl
    {
        public Alfheim_Model.TRIGGERS.Trigger Trigger { get; set; }

        public Color Backcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public TriggerListEntry(Alfheim_Model.TRIGGERS.Trigger trigger)
        {
            InitializeComponent();
            Trigger = trigger;
            lbl_name.Text = Trigger.ToString();
            tgl_enabled.Checked = Trigger.Enabled;
            tgl_enabled.BackColor = Color.FromArgb(209, 65, 26);
        }

        public event EventHandler Deleted;

        public event EventHandler Clicked;

        private void tgl_enabled_CheckedChanged(object sender, EventArgs e)
        {
            Trigger.Enabled = tgl_enabled.Checked;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(this, e);
            if (Deleted != null)
                Deleted(this, e);
        }

        private void tgl_enabled_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(this, e);
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
    }
}
