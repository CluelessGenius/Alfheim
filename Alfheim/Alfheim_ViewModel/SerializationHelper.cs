using Alfheim_Model;
using Alfheim_Model.TRIGGERS;
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

        public void DeSerialize(string xmltasks, out List<Task> list)
        {
            if (String.IsNullOrEmpty(xmltasks))
            {
                list = new List<Task>();
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));
            
            using (var sww = new StringReader(xmltasks))
            {
                using (XmlReader reader = XmlReader.Create(sww))
                {

                    list = serializer.Deserialize(reader) as List<Task>;
                }
            }
        }

        public string Serialize(List<Trigger> triggers)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Trigger>));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    serializer.Serialize(writer, triggers);
                    xml = sww.ToString(); // Your XML
                }
            }

            return xml;
        }

        public void DeSerialize(string xmltriggers, out List<Trigger> list)
        {
            if (String.IsNullOrEmpty(xmltriggers))
            {
                list = new List<Trigger>();
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Trigger>));
            

            using (var sww = new StringReader(xmltriggers))
            {
                using (XmlReader reader = XmlReader.Create(sww))
                {

                    list = serializer.Deserialize(reader) as List<Trigger>;
                }
            }
        }
    }
}
