namespace Alfheim.GUI
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.triggerList6 = new Alfheim.GUI.UserControls.TriggerList();
            this.triggerList5 = new Alfheim.GUI.UserControls.TriggerList();
            this.triggerList1 = new Alfheim.GUI.UserControls.TriggerList();
            this.pnl_sysmon = new System.Windows.Forms.Panel();
            this.pnl_sysmon_expand = new System.Windows.Forms.Panel();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.pnl_sidebar_expand = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_sysmon.SuspendLayout();
            this.pnl_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnl_sysmon);
            this.panel1.Controls.Add(this.pnl_sidebar);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 688);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(16, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 688);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.triggerList6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.triggerList5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.triggerList1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 341);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 347);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // triggerList6
            // 
            this.triggerList6.BackColor = System.Drawing.Color.Transparent;
            this.triggerList6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triggerList6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerList6.Location = new System.Drawing.Point(417, 3);
            this.triggerList6.Name = "triggerList6";
            this.triggerList6.SelectedRowIndex = 0;
            this.triggerList6.SelectedTrigger = null;
            this.triggerList6.Size = new System.Drawing.Size(201, 341);
            this.triggerList6.TabIndex = 5;
            this.triggerList6.Triggers = ((System.Collections.Generic.List<Alfheim_Model.TRIGGERS.Trigger>)(resources.GetObject("triggerList6.Triggers")));
            // 
            // triggerList5
            // 
            this.triggerList5.BackColor = System.Drawing.Color.Transparent;
            this.triggerList5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triggerList5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerList5.Location = new System.Drawing.Point(210, 3);
            this.triggerList5.Name = "triggerList5";
            this.triggerList5.SelectedRowIndex = 0;
            this.triggerList5.SelectedTrigger = null;
            this.triggerList5.Size = new System.Drawing.Size(201, 341);
            this.triggerList5.TabIndex = 4;
            this.triggerList5.Triggers = ((System.Collections.Generic.List<Alfheim_Model.TRIGGERS.Trigger>)(resources.GetObject("triggerList5.Triggers")));
            // 
            // triggerList1
            // 
            this.triggerList1.BackColor = System.Drawing.Color.Transparent;
            this.triggerList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triggerList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerList1.Location = new System.Drawing.Point(3, 3);
            this.triggerList1.Name = "triggerList1";
            this.triggerList1.SelectedRowIndex = 0;
            this.triggerList1.SelectedTrigger = null;
            this.triggerList1.Size = new System.Drawing.Size(201, 341);
            this.triggerList1.TabIndex = 0;
            this.triggerList1.Triggers = ((System.Collections.Generic.List<Alfheim_Model.TRIGGERS.Trigger>)(resources.GetObject("triggerList1.Triggers")));
            // 
            // pnl_sysmon
            // 
            this.pnl_sysmon.BackColor = System.Drawing.Color.Black;
            this.pnl_sysmon.Controls.Add(this.pnl_sysmon_expand);
            this.pnl_sysmon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sysmon.Location = new System.Drawing.Point(1264, 0);
            this.pnl_sysmon.Name = "pnl_sysmon";
            this.pnl_sysmon.Size = new System.Drawing.Size(16, 688);
            this.pnl_sysmon.TabIndex = 2;
            // 
            // pnl_sysmon_expand
            // 
            this.pnl_sysmon_expand.BackColor = System.Drawing.Color.Black;
            this.pnl_sysmon_expand.BackgroundImage = global::Alfheim.Properties.Resources.icons8_systemaufgabe_32;
            this.pnl_sysmon_expand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_sysmon_expand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_sysmon_expand.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sysmon_expand.Location = new System.Drawing.Point(0, 0);
            this.pnl_sysmon_expand.Name = "pnl_sysmon_expand";
            this.pnl_sysmon_expand.Size = new System.Drawing.Size(16, 688);
            this.pnl_sysmon_expand.TabIndex = 1;
            this.pnl_sysmon_expand.Click += new System.EventHandler(this.pnl_sysmon_expand_Click);
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.Black;
            this.pnl_sidebar.Controls.Add(this.pnl_sidebar_expand);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(16, 688);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // pnl_sidebar_expand
            // 
            this.pnl_sidebar_expand.BackgroundImage = global::Alfheim.Properties.Resources.icons8_menü_32;
            this.pnl_sidebar_expand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_sidebar_expand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_sidebar_expand.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sidebar_expand.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar_expand.Name = "pnl_sidebar_expand";
            this.pnl_sidebar_expand.Size = new System.Drawing.Size(16, 688);
            this.pnl_sidebar_expand.TabIndex = 1;
            this.pnl_sidebar_expand.Click += new System.EventHandler(this.pnl_sidebar_expand_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALFHEIM";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_sysmon.ResumeLayout(false);
            this.pnl_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_tasks_add;
        private System.Windows.Forms.Button btn_tasks_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private UserControls.TriggerList trl_detail_trigger;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_sidebar_expand;
        private System.Windows.Forms.Panel pnl_sysmon;
        private System.Windows.Forms.Panel pnl_sysmon_expand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.TriggerList triggerList6;
        private UserControls.TriggerList triggerList5;
        private UserControls.TriggerList triggerList1;
    }
}

