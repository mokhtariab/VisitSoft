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

namespace MehrParvarPrj
{
    public partial class ListPatientVisitReport_frm : Form
    {
        bool _listOrDelList, _allListOrOne;
        int _patientID = 0, _companyId = 0;
        public ListPatientVisitReport_frm(bool AllListOrOne, bool ListOrDelList, int PatientID, int CompanyId)
        {
            InitializeComponent();
            _listOrDelList = ListOrDelList;
            _allListOrOne = AllListOrOne;
            _patientID = PatientID;
            _companyId = CompanyId;
        }

       bool IsShown = false;

        #region Load & UI
        private void ListPatientVisitReport_frm_Load(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            

            ColumnSelector_Cls.ComboBoxSelectorBind(comboBoxSelector, 5);

            IsShown = true;

            InterFaceChange();
        }


        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemVisitPrintList.Name)) buttonItemVisitPrintList.Enabled = false;
                if (UPer.Contains(buttonItemVisitSMSEmail.Name)) buttonItemVisitSMSEmail.Enabled = false;
                if (UPer.Contains(buttonItemPatientReport.Name)) buttonItemPatientReport.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItemVisitSMSEmail.Enabled = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemPatientReport.Visible = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L2") || Global_Cls.SoftwareCode.Contains("N2")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemPatientReport.Visible = false;
            }
            //codeing

          
            buttonItemPatientReport.Visible = false;
        }


        private void gridView_ListPatVisit_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.GridRowCellState state = ((DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo)e.Cell).State;

            if ((state & DevExpress.XtraGrid.Views.Base.GridRowCellState.Selected) == DevExpress.XtraGrid.Views.Base.GridRowCellState.Selected)
            {
                e.Appearance.BackColor = Color.Navy;
                e.Appearance.ForeColor = Color.White;
                e.Appearance.BorderColor = Color.White;
            }
        }


        #endregion


        #region Search

        

        private void gridView_ListPatVisit_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.RowHandle + 1;
        }

        #endregion


        #region All Buttons

        private void buttonItemCustomSearch_Click(object sender, EventArgs e)
        {
            gridView_ListPatVisit.OptionsView.ShowAutoFilterRow = !gridView_ListPatVisit.OptionsView.ShowAutoFilterRow;
            if (!buttonItemCustomSearch.Checked)
            {
                gridView_ListPatVisit.ActiveFilterString = "";
                gridView_ListPatVisit.ApplyColumnsFilter();
            }
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ListPatVisit.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCustomPrintList_Click(object sender, EventArgs e)
        {
            gridView_ListPatVisit.FormatConditions[0].Appearance.BackColor = Color.White;
            gridView_ListPatVisit.FormatConditions[1].Appearance.BackColor = Color.White;
            gridView_ListPatVisit.FormatConditions[2].Appearance.BackColor = Color.White;

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ListPatVisit);
            PP.ShowDialog();

            gridView_ListPatVisit.FormatConditions[0].Appearance.BackColor = Color.PaleGreen;
            gridView_ListPatVisit.FormatConditions[1].Appearance.BackColor = Color.MistyRose;
            gridView_ListPatVisit.FormatConditions[2].Appearance.BackColor = Color.LightGray;
        }


     



        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItemVisitSMS_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(true, "", gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "Mobile").ToString());
        }

        private void buttonItemVisitEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("", gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "Email").ToString());
        }

        #endregion


        #region Set CheckBox
        private void chkPatientTypeDsc_CheckedChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.CheckBoxChanged(sender, gridView_ListPatVisit);
        }

        private void comboBoxSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.ComboBoxSelectValueChange(comboBoxSelector, panel_Selector);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ColumnSelector_Cls.SaveChange(gridView_ListPatVisit, comboBoxSelector, 5);
        }

        #endregion

        private void buttonItemPatientReport_Click(object sender, EventArgs e)
        {
            Report.Forms.PatientReport PT = new Report.Forms.PatientReport(Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "PatientID")));
                //Convert.ToInt32(gridView_ListPatVisit.GetRowCellValue(gridView_ListPatVisit.FocusedRowHandle, "CompanyId")));
            PrintPreview_frm PP = new PrintPreview_frm(PT);
            PP.ShowDialog();
        }



    }
}
