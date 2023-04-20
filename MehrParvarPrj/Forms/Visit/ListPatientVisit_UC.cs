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
    public partial class ListPatientVisit_UC : UserControl
    {
        bool _listOrDelList, _allListOrOne;
        int _patientID = 0;
        public ListPatientVisit_UC(bool AllListOrOne, bool ListOrDelList, int PatientID)
        {
            InitializeComponent();
            _listOrDelList = ListOrDelList;
            _allListOrOne = AllListOrOne;
            _patientID = PatientID;
        }

        //new        
        bool _searchAdvanced = false, _lastVisitCode = false; DateTime _dateStartSearchAdvanced = DateTime.MinValue; DateTime _dateEndSearchAdvanced = DateTime.MinValue;
        public ListPatientVisit_UC(bool LastVisitCode, DateTime DateStart, DateTime DateEnd)
        {
            InitializeComponent();
            _searchAdvanced = true;
            _lastVisitCode = LastVisitCode;
            exPanelSearch.Visible = false;
            _dateStartSearchAdvanced = DateStart;
            _dateEndSearchAdvanced = DateEnd;
        }
        //New

       bool IsShown = false;
        
        #region Load & UI
        private void ListPatientVisit_UC_Load(object sender, EventArgs e)
        {
            string DateStr = "";
            if (!_searchAdvanced)//new
            {
                DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                if (_allListOrOne)
                {
                    var SUS = from prd in DCMDC.TBL_Doctors
                              //where prd.DoctorType == 1 && prd.Active == true
                              where prd.Active == true
                              select new
                              {
                                  prd.DoctorID,
                                  DoctorN = prd.DoctorName + " " + prd.DoctorFamily 
                                  //+ "-" + DCMDC.TBL_DoctorTypes.First(h => h.DoctorTypeId == prd.DoctorType).DoctorTypeDsc
                              };
                    comboBoxDocHealth.DisplayMember = "DoctorN";
                    comboBoxDocHealth.ValueMember = "DoctorID";
                    comboBoxDocHealth.DataSource = SUS;


                    System.Globalization.PersianCalendar ps = new System.Globalization.PersianCalendar();
                    comboBox_Day1.Text = "1";
                    comboBox_Month1.Text = ps.GetMonth(DateTime.Now).ToString();
                    comboBox_Year1.Text = ps.GetYear(DateTime.Now).ToString();

                    comboBox_Day2.Text = ps.GetMonth(DateTime.Now) <= 6 ? "31" : ps.GetMonth(DateTime.Now) == 12 ? "29" : "30";
                    comboBox_Month2.Text = ps.GetMonth(DateTime.Now).ToString();
                    comboBox_Year2.Text = ps.GetYear(DateTime.Now).ToString();
                }
                exPanelSearch.Visible = _allListOrOne;
                buttonItemPatVisitEdit.Visible = _listOrDelList;
                buttonItemPatVisitDel.Visible = _listOrDelList;
            }//new

            DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBoxYearRc.Text = DateStr.Substring(0, 4);
            comboBoxMonthRc.Text = DateStr.Substring(5, 2);
            comboBoxDayRc.Text = DateStr.Substring(8, 2);

            ColumnSelector_Cls.ComboBoxSelectorBind(comboBoxSelector, 2);

            IsShown = true;

            InterFaceChange();
            ShowListPatVisit(-1);
        }


        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemPatVisitEdit.Name)) buttonItemPatVisitEdit.Enabled = false;
                if (UPer.Contains(buttonItemPatVisitDel.Name)) buttonItemPatVisitDel.Enabled = false;
                if (UPer.Contains(buttonItemVisitPrintList.Name)) buttonItemVisitPrintList.Enabled = false;
                if (UPer.Contains(buttonItemVisitSMSEmail.Name)) buttonItemVisitSMSEmail.Enabled = false;
                if (UPer.Contains(buttonItemPatientReport.Name)) buttonItemPatientReport.Enabled = false;

                if (UPer.Contains(buttonItemExcelExportVisitPatient.Name)) buttonItemExcelExportVisitPatient.Enabled = false;
                if (UPer.Contains(buttonItemFileVisit.Name)) buttonItemFileVisit.Enabled = false;
                if (UPer.Contains(buttonItemOKPayment.Name)) buttonItemOKPayment.Enabled = false;
                if (UPer.Contains(btnSetValueVisit.Name)) btnSetValueVisit.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItemVisitSMSEmail.Enabled = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemPatientReport.Visible = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L3") || Global_Cls.SoftwareCode.Contains("L2") || Global_Cls.SoftwareCode.Contains("N2")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemPatientReport.Visible = false;
            }
            //codeing
        }

        string ActiveFilterStr = " ";
        private void RadioButtonAllVisit_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsShown) return;
            if (!_allListOrOne) return;

            string rStr = " ";
            try
            {
                rStr = gridView_ListPatVisit.ActiveFilterString.Replace(ActiveFilterStr, " ");
            }
            catch { rStr = gridView_ListPatVisit.ActiveFilterString; }
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

            //if (RadioButtonVisitPatient.Checked)
            //    ActiveFilterStr = " PatientID = " + (textBoxPatientID.Tag ?? 0).ToString();
            //else if (RadioButtonDocVisit.Checked)
            //    ActiveFilterStr = " DoctorID = " + comboBoxDocHealth.SelectedValue.ToString();
            //else if (RadioButtonVisitOK.Checked)
            //    ActiveFilterStr = " VisitOK = True ";
            //else if (RadioButtonVisitNOk.Checked)
            //    ActiveFilterStr = " VisitOK = False ";
            //else if (RadioButtonVisitForce.Checked)
            //    ActiveFilterStr = " ForceVisit = True ";
            //else ActiveFilterStr = " 1=1 ";


            if (RadioButtonSickness.Checked)
            {
                ActiveFilterStr = " 1<>1 ";
                for (int i = 0; i < textBoxSicknessSearch.Lines.Count(); i++)
                    if (textBoxSicknessSearch.Lines[i] != "")
                        ActiveFilterStr += " or replace([StateSickness],' ','') like '%" + textBoxSicknessSearch.Lines[i].Replace(" ", "") + "%' ";
                if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            }

            if (RadioButtonParaclinic.Checked)
            {
                ActiveFilterStr = " 1<>1 ";
                for (int i = 0; i < textBoxParaclinicSearch.Lines.Count(); i++)
                    if (textBoxParaclinicSearch.Lines[i] != "")
                        ActiveFilterStr += " or replace([Paraclinic],' ','') like '%" + textBoxParaclinicSearch.Lines[i].Replace(" ", "") + "%' ";
                if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            }

            if (RadioButtonDrugs.Checked)
            {
                ActiveFilterStr = " 1<>1 ";
                for (int i = 0; i < textBoxDrugsSearch.Lines.Count(); i++)
                    if (textBoxDrugsSearch.Lines[i] != "")
                        ActiveFilterStr += " or replace([DrugsHistory],' ','') like '%" + textBoxDrugsSearch.Lines[i].Replace(" ", "") + "%' ";
                if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            }

            if (RadioButtonBedsore.Checked)
            {
                ActiveFilterStr = " 1<>1 ";
                for (int i = 0; i < textBoxBedsoreSearch.Lines.Count(); i++)
                    if (textBoxBedsoreSearch.Lines[i] != "")
                        ActiveFilterStr += " or replace([Bedsore],' ','') like '%" + textBoxBedsoreSearch.Lines[i].Replace(" ", "") + "%' ";
                if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            }


            if (RadioButtonAndPatient.Checked)
            {
                ActiveFilterStr = " 1=1 ";
                if (checkBoxBedsore.Checked)
                    ActiveFilterStr += " and replace([Bedsore],' ','') like '%" + textBoxBedsore.Text.Replace(" ", "") + "%' and ([Bedsore] not like '%زخم%بستر%ندارد%') ";
                if (checkBoxParaclinic.Checked)
                    ActiveFilterStr += " and replace([Paraclinic],' ','') like '%" + textBoxParaclinic.Text.Replace(" ", "") + "%' and ([Paraclinic] not like '%پاراکل%ندارد%') ";
                if (checkBoxDrugs.Checked)
                    ActiveFilterStr += " and replace([DrugsHistory],' ','') like '%" + textBoxDrugs.Text.Replace(" ", "") + "%' and ([DrugsHistory] not like '%دارو%مصرف%ندارد%') ";
                if (checkBoxSickness.Checked)
                    ActiveFilterStr += " and replace([StateSickness],' ','') like '%" + textBoxSickness.Text.Replace(" ", "") + "%' and ([StateSickness] not like '%بیمار%ندارد%') ";
                //if (ActiveFilterStr == " 1=1 ") ActiveFilterStr = "";
            }

            //try
            //{
            //    DateTime D1 = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text);
            //    DateTime D2 = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);
            //    ActiveFilterStr += " and VisitDateMiladi >= #" + D1.ToShortDateString() + "# And VisitDateMiladi <= #" + D2.AddDays(1).ToShortDateString() + "# ";
            //}
            //catch { }

            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            var SUS = from prd in DCMDC.VW_PatientVisits
                      select prd;

            DateTime Dt1 = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text);
            DateTime Dt2 = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);

            if (!_allListOrOne) SUS = SUS.Where(s => s.PatientID == _patientID);
            else SUS = SUS.Where(s => s.VisitDateMiladi >= Dt1 && s.VisitDateMiladi <= Dt2);

            if (RadioButtonVisitPatient.Checked)
                SUS = SUS.Where(s => s.PatientID.Equals(textBoxPatientID.Tag ?? 0));
            else if (RadioButtonDocVisit.Checked)
                SUS = SUS.Where(s => s.DoctorID.Equals(comboBoxDocHealth.SelectedValue ?? 0));
            
            
            else if (RadioButtonVisitOK.Checked)
                SUS = SUS.Where(s => s.VisitStatus == "تاييد و ارسال");
            else if (RadioButtonVisitWait.Checked)
                SUS = SUS.Where(s => s.VisitStatus == "در انتظار تایید");
            else if (radioButtonVisitBack.Checked)
                SUS = SUS.Where(s => s.VisitStatus == "عودتی");
            else if (RadioButtonEven.Checked)
                SUS = SUS.Where(s => s.BonyadAddEven == 1);
            else if (radioButtonAdd.Checked)
                SUS = SUS.Where(s => s.BonyadAddEven == 0);
            else if (RadioButtonCostDoctor.Checked)
                SUS = SUS.Where(s => s.CostDoctor == 1);


            gridControl_ListPatVisit.DataSource = SUS;


            gridView_ListPatVisit.ActiveFilterString = ActiveFilterStr;
            ActiveFilterStr = gridView_ListPatVisit.ActiveFilterString;

            if (rStr == " ") rStr = "";
            if (ActiveFilterStr == " ") ActiveFilterStr = "";

            if (rStr != "" && ActiveFilterStr != "") gridView_ListPatVisit.ActiveFilterString += " and " + rStr;
            else if (rStr != "" && ActiveFilterStr == "") gridView_ListPatVisit.ActiveFilterString = rStr;
            gridView_ListPatVisit.ApplyColumnsFilter();

            gridView_ListPatVisit.UnselectRow(gridView_ListPatVisit.FocusedRowHandle);
            gridView_ListPatVisit.SelectRow(gridView_ListPatVisit.RowCount - 1);
            gridView_ListPatVisit.FocusedRowHandle = gridView_ListPatVisit.RowCount - 1;
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


        private void panel3_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthRc.Text) > 6 && Convert.ToInt16(comboBoxDayRc.Text) == 31) comboBoxDayRc.Text = "30";
            if (Convert.ToInt16(comboBoxMonthRc.Text) == 12 && (Convert.ToInt16(comboBoxDayRc.Text) == 31 || Convert.ToInt16(comboBoxDayRc.Text) == 30)) comboBoxDayRc.Text = "29";
        }



        private void gridView_ListPatVisit_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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

        public List<QueryFilter.ExpressionBuilder.Filter> filter;

        private void ShowListPatVisit(int RowFocus)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            if (!_searchAdvanced)//new
            {
                if (_listOrDelList)
                {
                    //var SUS = (from prd in DCMDC.TBL_PatientVisits
                    //           select new
                    //           {
                    //               prd.PatientID,
                    //               PatientNameF = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientName + " " + DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientFamily,
                    //               PatientTypeDsc = DCMDC.TBL_PatientTypes.First(h => h.PatientTypeId == DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientTypeId).PatientTypeDsc,
                    //               DosiersNo = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).DosiersNo,


                    //               //new
                    //               NationalCode = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).NationalCode,
                    //               IDNO = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).IDNO,
                    //               ParentName = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).ParentName,
                    //               BrithDate = Global_Cls.MiladiDateToShamsi(DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).BrithDate.Value),
                    //               BrithCityName = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).BrithCityName,
                    //               KinShipWith = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).KinShipWith,
                    //               PercentState = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).PercentState,
                    //               WifeSituation = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).WifeSituation,
                    //               ProtectSituation = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).ProtectSituation,

                    //               StateSickness = DCMDC.VisitStateSicknessStr(prd.PatientID, prd.VisitCode),
                    //               Paraclinic = DCMDC.VisitStateParaclinicsStr(prd.PatientID, prd.VisitCode),
                    //               DrugsHistory = DCMDC.VisitStateDrugsStr(prd.PatientID, prd.VisitCode),
                    //               Bedsore = DCMDC.VisitStateBedsoreStr(prd.PatientID, prd.VisitCode),
                    //               //--new


                    //               CityPart = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).CityPart,
                    //               AddressPart = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).AddressPart,
                    //               Address = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).Address,
                    //               Mobile = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).Mobile,
                    //               Mobile2 = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).Mobile2,
                    //               TelHome = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).TelHome,
                    //               TelBusiness = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(prd.PatientID)).TelBusiness,

                    //               VisitDate = Global_Cls.MiladiDateToShamsi(prd.VisitDate.Value),
                    //               VisitDateMiladi = prd.VisitDate.Value,
                    //               prd.VisitCode,

                    //               //ForceVisit = prd.ForceVisit.Value == true ? "بله" : "",
                    //               //DoctorNameF = (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorFamily),

                    //               //CostDoctor = Global_Cls.DigitSeparator(prd.CostDoctor.Value.ToString()),

                    //               //VisitOK = prd.VisitOK.Value == true ? "دارد" : "",
                    //               //CVA = prd.CVA.Value == true ? "دارد" : "",
                    //               //prd.DH,
                    //               //HLP = prd.HLP.Value == true ? "دارد" : "",
                    //               //IHD = prd.IHD.Value == true ? "دارد" : "",
                    //               //HTN = prd.HTN.Value == true ? "دارد" : "",
                    //               //DM = prd.DM.Value == true ? "دارد" : "",

                    //               //prd.Hb,
                    //               //bedsore = prd.bedsore.Value == true ? "دارد" : "",

                    //               prd.ForceVisit,
                    //               DoctorNameF = (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorFamily),

                    //               prd.VisitOK,

                    //               //Old
                    //               //prd.CVA,
                    //               //prd.DH,
                    //               //prd.HLP,
                    //               //prd.IHD,
                    //               //prd.HTN,
                    //               //prd.DM,

                    //               //prd.Hb,
                    //               //prd.bedsore,
                    //               //--Old

                    //               prd.PatientStateDsc,
                    //               prd.DoctorID,
                    //               Status = "فعال"

                    //           }).Union(

                    //                from prd in DCMDC.TBL_DelPatientVisits
                    //                select new
                    //                {
                    //                    prd.PatientID,
                    //                    PatientNameF = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientName + " " + DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientFamily,
                    //                    PatientTypeDsc = DCMDC.TBL_PatientTypes.First(h => h.PatientTypeId == DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientTypeId).PatientTypeDsc,

                    //                    DosiersNo = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).DosiersNo,

                    //                    //new
                    //                    NationalCode = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).NationalCode,
                    //                    IDNO = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).IDNO,
                    //                    ParentName = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).ParentName,
                    //                    BrithDate = Global_Cls.MiladiDateToShamsi(DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).BrithDate.Value),
                    //                    BrithCityName = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).BrithCityName,
                    //                    KinShipWith = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).KinShipWith,
                    //                    PercentState = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).PercentState,
                    //                    WifeSituation = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).WifeSituation,
                    //                    ProtectSituation = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).ProtectSituation,

                    //                    StateSickness = DCMDC.VisitStateSicknessStr(prd.PatientID, prd.VisitCode),
                    //                    Paraclinic = DCMDC.VisitStateParaclinicsStr(prd.PatientID, prd.VisitCode),
                    //                    DrugsHistory = DCMDC.VisitStateDrugsStr(prd.PatientID, prd.VisitCode),
                    //                    Bedsore = DCMDC.VisitStateBedsoreStr(prd.PatientID, prd.VisitCode),
                    //                    //--new


                    //                    CityPart = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).CityPart,
                    //                    AddressPart = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).AddressPart,
                    //                    Address = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).Address,
                    //                    Mobile = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).Mobile,
                    //                    Mobile2 = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).Mobile2,
                    //                    TelHome = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).TelHome,
                    //                    TelBusiness = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).TelBusiness,

                    //                    VisitDate = Global_Cls.MiladiDateToShamsi(prd.VisitDate.Value),
                    //                    VisitDateMiladi = prd.VisitDate.Value,
                    //                    prd.VisitCode,

                    //                    //ForceVisit = prd.ForceVisit.Value == true ? "بله" : "",
                    //                    //DoctorNameF = (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorFamily),

                    //                    //CostDoctor = Global_Cls.DigitSeparator(prd.CostDoctor.Value.ToString()),

                    //                    //VisitOK = prd.VisitOK.Value == true ? "دارد" : "",
                    //                    //CVA = prd.CVA.Value == true ? "دارد" : "",
                    //                    //prd.DH,
                    //                    //HLP = prd.HLP.Value == true ? "دارد" : "",
                    //                    //IHD = prd.IHD.Value == true ? "دارد" : "",
                    //                    //HTN = prd.HTN.Value == true ? "دارد" : "",
                    //                    //DM = prd.DM.Value == true ? "دارد" : "",

                    //                    //prd.Hb,
                    //                    //bedsore = prd.bedsore.Value == true ? "دارد" : "",


                    //                    prd.ForceVisit,
                    //                    DoctorNameF = (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorFamily),

                    //                    prd.VisitOK,

                    //                    //Old
                    //                    //prd.CVA,
                    //                    //prd.DH,
                    //                    //prd.HLP,
                    //                    //prd.IHD,
                    //                    //prd.HTN,
                    //                    //prd.DM,

                    //                    //prd.Hb,
                    //                    //prd.bedsore,
                    //                    //--Old

                    //                    prd.PatientStateDsc,
                    //                    prd.DoctorID,
                    //                    Status = "حذف"
                    //                });


                    var SUS = from prd in DCMDC.VW_PatientVisits
                              select prd;

                    DateTime D1 = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text);
                    DateTime D2 = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);

                    if (!_allListOrOne) SUS = SUS.Where(s => s.PatientID == _patientID);
                    else SUS = SUS.Where(s => s.VisitDateMiladi >= D1 && s.VisitDateMiladi <= D2);

                    gridControl_ListPatVisit.DataSource = SUS;
                }
                else
                {
                    var SUS = from prd in DCMDC.TBL_DelPatientVisits
                              where prd.PatientID == _patientID
                              select new
                              {
                                  prd.PatientID,
                                  PatientNameF = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientName + " " + DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientFamily,
                                  PatientTypeDsc = "",//DCMDC.TBL_PatientTypes.First(h => h.PatientTypeId == DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).PatientTypeId).PatientTypeDsc,
                                  DosiersNo = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).DosiersNo,


                                  //new
                                  NationalCode = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).NationalCode,
                                  IDNO = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).IDNO,
                                  ParentName = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).ParentName,
                                  BrithDate = Global_Cls.MiladiDateToShamsi(DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).BrithDate.Value),
                                  BrithCityName = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).BrithCityName,
                                  //KinShipWith = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).KinShipWith,
                                  PercentState = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).PercentState,
                                  WifeSituation = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).WifeSituation,
                                  ProtectSituation = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).ProtectSituation,

                                  StateSickness = DCMDC.VisitStateSicknessStr(prd.PatientID, prd.VisitCode),
                                  Paraclinic = DCMDC.VisitStateParaclinicsStr(prd.PatientID, prd.VisitCode),
                                  DrugsHistory = DCMDC.VisitStateDrugsStr(prd.PatientID, prd.VisitCode),
                                  Bedsore = DCMDC.VisitStateBedsoreStr(prd.PatientID, prd.VisitCode),
                                  //--new

                                  CityPart = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).CityPart,
                                  AddressPart = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).AddressPart,
                                  Address = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).Address,
                                  Mobile = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).Mobile,
                                  Mobile2 = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).Mobile2,
                                  TelHome = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).TelHome,
                                  TelBusiness = DCMDC.TBL_DelPatients.First(hf => hf.PatientID.Equals(prd.PatientID)).TelBusiness,

                                  VisitDate = Global_Cls.MiladiDateToShamsi(prd.VisitDate.Value),
                                  VisitDateMiladi = prd.VisitDate,
                                  prd.VisitCode,

                                  //ForceVisit = prd.ForceVisit.Value == true ? "بله" : "",
                                  //DoctorNameF = (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorFamily),

                                  //CostDoctor = Global_Cls.DigitSeparator(prd.CostDoctor.Value.ToString()),

                                  //VisitOK = prd.VisitOK.Value == true ? "دارد" : "",
                                  //CVA = prd.CVA.Value == true ? "دارد" : "",
                                  //prd.DH,
                                  //HLP = prd.HLP.Value == true ? "دارد" : "",
                                  //IHD = prd.IHD.Value == true ? "دارد" : "",
                                  //HTN = prd.HTN.Value == true ? "دارد" : "",
                                  //DM = prd.DM.Value == true ? "دارد" : "",

                                  //prd.Hb,
                                  //bedsore = prd.bedsore.Value == true ? "دارد" : "",


                                  //prd.ForceVisit,
                                  DoctorNameF = (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.DoctorID)).DoctorFamily),

                                  //prd.VisitOK,

                                  //old
                                  //prd.CVA,
                                  //prd.DH,
                                  //prd.HLP,
                                  //prd.IHD,
                                  //prd.HTN,
                                  //prd.DM,

                                  //prd.Hb,
                                  //prd.bedsore,
                                  //--old

                                  prd.PatientStateDsc,
                                  prd.DoctorID,
                                  Status = "حذف",
                                  prd.CostDoctor
                              };

                    gridControl_ListPatVisit.DataSource = SUS;
                }

                RadioButtonAllVisit_CheckedChanged(this, null);
            }
            else
            {
                string str = "";
                gridControl_ListPatVisit.DataSource = GetListByFilter(filter, ref str);
            }


            if (RowFocus != -1)
            {
                gridView_ListPatVisit.UnselectRow(gridView_ListPatVisit.FocusedRowHandle);
                gridView_ListPatVisit.SelectRow(RowFocus);
                gridView_ListPatVisit.FocusedRowHandle = RowFocus;
            }
            else
            {
                gridView_ListPatVisit.UnselectRow(gridView_ListPatVisit.FocusedRowHandle);
                gridView_ListPatVisit.SelectRow(gridView_ListPatVisit.RowCount - 1);
                gridView_ListPatVisit.FocusedRowHandle = gridView_ListPatVisit.RowCount - 1;
            }
        }

        public List<VW_PatientVisit> GetListByFilter(List<QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            try
            {
                var deleg = QueryFilter.ExpressionBuilder.GetExpression<VW_PatientVisit>(filter).Compile();
                var filteredCollection = (from d in DCMDC.VW_PatientVisits select d).Where(deleg);
                if (_lastVisitCode)
                        filteredCollection = (from d in DCMDC.VW_PatientVisits
                                              join k in DCMDC.TBL_Patients on d.PatientID equals k.PatientID
                                              where (k.LastOverhalDate == d.LastOverhalDateMiladi)
                                              select d).Where(deleg);
                else
                    if (_dateStartSearchAdvanced != DateTime.MinValue)
                        filteredCollection = (from d in DCMDC.VW_PatientVisits
                                              where d.VisitDateMiladi >= _dateStartSearchAdvanced && d.VisitDateMiladi <= _dateEndSearchAdvanced
                                              select d).Where(deleg);
                    

                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        private void gridView_ListPatVisit_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.RowHandle + 1;
        }

        #endregion


        #region All Buttons

        private void buttonItemCustomSearch_Click(object sender, EventArgs e)
        {
            gridView_ListPatVisit.OptionsView.ShowAutoFilterRow = !gridView_ListPatVisit.OptionsView.ShowAutoFilterRow;
            
            if (_searchAdvanced) return; //new
            
            if (!buttonItemCustomSearch.Checked)
            {
                gridView_ListPatVisit.ActiveFilterString = ActiveFilterStr;
                gridView_ListPatVisit.ApplyColumnsFilter();
            }
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ListPatVisit.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCustomPrintList_Click(object sender, EventArgs e)
        {
            gridView_ListPatVisit.FormatConditions[0].Appearance.BackColor = Color.White;
            gridView_ListPatVisit.FormatConditions[1].Appearance.BackColor = Color.White;

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ListPatVisit);
            PP.ShowDialog();

            gridView_ListPatVisit.FormatConditions[0].Appearance.BackColor = Color.PaleGreen;
            gridView_ListPatVisit.FormatConditions[1].Appearance.BackColor = Color.LightGray;
        }


        private void buttonItemNewVisit_Click(object sender, EventArgs e)
        {
            PatientVisitNE_frm Uc = new PatientVisitNE_frm();
            Uc.ShowDialog();
            ShowListPatVisit(gridView_ListPatVisit.RowCount);
        }


        private void buttonItemCustomEdit_Click(object sender, EventArgs e)
        {
            if (!_listOrDelList) return;
            if (gridView_ListPatVisit.RowCount == 0) return;
            int Index = gridView_ListPatVisit.FocusedRowHandle;

            try
            {
                PatientVisitNE_frm Uc = new PatientVisitNE_frm(Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index, "PatientID")),
                    Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index, "VisitCode")),
                    gridView_ListPatVisit.GetRowCellValue(Index, "Status").ToString());
                if (gridView_ListPatVisit.GetRowCellValue(Index, "VisitStatus").ToString() == "تاييد و ارسال")
                    Uc.groupPanel_All.Enabled = false;
                Uc.ShowDialog();
            }
            catch { }
            ShowListPatVisit(Index);
        }


        private void buttonItemPatVisitDel_Click(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
 
            if (!_listOrDelList) return;

            int[] Index = gridView_ListPatVisit.GetSelectedRows();
            
            if (gridView_ListPatVisit.RowCount == 0) return;
            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید سابقه (های) بیمار مربوطه به طور کامل حذف شوند؟ ")) return;
            //int Index = gridView_ListPatVisit.FocusedRowHandle;

            for (int i = 0; i < gridView_ListPatVisit.SelectedRowsCount; i++)
            {
                try
                {
                    if (gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitStatus").ToString() == "تاييد و ارسال")
                    {
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, " به علت ارسال شدن به مالی ویزیت مذکور امکان ویرایش آن وجود ندارد. ابتدا ویزیت مذکور از لیست مالی حذف شده و سپس عملیات درخواستی انجام می شود. ");
                        continue;
                    }
                }
                catch { }

                DCMDC.SP_DeletePatientVisit(Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID")),
                    Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode")),
                    gridView_ListPatVisit.GetRowCellValue(Index[i], "Status").ToString());

                //if (gridView_ListPatVisit.GetRowCellValue(Index[i], "Status").ToString() != "حذف")
                //{
                //    TBL_PatientVisit tptm = DCMDC.TBL_PatientVisits.First(tp => tp.PatientID == Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID")) &&
                //                                                                tp.VisitCode == Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode")));
                //    DCMDC.TBL_PatientVisits.DeleteOnSubmit(tptm);
                //    DCMDC.SubmitChanges();
                //}
                //else
                //{
                //    TBL_DelPatientVisit tptm = DCMDC.TBL_DelPatientVisits.First(tp => tp.PatientID == Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID")) &&
                //                                                                tp.VisitCode == Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode")));
                //    DCMDC.TBL_DelPatientVisits.DeleteOnSubmit(tptm);
                //    DCMDC.SubmitChanges();
                //}
            }
            ShowListPatVisit(Index[0]);
        }


        private void buttonPatientID_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(0);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxPatientID.Tag = sp.CodeC;
                textBoxPatientID.Text = sp.NameC;
                RadioButtonVisitPatient.Checked = true;
            }

        }

        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            ShowListPatVisit(gridView_ListPatVisit.FocusedRowHandle);
        }

        private void buttonItemVisitSMS_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(true, "", gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "Mobile").ToString());
        }

        private void buttonItemVisitEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("", gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "Email").ToString());
        }

        #endregion


        #region Set CheckBox
        private void chkPatientTypeDsc_CheckedChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.CheckBoxChanged(sender, gridView_ListPatVisit);
        }

        private void comboBoxSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.ComboBoxSelectValueChange(comboBoxSelector, panel_Selector);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ColumnSelector_Cls.SaveChange(gridView_ListPatVisit, comboBoxSelector, 2);
        }

        #endregion

        private void buttonItemPatientReport_Click(object sender, EventArgs e)
        {
            Report.Forms.PatientReport PT = new Report.Forms.PatientReport(Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "PatientID")));
            PrintPreview_frm PP = new PrintPreview_frm(PT);
            PP.ShowDialog();
        }

        private void buttonItemExcelExportVisitPatient_Click(object sender, EventArgs e)
        {
            Function_Cls.ExportExcelGrid(gridControl_ListPatVisit);
            comboBoxSelector_SelectedValueChanged(this, null);
        }

        //private void ToolStripMenuItemTwoVisit_Click(object sender, EventArgs e)
        //{
        //    int[] Index = gridView_ListPatVisit.GetSelectedRows();
        //    int PatientIDSet, i, VisitCodeSet;
        //    string SpecialDeasesSet = "";
        //    DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        //    for (i = 0; i < gridView_ListPatVisit.SelectedRowsCount; i++)
        //    {
        //        PatientIDSet = Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID"));
        //        VisitCodeSet = Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode"));
        //        SpecialDeasesSet = gridView_ListPatVisit.GetRowCellValue(Index[0], "NationalCode").ToString() + "-" + gridView_ListPatVisit.GetRowCellValue(Index[0], "VisitDate").ToString().Replace("/", "");

        //        try
        //        {
        //            TBL_PatientVisit pt = DCMDC.TBL_PatientVisits.First(l => l.PatientID == PatientIDSet && l.VisitCode == VisitCodeSet);
        //            pt.SpecialDisease = SpecialDeasesSet;
        //            DCMDC.SubmitChanges();
        //        }
        //        catch
        //        {
        //        }
        //    }
        //    ShowListPatVisit(Index[i - 1]);
        //}

        //private void ToolStripMenuItemDelTwoVisit_Click(object sender, EventArgs e)
        //{
        //    int[] Index = gridView_ListPatVisit.GetSelectedRows();
        //    int PatientIDSet, i, VisitCodeSet;
        //    string SpecialDeasesSet = "";
        //    DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        //    for (i = 0; i < gridView_ListPatVisit.SelectedRowsCount; i++)
        //    {
        //        PatientIDSet = Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID"));
        //        VisitCodeSet = Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode"));
        //        SpecialDeasesSet = gridView_ListPatVisit.GetRowCellValue(Index[0], "NationalCode").ToString() + "-" + gridView_ListPatVisit.GetRowCellValue(Index[0], "VisitDate").ToString().Replace("/", "");

        //        try
        //        {
        //            TBL_PatientVisit pt = DCMDC.TBL_PatientVisits.First(l => l.PatientID == PatientIDSet && l.VisitCode == VisitCodeSet);
        //            pt.SpecialDisease = "";
        //            DCMDC.SubmitChanges();
        //        }
        //        catch
        //        {
        //        }
        //    }
        //    ShowListPatVisit(Index[i - 1]);

        //}

        private void buttonItemFileVisit_Click(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            
            int PatientIDSet, VisitCodeSet;
            PatientIDSet = Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "PatientID"));
            VisitCodeSet = Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "VisitCode").ToString());
            MSSImageSelectorFiling_frm imgs = new MSSImageSelectorFiling_frm(PatientIDSet + "-" + VisitCodeSet, Global_Cls.AddressFile + @"\PatientVisitFile\");
            if (imgs.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TBL_PatientVisit tv = DCMDC.TBL_PatientVisits.First(f => f.PatientID == PatientIDSet && f.VisitCode == VisitCodeSet);
                    tv.CostDoctor = 1;
                    DCMDC.SubmitChanges();
                }
                catch (Exception)
                {
                    TBL_DelPatientVisit tv = DCMDC.TBL_DelPatientVisits.First(f => f.PatientID == PatientIDSet && f.VisitCode == VisitCodeSet);
                    tv.CostDoctor = 1;
                    DCMDC.SubmitChanges();
                } 
            }
            else
            {
                try
                {
                    TBL_PatientVisit tv = DCMDC.TBL_PatientVisits.First(f => f.PatientID == PatientIDSet && f.VisitCode == VisitCodeSet);
                    tv.CostDoctor = 0;
                    DCMDC.SubmitChanges();
                }
                catch (Exception)
                {
                    TBL_DelPatientVisit tv = DCMDC.TBL_DelPatientVisits.First(f => f.PatientID == PatientIDSet && f.VisitCode == VisitCodeSet);
                    tv.CostDoctor = 0;
                    DCMDC.SubmitChanges();
                }
            }
        }

        private void buttonItemOKPayment_Click(object sender, EventArgs e)
        {
            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید موارد انتخابی تاييد و ارسال جهت مالی شوند؟ ")) return;

            
            int[] Index = gridView_ListPatVisit.GetSelectedRows();
            int i;
            short BonyadAddEvenSet = 0;
            DataClassesSecondDataContext MHDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            int DefCostAdd = Convert.ToInt32((from sd in MHDC.TBL_Settings where sd.Name == "DefCostAdd" select sd).Single().value);
            int DefCostEven = Convert.ToInt32((from sd in MHDC.TBL_Settings where sd.Name == "DefCostEven" select sd).Single().value);
            decimal DefCostCo = Convert.ToDecimal((from sd in MHDC.TBL_Settings where sd.Name == "DefCostCo" select sd).Single().value);

            for (i = 0; i < gridView_ListPatVisit.SelectedRowsCount; i++)
            {
                if (gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitStatus").ToString() == "تاييد و ارسال")
                    continue;

                BonyadAddEvenSet = Convert.ToInt16(gridView_ListPatVisit.GetRowCellValue(Index[i], "BonyadAddEven"));
                string DateNow = Global_Cls.MiladiDateToShamsi(DateTime.Now);

                int sint = Convert.ToInt32(Math.Round((BonyadAddEvenSet == 0 ? DefCostAdd * DefCostCo / 100 : DefCostEven * DefCostCo / 100),0));

                MHDC.SP_InsertVisitDoctorPayment(
                    Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "DoctorID")),
                    Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID")),
                    Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode")),
                    gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitDate").ToString(),
                    "پرداخت عادی",
                    "آماده پرداخت",
                    DateNow,
                    "",
                    "",
                    BonyadAddEvenSet == 0 ? DefCostAdd : DefCostEven,
                    BonyadAddEvenSet == 0 ? DefCostAdd : DefCostEven,
                    "",
                    "",
                    "",
                    "",
                    "",
                    sint,
                    0,
                    "",
                    0,
                    (BonyadAddEvenSet == 0 ? DefCostAdd : DefCostEven) - sint,
                    0,
                    0,
                    "",
                    ""
                    );

                try
                {
                    TBL_PatientVisit tv = DCMDC.TBL_PatientVisits.First(f => f.PatientID == Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID")) &&
                    f.VisitCode == Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode")));
                    tv.VisitStatus = "تاييد و ارسال";
                }
                catch
                {
                    TBL_DelPatientVisit tv = DCMDC.TBL_DelPatientVisits.First(f => f.PatientID == Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID")) &&
                    f.VisitCode == Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode")));
                    tv.VisitStatus = "تاييد و ارسال";
                }
                DCMDC.SubmitChanges();
            }
            ShowListPatVisit(Index[i - 1]);
        }

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListPatVisit.GetSelectedRows();
            int PatientIDSet, VisitCodeSet, i;

            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید تاریخ دریافت فایل جهت ویزیت های انتخابی ثبت شوند؟"))
            {
                string DateSet = comboBoxYearRc.Text + "/" + (comboBoxMonthRc.Text.Length == 1 ? "0" + comboBoxMonthRc.Text : comboBoxMonthRc.Text) + "/" + (comboBoxDayRc.Text.Length == 1 ? "0" + comboBoxDayRc.Text : comboBoxDayRc.Text);

                for (i = 0; i < gridView_ListPatVisit.SelectedRowsCount; i++)
                {
                    PatientIDSet = Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "PatientID"));
                    VisitCodeSet = Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(Index[i], "VisitCode"));

                    try
                    {
                        TBL_PatientVisit TP = MHDC.TBL_PatientVisits.First(hj => hj.PatientID == PatientIDSet && hj.VisitCode == VisitCodeSet);

                        TP.SpecialDisease = DateSet;
                        MHDC.SubmitChanges();
                    }
                    catch
                    {
                        TBL_DelPatientVisit TP = MHDC.TBL_DelPatientVisits.First(hj => hj.PatientID == PatientIDSet && hj.VisitCode == VisitCodeSet);

                        TP.SpecialDisease = DateSet;
                        MHDC.SubmitChanges();

                    }
                }
                ShowListPatVisit(Index[i - 1]);
            }

        }


    }
}
