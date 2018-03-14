using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model.TRIGGERS
{
    [Serializable]
    public class IntervalTrigger : TriggerBase
    {
        private long interval;

        [DetailOrder(Position = 1)]
        public long Interval
        {
            get
            {
                return interval;
            }

            set
            {
                interval = value;
            }
        }
    }
}
