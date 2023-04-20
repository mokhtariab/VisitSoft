using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.DataLinq;

namespace MehrParvarPrj
{
    public partial class PatientVisitNE_frm : Form
    {
        int _patientID = 0, _visitCode = 0;
        bool _newOrEditPatientVisit = false;
        string _status;

        public PatientVisitNE_frm(int PatientID, int VisitCode, string Status)
        {
            InitializeComponent();
            _patientID = PatientID;
            _visitCode = VisitCode;
            _status = Status;
            _newOrEditPatientVisit = false;
        }
        public PatientVisitNE_frm()
        {
            InitializeComponent();
            _newOrEditPatientVisit = true;
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DCSSS = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void PatientVisitNE_frm_Load(object sender, EventArgs e)
        {
            //var SUS1 = (from prd in DCMD.TBL_PatientVisits
            //          select new { prd.BusinessReasons}).Distinct();
            //comboBoxBusinessReasons.DisplayMember = "BusinessReasons";
            //comboBoxBusinessReasons.ValueMember = "BusinessReasons";
            //comboBoxBusinessReasons.DataSource = SUS1;

            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBoxYearF.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBoxMonthF.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBoxDayF.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
            
            checkBoxCostDoctor.Checked = false;
            checkBoxCostDoctor_CheckValueChanged(this, null);

            SetDefault_PatientVisitNE();
        }

        private void SetDefault_PatientVisitNE()
        {
            if (!_newOrEditPatientVisit)
            {
                FillComponents(_patientID, _visitCode);
            }

            else if (_newOrEditPatientVisit)
            {
                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                groupPanel_Other.Enabled = false;
            }
        }

        private void FillComponents(int PID, int VCode)
        {
            try
            {
                if (_status != "حذف")
                {
                    TBL_PatientVisit tbhc = DCMD.TBL_PatientVisits.First(thfr => thfr.PatientID == PID && thfr.VisitCode == VCode);

                    textBoxPatientID.Tag = tbhc.PatientID;
                    textBoxPatientID.Text = DCMD.TBL_Patients.First(thfr => thfr.PatientID == tbhc.PatientID).PatientName + " " + DCMD.TBL_Patients.First(thfr => thfr.PatientID == tbhc.PatientID).PatientFamily;
                    buttonPatientID.Visible = _newOrEditPatientVisit;
                    textBoxVisitCode.Text = tbhc.VisitCode.ToString();

                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.VisitDate));
                    comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                    
                    textBoxDoctorName.Tag = tbhc.DoctorID;
                    textBoxDoctorName.Text = DCMD.TBL_Doctors.First(thfr => thfr.DoctorID == tbhc.DoctorID).DoctorName + " " + DCMD.TBL_Doctors.First(thfr => thfr.DoctorID == tbhc.DoctorID).DoctorFamily;

                    chkDrugsHistory.Checked = tbhc.DrugsHistory ?? false;
                    chkParaclinic.Checked = tbhc.Paraclinic ?? false;
                    chkStateSickness.Checked = tbhc.StateSickness ?? false;
                    chkbedsore.Checked = tbhc.Bedsore ?? false;
                    chkVaccination.Checked = tbhc.VaccinationDsc == "" ? false : true;
                    chkEquipmentUse.Checked = tbhc.EquipmentUseDsc == "" ? false : true;
                    checkBoxUnwillingness.Checked = tbhc.Unwillingness ?? false;
                    chkVisitOK.Checked = tbhc.VisitOK ?? false;
                    chkForceVisit.Checked = tbhc.ForceVisit ?? false;

                    textBoxPatientStateDsc.Text = tbhc.PatientStateDsc;
                    comboBoxBusinessReasons.Text = tbhc.BusinessReasons;


                    ////////////////////New
                    //textBoxCostDoctor.Text = Global_Cls.DigitSeparator(tbhc.CostDoctor.Value.ToString());
                    checkBoxCostDoctor.Checked = tbhc.SpecialDisease != "";

                    //comboBoxSpecialDisease.Text = tbhc.SpecialDisease;
                    if (tbhc.SpecialDisease != "")
                    {
                        try
                        {
                            comboBoxYearF.Text = Convert.ToInt16(tbhc.SpecialDisease.Substring(0, 4)).ToString();
                            comboBoxMonthF.Text = Convert.ToInt16(tbhc.SpecialDisease.Substring(5, 2)).ToString();
                            comboBoxDayF.Text = Convert.ToInt16(tbhc.SpecialDisease.Substring(8, 2)).ToString();
                        }
                        catch { }
                    }
                    ////////////////////////New

                    
                    //new
                    comboBoxVisitStatus.SelectedIndex = tbhc.VisitStatus == "در انتظار تاييد" ? 0 : 1;

                    comboBoxBonyadAddEven.SelectedIndex = tbhc.BonyadAddEven.Value;

                    textBoxBedsore.Text = DCMD.VisitStateBedsoreStr(PID, VCode);
                    textBoxDrugsHistory.Text = DCMD.VisitStateDrugsStr(PID, VCode);
                    textBoxParaclinic.Text = DCMD.VisitStateParaclinicsStr(PID, VCode);
                    textBoxStateSickness.Text = DCMD.VisitStateSicknessStr(PID, VCode);

                    textBoxVaccination.Text = DCSSS.VisitStateVaccinationStr(_patientID, _visitCode);
                    textBoxEquipmentUse.Text = DCSSS.VisitStateEquipmentUseStr(_patientID, _visitCode);

                }
                else
                {
                    TBL_DelPatientVisit tbhc = DCMD.TBL_DelPatientVisits.First(thfr => thfr.PatientID == PID && thfr.VisitCode == VCode);

                    textBoxPatientID.Tag = tbhc.PatientID;
                    textBoxPatientID.Text = DCMD.TBL_DelPatients.First(thfr => thfr.PatientID == tbhc.PatientID).PatientName + " " + DCMD.TBL_DelPatients.First(thfr => thfr.PatientID == tbhc.PatientID).PatientFamily;
                    buttonPatientID.Visible = _newOrEditPatientVisit;
                    textBoxVisitCode.Text = tbhc.VisitCode.ToString();

                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.VisitDate));
                    comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                    textBoxDoctorName.Tag = tbhc.DoctorID;
                    textBoxDoctorName.Text = DCMD.TBL_Doctors.First(thfr => thfr.DoctorID == tbhc.DoctorID).DoctorName + " " + DCMD.TBL_Doctors.First(thfr => thfr.DoctorID == tbhc.DoctorID).DoctorFamily;

