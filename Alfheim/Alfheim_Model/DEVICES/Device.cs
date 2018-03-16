using Alfheim_Model.TRIGGERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model.DEVICES
{
    public class Device : Param
    {
        private List<LED> lEDs;

        internal List<LED> LEDs
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
    }
}
