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

        public ParamDateTimeEdit(string name, DateTime value)
        {
            InitializeComponent();
            propertyname = name;
            dateTimePicker1.CustomFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
            dateTimePicker1.Value = value;
        }

        public event EventHandler<ValuechangedEventArgs> DateTimeChanged;
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimeChanged == null)
            {
                return;
            }
            DateTimeChanged(this, new ValuechangedEventArgs()
            {
                NewValue = (sender as DateTimePicker).Value,
                OldValue = null,
                Property = propertyname
            });
        }
    }
    
}
