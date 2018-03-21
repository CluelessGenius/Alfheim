using Alfheim_Model;
using Alfheim_Model.TRIGGERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Alfheim.GUI.UserControls
{
    public partial class TriggerDetail : UserControl
    {
        private Trigger detailedTrigger;

        public TriggerDetail()
        {
            InitializeComponent();
        }
        
        public Trigger DetailedTrigger
        {
            get { return detailedTrigger; }
        }

        public void SetDetailedTrigger(Trigger trigger)
        {
            detailedTrigger = trigger;
            detailedTrigger.PropertyChanged += DetailedTrigger_PropertyChanged;
            RefreshData();
        }

        private void DetailedTrigger_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is Trigger)
            {
                var trigsender = (sender as Trigger);
                switch (e.PropertyName)
                {
                    case nameof(trigsender.Name):
                        lbl_name.Text = trigsender.Name;
                        break;
                    case nameof(trigsender.TriggerType):
                        RefreshData();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                //var names = pnl_proplist.Controls.Cast<IReflectionEdit>().First(edit=>edit.Propertyname=="Trig."+e.PropertyName);
                
                //string[] proppath = e.Property.Split('.');
                //object objecttochange = triggerManager.Members.Single(t => t.ID == e.ID);
                //for (int i = 1; i < proppath.Length; i++)
                //{
                //    objecttochange = objecttochange.GetType().GetProperty(proppath[i - 1]).GetValue(objecttochange);
                //}
                //objecttochange.GetType().GetProperty(proppath.Last()).SetValue(objecttochange, e.NewValue);
                
            }

        }

        public void RefreshData()
        {
            SuspendLayout();
            pnl_proplist?.Controls?.Clear();
            lbl_name.Text = "";
            if (detailedTrigger == null)
            {
                return;
            }
            else
            {
                lbl_name.Text = detailedTrigger.Name;
                AddPropertiesOf(detailedTrigger);
            }
        }

        private void AddPropertiesOf(object source, string proppath="")
        {
            
            List<PropertyInfo> props = source.GetType().GetProperties().Where(p => p.CustomAttributes.Any(c => c.AttributeType == typeof(DetailOrder))).ToList();
            props.Sort((x, y) => GetDetailorder(x).CompareTo(GetDetailorder(y)));

            foreach (PropertyInfo pinf in props)
            {
                string path = proppath;
                if (!String.IsNullOrEmpty(proppath))
                {
                    path += ".";
                }
                path += pinf.Name;
                bool wasadded = AddCustomControl(pinf, source, path);

                if (!wasadded && pinf.PropertyType.IsClass && !pinf.PropertyType.FullName.StartsWith("System."))
                {
                    object realobject = pinf.GetValue(source);
                    AddPropertiesOf(realobject, path);
                }
            }
        }

        private bool AddCustomControl(PropertyInfo p, object valueobject, string proppath)
        {
            if (p.PropertyType == typeof(string))
            {
                var stringedit = new ParamStringEdit(proppath, p.GetValue(valueobject)?.ToString(), detailedTrigger.ID);
                stringedit.Width = Width - 30;
                stringedit.StringChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(stringedit);
                return true;
            }
            else if (p.PropertyType == typeof(long))
            {
                var numericedit = new ParamNumericEdit(proppath, (long)p.GetValue(valueobject), detailedTrigger.ID);
                numericedit.Width = Width - 30;
                numericedit.NumberChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(numericedit);
                return true;
            }
            else if (p.PropertyType == typeof(bool))
            {
                var booledit = new ParamBoolEdit(proppath, (bool)p.GetValue(valueobject), detailedTrigger.ID);
                booledit.Width = Width - 30;
                booledit.BoolChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(booledit);
                return true;
            }
            else if (p.PropertyType.IsEnum)
            {
                var enumedit = new ParamEnumEdit(proppath, p.GetValue(valueobject), detailedTrigger.ID);
                enumedit.Width = Width - 30;
                enumedit.EnumChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(enumedit);
                return true;
            }
            else if (p.PropertyType == typeof(DateTime))
            {
                var dateedit = new ParamDateTimeEdit(proppath, (DateTime)p.GetValue(valueobject), detailedTrigger.ID);
                dateedit.Width = Width - 30;
                dateedit.DateTimeChanged += Edit_ValueChanged;
                pnl_proplist.Controls.Add(dateedit);
                return true;
            }
            else
            {
                return false;
            }
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
                objecttochange = objecttochange.GetType().GetProperty(proppath[i - 1]).GetValue(objecttochange);
            }
            objecttochange.GetType().GetProperty(proppath.Last()).SetValue(objecttochange, e.NewValue);

        }

        private int GetDetailorder(PropertyInfo p)
        {
            return Convert.ToInt32(p.CustomAttributes.First(c => c.AttributeType == typeof(DetailOrder)).NamedArguments.Single(a => a.MemberName == "Position").TypedValue.Value);
        }
    }
}