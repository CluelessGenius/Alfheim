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
using Alfheim_Model;
using Alfheim_Model.DEVICES;

namespace Alfheim.GUI.UserControls
{
    public partial class TriggerList : UserControl
    {
        private List<Trigger> triggers;

        public List<Trigger> Triggers
        {
            get { return triggers; }
            set
            {
                triggers = value;
                if (triggers!=null)
                {
                    AddingEnabled = true;
                }
                SelectedRowIndex = -1;
                RefreshParamList();
            }
        }

        public Trigger SelectedTrigger
        {
            get { return selectedTrigger; }
            set
            {
                selectedTrigger = value;
            }
        }

        private Trigger selectedTrigger;

        public bool AddingEnabled
        {
            get { return addButton1.Enabled; }
            set { addButton1.Enabled = value; }
        }

        public TriggerList()
        {
            InitializeComponent();
            AddingEnabled = false;
        }

        public void Clear()
        {
            SelectedRowIndex = -1;
            SelectedTrigger = null;
        }

        public void RefreshParamList()
        {
            pnl_parameters.Controls.Clear();
            if (triggers==null)
            {
                return;
            }
            List<TriggerListEntry> entrycontrols = triggers.Select(t => (new TriggerListEntry(t))).ToList();
            entrycontrols.ForEach(e => 
            {
                e.Width = pnl_parameters.Width - 24;
                e.Clicked += Entry_Clicked;
                e.Deleted += Entry_Deleted;
                pnl_parameters.Controls.Add(e);
            });
            try
            {
                triggerDetail1.DetailedTrigger = SelectedTrigger = Triggers[SelectedRowIndex];    
            }
            catch (Exception)
            {
                triggerDetail1.DetailedTrigger = SelectedTrigger = null;
                return;
            }
        }
        
        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            Triggers.Add(new Trigger() { Name = "Dummy Trigger Static" , TriggerType = TriggerType.Static });
            RefreshParamList();
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            Triggers.Remove((sender as TriggerListEntry).Param);
            pnl_parameters.Controls.Remove((sender as TriggerListEntry));
            triggerDetail1.DetailedTrigger = null;
        }

        public int SelectedRowIndex { get; set; }

        

        

        private void Entry_Clicked(object sender, EventArgs e)
        {
            foreach (TriggerListEntry entry in pnl_parameters.Controls)
            {
                if (entry.BackColor != Color.Transparent)
                {
                    entry.BackColor = Color.Transparent;
                    break;
                }
            }
            (sender as TriggerListEntry).BackColor = Color.FromArgb(209, 65, 26);
            SelectedRowIndex = pnl_parameters.Controls.IndexOf(sender as TriggerListEntry);
            SelectedTrigger = Triggers[SelectedRowIndex];
            triggerDetail1.DetailedTrigger = SelectedTrigger;
        }

        public void SetParameters(List<Trigger> parames)
        {
            Triggers.Clear();
            Triggers.AddRange(parames);
            RefreshParamList();
        }
    }

    public enum ParamListType
    {
        TRIGGER,
        DEVICES,
        ACTIONS
    }
}
