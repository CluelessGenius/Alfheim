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
    public partial class ParamEnumEdit : IReflectionEdit
    {
        Type EnumType;

        public ParamEnumEdit(string name, object value,long id)
        {
            InitializeComponent();
            Propertyname = name;
            PropertyValue = value;
            lbl_name.Text = name.Split('.').Last();
            EnumType = PropertyValue.GetType();
            string[] values = Enum.GetNames(EnumType);
            comboBox1.Items.AddRange(values);
            comboBox1.SelectedItem = PropertyValue.ToString();
            iD = id;
        }
        
        long iD;

        public event EventHandler<ValuechangedEventArgs> EnumChanged;
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PropertyValue = Enum.Parse(EnumType, (sender as ComboBox).SelectedItem.ToString());
            if (EnumChanged == null)
            {
                return;
            }
            EnumChanged(this, new ValuechangedEventArgs()
            {
                NewValue = PropertyValue,
                OldValue = null,
                Property = Propertyname,
                ID = iD
            });
        }
    }
    
}
