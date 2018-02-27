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
            this.pnl_content = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.triggerList6 = new Alfheim.GUI.UserControls.ParamList();
            this.triggerList5 = new Alfheim.GUI.UserControls.ParamList();
            this.triggerList1 = new Alfheim.GUI.UserControls.ParamList();
            this.pnl_sysmon = new System.Windows.Forms.Panel();
            this.pnl_sysmon_expand = new System.Windows.Forms.Panel();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.pnl_sidebar_expand = new System.Windows.Forms.Panel();
            this.taskList1 = new Alfheim.GUI.UserControls.TaskList();
            this.taskList2 = new Alfheim.GUI.UserControls.TaskList();
            this.taskList3 = new Alfheim.GUI.UserControls.TaskList();
            this.pnl_content.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_sysmon.SuspendLayout();
            this.pnl_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.Transparent;
            this.pnl_content.Controls.Add(this.panel2);
            this.pnl_content.Controls.Add(this.pnl_sysmon);
            this.pnl_content.Controls.Add(this.pnl_sidebar);
            this.pnl_content.Location = new System.Drawing.Point(0, 32);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(1280, 688);
            this.pnl_content.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.taskList3);
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
            this.tableLayoutPanel1.Controls.Add(this.triggerList6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.triggerList5, 2, 0);
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
            this.triggerList6.BackColor = System.Drawing.Color.Black;
            this.triggerList6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.triggerList6, 2);
            this.triggerList6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerList6.ForeColor = System.Drawing.Color.White;
            this.triggerList6.Location = new System.Drawing.Point(828, 10);
            this.triggerList6.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.triggerList6.Name = "triggerList6";
            this.triggerList6.Parameters = ((System.Collections.Generic.List<Alfheim_Model.Param>)(resources.GetObject("triggerList6.Parameters")));
            this.triggerList6.ParamType = Alfheim.GUI.UserControls.ParamListType.ACTIONS;
            this.triggerList6.SelectedRowIndex = 0;
            this.triggerList6.SelectedTrigger = null;
            this.triggerList6.Size = new System.Drawing.Size(410, 327);
            this.triggerList6.TabIndex = 5;
            // 
            // triggerList5
            // 
            this.triggerList5.BackColor = System.Drawing.Color.Black;
            this.triggerList5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.triggerList5, 2);
            this.triggerList5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerList5.ForeColor = System.Drawing.Color.White;
            this.triggerList5.Location = new System.Drawing.Point(424, 10);
            this.triggerList5.Margin = new System.Windows.Forms.Padding(10);
            this.triggerList5.Name = "triggerList5";
            this.triggerList5.Parameters = ((System.Collections.Generic.List<Alfheim_Model.Param>)(resources.GetObject("triggerList5.Parameters")));
            this.triggerList5.ParamType = Alfheim.GUI.UserControls.ParamListType.DEVICES;
            this.triggerList5.SelectedRowIndex = 0;
            this.triggerList5.SelectedTrigger = null;
            this.triggerList5.Size = new System.Drawing.Size(394, 327);
            this.triggerList5.TabIndex = 4;
            // 
            // triggerList1
            // 
            this.triggerList1.BackColor = System.Drawing.Color.Black;
            this.triggerList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.triggerList1, 2);
            this.triggerList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerList1.ForeColor = System.Drawing.Color.White;
            this.triggerList1.Location = new System.Drawing.Point(10, 10);
            this.triggerList1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.triggerList1.Name = "triggerList1";
            this.triggerList1.Parameters = ((System.Collections.Generic.List<Alfheim_Model.Param>)(resources.GetObject("triggerList1.Parameters")));
            this.triggerList1.ParamType = Alfheim.GUI.UserControls.ParamListType.TRIGGER;
            this.triggerList1.SelectedRowIndex = 0;
            this.triggerList1.SelectedTrigger = null;
            this.triggerList1.Size = new System.Drawing.Size(404, 327);
            this.triggerList1.TabIndex = 0;
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
            // taskList1
            // 
            this.taskList1.BackColor = System.Drawing.Color.Black;
            this.taskList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList1.ForeColor = System.Drawing.Color.White;
            this.taskList1.Location = new System.Drawing.Point(0, 0);
            this.taskList1.Margin = new System.Windows.Forms.Padding(10);
            this.taskList1.Name = "taskList1";
            this.taskList1.SelectedRowIndex = 0;
            this.taskList1.SelectedTask = null;
            this.taskList1.Size = new System.Drawing.Size(566, 350);
            this.taskList1.TabIndex = 0;
            this.taskList1.Tasks = ((System.Collections.Generic.List<Alfheim_Model.Task>)(resources.GetObject("taskList1.Tasks")));
            // 
            // taskList2
            // 
            this.taskList2.BackColor = System.Drawing.Color.Black;
            this.taskList2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList2.ForeColor = System.Drawing.Color.White;
            this.taskList2.Location = new System.Drawing.Point(0, 0);
            this.taskList2.Margin = new System.Windows.Forms.Padding(10);
            this.taskList2.Name = "taskList2";
            this.taskList2.SelectedRowIndex = 0;
            this.taskList2.SelectedTask = null;
            this.taskList2.Size = new System.Drawing.Size(566, 350);
            this.taskList2.TabIndex = 0;
            this.taskList2.Tasks = ((System.Collections.Generic.List<Alfheim_Model.Task>)(resources.GetObject("taskList2.Tasks")));
            // 
            // taskList3
            // 
            this.taskList3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList3.BackColor = System.Drawing.Color.Black;
            this.taskList3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList3.ForeColor = System.Drawing.Color.White;
            this.taskList3.Location = new System.Drawing.Point(10, 10);
            this.taskList3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.taskList3.Name = "taskList3";
            this.taskList3.SelectedRowIndex = 0;
            this.taskList3.SelectedTask = null;
            this.taskList3.Size = new System.Drawing.Size(1228, 331);
            this.taskList3.TabIndex = 1;
            this.taskList3.Tasks = ((System.Collections.Generic.List<Alfheim_Model.Task>)(resources.GetObject("taskList3.Tasks")));
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnl_content);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALFHEIM";
            this.Controls.SetChildIndex(this.pnl_content, 0);
            this.pnl_content.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_sysmon.ResumeLayout(false);
            this.pnl_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_sidebar_expand;
        private System.Windows.Forms.Panel pnl_sysmon;
        private System.Windows.Forms.Panel pnl_sysmon_expand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.ParamList triggerList6;
        private UserControls.ParamList triggerList5;
        private UserControls.ParamList triggerList1;
        private UserControls.TaskList taskList1;
        private UserControls.TaskList taskList2;
        private UserControls.TaskList taskList3;
    }
}

