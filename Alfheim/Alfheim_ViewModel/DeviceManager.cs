using Alfheim_Model.DEVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_ViewModel
{
    public static class DeviceManager
    {
        public static List<Device> GetAvailableDevices()
        {
            Properties.SettingsData.Default.MaxID += 1;
            Properties.SettingsData.Default.Save();
            return new List<Device>() { { new Motherboard() { Name = "ASUS Z270I Strix", ID= Properties.SettingsData.Default.MaxID, HardwareHASH="ASUSTRXZ270I" } } };
        }
    }
}
