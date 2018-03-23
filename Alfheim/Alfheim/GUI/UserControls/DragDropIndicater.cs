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
    public partial class DragDropIndicater : UserControl
    {
        public DragDropIndicater()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            label1.Text = text;
        }
    }
}
