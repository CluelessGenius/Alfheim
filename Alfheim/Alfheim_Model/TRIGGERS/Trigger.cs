using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alfheim_Model.TRIGGERS
{
    public enum TriggerType
    {
        Static,
        Interval,
        External,
        Appointment
    }

    [JsonObject]
    [Serializable]
    public class Trigger : Param
    {
        private ITrigger trig;

        private TriggerType triggerType;
        
        [DetailOrder(Position = 1)]
        [JsonProperty("TriggerType", Order = 1)]
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
        [JsonProperty("Trig", Order = 2)]
        public ITrigger Trig
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
    }
}
