using Alfheim_Model.TRIGGERS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void CleanUpTriggers(long[] allpossibletriggerIDs)
        {
            long[] garbageIDs = triggers.Where(t => !allpossibletriggerIDs.Contains(t)).ToArray();
            for (int i = 0; i < garbageIDs.Length; i++)
            {
                triggers.Remove(garbageIDs[i]);
            }
            if (garbageIDs.Length > 0)
            {
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

        [JsonIgnore]
        [IgnoreWhenSaving]
        public List<TriggerInfo> TriggerInfos
        {
            get
            {
                return triggerInfos;
            }

            private set
            {
                triggerInfos = value;
                OnPropertyChanged(nameof(TriggerInfos));
            }
        }

        private List<TriggerInfo> triggerInfos;

        public void UpdateTriggerInfo(List<Trigger> infos)
        {
            TriggerInfos = infos.Select(i => new TriggerInfo() { ID=i.ID,Icon=i.Trig.Icon,Name=i.Name,Type=i.Trig.GetType() }).ToList();
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
            Name = "new Task";
            Enabled = false;
            Description = "text describing the task and its purpose";
            Triggers = new List<long>();
            Actions = new List<ACTIONS.Action>();
        }
    }

    public class TriggerInfo
    {
        public long ID;
        public string Name;
        public Type Type;
        public Bitmap Icon;

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
