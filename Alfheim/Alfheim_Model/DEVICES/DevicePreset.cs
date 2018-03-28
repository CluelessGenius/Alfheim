using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model.DEVICES
{
    public class DevicePreset : Param
    {
        List<DEVICES.Device> devices;

        public List<Device> Devices
        {
            get
            {
                return devices;
            }

            set
            {
                devices = value;
            }
        }
    }
}
