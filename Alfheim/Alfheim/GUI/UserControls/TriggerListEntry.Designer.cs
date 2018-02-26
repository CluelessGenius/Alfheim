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
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(38, 7);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 17);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // tgl_enabled
            // 
            this.tgl_enabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tgl_enabled.AutoSize = true;
            this.tgl_enabled.Checked = true;
            this.tgl_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgl_enabled.DisplayStatus = false;
            this.tgl_enabled.Location = new System.Drawing.Point(242, 7);
            this.tgl_enabled.Name = "tgl_enabled";
            this.tgl_enabled.Size = new System.Drawing.Size(50, 17);
            this.tgl_enabled.TabIndex = 13;
            this.tgl_enabled.Text = "An";
            this.tgl_enabled.UseCustomForeColor = true;
            this.tgl_enabled.UseSelectable = true;
            this.tgl_enabled.CheckedChanged += new System.EventHandler(this.tgl_enabled_CheckedChanged);
            this.tgl_enabled.Click += new System.EventHandler(this.tgl_enabled_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_del.BackgroundImage = global::Alfheim.Properties.Resources.icons8_trash_64;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_del.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(0, 0);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(32, 32);
            this.btn_del.TabIndex = 11;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // TriggerListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tgl_enabled);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_del);
            this.DoubleBuffered = true;
            this.Name = "TriggerListEntry";
            this.Size = new System.Drawing.Size(292, 32);
            this.Click += new System.EventHandler(this.TriggerListEntry_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label lbl_name;
        private MetroFramework.Controls.MetroToggle tgl_enabled;
    }
}
