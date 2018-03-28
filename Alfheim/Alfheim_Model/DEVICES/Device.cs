using Alfheim_Model.TRIGGERS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model.DEVICES
{
    public class Device : Param
    {
        private string hardwareHASH;

        private List<LED> lEDs;

        public List<LED> LEDs
        {
            get
            {
                return lEDs;
            }

            set
            {
                lEDs = value;
            }
        }

        [JsonIgnore]
        [IgnoreWhenSaving]
        public bool DeviceEnabled
        {
            get
            {
                return deviceEnabled;
            }

            set
            {
                if (value != deviceEnabled)
                {
                    deviceEnabled = value;
                    OnPropertyChanged(nameof(DeviceEnabled));
                }
            }
        }

        public string HardwareHASH
        {
            get
            {
                return hardwareHASH;
            }

            set
            {
                hardwareHASH = value;
            }
        }

        private bool deviceEnabled;

    }
}
