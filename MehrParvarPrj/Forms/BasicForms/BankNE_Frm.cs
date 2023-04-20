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
    public partial class BankNE_Frm : Form
    {
        int _BankID = 0; 
        bool _newOrEditBank = false;

        public BankNE_Frm(bool NewOrEditBank, int BankID)
        {
            InitializeComponent();
            _BankID = BankID;
            _newOrEditBank = NewOrEditBank;
        }



        DataClassesSecondDataContext DCMD = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void BankNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_BankNE();
        }

        private void SetDefault_BankNE()
        {
            if (!_newOrEditBank)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_Bank tbhc = DCMD.TBL_Banks.First(thfr => thfr.Id.Equals(_BankID));
                    textBox_BankDsc.Text = tbhc.TitleName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditBank)
            {
                textBox_BankDsc.Focus();
                this.Text = "ثبت بانک جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_BankDsc.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "بانک را وارد کنید!"); textBox_BankDsc.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClassesSecondDataContext DCMD1 = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditBank)

                try
                {
                    TBL_Bank THC = new TBL_Bank
                    {
                        TitleName = textBox_BankDsc.Text,
                    };
                    DCMD1.TBL_Banks.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditBank)
                    try
                    {
                        TBL_Bank tbhc = DCMD1.TBL_Banks.First(thfr => thfr.Id.Equals(_BankID));

                        tbhc.TitleName = textBox_BankDsc.Text;
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

        
        
    }
}