                    chkDrugsHistory.Checked = tbhc.DrugsHistory ?? false;
                    chkParaclinic.Checked = tbhc.Paraclinic ?? false;
                    chkStateSickness.Checked = tbhc.StateSickness ?? false;
                    chkbedsore.Checked = tbhc.Bedsore ?? false;
                    chkVaccination.Checked = tbhc.VaccinationDsc == "" ? false : true;
                    chkEquipmentUse.Checked = tbhc.EquipmentUseDsc == "" ? false : true;
                    checkBoxUnwillingness.Checked = tbhc.Unwillingness ?? false;
                    chkVisitOK.Checked = tbhc.VisitOK ?? false;

                    textBoxPatientStateDsc.Text = tbhc.PatientStateDsc;
                    comboBoxBusinessReasons.Text = tbhc.BusinessReasons;
                    chkForceVisit.Checked = tbhc.ForceVisit??false;


                    ////////////////////New

                    //textBoxCostDoctor.Text = Global_Cls.DigitSeparator(tbhc.CostDoctor.Value.ToString());
                    checkBoxCostDoctor.Checked = tbhc.SpecialDisease != "";

                    //comboBoxSpecialDisease.Text = tbhc.SpecialDisease;
                    if (tbhc.SpecialDisease != "")
                    {
                        try
                        {
                            comboBoxYearF.Text = Convert.ToInt16(tbhc.SpecialDisease.Substring(0, 4)).ToString();
                            comboBoxMonthF.Text = Convert.ToInt16(tbhc.SpecialDisease.Substring(5, 2)).ToString();
                            comboBoxDayF.Text = Convert.ToInt16(tbhc.SpecialDisease.Substring(8, 2)).ToString();
                        }
                        catch { }
                    }
                    ////////////////////////New


