using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfheim_Model
{
    [JsonObject]
    [Serializable]
    public class Param : INotifyPropertyChanged
    {
        private long iD;

        [JsonProperty(nameof(ID), Order = 1)]
        public long ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        private string name;

        [DetailOrder(Position = 0)]
        [JsonProperty(nameof(Name),Order = 2)]
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string property, object sender = null)
        {
            if (PropertyChanged != null)
            {
                sender = sender == null ? this : sender;
                PropertyChanged(sender, new PropertyChangedEventArgs(property));
            }
        }

    }
}
