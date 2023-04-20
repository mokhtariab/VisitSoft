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
    public partial class VaccinationNE_Frm : Form
    {
        int _VaccinationID = 0; 
        bool _newOrEditVaccination = false;

        public VaccinationNE_Frm(bool NewOrEditVaccination, int VaccinationID)
        {
            InitializeComponent();
            _VaccinationID = VaccinationID;
            _newOrEditVaccination = NewOrEditVaccination;
        }



        DataClassesSecondDataContext DCMD = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void VaccinationNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_VaccinationNE();
        }

        private void SetDefault_VaccinationNE()
        {
            if (!_newOrEditVaccination)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_Vaccination tbhc = DCMD.TBL_Vaccinations.First(thfr => thfr.Id.Equals(_VaccinationID));
                    textBox_VaccinationDsc.Text = tbhc.TitleName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditVaccination)
            {
                textBox_VaccinationDsc.Focus();
                this.Text = "ثبت واکسیناسیون جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_VaccinationDsc.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "واکسیناسیون را وارد کنید!"); textBox_VaccinationDsc.Focus(); return; }

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClassesSecondDataContext DCMD1 = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditVaccination)

                try
                {
                    TBL_Vaccination THC = new TBL_Vaccination
                    {
                        TitleName = textBox_VaccinationDsc.Text,
                    };
                    DCMD1.TBL_Vaccinations.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditVaccination)
                    try
                    {
                        TBL_Vaccination tbhc = DCMD1.TBL_Vaccinations.First(thfr => thfr.Id.Equals(_VaccinationID));

                        tbhc.TitleName = textBox_VaccinationDsc.Text;
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
