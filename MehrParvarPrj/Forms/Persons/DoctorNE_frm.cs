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
    public partial class DoctorNE_frm : Form
    {
        int _DoctorID = 0;
        bool _newOrEditDoctor = false;

        public DoctorNE_frm(int DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
            _newOrEditDoctor = false;
        }
        public DoctorNE_frm()
        {
            InitializeComponent();
            _newOrEditDoctor = true;
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DCMMM = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void DoctorNE_frm_Load(object sender, EventArgs e)
        {
            var SUS = from prd in DCMD.TBL_PrtCities
                      orderby prd.CityName_Fa
                      select prd;
            ComboBoxBrithCityName.DataSource = SUS;
            ComboBoxBrithCityName.Text = ""; 

            var SUS2 = from prd in DCMD.TBL_ContractTypes
                       select new { prd.ContractTypeId, prd.ContractTypeDsc };
            comboBoxContract.DisplayMember = "ContractTypeDsc";
            comboBoxContract.ValueMember = "ContractTypeId";
            comboBoxContract.DataSource = SUS2;

            var SUS3 = from prd in DCMD.TBL_DoctorTypes
                       select new { prd.DoctorTypeId, prd.DoctorTypeDsc };
            comboBoxDoctorType.DisplayMember = "DoctorTypeDsc";
            comboBoxDoctorType.ValueMember = "DoctorTypeId";
            comboBoxDoctorType.DataSource = SUS3;
            
            var SUS4 = from prd in DCMMM.TBL_Banks
                       select new { prd.Id, prd.TitleName };
            comboBoxBank.DisplayMember = "TitleName";
            comboBoxBank.ValueMember = "Id";
            comboBoxBank.DataSource = SUS4;

            if (itemPanelLocationPart.Items.Count == 0)
                foreach (var item in DCMMM.TBL_LocationParts)
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.Id.ToString();
                    Ch.Text = item.TitleName;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelLocationPart.Items.Add(Ch);
                    itemPanelLocationPart.Refresh();
                }


            SetDefault_DoctorNE();
            //chkTel.Visible = _newOrEditDoctor;
        }

        private void SetDefault_DoctorNE()
        {
            if (!_newOrEditDoctor)
            {
                try
                {
                    TBL_Doctor tbhc = DCMD.TBL_Doctors.First(thfr => thfr.DoctorID.Equals(_DoctorID));

                    byte[] b = null;
                    if (tbhc.DoctorPic != null)
                    {
                        b = new byte[tbhc.DoctorPic.Length];
                        b = tbhc.DoctorPic.ToArray();
                    }

                    try { pictureBoxDoctorPic.Image = byteArrayToImage(b); }
                    catch { }

                    textBoxMedicalCode.Text = tbhc.MedicalCode;

                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.CreateDate));
                    comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_Name.Text = tbhc.DoctorName;
                    textBox_Family.Text = tbhc.DoctorFamily;
                    textBox_Parent.Text = tbhc.ParentName;
                    textBox_IDNO.Text = tbhc.IDNO;
                    textBox_NationalCode.Text = tbhc.NationalCode;
                    ComboBoxBrithCityName.Text = tbhc.BrithCityName;

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate));
                    comboBox_YearBD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthBD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayBD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    nUpDown_AddressPrt.Value = tbhc.AddressPart.Value;
                    textBox_Address.Text = tbhc.Address;
                    textBox_TelHome.Text = tbhc.TelHome;
                    textBox_TelBusiness.Text = tbhc.TelBusiness;
                    textBox_Mobile.Text = tbhc.Mobile;
                    textBoxAddressBussiness.Text = tbhc.AddressBusiness;
                    textBoxEmail.Text = tbhc.Email;

                    comboBoxDoctorType.SelectedValue = tbhc.DoctorType;
                    comboBoxContract.SelectedValue = tbhc.ContractTypeId;
                    try { comboBoxBank.SelectedValue = tbhc.Bank_Id; }
                    catch { }
                    chkActive.Checked = tbhc.Active.Value;


                    textBoxCardBankNo1.Text = tbhc.CardBankNo1;
                    textBoxCardBankNo2.Text = tbhc.CardBankNo2;

                    foreach (var item in (from PT in DCMMM.TBL_LocationPartDoctors where PT.Doctors_Id == _DoctorID select PT))
                        (itemPanelLocationPart.Items[item.LocationPart_Id.ToString()] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;

                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.Message);
                }
            }

            else if (_newOrEditDoctor)
            {

                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBox_YearBD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthBD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayBD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                ComboBoxBrithCityName.Text = "تهران";
                
                chkActive.Checked = true;
            }
        }


        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            //if (textBoxMedicalCode.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "کد نظام پزشکی را وارد نمایید!"); textBoxMedicalCode.Focus(); return; }
            //if (textBox_Name.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام را وارد نمایید!"); textBox_Name.Focus(); return; }
            if (textBox_Family.Text == "") { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام خانوادگی را وارد نمایید!"); textBox_Family.Focus(); return; }
            if (textBox_Mobile.Text == "")
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا موبایل را وارد نمایید!"); textBox_Mobile.Focus(); return; }

            if (textBox_Mobile.Text != "" && textBox_Mobile.Text.Length < 11)
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا شماره موبایل را به طور صحیح وارد نمایید!"); textBox_Mobile.Focus(); return; }
            if (textBox_TelHome.Text != "" && textBox_TelHome.Text.Length < 8)
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا شماره تلفن را به طور صحیح وارد نمایید!"); textBox_TelHome.Focus(); return; }
            if (textBox_TelBusiness.Text != "" && textBox_TelBusiness.Text.Length < 8)
            { Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "لطفا شماره تلفن را به طور صحیح وارد نمایید!"); textBox_TelBusiness.Focus(); return; }

            
            if (_newOrEditDoctor)
            { 
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    if ((from d in DCMD1.TBL_Doctors
                         where d.DoctorName == textBox_Name.Text && d.DoctorFamily == textBox_Family.Text
                         select d).Count() > 0)
                    {
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "پزشک تکراری می باشد!"); textBox_Family.Focus(); 
                        return;
                    }

            }
            panel_CDate1_Leave(this, null);
            panel_BrithDate_Leave(this, null);

            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید تغییرات درخواستی ثبت شوند؟"))
            {
                if (OKFunction())
                    Close();
            }
        }

        private bool OKFunction()
        {
            byte[] b = null;
            if (pictureBoxDoctorPic.Image != null)
                b = imageToByteArray(pictureBoxDoctorPic.Image);


            if (_newOrEditDoctor)
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    TBL_Doctor THC = new TBL_Doctor()
                   {
                       DoctorPic = b,
                       MedicalCode = textBoxMedicalCode.Text,
                       CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text),
                       DoctorName = textBox_Name.Text,
                       DoctorFamily = textBox_Family.Text,
                       ParentName = textBox_Parent.Text,
                       IDNO = textBox_IDNO.Text,

                       NationalCode = textBox_NationalCode.Text,
                       BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text),
                       BrithCityName = ComboBoxBrithCityName.Text,

                       AddressPart = short.Parse(nUpDown_AddressPrt.Value.ToString()),
                       Address = textBox_Address.Text,

                       TelHome = textBox_TelHome.Text,
                       Mobile = textBox_Mobile.Text,
                       TelBusiness = textBox_TelBusiness.Text,
                       AddressBusiness = textBoxAddressBussiness.Text,
                       Email = textBoxEmail.Text,

                       ContractTypeId = short.Parse(comboBoxContract.SelectedValue.ToString()),
                       DoctorType = short.Parse(comboBoxDoctorType.SelectedValue.ToString()),
                       Active = chkActive.Checked,

                       Bank_Id = short.Parse(comboBoxBank.SelectedValue.ToString()),
                       CardBankNo1 = textBoxCardBankNo1.Text,
                       CardBankNo2 = textBoxCardBankNo2.Text
                   };
                    DCMD1.TBL_Doctors.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();

                    int NewDoctorID = (from h in DCMD1.TBL_Doctors select h.DoctorID).Max();
                    try
                    {
                        foreach (var item in itemPanelLocationPart.Items)
                        {
                            if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                            {
                                TBL_LocationPartDoctor PatientTG = new TBL_LocationPartDoctor
                                {
                                    Doctors_Id = NewDoctorID,
                                    LocationPart_Id = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name)
                                };
                                DCMMM.TBL_LocationPartDoctors.InsertOnSubmit(PatientTG);
                                DCMMM.SubmitChanges();
                            }
                        }
                    }
                    catch { }
                    //اضافه به دفتر تلفن
                    if (chkTel.Checked)
                    {
                        int a = Global_Cls.InsertPerTelMob(textBox_Name.Text,
                            textBox_Family.Text, textBox_TelHome.Text, textBox_Mobile.Text, textBoxAddressBussiness.Text, textBox_Address.Text, "");
                        if (a == 0)
                            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, false, "مشخصات این فرد در دفتر تلفن ثبت گردید");
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات این پزشک قبلا وارد شده و تکراری است!", ex.Message);
                    else
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد، دوباره تایید نمایید", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditDoctor)
                    try
                    {
                        DataClasses_MainDataContext DCMD2 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                        TBL_Doctor tbhc = DCMD2.TBL_Doctors.First(thfh => thfh.DoctorID.Equals(_DoctorID));

                        try { tbhc.DoctorPic = b; }
                        catch { }

                        tbhc.MedicalCode = textBoxMedicalCode.Text;
                        tbhc.CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
                        tbhc.DoctorName = textBox_Name.Text;
                        tbhc.DoctorFamily = textBox_Family.Text;
                        tbhc.ParentName = textBox_Parent.Text;
                        tbhc.IDNO = textBox_IDNO.Text;

                        tbhc.NationalCode = textBox_NationalCode.Text;
                        tbhc.BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text);
                        tbhc.BrithCityName = ComboBoxBrithCityName.Text;

                        tbhc.AddressPart = short.Parse(nUpDown_AddressPrt.Value.ToString());
                        tbhc.Address = textBox_Address.Text;

                        tbhc.TelHome = textBox_TelHome.Text;
                        tbhc.Mobile = textBox_Mobile.Text;
                        tbhc.TelBusiness = textBox_TelBusiness.Text;
                        tbhc.AddressBusiness = textBoxAddressBussiness.Text;
                        tbhc.Email = textBoxEmail.Text;

                        tbhc.ContractTypeId = short.Parse(comboBoxContract.SelectedValue.ToString());
                        tbhc.DoctorType = short.Parse(comboBoxDoctorType.SelectedValue.ToString());
                        tbhc.Active = chkActive.Checked;

                        tbhc.Bank_Id = short.Parse(comboBoxBank.SelectedValue.ToString());
                        tbhc.CardBankNo1 = textBoxCardBankNo1.Text;
                        tbhc.CardBankNo2 = textBoxCardBankNo2.Text;

                        DCMD2.SubmitChanges();

                        var LocationPartDoctors = DCMMM.TBL_LocationPartDoctors.Where(c => c.Doctors_Id == _DoctorID);
                        DCMMM.TBL_LocationPartDoctors.DeleteAllOnSubmit(LocationPartDoctors);
                        DCMMM.SubmitChanges();
                        try
                        {
                            foreach (var item in itemPanelLocationPart.Items)
                            {
                                if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                                {
                                    TBL_LocationPartDoctor PatientTG = new TBL_LocationPartDoctor
                                    {
                                        Doctors_Id = _DoctorID,
                                        LocationPart_Id = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name)
                                    };
                                    DCMMM.TBL_LocationPartDoctors.InsertOnSubmit(PatientTG);
                                    DCMMM.SubmitChanges();
                                }
                            }
                        }
                        catch { }

                        //اضافه به دفتر تلفن
                        if (chkTel.Checked)
                        {
                            try
                            {
                                int a = Global_Cls.InsertPerTelMob(textBox_Name.Text,
                                textBox_Family.Text, textBox_TelHome.Text, textBox_Mobile.Text, textBoxEmail.Text, textBox_Address.Text, "");
                                if (a == 0)
                                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, false, "مشخصات این فرد در دفتر تلفن ثبت گردید");
                            }
                            catch { }
                        }

                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات این پزشک قبلا وارد شده و تکراری است!", ex.Message);
                        else
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


        #region Other
        TextBox tx = new TextBox();
        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            { e.KeyChar = '\0'; return; }

            if (e.KeyChar == (char)Keys.Space)
            {
                tx = (TextBox)sender;
                if (tx.Text.Length < 18) tx.Text = tx.Text + "000";
                tx.SelectionStart = tx.Text.Length;
            }
        }

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {
            tx = (TextBox)sender;
            string str = tx.Text;
            int ts = tx.SelectionStart;
            if (tx.Text != "")
            {
                try
                {
                    str = System.String.Format("{0:###,###}", System.Int64.Parse(str, System.Globalization.NumberStyles.Number));
                }
                catch
                {
                    str = str.Replace(",", "");
                }
                tx.Text = str.Replace(" ", "");
                tx.SelectionStart = ts + 1;
            }

        }

        private void panel_CDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthCD.Text) > 6 && Convert.ToInt16(comboBox_DayCD.Text) == 31) comboBox_DayCD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthCD.Text) == 12 && (Convert.ToInt16(comboBox_DayCD.Text) == 31 || Convert.ToInt16(comboBox_DayCD.Text) == 30)) comboBox_DayCD.Text = "29";
        }

        private void panel_BrithDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthBD.Text) > 6 && Convert.ToInt16(comboBox_DayBD.Text) == 31) comboBox_DayBD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthBD.Text) == 12 && (Convert.ToInt16(comboBox_DayBD.Text) == 31 || Convert.ToInt16(comboBox_DayBD.Text) == 30)) comboBox_DayBD.Text = "29";
        }

        #endregion

        private void pictureBoxDoctorPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Image File|*.Jpg;*.Jpeg;*.bmp;*.png;*.tiff;*.tif;*.gif;*.ico";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxDoctorPic.Image = System.Drawing.Image.FromFile(op.FileName);
                }
                catch
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, " مسیر فایل و یا سورس فایل نامعتبر است. دوباره سعی کنید ");
                }
            }

        }

        private void button_DelPic_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxDoctorPic.Image = null;
                pictureBoxDoctorPic.Load("");
            }
            catch { }

        }
        

       
    }
}
