using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfheim.GUI
{
    public class ResizableNonBorderForm : Form
    {
        

        public ResizableNonBorderForm():base()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts 
        }

        

        protected override void OnPaint(PaintEventArgs e) 
        {
            lbl_from_name.Text = this.Text;
            Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, 32);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 209, 65, 26)), rc);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;
        private Label lbl_from_name;
        private Button button1;
        private Button btn_form_max;
        private Button button2;
        const int _ = 10; // you can rename this variable if you like

        Rectangle Topcenter { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Leftcenter { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizableNonBorderForm));
            this.lbl_from_name = new System.Windows.Forms.Label();
            this.btn_form_max = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_from_name
            // 
            this.lbl_from_name.AutoSize = true;
            this.lbl_from_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_from_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(53)))));
            this.lbl_from_name.Location = new System.Drawing.Point(3, 3);
            this.lbl_from_name.Name = "lbl_from_name";
            this.lbl_from_name.Size = new System.Drawing.Size(0, 25);
            this.lbl_from_name.TabIndex = 4;
            // 
            // btn_form_max
            // 
            this.btn_form_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_form_max.BackColor = System.Drawing.Color.Transparent;
            this.btn_form_max.BackgroundImage = global::Alfheim.Properties.Resources.max;
            this.btn_form_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_form_max.FlatAppearance.BorderSize = 0;
            this.btn_form_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_form_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_form_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_max.Location = new System.Drawing.Point(1216, 0);
            this.btn_form_max.Name = "btn_form_max";
            this.btn_form_max.Size = new System.Drawing.Size(32, 32);
            this.btn_form_max.TabIndex = 6;
            this.btn_form_max.UseVisualStyleBackColor = false;
            this.btn_form_max.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1248, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Alfheim.Properties.Resources.mini;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1184, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ResizableNonBorderForm
            // 
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_form_max);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_from_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResizableNonBorderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btn_form_max.BackgroundImage = Alfheim.Properties.Resources.resto;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btn_form_max.BackgroundImage = Alfheim.Properties.Resources.max;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        Rectangle Bottomcenter { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Rightcenter { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
        
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = this.PointToClient(new Point(message.LParam.ToInt32()));
                if (pos.Y < 32 && pos.Y > 1)
                {
                    message.Result = (IntPtr)2;  // HTCAPTION

                    return;
                }
            }
            base.WndProc(ref message);

            //if (message.Msg == 0x84) // WM_NCHITTEST
            //{
            //    var cursor = this.PointToClient(Cursor.Position);
            //    BG.Size = new Size(this.Width, this.Height - 32);
            //    if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
            //    else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
            //    else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
            //    else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

            //    else if (Topcenter.Contains(cursor)) message.Result = (IntPtr)HTTOP;
            //    else if (Leftcenter.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
            //    else if (Rightcenter.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
            //    else if (Bottomcenter.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            //}
        }
    }
}
