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
    public partial class DoctorTypeNE_Frm : Form
    {
        int _DoctorTypeID = 0; 
        bool _newOrEditDoctorType = false;

        public DoctorTypeNE_Frm(bool NewOrEditDoctorType, int DoctorTypeID)
        {
            InitializeComponent();
            _DoctorTypeID = DoctorTypeID;
            _newOrEditDoctorType = NewOrEditDoctorType;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void DoctorTypeNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_DoctorTypeNE();
        }

        private void SetDefault_DoctorTypeNE()
        {
            if (!_newOrEditDoctorType)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_DoctorType tbhc = DCMD.TBL_DoctorTypes.First(thfr => thfr.DoctorTypeId.Equals(_DoctorTypeID));
                    textBox_DoctorTypeDsc.Text = tbhc.DoctorTypeDsc;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditDoctorType)
            {
                textBox_DoctorTypeDsc.Focus();
                this.Text = "ثبت نوع پزشک جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_DoctorTypeDsc.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نوع پزشک را وارد کنید!"); textBox_DoctorTypeDsc.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditDoctorType)

                try
                {
                    TBL_DoctorType THC = new TBL_DoctorType
                    {
                        DoctorTypeDsc = textBox_DoctorTypeDsc.Text,
                    };
                    DCMD1.TBL_DoctorTypes.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditDoctorType)
                    try
                    {
                        TBL_DoctorType tbhc = DCMD1.TBL_DoctorTypes.First(thfr => thfr.DoctorTypeId.Equals(_DoctorTypeID));

                        tbhc.DoctorTypeDsc = textBox_DoctorTypeDsc.Text;
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
