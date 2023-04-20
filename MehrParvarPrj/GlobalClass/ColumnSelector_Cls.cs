using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.DataLinq;

namespace MehrParvarPrj
{
    public class ColumnSelector_Cls
    {
        private static DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        public static CheckBox CB = new CheckBox();


        public static void ComboBoxSelectorBind(DevComponents.DotNetBar.Controls.ComboBoxEx cmbSelector, short FieldSelectType)
        {
            var SUS = from prd in DCMDC.TBL_FieldSelectors
                      where prd.FieldSelectType == FieldSelectType
                      select new { prd.FieldSelectName, prd.FieldSelectId };
            cmbSelector.DisplayMember = "FieldSelectName";
            cmbSelector.ValueMember = "FieldSelectId";
            cmbSelector.DataSource = SUS;
        }

        public static void CheckBoxChanged(object sender, DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            CB = (CheckBox)sender;
            string StrName = CB.Name.Substring(3);

            foreach (DevExpress.XtraGrid.Columns.GridColumn df in gv.Columns)
            {
                if (df.Name == StrName)
                {
                    if (CB.Tag != null)
                        df.Width = Convert.ToInt16(CB.Tag);

                    if (CB.Checked) df.VisibleIndex = 0;
                    else df.Visible = false;
                }
            }
        }

        public static void ComboBoxSelectValueChange(DevComponents.DotNetBar.Controls.ComboBoxEx cmbSelector, Panel Pnl)
        {
            if (cmbSelector.Text == "") return;

            foreach (var CHK in Pnl.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                if (CHK is CheckBox)
                    (CHK as CheckBox).Checked = false;

            string StrChecked = DCMDC.TBL_FieldSelectors.First(hf => hf.FieldSelectId.Equals(cmbSelector.SelectedValue)).FieldSelectValue;
            Dictionary<string, Dictionary<string, int>> df = new Dictionary<string, Dictionary<string, int>>(SetStrChecked(StrChecked));

            foreach (var CHK5 in df)
            {
                (Pnl.Controls.Cast<Control>().First(d => d is CheckBox && d.Name == CHK5.Key) as CheckBox).Tag = df[CHK5.Key]["WD"];
                (Pnl.Controls.Cast<Control>().First(d => d is CheckBox && d.Name == CHK5.Key) as CheckBox).Checked = true;
            }
        }


        private static Dictionary<string, Dictionary<string, int>> SetStrChecked(string StrChecked)
        {
            Dictionary<string, Dictionary<string, int>> hg = new Dictionary<string, Dictionary<string, int>>();
            while (StrChecked != "")
            {
                Dictionary<string, int> f = new Dictionary<string, int>();

                f.Add("WD", int.Parse(StrChecked.Substring(StrChecked.IndexOf("-WD:") + 4, StrChecked.IndexOf(";") - StrChecked.IndexOf("-WD:") - 4)));

                hg.Add(StrChecked.Substring(0, StrChecked.IndexOf("-")), f);
                StrChecked = StrChecked.Remove(0, StrChecked.IndexOf(";") + 1);
            }

            return hg;
        }


        public static void SaveChange(DevExpress.XtraGrid.Views.Grid.GridView gv, DevComponents.DotNetBar.Controls.ComboBoxEx cmbSelector, short FieldSelectType)
        {
            //1: ListDocPat_UC
            //2: ListPatientVisit
            //3: ListVisitHistory
            //4: ListDoctorPayment
            //5: ListPatientVisitReport
            //6: ListDelDocPat

            if (cmbSelector.Text == "") return;

            string StrChecked = "";

            foreach (DevExpress.XtraGrid.Columns.GridColumn dgv in
                gv.Columns.Cast<DevExpress.XtraGrid.Columns.GridColumn>().OrderByDescending(d => d.VisibleIndex).Where(j => j.VisibleIndex != -1))
            {
                StrChecked += "chk" + dgv.Name +
                    "-WD:" + gv.Columns[dgv.Name].Width + ";";
            }


            if ((from gh in DCMDC.TBL_FieldSelectors where gh.FieldSelectName == cmbSelector.Text && gh.FieldSelectType == FieldSelectType select gh).Count() > 0)
            {
                TBL_FieldSelector TF = DCMDC.TBL_FieldSelectors.First(hj => hj.FieldSelectId == int.Parse(cmbSelector.SelectedValue.ToString()));
                TF.FieldSelectValue = StrChecked;
                DCMDC.SubmitChanges();

                int indx = cmbSelector.SelectedIndex;

                ComboBoxSelectorBind(cmbSelector, FieldSelectType);
                
                cmbSelector.SelectedIndex = indx;
            }
            else
            {
                TBL_FieldSelector TF = new TBL_FieldSelector();
                TF.FieldSelectType = FieldSelectType;
                TF.FieldSelectName = cmbSelector.Text;
                TF.FieldSelectValue = StrChecked;
                DCMDC.TBL_FieldSelectors.InsertOnSubmit(TF);
                DCMDC.SubmitChanges();

                ComboBoxSelectorBind(cmbSelector, FieldSelectType);
                cmbSelector.SelectedIndex = cmbSelector.Items.Count - 1;
            }
        }


    }
}
