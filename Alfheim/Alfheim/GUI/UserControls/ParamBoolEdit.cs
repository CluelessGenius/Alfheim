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
    public partial class ParamBoolEdit : UserControl
    {
        public ParamBoolEdit(string name, bool value, long id)
        {
            InitializeComponent();
            lbl_name.Text = name;
            metroToggle1.Checked = value;
            iD = id;
        }

        long iD;

        public event EventHandler<ValuechangedEventArgs> BoolChanged;

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (BoolChanged == null)
            {
                return;
            }
            BoolChanged(this, new ValuechangedEventArgs()
            {
                NewValue = (sender as MetroFramework.Controls.MetroToggle).Checked,
                OldValue = null,
                Property = lbl_name.Text,
                ID = iD
            });
        }
    }
    
}
