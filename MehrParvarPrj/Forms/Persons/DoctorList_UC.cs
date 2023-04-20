using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.Properties;
using MehrParvarPrj.DataLinq;

namespace MehrParvarPrj
{
    public partial class DoctorList_UC : UserControl
    {
        public DoctorList_UC()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DCMMM = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load & 

        private void DoctorList_UC_Load(object sender, EventArgs e)
        {
            string str = "";
            DCMDC.SP_DoctorsContractOnLineUpdate(ref str);
            if (str != "")
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " قراردادهای پزشکان به روز آوری نشد ");

            ShowListDoctor(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItem_DoctorNew.Name)) buttonItem_DoctorNew.Enabled = false;
                if (UPer.Contains(buttonItemDoctorEdit.Name)) buttonItemDoctorEdit.Enabled = false;
                if (UPer.Contains(buttonItemDoctorDel.Name)) buttonItemDoctorDel.Enabled = false;
                if (UPer.Contains(buttonItemDoctorPrintList.Name)) buttonItemDoctorPrintList.Enabled = false;
                if (UPer.Contains(buttonItemDoctorSMSEmail.Name)) buttonItemDoctorSMSEmail.Enabled = false;
                if (UPer.Contains(buttonItemDoctorListContract.Name)) buttonItemDoctorListContract.Enabled = false;

