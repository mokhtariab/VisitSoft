using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.Properties;
using MehrParvarPrj.DataLinq;
using System.IO;

namespace MehrParvarPrj
{
    public partial class MartyrsList_UC : UserControl
    {
        public MartyrsList_UC()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load & UI

        private void MartyrsList_UC_Load(object sender, EventArgs e)
        {
            ShowListMartyrs(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItem_MartyrsNew.Name)) buttonItem_MartyrsNew.Enabled = false;
                if (UPer.Contains(buttonItemMartyrsEdit.Name)) buttonItemMartyrsEdit.Enabled = false;
                if (UPer.Contains(buttonItemMartyrsDel.Name)) buttonItemMartyrsDel.Enabled = false;
                if (UPer.Contains(buttonItemMartyrsPrintList.Name)) buttonItemMartyrsPrintList.Enabled = false;
                if (UPer.Contains(buttonItemExcelExportMartyr.Name)) buttonItemExcelExportMartyr.Enabled = false;
            }

            //codeing
            //if (!Global_Cls.SoftwareCode.Contains("+S"))
            //{
            //    buttonItemMartyrsSMSEmail.Enabled = false;
            //}
            //codeing
        }

        private void MartyrsList_UC_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                ShowListMartyrs(gridView_MartyrsList.RowCount);
            }
            catch { }

        }


        #endregion


        #region Search
        private void ShowListMartyrs(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_Martyrs
                      select new
                      {
                          prd.MartyrId,
                          prd.MartyrNameFamily,
                          prd.MartyrFew,

                          prd.DosiersNo1,
                          prd.DosiersNo2,
                          prd.DosiersNo3,

                          prd.NationalCode1,
                          prd.NationalCode2,
                          prd.NationalCode3,

                          BrithDate1 = Global_Cls.MiladiDateToShamsi(prd.BrithDate1.Value),
                          BrithDate2 = Global_Cls.MiladiDateToShamsi(prd.BrithDate2.Value),
                          BrithDate3 = Global_Cls.MiladiDateToShamsi(prd.BrithDate3.Value),

                          MartyrDate1 = Global_Cls.MiladiDateToShamsi(prd.MartyrDate1.Value),
                          MartyrDate2 = Global_Cls.MiladiDateToShamsi(prd.MartyrDate2.Value),
                          MartyrDate3 = Global_Cls.MiladiDateToShamsi(prd.MartyrDate3.Value),

                          prd.MartyrName1,
                          prd.MartyrName2,
                          prd.MartyrName3,

                          prd.MartyrLocation1,
                          prd.MartyrLocation2,
                          prd.MartyrLocation3,

                          prd.Description

                      };
            gridControl_MartyrsList.DataSource = SUS;


            gridView_MartyrsList.UnselectRow(gridView_MartyrsList.FocusedRowHandle);
            gridView_MartyrsList.SelectRow(RowFocus);
            gridView_MartyrsList.FocusedRowHandle = RowFocus;
        }

       

        #endregion


        #region All Buttons

        private void buttonItem_MartyrsNew_Click(object sender, EventArgs e)
        {
            MartyrsNE_frm Uc = new MartyrsNE_frm();
            Uc.ShowDialog();
            ShowListMartyrs(gridView_MartyrsList.RowCount);
        }

        private void buttonItemMartyrsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView_MartyrsList.RowCount == 0) return;

                int Index = gridView_MartyrsList.FocusedRowHandle;

                MartyrsNE_frm Uc = new MartyrsNE_frm(Convert.ToInt32(gridView_MartyrsList.GetRowCellValue(Index, "MartyrId")));
                Uc.ShowDialog();
                ShowListMartyrs(Index);
            }
            catch { }
        }

        private void buttonItemMartyrsDel_Click(object sender, EventArgs e)
        {
            if (gridView_MartyrsList.RowCount == 0) return;
            int Index = gridView_MartyrsList.FocusedRowHandle;
            int OpCode = Convert.ToInt32(gridView_MartyrsList.GetRowCellValue(Index, "MartyrId"));

            if (!DCMDC.CheckMartyrs(OpCode).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " این خانواده در سیستم فعال می باشد. درنتیجه امکان حذف وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این خانواده حذف شود؟")) return;
            TBL_Martyr thsf = DCMDC.TBL_Martyrs.First(hf => hf.MartyrId.Equals(OpCode));
            DCMDC.TBL_Martyrs.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListMartyrs(Index - 1);
        }

        private void buttonItemMartyrsSearch_Click(object sender, EventArgs e)
        {
            gridView_MartyrsList.OptionsView.ShowAutoFilterRow = !gridView_MartyrsList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_MartyrsList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemMartyrsPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_MartyrsList);
            PP.ShowDialog();
        }

        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            ShowListMartyrs(gridView_MartyrsList.FocusedRowHandle);
        }
        

        #endregion

        private void buttonItemExcelExportMartyr_Click(object sender, EventArgs e)
        {
            Function_Cls.ExportExcelGrid(gridControl_MartyrsList);
        }

      

    }
}
