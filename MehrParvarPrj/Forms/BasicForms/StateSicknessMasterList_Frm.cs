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
    public partial class StateSicknessMasterList_Frm : Form
    {

        public StateSicknessMasterList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void StateSicknessMasterList_Frm_Load(object sender, EventArgs e)
        {
            ShowListStateSicknessMaster(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddStateSicknessMaster.Name)) buttonItemAddStateSicknessMaster.Enabled = false;
                if (UPer.Contains(buttonItemEditStateSicknessMaster.Name)) buttonItemEditStateSicknessMaster.Enabled = false;
                if (UPer.Contains(buttonItemDelStateSicknessMaster.Name)) buttonItemDelStateSicknessMaster.Enabled = false;
                if (UPer.Contains(buttonItemStateSicknessMasterPrintList.Name)) buttonItemStateSicknessMasterPrintList.Enabled = false;
            }
        }

        private void ShowListStateSicknessMaster(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_StateSicknessMasters
                      select new
                      {
                          prd.Id,
                          prd.StateSicknessMasterName,
                      };
            gridControl_StateSicknessMasterList.DataSource = SUS;

            gridView_StateSicknessMasterList.UnselectRow(gridView_StateSicknessMasterList.FocusedRowHandle);
            gridView_StateSicknessMasterList.SelectRow(RowFocus);
            gridView_StateSicknessMasterList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_StateSicknessMasterList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_StateSicknessMasterList.OptionsView.ShowAutoFilterRow = !gridView_StateSicknessMasterList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_StateSicknessMasterList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddStateSicknessMaster_Click(object sender, EventArgs e)
        {
            int Index = gridView_StateSicknessMasterList.FocusedRowHandle;

            StateSicknessMasterNE_Frm Uc = new StateSicknessMasterNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListStateSicknessMaster(gridView_StateSicknessMasterList.RowCount);
        }

        private void buttonItemEditStateSicknessMaster_Click(object sender, EventArgs e)
        {
            if (gridView_StateSicknessMasterList.RowCount == 0) return;

            int Index = gridView_StateSicknessMasterList.FocusedRowHandle;

            StateSicknessMasterNE_Frm Uc = new StateSicknessMasterNE_Frm(false,
                Convert.ToInt32(gridView_StateSicknessMasterList.GetRowCellValue(Index, "Id")));
            Uc.ShowDialog();
            ShowListStateSicknessMaster(Index);
        }

        private void buttonItemDelStateSicknessMaster_Click(object sender, EventArgs e)
        {

            if (gridView_StateSicknessMasterList.RowCount == 0) return;
            int Index = gridView_StateSicknessMasterList.FocusedRowHandle;
            int _StateSicknessMasterId = Convert.ToInt32(gridView_StateSicknessMasterList.GetRowCellValue(Index, "Id"));

            if (!DCMDC.CheckStateSicknessMaster(_StateSicknessMasterId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این بیماری به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این عنوان کلی بیماری حذف شود؟")) return;
            TBL_StateSicknessMaster thsf = DCMDC.TBL_StateSicknessMasters.First(hf => hf.Id.Equals(_StateSicknessMasterId));
            DCMDC.TBL_StateSicknessMasters.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListStateSicknessMaster(Index - 1);
        }


    }
}
