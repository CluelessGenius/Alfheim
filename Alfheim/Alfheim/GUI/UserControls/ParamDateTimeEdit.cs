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
    public partial class ParamDateTimeEdit : UserControl
    {
        string propertyname = "";

        public ParamDateTimeEdit(string name, DateTime value, long id)
        {
            InitializeComponent();
            propertyname = name;
            dateTimePicker1.Value = value;
            dateTimePicker2.Value = value;
            iD = id;
        }

        long iD;

        public event EventHandler<ValuechangedEventArgs> DateTimeChanged;
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimeChanged == null)
            {
                return;
            }
            DateTimeChanged(this, new ValuechangedEventArgs()
            {
                NewValue = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay,
                OldValue = null,
                Property = propertyname,
                ID = iD
            });
        }
        
    }
    
}
