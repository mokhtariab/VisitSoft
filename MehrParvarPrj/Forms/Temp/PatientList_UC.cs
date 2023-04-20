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
    public partial class PatientList_UC : UserControl
    {
        public PatientList_UC()
        {
            InitializeComponent();
            ShowListPatient(1);
            InterFaceChange();
        }
        
        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        #region Load & UI
        private void PatientList_UC_Load(object sender, EventArgs e)
        {
            ShowListPatient(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemCustomEdit.Name)) buttonItemCustomEdit.Enabled = false;
                if (UPer.Contains(buttonItemCustomDel.Name)) buttonItemCustomDel.Enabled = false;
                if (UPer.Contains(buttonItemCustomPrintList.Name)) buttonItemCustomPrintList.Enabled = false;
            }
        }

        private void PatientList_UC_Layout(object sender, LayoutEventArgs e)
        {
            try 
            { 
                ShowListPatient(gridView_PatientList.RowCount); 
            }
            catch { }
        }

        #endregion


        #region Search

        private void ShowListPatient(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_Patients
                      select new
                      {
                          CreateDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value),
                          prd.PatientID,
                          //prd.PatientTypeId,
                          //PatientTypeDsc = prd.PatientTypeId == 0 ? "" : DCMDC.TBL_PatientTypes.First(hf => hf.PatientTypeId.Equals(prd.PatientTypeId)).PatientTypeDsc,
                          PatientTypeId = 0,
                          PatientTypeDsc = "",
                          prd.DosiersNo,
                          prd.PatientName,
                          prd.PatientFamily,
                          prd.ParentName,
                          prd.NationalCode,
                          prd.PercentState,
                          prd.KinShipWith,
                          prd.WifeSituation,
                          prd.ProtectSituation,
                          prd.WholeSituation,

                          ContractTypeDsc = prd.ContractTypeId == 0 ? "" : DCMDC.TBL_ContractTypes.First(hf => hf.ContractTypeId.Equals(prd.ContractTypeId)).ContractTypeDsc,
                          prd.PeriodVisit,
                          //LastDocWatcherName = prd.LastDocWatcherId == 0 ? "" : (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.LastDocWatcherId)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.LastDocWatcherId)).DoctorFamily),
                          LastDocHealthName = prd.LastDocHealthId == 0 ? "" : (DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.LastDocHealthId)).DoctorName + " " + DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(prd.LastDocHealthId)).DoctorFamily),

                          LastOverhalDateDsc = Global_Cls.MiladiDateToShamsi(prd.LastOverhalDate.Value),
                          
                          prd.AddressPart,

                          prd.Address,
                          prd.TelHome,
                          prd.TelBusiness,
                          prd.Mobile,
                          prd.Email,
                          prd.Active
                      };
            gridControl_PatientList.DataSource = SUS;

            gridView_PatientList.ActiveFilterString = " (PatientTypeId = 2 and Active = true) ";
            gridView_PatientList.ApplyColumnsFilter();
            gridView_PatientList.FocusedRowHandle = RowFocus;
        }
        #endregion


        #region All Buttons

        private void buttonItemCustomEdit_Click(object sender, EventArgs e)
        {
            if (gridView_PatientList.RowCount == 0) return;
            int Index = gridView_PatientList.FocusedRowHandle;

            PatientNE_frm Uc = new PatientNE_frm(false, 0, Convert.ToInt32(gridView_PatientList.GetRowCellValue(Index, "PatientID")), true);
            Uc.ShowDialog();
            ShowListPatient(Index);
        }

        private void buttonItemCustomDel_Click(object sender, EventArgs e)
        {
            if (gridView_PatientList.RowCount == 0) return;

            int Index = gridView_PatientList.FocusedRowHandle;
            int CustID = Convert.ToInt32(gridView_PatientList.GetRowCellValue(Index, "PatientID"));

            //if (!DCMDC.CheckPatientCode(CustID).Value)
            //{
            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " فعالیت این متقاضی در سیستم موجود می باشد. درنتیجه امکان حذف وجود ندارد ");
            //    return;
            //}

            
            //if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این متقاضی حذف شود؟")) return;
            //TBL_Patient thsf = DCMDC.TBL_Patients.First(hf => hf.PatientID.Equals(CustID));
            //DCMDC.TBL_Patients.DeleteOnSubmit(thsf);
            //DCMDC.SubmitChanges();
            //ShowListPatient(Index - 1);
        }

        private void buttonItemCustomSearch_Click(object sender, EventArgs e)
        {
            gridView_PatientList.OptionsView.ShowAutoFilterRow = !gridView_PatientList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_PatientList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCustomPrintList_Click(object sender, EventArgs e)
        {
            gridControl_PatientList.ShowPreview();
        }


        private void label1_CheckedChanged(object sender, EventArgs e)
        {
            string ActiveFilterString = "  ";
            if (chkFatherMather.Checked)
                ActiveFilterString = " (PatientTypeId = 1 and Active = true) ";
            else if (chkStuntman.Checked)
                ActiveFilterString = " (PatientTypeId = 2 and Active = true) ";
            else if (chkOther.Checked)
                ActiveFilterString = " (PatientTypeId = 3 and Active = true) ";

            gridView_PatientList.ActiveFilterString = ActiveFilterString;
            gridView_PatientList.ApplyColumnsFilter();
        }
        #endregion




    }
}
