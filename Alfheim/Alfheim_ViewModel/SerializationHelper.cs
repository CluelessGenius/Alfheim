using Alfheim_Model;
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
            XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    serializer.Serialize(writer, tasks);
                    xml = sww.ToString(); // Your XML
                }
            }

            return xml;
        }

        public List<Task> DeSerialize(string xmltasks)
        {
            if (String.IsNullOrEmpty(xmltasks))
            {
                return new List<Task>();
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));
            List<Task> list;

            using (var sww = new StringReader(xmltasks))
            {
                using (XmlReader reader = XmlReader.Create(sww))
                {

                    list = serializer.Deserialize(reader) as List<Task>;
                }
            }

            return list;
        }
    }
}
