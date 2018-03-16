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
    public partial class ParamStringEdit : UserControl
    {
        public ParamStringEdit(string name, string value, long id)
        {
            InitializeComponent();
            metroTextBox1.WaterMark = name;
            metroTextBox1.Text = value;
            iD = id;
        }

        long iD;

        public event EventHandler<ValuechangedEventArgs> StringChanged;

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (StringChanged==null || String.IsNullOrEmpty((sender as MetroFramework.Controls.MetroTextBox).Text))
            {
                return;
            }
            StringChanged(this, new ValuechangedEventArgs()
                                    { NewValue = (sender as MetroFramework.Controls.MetroTextBox).Text,
                                      OldValue = null,
                                      Property = (sender as MetroFramework.Controls.MetroTextBox).WaterMark,
                                      ID = iD});
        }
    }
}
