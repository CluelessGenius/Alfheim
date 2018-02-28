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
            this.pnl_parameters = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_content = new System.Windows.Forms.TableLayoutPanel();
            this.triggerDetail1 = new Alfheim.GUI.UserControls.ParamDetail();
            this.pnl_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(277, 21);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "TRIGGER";
            // 
            // addButton1
            // 
            this.addButton1.AutoSize = true;
            this.addButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton1.BackColor = System.Drawing.Color.Transparent;
            this.addButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton1.Location = new System.Drawing.Point(3, 315);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(277, 32);
            this.addButton1.TabIndex = 0;
            this.addButton1.Clicked += new System.EventHandler(this.Addbutton_Clicked);
            // 
            // pnl_parameters
            // 
            this.pnl_parameters.AutoScroll = true;
            this.pnl_parameters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_parameters.Location = new System.Drawing.Point(3, 24);
            this.pnl_parameters.Name = "pnl_parameters";
            this.pnl_parameters.Size = new System.Drawing.Size(277, 285);
            this.pnl_parameters.TabIndex = 14;
            this.pnl_parameters.WrapContents = false;
            // 
            // pnl_content
            // 
            this.pnl_content.ColumnCount = 2;
            this.pnl_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_content.Controls.Add(this.lbl_name, 0, 0);
            this.pnl_content.Controls.Add(this.addButton1, 0, 2);
            this.pnl_content.Controls.Add(this.pnl_parameters, 0, 1);
            this.pnl_content.Controls.Add(this.triggerDetail1, 1, 1);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(0, 0);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.RowCount = 3;
            this.pnl_content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_content.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_content.Size = new System.Drawing.Size(566, 350);
            this.pnl_content.TabIndex = 15;
            // 
            // triggerDetail1
            // 
            this.triggerDetail1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.triggerDetail1.BackColor = System.Drawing.Color.Transparent;
            this.triggerDetail1.DetailedTrigger = null;
            this.triggerDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerDetail1.ForeColor = System.Drawing.Color.White;
            this.triggerDetail1.Location = new System.Drawing.Point(286, 24);
            this.triggerDetail1.Name = "triggerDetail1";
            this.pnl_content.SetRowSpan(this.triggerDetail1, 2);
            this.triggerDetail1.Size = new System.Drawing.Size(277, 323);
            this.triggerDetail1.TabIndex = 15;
            // 
            // ParamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_content);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ParamList";
            this.Size = new System.Drawing.Size(566, 350);
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_name;
        private AddButton addButton1;
        private System.Windows.Forms.FlowLayoutPanel pnl_parameters;
        private System.Windows.Forms.TableLayoutPanel pnl_content;
        private ParamDetail triggerDetail1;
    }
}
