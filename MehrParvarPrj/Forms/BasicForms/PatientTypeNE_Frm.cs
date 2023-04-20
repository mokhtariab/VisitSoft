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
    public partial class PatientTypeNE_Frm : Form
    {
        int _PatientTypeID = 0; 
        bool _newOrEditPatientType = false;

        public PatientTypeNE_Frm(bool NewOrEditPatientType, int PatientTypeID)
        {
            InitializeComponent();
            _PatientTypeID = PatientTypeID;
            _newOrEditPatientType = NewOrEditPatientType;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void PatientTypeNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_PatientTypeNE();
        }

        private void SetDefault_PatientTypeNE()
        {
            if (!_newOrEditPatientType)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_PatientType tbhc = DCMD.TBL_PatientTypes.First(thfr => thfr.PatientTypeId.Equals(_PatientTypeID));
                    textBox_PatientTypeDsc.Text = tbhc.PatientTypeDsc;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditPatientType)
            {
                textBox_PatientTypeDsc.Focus();
                this.Text = "ثبت نسبت جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_PatientTypeDsc.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نسبت را وارد کنید!"); textBox_PatientTypeDsc.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditPatientType)

                try
                {
                    TBL_PatientType THC = new TBL_PatientType
                    {
                        PatientTypeDsc = textBox_PatientTypeDsc.Text,
                    };
                    DCMD1.TBL_PatientTypes.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditPatientType)
                    try
                    {
                        TBL_PatientType tbhc = DCMD1.TBL_PatientTypes.First(thfr => thfr.PatientTypeId.Equals(_PatientTypeID));

                        tbhc.PatientTypeDsc = textBox_PatientTypeDsc.Text;
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
