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
    public partial class EquipmentUseNE_Frm : Form
    {
        int _EquipmentUseID = 0; 
        bool _newOrEditEquipmentUse = false;

        public EquipmentUseNE_Frm(bool NewOrEditEquipmentUse, int EquipmentUseID)
        {
            InitializeComponent();
            _EquipmentUseID = EquipmentUseID;
            _newOrEditEquipmentUse = NewOrEditEquipmentUse;
        }



        DataClassesSecondDataContext DCMD = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void EquipmentUseNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_EquipmentUseNE();
        }

        private void SetDefault_EquipmentUseNE()
        {
            if (!_newOrEditEquipmentUse)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_EquipmentUse tbhc = DCMD.TBL_EquipmentUses.First(thfr => thfr.Id.Equals(_EquipmentUseID));
                    textBox_EquipmentUseDsc.Text = tbhc.TitleName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditEquipmentUse)
            {
                textBox_EquipmentUseDsc.Focus();
                this.Text = "ثبت تجهیزات مصرفی جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_EquipmentUseDsc.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "تجهیزات مصرفی را وارد کنید!"); textBox_EquipmentUseDsc.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClassesSecondDataContext DCMD1 = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditEquipmentUse)

                try
                {
                    TBL_EquipmentUse THC = new TBL_EquipmentUse
                    {
                        TitleName = textBox_EquipmentUseDsc.Text,
                    };
                    DCMD1.TBL_EquipmentUses.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditEquipmentUse)
                    try
                    {
                        TBL_EquipmentUse tbhc = DCMD1.TBL_EquipmentUses.First(thfr => thfr.Id.Equals(_EquipmentUseID));

                        tbhc.TitleName = textBox_EquipmentUseDsc.Text;
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
