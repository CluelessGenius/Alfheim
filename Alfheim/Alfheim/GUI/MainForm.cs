using Alfheim.GUI.UserControls;
using Alfheim_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alfheim.GUI
{
    public partial class MainForm : ResizableNonBorderForm
    {
        List<Task> Tasks = new List<Task>();
        Task DetailedTask = new Task();

        public MainForm():base()
        {
            InitializeComponent();
            taskBindingSource.DataSource = Tasks;
        }

        private void btn_tasks_add_Click(object sender, EventArgs e)
        {
            Tasks.Add(new Task());
            taskBindingSource.ResetBindings(false);
        }
        
        private void btn_tasks_del_Click(object sender, EventArgs e)
        {
            if (dgv_tasks_grid.SelectedRows.Count==0)
            {
                return;
            }
            Tasks.RemoveAt(dgv_tasks_grid.SelectedRows[0].Index);
            taskBindingSource.ResetBindings(false);
        }

        private void dgv_tasks_grid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            if (null != gridView && row.HeaderCell.Value==null)
            {
                row.HeaderCell.Value = (e.RowIndex+1).ToString();
            }
        }

        private void dgv_tasks_grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.ColumnIndex>=0 && e.RowIndex >= 0)
            //{
            //    string column = dgv_tasks_grid.Columns[e.ColumnIndex].Name;

            //    if (column == "enabledDataGridViewCheckBoxColumn")
            //    {
            //        e.PaintBackground(e.ClipBounds, (sender as DataGridView).SelectedRows.Contains((sender as DataGridView).Rows[e.RowIndex]));
            //        MetroFramework.Controls.MetroToggle toggle = new MetroFramework.Controls.MetroToggle();
            //        toggle.Checked = (taskBindingSource[e.RowIndex] as Task).Enabled;
                    
            //        e.Handled = true;
            //    }
            //}
        }

        private void dgv_tasks_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tasks_grid.SelectedRows==null || dgv_tasks_grid.SelectedRows.Count == 0 || dgv_tasks_grid.SelectedRows[0]==null || dgv_tasks_grid.SelectedRows[0].Index<0)
            {
                return;
            }

            DetailedTask = taskBindingSource[dgv_tasks_grid.SelectedRows[0].Index] as Task;
            if (DetailedTask!=null)
            {
                trl_detail_trigger.Visible = true;
            }
            else
            {
                trl_detail_trigger.Visible = false;
            }
            trl_detail_trigger.Triggers = DetailedTask.Triggers;
            
            clb_detail_devices.Items.Clear();
            clb_detail_devices.Items.AddRange(DetailedTask.Devices.ToArray());
            clb_detail_actions.Items.Clear();
            clb_detail_actions.Items.AddRange(DetailedTask.Actions.ToArray());

            propertyGrid1.SelectedObject = DetailedTask;
        }

        private void clb_detail_MouseClick(object sender, MouseEventArgs e)
        {
            if ((sender as CheckedListBox).SelectedIndex < 0)
            {
                return;
            }
            switch ((sender as CheckedListBox).Name)
            {
                case "clb_detail_trigger":
                    pg_task_detailed.SelectedObject = DetailedTask.Triggers[(sender as CheckedListBox).SelectedIndex];
                    break;
                case "clb_detail_devices":
                    pg_task_detailed.SelectedObject = DetailedTask.Devices[(sender as CheckedListBox).SelectedIndex];
                    break;
                case "clb_detail_actions":
                    pg_task_detailed.SelectedObject = DetailedTask.Actions[(sender as CheckedListBox).SelectedIndex];
                    break;
                default:
                    break;
            }
        }
    }
}
