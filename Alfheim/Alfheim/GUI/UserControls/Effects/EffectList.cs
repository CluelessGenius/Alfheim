using Alfheim_Model.TRIGGERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class EffectList : UserControl
    {
        private bool enablingEnabled;
        private Trigger selectedTrigger;
        private List<Trigger> triggers;

        public EffectList()
        {
            InitializeComponent();
            EnablingEnabled = false;
            triggerDetail1.ValueChanged += TriggerDetail1_ValueChanged;
        }

        private void TriggerDetail1_ValueChanged(object sender, ValuechangedEventArgs e)
        {
            string[] proppath = e.Property.Split('.');
            object objecttochange = Triggers.Single(t=>t.ID==e.ID);
            for (int i = 1; i < proppath.Length; i++)
            {
                objecttochange = objecttochange.GetType().GetProperty(proppath[i - 1]).GetValue(objecttochange);
            }
            objecttochange.GetType().GetProperty(proppath.Last()).SetValue(objecttochange, e.NewValue);
        }

        public bool EnablingEnabled
        {
            get { return enablingEnabled; }
            set
            {
                enablingEnabled = value;
                foreach (TriggerListEntry entry in pnl_parameters.Controls)
                {
                    entry.EnablingPossible = value;
                }
            }
        }

        public int SelectedRowIndex { get; set; }

        public Trigger SelectedTrigger
        {
            get { return selectedTrigger; }
            set
            {
                selectedTrigger = value;
            }
        }

        public List<Trigger> Triggers
        {
            get { return triggers; }
            set
            {
                triggers = value;
                SelectedRowIndex = -1;
                RefreshParamList();
            }
        }

        public event EventHandler TriggerEnabledChanged;

        public void RefreshParamList()
        {
            pnl_parameters.Controls.Clear();
            if (triggers == null)
            {
                return;
            }
            List<TriggerListEntry> entrycontrols = triggers.Select(t => (new TriggerListEntry(t))).ToList();
            entrycontrols.ForEach(e =>
            {
                e.Width = pnl_parameters.Width - 24;
                e.Clicked += Entry_Clicked;
                e.Deleted += Entry_Deleted;
                e.EnabledToggleChanged += EntryEnabled_Changed;
                e.EnablingPossible = enablingEnabled;
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

        public void SetToggles(List<long> IDs)
        {
            foreach (TriggerListEntry entry in pnl_parameters.Controls)
            {
                entry.ToggleEnabled = IDs.Contains(entry.Param.ID);
            }
        }

        private void EntryEnabled_Changed(object sender, EventArgs e)
        {
            if (TriggerEnabledChanged!=null)
            {
                TriggerEnabledChanged(sender, e);
            }
        }

        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxID += 1;
            Properties.Settings.Default.Save();
            Triggers.Add(new Trigger() { Name = "Dummy Trigger Static", TriggerType = TriggerType.Static, ID = Properties.Settings.Default.MaxID });
            RefreshParamList();
        }

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

        private void Entry_Deleted(object sender, EventArgs e)
        {
            Triggers.Remove((sender as TriggerListEntry).Param);
            pnl_parameters.Controls.Remove((sender as TriggerListEntry));
            triggerDetail1.DetailedTrigger = null;
        }
    }
}