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
    public partial class ListVisitHistory_UC : UserControl
    {
        public ListVisitHistory_UC()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        bool IsShown = false;

        #region Load & UI
        private void ListVisitHistory_UC_Load(object sender, EventArgs e)
        {
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(-7));
            comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBox_Day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            System.Globalization.PersianCalendar ps = new System.Globalization.PersianCalendar();
            comboBox_Day2.Text = ps.GetDayOfMonth(DateTime.Now).ToString();
            comboBox_Month2.Text = ps.GetMonth(DateTime.Now).ToString();
            comboBox_Year2.Text = ps.GetYear(DateTime.Now).ToString();


            ColumnSelector_Cls.ComboBoxSelectorBind(comboBoxSelector, 3);

            IsShown = true;

            ShowListVisitHistory(1);
            InterFaceChange();
        }


        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemVisitHistoryAdd.Name)) buttonItemVisitHistoryAdd.Enabled = false;
                if (UPer.Contains(buttonItemVisitHistoryEdit.Name)) buttonItemVisitHistoryEdit.Enabled = false;
                if (UPer.Contains(buttonItemVisitHistoryDel.Name)) buttonItemVisitHistoryDel.Enabled = false;
                if (UPer.Contains(buttonItemVisitHistoryPrint.Name)) buttonItemVisitHistoryPrint.Enabled = false;
                if (UPer.Contains(buttonItemVisitHistorySMSEmail.Name)) buttonItemVisitHistorySMSEmail.Enabled = false;
                if (UPer.Contains(buttonItemPatientVisitHistoryReport.Name)) buttonItemPatientVisitHistoryReport.Enabled = false;

                if (UPer.Contains("buttonItem_ReciveSMS")) buttonItemVisitHistoryReciveSMS.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItemVisitHistorySMSEmail.Enabled = false;
                buttonItemVisitHistoryReciveSMS.Enabled = false;
            }

            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemPatientVisitHistoryReport.Visible = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L3") || Global_Cls.SoftwareCode.Contains("L2") || Global_Cls.SoftwareCode.Contains("N2")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemPatientVisitHistoryReport.Visible = false;
            }
            //codeing
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RadioButtonAllVisit_CheckedChanged(this, null);
        }

        string ActiveFilterStr = " ";
        private void RadioButtonAllVisit_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsShown) return;

            //string rStr = " ";
            //try
            //{
            //    rStr = gridView_ListVisitHistory.ActiveFilterString.Replace(ActiveFilterStr, " ");
            //}
            //catch { rStr = gridView_ListVisitHistory.ActiveFilterString; }
            //try
            //{
            //    if (rStr.Substring(rStr.Length - 4, 4).ToLower().Replace(" ", "") == "and".ToLower())
            //        rStr = rStr.Remove(rStr.Length - 4);

            //    if (rStr.Substring(1, 4).ToLower().Replace(" ", "") == "and".ToLower())
            //        rStr = rStr.Remove(1, 4);

            //    if (rStr.Substring(rStr.Length - 3, 3).ToLower().Replace(" ", "") == "or".ToLower())
            //        rStr = rStr.Remove(rStr.Length - 3);

            //    if (rStr.Substring(1, 3).ToLower().Replace(" ", "") == "or".ToLower())
            //        rStr = rStr.Remove(1, 3);
            //}
            //catch { }

            //ActiveFilterStr = " ";

            //if (RadioButtonOK.Checked)
            //{
            //    ActiveFilterStr = " 1<>1 ";
            //    ActiveFilterStr += " and VisitHistoryStatus = 1 ";
            //    if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            //}

            //if (RadioButtonNotRespon.Checked)
            //{
            //    ActiveFilterStr = " 1<>1 ";
            //    ActiveFilterStr += " and VisitHistoryStatus = 2 ";
            //    if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            //}

            //if (RadioButtonNotOk.Checked)
            //{
            //    ActiveFilterStr = " 1<>1 ";
            //    ActiveFilterStr += " and VisitHistoryStatus = 3 ";
            //    if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            //}

            //if (ActiveFilterStr == " ") ActiveFilterStr = " 1=1 ";
            
            
            //try
            //{
            //    DateTime D1 = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text);
            //    DateTime D2 = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);
            //    ActiveFilterStr += " and DateVisit >= #" + D1.ToShortDateString() + "# And DateVisit <= #" + D2.AddDays(1).ToShortDateString() + "# ";
            //}
            //catch { }

            //////////////////////
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            var SUS = from prd in DCMDC.VW_VisitHistories
                      select new
                      {
                          prd.PatientID,
                          PatientNameF = prd.PatientName + " " + prd.PatientFamily,
                          prd.ParentName,
                          prd.PatientTypeDsc,
                          prd.DosiersNo,


                          //new
                          NationalCode = prd.PatientNationalCode,
                          IDNO = prd.PatientIDNO,
                          BrithDate = Global_Cls.MiladiDateToShamsi(prd.PatientBrithDate),
                          BrithCityName = prd.PatientBrithCityName,
                          KinShipWith = prd.KinShipWith,
                          PercentState = prd.PercentState,
                          prd.WifeSituation,

                          StateSickness = DCMDC.VisitStateSicknessStr(prd.PatientID, (from h in DCMDC.TBL_PatientVisits where h.PatientID == prd.PatientID select h.VisitCode).Max()),
                          Paraclinic = DCMDC.VisitStateParaclinicsStr(prd.PatientID, (from h in DCMDC.TBL_PatientVisits where h.PatientID == prd.PatientID select h.VisitCode).Max()),
                          DrugsHistory = DCMDC.VisitStateDrugsStr(prd.PatientID, (from h in DCMDC.TBL_PatientVisits where h.PatientID == prd.PatientID select h.VisitCode).Max()),
                          Bedsore = DCMDC.VisitStateBedsoreStr(prd.PatientID, (from h in DCMDC.TBL_PatientVisits where h.PatientID == prd.PatientID select h.VisitCode).Max()),
                          //--new


                          CityPart = prd.CityPart,
                          AddressPart = prd.AddressPart,
                          Address = prd.PatientAddress,
                          Mobile = prd.PatientMobile,
                          Mobile2 = prd.PatientMobile2,
                          TelHome = prd.PatientTelHome,
                          TelBusiness = prd.PatientTelBusiness,

                          prd.DateVisit,
                          DateVisitShamsi = Global_Cls.MiladiDateToShamsiWithTime(prd.DateVisit),


                          prd.DoctorID,
                          DoctorNameF = prd.DoctorName + " " + prd.DoctorFamily,
                          prd.DoctorTypeDsc,

                          //new
                          DoctorNationalCode = prd.DoctorNationalCode,
                          DoctorIDNO = prd.DoctorIDNO,
                          DoctorBrithDate = Global_Cls.MiladiDateToShamsi(prd.DoctorBrithDate),
                          DoctorBrithCityName = prd.DoctorBrithCityName,

                          prd.DoctorAddress,
                          prd.MobileDoctor,
                          prd.DoctorTelHome,
                          prd.DoctorTelBusiness,
                          prd.Description,
                          prd.VisitHistoryStatus

                      };


            DateTime Dt1 = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text);
            DateTime Dt2 = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);

            SUS = SUS.Where(s => s.DateVisit >= Dt1 && s.DateVisit <= Dt2);
            if (!RadioButtonAllVisit.Checked)
                if (RadioButtonOK.Checked)
                    SUS = SUS.Where(d => d.VisitHistoryStatus == 1);
                else
                    if (RadioButtonNotRespon.Checked)
                        SUS = SUS.Where(d => d.VisitHistoryStatus == 2);
                    else
                        if (RadioButtonNotOk.Checked)
                            SUS = SUS.Where(d => d.VisitHistoryStatus == 3);

            gridControl_ListVisitHistory.DataSource = SUS;
            /////////////////////



            //gridView_ListVisitHistory.ActiveFilterString = ActiveFilterStr;
            //ActiveFilterStr = gridView_ListVisitHistory.ActiveFilterString;

            //if (rStr == " ") rStr = "";
            //if (ActiveFilterStr == " ") ActiveFilterStr = "";

            //if (rStr != "" && ActiveFilterStr != "") gridView_ListVisitHistory.ActiveFilterString += " and " + rStr;
            //else if (rStr != "" && ActiveFilterStr == "") gridView_ListVisitHistory.ActiveFilterString = rStr;
            //gridView_ListVisitHistory.ApplyColumnsFilter();

        }

        private void panel_VisitDate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month2.Text) > 6 && Convert.ToInt16(comboBox_Day2.Text) == 31) comboBox_Day2.Text = "30";
            if (Convert.ToInt16(comboBox_Month2.Text) == 12 && (Convert.ToInt16(comboBox_Day2.Text) == 31 || Convert.ToInt16(comboBox_Day2.Text) == 30)) comboBox_Day2.Text = "29";
            RadioButtonAllVisit_CheckedChanged(this, null);
        }

        private void panel_VisitDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_Day1.Text) == 31) comboBox_Day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_Day1.Text) == 31 || Convert.ToInt16(comboBox_Day1.Text) == 30)) comboBox_Day1.Text = "29";
            RadioButtonAllVisit_CheckedChanged(this, null);
        }

        private void gridView_ListVisitHistory_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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

        private void ShowListVisitHistory(int RowFocus)
        {
            var SUS = from prd in DCMDC.VW_VisitHistories
                      select new
                      {
                          prd.PatientID,
                          PatientNameF = prd.PatientName + " " + prd.PatientFamily,
                          prd.ParentName,
                          prd.PatientTypeDsc,
                          prd.DosiersNo,


                          //new
                          NationalCode = prd.PatientNationalCode,
                          IDNO = prd.PatientIDNO,
                          BrithDate = Global_Cls.MiladiDateToShamsi(prd.PatientBrithDate),
                          BrithCityName = prd.PatientBrithCityName,
                          KinShipWith = prd.KinShipWith,
                          PercentState = prd.PercentState,
                          prd.WifeSituation,

                          StateSickness = DCMDC.VisitStateSicknessStr(prd.PatientID, (from h in DCMDC.TBL_PatientVisits where h.PatientID == prd.PatientID select h.VisitCode).Max()),
                          Paraclinic = DCMDC.VisitStateParaclinicsStr(prd.PatientID, (from h in DCMDC.TBL_PatientVisits where h.PatientID == prd.PatientID select h.VisitCode).Max()),
                          DrugsHistory = DCMDC.VisitStateDrugsStr(prd.PatientID, (from h in DCMDC.TBL_PatientVisits where h.PatientID == prd.PatientID select h.VisitCode).Max()),
                          Bedsore = DCMDC.VisitStateBedsoreStr(prd.PatientID, (from h in DCMDC.TBL_PatientVisits where h.PatientID == prd.PatientID select h.VisitCode).Max()),
                          //--new


                          CityPart = prd.CityPart,
                          AddressPart = prd.AddressPart,
                          Address = prd.PatientAddress,
                          Mobile = prd.PatientMobile,
                          Mobile2 = prd.PatientMobile2,
                          TelHome = prd.PatientTelHome,
                          TelBusiness = prd.PatientTelBusiness,

                          prd.DateVisit,
                          DateVisitShamsi = Global_Cls.MiladiDateToShamsiWithTime(prd.DateVisit),


                          prd.DoctorID,
                          DoctorNameF = prd.DoctorName + " " + prd.DoctorFamily,
                          prd.DoctorTypeDsc,

                          //new
                          DoctorNationalCode = prd.DoctorNationalCode,
                          DoctorIDNO = prd.DoctorIDNO,
                          DoctorBrithDate = Global_Cls.MiladiDateToShamsi(prd.DoctorBrithDate),
                          DoctorBrithCityName = prd.DoctorBrithCityName,

                          prd.DoctorAddress,
                          prd.MobileDoctor,
                          prd.DoctorTelHome,
                          prd.DoctorTelBusiness,
                          prd.Description

                      };


            DateTime Dt1 = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text);
            DateTime Dt2 = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);

            SUS = SUS.Where(s => s.DateVisit >= Dt1 && s.DateVisit <= Dt2);
            gridControl_ListVisitHistory.DataSource = SUS;


            RadioButtonAllVisit_CheckedChanged(this, null);


            gridView_ListVisitHistory.UnselectRow(gridView_ListVisitHistory.FocusedRowHandle);
            gridView_ListVisitHistory.SelectRow(RowFocus);
            gridView_ListVisitHistory.FocusedRowHandle = RowFocus;

        }

        private void gridView_ListVisitHistory_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.RowHandle + 1;
        }

        #endregion


        #region All Buttons

        private void buttonItemCustomSearch_Click(object sender, EventArgs e)
        {
            gridView_ListVisitHistory.OptionsView.ShowAutoFilterRow = !gridView_ListVisitHistory.OptionsView.ShowAutoFilterRow;
            if (!buttonItemVisitHistorySearch.Checked)
            {
                gridView_ListVisitHistory.ActiveFilterString = ActiveFilterStr;
                gridView_ListVisitHistory.ApplyColumnsFilter();
            }
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ListVisitHistory.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCustomPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ListVisitHistory);
            PP.ShowDialog();
        }

        private void buttonItemVisitHistoryAdd_Click(object sender, EventArgs e)
        {
            VisitHistoryNE_frm Uc = new VisitHistoryNE_frm();
            Uc.ShowDialog();
            ShowListVisitHistory(0);
        }

       
        private void buttonItemCustomEdit_Click(object sender, EventArgs e)
        {
            if (gridView_ListVisitHistory.RowCount == 0) return;
            int Index = gridView_ListVisitHistory.FocusedRowHandle;

            VisitHistoryNE_frm Uc = new VisitHistoryNE_frm(
                gridView_ListVisitHistory.GetRowCellValue(Index, "DateVisitShamsi").ToString(),
                gridView_ListVisitHistory.GetRowCellValue(Index, "MobileDoctor").ToString(),
                gridView_ListVisitHistory.GetRowCellValue(Index, "DosiersNo").ToString(),
                gridView_ListVisitHistory.GetRowCellValue(Index, "Description").ToString(),
                gridView_ListVisitHistory.GetRowCellValue(Index, "NationalCode").ToString()
                );
            Uc.ShowDialog();
            ShowListVisitHistory(Index);
        }


        private void buttonItemPatVisitDel_Click(object sender, EventArgs e)
        {
            if (gridView_ListVisitHistory.RowCount == 0) return;
            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید ردیف (های) انتخابی حذف شوند؟ ")) return;

            int[] Index = gridView_ListVisitHistory.GetSelectedRows();
            for (int i = 0; i < gridView_ListVisitHistory.SelectedRowsCount; i++)
            {
                TBL_VisitHistory tvh = DCMDC.TBL_VisitHistories.First(kk => kk.DosiersNo == gridView_ListVisitHistory.GetRowCellValue(Index[i], "DosiersNo").ToString()
                    & kk.DateVisit == DateTime.Parse(gridView_ListVisitHistory.GetRowCellValue(Index[i], "DateVisit").ToString()) 
                    & kk.MobileDoctor == gridView_ListVisitHistory.GetRowCellValue(Index[i], "MobileDoctor").ToString());
                DCMDC.TBL_VisitHistories.DeleteOnSubmit(tvh);
                DCMDC.SubmitChanges();
            }
            ShowListVisitHistory(Index[0]);
        }


        

        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            ShowListVisitHistory(gridView_ListVisitHistory.FocusedRowHandle);
        }

        private void buttonItemVisitSMS_Click(object sender, EventArgs e)
        {
            try { Global_Cls.SendSMS_Advertisment(true, "", gridView_ListVisitHistory.GetRowCellValue(gridView_ListVisitHistory.FocusedRowHandle, "MobileDoctor").ToString()); }
            catch { }
        }

        private void buttonItemVisitEmail_Click(object sender, EventArgs e)
        {
            try { Global_Cls.SendEmail("", gridView_ListVisitHistory.GetRowCellValue(gridView_ListVisitHistory.FocusedRowHandle, "DoctorEmail").ToString()); }
            catch { }
        }

        #endregion


        #region Set CheckBox
        private void chkPatientTypeDsc_CheckedChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.CheckBoxChanged(sender, gridView_ListVisitHistory);
        }

        private void comboBoxSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.ComboBoxSelectValueChange(comboBoxSelector, panel_Selector);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ColumnSelector_Cls.SaveChange(gridView_ListVisitHistory, comboBoxSelector, 3);
        }

        #endregion

        private void buttonItemVisitHistoryReciveSMS_Click(object sender, EventArgs e)
        {
            ReciveSMS_frm RSM = new ReciveSMS_frm();
            RSM.ShowDialog();
            buttonItemRefresh_Click(this, null);
        }

        private void buttonItemPatientReport_Click(object sender, EventArgs e)
        {
            Report.Forms.PatientReport PT = new Report.Forms.PatientReport(Convert.ToInt32(gridView_ListVisitHistory.GetRowCellValue(gridView_ListVisitHistory.FocusedRowHandle, "PatientID")));
            PrintPreview_frm PP = new PrintPreview_frm(PT);
            PP.ShowDialog();
        }

        private void ToolStripMenuItemOK_Click(object sender, EventArgs e)
        {
            try
            {
                int Index1 = gridView_ListVisitHistory.FocusedRowHandle;
                DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                TBL_VisitHistory TP = MHDC.TBL_VisitHistories.First(g =>
                    g.MobileDoctor == gridView_ListVisitHistory.GetRowCellValue(Index1, "MobileDoctor").ToString() &
                    //g.DosiersNo == gridView_ListVisitHistory.GetRowCellValue(Index1, "DosiersNo").ToString() &
                    g.DateVisit == Convert.ToDateTime(gridView_ListVisitHistory.GetRowCellValue(Index1, "DateVisit")) &
                    g.NationalCode == gridView_ListVisitHistory.GetRowCellValue(Index1, "NationalCode").ToString());

                TP.VisitHistoryStatus = short.Parse((sender as ToolStripMenuItem).Tag.ToString());
                MHDC.SubmitChanges();
            }
            catch { }
        }

        



    }
}
