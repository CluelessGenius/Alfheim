using Alfheim_Model.DEVICES;
using Alfheim_ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class DevicePresetList : UserControl
    {
        public int selectedRowIndex = -1;
        private DataMemberManager<DevicePreset> devicePresetManager;

        public DevicePresetList()
        {
            InitializeComponent();
        }

        public List<DevicePresetListEntry> Entries
        {
            get
            {
                return pnl_parameters.Controls.OfType<DevicePresetListEntry>().ToList();
            }
        }

        public DataMemberManager<DevicePreset> DevicePresetManager
        {
            get
            {
                return devicePresetManager;
            }
        }

        public void SetDataManager(DataMemberManager<DevicePreset> devicepresetmanager, DataMemberManager<Device> devicemanager)
        {
            devicePresetManager = devicepresetmanager;
            devicePresetManager.PropertyChanged += DevicesManager_PropertyChanged;
            devicePresetManager.OrderChanged += DevicesManager_OrderChanged;
            RefreshParamList();
            deviceList1.SetDataManager(devicemanager);
        }

        public void SetTogglesEnabled(bool value)
        {
            deviceList1.SetTogglesEnabled(value);
        }
        
        private void DevicesManager_OrderChanged(object sender, EventArgs e)
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
        
        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            devicePresetManager.Create();
            AddListEntry(devicePresetManager.Members.OrderByDescending(m => m.ID).First());
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            devicePresetManager.Select(Entries.IndexOf(sender as DevicePresetListEntry));
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            devicePresetManager.Delete(Entries.IndexOf(sender as DevicePresetListEntry));
            int index = pnl_parameters.Controls.IndexOf(sender as DevicePresetListEntry);
            pnl_parameters.Controls.RemoveAt(index);
            pnl_parameters.Controls.RemoveAt(index);
        }
        
        private void AddDragDropIndicator()
        {
            var tle = new DragDropIndicater();
            tle.Width = pnl_parameters.Width - 24;
            tle.Height = 3;
            tle.Margin = new Padding() { Top = 2, Bottom = 2, Left = 0, Right = 0 };
            pnl_parameters.Controls.Add(tle);
        }

        private void AddListEntry(DevicePreset preset)
        {
            var tle = new DevicePresetListEntry(preset);
            tle.Width = pnl_parameters.Width - 24;
            tle.Clicked += Entry_Clicked;
            tle.Deleted += Entry_Deleted;
            tle.NameChanged += Tle_NameChanged;
            pnl_parameters.Controls.Add(tle);
            AddDragDropIndicator();
        }

        private void Tle_NameChanged(object sender, ValuechangedEventArgs e)
        {
            devicePresetManager.Members.First(m => m.DisplayedPosition == Entries.IndexOf(sender as DevicePresetListEntry)).Name = e.NewValue.ToString();
        }

        private void RefreshParamList(int selectedindex = -1)
        {
            SuspendLayout();
            pnl_parameters.Controls.Clear();
            AddDragDropIndicator();
            foreach (DevicePreset preset in devicePresetManager.Members.OrderBy(m=>m.DisplayedPosition))
            {
                AddListEntry(preset);
            }
            selectedRowIndex = selectedindex;
            ResumeLayout();
        }
        
        private void DevicePresetList_SizeChanged(object sender, EventArgs e)
        {
            pnl_parameters.SuspendLayout();
            foreach (Control ctrl in pnl_parameters.Controls)
            {
                ctrl.Width = pnl_parameters.Width - 24;
            }
            pnl_parameters.ResumeLayout();
            pnl_parameters.PerformLayout();
        }

        private void DevicesManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is DataMemberManager<DevicePreset>)
            {
                var trigsender = (sender as DataMemberManager<DevicePreset>);
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
            var data = e.Data.GetData(typeof(DevicePresetListEntry));
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
            var d = (DevicePresetListEntry)e.Data.GetData(typeof(DevicePresetListEntry));
            int indexfrom = Entries.IndexOf(d);
            index = index > indexfrom ? Math.Max(0, index - 1) : index;
            devicePresetManager.Move(indexfrom, index);
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