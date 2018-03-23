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
    public class StaticTrigger : ITrigger
    {
        public StaticTrigger()
        {
            icon = Properties.Resources.icons8_aktiver_zustand_64;
        }
    }
}
