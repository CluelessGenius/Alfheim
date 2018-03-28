namespace Alfheim.GUI.UserControls
{
    partial class DeviceListEntry
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
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_name.AutoEllipsis = true;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_name.Location = new System.Drawing.Point(6, 5);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_name.MaximumSize = new System.Drawing.Size(140, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(75, 15);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Triggername";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tgl_enabled.Location = new System.Drawing.Point(168, 6);
            this.tgl_enabled.Margin = new System.Windows.Forms.Padding(0);
            this.tgl_enabled.Name = "tgl_enabled";
            this.tgl_enabled.Size = new System.Drawing.Size(30, 12);
            this.tgl_enabled.Style = MetroFramework.MetroColorStyle.Orange;
            this.tgl_enabled.TabIndex = 14;
            this.tgl_enabled.Text = "Aus";
            this.tgl_enabled.UseSelectable = true;
            // 
            // DeviceListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tgl_enabled);
            this.Controls.Add(this.lbl_name);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DeviceListEntry";
            this.Size = new System.Drawing.Size(204, 25);
            this.SizeChanged += new System.EventHandler(this.TriggerListEntry_SizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TriggerListEntry_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_name;
        private MetroFramework.Controls.MetroToggle tgl_enabled;
    }
}
