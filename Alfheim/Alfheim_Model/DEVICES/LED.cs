using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Alfheim_Model.DEVICES
{
    class LED : Param
    {
        private Color color;

        public Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
    }
}
