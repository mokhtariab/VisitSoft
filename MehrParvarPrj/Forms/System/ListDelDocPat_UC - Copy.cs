using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.Properties;
using MehrParvarPrj.DataLinq;

namespace MehrParvarPrj
{
    public partial class ListDelDocPat_UC : UserControl
    {
        public ListDelDocPat_UC()
        {
            InitializeComponent();
            ShowListPatient(1);
            InterFaceChange();
        }
        
        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        bool IsShown = false;

        #region Load & UI
        private void ListDelDocPat_UC_Load(object sender, EventArgs e)
        {
            ColumnSelector_Cls.ComboBoxSelectorBind(comboBoxSelector, 1);
            //ComboBoxSelectorBind();
            
            IsShown = true;

            ShowListPatient(1);
            InterFaceChange();
        }

        //private void ComboBoxSelectorBind()
        //{
        //    var SUS = from prd in DCMDC.TBL_FieldSelectors
        //              where prd.FieldSelectType == 1
        //              select new { prd.FieldSelectName, prd.FieldSelectId };
        //    comboBoxSelector.DisplayMember = "FieldSelectName";
        //    comboBoxSelector.ValueMember = "FieldSelectId";
        //    comboBoxSelector.DataSource = SUS;
        //}

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAllDel.Name)) buttonItemAllDel.Enabled = false;
                if (UPer.Contains(buttonItemPatientEdit.Name)) buttonItemPatientEdit.Enabled = false;
                if (UPer.Contains(buttonItemDelPrintList.Name)) buttonItemDelPrintList.Enabled = false;
                if (UPer.Contains(buttonItemPatVisit.Name)) buttonItemPatVisit.Enabled = false;
                if (UPer.Contains(buttonItemBackPatient.Name)) buttonItemBackPatient.Enabled = false;
            }
         
        }

        private void gridView_ListDelDocPat_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.GridRowCellState state = ((DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo)e.Cell).State;

            if ((state & DevExpress.XtraGrid.Views.Base.GridRowCellState.Selected) == DevExpress.XtraGrid.Views.Base.GridRowCellState.Selected)
            {
                e.Appearance.BackColor = Color.Navy;
                e.Appearance.ForeColor = Color.White;
                e.Appearance.BorderColor = Color.White;
            }
        }

        #endregion


        #region Search

        private void ShowListPatient(int RowFocus)
        {
            gridControl_ListDelDocPat.DataSource = null;

            var SUS = from prd in DCMDC.TBL_DelPatients
                      select new
                      {
                          prd.DelType,
                          CreateDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value),
                          prd.PatientID,
                          //prd.PatientTypeId,
                          //PatientTypeDsc = prd.PatientTypeId == 0 ? "" : DCMDC.TBL_PatientTypes.First(hf => hf.PatientTypeId.Equals(prd.PatientTypeId)).PatientTypeDsc,
                          PatientTypeId = 0,
                          PatientTypeDsc = "",
                          prd.DosiersNo,
                          prd.PatientName,
                          prd.PatientFamily,
                          prd.ParentName,
                          prd.NationalCode,
                          prd.PercentState,
                          prd.KinShipWith,
                          prd.WifeSituation,
                          prd.ProtectSituation,
                          prd.WholeSituation,
                          prd.Description,

                          ContractTypeDsc = prd.ContractTypeId == 0 ? "" : DCMDC.TBL_ContractTypes.First(hf => hf.ContractTypeId.Equals(prd.ContractTypeId)).ContractTypeDsc,
                          prd.ContractTypeId,
                          prd.PeriodVisit,
                          //LastDocWatcherName = prd.LastDocWatcherId == 0 ? "" : (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.LastDocWatcherId)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.LastDocWatcherId)).DoctorFamily),
                          LastDocHealthName = DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.LastDocHealthId)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.LastDocHealthId)).DoctorFamily,
                          //prd.LastDocWatcherId,
                          prd.LastDocHealthId,
                          LastOverhalDateDsc = Global_Cls.MiladiDateToShamsi(prd.LastOverhalDate.Value),

                          prd.CityPart,
                          prd.AddressPart,

                          prd.Address,
                          prd.TelHome,
                          prd.TelBusiness,
                          prd.Mobile,
                          prd.Mobile2,
                          prd.Email,
                          prd.Active
                      };
            gridControl_ListDelDocPat.DataSource = SUS;

            chkAllPatient_CheckedChanged(this, null);

            gridView_ListDelDocPat.UnselectRow(gridView_ListDelDocPat.FocusedRowHandle);
            gridView_ListDelDocPat.SelectRow(RowFocus);

            gridView_ListDelDocPat.FocusedRowHandle = RowFocus;
        }

        string ActiveFilterStr = " ";
        private void chkAllPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsShown) return;

            string rStr = " ";
            try
            {
                rStr = gridView_ListDelDocPat.ActiveFilterString.Replace(ActiveFilterStr, " ");
            }
            catch { rStr = gridView_ListDelDocPat.ActiveFilterString; }
            try
            {
                if (rStr.Substring(rStr.Length - 4, 4).ToLower().Replace(" ", "") == "and".ToLower())
                    rStr = rStr.Remove(rStr.Length - 4);

                if (rStr.Substring(1, 4).ToLower().Replace(" ", "") == "and".ToLower())
                    rStr = rStr.Remove(1, 4);

                if (rStr.Substring(rStr.Length - 3, 3).ToLower().Replace(" ", "") == "or".ToLower())
                    rStr = rStr.Remove(rStr.Length - 3);

                if (rStr.Substring(1, 3).ToLower().Replace(" ", "") == "or".ToLower())
                    rStr = rStr.Remove(1, 3);
            }
            catch { }

            ActiveFilterStr = " ";


            if (!chkAllPatient.Checked)
                try { ActiveFilterStr = " DelType = '" + (sender as RadioButton).Text + "'"; }
                catch { }
            //else if (chkDead.Checked)
            //    ActiveFilterStr = " DelType = 'فوت' ";
            //else if (chkOther.Checked)
            //    ActiveFilterStr = " DelType <> 'انصراف' and  DelType <> 'فوت' ";

            gridView_ListDelDocPat.ActiveFilterString = ActiveFilterStr;
            ActiveFilterStr = gridView_ListDelDocPat.ActiveFilterString;

            if (rStr == " ") rStr = "";
            if (ActiveFilterStr == " ") ActiveFilterStr = "";

            if (rStr != "" && ActiveFilterStr != "") gridView_ListDelDocPat.ActiveFilterString += " and " + rStr;
            else if (rStr != "" && ActiveFilterStr == "") gridView_ListDelDocPat.ActiveFilterString = rStr;
            gridView_ListDelDocPat.ApplyColumnsFilter();
        }

        private void gridView_ListDelDocPat_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.RowHandle + 1;
        }


        #endregion


        #region All Buttons

        private void buttonItemCustomSearch_Click(object sender, EventArgs e)
        {
            gridView_ListDelDocPat.OptionsView.ShowAutoFilterRow = !gridView_ListDelDocPat.OptionsView.ShowAutoFilterRow;
            if (!buttonItemPatientSearch.Checked)
            {
                gridView_ListDelDocPat.ActiveFilterString = ActiveFilterStr;
                gridView_ListDelDocPat.ApplyColumnsFilter();
            }
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ListDelDocPat.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCustomPrintList_Click(object sender, EventArgs e)
        {
            gridView_ListDelDocPat.FormatConditions[0].Appearance.BackColor = Color.White;
            gridView_ListDelDocPat.FormatConditions[1].Appearance.BackColor = Color.White;
            gridView_ListDelDocPat.FormatConditions[2].Appearance.BackColor = Color.White;

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ListDelDocPat);
            PP.ShowDialog();

            gridView_ListDelDocPat.FormatConditions[0].Appearance.BackColor = Color.LemonChiffon;
            gridView_ListDelDocPat.FormatConditions[1].Appearance.BackColor = Color.MistyRose;
            gridView_ListDelDocPat.FormatConditions[2].Appearance.BackColor = Color.PaleGreen;      
        }


        private void buttonItemCustomEdit_Click(object sender, EventArgs e)
        {
            if (gridView_ListDelDocPat.RowCount == 0) return;
            int Index = gridView_ListDelDocPat.FocusedRowHandle;

            PatientNE_frm Uc = new PatientNE_frm(false, 0, Convert.ToInt32(gridView_ListDelDocPat.GetRowCellValue(Index, "PatientID")),false);
            Uc.ShowDialog();
            ShowListPatient(Index);
        }

        private void buttonItemBackPatient_Click(object sender, EventArgs e)
        {
            if (gridView_ListDelDocPat.RowCount == 0) return;
            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این بیمار به لیست اصلی منتقل شود؟")) return;
            int Index = gridView_ListDelDocPat.FocusedRowHandle;

            DCMDC.SP_InsDelRecordMehrParvar(Convert.ToInt32(gridView_ListDelDocPat.GetRowCellValue(Index, "PatientID")), false, (sender as DevComponents.DotNetBar.ButtonItem).Text);
            DCMDC.SubmitChanges();

            ShowListPatient(Index);

        }

        private void buttonItemAllDel_Click(object sender, EventArgs e)
        {

            if (gridView_ListDelDocPat.RowCount == 0) return;
            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این بیمار(ان) از سیستم به طور کلی و با پرونده پزشکی حذف شود؟")) return;


            int[] Index = gridView_ListDelDocPat.GetSelectedRows();
            for (int i = 0; i < gridView_ListDelDocPat.SelectedRowsCount; i++)
            {
                try
                {
                    if ((from f in DCMDC.TBL_DelPatientVisits
                         where f.PatientID == Convert.ToInt32(gridView_ListDelDocPat.GetRowCellValue(Index[i], "PatientID"))
                         select f).Count() > 0)
                    {
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف کلی بیمار به واسطه وجود پرونده پزشکی نمی باشد");
                        continue;
                    }
                }
                catch
                { }

                DCMDC.SP_DeletePatient(Convert.ToInt32(gridView_ListDelDocPat.GetRowCellValue(Index[i], "PatientID")));
                DCMDC.SubmitChanges();
            }

            ShowListPatient(Index[0]);
        }

        private void buttonItemPatVisit_Click(object sender, EventArgs e)
        {
            int Index = gridView_ListDelDocPat.FocusedRowHandle;

            ListPatientVisit_UC Uc = new ListPatientVisit_UC(false, false, Convert.ToInt32(gridView_ListDelDocPat.GetRowCellValue(Index, "PatientID")));
            Global_Cls.MainForm.AddTabToTabControl("ListPatientVisit" + gridView_ListDelDocPat.GetRowCellValue(Index, "PatientID"),
                "پرونده " + gridView_ListDelDocPat.GetRowCellValue(Index, "PatientName").ToString() + " " + gridView_ListDelDocPat.GetRowCellValue(Index, "PatientFamily").ToString(), Uc);

        }
        
        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            ShowListPatient(gridView_ListDelDocPat.FocusedRowHandle);
        }

      
        #endregion


        #region Set CheckBox
        //CheckBox CB = new CheckBox();
        private void chkPatientTypeStr_CheckedChanged(object sender, EventArgs e)
        {
            //CB = (CheckBox)sender;
            //string StrName = CB.Name.Substring(3);

            //int abs = 0;
            //foreach (DevExpress.XtraGrid.Columns.GridColumn df in gridView_ListDelDocPat.Columns)
            //{
            //    if (df.Name == StrName)
            //    {
            //        if (CB.Tag != null)
            //            df.Width = Convert.ToInt16(CB.Tag);

            //        foreach (var CHK in panel_Selector.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //            if ((CHK is CheckBox) && (CHK as CheckBox).TabIndex <= Convert.ToInt32(df.Tag) && !(CHK as CheckBox).Checked)
            //                abs++;
            //        df.VisibleIndex = CB.TabIndex - abs;
            //        df.Visible = CB.Checked;
            //    }
            //}

            ColumnSelector_Cls.CheckBoxChanged(sender, gridView_ListDelDocPat);
        }

        private void comboBoxSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.ComboBoxSelectValueChange(comboBoxSelector, panel_Selector);

            //if (comboBoxSelector.Text == "") return;

            //foreach (var CHK in panel_Selector.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //    if (CHK is CheckBox)
            //    {
            //        (CHK as CheckBox).Checked = false;
            //        //(CHK as CheckBox).TabIndex = 0;
            //    }

            //foreach (DevExpress.XtraGrid.Columns.GridColumn dgv in gridView_ListDelDocPat.Columns)
            //    dgv.Visible = false;


            //string StrChecked = DCMDC.TBL_FieldSelectors.First(hf => hf.FieldSelectId.Equals(comboBoxSelector.SelectedValue)).FieldSelectValue;
            //Dictionary<string, Dictionary<string, int>> df = new Dictionary<string, Dictionary<string, int>>(SetStrChecked(StrChecked));

            //foreach (var CHK in panel_Selector.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //    if (CHK is CheckBox)
            //        if (StrChecked.Contains((CHK as CheckBox).Name))
            //        {
            //            // (CHK as CheckBox).TabIndex = df[(CHK as CheckBox).Name]["TI"];
            //            (CHK as CheckBox).Tag = df[(CHK as CheckBox).Name]["WD"];
            //            (CHK as CheckBox).Checked = true;
            //        }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ColumnSelector_Cls.SaveChange(gridView_ListDelDocPat, comboBoxSelector, 6);

            //if (comboBoxSelector.Text == "") return;

            //string StrChecked = "";

            //foreach (Control CHK in panel_Selector.Controls.Cast<Control>()
            //                         .OrderBy(c => c.TabIndex))
            //{
            //    if (CHK is CheckBox)
            //        if ((CHK as CheckBox).Checked)
            //            StrChecked += (CHK as CheckBox).Name +
            //                "-TI:" + gridView_ListDelDocPat.Columns[(CHK as CheckBox).Name.Substring(3)].VisibleIndex +
            //                "-WD:" + gridView_ListDelDocPat.Columns[(CHK as CheckBox).Name.Substring(3)].Width + ";";
            //}

            //if ((from gh in DCMDC.TBL_FieldSelectors where gh.FieldSelectName == comboBoxSelector.Text && gh.FieldSelectType == 1 select gh).Count() > 0)
            //{
            //    TBL_FieldSelector TF = DCMDC.TBL_FieldSelectors.First(hj => hj.FieldSelectId == int.Parse(comboBoxSelector.SelectedValue.ToString()));
            //    TF.FieldSelectValue = StrChecked;
            //    DCMDC.SubmitChanges();

            //    int indx = comboBoxSelector.SelectedIndex;
            //    ComboBoxSelectorBind();
            //    comboBoxSelector.SelectedIndex = indx;
            //}
            //else
            //{
            //    TBL_FieldSelector TF = new TBL_FieldSelector();
            //    TF.FieldSelectType = 1;
            //    TF.FieldSelectName = comboBoxSelector.Text;
            //    TF.FieldSelectValue = StrChecked;
            //    DCMDC.TBL_FieldSelectors.InsertOnSubmit(TF);
            //    DCMDC.SubmitChanges();
                
            //    ComboBoxSelectorBind();
            //    comboBoxSelector.SelectedIndex = comboBoxSelector.Items.Count - 1;                

            //}
        }

        private void buttonItemExcelExportPatientDel_Click(object sender, EventArgs e)
        {
            Function_Cls.ExportExcelGrid(gridControl_ListDelDocPat);
        }
        //private Dictionary<string, Dictionary<string, int>> SetStrChecked(string StrChecked)
        //{
        //    Dictionary<string, Dictionary<string, int>> hg = new Dictionary<string, Dictionary<string, int>>();
        //    while (StrChecked != "")
        //    {
        //        Dictionary<string, int> f = new Dictionary<string, int>();
        //        f.Add("TI", int.Parse(StrChecked.Substring(StrChecked.IndexOf("-TI:") + 4, StrChecked.IndexOf("-WD:") - StrChecked.IndexOf("-TI:") - 4)));

        //        f.Add("WD", int.Parse(StrChecked.Substring(StrChecked.IndexOf("-WD:") + 4, StrChecked.IndexOf(";") - StrChecked.IndexOf("-WD:") - 4)));

        //        hg.Add(StrChecked.Substring(0, StrChecked.IndexOf("-")), f);
        //        StrChecked = StrChecked.Remove(0, StrChecked.IndexOf(";") + 1);
        //    }

        //    return hg;
        //}

       #endregion

       
        
    }
}
