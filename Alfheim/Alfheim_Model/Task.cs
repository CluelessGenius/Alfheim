using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model
{
    public class Task
    {
        public List<TRIGGERS.Trigger> Triggers { get; set; }

        public List<DEVICES.Device> Devices { get; set; }

        public List<ACTIONS.Action> Actions { get; set; }

        public string Name { get; set; }

        public bool Enabled { get; set; }

        public Task(string name = "Dummy Task", bool enabled = true)
        {
            Name = name;
            Enabled = enabled;
            Triggers = new List<TRIGGERS.Trigger>();
            Devices = new List<DEVICES.Device>();
            Actions = new List<ACTIONS.Action>();
        }
    }
}
