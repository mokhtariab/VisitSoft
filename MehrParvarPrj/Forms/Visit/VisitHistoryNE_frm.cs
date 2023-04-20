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
    public partial class VisitHistoryNE_frm : Form
    {
        bool _newOrEditVisitHistory = false;
        string _mobileDoctor = "", _dosiersNo = "", _nationalCode = "";
        int _hour = 0, _minute = 0;
        DateTime _dtm = DateTime.Now;

        public VisitHistoryNE_frm(string DateVisitStr, string MobileDoctor, string DosiersNo, string Description, string NationalCode)
        {
            InitializeComponent();
            _mobileDoctor = MobileDoctor; _dosiersNo = DosiersNo; _nationalCode = NationalCode;

            try
            {
                _hour = Convert.ToInt32(DateVisitStr.Substring(11, 2));
                _minute = Convert.ToInt32(DateVisitStr.Substring(14, DateVisitStr.Length - 14));
            }
            catch
            {
                _hour = Convert.ToInt32(DateVisitStr.Substring(11, 1));
                _minute = Convert.ToInt32(DateVisitStr.Substring(13, DateVisitStr.Length - 13));
            }


            _dtm = Global_Cls.ShamsiDateToMiladiWithTime(DateVisitStr, "", "", "", _hour, _minute, 0);
            
            //AddHours(double.Parse(_hour.ToString()));
            //dtm.AddMinutes(double.Parse(_minute.ToString()));

            textBox_Mobile.Text = MobileDoctor;
            textBoxDosiersNo.Text = DosiersNo;
            textBoxDescription.Text = Description;
            textBoxNationalCode.Text = NationalCode;

            comboBox_YearBD.Text = Convert.ToInt16(DateVisitStr.Substring(0, 4)).ToString();
            comboBox_MonthBD.Text = Convert.ToInt16(DateVisitStr.Substring(5, 2)).ToString();
            comboBox_DayBD.Text = Convert.ToInt16(DateVisitStr.Substring(8, 2)).ToString();

            NUpDownHour.Value = _hour;
            NUpDownMinute.Value = _minute;

            //textBox_Mobile.Enabled = false;
            //textBoxDosiersNo.Enabled = false;
            //panel_VisitDate.Enabled = false;

            _newOrEditVisitHistory = false;
        }

        public VisitHistoryNE_frm()
        {
            InitializeComponent();
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBox_YearBD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBox_MonthBD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBox_DayBD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            _newOrEditVisitHistory = true;
        }

        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBoxNationalCode.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد ملی بیمار را وارد نمایید!"); textBoxNationalCode.Focus(); return; }
            try{long.Parse(textBoxNationalCode.Text);}
            catch
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد ملی بیمار را صحیح وارد نمایید!"); textBoxNationalCode.Focus(); return; }

            if (textBox_Mobile.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا موبایل پزشک را وارد نمایید!"); textBox_Mobile.Focus(); return; }
            if (textBox_Mobile.Text.Length != 11 || textBox_Mobile.Text[0].ToString()!="0") 
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا موبایل پزشک را صحیح وارد نمایید!"); textBox_Mobile.Focus(); return; }

            panel_BrithDate_Leave(this, null);

            if (OKFunction())
                Close();
        }

        private bool OKFunction()
        {
            DateTime Dtm = Global_Cls.ShamsiDateToMiladiWithTime("", comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text,
                int.Parse(NUpDownHour.Value.ToString()), int.Parse(NUpDownMinute.Value.ToString()), 0);

            if (_newOrEditVisitHistory)
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    TBL_VisitHistory THC = new TBL_VisitHistory()
                   {
                       DosiersNo = textBoxDosiersNo.Text,
                       NationalCode = textBoxNationalCode.Text,
                       DateVisit = Dtm,
                       Description = textBoxDescription.Text,

                       MobileDoctor = textBox_Mobile.Text,
                   };
                    DCMD1.TBL_VisitHistories.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات قبلا وارد شده و تکراری است!", ex.Message);
                    else
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditVisitHistory)
                    try
                    {
                        DataClasses_MainDataContext DCMD2 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                        TBL_VisitHistory tbhc = DCMD2.TBL_VisitHistories.First(thfh =>
                            thfh.DateVisit == _dtm &
                            thfh.NationalCode == _nationalCode &
                            thfh.MobileDoctor == _mobileDoctor
                            );
                        DCMD2.TBL_VisitHistories.DeleteOnSubmit(tbhc);

                        
                        TBL_VisitHistory tbh = new TBL_VisitHistory();
                        tbh.DateVisit = Dtm;
                        tbh.DosiersNo = textBoxDosiersNo.Text;
                        tbh.MobileDoctor = textBox_Mobile.Text;
                        tbh.Description = textBoxDescription.Text;
                        tbh.NationalCode = textBoxNationalCode.Text;
                        DCMD2.TBL_VisitHistories.InsertOnSubmit(tbh);
                        

                        DCMD2.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
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
        private void panel_BrithDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthBD.Text) > 6 && Convert.ToInt16(comboBox_DayBD.Text) == 31) comboBox_DayBD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthBD.Text) == 12 && (Convert.ToInt16(comboBox_DayBD.Text) == 31 || Convert.ToInt16(comboBox_DayBD.Text) == 30)) comboBox_DayBD.Text = "29";
        }

        #endregion

       
    }
}
