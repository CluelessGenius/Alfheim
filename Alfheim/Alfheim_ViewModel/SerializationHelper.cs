using Alfheim_Model;
using Alfheim_Model.TRIGGERS;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Alfheim_ViewModel
{
    public class SerializationHelper
    {
        public string Serialize(List<Task> tasks)
        {
            return JsonConvert.SerializeObject(tasks);
        }

        public void DeSerialize(string xmltasks, out List<Task> list)
        {
            if (String.IsNullOrEmpty(xmltasks))
            {
                list = new List<Task>();
                return;
            }
            list = JsonConvert.DeserializeObject<List<Task>>(xmltasks);
        }

        public string Serialize(List<Trigger> triggers)
        {
            return JsonConvert.SerializeObject(triggers);
        }

        public void DeSerialize(string xmltriggers, out List<Trigger> list)
        {
            if (String.IsNullOrEmpty(xmltriggers))
            {
                list = new List<Trigger>();
                return;
            }
            list = JsonConvert.DeserializeObject<List<Trigger>>(xmltriggers);
        }
        
    }
}
