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
    public partial class ParamNumericEdit : UserControl
    {
        string propertyname = "";

        public ParamNumericEdit(string name, long value)
        {
            InitializeComponent();
            propertyname = name;
            lbl_name.Text = name.Split('.').Last();
            numericUpDown1.Value = value;
        }

        public event EventHandler<ValuechangedEventArgs> NumberChanged;
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (NumberChanged == null)
            {
                return;
            }
            NumberChanged(this, new ValuechangedEventArgs()
            {
                NewValue = (long)(sender as NumericUpDown).Value,
                OldValue = null,
                Property = propertyname
            });
        }
    }
    
}
