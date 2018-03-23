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

            taskManager.Members.ForEach(m=>m.UpdateTriggerInfo(triggerManager.Members.Where(t => m.Triggers.Contains(t.ID)).ToList()));
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
                    case nameof(sendertrgr.TriggerType):
                        foreach (Task task in taskManager.Members.Where(t=>t.Triggers.Contains(sendertrgr.ID)))
                        {
                            task.UpdateTriggerInfo(triggerManager.Members.Where(t => task.Triggers.Contains(t.ID)).ToList());
                        }
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
                        foreach (Task task in taskManager.Members)
                        {
                            task.CleanUpTriggers(triggerManager.Members.Select(m => m.ID).ToArray());
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
            else if (sender is Task)
            {
                var sendertask = (sender as Task);
                switch (e.PropertyName)
                {
                    case nameof(sendertask.Triggers):
                        if (sendertask.Triggers != null)
                        {
                            sendertask.UpdateTriggerInfo(triggerManager.Members.Where(t=> sendertask.Triggers.Contains(t.ID)).ToList());
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