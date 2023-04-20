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
    public partial class SelectPerson_frm: Form
    {

        int _type = 0, _code = 0;
        bool _free = false;
        public SelectPerson_frm(int Type)
        {
            InitializeComponent();
            _type = Type;
        }
        
        public SelectPerson_frm(int Type, int Code)
        {
            InitializeComponent();
            _type = Type;
            _code = Code;
        }

        public SelectPerson_frm(int Type, bool Free)
        {
            InitializeComponent();
            _type = Type;
            _free = Free;
        }

        public void DataBind()
        {
            var SU = from prd in DCDC.TBL_Patients
                     //where prd.Active == true 
                     select new
                     {
                         Code = prd.PatientID,
                         Name = prd.PatientName + " " + prd.PatientFamily,
                         Other = prd.DosiersNo
                     };
            dataGridView_SelectPerson.Columns["Other"].HeaderText = "شماره پرونده";
            if (_code != 0)
            {
                SU = from prd in DCDC.TBL_Patients
                     where prd.PatientID == _code
                     select new
                     {
                         Code = prd.PatientID,
                         Name = prd.PatientName + " " + prd.PatientFamily,
                         Other = prd.Mobile
                     };

            }
           
            
            if (_type == 1)
            {
               
                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "نام و نام خانوادگی پزشک";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;


                SU = from prd in DCDC.TBL_Doctors
                     where prd.Active == true
                     select new
                     {
                         Code = prd.DoctorID,
                         Name = prd.DoctorName + " " + prd.DoctorFamily,
                         Other = ""
                     };
                //}



                try
                {
                    if (textBoxName.Text != "")
                        SU = SU.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU = SU.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }


            if (_type == 2)
            {
                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد دارو";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "نام دارو";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;

                SU = from prd in DCDC.TBL_Drugs
                     select new
                     {
                         Code = prd.DrugsId,
                         Name = prd.DrugsName,
                         Other = ""
                     };

                try
                {
                    if (textBoxName.Text != "")
                        SU = SU.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU = SU.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }

            if (_type == 3)
            {
                dataGridView_SelectPerson.Columns["CCode"].Visible = false;
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "کد ایثارگری";
                dataGridView_SelectPerson.Columns["Other"].HeaderText = "خانواده شهید";

                SU = from prd in DCDC.TBL_Martyrs
                     select new
                     {
                         Code = prd.MartyrId,
                         Name = prd.DosiersNo1,
                         Other = prd.MartyrNameFamily
                     };

                try
                {
                    if (textBoxName.Text != "")
                        SU = SU.Where(i => i.Name.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU = SU.Where(i => i.Other.Contains(textBoxOther.Text));
                }
                catch { }
            }


            if (_type == 4)
            {
                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد بیماری";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "نام بیماری";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;

                SU = from prd in DCDC.VW_StateSicknesses
                     select new
                     {
                         Code = prd.StateSicknessId,
                         Name = prd.StateSicknessMasterName + " - " + prd.StateSicknessName,
                         Other = ""
                     };

                try
                {
                    if (textBoxName.Text != "")
                        SU = SU.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU = SU.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }



            if (_type == 0)
            {
                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد بیماری";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "نام کلی بیماری";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;

                SU = from prd in DCDC.TBL_StateSicknessMasters
                     select new
                     {
                         Code = prd.Id,
                         Name = prd.StateSicknessMasterName,
                         Other = ""
                     };

                try
                {
                    if (textBoxName.Text != "")
                        SU = SU.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU = SU.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }



            if (_type == 5)
            {
                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد زخم بستر";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "محل زخم بستر";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;

                SU = from prd in DCDC.TBL_VisitStateBedsores
                     select new
                     {
                         Code = prd.StateBedsoreId,
                         Name = prd.BedsorePosition,
                         Other = ""
                     };

                try
                {
                    if (textBoxName.Text != "")
                        SU = SU.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU = SU.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }

            if (_type == 6)
            {
                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد پاراکلینیک";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "عنوان پاراکلینیک";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;

                SU = from prd in DCDC.TBL_Paraclinics
                     select new
                     {
                         Code = prd.ParaclinicId,
                         Name = prd.ParaclinicName,
                         Other = ""
                     };

                try
                {
                    if (textBoxName.Text != "")
                        SU = SU.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU = SU.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }

            if (_type == -1)
            {

                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "نام و نام خانوادگی پزشک";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;


                SU = from prd in DCDC.TBL_Doctors
                     //where prd.Active == true
                     select new
                     {
                         Code = prd.DoctorID,
                         Name = prd.DoctorName + " " + prd.DoctorFamily,
                         Other = ""
                     };
                //}



                try
                {
                    if (textBoxName.Text != "")
                        SU = SU.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU = SU.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }




            var SU1 = from prd in DSSS.TBL_Vaccinations
                      select new
                          {
                              Code = prd.Id,
                              Name = prd.TitleName,
                              Other = ""
                          };

            if (_type == 7)
            {
                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد واکسن";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "عنوان واکسن";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;

                SU1 = from prd in DSSS.TBL_Vaccinations
                      select new
                      {
                          Code = prd.Id,
                          Name = prd.TitleName,
                          Other = ""
                      };

                try
                {
                    if (textBoxName.Text != "")
                        SU1 = SU1.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU1 = SU1.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }

            if (_type == 8)
            {
                dataGridView_SelectPerson.Columns["CCode"].Visible = true;
                dataGridView_SelectPerson.Columns["CCode"].HeaderText = "کد تجهیز";
                dataGridView_SelectPerson.Columns["CName"].HeaderText = "عنوان تجهیز";
                dataGridView_SelectPerson.Columns["Other"].Visible = false;

                SU1 = from prd in DSSS.TBL_EquipmentUses
                      select new
                      {
                          Code = prd.Id,
                          Name = prd.TitleName,
                          Other = ""
                      };

                try
                {
                    if (textBoxName.Text != "")
                        SU1 = SU1.Where(i => i.Code.ToString().Contains(textBoxName.Text));

                    if (textBoxOther.Text != "")
                        SU1 = SU1.Where(i => i.Name.Contains(textBoxOther.Text));
                }
                catch { }
            }


           

            if (_type < 7)
                dataGridView_SelectPerson.DataSource = SU;
            else
                dataGridView_SelectPerson.DataSource = SU1;
        }
        
        
        DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DSSS = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        private void textBox_Code_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }


        public int CodeC = 0;
        public string NameC = "", OtherC = "";

        private void dataGridView_SelectPerson_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CodeC = int.Parse(dataGridView_SelectPerson.CurrentRow.Cells["CCode"].Value.ToString());
                NameC = dataGridView_SelectPerson.CurrentRow.Cells["CName"].Value.ToString();
                try { OtherC = dataGridView_SelectPerson.CurrentRow.Cells["Other"].Value.ToString(); }
                catch { }
                Close();
            }
            catch { }
        }

        private void SelectPerson_frm_Load(object sender, EventArgs e)
        {
            DataBind();
            errorProvider.SetError(dataGridView_SelectPerson, "جهت انتخاب بر روی ردیف مورد نظر دوبار کلیک نمایید");
            errorProvider.SetIconAlignment(dataGridView_SelectPerson, ErrorIconAlignment.TopRight);
            textBoxOther.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            if (_type == 0)
            {
                //PatientNE_frm Cu = new PatientNE_frm(true, 4, 0);
                //Cu.ShowDialog();
            }
            if (_type == 1)
            {
                DoctorNE_frm Cu = new DoctorNE_frm();
                Cu.ShowDialog();
            }
            if (_type == 2)
            {
                DrugsNE_Frm Cu = new DrugsNE_Frm(true, 0);
                Cu.ShowDialog();
            }
            if (_type == 3)
            {
                MartyrsNE_frm Cu = new MartyrsNE_frm();
                Cu.ShowDialog();
            }



            if (_type == 7)
            {
                VaccinationNE_Frm Cu = new VaccinationNE_Frm(true,0);
                Cu.ShowDialog();
            } 
            
            if (_type == 8)
            {
                EquipmentUseNE_Frm Cu = new EquipmentUseNE_Frm(true, 0);
                Cu.ShowDialog();
            }

            DataBind();
        }

        private void dataGridView_SelectPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //    dataGridView_SelectPerson_DoubleClick(this, null);
        }

    }
}
