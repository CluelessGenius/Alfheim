﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model.TRIGGERS
{
    [Serializable]
    public class AppointmentTrigger : TriggerBase
    {
        private DateTime appointment = DateTime.Now;

        [DetailOrder(Position = 1)]
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
