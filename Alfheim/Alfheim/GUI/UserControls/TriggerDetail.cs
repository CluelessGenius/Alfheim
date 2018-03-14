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
    public partial class TriggerDetail : UserControl
    {
        private Trigger detailedTrigger;
        
        public TriggerDetail()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            pnl_proplist?.Controls?.Clear();
            lbl_name?.DataBindings?.Clear();
            lbl_name.Text = "";
            if (detailedTrigger == null)
            {
                return;
            }
            else if (detailedTrigger.Name != null)
            {
                lbl_name.DataBindings.Add(new Binding("Text", DetailedTrigger, "Name"));
                List<PropertyInfo> props = detailedTrigger.GetType().GetProperties().Where(p => p.CustomAttributes.Any(c => c.AttributeType == typeof(DetailOrder))).ToList();
                props.Sort((x, y) => GetDetailorder(x).CompareTo(GetDetailorder(y)));
                foreach (PropertyInfo pinf in props)
                {
                    bool wasadded = AddCustomControl(pinf, detailedTrigger, pinf.Name);
                    if (!wasadded && pinf.PropertyType.IsClass && !pinf.PropertyType.FullName.StartsWith("System."))
                    {
                        Type realtype = pinf.GetValue(detailedTrigger).GetType();
                        List<PropertyInfo> ps = realtype.GetProperties().Where(p => p.CustomAttributes.Any(c => c.AttributeType == typeof(DetailOrder))).ToList();
                        ps.Sort((x, y) => GetDetailorder(x).CompareTo(GetDetailorder(y)));
                        foreach (PropertyInfo p in ps)
                        {
                            AddCustomControl(p, pinf.GetValue(detailedTrigger), pinf.Name+"."+p.Name);
                        }
                    }
                }
            }
        }

        private bool AddCustomControl(PropertyInfo p, object valueobject,string proppath)
        {
            if (p.PropertyType.Name == nameof(String))
            {
                var stringedit = new ParamStringEdit(proppath, p.GetValue(valueobject)?.ToString());
                stringedit.Width = Width - 30;
                stringedit.StringChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(stringedit);
                return true;
            }
            else if (p.PropertyType == typeof(long))
            {
                var numericedit = new ParamNumericEdit(proppath, (long)p.GetValue(valueobject));
                numericedit.Width = Width - 30;
                numericedit.NumberChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(numericedit);
                return true;
            }
            else if (p.PropertyType.Name == nameof(Boolean))
            {
                var booledit = new ParamBoolEdit(proppath, (bool)p.GetValue(valueobject));
                booledit.Width = Width - 30;
                booledit.BoolChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(booledit);
                return true;
            }
            else if (p.PropertyType.IsEnum)
            {
                var enumedit = new ParamEnumEdit(proppath, p.GetValue(valueobject));
                enumedit.Width = Width - 30;
                enumedit.EnumChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(enumedit);
                return true;
            }
            else if (p.PropertyType == typeof(DateTime))
            {
                var datetimeedit = new ParamDateTimeEdit(proppath, (DateTime)p.GetValue(valueobject));
                datetimeedit.Width = Width - 30;
                datetimeedit.DateTimeChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(datetimeedit);
                return true;
            }
            else
            {
                return false;
            }
        }


        private int GetDetailorder(PropertyInfo p)
        {
            return Convert.ToInt32(p.CustomAttributes.Single(c => c.AttributeType == typeof(DetailOrder)).NamedArguments.Single(a => a.MemberName == "Position").TypedValue.Value);
        }

        private void Edit_ValueChanged(object sender, ValuechangedEventArgs e)
        {
            if (e == null || String.IsNullOrEmpty(e.Property) || e.NewValue == null)
            {
                return;
            }
            string[] proppath = e.Property.Split('.');
            if (proppath.Last() == "TriggerType" && (TriggerType)e.NewValue == detailedTrigger.TriggerType)
            {
                return;
            }
            object objecttochange = detailedTrigger;
            for (int i = 1; i < proppath.Length; i++)
            {
                objecttochange = objecttochange.GetType().GetProperty(proppath[i-1]).GetValue(objecttochange);
            }
            objecttochange.GetType().GetProperty(proppath.Last()).SetValue(objecttochange, e.NewValue);

            if (proppath.Last() == "TriggerType")
            {
                RefreshData();
            }
        }

        public Trigger DetailedTrigger
        {
            get { return detailedTrigger; }
            set
            {
                detailedTrigger = value;
                RefreshData();
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
