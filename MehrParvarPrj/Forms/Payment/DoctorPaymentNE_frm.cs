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
    public partial class DoctorPaymentNE_frm : Form
    {
        int _id = 0;
        bool _newOrEditDoctorPayment = false;

        public DoctorPaymentNE_frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _newOrEditDoctorPayment = false;
        }
        public DoctorPaymentNE_frm()
        {
            InitializeComponent();
            _newOrEditDoctorPayment = true;
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DCSSS = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void DoctorPaymentNE_frm_Load(object sender, EventArgs e)
        {
            SetDefault_DoctorPaymentNE();
        }

        private void SetDefault_DoctorPaymentNE()
        {
            if (!_newOrEditDoctorPayment)
            {
                FillComponents(_id);
            }

            else if (_newOrEditDoctorPayment)
            {
                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_Year.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_Month.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_Day.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBoxYear.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBoxMonth.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBoxDay.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
            }
        }

        private void FillComponents(int Id)
        {
            try
            {
                TBL_DoctorPayment tbhc = DCSSS.TBL_DoctorPayments.First(thfr => thfr.Id == Id);

                textBoxDoctorName.Tag = tbhc.DoctorID;
                textBoxDoctorName.Text = DCMD.TBL_Doctors.First(thfr => thfr.DoctorID == tbhc.DoctorID).DoctorName + " " + DCMD.TBL_Doctors.First(thfr => thfr.DoctorID == tbhc.DoctorID).DoctorFamily;
                textBoxAccountingDocumentNumber.Text = tbhc.AccountingDocumentNumber.ToString();

                string DateStr = tbhc.VisitCreateDate;
                comboBox_Year.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_Month.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_Day.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                string DateStr2 = tbhc.PaymentDoctorDate;
                comboBoxYear.Text = Convert.ToInt16(DateStr2.Substring(0, 4)).ToString();
                comboBoxMonth.Text = Convert.ToInt16(DateStr2.Substring(5, 2)).ToString();
                comboBoxDay.Text = Convert.ToInt16(DateStr2.Substring(8, 2)).ToString();

                comboBoxPaymentType.Text = tbhc.PaymentType;

                textBoxCostVisitDoctorBes.Text = tbhc.CostVisitDoctorBes.Value.ToString().Replace("-","");
                textBoxDescription.Text = tbhc.Description;
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
            if (textBoxDoctorName.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام نام خانوادگی پزشک را وارد نمایید!"); textBoxDoctorName.Focus(); return; }

            panel_CDate1_Leave(this, null);
            panelPaymentDoctorDate_Leave(this, null);

            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید عملیات ثبت انجام شود؟"))
            {
                if (OKFunction())
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
            }
        }

        private bool OKFunction()
        {
            if (_newOrEditDoctorPayment)
                try
                {
                    DCSSS.SP_InsertVisitDoctorPayment(
                        int.Parse(textBoxDoctorName.Tag.ToString()),
                        0,
                        0,
                        comboBox_Year.Text + "/" + (comboBox_Month.Text.Length == 1 ? "0" + comboBox_Month.Text : comboBox_Month.Text) + "/" + (comboBox_Day.Text.Length == 1 ? "0" + comboBox_Day.Text : comboBox_Day.Text),
                        comboBoxPaymentType.Text,
                        "پرداخت/کسر شده",
                        comboBox_Year.Text + "/" + (comboBox_Month.Text.Length == 1 ? "0" + comboBox_Month.Text : comboBox_Month.Text) + "/" + (comboBox_Day.Text.Length == 1 ? "0" + comboBox_Day.Text : comboBox_Day.Text),
                        "",
                        "",
                        0,
                        0,
                        "",
                        "",
                        "",
                        "",
                        textBoxAccountingDocumentNumber.Text,
                        0,
                        0,
                        "",
                        0,
                        0,
                        comboBoxPaymentType.SelectedIndex == 1 ? -Convert.ToInt32(textBoxCostVisitDoctorBes.Text.Replace(",", "")) : Convert.ToInt32(textBoxCostVisitDoctorBes.Text.Replace(",", "")),
                        0,
                        comboBoxYear.Text + "/" + (comboBoxMonth.Text.Length == 1 ? "0" + comboBoxMonth.Text : comboBoxMonth.Text) + "/" + (comboBoxDay.Text.Length == 1 ? "0" + comboBoxDay.Text : comboBoxDay.Text),
                        textBoxDescription.Text
                       );


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
                if (!_newOrEditDoctorPayment)
                    try
                    {
                        TBL_DoctorPayment tbhc = DCSSS.TBL_DoctorPayments.First(thfh => thfh.Id == _id);

                        tbhc.DoctorID = int.Parse(textBoxDoctorName.Tag.ToString());
                        tbhc.PaymentStatusDate = comboBox_Year.Text + "/" + (comboBox_Month.Text.Length == 1 ? "0" + comboBox_Month.Text : comboBox_Month.Text) + "/" + (comboBox_Day.Text.Length == 1 ? "0" + comboBox_Day.Text : comboBox_Day.Text);
                        tbhc.VisitCreateDate = comboBox_Year.Text + "/" + (comboBox_Month.Text.Length == 1 ? "0" + comboBox_Month.Text : comboBox_Month.Text) + "/" + (comboBox_Day.Text.Length == 1 ? "0" + comboBox_Day.Text : comboBox_Day.Text);
                        tbhc.PaymentType = comboBoxPaymentType.Text;

                        tbhc.AccountingDocumentNumber = textBoxAccountingDocumentNumber.Text;
                        tbhc.CostVisitDoctorBes = comboBoxPaymentType.SelectedIndex == 1 ? -Convert.ToInt32(textBoxCostVisitDoctorBes.Text.Replace(",", "")) : Convert.ToInt32(textBoxCostVisitDoctorBes.Text.Replace(",", ""));
                        tbhc.PaymentDoctorDate = comboBoxYear.Text + "/" + (comboBoxMonth.Text.Length == 1 ? "0" + comboBoxMonth.Text : comboBoxMonth.Text) + "/" + (comboBoxDay.Text.Length == 1 ? "0" + comboBoxDay.Text : comboBoxDay.Text);
                        tbhc.Description = textBoxDescription.Text;

                        DCSSS.SubmitChanges();
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
            if (Convert.ToInt16(comboBox_Month.Text) > 6 && Convert.ToInt16(comboBox_Day.Text) == 31) comboBox_Day.Text = "30";
            if (Convert.ToInt16(comboBox_Month.Text) == 12 && (Convert.ToInt16(comboBox_Day.Text) == 31 || Convert.ToInt16(comboBox_Day.Text) == 30)) comboBox_Day.Text = "29";
        }

        private void panelPaymentDoctorDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonth.Text) > 6 && Convert.ToInt16(comboBoxDay.Text) == 31) comboBoxDay.Text = "30";
            if (Convert.ToInt16(comboBoxMonth.Text) == 12 && (Convert.ToInt16(comboBoxDay.Text) == 31 || Convert.ToInt16(comboBoxDay.Text) == 30)) comboBoxDay.Text = "29";
        }

        #endregion

        private void buttonPatientID_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(-1);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxDoctorName.Tag = sp.CodeC;
                textBoxDoctorName.Text = sp.NameC;
            }
        }


       
    }
}
