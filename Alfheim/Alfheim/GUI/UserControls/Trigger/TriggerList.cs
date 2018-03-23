using Alfheim_Model.TRIGGERS;
using Alfheim_ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TriggerList : UserControl
    {
        public int selectedRowIndex = -1;
        private DataMemberManager<Trigger> triggerManager;

        public TriggerList()
        {
            InitializeComponent();
        }

        public List<TriggerListEntry> Entries
        {
            get
            {
                return pnl_parameters.Controls.OfType<TriggerListEntry>().ToList();
            }
        }

        public DataMemberManager<Trigger> TriggerManager
        {
            get
            {
                return triggerManager;
            }
        }

        public void SetDataManager(DataMemberManager<Trigger> triggermanager)
        {
            triggerManager = triggermanager;
            triggerManager.PropertyChanged += TriggerManager_PropertyChanged;
            RefreshParamList();
        }

        public void SetTogglesEnabled(bool value)
        {
            areTogglesEnabled = value;
            foreach (TriggerListEntry entry in Entries)
            {
                entry.SetToggleEnabled(value);
            }
        }

        private bool areTogglesEnabled;

        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            triggerManager.Create();
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            triggerManager.Select(Entries.IndexOf(sender as TriggerListEntry));
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            triggerManager.Delete(pnl_parameters.Controls.IndexOf(sender as TriggerListEntry));
        }

        private void EntryEnabled_Changed(object sender, EventArgs e)
        {
            triggerManager.Members[Entries.IndexOf(sender as TriggerListEntry)].TriggerEnabled = (sender as TriggerListEntry).TriggerEnabled;
        }

        private void RefreshParamList(int selectedindex = -1)
        {
            SuspendLayout();
            pnl_parameters.Controls.Clear();
            foreach (Trigger trigger in triggerManager.Members)
            {
                var tle = new TriggerListEntry(trigger);
                tle.SetToggleEnabled(areTogglesEnabled);
                tle.Width = pnl_parameters.Width - 24;
                tle.Clicked += Entry_Clicked;
                tle.Deleted += Entry_Deleted;
                tle.TriggerEnabledChanged += EntryEnabled_Changed;
                pnl_parameters.Controls.Add(tle);
            }
            selectedRowIndex = selectedindex;
            ResumeLayout();
        }
        
        private void TriggerList_SizeChanged(object sender, EventArgs e)
        {
            pnl_parameters.SuspendLayout();
            foreach (TriggerListEntry ctrl in Entries)
            {
                ctrl.Width = pnl_parameters.Width - 24;
            }
            pnl_parameters.ResumeLayout();
            pnl_parameters.PerformLayout();
        }

        private void TriggerManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is DataMemberManager<Trigger>)
            {
                var trigsender = (sender as DataMemberManager<Trigger>);
                switch (e.PropertyName)
                {
                    case nameof(trigsender.SelectedMember):
                        if (trigsender.SelectedMember == null)
                        {
                            return;
                        }
                        int index = trigsender.Members.IndexOf(trigsender.SelectedMember);
                        if (selectedRowIndex >= 0 && selectedRowIndex < Entries.Count)
                        {
                            Entries[selectedRowIndex].BackColor = Color.Transparent;
                        }
                        selectedRowIndex = index;
                        if (selectedRowIndex >= 0 && selectedRowIndex < Entries.Count)
                        {
                            Entries[selectedRowIndex].BackColor = Color.FromArgb(209, 65, 26);
                        }
                        triggerDetail1.SetDetailedTrigger(trigsender.SelectedMember);
                        break;

                    case nameof(trigsender.Members):
                        RefreshParamList();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}