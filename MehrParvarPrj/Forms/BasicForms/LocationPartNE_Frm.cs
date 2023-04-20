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
    public partial class LocationPartNE_Frm : Form
    {
        int _LocationPartID = 0; 
        bool _newOrEditLocationPart = false;

        public LocationPartNE_Frm(bool NewOrEditLocationPart, int LocationPartID)
        {
            InitializeComponent();
            _LocationPartID = LocationPartID;
            _newOrEditLocationPart = NewOrEditLocationPart;
        }



        DataClassesSecondDataContext DCMD = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void LocationPartNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_LocationPartNE();
        }

        private void SetDefault_LocationPartNE()
        {
            if (!_newOrEditLocationPart)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_LocationPart tbhc = DCMD.TBL_LocationParts.First(thfr => thfr.Id.Equals(_LocationPartID));
                    textBox_LocationPartDsc.Text = tbhc.TitleName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditLocationPart)
            {
                textBox_LocationPartDsc.Focus();
                this.Text = "ثبت منطقه جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_LocationPartDsc.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "منطقه را وارد کنید!"); textBox_LocationPartDsc.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClassesSecondDataContext DCMD1 = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditLocationPart)

                try
                {
                    TBL_LocationPart THC = new TBL_LocationPart
                    {
                        TitleName = textBox_LocationPartDsc.Text,
                    };
                    DCMD1.TBL_LocationParts.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditLocationPart)
                    try
                    {
                        TBL_LocationPart tbhc = DCMD1.TBL_LocationParts.First(thfr => thfr.Id.Equals(_LocationPartID));

                        tbhc.TitleName = textBox_LocationPartDsc.Text;
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
