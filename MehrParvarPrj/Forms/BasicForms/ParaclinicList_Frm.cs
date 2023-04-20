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
    public partial class ParaclinicList_Frm : Form
    {

        public ParaclinicList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void ParaclinicList_Frm_Load(object sender, EventArgs e)
        {
            ShowListParaclinic(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddParaclinic.Name)) buttonItemAddParaclinic.Enabled = false;
                if (UPer.Contains(buttonItemEditParaclinic.Name)) buttonItemEditParaclinic.Enabled = false;
                if (UPer.Contains(buttonItemDelParaclinic.Name)) buttonItemDelParaclinic.Enabled = false;
                if (UPer.Contains(buttonItemParaclinicPrintList.Name)) buttonItemParaclinicPrintList.Enabled = false;
            }
        }

        private void ShowListParaclinic(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_Paraclinics
                      select new
                      {
                          prd.ParaclinicId,
                          prd.ParaclinicName,
                      };
            gridControl_ParaclinicList.DataSource = SUS;

            gridView_ParaclinicList.UnselectRow(gridView_ParaclinicList.FocusedRowHandle);
            gridView_ParaclinicList.SelectRow(RowFocus);
            gridView_ParaclinicList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ParaclinicList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_ParaclinicList.OptionsView.ShowAutoFilterRow = !gridView_ParaclinicList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ParaclinicList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddParaclinic_Click(object sender, EventArgs e)
        {
            int Index = gridView_ParaclinicList.FocusedRowHandle;

            ParaclinicNE_Frm Uc = new ParaclinicNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListParaclinic(gridView_ParaclinicList.RowCount);
        }

        private void buttonItemEditParaclinic_Click(object sender, EventArgs e)
        {
            if (gridView_ParaclinicList.RowCount == 0) return;

            int Index = gridView_ParaclinicList.FocusedRowHandle;

            ParaclinicNE_Frm Uc = new ParaclinicNE_Frm(false,
                Convert.ToInt32(gridView_ParaclinicList.GetRowCellValue(Index, "ParaclinicId")));
            Uc.ShowDialog();
            ShowListParaclinic(Index);
        }

        private void buttonItemDelParaclinic_Click(object sender, EventArgs e)
        {

            if (gridView_ParaclinicList.RowCount == 0) return;
            int Index = gridView_ParaclinicList.FocusedRowHandle;
            int _ParaclinicId = Convert.ToInt32(gridView_ParaclinicList.GetRowCellValue(Index, "ParaclinicId"));

            if (!DCMDC.CheckParaclinics(_ParaclinicId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این پاراکلینیک به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این پاراکلینیک حذف شود؟")) return;
            TBL_Paraclinic thsf = DCMDC.TBL_Paraclinics.First(hf => hf.ParaclinicId.Equals(_ParaclinicId));
            DCMDC.TBL_Paraclinics.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListParaclinic(Index - 1);
        }


    }
}
