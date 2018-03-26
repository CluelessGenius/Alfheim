namespace Alfheim.GUI.UserControls
{
    partial class DeviceList
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
            this.pnl_parameters = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_content = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_parameters
            // 
            this.pnl_parameters.AllowDrop = true;
            this.pnl_parameters.AutoScroll = true;
            this.pnl_parameters.BackColor = System.Drawing.Color.Transparent;
            this.pnl_parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_parameters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl_parameters.Location = new System.Drawing.Point(3, 3);
            this.pnl_parameters.Name = "pnl_parameters";
            this.pnl_parameters.Size = new System.Drawing.Size(279, 346);
            this.pnl_parameters.TabIndex = 14;
            this.pnl_parameters.WrapContents = false;
            this.pnl_parameters.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_parameters_DragDrop);
            this.pnl_parameters.DragOver += new System.Windows.Forms.DragEventHandler(this.pnl_parameters_DragOver);
            this.pnl_parameters.DragLeave += new System.EventHandler(this.pnl_parameters_DragLeave);
            // 
            // pnl_content
            // 
            this.pnl_content.ColumnCount = 1;
            this.pnl_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnl_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.pnl_content.Controls.Add(this.pnl_parameters, 0, 0);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(0, 0);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.RowCount = 1;
            this.pnl_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnl_content.Size = new System.Drawing.Size(285, 352);
            this.pnl_content.TabIndex = 15;
            // 
            // DeviceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.pnl_content);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "DeviceList";
            this.Size = new System.Drawing.Size(285, 352);
            this.SizeChanged += new System.EventHandler(this.TriggerList_SizeChanged);
            this.pnl_content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnl_parameters;
        private System.Windows.Forms.TableLayoutPanel pnl_content;
    }
}
