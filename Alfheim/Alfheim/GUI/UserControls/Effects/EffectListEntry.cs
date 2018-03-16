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
    public partial class EffectListEntry : UserControl
    {
        bool enablingPossible;

        public EffectListEntry(Trigger trigger)
        {
            InitializeComponent();
            Param = trigger;
            lbl_name.DataBindings.Add(new Binding("Text", Param, "Name"));
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
            tgl_enabled.BackColor = Color.FromArgb(209, 65, 26);
        }

        public event EventHandler Clicked;

        public event EventHandler Deleted;

        public event EventHandler EnabledToggleChanged;

        public Color Backcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public bool EnablingPossible
        {
            get
            {
                return enablingPossible;
            }

            set
            {
                enablingPossible = value;
                tgl_enabled.Enabled = value;
            }
        }

        public Trigger Param { get; set; }

        public bool ToggleEnabled
        {
            get
            {
                return tgl_enabled.Checked;
            }

            set
            {
                tgl_enabled.Checked = value;
            }
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
        
        private void TriggerListEntry_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(this, e);
        }

        private void TriggerListEntry_SizeChanged(object sender, EventArgs e)
        {
            lbl_name.MaximumSize = new Size(tgl_enabled.Location.X - lbl_name.Location.X, Height);
        }

        private void tgl_enabled_Click(object sender, EventArgs e)
        {
            if (EnabledToggleChanged != null)
            {
                EnabledToggleChanged(Param, new ValuechangedEventArgs() { NewValue = tgl_enabled.Checked, OldValue = !tgl_enabled.Checked, Property = Param.Name });
            }
        }
    }
}
