using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model
{
    public class Task
    {
        public List<long> Triggers { get; set; }
        
        public List<ACTIONS.Action> Actions { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        private bool active;

        public bool Active
        {
            get { return active; }
            set
            {
                active = value;
                if (active)
                {
                    DoAction();
                }
            }
        }

        public void DoAction()
        {

        }

        private bool enabled;

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                enabled = value;
                //if (enabled)
                //{
                //    ActivateTriggers();
                //}
            }
        }
        
        //public void ActivateTriggers()
        //{
        //    if (Triggers!=null && Triggers.Any(t=>t.Enabled&&t.TriggerType==TRIGGERS.TriggerType.Static))
        //    {
        //        Active = true;
        //    }
        //}

        public Task(string name = "Dummy Task",string description = "", bool enabled = true)
        {
            Name = name;
            Enabled = enabled;
            Description = description;
            Triggers = new List<long>();
            Actions = new List<ACTIONS.Action>();
        }

        public Task()
        {
            Name = "Dummy Task";
            Enabled = true;
            Description = "";
            Triggers = new List<long>();
            Actions = new List<ACTIONS.Action>();
        }
    }
}
