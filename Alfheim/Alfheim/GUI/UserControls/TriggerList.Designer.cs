namespace Alfheim.GUI.UserControls
{
    partial class TriggerList
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
            this.addButton1 = new Alfheim.GUI.UserControls.AddButton();
            this.pnl_triggers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 21);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "TRIGGER";
            // 
            // addButton1
            // 
            this.addButton1.AutoSize = true;
            this.addButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addButton1.Location = new System.Drawing.Point(0, 318);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(290, 32);
            this.addButton1.TabIndex = 0;
            this.addButton1.Clicked += new System.EventHandler(this.Addbutton_Clicked);
            // 
            // pnl_triggers
            // 
            this.pnl_triggers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_triggers.AutoScroll = true;
            this.pnl_triggers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_triggers.Location = new System.Drawing.Point(-1, 24);
            this.pnl_triggers.Name = "pnl_triggers";
            this.pnl_triggers.Size = new System.Drawing.Size(292, 288);
            this.pnl_triggers.TabIndex = 14;
            this.pnl_triggers.WrapContents = false;
            // 
            // TriggerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_triggers);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.lbl_name);
            this.DoubleBuffered = true;
            this.Name = "TriggerList";
            this.Size = new System.Drawing.Size(290, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_name;
        private AddButton addButton1;
        private System.Windows.Forms.FlowLayoutPanel pnl_triggers;
    }
}
