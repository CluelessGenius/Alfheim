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
    public partial class ParamNumericEdit : IReflectionEdit
    {
        public ParamNumericEdit(string name, long value, long id)
        {
            InitializeComponent();
            Propertyname = name;
            PropertyValue = value;
            lbl_name.Text = name.Split('.').Last();
            numericUpDown1.Value = (long)PropertyValue;
            iD = id;
        }
        
        long iD;

        public event EventHandler<ValuechangedEventArgs> NumberChanged;
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PropertyValue = (long)numericUpDown1.Value;
            if (NumberChanged == null)
            {
                return;
            }
            
            NumberChanged(this, new ValuechangedEventArgs()
            {
                NewValue = PropertyValue,
                OldValue = null,
                Property = Propertyname,
                ID = iD
            });
        }

        char[] allowedchars = new char[] { '\b', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!allowedchars.Contains(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            // HACK: Doing this will cause the numericUpDown to update it's value attribute if the user 
            // types in something (rather than clicking the up/down buttons)
            decimal i = numericUpDown1.Value;
        }
    }
    
}
