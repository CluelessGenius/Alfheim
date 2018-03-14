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
        
        private TriggerType triggerType;

        [DetailOrder(Position = 1)]
        public TriggerType TriggerType
        {
            get
            {
                return triggerType;
            }

            set
            {
                triggerType = value;
                switch (value)
                {
                    case TriggerType.Static:
                        Trig = new StaticTrigger();
                        break;
                    case TriggerType.Interval:
                        Trig = new IntervalTrigger();
                        break;
                    case TriggerType.External:
                        Trig = new ExternalTrigger();
                        break;
                    case TriggerType.Appointment:
                        Trig = new AppointmentTrigger();
                        break;
                    default:
                        break;
                }
            }
        }

        [DetailOrder(Position = 2)]
        public TriggerBase Trig
        {
            get
            {
                return trig;
            }

            set
            {
                trig = value;
            }
        }

        private TriggerBase trig;
    }

    public enum TriggerType
    {
        Static,
        Interval,
        External,
        Appointment
    }

}
