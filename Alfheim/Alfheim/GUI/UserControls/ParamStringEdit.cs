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
    public partial class ParamStringEdit : IReflectionEdit
    {
        public ParamStringEdit(string name, string value, long id)
        {
            InitializeComponent();
            Propertyname = name;
            PropertyValue = value;
            metroTextBox1.WaterMark = name.Split('.').Last();
            metroTextBox1.Text = (string)PropertyValue;
            iD = id;
        }
        
        long iD;

        public event EventHandler<ValuechangedEventArgs> StringChanged;

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            PropertyValue = metroTextBox1.Text;
            if (StringChanged==null || String.IsNullOrEmpty((sender as MetroFramework.Controls.MetroTextBox).Text))
            {
                return;
            }
            StringChanged(this, new ValuechangedEventArgs()
                                    { NewValue = PropertyValue,
                                      OldValue = null,
                                      Property = Propertyname,
                                      ID = iD});
        }
    }
}
