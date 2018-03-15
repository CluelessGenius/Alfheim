using Alfheim.GUI.UserControls;
using Alfheim_Model;
using Alfheim_Model.TRIGGERS;
using Alfheim_ViewModel;
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
        DataManager dataManager = new DataManager();
        public List<Task> Tasks = new List<Task>();
        public List<Trigger> Triggers = new List<Trigger>();

        public MainForm():base()
        {
            InitializeComponent();
            Tasks = dataManager.LoadTasks();
            Triggers = dataManager.LoadTriggers();
            taskList3.Tasks = Tasks;
            trl_triggerlist.Triggers = Triggers;
            trl_triggerlist.TriggerEnabledChanged += Trl_triggerlist_TriggerEnabledChanged;
        }

        private void Trl_triggerlist_TriggerEnabledChanged(object sender, EventArgs e)
        {
            if ((bool)(e as ValuechangedEventArgs).NewValue && !taskList3.SelectedTask.Triggers.Contains((sender as Trigger).ID))
            {
                taskList3.SelectedTask.Triggers.Add((sender as Trigger).ID);
            }
            else if (!(bool)(e as ValuechangedEventArgs).NewValue && taskList3.SelectedTask.Triggers.Contains((sender as Trigger).ID))
            {
                taskList3.SelectedTask.Triggers.Remove((sender as Trigger).ID);
            }
            
        }

        private void TaskList3_SelectionChanged(object sender, EventArgs e)
        {
            trl_triggerlist.EnablingEnabled = taskList3.SelectedTask != null;
            if (taskList3.SelectedTask!=null)
            {
                trl_triggerlist.SetToggles(taskList3.SelectedTask.Triggers);
            }
        }

        private void pnl_sidebar_expand_Click(object sender, EventArgs e)
        {
            if (pnl_sidebar.Width >= 200)
            {
                base.SuspendLayout();
                this.SuspendLayout();
                pnl_sidebar.Width = 16;
                base.ResumeLayout();
                this.ResumeLayout();
            }
            else
            {
                base.SuspendLayout();
                this.SuspendLayout();
                pnl_sidebar.Width = 200;
                base.ResumeLayout();
                this.ResumeLayout();
            }
        }

        private void pnl_sysmon_expand_Click(object sender, EventArgs e)
        {
            if (pnl_sysmon.Width >= 200)
            {
                base.SuspendLayout();
                this.SuspendLayout();
                Width -= 400 - 16;
                pnl_sysmon.Width = 16;
                base.ResumeLayout();
                this.ResumeLayout();
            }
            else
            {
                base.SuspendLayout();
                this.SuspendLayout();
                pnl_sysmon.Width = 400;
                Width += 400 - 16;
                base.ResumeLayout();
                this.ResumeLayout();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataManager.SaveTasks(Tasks);
            dataManager.SaveTriggers(Triggers);
        }
        
    }
}
