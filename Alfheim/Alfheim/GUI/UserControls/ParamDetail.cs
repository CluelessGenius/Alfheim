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
using System.Reflection;

namespace Alfheim.GUI.UserControls
{
    public partial class ParamDetail : UserControl
    {
        private Trigger detailedParam;
        
        public ParamDetail()
        {
            InitializeComponent();
        }
        
        //public void RefreshData()
        //{
        //    pnl_proplist?.Controls?.Clear();
        //    lbl_name?.DataBindings?.Clear();
        //    lbl_name.Text="";
        //    if (detailedParam == null)
        //    {
        //        return;
        //    }
        //    else if (detailedParam.Name != null)
        //    {
        //        lbl_name.DataBindings.Add(new Binding("Text", DetailedParam, "Name"));
        //        List<PropertyInfo> props = detailedParam.GetType().GetProperties().Where(p=>p.CustomAttributes.Any(c => c.AttributeType == typeof(DetailOrder))).ToList();
        //        props.Sort((x,y) => GetDetailorder(x).CompareTo(GetDetailorder(y)));
        //        foreach (PropertyInfo pinf in props)
        //        {
        //            if (pinf.PropertyType.Name == nameof(String))
        //            {
        //                var stringedit = new ParamStringEdit(pinf.Name, pinf.GetValue(detailedParam)?.ToString());
        //                stringedit.Width = Width - 20;
        //                stringedit.StringChanged += Edit_ValueChanged;
        //                pnl_proplist.Controls.Add(stringedit);
        //            }
        //            else if (pinf.PropertyType.Name == nameof(Boolean))
        //            {
        //                var booledit = new ParamBoolEdit(pinf.Name, (bool)pinf.GetValue(detailedParam));
        //                booledit.Width = Width - 20;
        //                booledit.BoolChanged += Edit_ValueChanged;
        //                pnl_proplist.Controls.Add(booledit);
        //            }
        //            else if (pinf.PropertyType.IsEnum)
        //            {
        //                var enumedit = new ParamEnumEdit(pinf.Name, pinf.GetValue(detailedParam));
        //                enumedit.Width = Width - 20;
        //                enumedit.EnumChanged += Edit_ValueChanged;
        //                pnl_proplist.Controls.Add(enumedit);
        //            }
        //        }
        //    }
        //}

        private int GetDetailorder(PropertyInfo p)
        {
            return Convert.ToInt32(p.CustomAttributes.Single(c => c.AttributeType == typeof(DetailOrder)).NamedArguments.Single(a => a.MemberName == "Position").TypedValue.Value);
        }

        private void Edit_ValueChanged(object sender, ValuechangedEventArgs e)
        {
            if (e == null || String.IsNullOrEmpty(e.Property) || e.NewValue == null )
            {
                return;
            }
            detailedParam.GetType().GetProperty(e.Property).SetValue(detailedParam, e.NewValue);
        }

        public Trigger DetailedTrigger
        {
            get { return detailedParam; }
            set
            {
                detailedParam = value;
                //RefreshData();
            }
        }
    }

    public class ValuechangedEventArgs : EventArgs
    {
        public string Property { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
    }
    
}
