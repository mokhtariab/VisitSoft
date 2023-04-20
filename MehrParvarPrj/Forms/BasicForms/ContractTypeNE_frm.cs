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
    public partial class ContractTypeNE_frm : Form
    {
        int _ContractTypeID = 0; 
        bool _newOrEditContractType = false;

        public ContractTypeNE_frm(bool NewOrEditContractType, int ContractTypeID)
        {
            InitializeComponent();
            _ContractTypeID = ContractTypeID;
            _newOrEditContractType = NewOrEditContractType;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void ContractTypeNE_frm_Load(object sender, EventArgs e)
        {
            SetDefault_ContractTypeNE();
        }

        private void SetDefault_ContractTypeNE()
        {
            if (!_newOrEditContractType)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_ContractType tbhc = DCMD.TBL_ContractTypes.First(thfr => thfr.ContractTypeId.Equals(_ContractTypeID));
                    textBox_ContractTypeDsc.Text = tbhc.ContractTypeDsc;
                    textBox_ContractTypePrice.Text = Global_Cls.DigitSeparator(tbhc.ContractTypePrice.Value.ToString());
                    textBox_InsurancePrice.Text = Global_Cls.DigitSeparator(tbhc.InsurancePrice.Value.ToString());
                    textBox_BothVisitPrice.Text = Global_Cls.DigitSeparator(tbhc.BothVisitPrice.Value.ToString());
                    textBox_VisitForcePrice.Text = Global_Cls.DigitSeparator(tbhc.VisitForcePrice.Value.ToString());
                    textBox_TaxPrice.Text = Global_Cls.DigitSeparator(tbhc.TaxPrice.Value.ToString());
                    textBox_OtherDecrement.Text = Global_Cls.DigitSeparator(tbhc.OtherDecrement.Value.ToString());
                    textBox_OtherIncrement.Text = Global_Cls.DigitSeparator(tbhc.OtherIncrement.Value.ToString());
                    
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditContractType)
            {
                textBox_ContractTypeDsc.Focus();
                this.Text = "ثبت نوع قراداد جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_ContractTypeDsc.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نوع قرارداد را وارد کنید!"); textBox_ContractTypeDsc.Focus(); return; }
            if (textBox_ContractTypePrice.Text == "0")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "مبلغ نوع قرارداد را وارد کنید!"); textBox_ContractTypePrice.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditContractType)

                try
                {
                    TBL_ContractType THC = new TBL_ContractType
                    {
                        ContractTypeDsc = textBox_ContractTypeDsc.Text,
                        ContractTypePrice = long.Parse(textBox_ContractTypePrice.Text == "" ? "0" : textBox_ContractTypePrice.Text.Replace(",", "")),
                        VisitForcePrice = long.Parse(textBox_VisitForcePrice.Text == "" ? "0" : textBox_VisitForcePrice.Text.Replace(",", "")),
                        BothVisitPrice = long.Parse(textBox_BothVisitPrice.Text == "" ? "0" : textBox_BothVisitPrice.Text.Replace(",", "")),
                        InsurancePrice = long.Parse(textBox_InsurancePrice.Text == "" ? "0" : textBox_InsurancePrice.Text.Replace(",", "")),
                        TaxPrice = long.Parse(textBox_TaxPrice.Text == "" ? "0" : textBox_TaxPrice.Text.Replace(",", "")),
                        OtherIncrement = long.Parse(textBox_OtherIncrement.Text == "" ? "0" : textBox_OtherIncrement.Text.Replace(",", "")),
                        OtherDecrement = long.Parse(textBox_OtherDecrement.Text == "" ? "0" : textBox_OtherDecrement.Text.Replace(",", "")),
                        Active = true
                    };
                    DCMD1.TBL_ContractTypes.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditContractType)
                    try
                    {
                        TBL_ContractType tbhc = DCMD1.TBL_ContractTypes.First(thfr => thfr.ContractTypeId.Equals(_ContractTypeID));

                        tbhc.ContractTypeDsc = textBox_ContractTypeDsc.Text;
                        tbhc.ContractTypePrice = long.Parse(textBox_ContractTypePrice.Text == "" ? "0" : textBox_ContractTypePrice.Text.Replace(",", ""));
                        tbhc.VisitForcePrice = long.Parse(textBox_VisitForcePrice.Text == "" ? "0" : textBox_VisitForcePrice.Text.Replace(",", ""));
                        tbhc.BothVisitPrice = long.Parse(textBox_BothVisitPrice.Text == "" ? "0" : textBox_BothVisitPrice.Text.Replace(",", ""));
                        tbhc.InsurancePrice = long.Parse(textBox_InsurancePrice.Text == "" ? "0" : textBox_InsurancePrice.Text.Replace(",", ""));
                        tbhc.TaxPrice = long.Parse(textBox_TaxPrice.Text == "" ? "0" : textBox_TaxPrice.Text.Replace(",", ""));
                        tbhc.OtherIncrement = long.Parse(textBox_OtherIncrement.Text == "" ? "0" : textBox_OtherIncrement.Text.Replace(",", ""));
                        tbhc.OtherDecrement = long.Parse(textBox_OtherDecrement.Text == "" ? "0" : textBox_OtherDecrement.Text.Replace(",", ""));
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

        #endregion

    }
}
