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
    public partial class DoctorTypeList_Frm : Form
    {

        public DoctorTypeList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void DoctorTypeList_Frm_Load(object sender, EventArgs e)
        {
            ShowListDoctorType(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddDoctorType.Name)) buttonItemAddDoctorType.Enabled = false;
                if (UPer.Contains(buttonItemEditDoctorType.Name)) buttonItemEditDoctorType.Enabled = false;
                if (UPer.Contains(buttonItemDelDoctorType.Name)) buttonItemDelDoctorType.Enabled = false;
                if (UPer.Contains(buttonItemDoctorTypePrintList.Name)) buttonItemDoctorTypePrintList.Enabled = false;
            }
        }

        private void ShowListDoctorType(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_DoctorTypes
                      select new
                      {
                          prd.DoctorTypeId,
                          prd.DoctorTypeDsc,
                      };
            gridControl_DoctorTypeList.DataSource = SUS;

            gridView_DoctorTypeList.UnselectRow(gridView_DoctorTypeList.FocusedRowHandle);
            gridView_DoctorTypeList.SelectRow(RowFocus);
            gridView_DoctorTypeList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_DoctorTypeList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_DoctorTypeList.OptionsView.ShowAutoFilterRow = !gridView_DoctorTypeList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_DoctorTypeList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddDoctorType_Click(object sender, EventArgs e)
        {
            int Index = gridView_DoctorTypeList.FocusedRowHandle;

            DoctorTypeNE_Frm Uc = new DoctorTypeNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListDoctorType(gridView_DoctorTypeList.RowCount);
        }

        private void buttonItemEditDoctorType_Click(object sender, EventArgs e)
        {
            if (gridView_DoctorTypeList.RowCount == 0) return;

            int Index = gridView_DoctorTypeList.FocusedRowHandle;

            DoctorTypeNE_Frm Uc = new DoctorTypeNE_Frm(false,
                Convert.ToInt32(gridView_DoctorTypeList.GetRowCellValue(Index, "DoctorTypeId")));
            Uc.ShowDialog();
            ShowListDoctorType(Index);
        }

        private void buttonItemDelDoctorType_Click(object sender, EventArgs e)
        {

            if (gridView_DoctorTypeList.RowCount == 0) return;
            int Index = gridView_DoctorTypeList.FocusedRowHandle;
            int _DoctorTypeId = Convert.ToInt32(gridView_DoctorTypeList.GetRowCellValue(Index, "DoctorTypeId"));

            if (!DCMDC.CheckDoctorType(_DoctorTypeId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این نوع پزشک به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این نوع پزشک حذف شود؟")) return;
            TBL_DoctorType thsf = DCMDC.TBL_DoctorTypes.First(hf => hf.DoctorTypeId.Equals(_DoctorTypeId));
            DCMDC.TBL_DoctorTypes.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListDoctorType(Index - 1);
        }


    }
}
