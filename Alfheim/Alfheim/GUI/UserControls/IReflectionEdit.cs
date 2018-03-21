using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public class IReflectionEdit : UserControl
    {
        string propertyname;

        public string Propertyname
        {
            get
            {
                return propertyname;
            }

            set
            {
                propertyname = value;
            }
        }

        public event EventHandler<PropertyChangedEventArgs> PropertyValueChanged;

        object propertyValue;

        public object PropertyValue
        {
            get
            {
                return propertyValue;
            }

            set
            {
                propertyValue = value;
                if (PropertyValueChanged != null)
                {
                    PropertyValueChanged(this, new PropertyChangedEventArgs(nameof(PropertyValue)));
                }
            }
        }
    }
}
