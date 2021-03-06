﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alfheim_Model.TRIGGERS
{
    [JsonObject]
    [Serializable]
    public class ITrigger : INotifyPropertyChanged
    {
        [JsonIgnore]
        [IgnoreWhenSaving]
        public Bitmap Icon
        {
            get
            {
                return icon;
            }
        }
        
        protected Bitmap icon;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string property, object sender=null)
        {
            if (PropertyChanged != null)
            {
                sender = sender == null ? this : sender;
                PropertyChanged(sender, new PropertyChangedEventArgs(property));
            }
        }
    }
}
