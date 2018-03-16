using Alfheim_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;

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
            Save();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public List<T> Members
        {
            get
            {
                return members;
            }
        }

        public T SelectedMember
        {
            get
            {
                try
                {
                    return members[selectedIndex];
                }
                catch (System.Exception)
                {
                    return null;
                }
            }
        }

        public void Create()
        {
            Properties.SettingsData.Default.MaxID += 1;
            Properties.SettingsData.Default.Save();
            T newT = new T() { ID = Properties.SettingsData.Default.MaxID };
            newT.PropertyChanged += DataMember_PropertyChanged;
            members.Add(newT);
            Save();
        }

        public void Delete(int index)
        {
            members.RemoveAt(index);
            Save();
        }

        public void Select(int index)
        {
            selectedIndex = index;
            try
            {
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedMember"));
            }
            catch (Exception) { }
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
        }
        
    }
}