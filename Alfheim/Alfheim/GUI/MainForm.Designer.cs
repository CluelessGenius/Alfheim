﻿using System;
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
            this.pnl_sysmon = new System.Windows.Forms.Panel();
            this.pnl_sysmon_expand = new System.Windows.Forms.Panel();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.pnl_sidebar_expand = new System.Windows.Forms.Panel();
            this.taskList3 = new Alfheim.GUI.UserControls.TaskList();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.trl_triggerlist = new Alfheim.GUI.UserControls.TriggerList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_content.SuspendLayout();
            this.pnl_sysmon.SuspendLayout();
            this.pnl_sidebar.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.Transparent;
            this.pnl_content.Controls.Add(this.tableLayoutPanel1);
            this.pnl_content.Controls.Add(this.pnl_sysmon);
            this.pnl_content.Controls.Add(this.pnl_sidebar);
            this.pnl_content.Location = new System.Drawing.Point(0, 32);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(1280, 688);
            this.pnl_content.TabIndex = 8;
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
            // taskList3
            // 
            this.taskList3.BackColor = System.Drawing.Color.Transparent;
            this.taskList3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskList3.ForeColor = System.Drawing.Color.White;
            this.taskList3.Location = new System.Drawing.Point(10, 10);
            this.taskList3.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.taskList3.Name = "taskList3";
            this.taskList3.SelectedTask = null;
            this.taskList3.Size = new System.Drawing.Size(609, 668);
            this.taskList3.TabIndex = 1;
            this.taskList3.Tasks = ((System.Collections.Generic.List<Alfheim_Model.Task>)(resources.GetObject("taskList3.Tasks")));
            this.taskList3.SelectionChanged += new System.EventHandler(this.TaskList3_SelectionChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(607, 666);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage2.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.metroTabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(599, 621);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "ACTIONS";
            this.metroTabPage2.UseCustomBackColor = true;
            this.metroTabPage2.UseCustomForeColor = true;
            this.metroTabPage2.UseStyleColors = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.metroTabPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(599, 621);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "EFFECTS";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.metroTabPage1.Controls.Add(this.trl_triggerlist);
            this.metroTabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(599, 621);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "TRIGGERS";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // trl_triggerlist
            // 
            this.trl_triggerlist.BackColor = System.Drawing.Color.Transparent;
            this.trl_triggerlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trl_triggerlist.EnablingEnabled = false;
            this.trl_triggerlist.ForeColor = System.Drawing.Color.White;
            this.trl_triggerlist.Location = new System.Drawing.Point(0, 0);
            this.trl_triggerlist.Margin = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.trl_triggerlist.Name = "trl_triggerlist";
            this.trl_triggerlist.SelectedRowIndex = -1;
            this.trl_triggerlist.SelectedTrigger = null;
            this.trl_triggerlist.Size = new System.Drawing.Size(599, 621);
            this.trl_triggerlist.TabIndex = 0;
            this.trl_triggerlist.Triggers = null;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(629, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 668);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.taskList3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 688);
            this.tableLayoutPanel1.TabIndex = 101;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Alfheim.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnl_content);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALFHEIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Controls.SetChildIndex(this.pnl_content, 0);
            this.pnl_content.ResumeLayout(false);
            this.pnl_sysmon.ResumeLayout(false);
            this.pnl_sidebar.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_sidebar_expand;
        private System.Windows.Forms.Panel pnl_sysmon;
        private System.Windows.Forms.Panel pnl_sysmon_expand;
        private TableLayoutPanel tableLayoutPanel1;
        private UserControls.TaskList taskList3;
        private Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private UserControls.TriggerList trl_triggerlist;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}

