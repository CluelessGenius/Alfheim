namespace Alfheim.GUI.UserControls
{
    partial class TaskListEntry
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tgl_enabled = new MetroFramework.Controls.MetroToggle();
            this.btn_del = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbx_description = new Alfheim.GUI.UserControls.AlphaBlendTextBox();
            this.pnl_actions = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_trigger = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_devices = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_name = new Alfheim.GUI.UserControls.AlphaBlendTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tgl_enabled
            // 
            this.tgl_enabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tgl_enabled.AutoSize = true;
            this.tgl_enabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tgl_enabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tgl_enabled.Checked = true;
            this.tgl_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgl_enabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgl_enabled.DisplayStatus = false;
            this.tgl_enabled.Location = new System.Drawing.Point(1302, 21);
            this.tgl_enabled.Margin = new System.Windows.Forms.Padding(12);
            this.tgl_enabled.Name = "tgl_enabled";
            this.tableLayoutPanel1.SetRowSpan(this.tgl_enabled, 3);
            this.tgl_enabled.Size = new System.Drawing.Size(50, 17);
            this.tgl_enabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.tgl_enabled.TabIndex = 13;
            this.tgl_enabled.Text = "An";
            this.tgl_enabled.UseSelectable = true;
            this.tgl_enabled.CheckedChanged += new System.EventHandler(this.tgl_enabled_CheckedChanged);
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_del.BackgroundImage = global::Alfheim.Properties.Resources.icons8_trash_64;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(8, 17);
            this.btn_del.Margin = new System.Windows.Forms.Padding(8);
            this.btn_del.Name = "btn_del";
            this.tableLayoutPanel1.SetRowSpan(this.btn_del, 3);
            this.btn_del.Size = new System.Drawing.Size(32, 24);
            this.btn_del.TabIndex = 11;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_actions, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_del, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tgl_enabled, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_trigger, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnl_devices, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 59);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this.tbx_description);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(48, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 14);
            this.panel2.TabIndex = 0;
            // 
            // tbx_description
            // 
            this.tbx_description.BackAlpha = 0;
            this.tbx_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_description.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_description.EditingEnabled = false;
            this.tbx_description.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_description.ForeColor = System.Drawing.Color.White;
            this.tbx_description.Location = new System.Drawing.Point(0, 0);
            this.tbx_description.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_description.MinimumSize = new System.Drawing.Size(0, 15);
            this.tbx_description.Name = "tbx_description";
            this.tbx_description.Size = new System.Drawing.Size(1242, 15);
            this.tbx_description.TabIndex = 19;
            this.tbx_description.Text = "text describing the task and its purpose";
            this.tbx_description.TextChanged += new System.EventHandler(this.tbx_description_TextChanged);
            this.tbx_description.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbx_description_MouseDown);
            // 
            // pnl_actions
            // 
            this.pnl_actions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_actions.BackColor = System.Drawing.Color.Transparent;
            this.pnl_actions.Location = new System.Drawing.Point(935, 38);
            this.pnl_actions.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_actions.Name = "pnl_actions";
            this.pnl_actions.Size = new System.Drawing.Size(355, 20);
            this.pnl_actions.TabIndex = 17;
            this.pnl_actions.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // pnl_trigger
            // 
            this.pnl_trigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_trigger.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.pnl_trigger, 2);
            this.pnl_trigger.Location = new System.Drawing.Point(48, 38);
            this.pnl_trigger.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_trigger.Name = "pnl_trigger";
            this.pnl_trigger.Size = new System.Drawing.Size(532, 20);
            this.pnl_trigger.TabIndex = 15;
            this.pnl_trigger.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // pnl_devices
            // 
            this.pnl_devices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_devices.BackColor = System.Drawing.Color.Transparent;
            this.pnl_devices.Location = new System.Drawing.Point(580, 38);
            this.pnl_devices.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_devices.Name = "pnl_devices";
            this.pnl_devices.Size = new System.Drawing.Size(355, 20);
            this.pnl_devices.TabIndex = 16;
            this.pnl_devices.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.tbx_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(51, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 17);
            this.panel1.TabIndex = 20;
            // 
            // tbx_name
            // 
            this.tbx_name.BackAlpha = 0;
            this.tbx_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_name.EditingEnabled = false;
            this.tbx_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name.ForeColor = System.Drawing.Color.White;
            this.tbx_name.Location = new System.Drawing.Point(0, 0);
            this.tbx_name.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(1236, 22);
            this.tbx_name.TabIndex = 18;
            this.tbx_name.TextChanged += new System.EventHandler(this.tbx_name_TextChanged);
            this.tbx_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbx_name_MouseDown);
            // 
            // TaskListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TaskListEntry";
            this.Size = new System.Drawing.Size(1366, 59);
            this.Click += new System.EventHandler(this.TaskListEntry_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private MetroFramework.Controls.MetroToggle tgl_enabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnl_actions;
        private System.Windows.Forms.FlowLayoutPanel pnl_trigger;
        private System.Windows.Forms.FlowLayoutPanel pnl_devices;
        private System.Windows.Forms.ToolTip toolTip1;
        private AlphaBlendTextBox tbx_name;
        private AlphaBlendTextBox tbx_description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
