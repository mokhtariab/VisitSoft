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
    public partial class MartyrsNE_frm : Form
    {
        int _MartyrsID = 0;
        bool _newOrEditMartyrs = false;

        public MartyrsNE_frm(int MartyrsID)
        {
            InitializeComponent();
            _MartyrsID = MartyrsID;
            _newOrEditMartyrs = false;
        }
        public MartyrsNE_frm()
        {
            InitializeComponent();
            _newOrEditMartyrs = true;
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void MartyrsNE_frm_Load(object sender, EventArgs e)
        {
            SetDefault_MartyrsNE();
        }

        private void SetDefault_MartyrsNE()
        {
            if (!_newOrEditMartyrs)
            {
                try
                {
                    TBL_Martyr tbhc = DCMD.TBL_Martyrs.First(thfr => thfr.MartyrId.Equals(_MartyrsID));

                    textBoxDosiersNo1.Text = tbhc.DosiersNo1;
                    textBoxDosiersNo2.Text = tbhc.DosiersNo2;
                    textBoxDosiersNo3.Text = tbhc.DosiersNo3;

                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.MartyrDate1));
                    comboBoxYearM1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBoxMonthM1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBoxDayM1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.MartyrDate2));
                    comboBoxYearM2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBoxMonthM2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBoxDayM2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                    
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.MartyrDate3));
                    comboBoxYearM3.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBoxMonthM3.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBoxDayM3.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    
                    
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate1));
                    comboBoxYearB1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBoxMonthB1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBoxDayB1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate2));
                    comboBoxYearB2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBoxMonthB2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBoxDayB2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                    
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate3));
                    comboBoxYearB3.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBoxMonthB3.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBoxDayB3.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


                    textBoxMartyrName1.Text = tbhc.MartyrName1;
                    textBoxMartyrName2.Text = tbhc.MartyrName2;
                    textBoxMartyrName3.Text = tbhc.MartyrName3;

                    textBoxNationalCode1.Text = tbhc.NationalCode1;
                    textBoxNationalCode2.Text = tbhc.NationalCode2;
                    textBoxNationalCode3.Text = tbhc.NationalCode3;

                    textBoxMartyrLocation1.Text = tbhc.MartyrLocation1;
                    textBoxMartyrLocation2.Text = tbhc.MartyrLocation2;
                    textBoxMartyrLocation3.Text = tbhc.MartyrLocation3;

                    textBoxMartyrNameFamily.Text = tbhc.MartyrNameFamily;
                    textBoxDescription.Text = tbhc.Description;
                    nUpDownMartyrFew.Value = tbhc.MartyrFew.Value;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!",ex.Message);
                }
            }

            else if (_newOrEditMartyrs)
            {

                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBoxYearM1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBoxMonthM1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBoxDayM1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBoxYearM2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBoxMonthM2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBoxDayM2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBoxYearM3.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBoxMonthM3.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBoxDayM3.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


                comboBoxYearB1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBoxMonthB1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBoxDayB1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBoxYearB2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBoxMonthB2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBoxDayB2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBoxYearB3.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBoxMonthB3.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBoxDayB3.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            }
        }

        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBoxDosiersNo1.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "شماره پرونده را وارد نمایید!"); textBoxMartyrNameFamily.Focus(); return; }
            if (textBoxMartyrNameFamily.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "خانواده شهید را وارد نمایید!"); textBoxMartyrNameFamily.Focus(); return; }
            if (textBoxMartyrName1.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام شهید را وارد نمایید!"); textBoxMartyrName1.Focus(); return; }

            if (textBoxNationalCode1.Text.Length != 0 && textBoxNationalCode1.Text.Length != 10) { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد ملی شهید 1 را به طور صحیح وارد نمایید!"); textBoxNationalCode1.Focus(); return; }
            if (textBoxNationalCode2.Text.Length != 0 && textBoxNationalCode2.Text.Length != 10) { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد ملی شهید 2 را به طور صحیح وارد نمایید!"); textBoxNationalCode2.Focus(); return; }
            if (textBoxNationalCode3.Text.Length != 0 && textBoxNationalCode3.Text.Length != 10) { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد ملی شهید 3 را به طور صحیح وارد نمایید!"); textBoxNationalCode3.Focus(); return; }


            panelBrithDate1_Leave(this, null);
            panelBrithDate2_Leave(this, null);
            panelBrithDate3_Leave(this, null);

            panelMartyrDate1_Leave(this, null);
            panelMartyrDate2_Leave(this, null);
            panelMartyrDate3_Leave(this, null);

            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید تغییرات درخواستی ثبت شوند؟"))
            {
                if (OKFunction())
                    Close();
            }
        }

        private bool OKFunction()
        {
            if (_newOrEditMartyrs)
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    TBL_Martyr THC = new TBL_Martyr()
                   {
                       MartyrNameFamily = textBoxMartyrNameFamily.Text,
                       MartyrFew = Convert.ToInt16(nUpDownMartyrFew.Value),

                       DosiersNo1 = textBoxDosiersNo1.Text,
                       DosiersNo2 = textBoxDosiersNo2.Text,
                       DosiersNo3 = textBoxDosiersNo3.Text,
                       
                       NationalCode1 = textBoxNationalCode1.Text,
                       NationalCode2 = textBoxNationalCode2.Text,
                       NationalCode3 = textBoxNationalCode3.Text,

                       BrithDate1 = Global_Cls.ShamsiDateToMiladi(comboBoxYearB1.Text, comboBoxMonthB1.Text, comboBoxDayB1.Text),
                       BrithDate2 = Global_Cls.ShamsiDateToMiladi(comboBoxYearB2.Text, comboBoxMonthB2.Text, comboBoxDayB2.Text),
                       BrithDate3 = Global_Cls.ShamsiDateToMiladi(comboBoxYearB3.Text, comboBoxMonthB3.Text, comboBoxDayB3.Text),

                       MartyrDate1 = Global_Cls.ShamsiDateToMiladi(comboBoxYearM1.Text, comboBoxMonthM1.Text, comboBoxDayM1.Text),
                       MartyrDate2 = Global_Cls.ShamsiDateToMiladi(comboBoxYearM2.Text, comboBoxMonthM2.Text, comboBoxDayM2.Text),
                       MartyrDate3 = Global_Cls.ShamsiDateToMiladi(comboBoxYearM3.Text, comboBoxMonthM3.Text, comboBoxDayM3.Text),

                       MartyrName1 = textBoxMartyrName1.Text,
                       MartyrName2 = textBoxMartyrName2.Text,
                       MartyrName3 = textBoxMartyrName3.Text,

                       MartyrLocation1 = textBoxMartyrLocation1.Text,
                       MartyrLocation2 = textBoxMartyrLocation2.Text,
                       MartyrLocation3 = textBoxMartyrLocation3.Text,

                   };
                    DCMD1.TBL_Martyrs.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();

                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات این خانواده قبلا وارد شده و تکراری است!", ex.Message);
                    else
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditMartyrs)
                    try
                    {
                        DataClasses_MainDataContext DCMD2 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                        TBL_Martyr tbhc = DCMD2.TBL_Martyrs.First(thfh => thfh.MartyrId.Equals(_MartyrsID));


                        tbhc.MartyrNameFamily = textBoxMartyrNameFamily.Text;
                        tbhc.MartyrFew = Convert.ToInt16(nUpDownMartyrFew.Value);

                        tbhc.DosiersNo1 = textBoxDosiersNo1.Text;
                        tbhc.DosiersNo2 = textBoxDosiersNo2.Text;
                        tbhc.DosiersNo3 = textBoxDosiersNo3.Text;

                        tbhc.NationalCode1 = textBoxNationalCode1.Text;
                        tbhc.NationalCode2 = textBoxNationalCode2.Text;
                        tbhc.NationalCode3 = textBoxNationalCode3.Text;

                        tbhc.BrithDate1 = Global_Cls.ShamsiDateToMiladi(comboBoxYearB1.Text, comboBoxMonthB1.Text, comboBoxDayB1.Text);
                        tbhc.BrithDate2 = Global_Cls.ShamsiDateToMiladi(comboBoxYearB2.Text, comboBoxMonthB2.Text, comboBoxDayB2.Text);
                        tbhc.BrithDate3 = Global_Cls.ShamsiDateToMiladi(comboBoxYearB3.Text, comboBoxMonthB3.Text, comboBoxDayB3.Text);

                        tbhc.MartyrDate1 = Global_Cls.ShamsiDateToMiladi(comboBoxYearM1.Text, comboBoxMonthM1.Text, comboBoxDayM1.Text);
                        tbhc.MartyrDate2 = Global_Cls.ShamsiDateToMiladi(comboBoxYearM2.Text, comboBoxMonthM2.Text, comboBoxDayM2.Text);
                        tbhc.MartyrDate3 = Global_Cls.ShamsiDateToMiladi(comboBoxYearM3.Text, comboBoxMonthM3.Text, comboBoxDayM3.Text);

                        tbhc.MartyrName1 = textBoxMartyrName1.Text;
                        tbhc.MartyrName2 = textBoxMartyrName2.Text;
                        tbhc.MartyrName3 = textBoxMartyrName3.Text;

                        tbhc.MartyrLocation1 = textBoxMartyrLocation1.Text;
                        tbhc.MartyrLocation2 = textBoxMartyrLocation2.Text;
                        tbhc.MartyrLocation3 = textBoxMartyrLocation3.Text;

                        DCMD2.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات این خانواده قبلا وارد شده و تکراری است!", ex.Message);
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


        private void panelBrithDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthB1.Text) > 6 && Convert.ToInt16(comboBoxDayB1.Text) == 31) comboBoxDayB1.Text = "30";
            if (Convert.ToInt16(comboBoxMonthB1.Text) == 12 && (Convert.ToInt16(comboBoxDayB1.Text) == 31 || Convert.ToInt16(comboBoxDayB1.Text) == 30)) comboBoxDayB1.Text = "29";
        }

        private void panelBrithDate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthB2.Text) > 6 && Convert.ToInt16(comboBoxDayB2.Text) == 31) comboBoxDayB2.Text = "30";
            if (Convert.ToInt16(comboBoxMonthB2.Text) == 12 && (Convert.ToInt16(comboBoxDayB2.Text) == 31 || Convert.ToInt16(comboBoxDayB2.Text) == 30)) comboBoxDayB2.Text = "29";
        }

        private void panelBrithDate3_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthB3.Text) > 6 && Convert.ToInt16(comboBoxDayB3.Text) == 31) comboBoxDayB3.Text = "30";
            if (Convert.ToInt16(comboBoxMonthB3.Text) == 12 && (Convert.ToInt16(comboBoxDayB3.Text) == 31 || Convert.ToInt16(comboBoxDayB3.Text) == 30)) comboBoxDayB3.Text = "29";
        }



        private void panelMartyrDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthM1.Text) > 6 && Convert.ToInt16(comboBoxDayM1.Text) == 31) comboBoxDayM1.Text = "30";
            if (Convert.ToInt16(comboBoxMonthM1.Text) == 12 && (Convert.ToInt16(comboBoxDayM1.Text) == 31 || Convert.ToInt16(comboBoxDayM1.Text) == 30)) comboBoxDayM1.Text = "29";
        }

        private void panelMartyrDate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthM2.Text) > 6 && Convert.ToInt16(comboBoxDayM2.Text) == 31) comboBoxDayM2.Text = "30";
            if (Convert.ToInt16(comboBoxMonthM2.Text) == 12 && (Convert.ToInt16(comboBoxDayM2.Text) == 31 || Convert.ToInt16(comboBoxDayM2.Text) == 30)) comboBoxDayM2.Text = "29";
        }

        private void panelMartyrDate3_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthM3.Text) > 6 && Convert.ToInt16(comboBoxDayM3.Text) == 31) comboBoxDayM3.Text = "30";
            if (Convert.ToInt16(comboBoxMonthM3.Text) == 12 && (Convert.ToInt16(comboBoxDayM3.Text) == 31 || Convert.ToInt16(comboBoxDayM3.Text) == 30)) comboBoxDayM3.Text = "29";
        }

        #endregion

        

       
    }
}
