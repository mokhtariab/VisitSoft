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
    public partial class PatientNE_frm : Form
    {
        int _PatientType = 0, _PatientID = 0;
        bool _newOrEditPatient = false, _activeOrDelete = true;

        public PatientNE_frm(bool NewOrEditPatient, int PatientType, int PatientID, bool ActiveOrDelete)
        {
            InitializeComponent();
            _PatientType = PatientType;
            _PatientID = PatientID;
            _newOrEditPatient = NewOrEditPatient;
            _activeOrDelete = ActiveOrDelete;
        }


        //ContractTypeId      به عنوان بیمار زوج0 و فرد1

        DataClasses_MainDataContext DCMD2 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void PatientNE_frm_Load(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            var SUS = from prd in DCMD.TBL_PrtCities
                      orderby prd.CityName_Fa
                      select prd;
            ComboBoxBrithCityName.DataSource = SUS;
            ComboBoxBrithCityName.SelectedIndex = -1; 


            //var SUS2 = from prd in DCMD.TBL_ContractTypes
            //           select new { prd.ContractTypeId, prd.ContractTypeDsc };
            //comboBoxContract.DisplayMember = "ContractTypeDsc";
            //comboBoxContract.ValueMember = "ContractTypeId";
            //comboBoxContract.DataSource = SUS2;

            
            
            //new 940315
            
            //var SUS3 = from prd in DCMD.TBL_PatientTypes
            //           select new { prd.PatientTypeId, prd.PatientTypeDsc };
            //comboBoxPatientType.DisplayMember = "PatientTypeDsc";
            //comboBoxPatientType.ValueMember = "PatientTypeId";
            //comboBoxPatientType.DataSource = SUS3;

            if (itemPanelPatientType.Items.Count == 0)
                foreach (var item in DCMD.TBL_PatientTypes)
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.PatientTypeId.ToString();
                    Ch.Text = item.PatientTypeDsc;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelPatientType.Items.Add(Ch);
                    itemPanelPatientType.Refresh();
                }

            if (itemPanelInjuryType.Items.Count == 0)
                foreach (var item in DCMD.TBL_InjuryTypes)
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.InjuryTypeId.ToString();
                    Ch.Text = item.InjuryTypeDsc;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelInjuryType.Items.Add(Ch);
                    itemPanelInjuryType.Refresh();
                }
            //New 940315


            var SUS4 = (from prd in DCMD.TBL_Patients
                        orderby prd.KinShipWith
                        select new { prd.KinShipWith }).Distinct();
            comboBoxKinShipWith.DisplayMember = "KinShipWith";
            comboBoxKinShipWith.ValueMember = "KinShipWith";
            comboBoxKinShipWith.DataSource = SUS4;

            var SUS5 = (from prd in DCMD.TBL_Patients
                        orderby prd.WifeSituation 
                        select new { prd.WifeSituation }).Distinct();
            comboBoxWifeSituation.DisplayMember = "WifeSituation";
            comboBoxWifeSituation.ValueMember = "WifeSituation";
            comboBoxWifeSituation.DataSource = SUS5;

            //var SUS6 = (from prd in DCMD.TBL_Patients
            //            orderby prd.ProtectSituation 
            //            select new { prd.ProtectSituation }).Distinct();
            //comboBoxProtectSituationOld.DisplayMember = "ProtectSituation";
            //comboBoxProtectSituationOld.ValueMember = "ProtectSituation";
            //comboBoxProtectSituationOld.DataSource = SUS6;

            var SUS7 = (from prd in DCMD.TBL_Patients
                        orderby prd.WholeSituation 
                        select new { prd.WholeSituation }).Distinct();
            comboBoxWholeSituation.DisplayMember = "WholeSituation";
            comboBoxWholeSituation.ValueMember = "WholeSituation";
            comboBoxWholeSituation.DataSource = SUS7;

            //var SUS8 = (from prd in DCMD.TBL_Patients
            //            select new { prd.Description }).Distinct();
            //comboBoxDsc.DisplayMember = "Description";
            //comboBoxDsc.ValueMember = "Description";
            //comboBoxDsc.DataSource = SUS8;

            var SUS9 = (from prd in DCMD.TBL_Patients
                        select new { prd.CityPart }).Distinct();
            comboBoxCityPart.DisplayMember = "CityPart";
            comboBoxCityPart.ValueMember = "CityPart";
            comboBoxCityPart.DataSource = SUS9;


            var SUS13 = (from prd in DCMD.TBL_Patients
                         select new { prd.Email }).Distinct();
            comboBox_EMail.DisplayMember = "Email";
            comboBox_EMail.ValueMember = "Email";
            comboBox_EMail.DataSource = SUS13;


            var SUS14 = (from prd in DCMD.TBL_Patients
                         select new { prd.BasicInsurance }).Distinct();
            comboBoxBasicInsurance.DisplayMember = "BasicInsurance";
            comboBoxBasicInsurance.ValueMember = "BasicInsurance";
            comboBoxBasicInsurance.DataSource = SUS14;


            var SUS15 = (from prd in DCMD.TBL_Patients
                         select new { prd.CompletionInsurance }).Distinct();
            comboBoxCompletionInsurance.DisplayMember = "CompletionInsurance";
            comboBoxCompletionInsurance.ValueMember = "CompletionInsurance";
            comboBoxCompletionInsurance.DataSource = SUS15;

            var SUS16 = (from prd in DCMD.TBL_Patients
                         select new { prd.Description }).Distinct();
            comboBoxDsc.DisplayMember = "Description";
            comboBoxDsc.ValueMember = "Description";
            comboBoxDsc.DataSource = SUS16;



            //var SUS77 = from prd in DCMD.TBL_Doctors
            //            //where prd.DoctorType == 1 && prd.Active == true
            //            where prd.Active == true
            //            select new
            //            {
            //                prd.DoctorID,
            //                DoctorN = prd.DoctorName + " " + prd.DoctorFamily 
            //                //+ "-" + DCMD.TBL_DoctorTypes.First(h => h.DoctorTypeId == prd.DoctorType).DoctorTypeDsc
            //            };
            //comboBoxLastDocHealthId.DisplayMember = "DoctorN";
            //comboBoxLastDocHealthId.ValueMember = "DoctorID";
            //comboBoxLastDocHealthId.DataSource = SUS77;


            var SUS10 = from prd in DCMD.TBL_Doctors
                        where prd.DoctorType == 2 && prd.Active == true
                        select new { prd.DoctorID, DoctorN = prd.DoctorName + " " + prd.DoctorFamily };
            comboBoxLastDocWatcherId.DisplayMember = "DoctorN";
            comboBoxLastDocWatcherId.ValueMember = "DoctorID";
            comboBoxLastDocWatcherId.DataSource = SUS10;



            if (!_activeOrDelete)
            {
                comboBoxDelType.Visible = true;
                labelDel.Visible = true;
                var SUS11 = (from prd in DCMD.TBL_DelPatients
                             select new { prd.DelType }).Distinct();
                comboBoxDelType.DisplayMember = "DelType";
                comboBoxDelType.ValueMember = "DelType";
                comboBoxDelType.DataSource = SUS11;
            }



            SetDefault_PatientNE();
        }

        private void SetDefault_PatientNE()
        {

            if (!_newOrEditPatient)
            {
                try
                {
                    if (_activeOrDelete)
                    {
                        TBL_Patient tbhc = DCMD2.TBL_Patients.First(thfr => thfr.PatientID.Equals(_PatientID));
                        //comboBoxPatientType.SelectedValue = tbhc.PatientTypeId;

                        textBoxDosiersNo.Text = tbhc.DosiersNo;

                        string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.CreateDate));
                        comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        textBox_Name.Text = tbhc.PatientName;
                        textBox_Family.Text = tbhc.PatientFamily;
                        textBox_Parent.Text = tbhc.ParentName;
                        textBox_IDNO.Text = tbhc.IDNO.ToString();
                        textBox_NationalCode.Text = tbhc.NationalCode;
                        ComboBoxBrithCityName.Text = tbhc.BrithCityName;

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate));
                        comboBox_Year2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_Month2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_Day2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDownPercentState.Value = int.Parse(tbhc.PercentState.ToString());

                        comboBoxKinShipWith.Text = tbhc.KinShipWith;
                        comboBoxWifeSituation.Text = tbhc.WifeSituation;
                        comboBoxProtectSituation.Text = tbhc.ProtectSituation;
                        //comboBoxProtectSituationOld.Text = tbhc.ProtectSituation;
                        comboBoxWholeSituation.Text = tbhc.WholeSituation;
                        comboBoxDsc.Text = tbhc.Description;
                        nUpDownPeriodVisit.Value = int.Parse(tbhc.PeriodVisit.ToString());


                        comboBoxCityPart.Text = tbhc.CityPart;
                        nUpDown_AddressPrt.Value = int.Parse(tbhc.AddressPart.ToString());
                        textBox_Address.Text = tbhc.Address;
                        textBox_Tel.Text = tbhc.TelHome;
                        textBox_TelBusiness.Text = tbhc.TelBusiness;
                        textBox_mobile.Text = tbhc.Mobile;
                        textBox_mobile2.Text = tbhc.Mobile2;
                        comboBox_EMail.Text = tbhc.Email;

                        comboBoxContract.SelectedValue = tbhc.ContractTypeId;

                        try
                        {
                            //comboBoxLastDocHealthId.SelectedValue = int.Parse(tbhc.LastDocHealthId.Value.ToString());
                            textBoxDoctorName.Tag = tbhc.LastDocHealthId.Value;
                            textBoxDoctorName.Text = DCMD2.TBL_Doctors.First(d => d.DoctorID == Convert.ToInt32(tbhc.LastDocHealthId.Value)).DoctorName + " " + DCMD2.TBL_Doctors.First(d => d.DoctorID == Convert.ToInt32(tbhc.LastDocHealthId.Value)).DoctorFamily;
                        }
                        catch { }

                        //comboBoxLastDocWatcherId.SelectedValue = int.Parse(tbhc.LastDocWatcherId.Value.ToString());

                        try
                        {
                            DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.LastOverhalDate));
                            comboBoxYearLO.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                            comboBoxMonthLO.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                            comboBoxDayLO.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                        }
                        catch { }

                        //new 940315
                        foreach (var item in (from PT in DCMD2.TBL_PatientTypeGroups where PT.PatientId == _PatientID select PT))
                            (itemPanelPatientType.Items[item.PatientTypeId.ToString()] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;

                        foreach (var item in (from PT in DCMD2.TBL_InjuryTypePatients where PT.PatientId == _PatientID select PT))
                            (itemPanelInjuryType.Items[item.InjuryTypeId.ToString()] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;

                        try
                        {
                            textBoxMartyrPatient.Tag = tbhc.MartyrId;
                            textBoxMartyrPatient.Text = DCMD2.TBL_Martyrs.Where(c => c.MartyrId == tbhc.MartyrId).Single().MartyrNameFamily;
                        }
                        catch { }

                        textBoxPostalCode.Text = tbhc.PostalCode;
                        nUpDownInstitutePart.Value = Convert.ToDecimal(tbhc.InstitutePart);
                        comboBoxBasicInsurance.Text = tbhc.BasicInsurance;
                        comboBoxCompletionInsurance.Text = tbhc.CompletionInsurance;
                        //new 940315


                        comboBoxSex.SelectedIndex = tbhc.Sex.Value;
                        comboBoxBonyadAddEven.SelectedIndex = tbhc.BonyadAddEven.Value;
                    }
                    if (!_activeOrDelete)
                    {
                        TBL_DelPatient tbhc = DCMD2.TBL_DelPatients.First(thfr => thfr.PatientID.Equals(_PatientID));

                        comboBoxDelType.Text = tbhc.DelType;
                        
                        //comboBoxPatientType.SelectedValue = 0;// tbhc.PatientTypeId;
                       
                        textBoxDosiersNo.Text = tbhc.DosiersNo;

                        string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.CreateDate));
                        comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        textBox_Name.Text = tbhc.PatientName;
                        textBox_Family.Text = tbhc.PatientFamily;
                        textBox_Parent.Text = tbhc.ParentName;
                        textBox_IDNO.Text = tbhc.IDNO.ToString();
                        textBox_NationalCode.Text = tbhc.NationalCode;
                        ComboBoxBrithCityName.Text = tbhc.BrithCityName;

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate));
                        comboBox_Year2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_Month2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_Day2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDownPercentState.Value = int.Parse(tbhc.PercentState.ToString());

                        comboBoxKinShipWith.Text = tbhc.KinShipWith;
                        comboBoxWifeSituation.Text = tbhc.WifeSituation;

                        comboBoxProtectSituation.Text = tbhc.ProtectSituation;
                        //comboBoxProtectSituationOld.Text = tbhc.ProtectSituation;
                        
                        comboBoxWholeSituation.Text = tbhc.WholeSituation;
                        comboBoxDsc.Text = tbhc.Description;
                        nUpDownPeriodVisit.Value = int.Parse(tbhc.PeriodVisit.ToString());


                        comboBoxCityPart.Text = tbhc.CityPart;
                        nUpDown_AddressPrt.Value = int.Parse(tbhc.AddressPart.ToString());
                        textBox_Address.Text = tbhc.Address;
                        textBox_Tel.Text = tbhc.TelHome;
                        textBox_TelBusiness.Text = tbhc.TelBusiness;
                        textBox_mobile.Text = tbhc.Mobile;
                        textBox_mobile2.Text = tbhc.Mobile2;
                        comboBox_EMail.Text = tbhc.Email;

                        comboBoxContract.SelectedValue = tbhc.ContractTypeId;

                        try
                        {
                            //comboBoxLastDocHealthId.SelectedValue = int.Parse(tbhc.LastDocHealthId.Value.ToString());
                            textBoxDoctorName.Tag = tbhc.LastDocHealthId.Value;
                            textBoxDoctorName.Text = DCMD2.TBL_Doctors.First(d => d.DoctorID == Convert.ToInt32(tbhc.LastDocHealthId.Value)).DoctorName + " " + DCMD2.TBL_Doctors.First(d => d.DoctorID == Convert.ToInt32(tbhc.LastDocHealthId.Value)).DoctorFamily;
                        }
                        catch { }

                        
                        //comboBoxLastDocWatcherId.SelectedValue = int.Parse(tbhc.LastDocWatcherId.Value.ToString());

                        try
                        {
                            DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.LastOverhalDate));
                            comboBoxYearLO.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                            comboBoxMonthLO.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                            comboBoxDayLO.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                        }
                        catch { }

                        
                        //new 940315
                        
                        foreach (var item in (from PT in DCMD2.TBL_PatientTypeGroups where PT.PatientId == _PatientID select PT))
                            (itemPanelPatientType.Items[item.PatientTypeId.ToString()] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;

                        foreach (var item in (from PT in DCMD2.TBL_InjuryTypePatients where PT.PatientId == _PatientID select PT))
                            (itemPanelInjuryType.Items[item.InjuryTypeId.ToString()] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;

                        try
                        {
                            textBoxMartyrPatient.Tag = tbhc.MartyrId;
                            textBoxMartyrPatient.Text = Convert.ToString(DCMD2.TBL_Martyrs.Where(c => c.MartyrId == tbhc.MartyrId).Single().MartyrNameFamily);
                        }
                        catch { }

                        textBoxPostalCode.Text = tbhc.PostalCode;
                        nUpDownInstitutePart.Value = Convert.ToDecimal(tbhc.InstitutePart);
                        comboBoxBasicInsurance.Text = tbhc.BasicInsurance;
                        comboBoxCompletionInsurance.Text = tbhc.CompletionInsurance;
                        
                        //new 940315

                        comboBoxSex.SelectedIndex = tbhc.Sex.Value;
                        comboBoxBonyadAddEven.SelectedIndex = tbhc.BonyadAddEven.Value;

                    }
                    //chkActive.Checked = tbhc.Active.Value;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditPatient)
            {
                //date
                string DateStr2 = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_Year1.Text = Convert.ToInt16(DateStr2.Substring(0, 4)).ToString();
                comboBox_Month1.Text = Convert.ToInt16(DateStr2.Substring(5, 2)).ToString();
                comboBox_day1.Text = Convert.ToInt16(DateStr2.Substring(8, 2)).ToString();

                comboBox_Year2.Text = Convert.ToInt16(DateStr2.Substring(0, 4)).ToString();
                comboBox_Month2.Text = Convert.ToInt16(DateStr2.Substring(5, 2)).ToString();
                comboBox_Day2.Text = Convert.ToInt16(DateStr2.Substring(8, 2)).ToString();

                comboBoxYearLO.Text = "1387";
                comboBoxMonthLO.Text = "1";
                comboBoxDayLO.Text = "1";

                ComboBoxBrithCityName.Text = "";
                comboBoxWifeSituation.Text = "";
                comboBoxKinShipWith.Text = "";
                comboBoxDsc.Text = "";
                comboBoxLastDocWatcherId.SelectedValue = 0;
                comboBoxProtectSituation.Text = "";
                //comboBoxProtectSituationOld.Text = "";
                comboBoxWholeSituation.Text = "";
                comboBoxCityPart.Text = "";


                //new 940315
                foreach (var item in itemPanelPatientType.Items)
                    (item as DevComponents.DotNetBar.CheckBoxItem).Checked = false;
                foreach (var item in itemPanelInjuryType.Items)
                    (item as DevComponents.DotNetBar.CheckBoxItem).Checked = false;
                
                textBoxMartyrPatient.Tag = 0;
                textBoxMartyrPatient.Text = "";

                textBoxPostalCode.Text = "";
                nUpDownInstitutePart.Value = 0;
                comboBoxBasicInsurance.Text = "";
                comboBoxCompletionInsurance.Text = "";

                //new 940315
                
                comboBoxSex.SelectedIndex = 0;
                comboBoxBonyadAddEven.SelectedIndex = 0;

            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            //new 940315
            
            //if (textBoxDosiersNo.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "شماره پرونده را وارد کنید!"); textBoxDosiersNo.Focus(); return; }
            if (textBox_NationalCode.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد ملی را وارد کنید!"); textBox_NationalCode.Focus(); return; }
            if (textBox_NationalCode.Text.Length != 10) { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد ملی را به طور صحیح وارد نمایید!"); textBox_NationalCode.Focus(); return; }

            if (itemPanelPatientType.SelectedItems.Count == 0) { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "وضعیت بیمار را مشخص نمایید!"); itemPanelPatientType.Focus(); return; }

            //new 940315


            if (textBox_Name.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام را وارد کنید!"); textBox_Name.Focus(); return; }
            if (textBox_Family.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام خانوادگی را وارد کنید!"); textBox_Family.Focus(); return; }
            if (textBox_mobile.Text == "" && textBox_Tel.Text == "" && textBox_TelBusiness.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "یکی از تلفن ها را وارد نمایید!"); textBox_mobile.Focus(); return; }
            if (textBox_mobile.Text != "" && textBox_mobile.Text.Length < 11)
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا شماره موبایل را به طور صحیح وارد نمایید!"); textBox_mobile.Focus(); return; }
            if (textBox_mobile2.Text != "" && textBox_mobile2.Text.Length < 11)
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا شماره موبایل را به طور صحیح وارد نمایید!"); textBox_mobile2.Focus(); return; }
            if (textBox_Tel.Text != "" && textBox_Tel.Text.Length < 8)
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا شماره تلفن را به طور صحیح وارد نمایید!"); textBox_Tel.Focus(); return; }
            if (textBox_TelBusiness.Text != "" && textBox_TelBusiness.Text.Length < 8)
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا شماره تلفن را به طور صحیح وارد نمایید!"); textBox_TelBusiness.Focus(); return; }
            
            if (!_activeOrDelete && comboBoxDelType.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نوع حذف را وارد کنید!"); comboBoxDelType.Focus(); return; }


            panel_CDate1_Leave(this, null);
            panel_BrithDate_Leave(this, null);
            panelLastOverhalDate_Leave(this, null);

            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید تغییرات درخواستی ثبت شوند؟"))
            {
                if (OKFunction())
                    this.Close();
            }
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditPatient)
                try
                {

                    TBL_Patient THC = new TBL_Patient
                    {
                        //PatientTypeId = Convert.ToInt16(comboBoxPatientType.SelectedValue),


                        DosiersNo = textBoxDosiersNo.Text,

                        CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text),

                        PatientName = textBox_Name.Text,
                        PatientFamily = textBox_Family.Text,
                        ParentName = textBox_Parent.Text,
                        IDNO = textBox_IDNO.Text,
                        NationalCode = textBox_NationalCode.Text,
                        BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text),
                        BrithCityName = ComboBoxBrithCityName.Text,

                        PercentState = Convert.ToInt16(nUpDownPercentState.Value),

                        KinShipWith = comboBoxKinShipWith.Text,
                        WifeSituation = comboBoxWifeSituation.Text,
                        //ProtectSituation = comboBoxProtectSituationOld.Text,
                        ProtectSituation = comboBoxProtectSituation.Text,
                        WholeSituation = comboBoxWholeSituation.Text,
                        Description = comboBoxDsc.Text,
                        PeriodVisit = Convert.ToInt16(nUpDownPeriodVisit.Value),

                        CityPart = comboBoxCityPart.Text,
                        AddressPart = Convert.ToInt16(nUpDown_AddressPrt.Value),
                        Address = textBox_Address.Text,
                        TelHome = textBox_Tel.Text,
                        TelBusiness = textBox_TelBusiness.Text,
                        Mobile = textBox_mobile.Text,
                        Mobile2 = textBox_mobile2.Text,
                        Email = comboBox_EMail.Text,

                        ContractTypeId = Convert.ToInt16(comboBoxContract.SelectedValue??0),
                        LastDocHealthId = Convert.ToInt16(textBoxDoctorName.Tag??0),
                        //LastDocWatcherId = Convert.ToInt16(comboBoxLastDocWatcherId.SelectedValue??0),

                        LastOverhalDate = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO.Text, comboBoxMonthLO.Text, comboBoxDayLO.Text),
                        StatusVisit = 0,
                        //Sex = 0,
                        Active = true,


                        //new 940315

                        MartyrId = Convert.ToInt32(textBoxMartyrPatient.Tag),
                        PostalCode = textBoxPostalCode.Text,
                        InstitutePart = Convert.ToInt16(nUpDownInstitutePart.Value),
                        BasicInsurance = comboBoxBasicInsurance.Text,
                        CompletionInsurance = comboBoxCompletionInsurance.Text,

                        //new 940315

                        Sex = Convert.ToByte(comboBoxSex.SelectedIndex),
                        BonyadAddEven = Convert.ToByte(comboBoxBonyadAddEven.SelectedIndex),
                        
                    
                    };

                    DCMD1.TBL_Patients.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();



                    //new 940315
                    int NewPatientID = (from h in DCMD2.TBL_Patients select h.PatientID).Max();

                    try
                    {
                        foreach (var item in itemPanelPatientType.Items)
                        {
                            if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                            {
                                TBL_PatientTypeGroup PatientTG = new TBL_PatientTypeGroup
                                {
                                    PatientId = NewPatientID,
                                    PatientTypeId = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name)
                                };
                                DCMD2.TBL_PatientTypeGroups.InsertOnSubmit(PatientTG);
                                DCMD2.SubmitChanges();
                            }
                        }
                    }
                    catch { }

                    try
                    {
                        foreach (var item in itemPanelInjuryType.Items)
                        {
                            if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                            {
                                TBL_InjuryTypePatient InjuryTP = new TBL_InjuryTypePatient
                                {
                                    PatientId = NewPatientID,
                                    InjuryTypeId = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name)
                                };
                                DCMD2.TBL_InjuryTypePatients.InsertOnSubmit(InjuryTP);
                                DCMD2.SubmitChanges();
                            }
                        }
                    }
                    catch { }

                    TBL_Patient TP = DCMD1.TBL_Patients.First(h => h.PatientID == NewPatientID);
                    TP.PatientTypeStr = DCMD1.PatientTypeStr(NewPatientID);
                    TP.InjuryTypeStr = DCMD1.InjuryTypeStr(NewPatientID);
                    DCMD1.SubmitChanges();

                    //new 940315
                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات بیمار قبلا وارد شده و تکراری است!", ex.Message);
                    else
                        if (ex.Message.IndexOf("Duplicated Tbl_Del!") > -1)
                            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "این بیمار در لیست حذفیات موجود می باشد!", ex.Message);
                        else
                            if (ex.Message.IndexOf("IX_TBL_Patient") > -1)
                                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد ملی تکراری است", ex.Message);
                            else
                                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditPatient)
                    try
                    {
                        if (_activeOrDelete)
                        {
                            TBL_Patient tbhc = DCMD1.TBL_Patients.First(thfh => thfh.PatientID.Equals(_PatientID));

                            //tbhc.PatientTypeId = Convert.ToInt16(comboBoxPatientType.SelectedValue);
                            tbhc.DosiersNo = textBoxDosiersNo.Text;

                            tbhc.CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text);

                            tbhc.PatientName = textBox_Name.Text;
                            tbhc.PatientFamily = textBox_Family.Text;
                            tbhc.ParentName = textBox_Parent.Text;
                            tbhc.IDNO = textBox_IDNO.Text;
                            tbhc.NationalCode = textBox_NationalCode.Text;
                            tbhc.BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);
                            tbhc.BrithCityName = ComboBoxBrithCityName.Text;

                            tbhc.PercentState = Convert.ToInt16(nUpDownPercentState.Value);

                            tbhc.KinShipWith = comboBoxKinShipWith.Text;
                            tbhc.WifeSituation = comboBoxWifeSituation.Text;
                            //tbhc.ProtectSituation = comboBoxProtectSituationOld.Text;
                            tbhc.ProtectSituation = comboBoxProtectSituation.Text;
                            tbhc.WholeSituation = comboBoxWholeSituation.Text;
                            tbhc.Description = comboBoxDsc.Text;
                            tbhc.PeriodVisit = Convert.ToInt16(nUpDownPeriodVisit.Value);

                            tbhc.CityPart = comboBoxCityPart.Text;
                            tbhc.AddressPart = Convert.ToInt16(nUpDown_AddressPrt.Value);
                            tbhc.Address = textBox_Address.Text;
                            tbhc.TelHome = textBox_Tel.Text;
                            tbhc.TelBusiness = textBox_TelBusiness.Text;
                            tbhc.Mobile = textBox_mobile.Text;
                            tbhc.Mobile2 = textBox_mobile2.Text;
                            tbhc.Email = comboBox_EMail.Text;

                            tbhc.ContractTypeId = Convert.ToInt16(comboBoxContract.SelectedValue??0);
                            tbhc.LastDocHealthId = Convert.ToInt16(textBoxDoctorName.Tag ?? 0);
                            //tbhc.LastDocWatcherId = Convert.ToInt16(comboBoxLastDocWatcherId.SelectedValue??0);

                            tbhc.LastOverhalDate = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO.Text, comboBoxMonthLO.Text, comboBoxDayLO.Text);


                            //new 940315
                            tbhc.MartyrId = Convert.ToInt32(textBoxMartyrPatient.Tag);
                            tbhc.PostalCode = textBoxPostalCode.Text;
                            tbhc.InstitutePart = Convert.ToInt16(nUpDownInstitutePart.Value);
                            tbhc.BasicInsurance = comboBoxBasicInsurance.Text;
                            tbhc.CompletionInsurance = comboBoxCompletionInsurance.Text;
                            //new 940315

                            tbhc.Sex = Convert.ToByte(comboBoxSex.SelectedIndex);
                            tbhc.BonyadAddEven = Convert.ToByte(comboBoxBonyadAddEven.SelectedIndex);
                            
                            DCMD1.SubmitChanges();

                            //new 940315
                            var PatientTypeGroups = DCMD1.TBL_PatientTypeGroups.Where(c => c.PatientId == _PatientID);
                            DCMD1.TBL_PatientTypeGroups.DeleteAllOnSubmit(PatientTypeGroups);
                            DCMD1.SubmitChanges();

                            foreach (var item in itemPanelPatientType.Items)
                            {
                                if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                                {
                                    TBL_PatientTypeGroup PatientTG = new TBL_PatientTypeGroup
                                    {
                                        PatientId = _PatientID,
                                        PatientTypeId = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name)
                                    };
                                    DCMD1.TBL_PatientTypeGroups.InsertOnSubmit(PatientTG);
                                    DCMD1.SubmitChanges();
                                }
                            }

                            var InjuryTypes = DCMD1.TBL_InjuryTypePatients.Where(c => c.PatientId == _PatientID);
                            DCMD1.TBL_InjuryTypePatients.DeleteAllOnSubmit(InjuryTypes);
                            DCMD1.SubmitChanges();

                            foreach (var item in itemPanelInjuryType.Items)
                            {
                                if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                                {
                                    TBL_InjuryTypePatient InjuryTP = new TBL_InjuryTypePatient
                                    {
                                        PatientId = _PatientID,
                                        InjuryTypeId = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name)
                                    };
                                    DCMD1.TBL_InjuryTypePatients.InsertOnSubmit(InjuryTP);
                                    DCMD1.SubmitChanges();
                                }
                            }



                            try
                            {
                                TBL_Patient tbhc1 = DCMD2.TBL_Patients.First(thfh => thfh.PatientID.Equals(_PatientID));
                                tbhc1.PatientTypeStr = DCMD2.PatientTypeStr(_PatientID);
                                tbhc1.InjuryTypeStr = DCMD2.InjuryTypeStr(_PatientID);
                                DCMD2.SubmitChanges();
                            }
                            catch { }
                            //new 940315


                        }
                        else
                        {
                            TBL_DelPatient tbhc = DCMD1.TBL_DelPatients.First(thfh => thfh.PatientID.Equals(_PatientID));

                            tbhc.DelType = comboBoxDelType.Text;

                            //tbhc.PatientTypeId = Convert.ToInt16(comboBoxPatientType.SelectedValue);
                            tbhc.DosiersNo = textBoxDosiersNo.Text;

                            tbhc.CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text);

                            tbhc.PatientName = textBox_Name.Text;
                            tbhc.PatientFamily = textBox_Family.Text;
                            tbhc.ParentName = textBox_Parent.Text;
                            tbhc.IDNO = textBox_IDNO.Text;
                            tbhc.NationalCode = textBox_NationalCode.Text;
                            tbhc.BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);
                            tbhc.BrithCityName = ComboBoxBrithCityName.Text;

                            tbhc.PercentState = Convert.ToInt16(nUpDownPercentState.Value);

                            tbhc.KinShipWith = comboBoxKinShipWith.Text;
                            tbhc.WifeSituation = comboBoxWifeSituation.Text;
                            //tbhc.ProtectSituation = comboBoxProtectSituationOld.Text;
                            tbhc.ProtectSituation = comboBoxProtectSituation.Text;
                            tbhc.WholeSituation = comboBoxWholeSituation.Text;
                            tbhc.Description = comboBoxDsc.Text;
                            tbhc.PeriodVisit = Convert.ToInt16(nUpDownPeriodVisit.Value);

                            tbhc.CityPart = comboBoxCityPart.Text;
                            tbhc.AddressPart = Convert.ToInt16(nUpDown_AddressPrt.Value);
                            tbhc.Address = textBox_Address.Text;
                            tbhc.TelHome = textBox_Tel.Text;
                            tbhc.TelBusiness = textBox_TelBusiness.Text;
                            tbhc.Mobile = textBox_mobile.Text;
                            tbhc.Mobile2 = textBox_mobile2.Text;
                            tbhc.Email = comboBox_EMail.Text;

                            tbhc.ContractTypeId = Convert.ToInt16(comboBoxContract.SelectedValue ?? 0);
                            tbhc.LastDocHealthId = Convert.ToInt16(textBoxDoctorName.Tag ?? 0);
                            //tbhc.LastDocWatcherId = Convert.ToInt16(comboBoxLastDocWatcherId.SelectedValue ?? 0);

                            tbhc.LastOverhalDate = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO.Text, comboBoxMonthLO.Text, comboBoxDayLO.Text);

                            //new 940315
                            tbhc.MartyrId = Convert.ToInt32(textBoxMartyrPatient.Tag);
                            tbhc.PostalCode = textBoxPostalCode.Text;
                            tbhc.InstitutePart = Convert.ToInt16(nUpDownInstitutePart.Value);
                            tbhc.BasicInsurance = comboBoxBasicInsurance.Text;
                            tbhc.CompletionInsurance = comboBoxCompletionInsurance.Text;
                          //new 940315


                            tbhc.Sex = Convert.ToByte(comboBoxSex.SelectedIndex);
                            tbhc.BonyadAddEven = Convert.ToByte(comboBoxBonyadAddEven.SelectedIndex);
                            

                            DCMD1.SubmitChanges();


                            //new 940315
                            var PatientTypeGroups = DCMD1.TBL_PatientTypeGroups.Where(c => c.PatientId == _PatientID);
                            DCMD1.TBL_PatientTypeGroups.DeleteAllOnSubmit(PatientTypeGroups);
                            DCMD1.SubmitChanges();

                            foreach (var item in itemPanelPatientType.Items)
                            {
                                if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                                {
                                    TBL_PatientTypeGroup PatientTG = new TBL_PatientTypeGroup
                                    {
                                        PatientId = _PatientID,
                                        PatientTypeId = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name)
                                    };
                                    DCMD1.TBL_PatientTypeGroups.InsertOnSubmit(PatientTG);
                                    DCMD1.SubmitChanges();
                                }
                            }

                            var InjuryTypes = DCMD1.TBL_InjuryTypePatients.Where(c => c.PatientId == _PatientID);
                            DCMD1.TBL_InjuryTypePatients.DeleteAllOnSubmit(InjuryTypes);
                            DCMD1.SubmitChanges();

                            foreach (var item in itemPanelInjuryType.Items)
                            {
                                if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                                {
                                    TBL_InjuryTypePatient InjuryTP = new TBL_InjuryTypePatient
                                    {
                                        PatientId = _PatientID,
                                        InjuryTypeId = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name)
                                    };
                                    DCMD1.TBL_InjuryTypePatients.InsertOnSubmit(InjuryTP);
                                    DCMD1.SubmitChanges();
                                }
                            }

                            try
                            {
                                TBL_DelPatient tbhc1 = DCMD2.TBL_DelPatients.First(thfh => thfh.PatientID.Equals(_PatientID));
                                tbhc1.PatientTypeStr = DCMD2.PatientTypeStr(_PatientID);
                                tbhc1.InjuryTypeStr = DCMD2.InjuryTypeStr(_PatientID);
                                DCMD2.SubmitChanges();
                            }
                            catch { }
                            //new 940315
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات بیمار قبلا وارد شده و تکراری است!", ex.Message);
                        else
                            if (ex.Message.IndexOf("Duplicated Tbl_Del!") > -1)
                                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "این بیمار در لیست حذفیات موجود می باشد!", ex.Message);
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
        private void panel_CDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }

        private void panel_BrithDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month2.Text) > 6 && Convert.ToInt16(comboBox_Day2.Text) == 31) comboBox_Day2.Text = "30";
            if (Convert.ToInt16(comboBox_Month2.Text) == 12 && (Convert.ToInt16(comboBox_Day2.Text) == 31 || Convert.ToInt16(comboBox_Day2.Text) == 30)) comboBox_Day2.Text = "29";
        }

        private void panelLastOverhalDate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(comboBoxMonthLO.Text) > 6 && Convert.ToInt16(comboBoxDayLO.Text) == 31) comboBoxDayLO.Text = "30";
                if (Convert.ToInt16(comboBoxMonthLO.Text) == 12 && (Convert.ToInt16(comboBoxDayLO.Text) == 31 || Convert.ToInt16(comboBoxDayLO.Text) == 30)) comboBoxDayLO.Text = "29";
            }
            catch { }
        }
        
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
        #endregion

        private void ButtonMartyrPatient_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(3);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxMartyrPatient.Tag = sp.CodeC;
                textBoxDosiersNo.Text = sp.NameC;
                textBoxMartyrPatient.Text = sp.OtherC;
            }
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(1);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxDoctorName.Tag = sp.CodeC;
                textBoxDoctorName.Text = sp.NameC;
            }

        }



    }
}
