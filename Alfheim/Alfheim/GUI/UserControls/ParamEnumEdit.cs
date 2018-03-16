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
    public partial class ParamEnumEdit : UserControl
    {
        Type EnumType;

        public ParamEnumEdit(string name, object value,long id)
        {
            InitializeComponent();
            lbl_name.Text = name;
            EnumType = value.GetType();
            string[] values = Enum.GetNames(EnumType);
            comboBox1.Items.AddRange(values);
            comboBox1.SelectedItem = value.ToString();
            iD = id;
        }

        long iD;

        public event EventHandler<ValuechangedEventArgs> EnumChanged;
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumChanged == null)
            {
                return;
            }
            EnumChanged(this, new ValuechangedEventArgs()
            {
                NewValue = Enum.Parse(EnumType, (sender as ComboBox).SelectedItem.ToString()),
                OldValue = null,
                Property = lbl_name.Text,
                ID = iD
            });
        }
    }
    
}
