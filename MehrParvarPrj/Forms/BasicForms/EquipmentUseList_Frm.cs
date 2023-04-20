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
    public partial class EquipmentUseList_Frm : Form
    {

        public EquipmentUseList_Frm()
        {
            InitializeComponent();
        }

        DataClassesSecondDataContext DCMDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        
        private void EquipmentUseList_Frm_Load(object sender, EventArgs e)
        {
            ShowListEquipmentUse(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddEquipmentUse.Name)) buttonItemAddEquipmentUse.Enabled = false;
                if (UPer.Contains(buttonItemEditEquipmentUse.Name)) buttonItemEditEquipmentUse.Enabled = false;
                if (UPer.Contains(buttonItemDelEquipmentUse.Name)) buttonItemDelEquipmentUse.Enabled = false;
                if (UPer.Contains(buttonItemEquipmentUsePrintList.Name)) buttonItemEquipmentUsePrintList.Enabled = false;
            }
        }

        private void ShowListEquipmentUse(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_EquipmentUses
                      select new
                      {
                          prd.Id,
                          prd.TitleName,
                      };
            gridControl_EquipmentUseList.DataSource = SUS;

            gridView_EquipmentUseList.UnselectRow(gridView_EquipmentUseList.FocusedRowHandle);
            gridView_EquipmentUseList.SelectRow(RowFocus);
            gridView_EquipmentUseList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_EquipmentUseList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_EquipmentUseList.OptionsView.ShowAutoFilterRow = !gridView_EquipmentUseList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_EquipmentUseList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddEquipmentUse_Click(object sender, EventArgs e)
        {
            int Index = gridView_EquipmentUseList.FocusedRowHandle;

            EquipmentUseNE_Frm Uc = new EquipmentUseNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListEquipmentUse(gridView_EquipmentUseList.RowCount);
        }

        private void buttonItemEditEquipmentUse_Click(object sender, EventArgs e)
        {
            if (gridView_EquipmentUseList.RowCount == 0) return;

            int Index = gridView_EquipmentUseList.FocusedRowHandle;

            EquipmentUseNE_Frm Uc = new EquipmentUseNE_Frm(false,
                Convert.ToInt32(gridView_EquipmentUseList.GetRowCellValue(Index, "Id")));
            Uc.ShowDialog();
            ShowListEquipmentUse(Index);
        }

        private void buttonItemDelEquipmentUse_Click(object sender, EventArgs e)
        {

            if (gridView_EquipmentUseList.RowCount == 0) return;
            int Index = gridView_EquipmentUseList.FocusedRowHandle;
            int _EquipmentUseId = Convert.ToInt32(gridView_EquipmentUseList.GetRowCellValue(Index, "Id"));

            if (!DCMDC.CheckEquipmentUse(_EquipmentUseId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این تجهیزات مصرفی به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این تجهیزات مصرفی حذف شود؟")) return;
            TBL_EquipmentUse thsf = DCMDC.TBL_EquipmentUses.First(hf => hf.Id.Equals(_EquipmentUseId));
            DCMDC.TBL_EquipmentUses.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListEquipmentUse(Index - 1);
        }


    }
}
