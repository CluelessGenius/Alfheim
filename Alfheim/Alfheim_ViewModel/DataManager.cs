using Alfheim_Model;
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
            List<Task> tasks = serializationhelper.DeSerialize(Properties.SettingsData.Default.Tasks);
            return tasks;
        }

    }
}