                    comboBoxVisitStatus.SelectedIndex = tbhc.VisitStatus == "در انتظار تاييد" ? 0 : 1;
                    comboBoxBonyadAddEven.SelectedIndex = tbhc.BonyadAddEven.Value;

                    textBoxBedsore.Text = DCMD.VisitStateBedsoreStr(PID, VCode);
                    textBoxDrugsHistory.Text = DCMD.VisitStateDrugsStr(PID, VCode);
                    textBoxParaclinic.Text = DCMD.VisitStateParaclinicsStr(PID, VCode);
                    textBoxStateSickness.Text = DCMD.VisitStateSicknessStr(PID, VCode);
                    
                    textBoxVaccination.Text = DCSSS.VisitStateVaccinationStr(_patientID, _visitCode);
                    textBoxEquipmentUse.Text = DCSSS.VisitStateEquipmentUseStr(_patientID, _visitCode);
                }
            }
            catch (Exception ex)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.Message);
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBoxPatientID.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام نام خانوادگی را وارد نمایید!"); textBoxPatientID.Focus(); return; }
            if (textBoxDoctorName.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا پزشک را وارد نمایید!"); textBoxDoctorName.Focus(); return; }

            panel_CDate1_Leave(this, null);
            panel1_Leave(this, null);

            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید تغییرات درخواستی ثبت شوند؟"))
            {
                if (OKFunction())
                    Close();
            }
        }

        private bool OKFunction()
        {
            string DateSpecialDisease = comboBoxYearF.Text + "/" + (comboBoxMonthF.Text.Length == 1 ? "0" + comboBoxMonthF.Text : comboBoxMonthF.Text) + "/" + (comboBoxDayF.Text.Length == 1 ? "0" + comboBoxDayF.Text : comboBoxDayF.Text);

            if (_newOrEditPatientVisit)
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    int? RetValue = 0;
                    DCMD1.SP_InsertPatientVisit(
                        int.Parse(textBoxPatientID.Tag.ToString()),
                        chkForceVisit.Checked,
                        int.Parse(textBoxDoctorName.Tag.ToString()),
                        chkVisitOK.Checked,
                        Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text),
                        0,
                        checkBoxUnwillingness.Checked,
                        comboBoxBusinessReasons.Text,
                        textBoxPatientStateDsc.Text,
                        checkBoxCostDoctor.Checked ? DateSpecialDisease : "",
                        Convert.ToInt16(comboBoxBonyadAddEven.SelectedIndex),
                        comboBoxVisitStatus.Text,
                        ref RetValue);

                    if (RetValue.Value == 0)
                    {
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در ماه درخواستی ویزیت جهت بیمار مذکور ثبت شده است");
                        return false;
                    }


                    //try
                    //{
                    //    int g = (from fg in DCMD1.TBL_PatientVisits
                    //             where fg.PatientID == int.Parse(textBoxPatientID.Tag.ToString()) &&
                    //                 fg.VisitDate == Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text)
                    //             select fg.VisitCode).Count();
                    //    if (g > 0)
                    //    {
                    //        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در یک روز امکان دوبار بازدید وجود ندارد");
                    //        return false;
                    //    }
                    //}
                    //catch { }
                    //TBL_PatientVisit tbhc = new TBL_PatientVisit();

                    //tbhc.PatientID = int.Parse(textBoxPatientID.Tag.ToString());
                    //tbhc.VisitCode = int.Parse(textBoxVisitCode.Text);
                    //tbhc.ForceVisit = chkForceVisit.Checked;

                    //tbhc.VisitDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
                    //tbhc.DoctorID = int.Parse(comboBoxDoctorID.SelectedValue.ToString());
                    //tbhc.CostDoctor = long.Parse((textBoxCostDoctor.Text == "" ? "0" : textBoxCostDoctor.Text).Replace(",", ""));

                    //tbhc.DrugsHistory = chkDrugsHistory.Checked;
                    //tbhc.Paraclinic = chkParaclinic.Checked;
                    //tbhc.StateSickness = chkStateSickness.Checked;
                    //tbhc.Bedsore = chkbedsore.Checked;

                    //tbhc.PatientStateDsc = textBoxPatientStateDsc.Text;
                    //tbhc.VisitOK = chkVisitOK.Checked;
                    //DCMD1.TBL_PatientVisits.InsertOnSubmit(tbhc);
                    //DCMD1.SubmitChanges();


                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "این اطلاعات قبلا وارد شده و تکراری است!", ex.Message);
                    else
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditPatientVisit)
                    try
                    {
                        DataClasses_MainDataContext DCMD2 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

                        if (_status != "حذف")
                        {
                            TBL_PatientVisit tbhc = DCMD2.TBL_PatientVisits.First(thfh => thfh.PatientID == _patientID && thfh.VisitCode == _visitCode);

                            tbhc.PatientID = int.Parse(textBoxPatientID.Tag.ToString());
                            tbhc.VisitCode = int.Parse(textBoxVisitCode.Text);
                            tbhc.ForceVisit = chkForceVisit.Checked;

                            tbhc.DrugsHistory = chkDrugsHistory.Checked;
                            tbhc.Paraclinic = chkParaclinic.Checked;
                            tbhc.StateSickness = chkStateSickness.Checked;
                            tbhc.Bedsore = chkbedsore.Checked;
                            tbhc.PatientStateDsc = textBoxPatientStateDsc.Text;
                            tbhc.VisitOK = chkVisitOK.Checked;


                            if (groupPanel_All.Enabled)
                            {
                                tbhc.VisitDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
                                tbhc.DoctorID = int.Parse(textBoxDoctorName.Tag.ToString());

                                tbhc.BusinessReasons = comboBoxBusinessReasons.Text;
                                tbhc.Unwillingness = checkBoxUnwillingness.Checked;

                                ///////////////////////New
                                //tbhc.CostDoctor = long.Parse((textBoxCostDoctor.Text == "" ? "0" : textBoxCostDoctor.Text).Replace(",", ""));
                                //tbhc.CostDoctor = checkBoxCostDoctor.Checked ? 1 : 0;
                                if (checkBoxCostDoctor.Checked)
                                    tbhc.SpecialDisease = DateSpecialDisease;
                                else tbhc.SpecialDisease = "";
                                ///////////////////////New

                                tbhc.VisitStatus = comboBoxVisitStatus.Text;
                                tbhc.BonyadAddEven = Convert.ToInt16(comboBoxBonyadAddEven.SelectedIndex);
                            }

                            DCMD2.SubmitChanges();

                            try
                            {
                                if ((from e in DCMD2.TBL_PatientVisits
                                     where e.PatientID == _patientID && e.VisitDate > Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text)
                                     select e).Count() == 0)
                                {
                                    TBL_Patient tb = DCMD2.TBL_Patients.First(thfh => thfh.PatientID == _patientID);

                                    tb.LastOverhalDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
                                    DCMD2.SubmitChanges();
                                }
                                else
                                {
                                    TBL_Patient tb = DCMD2.TBL_Patients.First(thfh => thfh.PatientID == _patientID);

                                    tb.LastOverhalDate = (from e in DCMD2.TBL_PatientVisits
                                                          where e.PatientID == _patientID
                                                          select new { e.VisitDate }).Max(g => g.VisitDate);
                                    DCMD2.SubmitChanges();
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            TBL_DelPatientVisit tbhc = DCMD2.TBL_DelPatientVisits.First(thfh => thfh.PatientID == _patientID && thfh.VisitCode == _visitCode);

                            tbhc.PatientID = int.Parse(textBoxPatientID.Tag.ToString());
                            tbhc.VisitCode = int.Parse(textBoxVisitCode.Text);
                            tbhc.ForceVisit = chkForceVisit.Checked;

                            tbhc.DrugsHistory = chkDrugsHistory.Checked;
                            tbhc.Paraclinic = chkParaclinic.Checked;
                            tbhc.StateSickness = chkStateSickness.Checked;
                            tbhc.Bedsore = chkbedsore.Checked;
                            tbhc.PatientStateDsc = textBoxPatientStateDsc.Text;
                            tbhc.VisitOK = chkVisitOK.Checked;


                            if (groupPanel_All.Enabled)
                            {
                                tbhc.VisitDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
                                tbhc.DoctorID = int.Parse(textBoxDoctorName.Tag.ToString());

                                tbhc.BusinessReasons = comboBoxBusinessReasons.Text;
                                tbhc.Unwillingness = checkBoxUnwillingness.Checked;

                                ///////////////////////New
                                //tbhc.CostDoctor = long.Parse((textBoxCostDoctor.Text == "" ? "0" : textBoxCostDoctor.Text).Replace(",", ""));
                                //tbhc.CostDoctor = checkBoxCostDoctor.Checked ? 1 : 0;
                                if (checkBoxCostDoctor.Checked)
                                    tbhc.SpecialDisease = DateSpecialDisease;
                                else tbhc.SpecialDisease = "";
                                ///////////////////////New

                                tbhc.VisitStatus = comboBoxVisitStatus.Text;
                                tbhc.BonyadAddEven = Convert.ToInt16(comboBoxBonyadAddEven.SelectedIndex);
                            }

                            DCMD2.SubmitChanges();

                            try
                            {
                                if ((from e in DCMD2.TBL_DelPatientVisits
                                     where e.PatientID == _patientID && e.VisitDate > Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text)
                                     select e).Count() == 0)
                                {
                                    TBL_DelPatient tb = DCMD2.TBL_DelPatients.First(thfh => thfh.PatientID == _patientID);

                                    tb.LastOverhalDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
                                    DCMD2.SubmitChanges();
                                }
                                else
                                {
                                    TBL_DelPatient tb = DCMD2.TBL_DelPatients.First(thfh => thfh.PatientID == _patientID);

                                    tb.LastOverhalDate = (from e in DCMD2.TBL_DelPatientVisits
                                                          where e.PatientID == _patientID
                                                          select new { e.VisitDate }).Max(g => g.VisitDate);
                                    DCMD2.SubmitChanges();
                                }
                            }
                            catch { }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "این اطلاعات قبلا وارد شده و تکراری است!", ex.Message);
                        else
                            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                        return false;
                    }

            return true;
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Other
        TextBox tx = new TextBox();
        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            { e.KeyChar = '\0'; return; }

            if (e.KeyChar == (char)Keys.Space)
            {
                tx = (TextBox)sender;
                if (tx.Text.Length < 18) tx.Text = tx.Text + "000";
                tx.SelectionStart = tx.Text.Length;
            }
        }

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {
            tx = (TextBox)sender;
            string str = tx.Text;
            int ts = tx.SelectionStart;
            if (tx.Text != "")
            {
                try
                {
                    str = System.String.Format("{0:###,###}", System.Int64.Parse(str, System.Globalization.NumberStyles.Number));
                }
                catch
                {
                    str = str.Replace(",", "");
                }
                tx.Text = str.Replace(" ", "");
                tx.SelectionStart = ts + 1;
            }

        }

        private void panel_CDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthCD.Text) > 6 && Convert.ToInt16(comboBox_DayCD.Text) == 31) comboBox_DayCD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthCD.Text) == 12 && (Convert.ToInt16(comboBox_DayCD.Text) == 31 || Convert.ToInt16(comboBox_DayCD.Text) == 30)) comboBox_DayCD.Text = "29";
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthF.Text) > 6 && Convert.ToInt16(comboBoxDayF.Text) == 31) comboBoxDayF.Text = "30";
            if (Convert.ToInt16(comboBoxMonthF.Text) == 12 && (Convert.ToInt16(comboBoxDayF.Text) == 31 || Convert.ToInt16(comboBoxDayF.Text) == 30)) comboBoxDayF.Text = "29";
        }

        #endregion



        private void buttonPatientID_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(0);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                FreeComponent();
                _patientID = sp.CodeC;
                textBoxPatientID.Tag = sp.CodeC;
                textBoxPatientID.Text = sp.NameC;

                int f = 0;
                try
                {
                    f = (from fg in DCMD.TBL_PatientVisits where fg.PatientID == _patientID select fg.VisitCode).Max();
                }
                catch { f = 0; }
                if (f != 0)
                    FillComponents(_patientID, f);
                textBoxVisitCode.Text = (int.Parse(textBoxVisitCode.Text == "" ? "0" : textBoxVisitCode.Text) + 1).ToString();
            }
        }

        private void FreeComponent()
        {
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            comboBoxYearF.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBoxMonthF.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBoxDayF.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            textBoxPatientID.Tag = 0;
            textBoxPatientID.Text = "";
            textBoxVisitCode.Text = "0";
            chkForceVisit.Checked = false;

            textBoxCostDoctor.Text = "0";
            checkBoxCostDoctor.Checked = false;

            chkDrugsHistory.Checked = false;
            chkParaclinic.Checked = false;
            chkStateSickness.Checked = false;
            chkbedsore.Checked = false;

            textBoxPatientStateDsc.Text = "";
            chkVisitOK.Checked = false;
            
            comboBoxBusinessReasons.Text = "";
            checkBoxUnwillingness.Checked = false;
        }


        private void buttonStateSickness_Click(object sender, EventArgs e)
        {
            StateSickness_frm s = new StateSickness_frm(_patientID, _visitCode, _status);
            s.ShowDialog();
            
            textBoxStateSickness.Text = DCMD.VisitStateSicknessStr(_patientID, _visitCode);
        }

        private void buttonParaclinic_Click(object sender, EventArgs e)
        {
            Paraclinic_frm s = new Paraclinic_frm(_patientID, _visitCode, _status);
            s.ShowDialog();
            
            textBoxParaclinic.Text = DCMD.VisitStateParaclinicsStr(_patientID, _visitCode);
        }

        private void buttonDrugsHistory_Click(object sender, EventArgs e)
        {
            StateDrugs_frm s = new StateDrugs_frm(_patientID, _visitCode, _status);
            s.ShowDialog();

            textBoxDrugsHistory.Text = DCMD.VisitStateDrugsStr(_patientID, _visitCode);
        }

        private void buttonBedsore_Click(object sender, EventArgs e)
        {
            StateBedsore_frm s = new StateBedsore_frm(_patientID, _visitCode, _status);
            s.ShowDialog();
            
            textBoxBedsore.Text = DCMD.VisitStateBedsoreStr(_patientID, _visitCode);
        }

        private void buttonVaccination_Click(object sender, EventArgs e)
        {
            StateVaccination_frm s = new StateVaccination_frm(_patientID, _visitCode, _status);
            s.ShowDialog();

            textBoxVaccination.Text = DCSSS.VisitStateVaccinationStr(_patientID, _visitCode);
        }

        private void buttonEquipmentUse_Click(object sender, EventArgs e)
        {
            StateEquipmentUse_frm s = new StateEquipmentUse_frm(_patientID, _visitCode, _status);
            s.ShowDialog();

            textBoxEquipmentUse.Text = DCSSS.VisitStateEquipmentUseStr(_patientID, _visitCode);
        }

        private void buttonDoctorID_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(1);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxDoctorName.Tag = sp.CodeC;
                textBoxDoctorName.Text = sp.NameC;
            }
        }

        private void checkBoxCostDoctor_CheckValueChanged(object sender, EventArgs e)
        {
            panel1.Enabled = checkBoxCostDoctor.Checked;
        }

        

       
    }
}
