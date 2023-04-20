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
    public partial class ContractTypeList_Frm : Form
    {

        public ContractTypeList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void ContractTypeList_Frm_Load(object sender, EventArgs e)
        {
            ShowListContractType(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddContractType.Name)) buttonItemAddContractType.Enabled = false;
                if (UPer.Contains(buttonItemEditContractType.Name)) buttonItemEditContractType.Enabled = false;
                if (UPer.Contains(buttonItemDelContractType.Name)) buttonItemDelContractType.Enabled = false;
                if (UPer.Contains(buttonItemContractTypePrintList.Name)) buttonItemContractTypePrintList.Enabled = false;
            }
        }

        private void ShowListContractType(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_ContractTypes
                      select new
                      {
                          prd.ContractTypeId,
                          prd.ContractTypeDsc,
                          ContractTypePrice = Global_Cls.DigitSeparator(prd.ContractTypePrice.Value.ToString()),
                          VisitForcePrice = Global_Cls.DigitSeparator(prd.VisitForcePrice.Value.ToString()),
                          BothVisitPrice = Global_Cls.DigitSeparator(prd.BothVisitPrice.Value.ToString()),
                          TaxPrice = Global_Cls.DigitSeparator(prd.TaxPrice.Value.ToString()),
                          InsurancePrice = Global_Cls.DigitSeparator(prd.InsurancePrice.Value.ToString()),
                          OtherDecrement = Global_Cls.DigitSeparator(prd.OtherDecrement.Value.ToString()),
                          OtherIncrement = Global_Cls.DigitSeparator(prd.OtherIncrement.Value.ToString()), 
                          prd.Active
                      };
            gridControl_ContractTypeList.DataSource = SUS;

            gridView_ContractTypeList.UnselectRow(gridView_ContractTypeList.FocusedRowHandle);
            gridView_ContractTypeList.SelectRow(RowFocus);
            gridView_ContractTypeList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ContractTypeList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_ContractTypeList.OptionsView.ShowAutoFilterRow = !gridView_ContractTypeList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ContractTypeList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddContractType_Click(object sender, EventArgs e)
        {
            int Index = gridView_ContractTypeList.FocusedRowHandle;

            ContractTypeNE_frm Uc = new ContractTypeNE_frm(true, 0);
            Uc.ShowDialog();
            ShowListContractType(gridView_ContractTypeList.RowCount);
        }

        private void buttonItemEditContractType_Click(object sender, EventArgs e)
        {
            if (gridView_ContractTypeList.RowCount == 0) return;

            int Index = gridView_ContractTypeList.FocusedRowHandle;

            ContractTypeNE_frm Uc = new ContractTypeNE_frm(false,
                Convert.ToInt32(gridView_ContractTypeList.GetRowCellValue(Index, "ContractTypeId")));
            Uc.ShowDialog();
            ShowListContractType(Index);
        }

        private void buttonItemDelContractType_Click(object sender, EventArgs e)
        {

            if (gridView_ContractTypeList.RowCount == 0) return;
            int Index = gridView_ContractTypeList.FocusedRowHandle;
            int _contractTypeId = Convert.ToInt32(gridView_ContractTypeList.GetRowCellValue(Index, "ContractTypeId"));

            if (!DCMDC.CheckContractType(_contractTypeId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این نوع قرارداد به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این نوع قرارداد حذف شود؟")) return;
            TBL_ContractType thsf = DCMDC.TBL_ContractTypes.First(hf => hf.ContractTypeId.Equals(_contractTypeId));
            DCMDC.TBL_ContractTypes.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListContractType(Index - 1);
        }


    }
}
