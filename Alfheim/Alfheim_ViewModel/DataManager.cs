using Alfheim_Model;
using Alfheim_Model.EFFECTS;
using Alfheim_Model.TRIGGERS;
using System.Collections.Generic;

namespace Alfheim_ViewModel
{
    public class DataManager
    {
        private DataMemberManager<Effect> effectManager;
        private DataMemberManager<Task> taskManager;
        private DataMemberManager<Trigger> triggerManager;
        public DataManager()
        {
            taskManager = new DataMemberManager<Task>();
            triggerManager = new DataMemberManager<Trigger>();
            effectManager = new DataMemberManager<Effect>();
        }

        public DataMemberManager<Effect> EffectManager
        {
            get
            {
                return effectManager;
            }
        }
        
        public DataMemberManager<Task> TaskManager
        {
            get
            {
                return taskManager;
            }
        }
        
        public DataMemberManager<Trigger> TriggerManager
        {
            get
            {
                return triggerManager;
            }
        }
        
    }
}