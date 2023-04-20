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
    public partial class ListDocPat_UC : UserControl
    {
        public string _listWhereSearch = "";

        public ListDocPat_UC()
        {
            InitializeComponent();
        }

        //new        
        bool _searchAdvanced = false;

        public ListDocPat_UC(bool SearchAdvanced)
        {
            InitializeComponent();
            _searchAdvanced = true;
            expandablePanel1.Visible = false;
        }
        //new        

        //DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        bool IsShown = false;

        #region Load & UI
        private void ListDocPat_UC_Load(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr); 
            if (!_searchAdvanced)//new
            {
                var SUS = from prd in DCMDC.TBL_Doctors
                          //where prd.DoctorType == 1 && prd.Active == true
                          where prd.Active == true
                          select new
                          {
                              prd.DoctorID,
                              DoctorN = prd.DoctorName + " " + prd.DoctorFamily 
                              //+ "-" + DCMDC.TBL_DoctorTypes.First(h => h.DoctorTypeId == prd.DoctorType).DoctorTypeDsc
                          };
                comboBoxDocHealth1.DisplayMember = "DoctorN";
                comboBoxDocHealth1.ValueMember = "DoctorID";
                comboBoxDocHealth1.DataSource = SUS;

                var SUS01 = from prd in DCMDC.TBL_Doctors
                            //where prd.DoctorType == 1 && prd.Active == true
                            where prd.Active == true
                            select new
                            {
                                prd.DoctorID,
                                DoctorN = prd.DoctorName + " " + prd.DoctorFamily 
                                //+ "-" + DCMDC.TBL_DoctorTypes.First(h => h.DoctorTypeId == prd.DoctorType).DoctorTypeDsc
                            };
                comboBoxDocHealth2.DisplayMember = "DoctorN";
                comboBoxDocHealth2.ValueMember = "DoctorID";
                comboBoxDocHealth2.DataSource = SUS01;
                comboBoxDocHealth2.SelectedValue = -1;


                var SUS4 = from prd in DCMDC.TBL_ContractTypes
                           select new { prd.ContractTypeId, prd.ContractTypeDsc };
                comboBoxContract.DisplayMember = "ContractTypeDsc";
                comboBoxContract.ValueMember = "ContractTypeId";
                comboBoxContract.DataSource = SUS4;
            }

            //var SUS3 = from prd in DCMDC.TBL_Doctors
            //           //where prd.DoctorType == 1 && prd.Active == true
            //           where prd.Active == true
            //           select new
            //           {
            //               prd.DoctorID,
            //               DoctorN = prd.DoctorName + " " + prd.DoctorFamily 
            //               //+ "-" + DCMDC.TBL_DoctorTypes.First(h => h.DoctorTypeId == prd.DoctorType).DoctorTypeDsc
            //           };
            //comboBoxDocHealthSelector.DisplayMember = "DoctorN";
            //comboBoxDocHealthSelector.ValueMember = "DoctorID";
            //comboBoxDocHealthSelector.DataSource = SUS3;

            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddMonths(-1));
            comboBoxYearNVT.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBoxMonthNVT.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBoxDayNVT.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


            ColumnSelector_Cls.ComboBoxSelectorBind(comboBoxSelector, 1);

            IsShown = true;

            InterFaceChange();

            //comboBoxSetValue.SelectedIndex = 0;

            ShowListPatient(-1);
        }

        //private void ComboBoxSelectorBind()
        //{
        //    var SUS = from prd in DCMDC.TBL_FieldSelectors
        //              where prd.FieldSelectType == 1
        //              select new { prd.FieldSelectName, prd.FieldSelectId };
        //    comboBoxSelector.DisplayMember = "FieldSelectName";
        //    comboBoxSelector.ValueMember = "FieldSelectId";
        //    comboBoxSelector.DataSource = SUS;
        //}

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItem_CuPatient.Name)) buttonItem_CuPatient.Enabled = false;
                if (UPer.Contains(buttonItemCustomEdit.Name)) buttonItemCustomEdit.Enabled = false;
                if (UPer.Contains(buttonItemCustomDel.Name)) buttonItemCustomDel.Enabled = false;
                if (UPer.Contains(buttonItemCustomPrintList.Name)) buttonItemCustomPrintList.Enabled = false;
                if (UPer.Contains(buttonItemVisitPat.Name)) buttonItemVisitPat.Enabled = false;
                if (UPer.Contains(buttonItemEditList.Name)) buttonItemEditList.Enabled = false;

                if (UPer.Contains(buttonItemFilePatient.Name)) buttonItemFilePatient.Enabled = false;
                if (UPer.Contains(buttonItemExitDoctors.Name)) buttonItemExitDoctors.Enabled = false;
                if (UPer.Contains(buttonItemPatientSMS.Name)) buttonItemPatientSMS.Enabled = false;
                if (UPer.Contains(buttonItemExcelExportPatientList.Name)) buttonItemExcelExportPatientList.Enabled = false;


                if (UPer.Contains(btnSetDoctor.Name)) btnSetDoctor.Enabled = false;
                if (UPer.Contains(btnSetVisit.Name)) btnSetVisit.Enabled = false;
                if (UPer.Contains(btnSetOneVisit.Name)) btnSetOneVisit.Enabled = false;
                if (UPer.Contains(btnSetTwoVisit.Name)) btnSetTwoVisit.Enabled = false;

                if (UPer.Contains(btnSetValue.Name)) btnSetValue.Enabled = false;
            }

            
            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItemPatientSMSEmail.Enabled = false;
            }

            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemDocPatientReport.Visible = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L3") || Global_Cls.SoftwareCode.Contains("L2") || Global_Cls.SoftwareCode.Contains("N2")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemDocPatientReport.Visible = false;
            }
            //codeing

            buttonItemVisitForDoctors.Visible = false;
        }

        private void SetAlarm()
        {
            //DCMDC.SP_AlarmSetForTBLPatient(Global_Cls.PrvAlarmDayForVisit);
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            nUpDownSetValue.Visible = comboBoxSetValue.SelectedIndex == 4 || comboBoxSetValue.SelectedIndex == 1;
            textBoxSetValue.Visible = comboBoxSetValue.SelectedIndex != 4 && comboBoxSetValue.SelectedIndex != 1;
        }


        private void buttonItemEditList_Click(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn hg in gridView_ListDocPat.Columns)
                hg.OptionsColumn.AllowEdit = false;

            CityPart.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            Address.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            AddressPart.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            TelHome.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            TelBusiness.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            Mobile.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            ParentName.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            IDNO.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            DosiersNo.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            BrithCityName.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            PercentState.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            //KinShipWith.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            WifeSituation.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            ProtectSituation.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            WholeSituation.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            Description.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            PeriodVisit.OptionsColumn.AllowEdit = buttonItemEditList.Checked;

            Email.OptionsColumn.AllowEdit = buttonItemEditList.Checked;

            NationalCode.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            PatientName.OptionsColumn.AllowEdit = buttonItemEditList.Checked;
            PatientFamily.OptionsColumn.AllowEdit = buttonItemEditList.Checked;

            gridView_ListDocPat.OptionsBehavior.Editable = buttonItemEditList.Checked;
        }

        private void gridView_ListDocPat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            TBL_Patient TP = MHDC.TBL_Patients.First(g => g.PatientID.ToString() == gridView_ListDocPat.GetRowCellValue(e.RowHandle, "PatientID").ToString());
            if (e.Column.FieldName == "Address")
                TP.Address = e.Value.ToString();
            else if (e.Column.Name == "CityPart")
                TP.CityPart = e.Value.ToString();
            else if (e.Column.Name == "AddressPart")
                TP.AddressPart = short.Parse(e.Value.ToString());
            else if (e.Column.Name == "PercentState")
                TP.PercentState = short.Parse(e.Value.ToString());
            else if (e.Column.Name == "PeriodVisit")
                TP.PeriodVisit = short.Parse(e.Value.ToString());

            else if (e.Column.FieldName == "TelHome")
                TP.TelHome = e.Value.ToString();
            else if (e.Column.FieldName == "TelBusiness")
                TP.TelBusiness = e.Value.ToString();
            else if (e.Column.FieldName == "Mobile")
                TP.Mobile = e.Value.ToString();
            else if (e.Column.Name == "ParentName")
                TP.ParentName = e.Value.ToString();
            else if (e.Column.FieldName == "IDNO")
                try { TP.IDNO = e.Value.ToString(); }
                catch { }
            else if (e.Column.Name == "DosiersNo")
                TP.DosiersNo = e.Value.ToString();
            else if (e.Column.Name == "BrithCityName")
                TP.BrithCityName = e.Value.ToString();
            else if (e.Column.Name == "WifeSituation")
                TP.WifeSituation = e.Value.ToString();
            else if (e.Column.Name == "ProtectSituation")
                TP.ProtectSituation = e.Value.ToString();
            else if (e.Column.Name == "WholeSituation")
                TP.WholeSituation = e.Value.ToString();
            else if (e.Column.Name == "Description")
                TP.Description = e.Value.ToString();
            else if (e.Column.Name == "Email")
                TP.Email = e.Value.ToString();

            else if (e.Column.FieldName == "NationalCode")
                try { TP.NationalCode = e.Value.ToString(); }
                catch { }
            else if (e.Column.Name == "PatientName")
                TP.PatientName = e.Value.ToString();
            else if (e.Column.Name == "PatientFamily")
                TP.PatientFamily = e.Value.ToString();

            MHDC.SubmitChanges();
        }

        private void gridView_ListDocPat_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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

        public List<QueryFilter.ExpressionBuilder.Filter> filterPatList;

        private void ShowListPatient(int RowFocus)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (!_searchAdvanced)//new
            {
                gridControl_ListDocPat.DataSource = null;

                //SetAlarm(); //new

                var SUS = from prd in DCMDC.VW_PatientLists
                          select prd;
                gridControl_ListDocPat.DataSource = SUS;

                chkNonDocH_CheckedChanged(this, null);
            }
            else
            {
                string str = "";
                gridControl_ListDocPat.DataSource = GetListByFilter(filterPatList, ref str);
            }

            gridView_ListDocPat.UnselectRow(gridView_ListDocPat.FocusedRowHandle);
            if (RowFocus != -1)
            {
                gridView_ListDocPat.SelectRow(RowFocus);
                gridView_ListDocPat.FocusedRowHandle = RowFocus;
            }
            else
            {
                gridView_ListDocPat.SelectRow(gridView_ListDocPat.RowCount-1);
                gridView_ListDocPat.FocusedRowHandle = gridView_ListDocPat.RowCount - 1;
            }
            gridView_ListDocPat.Focus();
        }

        public List<VW_PatientList> GetListByFilter(List<QueryFilter.ExpressionBuilder.Filter> filterNew, ref string msgRet)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            try
            {
                List<QueryFilter.ExpressionBuilder.Filter> filterNew1 = new List<QueryFilter.ExpressionBuilder.Filter>();
                filterNew1.AddRange(filterNew);
                
                var deleg = QueryFilter.ExpressionBuilder.GetExpression<VW_PatientList>(filterNew).Compile();
                var filteredCollection = (from d in DCMDC.VW_PatientLists select d).Where(deleg);

                filterPatList.AddRange(filterNew1);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        string ActiveFilterStr = " ";
        private void chkNonDocH_CheckedChanged(object sender, EventArgs e)
        {
            if (_searchAdvanced) return;//new

            if (!IsShown) return;
            string rStr = " ";
            try
            {
                rStr = gridView_ListDocPat.ActiveFilterString.Replace(ActiveFilterStr, "");
            }
            catch { rStr = gridView_ListDocPat.ActiveFilterString; }
            try
            {
                if (rStr.Substring(rStr.Length - 4, 4).ToLower().Replace(" ", "") == "and".ToLower())
                    rStr = rStr.Remove(rStr.Length - 4);

                if (rStr.Substring(1, 4).ToLower().Replace(" ", "") == "and".ToLower())
                    rStr = rStr.Remove(1, 4);

                if (rStr.Substring(rStr.Length - 3, 3).ToLower().Replace(" ", "") == "or".ToLower())
                    rStr = rStr.Remove(rStr.Length - 3);

                if (rStr.Substring(1, 3).ToLower().Replace(" ", "") == "or".ToLower())
                    rStr = rStr.Remove(1, 3);
            }
            catch { }
            ActiveFilterStr = " ";

            if (RadioButtonDosiers.Checked)
            {
                ActiveFilterStr = " 1<>1 ";
                for (int i = 0; i < textBoxDosiersSearch.Lines.Count(); i++)
                    ActiveFilterStr += " or DosiersNo = '" + textBoxDosiersSearch.Lines[i] + "' ";
                if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            }

            if (RadioButtonAddress.Checked)
            {
                ActiveFilterStr = " 1<>1 ";
                for (int i = 0; i < textBoxAddressSearch.Lines.Count(); i++)
                    if (textBoxAddressSearch.Lines[i] != "")
                        ActiveFilterStr += " or replace([Address],' ','') like '%" + textBoxAddressSearch.Lines[i].Replace(" ", "") + "%' ";
                if (ActiveFilterStr == " 1<>1 ") ActiveFilterStr = "";
            }

            if (RadioButtonWithDocH.Checked)
            {
                ActiveFilterStr = " 1<>1 ";
                if (comboBoxDocHealth1.Text != "")
                    ActiveFilterStr += " or LastDocHealthId = " + comboBoxDocHealth1.SelectedValue.ToString();
                if (comboBoxDocHealth2.Text != "")
                    ActiveFilterStr += " or LastDocHealthId = " + comboBoxDocHealth2.SelectedValue.ToString();
                //ActiveFilterStr += " ) ";
            }
            if (RadioButtonWithParts.Checked)
            {
                ActiveFilterStr = " 1<>1 or AddressPart = " + nUpDownPart1.Value.ToString();
                if (nUpDownPart2.Text != "0")
                    ActiveFilterStr += " or AddressPart = " + nUpDownPart2.Value.ToString();
                //ActiveFilterStr += " ) ";
            }

            if (RadioButtonWithContract.Checked)
                ActiveFilterStr = " (ContractTypeId = " + comboBoxContract.SelectedValue.ToString() + " ) ";

            if (RadioButtonAlarm.Checked)
                ActiveFilterStr = " (StatusVisit = 1) ";

            if (RadioButtonEven.Checked)
                ActiveFilterStr = " (BonyadAddEven = 0) ";

            if (RadioButtonADD.Checked)
                ActiveFilterStr = " (BonyadAddEven = 1) ";

            if (RadioButtonNoVisitInTime.Checked) 
                try
            {
                DateTime D1 = Global_Cls.ShamsiDateToMiladi(comboBoxYearNVT.Text, comboBoxMonthNVT.Text, comboBoxDayNVT.Text);
                ActiveFilterStr = " LastOverhalDateMiladi <= #" + D1.ToShortDateString() + "# ";
            }
            catch { }

            gridView_ListDocPat.ActiveFilterString = ActiveFilterStr;
            ActiveFilterStr = gridView_ListDocPat.ActiveFilterString;
            if (rStr == " ") rStr = "";
            if (ActiveFilterStr == " ") ActiveFilterStr = "";
            if (rStr != "" && ActiveFilterStr != "") gridView_ListDocPat.ActiveFilterString += " and " + rStr;
            else if (rStr != "" && ActiveFilterStr == "") gridView_ListDocPat.ActiveFilterString = rStr;
            gridView_ListDocPat.ApplyColumnsFilter();


            gridView_ListDocPat.UnselectRow(gridView_ListDocPat.FocusedRowHandle);
            gridView_ListDocPat.SelectRow(gridView_ListDocPat.RowCount - 1);
            gridView_ListDocPat.FocusedRowHandle = gridView_ListDocPat.RowCount - 1;
        }



        #endregion


        #region All Buttons

        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            ShowListPatient(gridView_ListDocPat.FocusedRowHandle);

            if (_searchAdvanced) return; //new


            //var SUS3 = from prd in DCMDC.TBL_Doctors
            //           //where prd.DoctorType == 1 && prd.Active == true
            //           where prd.Active == true
            //           select new
            //           {
            //               prd.DoctorID,
            //               DoctorN = prd.DoctorName + " " + prd.DoctorFamily
            //               //+ "-" + DCMDC.TBL_DoctorTypes.First(h => h.DoctorTypeId == prd.DoctorType).DoctorTypeDsc
            //           };
            //comboBoxDocHealthSelector.DisplayMember = "DoctorN";
            //comboBoxDocHealthSelector.ValueMember = "DoctorID";
            //comboBoxDocHealthSelector.DataSource = SUS3;

        }

        private void buttonItemCustomSearch_Click(object sender, EventArgs e)
        {
            gridView_ListDocPat.OptionsView.ShowAutoFilterRow = !gridView_ListDocPat.OptionsView.ShowAutoFilterRow;

            if (_searchAdvanced) return; //new

            if (!buttonItemCustomSearch.Checked)
            {
                gridView_ListDocPat.ActiveFilterString = ActiveFilterStr;
                gridView_ListDocPat.ApplyColumnsFilter();
            }
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ListDocPat.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCustomPrintList_Click(object sender, EventArgs e)
        {
            try
            {
                gridView_ListDocPat.FormatConditions[0].Appearance.BackColor = Color.White;
 
                PrintPreview_frm PP = new PrintPreview_frm(gridControl_ListDocPat);
                PP.ShowDialog();

                gridView_ListDocPat.FormatConditions[0].Appearance.BackColor = Color.LightSteelBlue;
            }
            catch { }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i;
            short DocHealthSelectID = short.Parse(textBoxDoctorName.Tag.ToString());
            //string Tekrariha = "";
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید پزشک بیماران انتخابی به " + textBoxDoctorName.Text + " تغییر یابد؟ "))
            {
                DataClasses_MainDataContext Dselect = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

                for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
                {
                    PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));

                    try
                    {
                        TBL_Patient TP = Dselect.TBL_Patients.First(hj => hj.PatientID == PatientIDSet);
                        TP.LastDocHealthId = DocHealthSelectID;
                        Dselect.SubmitChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                }

                //if (Tekrariha != "")
                //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, false, "موارد ثبت گردید به غیر از تکراری ها که در لیست آمده است", "شماره پرونده ها:" + Tekrariha);
                try
                {
                    ShowListPatient(Index[i - 1]);
                }
                catch { }
            }
        }


        private void buttonItem_CuPatient_Click(object sender, EventArgs e)
        {
            PatientNE_frm Uc = new PatientNE_frm(true, 1, 0, true);
            Uc.ShowDialog();
            ShowListPatient(gridView_ListDocPat.RowCount);
        }


        private void buttonItemCustomEdit_Click(object sender, EventArgs e)
        {
            if (gridView_ListDocPat.RowCount == 0) return;
            int Index = gridView_ListDocPat.FocusedRowHandle;

            PatientNE_frm Uc = new PatientNE_frm(false, 0, Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index, "PatientID")), true);
            Uc.ShowDialog();
            ShowListPatient(Index);
        }


        private void buttonItemDel1_Click(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (gridView_ListDocPat.RowCount == 0) return;
            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید مشخصات این بیمار(ان) بایگانی شود؟")) return;

            int[] Index = gridView_ListDocPat.GetSelectedRows();
            for (int i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
            {
                DCMDC.SP_InsDelRecordMehrParvar(Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID")), true, (sender as DevComponents.DotNetBar.ButtonItem).Text);
                DCMDC.SubmitChanges();
            }

            ShowListPatient(Index[0]);
        }

        private void gridView_ListDocPat_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.RowHandle + 1;
        }


        private void panel_VisitDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthCD.Text) > 6 && Convert.ToInt16(comboBox_DayCD.Text) == 31) comboBox_DayCD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthCD.Text) == 12 && (Convert.ToInt16(comboBox_DayCD.Text) == 31 || Convert.ToInt16(comboBox_DayCD.Text) == 30)) comboBox_DayCD.Text = "29";
        }

        private void btnSetVisit_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i, DoctorIDSet;
            string CopyStr = "", PatientDuplicate = "", DosiersNoSet, PatientNameFamily;
            int? RetValue = 0; 
            short BonyadAddEvenSet = 0;
            DateTime _lastOverhalDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید ویزیت بیماران انتخابی ثبت شود؟ "))
            {

                for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
                {
                    PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));
                    DoctorIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "LastDocHealthId"));
                    DosiersNoSet = gridView_ListDocPat.GetRowCellValue(Index[i], "DosiersNo").ToString();
                    BonyadAddEvenSet = Convert.ToInt16(gridView_ListDocPat.GetRowCellValue(Index[i], "BonyadAddEven"));
                    PatientNameFamily = gridView_ListDocPat.GetRowCellValue(Index[i], "PatientName").ToString() + " " + gridView_ListDocPat.GetRowCellValue(Index[i], "PatientFamily").ToString();

                    try
                    {
                        MHDC.SP_InsertPatientVisit(PatientIDSet, false, DoctorIDSet, true, _lastOverhalDate, 0, false, "", "", "", BonyadAddEvenSet, "در انتظار تایید", ref RetValue);
                        if (RetValue.Value == 0)
                        {
                            //if (gridView_ListDocPat.SelectedRowsCount == 1)
                            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در ماه درخواستی ویزیت جهت بیمار مذکور ثبت شده است");
                            //else
                            CopyStr += PatientNameFamily + ",  ";
                        }
                    }
                    catch
                    {
                        PatientDuplicate += DosiersNoSet.ToString() + "     ";
                    }
                }

                if (CopyStr != "")
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, "ویزیت جهت بیمار(ان) ذیل در ماه درخواستی قبلا ثبت شده است", CopyStr);
                else
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, false, "آخرین تاریخ و ویزیت بیمار(ان) انتخابی ثبت گردید");

                ShowListPatient(Index[i - 1]);
            }
        }

        //public void InsertToPtVisit(int patientID, int doctorID)
        //{
        //    DataClassesSecondDataContext DCMD1 = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        //    try
        //    {
        //        int g = (from fg in DCMD1.TBL_PatientVisits
        //                 where fg.PatientID == patientID &&
        //                     fg.VisitDate == Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text)
        //                 select fg.VisitCode).Count();
        //        if (g > 0) return;
        //    }
        //    catch { }

        //    TBL_PatientVisit tbhc = new TBL_PatientVisit();

        //    tbhc.PatientID = patientID;
        //    int f = 1;
        //    try
        //    {
        //        f = (from fg in DCMD1.TBL_PatientVisits where fg.PatientID == patientID select fg.VisitCode).Max() + 1;
        //    }
        //    catch { f = 1; }

        //    tbhc.VisitCode = f;
        //    tbhc.ForceVisit = false;

        //    tbhc.VisitDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
        //    tbhc.DoctorID = doctorID;
        //    tbhc.CostDoctor = 0;

        //    tbhc.Paraclinic = false;
        //    tbhc.StateSicknessMaster = false;
        //    tbhc.EquipmentUseHistory = false;
        //    tbhc.Bedsore = false;


        //    tbhc.PatientStateDsc = "";
        //    tbhc.VisitOK = true;
        //    DCMD1.TBL_PatientVisits.InsertOnSubmit(tbhc);
        //    DCMD1.SubmitChanges();
        //}

        private void buttonItemVisitPat_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = gridView_ListDocPat.FocusedRowHandle;

                ListPatientVisit_UC Uc = new ListPatientVisit_UC(false, true, Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index, "PatientID")));
                Global_Cls.MainForm.AddTabToTabControl("ListPatientVisit" + gridView_ListDocPat.GetRowCellValue(Index, "PatientID"),
                    "پرونده " + gridView_ListDocPat.GetRowCellValue(Index, "PatientName").ToString() + " " + gridView_ListDocPat.GetRowCellValue(Index, "PatientFamily").ToString(), Uc);
            }
            catch { }
        }


        private void buttonSetValue_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i;

            string Tekrariha = "";

            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مقدارهای انتخابی ثبت شوند؟"))
            {
                for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
                {
                    PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));
                    try
                    {
                        TBL_Patient TP = MHDC.TBL_Patients.First(hj => hj.PatientID == PatientIDSet);

                        if (comboBoxSetValue.SelectedIndex == 0)
                            TP.WifeSituation = textBoxSetValue.Text;
                        else if (comboBoxSetValue.SelectedIndex == 1)
                            TP.AddressPart = short.Parse(nUpDownSetValue.Value.ToString());
                        else if (comboBoxSetValue.SelectedIndex == 2)
                            TP.CityPart = textBoxSetValue.Text;
                        else if (comboBoxSetValue.SelectedIndex == 3)
                            TP.Email = textBoxSetValue.Text;
                        else if (comboBoxSetValue.SelectedIndex == 4)
                            TP.PercentState = short.Parse(nUpDownSetValue.Value.ToString());
                        else if (comboBoxSetValue.SelectedIndex == 5)
                            TP.Description = textBoxSetValue.Text;
                        else if (comboBoxSetValue.SelectedIndex == 6)
                            TP.BasicInsurance = textBoxSetValue.Text;
                        else if (comboBoxSetValue.SelectedIndex == 7)
                            TP.CompletionInsurance = textBoxSetValue.Text;

                        MHDC.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        //if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        //    Tekrariha += gridView_ListDocPat.GetRowCellValue(Index[i], "DosiersNo").ToString() + ";  ";
                    }
                }
                //if (Tekrariha != "")
                //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, false, "موارد ثبت گردید به غیر از تکراری ها که در لیست آمده است", "شماره پرونده ها:" + Tekrariha);

                ShowListPatient(Index[i - 1]);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            chkNonDocH_CheckedChanged(this, null);
        }

        private void buttonItemPatientSMSList_Click(object sender, EventArgs e)
        {
        }

        private void buttonItemPatientSMS_Click(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            Global_Cls.SendSMS_Advertisment(true, " با سلام و خسته نباشید" + "\r\n" + "بیمار: " +
                gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "PatientName").ToString() + " " +
                gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "PatientFamily").ToString() + ",   " +
                "آدرس: " +
                gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "WifeSituation").ToString() + " " +
                gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "CityPart").ToString() + " " +
                gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "Address").ToString() + ",   " +
                "تلفن منزل:" + gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "TelHome").ToString() + ",   " +
                "موبایل:" + gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "Mobile").ToString() + ",   " +
                "درخواست:" + "\r\n" + " باتشکر شرکت شاهد",
                DCMDC.TBL_Doctors.First(hf => hf.DoctorID.Equals(gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "LastDocHealthId").ToString())).Mobile);
        }

        private void buttonItemPatientEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("", gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "Email").ToString());
        }


        private void buttonItemPatientReport_Click(object sender, EventArgs e)
        {
            Report.Forms.PatientReport PT = new Report.Forms.PatientReport(Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "PatientID")));
            PrintPreview_frm PP = new PrintPreview_frm(PT);
            PP.ShowDialog();
        }

        private void buttonItemExcelExportPatientList_Click(object sender, EventArgs e)
        {
            Function_Cls.ExportExcelGrid(gridControl_ListDocPat);
            comboBoxSelector_SelectedValueChanged(this, null);
        }



        #endregion



        #region Set CheckBox

        private void chkPatientTypeDsc_CheckedChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.CheckBoxChanged(sender, gridView_ListDocPat);
        }

        private void comboBoxSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.ComboBoxSelectValueChange(comboBoxSelector, panel_Selector);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ColumnSelector_Cls.SaveChange(gridView_ListDocPat, comboBoxSelector, 1);
        }

        #endregion

        private void btnSetTwoVisit_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i, DoctorIDSet;
            string CopyStr = "", PatientDuplicate = "", DosiersNoSet = "", SpecialDeases = "", PatientNameFamily = "";
            int? RetValue = 0;
            DateTime _lastOverhalDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید ویزیت بیماران انتخابی به صورت زوج ثبت شوند؟"))
            {

                for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
                {
                    PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));
                    DoctorIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "LastDocHealthId"));
                    DosiersNoSet = gridView_ListDocPat.GetRowCellValue(Index[i], "DosiersNo").ToString();
                    //SpecialDeases = gridView_ListDocPat.GetRowCellValue(Index[0], "NationalCode").ToString() + "-" + Global_Cls.MiladiDateToShamsi(_lastOverhalDate).Replace("/","");
                    SpecialDeases = "";
                    PatientNameFamily = gridView_ListDocPat.GetRowCellValue(Index[i], "PatientName").ToString() + " " + gridView_ListDocPat.GetRowCellValue(Index[i], "PatientFamily").ToString();

                    try
                    {
                        MHDC.SP_InsertPatientVisit(PatientIDSet, false, DoctorIDSet, true, _lastOverhalDate, 0, false, "", "", SpecialDeases, 1, "در انتظار تایید", ref RetValue);
                        if (RetValue.Value == 0)
                        {
                            //if (gridView_ListDocPat.SelectedRowsCount == 1)
                            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در ماه درخواستی ویزیت جهت بیمار مذکور ثبت شده است");
                            //else
                            CopyStr += PatientNameFamily + "     ";
                        }
                    }
                    catch
                    {
                        PatientDuplicate += DosiersNoSet.ToString() + "     ";
                    }
                }
                if (CopyStr != "")
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, "ویزیت جهت بیمار(ان) ذیل در ماه درخواستی قبلا ثبت شده است", CopyStr);
                else
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, false, "آخرین تاریخ و ویزیت بیمار(ان) انتخابی ثبت گردید");


                ShowListPatient(Index[i - 1]);
            }
        }

        private void ToolStripMenuItemStatusVisit_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i;
            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
            {
                PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));

                try
                {
                    //MHDC.SP_SetStatusForPationt(PatientIDSet, 1, comboBox_YearCD.Text + "/" + int.Parse(comboBox_MonthCD.Text).ToString("00") + "/" + int.Parse(comboBox_DayCD.Text).ToString("00"));
                    MHDC.SP_SetStatusForPationt(PatientIDSet, 1, Global_Cls.MiladiDateToShamsi(DateTime.Now));
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, "ثبت نشد", ex.Message);
                }
            }
            ShowListPatient(Index[i - 1]);
        }

        private void ToolStripMenuItemNoStatusVisit_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i;
            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
            {
                PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));

                try
                {
                    MHDC.SP_SetStatusForPationt(PatientIDSet, 0, "");
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, "ثبت نشد", ex.Message);
                }
            }
            ShowListPatient(Index[i - 1]);
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(1);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxDoctorName.Tag = sp.CodeC;
                textBoxDoctorName.Text = sp.NameC;
            }
        }

        private void buttonItemFilePatient_Click(object sender, EventArgs e)
        {
            int PatientIDSet;
            PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(gridView_ListDocPat.FocusedRowHandle, "PatientID"));
            MSSImageSelectorFiling_frm imgs = new MSSImageSelectorFiling_frm(PatientIDSet.ToString(), Global_Cls.AddressFile+@"\PatientFile\");
            if (imgs.ShowDialog() == DialogResult.OK)
            {
               
            }
        }

        private void btnSetOneVisit_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i, DoctorIDSet;
            string CopyStr = "", PatientDuplicate = "", DosiersNoSet = "", SpecialDeases = "", PatientNameFamily = "" ;
            int? RetValue = 0;
            DateTime _lastOverhalDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید ویزیت بیماران انتخابی به صورت فرد ثبت شوند؟"))
            {

                for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
                {
                    PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));
                    DoctorIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "LastDocHealthId"));
                    DosiersNoSet = gridView_ListDocPat.GetRowCellValue(Index[i], "DosiersNo").ToString();
                    //SpecialDeases = gridView_ListDocPat.GetRowCellValue(Index[0], "NationalCode").ToString() + "-" + Global_Cls.MiladiDateToShamsi(_lastOverhalDate).Replace("/","");
                    SpecialDeases = "";
                    PatientNameFamily = gridView_ListDocPat.GetRowCellValue(Index[i], "PatientName").ToString() + " " + gridView_ListDocPat.GetRowCellValue(Index[i], "PatientFamily").ToString();

                    try
                    {
                        MHDC.SP_InsertPatientVisit(PatientIDSet, false, DoctorIDSet, true, _lastOverhalDate, 0, false, "", "", SpecialDeases, 0, "در انتظار تایید", ref RetValue);
                        if (RetValue.Value == 0)
                        {
                            //if (gridView_ListDocPat.SelectedRowsCount == 1)
                            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "در ماه درخواستی ویزیت جهت بیمار مذکور ثبت شده است");
                            //else
                            CopyStr += PatientNameFamily + "     ";
                        }
                    }
                    catch
                    {
                        PatientDuplicate += DosiersNoSet.ToString() + "     ";
                    }
                }
                
                if (CopyStr != "")
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, "ویزیت جهت بیمار(ان) ذیل در ماه درخواستی قبلا ثبت شده است", CopyStr);
                else
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, false, "آخرین تاریخ و ویزیت بیمار(ان) انتخابی ثبت گردید");

                ShowListPatient(Index[i - 1]);
            }
        }

        private void buttonItemExitDoctors_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i;

            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


            for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
            {
                PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));
                Report.Forms.PatientDoctorReport PT = new Report.Forms.PatientDoctorReport(PatientIDSet);
                PrintPreview_frm PP = new PrintPreview_frm(PT);
                PP.ShowDialog();
            }
        }

        private void buttonItemVisitForDoctors_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPat.GetSelectedRows();
            int PatientIDSet, i;
            string LastOverhalDateDsc ="";

            DataClasses_MainDataContext MHDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


            for (i = 0; i < gridView_ListDocPat.SelectedRowsCount; i++)
            {
                PatientIDSet = Convert.ToInt32(gridView_ListDocPat.GetRowCellValue(Index[i], "PatientID"));
                LastOverhalDateDsc = gridView_ListDocPat.GetRowCellValue(Index[i], "LastOverhalDateDsc").ToString();

                CreateReportForVisitDoctor(PatientIDSet, LastOverhalDateDsc);
            }
        }

        private void CreateReportForVisitDoctor(int PatientIDSet, string LastOverhalDateDsc)
        {
            MehrParvarPrj.DataLinq.DataClassesSecondDataContext DCDC = new MehrParvarPrj.DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr); 
            
            FastReport.Report rpt = new FastReport.Report();

            var gg1 = (from l in DCDC.VW_PatientVisitForReports
                       where l.PatientID == PatientIDSet && (l.VisitDate == LastOverhalDateDsc || l.VisitDate == null)
                       select l).ToList();
            rpt.Load(Global_Cls.AddressFile.Replace("VisitFile\\", "") + @"Report\VisitForDoctor.frx");
            rpt.RegisterData(gg1, "VW_PatientVisitForReport");
            rpt.GetDataSource("VW_PatientVisitForReport").Enabled = true;
            rpt.Design();
        
        }




    }
}
