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
    public partial class DoctorsContractNE_frm : Form
    {
        bool _newOrEditDoctorsContract = false;
        private int _id = 0, _doctor_Id = 0;
        
        public DoctorsContractNE_frm(bool NewOrEditDoctorsContract, int Doctor_Id, int Id = 0)
        {
            InitializeComponent();
            _doctor_Id = Doctor_Id;
            _id = Id;
            _newOrEditDoctorsContract = NewOrEditDoctorsContract;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void DoctorsContractNE_frm_Load(object sender, EventArgs e)
        {
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBoxYearBD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBoxMonthBD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBoxDayBD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            comboBoxYearED.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBoxMonthED.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBoxDayED.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                    

            SetDefault_DoctorsContractNE();
        }

        private void SetDefault_DoctorsContractNE()
        {
            if (!_newOrEditDoctorsContract)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_DoctorsContract tbhc = DCMD.TBL_DoctorsContracts.First(thfr => thfr.Id == _id);
                    TextBoxContractNo.Text = tbhc.ContractNo;

                    string DateStr = tbhc.ContractDate;
                    comboBoxYearBD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBoxMonthBD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBoxDayBD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    DateStr = tbhc.ContractEndDate;
                    comboBoxYearED.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBoxMonthED.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBoxDayED.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditDoctorsContract)
            {
                TextBoxContractNo.Focus();
                this.Text = "ثبت قراداد جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (TextBoxContractNo.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "شماره قرارداد را وارد کنید!"); TextBoxContractNo.Focus(); return; }

            panelContractDate_Leave(this, null);
            panelContractEndDate_Leave(this, null);

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditDoctorsContract)

                try
                {
                    bool SetActive = true;
                    if (Global_Cls.ShamsiDateToMiladi(comboBoxYearED.Text,comboBoxMonthED.Text,comboBoxDayED.Text) < DateTime.Now)
                        SetActive = false;

                    TBL_DoctorsContract THC = new TBL_DoctorsContract
                    {
                        Doctor_Id = _doctor_Id,
                        ContractNo = TextBoxContractNo.Text,
                        ContractDate = comboBoxYearBD.Text + "/" + (comboBoxMonthBD.Text.Length == 1 ? ("0" + comboBoxMonthBD.Text) : comboBoxMonthBD.Text) + "/" + (comboBoxDayBD.Text.Length == 1 ? ("0" + comboBoxDayBD.Text) : comboBoxDayBD.Text),
                        ContractEndDate = comboBoxYearED.Text + "/" + (comboBoxMonthED.Text.Length == 1 ? ("0" + comboBoxMonthED.Text) : comboBoxMonthED.Text) + "/" + (comboBoxDayED.Text.Length == 1 ? ("0" + comboBoxDayED.Text) : comboBoxDayED.Text),
                        Active = SetActive
                    };
                    DCMD1.TBL_DoctorsContracts.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditDoctorsContract)
                    try
                    {
                        TBL_DoctorsContract tbhc = DCMD1.TBL_DoctorsContracts.First(thfr => thfr.Id.Equals(_id));

                        tbhc.ContractNo = TextBoxContractNo.Text;
                        tbhc.ContractDate = comboBoxYearBD.Text + "/" + (comboBoxMonthBD.Text.Length == 1 ? ("0" + comboBoxMonthBD.Text) : comboBoxMonthBD.Text) + "/" + (comboBoxDayBD.Text.Length == 1 ? ("0" + comboBoxDayBD.Text) : comboBoxDayBD.Text);
                        tbhc.ContractEndDate = comboBoxYearED.Text + "/" + (comboBoxMonthED.Text.Length == 1 ? ("0" + comboBoxMonthED.Text) : comboBoxMonthED.Text) + "/" + (comboBoxDayED.Text.Length == 1 ? ("0" + comboBoxDayED.Text) : comboBoxDayED.Text);
                        tbhc.Active = true;
                        DCMD1.SubmitChanges();
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


        private void panelContractDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthBD.Text) > 6 && Convert.ToInt16(comboBoxDayBD.Text) == 31) comboBoxDayBD.Text = "30";
            if (Convert.ToInt16(comboBoxMonthBD.Text) == 12 && (Convert.ToInt16(comboBoxDayBD.Text) == 31 || Convert.ToInt16(comboBoxDayBD.Text) == 30)) comboBoxDayBD.Text = "29";
        }

        private void panelContractEndDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthED.Text) > 6 && Convert.ToInt16(comboBoxDayED.Text) == 31) comboBoxDayED.Text = "30";
            if (Convert.ToInt16(comboBoxMonthED.Text) == 12 && (Convert.ToInt16(comboBoxDayED.Text) == 31 || Convert.ToInt16(comboBoxDayED.Text) == 30)) comboBoxDayED.Text = "29";
        }
       
    }
}
