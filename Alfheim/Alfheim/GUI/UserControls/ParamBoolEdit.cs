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
    public partial class ParamBoolEdit : IReflectionEdit
    {
        public ParamBoolEdit(string name, bool value, long id)
        {
            InitializeComponent();
            Propertyname = name;
            PropertyValue = value;
            lbl_name.Text = name.Split('.').Last();
            metroToggle1.Checked = (bool)PropertyValue;
            iD = id;
        }
        
        long iD;

        public event EventHandler<ValuechangedEventArgs> BoolChanged;

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            PropertyValue = metroToggle1.Checked;
            if (BoolChanged == null)
            {
                return;
            }
            BoolChanged(this, new ValuechangedEventArgs()
            {
                NewValue = PropertyValue,
                OldValue = null,
                Property = Propertyname,
                ID = iD
            });
        }
    }
    
}
