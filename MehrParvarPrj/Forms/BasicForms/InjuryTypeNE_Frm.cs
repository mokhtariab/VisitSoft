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
    public partial class InjuryTypeNE_Frm : Form
    {
        int _InjuryTypeID = 0; 
        bool _newOrEditInjuryType = false;

        public InjuryTypeNE_Frm(bool NewOrEditInjuryType, int InjuryTypeID)
        {
            InitializeComponent();
            _InjuryTypeID = InjuryTypeID;
            _newOrEditInjuryType = NewOrEditInjuryType;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void InjuryTypeNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_InjuryTypeNE();
        }

        private void SetDefault_InjuryTypeNE()
        {
            if (!_newOrEditInjuryType)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_InjuryType tbhc = DCMD.TBL_InjuryTypes.First(thfr => thfr.InjuryTypeId.Equals(_InjuryTypeID));
                    textBox_InjuryTypeDsc.Text = tbhc.InjuryTypeDsc;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditInjuryType)
            {
                textBox_InjuryTypeDsc.Focus();
                this.Text = "ثبت نوع مجروحیت جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_InjuryTypeDsc.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نوع مجروحیت را وارد کنید!"); textBox_InjuryTypeDsc.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditInjuryType)

                try
                {
                    TBL_InjuryType THC = new TBL_InjuryType
                    {
                        InjuryTypeDsc = textBox_InjuryTypeDsc.Text,
                    };
                    DCMD1.TBL_InjuryTypes.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditInjuryType)
                    try
                    {
                        TBL_InjuryType tbhc = DCMD1.TBL_InjuryTypes.First(thfr => thfr.InjuryTypeId.Equals(_InjuryTypeID));

                        tbhc.InjuryTypeDsc = textBox_InjuryTypeDsc.Text;
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
