using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class ParamDateTimeEdit : IReflectionEdit
    {
        public ParamDateTimeEdit(string name, DateTime value, long id)
        {
            InitializeComponent();
            Propertyname = name;
            PropertyValue = value;
            dateTimePicker1.Value = value;
            dateTimePicker2.Value = value;
            iD = id;
        }
        
        long iD;

        public event EventHandler<ValuechangedEventArgs> DateTimeChanged;
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PropertyValue = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;
            if (DateTimeChanged == null)
            {
                return;
            }
            DateTimeChanged(this, new ValuechangedEventArgs()
            {
                NewValue = PropertyValue,
                OldValue = null,
                Property = Propertyname,
                ID = iD
            });
        }
        
    }
    
}
