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
    public partial class PatientTypeList_Frm : Form
    {

        public PatientTypeList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void PatientTypeList_Frm_Load(object sender, EventArgs e)
        {
            ShowListPatientType(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddPatientType.Name)) buttonItemAddPatientType.Enabled = false;
                if (UPer.Contains(buttonItemEditPatientType.Name)) buttonItemEditPatientType.Enabled = false;
                if (UPer.Contains(buttonItemDelPatientType.Name)) buttonItemDelPatientType.Enabled = false;
                if (UPer.Contains(buttonItemPatientTypePrintList.Name)) buttonItemPatientTypePrintList.Enabled = false;
            }
        }

        private void ShowListPatientType(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_PatientTypes
                      select new
                      {
                          prd.PatientTypeId,
                          prd.PatientTypeDsc,
                      };
            gridControl_PatientTypeList.DataSource = SUS;

            gridView_PatientTypeList.UnselectRow(gridView_PatientTypeList.FocusedRowHandle);
            gridView_PatientTypeList.SelectRow(RowFocus);
            gridView_PatientTypeList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_PatientTypeList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_PatientTypeList.OptionsView.ShowAutoFilterRow = !gridView_PatientTypeList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_PatientTypeList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddPatientType_Click(object sender, EventArgs e)
        {
            int Index = gridView_PatientTypeList.FocusedRowHandle;

            PatientTypeNE_Frm Uc = new PatientTypeNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListPatientType(gridView_PatientTypeList.RowCount);
        }

        private void buttonItemEditPatientType_Click(object sender, EventArgs e)
        {
            if (gridView_PatientTypeList.RowCount == 0) return;

            int Index = gridView_PatientTypeList.FocusedRowHandle;

            PatientTypeNE_Frm Uc = new PatientTypeNE_Frm(false,
                Convert.ToInt32(gridView_PatientTypeList.GetRowCellValue(Index, "PatientTypeId")));
            Uc.ShowDialog();
            ShowListPatientType(Index);
        }

        private void buttonItemDelPatientType_Click(object sender, EventArgs e)
        {

            if (gridView_PatientTypeList.RowCount == 0) return;
            int Index = gridView_PatientTypeList.FocusedRowHandle;
            int _PatientTypeId = Convert.ToInt32(gridView_PatientTypeList.GetRowCellValue(Index, "PatientTypeId"));

            if (!DCMDC.CheckPatientType(_PatientTypeId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این نسبت به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این نسبت حذف شود؟")) return;
            TBL_PatientType thsf = DCMDC.TBL_PatientTypes.First(hf => hf.PatientTypeId.Equals(_PatientTypeId));
            DCMDC.TBL_PatientTypes.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListPatientType(Index - 1);
        }


    }
}
