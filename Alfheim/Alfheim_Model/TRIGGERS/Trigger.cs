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
                if (triggerType != value)
                {
                    triggerType = value;
                    switch (triggerType)
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
                    Trig.PropertyChanged += Trig_PropertyChanged;
                    OnPropertyChanged(nameof(TriggerType));
                }
            }
        }

        [DetailOrder(Position = 2)]
        [JsonProperty("Trig", Order = 2)]
        public ITrigger Trig
        {
            get
            {
                if (trig==null)
                {
                    switch (triggerType)
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
                    Trig.PropertyChanged += Trig_PropertyChanged;
                }
                return trig;
            }

            private set
            {
                if (value != trig)
                {
                    trig = value;
                }
            }
        }

        private void Trig_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(e.PropertyName,sender);
        }

        [JsonIgnore]
        [IgnoreWhenSaving]
        public bool TriggerEnabled
        {
            get
            {
                return triggerEnabled;
            }

            set
            {
                if (value != triggerEnabled)
                {
                    triggerEnabled = value;
                    OnPropertyChanged(nameof(TriggerEnabled));
                }
            }
        }

        private bool triggerEnabled;
        
    }
}
