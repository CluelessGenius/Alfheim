using Alfheim_Model;
using Alfheim_Model.EFFECTS;
using Alfheim_Model.TRIGGERS;
using Alfheim_Model.DEVICES;
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel;

namespace Alfheim_ViewModel
{
    public class DataManager
    {
        private DataMemberManager<Effect> effectManager;
        private DataMemberManager<DevicePreset> devicePresetManager;
        private DataMemberManager<Device> deviceManager;
        private DataMemberManager<Task> taskManager;
        private DataMemberManager<Trigger> triggerManager;
        public DataManager()
        {
            taskManager = new DataMemberManager<Task>();
            taskManager.PropertyChanged += TaskManager_PropertyChanged;
            triggerManager = new DataMemberManager<Trigger>();
            triggerManager.PropertyChanged += TriggerManager_PropertyChanged;
            effectManager = new DataMemberManager<Effect>();
            DevicePresetManager = new DataMemberManager<DevicePreset>();
            DevicePresetManager.PropertyChanged += DevicePresetManager_PropertyChanged;
            DevicesManager = new DataMemberManager<Device>();
            DevicesManager.SetMembers(DeviceManager.GetAvailableDevices());
            DevicesManager.PropertyChanged += DeviceManager_PropertyChanged;

            taskManager.Members.ForEach(m=>m.UpdateTriggerInfo(triggerManager.Members.Where(t => m.Triggers.Contains(t.ID)).ToList()));
        }

        private void DeviceManager_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Device)
            {
                var sendertrgr = (sender as Device);
                switch (e.PropertyName)
                {
                    case nameof(sendertrgr.DeviceEnabled):
                        devicePresetManager.SelectedMember?.UpdateDevices(sendertrgr);
                        taskManager.SelectedMember?.UpdateTriggers(sendertrgr);
                        break;
                    default:
                        break;
                }
            }
        }

        private void DevicePresetManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
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

        public DataMemberManager<DevicePreset> DevicePresetManager
        {
            get
            {
                return devicePresetManager;
            }

            set
            {
                devicePresetManager = value;
            }
        }

        public DataMemberManager<Device> DevicesManager
        {
            get
            {
                return deviceManager;
            }

            set
            {
                deviceManager = value;
            }
        }
    }
}