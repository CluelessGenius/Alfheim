using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model.TRIGGERS
{
    [JsonObject]
    [Serializable]
    public class AppointmentTrigger : ITrigger
    {
        private DateTime appointment = DateTime.Now;

        [DetailOrder(Position = 1)]
        [JsonProperty("Appointment")]
        public DateTime Appointment
        {
            get
            {
                return appointment;
            }

            set
            {
                appointment = value;
            }
        }
    }
}
