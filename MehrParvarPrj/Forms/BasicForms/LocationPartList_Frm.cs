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
    public partial class LocationPartList_Frm : Form
    {

        public LocationPartList_Frm()
        {
            InitializeComponent();
        }

        DataClassesSecondDataContext DCMDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        
        private void LocationPartList_Frm_Load(object sender, EventArgs e)
        {
            ShowListLocationPart(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddLocationPart.Name)) buttonItemAddLocationPart.Enabled = false;
                if (UPer.Contains(buttonItemEditLocationPart.Name)) buttonItemEditLocationPart.Enabled = false;
                if (UPer.Contains(buttonItemDelLocationPart.Name)) buttonItemDelLocationPart.Enabled = false;
                if (UPer.Contains(buttonItemLocationPartPrintList.Name)) buttonItemLocationPartPrintList.Enabled = false;
            }
        }

        private void ShowListLocationPart(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_LocationParts
                      select new
                      {
                          prd.Id,
                          prd.TitleName,
                      };
            gridControl_LocationPartList.DataSource = SUS;

            gridView_LocationPartList.UnselectRow(gridView_LocationPartList.FocusedRowHandle);
            gridView_LocationPartList.SelectRow(RowFocus);
            gridView_LocationPartList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_LocationPartList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_LocationPartList.OptionsView.ShowAutoFilterRow = !gridView_LocationPartList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_LocationPartList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddLocationPart_Click(object sender, EventArgs e)
        {
            int Index = gridView_LocationPartList.FocusedRowHandle;

            LocationPartNE_Frm Uc = new LocationPartNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListLocationPart(gridView_LocationPartList.RowCount);
        }

        private void buttonItemEditLocationPart_Click(object sender, EventArgs e)
        {
            if (gridView_LocationPartList.RowCount == 0) return;

            int Index = gridView_LocationPartList.FocusedRowHandle;

            LocationPartNE_Frm Uc = new LocationPartNE_Frm(false,
                Convert.ToInt32(gridView_LocationPartList.GetRowCellValue(Index, "Id")));
            Uc.ShowDialog();
            ShowListLocationPart(Index);
        }

        private void buttonItemDelLocationPart_Click(object sender, EventArgs e)
        {

            if (gridView_LocationPartList.RowCount == 0) return;
            int Index = gridView_LocationPartList.FocusedRowHandle;
            int _LocationPartId = Convert.ToInt32(gridView_LocationPartList.GetRowCellValue(Index, "Id"));

            if (!DCMDC.CheckLocationPart(_LocationPartId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این منطقه به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این منطقه حذف شود؟")) return;
            TBL_LocationPart thsf = DCMDC.TBL_LocationParts.First(hf => hf.Id.Equals(_LocationPartId));
            DCMDC.TBL_LocationParts.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListLocationPart(Index - 1);
        }


    }
}
