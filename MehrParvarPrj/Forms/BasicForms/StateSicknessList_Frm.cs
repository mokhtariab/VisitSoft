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
    public partial class StateSicknessList_Frm : Form
    {

        public StateSicknessList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void StateSicknessList_Frm_Load(object sender, EventArgs e)
        {
            ShowListStateSickness(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddStateSickness.Name)) buttonItemAddStateSickness.Enabled = false;
                if (UPer.Contains(buttonItemEditStateSickness.Name)) buttonItemEditStateSickness.Enabled = false;
                if (UPer.Contains(buttonItemDelStateSickness.Name)) buttonItemDelStateSickness.Enabled = false;
                if (UPer.Contains(buttonItemStateSicknessPrintList.Name)) buttonItemStateSicknessPrintList.Enabled = false;
            }
        }

        private void ShowListStateSickness(int RowFocus)
        {
            var SUS = from prd in DCMDC.VW_StateSicknesses
                      select new
                      {
                          prd.StateSicknessId,
                          prd.StateSicknessMasterName,
                          prd.StateSicknessName,
                      };
            gridControl_StateSicknessList.DataSource = SUS;

            gridView_StateSicknessList.UnselectRow(gridView_StateSicknessList.FocusedRowHandle);
            gridView_StateSicknessList.SelectRow(RowFocus);
            gridView_StateSicknessList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_StateSicknessList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_StateSicknessList.OptionsView.ShowAutoFilterRow = !gridView_StateSicknessList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_StateSicknessList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddStateSickness_Click(object sender, EventArgs e)
        {
            int Index = gridView_StateSicknessList.FocusedRowHandle;

            StateSicknessNE_Frm Uc = new StateSicknessNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListStateSickness(gridView_StateSicknessList.RowCount);
        }

        private void buttonItemEditStateSickness_Click(object sender, EventArgs e)
        {
            if (gridView_StateSicknessList.RowCount == 0) return;

            int Index = gridView_StateSicknessList.FocusedRowHandle;

            StateSicknessNE_Frm Uc = new StateSicknessNE_Frm(false,
                Convert.ToInt32(gridView_StateSicknessList.GetRowCellValue(Index, "StateSicknessId")));
            Uc.ShowDialog();
            ShowListStateSickness(Index);
        }

        private void buttonItemDelStateSickness_Click(object sender, EventArgs e)
        {

            if (gridView_StateSicknessList.RowCount == 0) return;
            int Index = gridView_StateSicknessList.FocusedRowHandle;
            int _StateSicknessId = Convert.ToInt32(gridView_StateSicknessList.GetRowCellValue(Index, "StateSicknessId"));

            if (!DCMDC.CheckStateSickness(_StateSicknessId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این بیماری به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این وضعیت بیماری حذف شود؟")) return;
            TBL_StateSickness thsf = DCMDC.TBL_StateSicknesses.First(hf => hf.StateSicknessId.Equals(_StateSicknessId));
            DCMDC.TBL_StateSicknesses.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListStateSickness(Index - 1);
        }


    }
}
