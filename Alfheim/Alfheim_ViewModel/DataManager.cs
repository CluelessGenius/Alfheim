using Alfheim_Model;
using Alfheim_Model.EFFECTS;
using Alfheim_Model.TRIGGERS;
using System.Collections.Generic;
using System.Linq;

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
            taskManager.PropertyChanged += TaskManager_PropertyChanged;
            triggerManager = new DataMemberManager<Trigger>();
            triggerManager.PropertyChanged += TriggerManager_PropertyChanged;
            effectManager = new DataMemberManager<Effect>();
        }

        private void TriggerManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is Trigger)
            {
                var sendertrgr = (sender as Trigger);
                switch (e.PropertyName)
                {
                    case nameof(sendertrgr.TriggerEnabled):
                        taskManager.SelectedMember?.UpdateTriggers(sendertrgr);
                        break;
                    default:
                        break;
                }
            }
            if (sender is DataMemberManager<Trigger>)
            {
                var sendertrgr = (sender as DataMemberManager<Trigger>);
                switch (e.PropertyName)
                {
                    case nameof(sendertrgr.Members):
                        if (taskManager.SelectedMember != null)
                        {
                            long[] missingids = taskManager.SelectedMember.Triggers.Where(t => !triggerManager.Members.Select(m => m.ID).Contains(t)).ToArray();
                            for (int i = 0; i < missingids.Length; i++)
                            {
                                taskManager.SelectedMember.Triggers.Remove(missingids[i]);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void TaskManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is DataMemberManager<Task>)
            {
                var sendertaskmgr = (sender as DataMemberManager<Task>);
                switch (e.PropertyName)
                {
                    case nameof(sendertaskmgr.SelectedMember):
                        if (sendertaskmgr.SelectedMember == null)
                        {
                            foreach (Trigger trigg in triggerManager.Members)
                            {
                                trigg.TriggerEnabled = false;
                            }
                        }
                        else
                        {
                            foreach (Trigger trigg in triggerManager.Members)
                            {
                                trigg.TriggerEnabled = sendertaskmgr.SelectedMember.Triggers.Contains(trigg.ID);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public DataMemberManager<Effect> EffectManager
        {
            get
            {
                return effectManager;
            }
            set
            {
                effectManager = value;
            }
        }
        
        public DataMemberManager<Task> TaskManager
        {
            get
            {
                return taskManager;
            }
            set
            {
                taskManager = value;
            }
        }
        
        public DataMemberManager<Trigger> TriggerManager
        {
            get
            {
                return triggerManager;
            }
            set
            {
                triggerManager = value;
            }
        }
        
    }
}