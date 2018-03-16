using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model.ACTIONS
{
    public class Action : Param
    {
        public DEVICES.Device Device { get; set; }

        public EFFECTS.Effect Effect { get; set; }
    }
}
