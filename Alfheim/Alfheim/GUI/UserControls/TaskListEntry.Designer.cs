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
            this.lbl_description = new System.Windows.Forms.Label();
            this.pnl_trigger = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_devices = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_actions = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_name.Location = new System.Drawing.Point(67, 0);
            this.lbl_name.MaximumSize = new System.Drawing.Size(140, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(83, 21);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Taskname";
            // 
            // tgl_enabled
            // 
            this.tgl_enabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tgl_enabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tgl_enabled.Checked = true;
            this.tgl_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgl_enabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgl_enabled.DisplayStatus = false;
            this.tgl_enabled.Location = new System.Drawing.Point(1136, 24);
            this.tgl_enabled.Margin = new System.Windows.Forms.Padding(24);
            this.tgl_enabled.Name = "tgl_enabled";
            this.tableLayoutPanel1.SetRowSpan(this.tgl_enabled, 2);
            this.tgl_enabled.Size = new System.Drawing.Size(48, 16);
            this.tgl_enabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.tgl_enabled.TabIndex = 13;
            this.tgl_enabled.Text = "An";
            this.tgl_enabled.UseSelectable = true;
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_del.BackgroundImage = global::Alfheim.Properties.Resources.icons8_trash_32;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(16, 16);
            this.btn_del.Margin = new System.Windows.Forms.Padding(16);
            this.btn_del.Name = "btn_del";
            this.tableLayoutPanel1.SetRowSpan(this.btn_del, 2);
            this.btn_del.Size = new System.Drawing.Size(32, 32);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1208, 64);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_description.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_description, 3);
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_description.Location = new System.Drawing.Point(156, 2);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(951, 17);
            this.lbl_description.TabIndex = 14;
            this.lbl_description.Text = "text describing the task and its purpose";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnl_trigger
            // 
            this.pnl_trigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.pnl_trigger, 2);
            this.pnl_trigger.Location = new System.Drawing.Point(64, 22);
            this.pnl_trigger.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_trigger.Name = "pnl_trigger";
            this.pnl_trigger.Size = new System.Drawing.Size(350, 40);
            this.pnl_trigger.TabIndex = 15;
            // 
            // pnl_devices
            // 
            this.pnl_devices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_devices.Location = new System.Drawing.Point(414, 22);
            this.pnl_devices.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_devices.Name = "pnl_devices";
            this.pnl_devices.Size = new System.Drawing.Size(348, 40);
            this.pnl_devices.TabIndex = 16;
            // 
            // pnl_actions
            // 
            this.pnl_actions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_actions.Location = new System.Drawing.Point(762, 22);
            this.pnl_actions.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_actions.Name = "pnl_actions";
            this.pnl_actions.Size = new System.Drawing.Size(348, 40);
            this.pnl_actions.TabIndex = 17;
            // 
            // TaskListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TaskListEntry";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1208, 64);
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
