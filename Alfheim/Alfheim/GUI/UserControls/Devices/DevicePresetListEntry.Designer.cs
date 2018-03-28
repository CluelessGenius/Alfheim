namespace Alfheim.GUI.UserControls
{
    partial class DevicePresetListEntry
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
            this.btn_del = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbx_name = new Alfheim.GUI.UserControls.AlphaBlendTextBox();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.AutoSize = true;
            this.btn_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_del.BackgroundImage = global::Alfheim.Properties.Resources.icons8_trash_64;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(0, 0);
            this.btn_del.Margin = new System.Windows.Forms.Padding(0);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(16, 25);
            this.btn_del.TabIndex = 11;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // tbx_name
            // 
            this.tbx_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_name.BackAlpha = 0;
            this.tbx_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx_name.EditingEnabled = false;
            this.tbx_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name.ForeColor = System.Drawing.Color.White;
            this.tbx_name.Location = new System.Drawing.Point(21, 4);
            this.tbx_name.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(184, 16);
            this.tbx_name.TabIndex = 12;
            this.toolTip1.SetToolTip(this.tbx_name, "double-click to edit");
            this.tbx_name.TextChanged += new System.EventHandler(this.tbx_name_TextChanged);
            this.tbx_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbx_name_MouseDown);
            // 
            // DevicePresetListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.tbx_name);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DevicePresetListEntry";
            this.Size = new System.Drawing.Size(204, 25);
            this.Click += new System.EventHandler(this.TriggerListEntry_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TriggerListEntry_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private AlphaBlendTextBox tbx_name;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
