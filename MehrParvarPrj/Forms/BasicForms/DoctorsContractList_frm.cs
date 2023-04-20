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
    public partial class DoctorsContractList_Frm : Form
    {
        int _doctor_Id = 0;

        public DoctorsContractList_Frm(int Doctor_Id)
        {
            InitializeComponent();
            _doctor_Id = Doctor_Id;
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void DoctorsContractList_Frm_Load(object sender, EventArgs e)
        {
            ShowListDoctorsContract(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddDoctorsContract.Name)) buttonItemAddDoctorsContract.Enabled = false;
                if (UPer.Contains(buttonItemEditDoctorsContract.Name)) buttonItemEditDoctorsContract.Enabled = false;
                if (UPer.Contains(buttonItemDelDoctorsContract.Name)) buttonItemDelDoctorsContract.Enabled = false;
                if (UPer.Contains(buttonItemDoctorsContractPrintList.Name)) buttonItemDoctorsContractPrintList.Enabled = false;
            }
        }

        private void ShowListDoctorsContract(int RowFocus)
        {
            string str = "";
            DCMDC.SP_DoctorsContractOnLineUpdate(ref str);
            if (str != "")
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " قراردادهای پزشکان به روز آوری نشد ");


            var SUS = from prd in DCMDC.TBL_DoctorsContracts
                      where prd.Doctor_Id == _doctor_Id
                      select new
                      {
                          prd.Id,
                          prd.Doctor_Id,
                          prd.ContractNo,
                          prd.ContractDate,
                          prd.ContractEndDate,
                          prd.Active
                      };
            gridControl_DoctorsContractList.DataSource = SUS;

            gridView_DoctorsContractList.UnselectRow(gridView_DoctorsContractList.FocusedRowHandle);
            gridView_DoctorsContractList.SelectRow(RowFocus);
            gridView_DoctorsContractList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_DoctorsContractList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_DoctorsContractList.OptionsView.ShowAutoFilterRow = !gridView_DoctorsContractList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_DoctorsContractList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddDoctorsContract_Click(object sender, EventArgs e)
        {
            int Index = gridView_DoctorsContractList.FocusedRowHandle;

            DoctorsContractNE_frm Uc = new DoctorsContractNE_frm(true,
                _doctor_Id,
                0);
            Uc.ShowDialog();
            ShowListDoctorsContract(gridView_DoctorsContractList.RowCount);
        }

        private void buttonItemEditDoctorsContract_Click(object sender, EventArgs e)
        {
            if (gridView_DoctorsContractList.RowCount == 0) return;

            int Index = gridView_DoctorsContractList.FocusedRowHandle;

            DoctorsContractNE_frm Uc = new DoctorsContractNE_frm(false,
                _doctor_Id,
                Convert.ToInt32(gridView_DoctorsContractList.GetRowCellValue(Index, "Id")));
            Uc.ShowDialog();
            ShowListDoctorsContract(Index);
        }

        private void buttonItemDelDoctorsContract_Click(object sender, EventArgs e)
        {

            if (gridView_DoctorsContractList.RowCount == 0) return;
            int Index = gridView_DoctorsContractList.FocusedRowHandle;
            int _id = Convert.ToInt32(gridView_DoctorsContractList.GetRowCellValue(Index, "Id"));

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این قرارداد حذف شود؟")) return;
            TBL_DoctorsContract thsf = DCMDC.TBL_DoctorsContracts.First(hf => hf.Id.Equals(_id));
            DCMDC.TBL_DoctorsContracts.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListDoctorsContract(Index - 1);
        }


    }
}
