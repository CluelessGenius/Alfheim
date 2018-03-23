using Alfheim.GUI.UserControls;
using Alfheim_Model;
using Alfheim_Model.EFFECTS;
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
        DataManager dataManager;

        public MainForm():base()
        {
            InitializeComponent();
            dataManager = new DataManager();
            dataManager.TaskManager.PropertyChanged += TaskManager_PropertyChanged;
            taskList3.SetDataManager(dataManager.TaskManager);
            trl_triggerlist.SetDataManager(dataManager.TriggerManager);
        }
        

        private void TaskManager_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is DataMemberManager<Task>)
            {
                var sendermgr = (sender as DataMemberManager<Task>);
                switch (e.PropertyName)
                {
                    case nameof(sendermgr.SelectedMember):
                        trl_triggerlist.SetTogglesEnabled(sendermgr.SelectedMember!=null);
                        break;
                    default:
                        break;
                }
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
        
        
    }
}
