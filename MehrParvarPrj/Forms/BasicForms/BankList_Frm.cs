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
    public partial class BankList_Frm : Form
    {

        public BankList_Frm()
        {
            InitializeComponent();
        }

        DataClassesSecondDataContext DCMDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        
        private void BankList_Frm_Load(object sender, EventArgs e)
        {
            ShowListBank(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddBank.Name)) buttonItemAddBank.Enabled = false;
                if (UPer.Contains(buttonItemEditBank.Name)) buttonItemEditBank.Enabled = false;
                if (UPer.Contains(buttonItemDelBank.Name)) buttonItemDelBank.Enabled = false;
                if (UPer.Contains(buttonItemBankPrintList.Name)) buttonItemBankPrintList.Enabled = false;
            }
        }

        private void ShowListBank(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_Banks
                      select new
                      {
                          prd.Id,
                          prd.TitleName,
                      };
            gridControl_BankList.DataSource = SUS;

            gridView_BankList.UnselectRow(gridView_BankList.FocusedRowHandle);
            gridView_BankList.SelectRow(RowFocus);
            gridView_BankList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_BankList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_BankList.OptionsView.ShowAutoFilterRow = !gridView_BankList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_BankList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddBank_Click(object sender, EventArgs e)
        {
            int Index = gridView_BankList.FocusedRowHandle;

            BankNE_Frm Uc = new BankNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListBank(gridView_BankList.RowCount);
        }

        private void buttonItemEditBank_Click(object sender, EventArgs e)
        {
            if (gridView_BankList.RowCount == 0) return;

            int Index = gridView_BankList.FocusedRowHandle;

            BankNE_Frm Uc = new BankNE_Frm(false,
                Convert.ToInt32(gridView_BankList.GetRowCellValue(Index, "Id")));
            Uc.ShowDialog();
            ShowListBank(Index);
        }

        private void buttonItemDelBank_Click(object sender, EventArgs e)
        {

            if (gridView_BankList.RowCount == 0) return;
            int Index = gridView_BankList.FocusedRowHandle;
            int _BankId = Convert.ToInt32(gridView_BankList.GetRowCellValue(Index, "Id"));

            if (!DCMDC.CheckBank(_BankId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این بانک به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این بانک حذف شود؟")) return;
            TBL_Bank thsf = DCMDC.TBL_Banks.First(hf => hf.Id.Equals(_BankId));
            DCMDC.TBL_Banks.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListBank(Index - 1);
        }


    }
}
