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
            this.lbl_name = new System.Windows.Forms.Label();
            this.tgl_enabled = new MetroFramework.Controls.MetroToggle();
            this.btn_del = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_actions = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_description = new System.Windows.Forms.Label();
            this.pnl_trigger = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_devices = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_name.Location = new System.Drawing.Point(48, 0);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(82, 20);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Taskname";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_name.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // tgl_enabled
            // 
            this.tgl_enabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tgl_enabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tgl_enabled.Checked = true;
            this.tgl_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgl_enabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgl_enabled.DisplayStatus = false;
            this.tgl_enabled.Location = new System.Drawing.Point(1152, 12);
            this.tgl_enabled.Margin = new System.Windows.Forms.Padding(12);
            this.tgl_enabled.Name = "tgl_enabled";
            this.tableLayoutPanel1.SetRowSpan(this.tgl_enabled, 2);
            this.tgl_enabled.Size = new System.Drawing.Size(48, 16);
            this.tgl_enabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.tgl_enabled.TabIndex = 13;
            this.tgl_enabled.Text = "An";
            this.tgl_enabled.UseSelectable = true;
            this.tgl_enabled.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_del.BackgroundImage = global::Alfheim.Properties.Resources.icons8_trash_32;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(8, 8);
            this.btn_del.Margin = new System.Windows.Forms.Padding(8);
            this.btn_del.Name = "btn_del";
            this.tableLayoutPanel1.SetRowSpan(this.btn_del, 2);
            this.btn_del.Size = new System.Drawing.Size(32, 24);
            this.btn_del.TabIndex = 11;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pnl_actions, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_del, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_description, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tgl_enabled, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_trigger, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_devices, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, -3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1212, 40);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // pnl_actions
            // 
            this.pnl_actions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_actions.BackColor = System.Drawing.Color.Transparent;
            this.pnl_actions.Location = new System.Drawing.Point(772, 20);
            this.pnl_actions.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_actions.Name = "pnl_actions";
            this.pnl_actions.Size = new System.Drawing.Size(367, 20);
            this.pnl_actions.TabIndex = 17;
            this.pnl_actions.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_description, 3);
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_description.Location = new System.Drawing.Point(130, 1);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(1009, 17);
            this.lbl_description.TabIndex = 14;
            this.lbl_description.Text = "text describing the task and its purpose";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_description.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // pnl_trigger
            // 
            this.pnl_trigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_trigger.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.pnl_trigger, 2);
            this.pnl_trigger.Location = new System.Drawing.Point(48, 20);
            this.pnl_trigger.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_trigger.Name = "pnl_trigger";
            this.pnl_trigger.Size = new System.Drawing.Size(357, 20);
            this.pnl_trigger.TabIndex = 15;
            this.pnl_trigger.Click += new System.EventHandler(this.TaskListEntry_Click);
            // 
            // pnl_devices
            // 
            this.pnl_devices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_devices.BackColor = System.Drawing.Color.Transparent;
            this.pnl_devices.Location = new System.Drawing.Point(405, 20);
            this.pnl_devices.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_devices.Name = "pnl_devices";
            this.pnl_devices.Size = new System.Drawing.Size(367, 20);
            this.pnl_devices.TabIndex = 16;
            this.pnl_devices.Click += new System.EventHandler(this.TaskListEntry_Click);
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
            this.Size = new System.Drawing.Size(1206, 40);
            this.Click += new System.EventHandler(this.TaskListEntry_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label lbl_name;
        private MetroFramework.Controls.MetroToggle tgl_enabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnl_actions;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.FlowLayoutPanel pnl_trigger;
        private System.Windows.Forms.FlowLayoutPanel pnl_devices;
    }
}
