using Alfheim_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Alfheim_ViewModel
{
    public class DataMemberManager<T> : INotifyPropertyChanged where T : Param, new()
    {
        private List<T> members;

        private int selectedIndex = -1;

        private SerializationHelper serializationhelper;

        public DataMemberManager()
        {
            members = new List<T>();
            serializationhelper = new SerializationHelper();
            Load();
        }

        private void DataMember_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(sender, e);
            if (!sender.GetType().GetProperty(e.PropertyName).CustomAttributes.Any(a => a.AttributeType == typeof(IgnoreWhenSaving)))
            {
                Save();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(sender, e);
        }

        public List<T> Members
        {
            get
            {
                return members;
            }
        }

        [IgnoreWhenSaving]
        public T SelectedMember
        {
            get
            {
                return members.FirstOrDefault(m => m.IsSelected == true);
            }

            set
            {
                var mem = members.FirstOrDefault(m => m.IsSelected == true);
                mem = value;
            }
        }

        public void Create(string name = "")
        {
            if (String.IsNullOrEmpty(name))
            {
                name = "new "+typeof(T).Name;
            }
            Properties.SettingsData.Default.MaxID += 1;
            Properties.SettingsData.Default.Save();
            T newT = new T() { ID = Properties.SettingsData.Default.MaxID,
                               Name = name};
            newT.PropertyChanged += DataMember_PropertyChanged;
            newT.DisplayedPosition = members.Count==0?0:members.Select(m=>m.DisplayedPosition).Max()+1;
            members.Add(newT);
            OnPropertyChanged(this, new PropertyChangedEventArgs(nameof(Members)));
            Save();
        }

        public void Delete(int index)
        {
            var mem = members.First(m => m.DisplayedPosition == index);
            members.Remove(mem);
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].DisplayedPosition>index)
                {
                    members[i].DisplayedPosition--;
                }
            }
            OnPropertyChanged(this, new PropertyChangedEventArgs(nameof(Members)));
            if (index==selectedIndex)
            {
                Select(-1);
            }
            Save();
        }

        public void Select(int index)
        {
            for (int i = 0; i < members.Count; i++)
            {
                members[i].IsSelected = members[i].DisplayedPosition == index;
            }
            selectedIndex = index;
            OnPropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedMember)));
        }

        public event EventHandler OrderChanged;

        public void Move(int indexFrom, int indexTo)
        {
            List<long> ids = members.OrderBy(m => m.DisplayedPosition).Select(mem => mem.ID).ToList();

            long item = ids[indexFrom];
            ids.RemoveAt(indexFrom);
            ids.Insert(indexTo, item);
            
            for (int i = 0; i < members.Count; i++)
            {
                members[i].DisplayedPosition = ids.IndexOf(members[i].ID);
            }
            if (OrderChanged!=null)
            {
                OrderChanged(new Dictionary<string, int>() { { "From",indexFrom }, { "To", indexTo } },EventArgs.Empty);
            }
            Save();
            //Select(indexTo);
        }

        private void Load()
        {
            List<T> list = new List<T>();
            serializationhelper.DeSerialize(Properties.SettingsData.Default.GetType().GetProperty(typeof(T).Name + "s").GetValue(Properties.SettingsData.Default).ToString(), out list);
            members.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].PropertyChanged += DataMember_PropertyChanged;
                members.Add(list[i]);
            }
        }

        private void Save()
        {
            string xmllist = serializationhelper.Serialize(members);
            Properties.SettingsData.Default.GetType().GetProperty(typeof(T).Name + "s").SetValue(Properties.SettingsData.Default, xmllist);
            Properties.SettingsData.Default.Save();
            Debug.WriteLine(typeof(T).Name + "s have been saved!");
        }
        
    }
}