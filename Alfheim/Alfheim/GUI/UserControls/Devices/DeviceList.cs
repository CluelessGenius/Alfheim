using Alfheim_Model.DEVICES;
using Alfheim_ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class DeviceList : UserControl
    {
        public int selectedRowIndex = -1;
        private DataMemberManager<Device> deviceManager;

        public DeviceList()
        {
            InitializeComponent();
        }

        public List<DeviceListEntry> Entries
        {
            get
            {
                return pnl_parameters.Controls.OfType<DeviceListEntry>().ToList();
            }
        }

        public DataMemberManager<Device> DeviceManager
        {
            get
            {
                return deviceManager;
            }
        }

        public void SetDataManager(DataMemberManager<Device> devicemanager)
        {
            deviceManager = devicemanager;
            deviceManager.PropertyChanged += TriggerManager_PropertyChanged;
            deviceManager.OrderChanged += DeviceManager_OrderChanged;
            RefreshParamList();
        }

        private void DeviceManager_OrderChanged(object sender, EventArgs e)
        {
            var dict = sender as Dictionary<string, int>;
            if (dict["From"] == dict["To"])
            {
                return;
            }
            int indexto = pnl_parameters.Controls.IndexOf(Entries[dict["To"]]);
            if (dict["From"] < dict["To"])
            {
                pnl_parameters.Controls.SetChildIndex(Entries[dict["From"]], indexto + 1);
            }
            else
            {
                pnl_parameters.Controls.SetChildIndex(Entries[dict["From"]], indexto);
            }
            pnl_parameters.Controls.SetChildIndex(Indicators[dict["From"] + 1], indexto + 1);
        }

        public void SetTogglesEnabled(bool value)
        {
            areTogglesEnabled = value;
            foreach (DeviceListEntry entry in Entries)
            {
                entry.SetToggleEnabled(value);
            }
        }

        private bool areTogglesEnabled;
        
        private void EntryEnabled_Changed(object sender, EventArgs e)
        {
            deviceManager.Members.First(m => m.DisplayedPosition == Entries.IndexOf(sender as DeviceListEntry)).DeviceEnabled = (sender as DeviceListEntry).DeviceEnabled;
        }

        private void AddDragDropIndicator()
        {
            var tle = new DragDropIndicater();
            tle.Width = pnl_parameters.Width - 24;
            tle.Height = 3;
            tle.Margin = new Padding() { Top = 2, Bottom = 2, Left = 0, Right = 0 };
            pnl_parameters.Controls.Add(tle);
        }

        private void AddListEntry(Device device)
        {
            var tle = new DeviceListEntry(device);
            tle.SetToggleEnabled(areTogglesEnabled);
            tle.Width = pnl_parameters.Width - 24;
            tle.DeviceEnabledChanged += EntryEnabled_Changed;
            pnl_parameters.Controls.Add(tle);
            AddDragDropIndicator();
        }

        private void RefreshParamList(int selectedindex = -1)
        {
            SuspendLayout();
            pnl_parameters.Controls.Clear();
            AddDragDropIndicator();
            foreach (Device trigger in deviceManager.Members.OrderBy(m=>m.DisplayedPosition))
            {
                AddListEntry(trigger);
            }
            selectedRowIndex = selectedindex;
            ResumeLayout();
        }
        
        private void TriggerList_SizeChanged(object sender, EventArgs e)
        {
            pnl_parameters.SuspendLayout();
            foreach (Control ctrl in pnl_parameters.Controls)
            {
                ctrl.Width = pnl_parameters.Width - 24;
            }
            pnl_parameters.ResumeLayout();
            pnl_parameters.PerformLayout();
        }

        private void TriggerManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is DataMemberManager<Device>)
            {
                var trigsender = (sender as DataMemberManager<Device>);
                switch (e.PropertyName)
                {
                    case nameof(trigsender.SelectedMember):
                        if (trigsender.SelectedMember != null)
                        {
                            selectedRowIndex = trigsender.SelectedMember.DisplayedPosition;
                        }
                        break;
                    case nameof(trigsender.Members):
                        //RefreshParamList();
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
            var d = (DeviceListEntry)e.Data.GetData(typeof(DeviceListEntry));
            int indexfrom = Entries.IndexOf(d);
            index = index > indexfrom ? Math.Max(0, index - 1) : index;
            deviceManager.Move(indexfrom, index);
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