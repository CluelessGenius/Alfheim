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
            triggerManager.OrderChanged += TriggerManager_OrderChanged;
            RefreshParamList();
        }

        private void TriggerManager_OrderChanged(object sender, EventArgs e)
        {
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
            triggerManager.Members.First(m => m.DisplayedPosition == Entries.IndexOf(sender as TriggerListEntry)).TriggerEnabled = (sender as TriggerListEntry).TriggerEnabled;
        }

        private void AddDragDropIndicator()
        {
            var tle = new DragDropIndicater();
            tle.Width = pnl_parameters.Width - 24;
            tle.Height = 3;
            tle.Margin = new Padding() { Top = 2, Bottom = 2, Left = 0, Right = 0 };
            pnl_parameters.Controls.Add(tle);
        }

        private void AddListEntry(Trigger trigger)
        {
            var tle = new TriggerListEntry(trigger);
            tle.SetToggleEnabled(areTogglesEnabled);
            tle.Width = pnl_parameters.Width - 24;
            tle.Clicked += Entry_Clicked;
            tle.Deleted += Entry_Deleted;
            tle.TriggerEnabledChanged += EntryEnabled_Changed;
            pnl_parameters.Controls.Add(tle);
        }

        private void RefreshParamList(int selectedindex = -1)
        {
            SuspendLayout();
            pnl_parameters.Controls.Clear();
            AddDragDropIndicator();
            foreach (Trigger trigger in triggerManager.Members.OrderBy(m=>m.DisplayedPosition))
            {
                AddListEntry(trigger);
                AddDragDropIndicator();
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
                        if (trigsender.SelectedMember != null)
                        {
                            selectedRowIndex = trigsender.SelectedMember.DisplayedPosition;
                            triggerDetail1.SetDetailedTrigger(trigsender.SelectedMember);
                        }
                        break;
                    case nameof(trigsender.Members):
                        RefreshParamList();
                        break;

                    default:
                        break;
                }
            }
        }

        private List<DragDropIndicater> Indicators { get { return pnl_parameters.Controls.OfType<DragDropIndicater>().ToList(); } }

        private static Color indicatorColor = Color.FromArgb(209, 65, 26);
        
        private void pnl_parameters_DragOver(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(typeof(TriggerListEntry));
            if (data == null)
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = DragDropEffects.Move;
            Point mouselocation = pnl_parameters.PointToClient(new Point(e.X, e.Y));
            var ini = Indicators.Select(i => Math.Abs(mouselocation.Y - i.Location.Y)).ToList();
            for (int i = 0; i < Indicators.Count; i++)
            {
                //Indicators[i].SetText(ini[i].ToString()+" | "+Indicators[i].Location.Y+" | "+mouselocation.Y);
                if (i == ini.IndexOf(ini.Min()))
                {
                    Indicators[i].BackColor = indicatorColor;
                }
                else
                {
                    Indicators[i].BackColor = Color.Transparent;
                }
            }
        }

        private void pnl_parameters_DragDrop(object sender, DragEventArgs e)
        {
            int index = Indicators.IndexOf(Indicators.First(ind => ind.BackColor == indicatorColor));
            for (int i = 0; i < Indicators.Count; i++)
            {
                Indicators[i].BackColor = Color.Transparent;
            }
            var d = (TriggerListEntry)e.Data.GetData(typeof(TriggerListEntry));
            int indexfrom = Entries.IndexOf(d);
            index = index > indexfrom ? Math.Max(0, index - 1) : index;
            triggerManager.Move(indexfrom, index);
        }

        private void pnl_parameters_DragLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < Indicators.Count; i++)
            {
                Indicators[i].BackColor = Color.Transparent;
            }
        }
    }
}