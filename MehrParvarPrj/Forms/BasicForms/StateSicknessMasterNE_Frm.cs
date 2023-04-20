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
    public partial class StateSicknessMasterNE_Frm : Form
    {
        int _StateSicknessMasterID = 0; 
        bool _newOrEditStateSicknessMaster = false;

        public StateSicknessMasterNE_Frm(bool NewOrEditStateSicknessMaster, int StateSicknessMasterID)
        {
            InitializeComponent();
            _StateSicknessMasterID = StateSicknessMasterID;
            _newOrEditStateSicknessMaster = NewOrEditStateSicknessMaster;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void StateSicknessMasterNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_StateSicknessMasterNE();
        }

        private void SetDefault_StateSicknessMasterNE()
        {
            if (!_newOrEditStateSicknessMaster)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_StateSicknessMaster tbhc = DCMD.TBL_StateSicknessMasters.First(thfr => thfr.Id.Equals(_StateSicknessMasterID));
                    textBox_StateSicknessMasterName.Text = tbhc.StateSicknessMasterName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditStateSicknessMaster)
            {
                textBox_StateSicknessMasterName.Focus();
                this.Text = "ثبت وضعیت بیماری جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_StateSicknessMasterName.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "وضعیت بیماری را وارد کنید!"); textBox_StateSicknessMasterName.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditStateSicknessMaster)

                try
                {
                    TBL_StateSicknessMaster THC = new TBL_StateSicknessMaster
                    {
                        StateSicknessMasterName = textBox_StateSicknessMasterName.Text,
                    };
                    DCMD1.TBL_StateSicknessMasters.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditStateSicknessMaster)
                    try
                    {
                        TBL_StateSicknessMaster tbhc = DCMD1.TBL_StateSicknessMasters.First(thfr => thfr.Id.Equals(_StateSicknessMasterID));

                        tbhc.StateSicknessMasterName = textBox_StateSicknessMasterName.Text;
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
