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
    public partial class ParaclinicNE_Frm : Form
    {
        int _ParaclinicID = 0; 
        bool _newOrEditParaclinic = false;

        public ParaclinicNE_Frm(bool NewOrEditParaclinic, int ParaclinicID)
        {
            InitializeComponent();
            _ParaclinicID = ParaclinicID;
            _newOrEditParaclinic = NewOrEditParaclinic;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void ParaclinicNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_ParaclinicNE();
        }

        private void SetDefault_ParaclinicNE()
        {
            if (!_newOrEditParaclinic)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_Paraclinic tbhc = DCMD.TBL_Paraclinics.First(thfr => thfr.ParaclinicId.Equals(_ParaclinicID));
                    textBox_ParaclinicName.Text = tbhc.ParaclinicName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditParaclinic)
            {
                textBox_ParaclinicName.Focus();
                this.Text = "ثبت پاراکلینیک جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_ParaclinicName.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "پاراکلینیک را وارد کنید!"); textBox_ParaclinicName.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditParaclinic)

                try
                {
                    TBL_Paraclinic THC = new TBL_Paraclinic
                    {
                        ParaclinicName = textBox_ParaclinicName.Text,
                    };
                    DCMD1.TBL_Paraclinics.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditParaclinic)
                    try
                    {
                        TBL_Paraclinic tbhc = DCMD1.TBL_Paraclinics.First(thfr => thfr.ParaclinicId.Equals(_ParaclinicID));

                        tbhc.ParaclinicName = textBox_ParaclinicName.Text;
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
