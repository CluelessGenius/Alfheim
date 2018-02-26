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
    public partial class AddButton : UserControl
    {
        public AddButton()
        {
            InitializeComponent();
        }

        public event EventHandler Clicked;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clicked!=null)
            {
                Clicked(this, e);
            }
        }
    }
}
