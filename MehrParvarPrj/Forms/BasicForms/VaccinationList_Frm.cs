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
    public partial class VaccinationList_Frm : Form
    {

        public VaccinationList_Frm()
        {
            InitializeComponent();
        }

        DataClassesSecondDataContext DCMDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        
        private void VaccinationList_Frm_Load(object sender, EventArgs e)
        {
            ShowListVaccination(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddVaccination.Name)) buttonItemAddVaccination.Enabled = false;
                if (UPer.Contains(buttonItemEditVaccination.Name)) buttonItemEditVaccination.Enabled = false;
                if (UPer.Contains(buttonItemDelVaccination.Name)) buttonItemDelVaccination.Enabled = false;
                if (UPer.Contains(buttonItemVaccinationPrintList.Name)) buttonItemVaccinationPrintList.Enabled = false;
            }
        }

        private void ShowListVaccination(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_Vaccinations
                      select new
                      {
                          prd.Id,
                          prd.TitleName,
                      };
            gridControl_VaccinationList.DataSource = SUS;

            gridView_VaccinationList.UnselectRow(gridView_VaccinationList.FocusedRowHandle);
            gridView_VaccinationList.SelectRow(RowFocus);
            gridView_VaccinationList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_VaccinationList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_VaccinationList.OptionsView.ShowAutoFilterRow = !gridView_VaccinationList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_VaccinationList);
            PP.ShowDialog();
        }
        
        private void buttonItemAddVaccination_Click(object sender, EventArgs e)
        {
            int Index = gridView_VaccinationList.FocusedRowHandle;

            VaccinationNE_Frm Uc = new VaccinationNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListVaccination(gridView_VaccinationList.RowCount);
        }

        private void buttonItemEditVaccination_Click(object sender, EventArgs e)
        {
            if (gridView_VaccinationList.RowCount == 0) return;

            int Index = gridView_VaccinationList.FocusedRowHandle;

            VaccinationNE_Frm Uc = new VaccinationNE_Frm(false,
                Convert.ToInt32(gridView_VaccinationList.GetRowCellValue(Index, "Id")));
            Uc.ShowDialog();
            ShowListVaccination(Index);
        }

        private void buttonItemDelVaccination_Click(object sender, EventArgs e)
        {

            if (gridView_VaccinationList.RowCount == 0) return;
            int Index = gridView_VaccinationList.FocusedRowHandle;
            int _VaccinationId = Convert.ToInt32(gridView_VaccinationList.GetRowCellValue(Index, "Id"));

            if (!DCMDC.CheckVaccination(_VaccinationId).Value)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, " امکان حذف این واکسیناسیون به علت استفاده در سیستم وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این واکسیناسیون حذف شود؟")) return;
            TBL_Vaccination thsf = DCMDC.TBL_Vaccinations.First(hf => hf.Id.Equals(_VaccinationId));
            DCMDC.TBL_Vaccinations.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListVaccination(Index - 1);
        }


    }
}
