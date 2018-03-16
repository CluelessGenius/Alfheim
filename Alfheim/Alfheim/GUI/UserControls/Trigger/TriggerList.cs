using Alfheim_Model.TRIGGERS;
using Alfheim_ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TriggerList : UserControl
    {
        public int selectedRowIndex = -1;
        DataManager dataManager;
        private bool enablingEnabled;
        public TriggerList()
        {
            InitializeComponent();
            EnablingEnabled = false;
            triggerDetail1.ValueChanged += TriggerDetail1_ValueChanged;
        }

        public DataManager DataManager
        {
            get
            {
                return dataManager;
            }
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

        

        public void SetDataManager(ref DataManager datamanager)
        {
            dataManager = datamanager;
            RefreshParamList();
        }

        public void SetToggles(List<long> IDs)
        {
            foreach (TriggerListEntry entry in pnl_parameters.Controls)
            {
                entry.ToggleEnabled = IDs.Contains(entry.Param.ID);
            }
        }

        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            dataManager.TriggerManager.Create();
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
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            pnl_parameters.Controls.Remove((sender as TriggerListEntry));
            triggerDetail1.DetailedTrigger = null;
        }

        private void TriggerDetail1_ValueChanged(object sender, ValuechangedEventArgs e)
        {
            string[] proppath = e.Property.Split('.');
            object objecttochange = dataManager.TriggerManager.Members.Single(t=>t.ID==e.ID);
            for (int i = 1; i < proppath.Length; i++)
            {
                objecttochange = objecttochange.GetType().GetProperty(proppath[i - 1]).GetValue(objecttochange);
            }
            objecttochange.GetType().GetProperty(proppath.Last()).SetValue(objecttochange, e.NewValue);
        }

        private void RefreshParamList(int selectedindex = -1)
        {
            SuspendLayout();
            pnl_parameters.Controls.Clear();
            List<TriggerListEntry> entrycontrols = dataManager.TriggerManager.Members.Select(t => (new TriggerListEntry(t))).ToList();
            entrycontrols.ForEach(e =>
            {
                e.Width = pnl_parameters.Width - 24;
                e.Clicked += Entry_Clicked;
                e.Deleted += Entry_Deleted;
                //e.EnabledToggleChanged += EntryEnabled_Changed;
                e.EnablingPossible = enablingEnabled;
                pnl_parameters.Controls.Add(e);
            });
            selectedRowIndex = selectedindex;
            try
            {
                (pnl_parameters.Controls[selectedRowIndex] as TriggerListEntry).BackColor = Color.FromArgb(209, 65, 26);
            }
            catch (Exception) { }
            dataManager.TriggerManager.Select(selectedRowIndex);
            ResumeLayout();
        }
    }
}