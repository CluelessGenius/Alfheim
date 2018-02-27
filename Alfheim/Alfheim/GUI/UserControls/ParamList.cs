using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alfheim_Model.TRIGGERS;
using Alfheim_Model;
using Alfheim_Model.DEVICES;

namespace Alfheim.GUI.UserControls
{
    public partial class ParamList : UserControl
    {
        private ParamListType paramType;

        private List<Param> parameters;

        public List<Param> Parameters
        {
            get { return parameters; }
            set
            {
                if (value != null)
                {
                    parameters = value;
                    RefreshParamList();
                }
            }
        }

        public void RefreshParamList()
        {
            if (parameters==null)
            {
                return;
            }
            pnl_parameters.Controls.Clear();
            List<ParamListEntry> entrycontrols = parameters.Select(t => (new ParamListEntry(t))).ToList();
            entrycontrols.ForEach(e => 
            {
                e.Width = pnl_parameters.Width - 20;
                e.Clicked += Entry_Clicked;
                e.Deleted += Entry_Deleted;
                pnl_parameters.Controls.Add(e);
            });
        }


        private void Addbutton_Clicked(object sender, EventArgs e)
        {
            switch (paramType)
            {
                case ParamListType.TRIGGER:
                    Parameters.Add(new Trigger() { Name = "Dummy Trigger Static" });
                    break;
                case ParamListType.DEVICES:
                    Parameters.Add(new Device() { Name = "Dummy Device Static" });
                    break;
                case ParamListType.ACTIONS:
                    Parameters.Add(new Alfheim_Model.ACTIONS.Action() { Name = "Dummy Action Static" });
                    break;
                default:
                    break;
            }
            
            RefreshParamList();
        }

        private void Entry_Deleted(object sender, EventArgs e)
        {
            Parameters.Remove((sender as ParamListEntry).Param);
            pnl_parameters.Controls.Remove((sender as ParamListEntry));
            triggerDetail1.DetailedParam = null;
        }

        public int SelectedRowIndex { get; set; }

        public Param SelectedTrigger { get; set; }

        public ParamListType ParamType
        {
            get { return paramType; }
            set
            {
                paramType = value;
                lbl_name.Text = paramType.ToString();
            }
        }

        public ParamList()
        {
            InitializeComponent();
            parameters = new List<Param>();
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            foreach (ParamListEntry entry in pnl_parameters.Controls)
            {
                if (entry.BackColor != Color.Transparent)
                {
                    entry.BackColor = Color.Transparent;
                    break;
                }
            }
            (sender as ParamListEntry).BackColor = Color.FromArgb(209, 65, 26);
            SelectedRowIndex = pnl_parameters.Controls.IndexOf(sender as ParamListEntry);
            SelectedTrigger = Parameters[SelectedRowIndex];
            triggerDetail1.DetailedParam = SelectedTrigger;
        }

        
    }

    public enum ParamListType
    {
        TRIGGER,
        DEVICES,
        ACTIONS
    }
}
