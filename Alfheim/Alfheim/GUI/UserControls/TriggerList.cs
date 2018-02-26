using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alfheim_Model.TRIGGERS;

namespace Alfheim.GUI.UserControls
{
    public partial class TriggerList : UserControl
    {
        private List<Trigger> trigger;

        public List<Trigger> Triggers
        {
            get { return trigger; }
            set
            {
                trigger = value;
                pnl_triggers.Controls.Clear();
                pnl_triggers.Controls.AddRange(Triggers.Select(t => (new TriggerListEntry(t))).ToArray());
                foreach (Control control in pnl_triggers.Controls)
                {
                    if (control is TriggerListEntry)
                    {
                        (control as TriggerListEntry).Clicked += Entry_Clicked;
                        (control as TriggerListEntry).Deleted += Entry_Deleted;
                    }
                }
                
            }
        }

        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            Trigger newt = new Trigger();
            Triggers.Add(newt);
            TriggerListEntry newtentry = new TriggerListEntry(newt);
            newtentry.Clicked += Entry_Clicked;
            newtentry.Deleted += Entry_Deleted;
            pnl_triggers.Controls.Add(newtentry);
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            Triggers.Remove((sender as TriggerListEntry).Trigger);
            pnl_triggers.Controls.Remove((sender as TriggerListEntry));
        }

        public int SelectedRowIndex { get; set; }

        public Trigger SelectedTrigger { get; set; }
        
        public TriggerList()
        {
            InitializeComponent();
            Triggers = new List<Trigger>();
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            foreach (TriggerListEntry entry in pnl_triggers.Controls)
            {
                if (entry.BackColor != Color.Transparent)
                {
                    entry.BackColor = Color.Transparent;
                    break;
                }
            }
            (sender as TriggerListEntry).BackColor = Color.FromArgb(209, 65, 26);
            SelectedRowIndex = pnl_triggers.Controls.IndexOf(sender as TriggerListEntry);
            SelectedTrigger = Triggers[SelectedRowIndex];
        }
    }
}
