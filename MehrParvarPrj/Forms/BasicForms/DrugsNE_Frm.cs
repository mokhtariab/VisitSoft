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
    public partial class DrugsNE_Frm : Form
    {
        int _DrugsID = 0; 
        bool _newOrEditDrugs = false;

        public DrugsNE_Frm(bool NewOrEditDrugs, int DrugsID)
        {
            InitializeComponent();
            _DrugsID = DrugsID;
            _newOrEditDrugs = NewOrEditDrugs;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void DrugsNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_DrugsNE();
        }

        private void SetDefault_DrugsNE()
        {
            if (!_newOrEditDrugs)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_Drug tbhc = DCMD.TBL_Drugs.First(thfr => thfr.DrugsId.Equals(_DrugsID));
                    textBox_DrugsName.Text = tbhc.DrugsName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditDrugs)
            {
                textBox_DrugsName.Focus();
                this.Text = "ثبت داروی جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_DrugsName.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام دارو را وارد کنید!"); textBox_DrugsName.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditDrugs)

                try
                {
                    TBL_Drug THC = new TBL_Drug
                    {
                        DrugsName = textBox_DrugsName.Text,
                    };
                    DCMD1.TBL_Drugs.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditDrugs)
                    try
                    {
                        TBL_Drug tbhc = DCMD1.TBL_Drugs.First(thfr => thfr.DrugsId.Equals(_DrugsID));

                        tbhc.DrugsName = textBox_DrugsName.Text;
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
