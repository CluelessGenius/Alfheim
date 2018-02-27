using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model.TRIGGERS
{
    [Serializable]
    public class Trigger : Param
    {
        [DetailOrder(Position = 1)]
        public TriggerType TriggerType { get; set; }
    }

    public enum TriggerType
    {
        Static,
        Interval,
        External,
        Appointment
    }

}