                if (UPer.Contains(buttonItemExcelExportDoctorList.Name)) buttonItemExcelExportDoctorList.Enabled = false;
                if (UPer.Contains(buttonItemFileDoctors.Name)) buttonItemFileDoctors.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItemDoctorSMSEmail.Enabled = false;
            }
            //codeing
        }

        private void DoctorList_UC_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                ShowListDoctor(gridView_DoctorList.RowCount);
            }
            catch { }

        }


        #endregion


        #region Search
        private void ShowListDoctor(int RowFocus)
        {
            //var SUS = from prd in DCMDC.TBL_Doctors
            //          select new
            //          {
            //              prd.DoctorID,
            //              prd.DoctorPic,
            //              prd.MedicalCode,
            //              prd.NationalCode,

            //              prd.DoctorName,
            //              prd.DoctorFamily,
            //              prd.ParentName,
            //              prd.IDNO,
            //              DoctorTypeDsc = DCMDC.TBL_DoctorTypes.First(hf => hf.DoctorTypeId.Equals(prd.DoctorType)).DoctorTypeDsc,
            //              prd.DoctorType,
            //              prd.Address,
            //              prd.TelHome,
            //              prd.TelBusiness,
            //              prd.Mobile,
            //              prd.Email,
            //              prd.Email1,
            //              prd.Active,
            //              prd.CardBankNo1,
            //              prd.CardBankNo2,
            //              prd.AddressPart,
            //              BankName = DCMMM.TBL_Banks.First(hf => hf.Id == prd.Bank_Id).TitleName,
                          
            //              LocationPart = "",//LoactionPartStr(prd.DoctorID),

            //              CreateDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value),
            //              BrithDate = Global_Cls.MiladiDateToShamsi(prd.BrithDate.Value),
            //              prd.BrithCityName,
            //          };

            var SUS = from prd in DCMDC.VW_Doctors
                      select new
                      {
                          prd.DoctorID,
                          prd.MedicalCode,
                          prd.NationalCode,

                          prd.DoctorName,
                          prd.DoctorFamily,
                          prd.ParentName,
                          prd.IDNO,
                          prd.DoctorTypeDsc,
                          prd.DoctorType,
                          prd.Address,
                          prd.TelHome,
                          prd.TelBusiness,
                          prd.Mobile,
                          prd.AddressBusiness,
                          prd.Email,
                          prd.Active,
                          prd.CardBankNo1,
                          prd.CardBankNo2,
                          prd.AddressPart,
                          prd.BankName,

                          prd.LocationPart,

                          prd.CreateDate,
                          prd.BrithDate,
                          prd.BrithCityName,
                          
                          prd.ContractNo,
                          prd.ContractDate,
                          prd.ContractEndDate
                      };

            gridControl_DoctorList.DataSource = SUS;

            chkAllDoctor_CheckedChanged(this, null);


            gridView_DoctorList.UnselectRow(gridView_DoctorList.FocusedRowHandle);
            gridView_DoctorList.SelectRow(RowFocus);
            gridView_DoctorList.FocusedRowHandle = RowFocus;
        }

      

        string ActiveFilterStr = " ";
        private void chkAllDoctor_CheckedChanged(object sender, EventArgs e)
        {
            string rStr = " ";
            try
            {
                rStr = gridView_DoctorList.ActiveFilterString.Replace(ActiveFilterStr, " ");
            }
            catch { rStr = gridView_DoctorList.ActiveFilterString; }
            try
            {
                if (rStr.Substring(rStr.Length - 4, 4).ToLower().Replace(" ", "") == "and".ToLower())
                    rStr = rStr.Remove(rStr.Length - 4);

                if (rStr.Substring(1, 4).ToLower().Replace(" ", "") == "and".ToLower())
                    rStr = rStr.Remove(1, 4);

                if (rStr.Substring(rStr.Length - 3, 3).ToLower().Replace(" ", "") == "or".ToLower())
                    rStr = rStr.Remove(rStr.Length - 3);

                if (rStr.Substring(1, 3).ToLower().Replace(" ", "") == "or".ToLower())
                    rStr = rStr.Remove(1, 3);
            }
            catch { }

            ActiveFilterStr = " ";

            if (chkNonActive.Checked)
                ActiveFilterStr = " (Active = false) ";

            if (chkActive.Checked)
                ActiveFilterStr = " (Active = true) ";

            if (chkNonContract.Checked)
                ActiveFilterStr = " (ContractNo Is Null) and (Active = true) ";
            
            if (chkContract.Checked)
                ActiveFilterStr = " (ContractNo Is not Null) and (Active = true) ";

            gridView_DoctorList.ActiveFilterString = ActiveFilterStr;
            ActiveFilterStr = gridView_DoctorList.ActiveFilterString;

            if (rStr == " ") rStr = "";
            if (ActiveFilterStr == " ") ActiveFilterStr = "";

            if (rStr != "" && ActiveFilterStr != "") gridView_DoctorList.ActiveFilterString += " and " + rStr;
            else if (rStr != "" && ActiveFilterStr == "") gridView_DoctorList.ActiveFilterString = rStr;
            gridView_DoctorList.ApplyColumnsFilter();
        }


        #endregion


        #region All Buttons

        private void buttonItem_DoctorNew_Click(object sender, EventArgs e)
        {
            DoctorNE_frm Uc = new DoctorNE_frm();
            Uc.ShowDialog();
            ShowListDoctor(gridView_DoctorList.RowCount);
        }

        private void buttonItemDoctorEdit_Click(object sender, EventArgs e)
        {
            if (gridView_DoctorList.RowCount == 0) return;

            int Index = gridView_DoctorList.FocusedRowHandle;

            DoctorNE_frm Uc = new DoctorNE_frm(Convert.ToInt32(gridView_DoctorList.GetRowCellValue(Index, "DoctorID")));
            Uc.ShowDialog();
            ShowListDoctor(Index);
        }

        private void buttonItemDoctorDel_Click(object sender, EventArgs e)
        {
            if (gridView_DoctorList.RowCount == 0) return;
            int Index = gridView_DoctorList.FocusedRowHandle;
            int OpCode = Convert.ToInt32(gridView_DoctorList.GetRowCellValue(Index, "DoctorID"));

            if (!DCMDC.CheckDoctorCode(OpCode).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " فعالیت این پزشک در سیستم فعال می باشد. درنتیجه امکان حذف وجود ندارد ");
                if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این پزشک غیرفعال شود؟"))
                {
                    TBL_Doctor thsf1 = DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(OpCode));
                    thsf1.Active = false;
                    DCMDC.SubmitChanges();
                    ShowListDoctor(Index - 1);
                }
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این پزشک حذف شود؟")) return;
            TBL_Doctor thsf = DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(OpCode));
            DCMDC.TBL_Doctors.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListDoctor(Index - 1);
        }

        private void buttonItemDoctorSearch_Click(object sender, EventArgs e)
        {
            gridView_DoctorList.OptionsView.ShowAutoFilterRow = !gridView_DoctorList.OptionsView.ShowAutoFilterRow;
            if (!buttonItemDoctorSearch.Checked)
            {
                gridView_DoctorList.ActiveFilterString = ActiveFilterStr;
                gridView_DoctorList.ApplyColumnsFilter();
            }
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_DoctorList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemDoctorPrintList_Click(object sender, EventArgs e)
        {
            gridView_DoctorList.FormatConditions[0].Appearance.BackColor = Color.White;
            gridView_DoctorList.FormatConditions[1].Appearance.BackColor = Color.White;
            gridView_DoctorList.FormatConditions[2].Appearance.BackColor = Color.White;
            gridView_DoctorList.FormatConditions[3].Appearance.BackColor = Color.White;

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_DoctorList);
            PP.ShowDialog();

            gridView_DoctorList.FormatConditions[0].Appearance.BackColor = Color.PaleGreen;
            gridView_DoctorList.FormatConditions[1].Appearance.BackColor = Color.MistyRose;
            gridView_DoctorList.FormatConditions[2].Appearance.BackColor = Color.SkyBlue;
            gridView_DoctorList.FormatConditions[3].Appearance.BackColor = Color.Silver;
        }

        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            ShowListDoctor(gridView_DoctorList.FocusedRowHandle);
        }
        

        private void buttonItemSMS_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(true, "", gridView_DoctorList.GetRowCellValue(gridView_DoctorList.FocusedRowHandle, "Mobile").ToString());
        }

        private void buttonItemDoctorEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("", gridView_DoctorList.GetRowCellValue(gridView_DoctorList.FocusedRowHandle, "Email").ToString());
        }

        #endregion

        private void buttonItemExcelExportDoctorList_Click(object sender, EventArgs e)
        {
            Function_Cls.ExportExcelGrid(gridControl_DoctorList);
        }


        private void gridView_DoctorList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int Index = gridView_DoctorList.FocusedRowHandle;
                int OpCode = Convert.ToInt32(gridView_DoctorList.GetRowCellValue(Index, "DoctorID"));

                DataClasses_MainDataContext DC22 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                pictureBoxPic.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(((byte[])(
                    DC22.TBL_Doctors.First(f => f.DoctorID == OpCode).DoctorPic.ToArray()))));
            }
            catch
            {
                pictureBoxPic.Image = null;
            }
        }

        private void buttonItemDoctorContract_Click(object sender, EventArgs e)
        {
            int Index = gridView_DoctorList.FocusedRowHandle;
            int OpCode = Convert.ToInt32(gridView_DoctorList.GetRowCellValue(Index, "DoctorID"));
            DoctorsContractList_Frm dc = new DoctorsContractList_Frm(OpCode);
            dc.ShowDialog();

           ShowListDoctor(Index);
        }

        private void buttonItemFileDoctors_Click(object sender, EventArgs e)
        {
            int DoctorIDSet;
            DoctorIDSet = Convert.ToInt32(gridView_DoctorList.GetRowCellValue(gridView_DoctorList.FocusedRowHandle, "DoctorID"));
            MSSImageSelectorFiling_frm imgs = new MSSImageSelectorFiling_frm(DoctorIDSet.ToString(), Global_Cls.AddressFile + @"\DoctorFile\");
            if (imgs.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void gridView_DoctorList_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.RowHandle + 1;
        }

      

    }
}
