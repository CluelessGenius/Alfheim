using System;
using System.Windows.Forms;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.trl_triggerlist = new Alfheim.GUI.UserControls.TriggerList();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.timeline1 = new Alfheim.GUI.UserControls.Timeline();
            this.taskList3 = new Alfheim.GUI.UserControls.TaskList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.devicePresetList1 = new Alfheim.GUI.UserControls.DevicePresetList();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.efl_effectlist = new Alfheim.GUI.UserControls.EffectList();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.pnl_sidebar_expand = new System.Windows.Forms.Panel();
            this.pnl_content.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.pnl_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.Transparent;
            this.pnl_content.Controls.Add(this.tableLayoutPanel1);
            this.pnl_content.Location = new System.Drawing.Point(16, 32);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(1264, 688);
            this.pnl_content.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.taskList3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 688);
            this.tableLayoutPanel1.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.metroTabControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 417);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 261);
            this.panel2.TabIndex = 3;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl2.Controls.Add(this.metroTabPage4);
            this.metroTabControl2.Controls.Add(this.metroTabPage5);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl2.ItemSize = new System.Drawing.Size(73, 25);
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
            this.metroTabControl2.Size = new System.Drawing.Size(1242, 259);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl2.TabIndex = 1;
            this.metroTabControl2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage4.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.metroTabPage4.Controls.Add(this.trl_triggerlist);
            this.metroTabPage4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage4.ForeColor = System.Drawing.Color.Transparent;
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1234, 226);
            this.metroTabPage4.TabIndex = 0;
            this.metroTabPage4.Text = "TRIGGERS";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // trl_triggerlist
            // 
            this.trl_triggerlist.BackColor = System.Drawing.Color.Transparent;
            this.trl_triggerlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.trl_triggerlist.ForeColor = System.Drawing.Color.White;
            this.trl_triggerlist.Location = new System.Drawing.Point(0, 0);
            this.trl_triggerlist.Margin = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.trl_triggerlist.Name = "trl_triggerlist";
            this.trl_triggerlist.Size = new System.Drawing.Size(1140, 226);
            this.trl_triggerlist.TabIndex = 0;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage5.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.metroTabPage5.Controls.Add(this.timeline1);
            this.metroTabPage5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(1234, 226);
            this.metroTabPage5.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabPage5.TabIndex = 1;
            this.metroTabPage5.Text = "TIMELINE";
            this.metroTabPage5.UseCustomBackColor = true;
            this.metroTabPage5.UseCustomForeColor = true;
            this.metroTabPage5.UseStyleColors = true;
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // timeline1
            // 
            this.timeline1.BackColor = System.Drawing.Color.Transparent;
            this.timeline1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeline1.Location = new System.Drawing.Point(0, 0);
            this.timeline1.Name = "timeline1";
            this.timeline1.Size = new System.Drawing.Size(1234, 226);
            this.timeline1.TabIndex = 2;
            // 
            // taskList3
            // 
            this.taskList3.BackColor = System.Drawing.Color.Transparent;
            this.taskList3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskList3.ForeColor = System.Drawing.Color.White;
            this.taskList3.Location = new System.Drawing.Point(10, 10);
            this.taskList3.Margin = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.taskList3.Name = "taskList3";
            this.taskList3.Size = new System.Drawing.Size(617, 397);
            this.taskList3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(637, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 397);
            this.panel1.TabIndex = 2;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(73, 25);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(615, 395);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage2.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.metroTabPage2.Controls.Add(this.devicePresetList1);
            this.metroTabPage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(607, 362);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "DEVICES";
            this.metroTabPage2.UseCustomBackColor = true;
            this.metroTabPage2.UseCustomForeColor = true;
            this.metroTabPage2.UseStyleColors = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // devicePresetList1
            // 
            this.devicePresetList1.BackColor = System.Drawing.Color.Transparent;
            this.devicePresetList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicePresetList1.ForeColor = System.Drawing.Color.White;
            this.devicePresetList1.Location = new System.Drawing.Point(0, 0);
            this.devicePresetList1.Margin = new System.Windows.Forms.Padding(10);
            this.devicePresetList1.Name = "devicePresetList1";
            this.devicePresetList1.Size = new System.Drawing.Size(607, 362);
            this.devicePresetList1.TabIndex = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.metroTabPage3.Controls.Add(this.efl_effectlist);
            this.metroTabPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(607, 362);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "EFFECTS";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // efl_effectlist
            // 
            this.efl_effectlist.BackColor = System.Drawing.Color.Transparent;
            this.efl_effectlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.efl_effectlist.EnablingEnabled = false;
            this.efl_effectlist.ForeColor = System.Drawing.Color.White;
            this.efl_effectlist.Location = new System.Drawing.Point(0, 0);
            this.efl_effectlist.Margin = new System.Windows.Forms.Padding(10);
            this.efl_effectlist.Name = "efl_effectlist";
            this.efl_effectlist.SelectedRowIndex = -1;
            this.efl_effectlist.SelectedTrigger = null;
            this.efl_effectlist.Size = new System.Drawing.Size(607, 362);
            this.efl_effectlist.TabIndex = 2;
            this.efl_effectlist.Triggers = null;
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.Black;
            this.pnl_sidebar.Controls.Add(this.pnl_sidebar_expand);
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 32);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(16, 688);
            this.pnl_sidebar.TabIndex = 100;
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
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_sidebar);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALFHEIM";
            this.Controls.SetChildIndex(this.pnl_sidebar, 0);
            this.Controls.SetChildIndex(this.pnl_content, 0);
            this.pnl_content.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.pnl_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_sidebar_expand;
        private TableLayoutPanel tableLayoutPanel1;
        private UserControls.TaskList taskList3;
        private Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private UserControls.EffectList efl_effectlist;
        private Panel panel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private UserControls.TriggerList trl_triggerlist;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private UserControls.DevicePresetList devicePresetList1;
        private UserControls.Timeline timeline1;
    }
}

