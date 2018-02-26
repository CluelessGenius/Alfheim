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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_tasks_add = new System.Windows.Forms.Button();
            this.btn_tasks_del = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pg_task_detailed = new System.Windows.Forms.PropertyGrid();
            this.clb_detail_devices = new System.Windows.Forms.CheckedListBox();
            this.clb_detail_actions = new System.Windows.Forms.CheckedListBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.trl_detail_trigger = new Alfheim.GUI.UserControls.TriggerList();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Triggers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tasks_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tasks_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(Alfheim_Model.Task);
            // 
            // btn_tasks_add
            // 
            this.btn_tasks_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_tasks_add.BackgroundImage = global::Alfheim.Properties.Resources.icons8_plus_math_64;
            this.btn_tasks_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tasks_add.FlatAppearance.BorderSize = 0;
            this.btn_tasks_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tasks_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_tasks_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tasks_add.Location = new System.Drawing.Point(12, 32);
            this.btn_tasks_add.Name = "btn_tasks_add";
            this.btn_tasks_add.Size = new System.Drawing.Size(32, 32);
            this.btn_tasks_add.TabIndex = 9;
            this.btn_tasks_add.UseVisualStyleBackColor = false;
            this.btn_tasks_add.Click += new System.EventHandler(this.btn_tasks_add_Click);
            // 
            // btn_tasks_del
            // 
            this.btn_tasks_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_tasks_del.BackgroundImage = global::Alfheim.Properties.Resources.icons8_trash_64;
            this.btn_tasks_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tasks_del.FlatAppearance.BorderSize = 0;
            this.btn_tasks_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tasks_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_tasks_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tasks_del.Location = new System.Drawing.Point(50, 32);
            this.btn_tasks_del.Name = "btn_tasks_del";
            this.btn_tasks_del.Size = new System.Drawing.Size(32, 32);
            this.btn_tasks_del.TabIndex = 10;
            this.btn_tasks_del.UseVisualStyleBackColor = false;
            this.btn_tasks_del.Click += new System.EventHandler(this.btn_tasks_del_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Triggers";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Devices";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Actions";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pg_task_detailed);
            this.panel1.Location = new System.Drawing.Point(973, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 326);
            this.panel1.TabIndex = 11;
            // 
            // pg_task_detailed
            // 
            this.pg_task_detailed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg_task_detailed.Location = new System.Drawing.Point(0, 0);
            this.pg_task_detailed.Name = "pg_task_detailed";
            this.pg_task_detailed.Size = new System.Drawing.Size(295, 326);
            this.pg_task_detailed.TabIndex = 0;
            // 
            // clb_detail_devices
            // 
            this.clb_detail_devices.FormattingEnabled = true;
            this.clb_detail_devices.Location = new System.Drawing.Point(337, 402);
            this.clb_detail_devices.Name = "clb_detail_devices";
            this.clb_detail_devices.Size = new System.Drawing.Size(188, 259);
            this.clb_detail_devices.TabIndex = 13;
            this.clb_detail_devices.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clb_detail_MouseClick);
            // 
            // clb_detail_actions
            // 
            this.clb_detail_actions.FormattingEnabled = true;
            this.clb_detail_actions.Location = new System.Drawing.Point(531, 402);
            this.clb_detail_actions.Name = "clb_detail_actions";
            this.clb_detail_actions.Size = new System.Drawing.Size(188, 259);
            this.clb_detail_actions.TabIndex = 14;
            this.clb_detail_actions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clb_detail_MouseClick);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(725, 382);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(242, 326);
            this.propertyGrid1.TabIndex = 1;
            // 
            // trl_detail_trigger
            // 
            this.trl_detail_trigger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trl_detail_trigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.trl_detail_trigger.Location = new System.Drawing.Point(12, 402);
            this.trl_detail_trigger.Name = "trl_detail_trigger";
            this.trl_detail_trigger.SelectedRowIndex = 0;
            this.trl_detail_trigger.SelectedTrigger = null;
            this.trl_detail_trigger.Size = new System.Drawing.Size(319, 306);
            this.trl_detail_trigger.TabIndex = 15;
            this.trl_detail_trigger.Triggers = ((System.Collections.Generic.List<Alfheim_Model.TRIGGERS.Trigger>)(resources.GetObject("trl_detail_trigger.Triggers")));
            this.trl_detail_trigger.Visible = false;
            // 
            // Actions
            // 
            this.Actions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Actions.HeaderText = "Actions";
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            // 
            // Devices
            // 
            this.Devices.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Devices.HeaderText = "Devices";
            this.Devices.Name = "Devices";
            this.Devices.ReadOnly = true;
            // 
            // Triggers
            // 
            this.Triggers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Triggers.HeaderText = "Triggers";
            this.Triggers.Name = "Triggers";
            this.Triggers.ReadOnly = true;
            this.Triggers.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // enabledDataGridViewCheckBoxColumn
            // 
            this.enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.HeaderText = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
            this.enabledDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgv_tasks_grid
            // 
            this.dgv_tasks_grid.AllowUserToAddRows = false;
            this.dgv_tasks_grid.AllowUserToDeleteRows = false;
            this.dgv_tasks_grid.AllowUserToOrderColumns = true;
            this.dgv_tasks_grid.AllowUserToResizeRows = false;
            this.dgv_tasks_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tasks_grid.AutoGenerateColumns = false;
            this.dgv_tasks_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgv_tasks_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tasks_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.enabledDataGridViewCheckBoxColumn,
            this.Triggers,
            this.Devices,
            this.Actions});
            this.dgv_tasks_grid.DataSource = this.taskBindingSource;
            this.dgv_tasks_grid.Location = new System.Drawing.Point(12, 64);
            this.dgv_tasks_grid.MultiSelect = false;
            this.dgv_tasks_grid.Name = "dgv_tasks_grid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tasks_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tasks_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_tasks_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tasks_grid.Size = new System.Drawing.Size(1256, 312);
            this.dgv_tasks_grid.TabIndex = 8;
            this.dgv_tasks_grid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_tasks_grid_CellPainting);
            this.dgv_tasks_grid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_tasks_grid_RowPrePaint);
            this.dgv_tasks_grid.SelectionChanged += new System.EventHandler(this.dgv_tasks_grid_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.trl_detail_trigger);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.clb_detail_actions);
            this.Controls.Add(this.clb_detail_devices);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_tasks_del);
            this.Controls.Add(this.btn_tasks_add);
            this.Controls.Add(this.dgv_tasks_grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ALFHEIM";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Controls.SetChildIndex(this.dgv_tasks_grid, 0);
            this.Controls.SetChildIndex(this.btn_tasks_add, 0);
            this.Controls.SetChildIndex(this.btn_tasks_del, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.clb_detail_devices, 0);
            this.Controls.SetChildIndex(this.clb_detail_actions, 0);
            this.Controls.SetChildIndex(this.propertyGrid1, 0);
            this.Controls.SetChildIndex(this.trl_detail_trigger, 0);
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tasks_grid)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PropertyGrid pg_task_detailed;
        private System.Windows.Forms.CheckedListBox clb_detail_devices;
        private System.Windows.Forms.CheckedListBox clb_detail_actions;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private UserControls.TriggerList trl_detail_trigger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Triggers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_tasks_grid;
    }
}

