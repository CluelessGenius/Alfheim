namespace Alfheim.GUI.UserControls
{
    partial class TriggerListEntry
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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoEllipsis = true;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_name.Location = new System.Drawing.Point(21, 0);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_name.MaximumSize = new System.Drawing.Size(140, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(140, 22);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Triggername";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            this.lbl_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TriggerListEntry_MouseMove);
            // 
            // tgl_enabled
            // 
            this.tgl_enabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tgl_enabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tgl_enabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tgl_enabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgl_enabled.DisplayStatus = false;
            this.tgl_enabled.Enabled = false;
            this.tgl_enabled.Location = new System.Drawing.Point(171, 5);
            this.tgl_enabled.Margin = new System.Windows.Forms.Padding(0);
            this.tgl_enabled.Name = "tgl_enabled";
            this.tgl_enabled.Size = new System.Drawing.Size(30, 12);
            this.tgl_enabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.tgl_enabled.TabIndex = 13;
            this.tgl_enabled.Text = "Aus";
            this.tgl_enabled.UseSelectable = true;
            this.tgl_enabled.Click += new System.EventHandler(this.tgl_enabled_Click);
            // 
            // btn_del
            // 
            this.btn_del.AutoSize = true;
            this.btn_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_del.BackgroundImage = global::Alfheim.Properties.Resources.icons8_trash_64;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(0, 0);
            this.btn_del.Margin = new System.Windows.Forms.Padding(0);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(16, 22);
            this.btn_del.TabIndex = 11;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_del, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tgl_enabled, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 22);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // TriggerListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TriggerListEntry";
            this.Size = new System.Drawing.Size(204, 22);
            this.SizeChanged += new System.EventHandler(this.TriggerListEntry_SizeChanged);
            this.Click += new System.EventHandler(this.TriggerListEntry_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TriggerListEntry_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label lbl_name;
        private MetroFramework.Controls.MetroToggle tgl_enabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
