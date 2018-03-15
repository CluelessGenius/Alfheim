using Alfheim_Model;
using Alfheim_Model.TRIGGERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alfheim_ViewModel
{
    public class DataManager
    {
        SerializationHelper serializationhelper = new SerializationHelper();

        public void SaveTasks(List<Task> tasks)
        {
            string xmltasks = serializationhelper.Serialize(tasks);
            Properties.SettingsData.Default.Tasks = xmltasks;
            Properties.SettingsData.Default.Save();
        }

        public List<Task> LoadTasks()
        {
            List<Task> tasks;
            serializationhelper.DeSerialize(Properties.SettingsData.Default.Tasks,out tasks);
            return tasks;
        }

        public void SaveTriggers(List<Trigger> triggers)
        {
            string xmltriggers = serializationhelper.Serialize(triggers);
            Properties.SettingsData.Default.Triggers = xmltriggers;
            Properties.SettingsData.Default.Save();
        }

        public List<Trigger> LoadTriggers()
        {
            List<Trigger> triggers;
            serializationhelper.DeSerialize(Properties.SettingsData.Default.Triggers, out triggers);
            return triggers;
        }

    }
}
