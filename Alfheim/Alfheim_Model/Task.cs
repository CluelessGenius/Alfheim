using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model
{
    [Serializable]
    public class Task: Param
    {
        private List<long> triggers;
        
        public List<ACTIONS.Action> Actions { get; set; }
        
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

        public void UpdateTriggers(TRIGGERS.Trigger trigger)
        {
            if (trigger.TriggerEnabled && !triggers.Contains(trigger.ID))
            {
                triggers.Add(trigger.ID);
                OnPropertyChanged(nameof(Triggers));
            }
            else if (!trigger.TriggerEnabled && triggers.Contains(trigger.ID))
            {
                triggers.Remove(trigger.ID);
                OnPropertyChanged(nameof(Triggers));
            }
        }
        
        private bool enabled;

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                if (value != enabled)
                {
                    enabled = value;
                    OnPropertyChanged(nameof(Enabled));
                }
                //if (enabled)
                //{
                //    ActivateTriggers();
                //}
            }
        }

        public List<long> Triggers
        {
            get
            {
                return triggers;
            }

            set
            {
                if (value != triggers)
                {
                    triggers = value;
                    OnPropertyChanged(nameof(Triggers));
                }
            }
        }

        //public void ActivateTriggers()
        //{
        //    if (Triggers!=null && Triggers.Any(t=>t.Enabled&&t.TriggerType==TRIGGERS.TriggerType.Static))
        //    {
        //        Active = true;
        //    }
        //}

        public Task(string name = "Dummy Task",string description = "", bool enabled = false)
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
            Enabled = false;
            Description = "";
            Triggers = new List<long>();
            Actions = new List<ACTIONS.Action>();
        }
    }
}
