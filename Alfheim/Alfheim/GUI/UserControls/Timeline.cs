using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Alfheim.GUI.UserControls
{
    public partial class Timeline : UserControl
    {
        private Timer timer;
        private int duration;
        private int progress;
        private decimal oldvalue;

        public Timeline()
        {
            InitializeComponent();
            timer = new Timer() { Interval = 16 };
            timer.Tick += Timer_Tick;
            numericUpDown1.Minimum = 1000;
            numericUpDown1.Maximum = Int32.MaxValue;
            oldvalue = numericUpDown1.Value;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progress >= duration)
            {
                lastxpos = 0;
                progress = 0;
                //Debug.WriteLine(DateTime.Now.ToString());
            }
            else
            {
                DateTime thistimerrunms = DateTime.Now;
                progress += thistimerrunms.Subtract(lasttimerrunms).Milliseconds;
                Debug.WriteLine(progress);
                Task.Run(()=>UpdateProgressBar());
                lasttimerrunms = thistimerrunms;
            }
        }
        
        private void UpdateProgressBar()
        {
            xpos = (int)(((double)progress / duration * 100.0) * (panel2.Width / 100.0));
            panel2.Invalidate(new Rectangle(new Point(lastxpos - 1, 0), new Size((xpos - lastxpos) + 2, panel2.Height)));
            lastxpos = xpos;
        }

        private DateTime lasttimerrunms;
        private int xpos;
        private int lastxpos;

        private bool running;
        private void tgl_enabled_CheckedChanged(object sender, EventArgs e)
        {
            running = tgl_enabled.Checked;
            numericUpDown1.Enabled = !tgl_enabled.Checked;
            if (tgl_enabled.Checked)
            {
                progress = 0;
                Debug.WriteLine(DateTime.Now.ToString());
                lasttimerrunms = DateTime.Now;
                timer.Start();
            }
            else
            {
                timer.Stop();
                panel2.Invalidate(new Rectangle(new Point(lastxpos - 1, 0), new Size((xpos - lastxpos) + 2, panel2.Height)));

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {   
            duration = (int)numericUpDown1.Value;
            oldvalue = numericUpDown1.Value;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (running)
            {
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.White)),
                                    new Point(xpos, 0),
                                    new Point(xpos, panel2.Height));
            }
        }
    }
}
