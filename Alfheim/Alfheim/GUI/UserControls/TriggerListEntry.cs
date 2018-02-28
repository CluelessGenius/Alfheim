using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alfheim_Model;
using Alfheim_Model.TRIGGERS;

namespace Alfheim.GUI.UserControls
{
    public partial class TriggerListEntry : UserControl
    {
        public Trigger Param { get; set; }

        public Color Backcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public TriggerListEntry(Trigger trigger)
        {
            InitializeComponent();
            Param = trigger;
            lbl_name.DataBindings.Add(new Binding("Text",Param,"Name"));
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X- lbl_name.Location.X - 30, Height);
            tgl_enabled.DataBindings.Add(new Binding("Checked",Param,"Enabled"));
            tgl_enabled.BackColor = Color.FromArgb(209, 65, 26);
        }
        
        public event EventHandler Deleted;

        public event EventHandler Clicked;

        private void tgl_enabled_CheckedChanged(object sender, EventArgs e)
        {
            Param.Enabled = tgl_enabled.Checked;
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
