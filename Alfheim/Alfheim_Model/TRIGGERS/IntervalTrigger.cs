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
    public class IntervalTrigger : ITrigger
    {
        private long interval;
        
        [DetailOrder(Position = 1)]
        [JsonProperty("Interval")]
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
