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
    public partial class StateSicknessNE_Frm : Form
    {
        int _StateSicknessID = 0; 
        bool _newOrEditStateSickness = false;

        public StateSicknessNE_Frm(bool NewOrEditStateSickness, int StateSicknessID)
        {
            InitializeComponent();
            _StateSicknessID = StateSicknessID;
            _newOrEditStateSickness = NewOrEditStateSickness;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void StateSicknessNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_StateSicknessNE();
        }

        private void SetDefault_StateSicknessNE()
        {
            if (!_newOrEditStateSickness)
            {
                try
                {
                    this.Text = "ویرایش";
                    VW_StateSickness tbhc = DCMD.VW_StateSicknesses.First(thfr => thfr.StateSicknessId.Equals(_StateSicknessID));
                    textBox_StateSicknessMasterName.Text = tbhc.StateSicknessMasterName;
                    textBox_StateSicknessMasterName.Tag = tbhc.StateSicknessMaster_Id;
                    textBox_StateSicknessName.Text = tbhc.StateSicknessName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditStateSickness)
            {
                textBox_StateSicknessName.Focus();
                this.Text = "ثبت وضعیت بیماری جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_StateSicknessMasterName.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "عنوان کلی بیماری را وارد کنید!"); textBox_StateSicknessName.Focus(); return; }

            if (textBox_StateSicknessName.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "وضعیت بیماری را وارد کنید!"); textBox_StateSicknessName.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditStateSickness)

                try
                {
                    TBL_StateSickness THC = new TBL_StateSickness
                    {
                        StateSicknessName = textBox_StateSicknessName.Text,
                        StateSicknessMaster_Id = int.Parse(textBox_StateSicknessMasterName.Tag.ToString()),
                    };
                    DCMD1.TBL_StateSicknesses.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditStateSickness)
                    try
                    {
                        TBL_StateSickness tbhc = DCMD1.TBL_StateSicknesses.First(thfr => thfr.StateSicknessId.Equals(_StateSicknessID));

                        tbhc.StateSicknessName = textBox_StateSicknessName.Text;
                        tbhc.StateSicknessMaster_Id = int.Parse(textBox_StateSicknessMasterName.Tag.ToString());
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

        private void ButtonStateSicknessMaster_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(0);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBox_StateSicknessMasterName.Tag = sp.CodeC;
                textBox_StateSicknessMasterName.Text = sp.NameC;
            }
        }

        
        
    }
}
