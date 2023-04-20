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
    public partial class InjuryTypeList_Frm : Form
    {

        public InjuryTypeList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void InjuryTypeList_Frm_Load(object sender, EventArgs e)
        {
            ShowListInjuryType(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddInjuryType.Name)) buttonItemAddInjuryType.Enabled = false;
                if (UPer.Contains(buttonItemEditInjuryType.Name)) buttonItemEditInjuryType.Enabled = false;
                if (UPer.Contains(buttonItemDelInjuryType.Name)) buttonItemDelInjuryType.Enabled = false;
                if (UPer.Contains(buttonItemInjuryTypePrintList.Name)) buttonItemInjuryTypePrintList.Enabled = false;
            }
        }

        private void ShowListInjuryType(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_InjuryTypes
                      select new
                      {
                          prd.InjuryTypeId,
                          prd.InjuryTypeDsc,
                      };
            gridControl_InjuryTypeList.DataSource = SUS;

            gridView_InjuryTypeList.UnselectRow(gridView_InjuryTypeList.FocusedRowHandle);
            gridView_InjuryTypeList.SelectRow(RowFocus);
            gridView_InjuryTypeList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_InjuryTypeList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_InjuryTypeList.OptionsView.ShowAutoFilterRow = !gridView_InjuryTypeList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_InjuryTypeList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddInjuryType_Click(object sender, EventArgs e)
        {
            int Index = gridView_InjuryTypeList.FocusedRowHandle;

            InjuryTypeNE_Frm Uc = new InjuryTypeNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListInjuryType(gridView_InjuryTypeList.RowCount);
        }

        private void buttonItemEditInjuryType_Click(object sender, EventArgs e)
        {
            if (gridView_InjuryTypeList.RowCount == 0) return;

            int Index = gridView_InjuryTypeList.FocusedRowHandle;

            InjuryTypeNE_Frm Uc = new InjuryTypeNE_Frm(false,
                Convert.ToInt32(gridView_InjuryTypeList.GetRowCellValue(Index, "InjuryTypeId")));
            Uc.ShowDialog();
            ShowListInjuryType(Index);
        }

        private void buttonItemDelInjuryType_Click(object sender, EventArgs e)
        {

            if (gridView_InjuryTypeList.RowCount == 0) return;
            int Index = gridView_InjuryTypeList.FocusedRowHandle;
            int _InjuryTypeId = Convert.ToInt32(gridView_InjuryTypeList.GetRowCellValue(Index, "InjuryTypeId"));

            if (!DCMDC.CheckInjuryType(_InjuryTypeId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این نوع مجروحیت به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این نوع مجروحیت حذف شود؟")) return;
            TBL_InjuryType thsf = DCMDC.TBL_InjuryTypes.First(hf => hf.InjuryTypeId.Equals(_InjuryTypeId));
            DCMDC.TBL_InjuryTypes.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListInjuryType(Index - 1);
        }


    }
}
