using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alfheim_Model.TRIGGERS
{
    [XmlInclude(typeof(IntervalTrigger))]
    [XmlInclude(typeof(StaticTrigger))]
    [XmlInclude(typeof(AppointmentTrigger))]
    [XmlInclude(typeof(ExternalTrigger))]
    [Serializable]
    public class TriggerBase
    {

    }
}
