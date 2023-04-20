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
    public partial class DrugsList_Frm : Form
    {

        public DrugsList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void DrugsList_Frm_Load(object sender, EventArgs e)
        {
            ShowListDrugs(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddDrugs.Name)) buttonItemAddDrugs.Enabled = false;
                if (UPer.Contains(buttonItemEditDrugs.Name)) buttonItemEditDrugs.Enabled = false;
                if (UPer.Contains(buttonItemDelDrugs.Name)) buttonItemDelDrugs.Enabled = false;
                if (UPer.Contains(buttonItemDrugsPrintList.Name)) buttonItemDrugsPrintList.Enabled = false;
            }
        }

        private void ShowListDrugs(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_Drugs
                      select new
                      {
                          prd.DrugsId,
                          prd.DrugsName,
                      };
            gridControl_DrugsList.DataSource = SUS;

            gridView_DrugsList.UnselectRow(gridView_DrugsList.FocusedRowHandle);
            gridView_DrugsList.SelectRow(RowFocus);
            gridView_DrugsList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_DrugsList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_DrugsList.OptionsView.ShowAutoFilterRow = !gridView_DrugsList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_DrugsList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddDrugs_Click(object sender, EventArgs e)
        {
            int Index = gridView_DrugsList.FocusedRowHandle;

            DrugsNE_Frm Uc = new DrugsNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListDrugs(gridView_DrugsList.RowCount);
        }

        private void buttonItemEditDrugs_Click(object sender, EventArgs e)
        {
            if (gridView_DrugsList.RowCount == 0) return;

            int Index = gridView_DrugsList.FocusedRowHandle;

            DrugsNE_Frm Uc = new DrugsNE_Frm(false,
                Convert.ToInt32(gridView_DrugsList.GetRowCellValue(Index, "DrugsId")));
            Uc.ShowDialog();
            ShowListDrugs(Index);
        }

        private void buttonItemDelDrugs_Click(object sender, EventArgs e)
        {

            if (gridView_DrugsList.RowCount == 0) return;
            int Index = gridView_DrugsList.FocusedRowHandle;
            int _DrugsId = Convert.ToInt32(gridView_DrugsList.GetRowCellValue(Index, "DrugsId"));

            if (!DCMDC.CheckDrugs(_DrugsId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این دارو به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این دارو حذف شود؟")) return;
            TBL_Drug thsf = DCMDC.TBL_Drugs.First(hf => hf.DrugsId.Equals(_DrugsId));
            DCMDC.TBL_Drugs.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListDrugs(Index - 1);
        }


    }
}
