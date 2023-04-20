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
    public partial class ListDoctorPayment_UC : UserControl

    {
        public ListDoctorPayment_UC()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DCSDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        bool IsShown = false;

        #region Load & UI
        private void ListDoctorPayment_UC_Load(object sender, EventArgs e)
        {

            System.Globalization.PersianCalendar ps = new System.Globalization.PersianCalendar();
            comboBox_Day1.Text = "1";
            comboBox_Month1.Text = ps.GetMonth(DateTime.Now).ToString();
            comboBox_Year1.Text = ps.GetYear(DateTime.Now).ToString();

            comboBox_Day2.Text = ps.GetMonth(DateTime.Now) <= 6 ? "31" : ps.GetMonth(DateTime.Now) == 12 ? "29" : "30";
            comboBox_Month2.Text = ps.GetMonth(DateTime.Now).ToString();
            comboBox_Year2.Text = ps.GetYear(DateTime.Now).ToString();



            comboBox_YearL1.Text = comboBox_Year1.Text;
            comboBox_MonthL1.Text = comboBox_Month1.Text;
            comboBox_DayL1.Text = comboBox_Day1.Text;

            comboBox_DayL2.Text = comboBox_Day2.Text;
            comboBox_MonthL2.Text = comboBox_Month2.Text;
            comboBox_YearL2.Text = comboBox_Year2.Text;

            
            comboBoxDay1.Text = ps.GetDayOfMonth(DateTime.Now).ToString("00");
            comboBoxMonth1.Text = ps.GetMonth(DateTime.Now).ToString("00");
            comboBoxYear1.Text = ps.GetYear(DateTime.Now).ToString("00");

            comboBoxBonyadAddEven.SelectedIndex = 0;
            comboBoxPaymentStatus.SelectedIndex = 0;

            ColumnSelector_Cls.ComboBoxSelectorBind(comboBoxSelector, 4);
            //ComboBoxSelectorBind();

            IsShown = true;
            
//            ShowListDocPay(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                //if (UPer.Contains(btnSelectPay.Name)) btnSelectPay.Enabled = false;
                //if (UPer.Contains(buttonItemAllPayment.Name)) buttonItemAllPayment.Enabled = false;
                //if (UPer.Contains(buttonItemContractTypeList.Name)) buttonItemContractTypeList.Enabled = false;
                //if (UPer.Contains(buttonItemPayPrice.Name)) buttonItemPayPrice.Enabled = false;
                if (UPer.Contains(buttonItemPayPrintList.Name)) buttonItemPayPrintList.Enabled = false;
            }
        }
        
        //private void ComboBoxSelectorBind()
        //{
        //    var SUS = from prd in DCMDC.TBL_FieldSelectors
        //              where prd.FieldSelectType == 3
        //              select new { prd.FieldSelectName, prd.FieldSelectId };
        //    comboBoxSelector.DisplayMember = "FieldSelectName";
        //    comboBoxSelector.ValueMember = "FieldSelectId";
        //    comboBoxSelector.DataSource = SUS;
        //}

        private void gridView_ListDocPay_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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

        private void ShowListDocPay(int RowFocus)
        {
            if (comboBox_Year1.Text == "" || comboBox_Month1.Text == "" || comboBox_Day1.Text == "" || comboBox_Year2.Text == "" || comboBox_Month2.Text == "" || comboBox_Day2.Text == "") return;

            var SUS = from prd in DCSDC.VW_DoctorPayments
                      select prd;
          

            //chkNonDocH_CheckedChanged(this, null);

            try
            {
                if (radioButtonVisitCreateDate.Checked)
                {
                    DateTime D1 = Global_Cls.ShamsiDateToMiladiWithTime("", comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text, 0, 0, 0);
                    DateTime D2 = Global_Cls.ShamsiDateToMiladiWithTime("", comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text, 23, 59, 59);

                    SUS = SUS.Where(s => s.VisitCreateDateMiladi >= D1 && s.VisitCreateDateMiladi <= D2);
                }
                else
                {
                    DateTime D1 = Global_Cls.ShamsiDateToMiladiWithTime("", comboBox_YearL1.Text, comboBox_MonthL1.Text, comboBox_DayL1.Text, 0, 0, 0);
                    DateTime D2 = Global_Cls.ShamsiDateToMiladiWithTime("", comboBox_YearL2.Text, comboBox_MonthL2.Text, comboBox_DayL2.Text, 23, 59, 59);

                    SUS = SUS.Where(s => (s.InsuLetterDateMiladi >= D1 && s.InsuLetterDateMiladi <= D2) || s.InsuLetterDateMiladi == null || s.InsuLetterDate == "");
                }
            }
            catch { }
            if (RadioButtonVisitOK.Checked)
                SUS = SUS.Where(s => s.PaymentDoctorDate != "");
            else
            if (RadioButtonVisitNotOK.Checked)
                SUS = SUS.Where(s => s.PaymentDoctorDate == "");

  
            
            gridControl_ListDocPay.DataSource = SUS;


            gridView_ListDocPay.UnselectRow(gridView_ListDocPay.FocusedRowHandle);
            gridView_ListDocPay.SelectRow(RowFocus);
            gridView_ListDocPay.FocusedRowHandle = RowFocus;

        }

        string ActiveFilterStr = " ";
        private void chkNonDocH_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsShown) return;
            
            //string rStr = " ";
            //try
            //{
            //    rStr = gridView_ListDocPay.ActiveFilterString.Replace(ActiveFilterStr, "");
            //}
            //catch { rStr = gridView_ListDocPay.ActiveFilterString; }
            //try
            //{
            //    if (rStr.Substring(rStr.Length - 4, 4).ToLower().Replace(" ", "") == "and".ToLower())
            //        rStr = rStr.Remove(rStr.Length - 4);

            //    if (rStr.Substring(1, 4).ToLower().Replace(" ", "") == "and".ToLower())
            //        rStr = rStr.Remove(1, 4);

            //    if (rStr.Substring(rStr.Length - 3, 3).ToLower().Replace(" ", "") == "or".ToLower())
            //        rStr = rStr.Remove(rStr.Length - 3);

            //    if (rStr.Substring(1, 3).ToLower().Replace(" ", "") == "or".ToLower())
            //        rStr = rStr.Remove(1, 3);
            //}
            //catch { }
            //ActiveFilterStr = " ";


            //try
            //{
            //    DateTime D1 = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text);
            //    DateTime D2 = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);
            //    ActiveFilterStr = " VisitDateMiladi >= #" + D1.ToShortDateString() + "# And VisitDateMiladi <= #" + D2.AddDays(1).ToShortDateString() + "# ";
            //}
            //catch { }

            //gridView_ListDocPay.ActiveFilterString = ActiveFilterStr;
            ////ActiveFilterStr = gridView_ListDocPay.ActiveFilterString;
            ////if (rStr == " ") rStr = "";
            ////if (ActiveFilterStr == " ") ActiveFilterStr = "";
            ////if (rStr != "" && ActiveFilterStr != "") gridView_ListDocPay.ActiveFilterString += " and " + rStr;
            ////else if (rStr != "" && ActiveFilterStr == "") gridView_ListDocPay.ActiveFilterString = rStr;
            //gridView_ListDocPay.ApplyColumnsFilter();
        }

        
        
        #endregion


        #region All Buttons
        
        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            ShowListDocPay(gridView_ListDocPay.FocusedRowHandle);
        }

        private void buttonItemCustomSearch_Click(object sender, EventArgs e)
        {
            gridView_ListDocPay.OptionsView.ShowAutoFilterRow = !gridView_ListDocPay.OptionsView.ShowAutoFilterRow;
            if (!buttonItemCustomSearch.Checked)
            {
                gridView_ListDocPay.ActiveFilterString = ActiveFilterStr;
                gridView_ListDocPay.ApplyColumnsFilter();
            }
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ListDocPay.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCustomPrintList_Click(object sender, EventArgs e)
        {
            gridView_ListDocPay.FormatConditions[0].Appearance.BackColor = Color.White;

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ListDocPay);
            PP.ShowDialog();

            gridView_ListDocPay.FormatConditions[0].Appearance.BackColor = Color.PaleGreen;
        }

        //private void btnSelect_Click(object sender, EventArgs e)
        //{
        //    int[] Index = gridView_ListDocPay.GetSelectedRows();
        //    int PatientIDSet, VisitCodeSet, i;
        //    string PaymentDscSet = "", PaymentDateSet;
        //    long PaymentPriceSet = 0, PaymentIDSet = 0;
        //    bool PayExistSet;

        //    for (i = 0; i < gridView_ListDocPay.SelectedRowsCount; i++)
        //    {
        //        PatientIDSet = Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "PatientID"));
        //        VisitCodeSet = Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "VisitCode"));

        //        PaymentDscSet = Convert.ToString(gridView_ListDocPay.GetRowCellValue(Index[i], "PaymentDsc"));
        //        PaymentPriceSet = Convert.ToInt64(gridView_ListDocPay.GetRowCellValue(Index[i], "PaymentPrice"));
        //        PaymentDateSet = gridView_ListDocPay.GetRowCellValue(Index[i], "PaymentDate").ToString();
        //        PaymentIDSet = Convert.ToInt64(gridView_ListDocPay.GetRowCellValue(Index[i], "PaymentID") ?? 0);
        //        PayExistSet = Convert.ToBoolean(gridView_ListDocPay.GetRowCellValue(Index[i], "PayExist"));

        //        try
        //        {
        //            if (PayExistSet)
        //            {
        //                TBL_DoctorPayment TP = DCSDC.TBL_DoctorPayments.First(hj => hj.Id == PaymentIDSet);
        //                //TP.PaymentDsc = PaymentDscSet;
        //                //TP.CostDoctor = PaymentPriceSet;
        //                //TP.PaymentDate = PaymentDateSet;
        //                DCMDC.SubmitChanges();
        //            }
        //            else
        //            {
        //                TBL_DoctorPayment TP = new TBL_DoctorPayment();
        //                TP.PatientID = PatientIDSet;
        //                TP.VisitCode = VisitCodeSet;
        //                TP.DoctorID = Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "DoctorID"));
        //                //TP.PaymentDate = PaymentDateSet;
        //                //TP.CostDoctor = PaymentPriceSet;
        //                //TP.PaymentDsc = PaymentDscSet;
        //                DCSDC.TBL_DoctorPayments.InsertOnSubmit(TP);
        //                DCSDC.SubmitChanges();
        //            }
        //        }
        //        catch { }
        //    }
        //    ShowListDocPay(Index[i - 1]);
        //}

        private void gridView_ListDocPat_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.RowHandle + 1;
        }

        private void buttonItem_ContractTypeList_Click(object sender, EventArgs e)
        {
            ContractTypeList_Frm Ct = new ContractTypeList_Frm();
            Ct.ShowDialog();
        }


        private void buttonItemAllPayment_Click(object sender, EventArgs e)
        {
            //SetPaymentPrice(false);
        }

        private void buttonItemPayPrice_Click(object sender, EventArgs e)
        {
            //SetPaymentPrice(true);
        }

        //private void SetPaymentPrice(bool PayExist)
        //{
        //    gridControlPay.DataSource = null;
        //    DataClasses_MainDataContext DC1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        //    if (buttonItemCustomSearch.Checked)
        //    {
        //        buttonItemCustomSearch.Checked = false;
        //        buttonItemCustomSearch_Click(this, null);
        //    }
        //    string FilterWhere = gridView_ListDocPay.ActiveFilterString.Replace("#", "'") == "" ? " 1=1 " : gridView_ListDocPay.ActiveFilterString.Replace("#", "'");
            
        //    DC1.SP_DoctorPaymentPrice(PayExist, FilterWhere);
        //    DC1.SubmitChanges();

        //    var dd = from fg in DC1.TBL_TempPayPrices
        //             select fg;
        //    gridControlPay.DataSource = dd;

        //    PrintPreview_frm PP = new PrintPreview_frm(gridControlPay);
        //    PP.ShowDialog();
        //}

        #endregion


        #region Set CheckBox
        //CheckBox CB = new CheckBox();
        private void chkWifeSituation_CheckedChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.CheckBoxChanged(sender, gridView_ListDocPay);

            //CB = (CheckBox)sender;
            //string StrName = CB.Name.Substring(3);

            //int abs = 0;
            //foreach (DevExpress.XtraGrid.Columns.GridColumn df in gridView_ListDocPay.Columns)
            //{
            //    if (df.Name == StrName)
            //    {
            //        if (CB.Tag != null)
            //            df.Width = Convert.ToInt16(CB.Tag);

            //        foreach (var CHK in panel_Selector.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //            if ((CHK is CheckBox) && (CHK as CheckBox).TabIndex <= Convert.ToInt32(df.Tag) && !(CHK as CheckBox).Checked)
            //                abs++;
            //        df.VisibleIndex = CB.TabIndex - abs;
            //        df.Visible = CB.Checked;
            //    }
            //}
        }

        private void comboBoxSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            ColumnSelector_Cls.ComboBoxSelectValueChange(comboBoxSelector, panel_Selector);
            //if (comboBoxSelector.Text == "") return;

            //foreach (var CHK in panel_Selector.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //    if (CHK is CheckBox)
            //    {
            //        (CHK as CheckBox).Checked = false;
            //        //(CHK as CheckBox).TabIndex = 0;
            //    }

            //foreach (DevExpress.XtraGrid.Columns.GridColumn dgv in gridView_ListDocPay.Columns)
            //    dgv.Visible = false;


            //string StrChecked = DCMDC.TBL_FieldSelectors.First(hf => hf.FieldSelectId.Equals(comboBoxSelector.SelectedValue)).FieldSelectValue;
            //Dictionary<string, Dictionary<string, int>> df = new Dictionary<string, Dictionary<string, int>>(SetStrChecked(StrChecked));

            //foreach (var CHK in panel_Selector.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //    if (CHK is CheckBox)
            //        if (StrChecked.Contains((CHK as CheckBox).Name))
            //        {
            //            // (CHK as CheckBox).TabIndex = df[(CHK as CheckBox).Name]["TI"];
            //            (CHK as CheckBox).Tag = df[(CHK as CheckBox).Name]["WD"];
            //            (CHK as CheckBox).Checked = true;
            //        }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ColumnSelector_Cls.SaveChange(gridView_ListDocPay, comboBoxSelector, 4);

            //if (comboBoxSelector.Text == "") return;

            //string StrChecked = "";

            //foreach (Control CHK in panel_Selector.Controls.Cast<Control>()
            //                         .OrderBy(c => c.TabIndex))
            //{
            //    if (CHK is CheckBox)
            //        if ((CHK as CheckBox).Checked)
            //            StrChecked += (CHK as CheckBox).Name +
            //                "-TI:" + gridView_ListDocPay.Columns[(CHK as CheckBox).Name.Substring(3)].VisibleIndex +
            //                "-WD:" + gridView_ListDocPay.Columns[(CHK as CheckBox).Name.Substring(3)].Width + ";";
            //}

            //if ((from gh in DCMDC.TBL_FieldSelectors where gh.FieldSelectName == comboBoxSelector.Text && gh.FieldSelectType == 3 select gh).Count() > 0)
            //{
            //    TBL_FieldSelector TF = DCMDC.TBL_FieldSelectors.First(hj => hj.FieldSelectId == int.Parse(comboBoxSelector.SelectedValue.ToString()));
            //    TF.FieldSelectValue = StrChecked;
            //    DCMDC.SubmitChanges();

            //    int indx = comboBoxSelector.SelectedIndex;
            //    ComboBoxSelectorBind();
            //    comboBoxSelector.SelectedIndex = indx;
            //}
            //else
            //{
            //    TBL_FieldSelector TF = new TBL_FieldSelector();
            //    TF.FieldSelectType = 3;
            //    TF.FieldSelectName = comboBoxSelector.Text;
            //    TF.FieldSelectValue = StrChecked;
            //    DCMDC.TBL_FieldSelectors.InsertOnSubmit(TF);
            //    DCMDC.SubmitChanges();

            //    ComboBoxSelectorBind();
            //    comboBoxSelector.SelectedIndex = comboBoxSelector.Items.Count - 1;
            //}
        }

        

       
        #endregion

        private void buttonItemExcelExportPatientList_Click(object sender, EventArgs e)
        {
            Function_Cls.ExportExcelGrid(gridControl_ListDocPay);
            comboBoxSelector_SelectedValueChanged(this, null);
        }

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            int[] Index = gridView_ListDocPay.GetSelectedRows();
            int IDSet, i;

            DataClassesSecondDataContext MHDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مقدار درخواستی جهت ردیف های انتخابی ثبت شوند؟"))
            {
                string DateSet = comboBoxYear1.Text+"/"+ (comboBoxMonth1.Text.Length == 1 ? "0"+comboBoxMonth1.Text:comboBoxMonth1.Text)+"/"+ (comboBoxDay1.Text.Length == 1 ? "0"+comboBoxDay1.Text:comboBoxDay1.Text);

                decimal DefCostCo = Convert.ToDecimal((from sd in MHDC.TBL_Settings where sd.Name == "DefCostCo" select sd).Single().value);


                for (i = 0; i < gridView_ListDocPay.SelectedRowsCount; i++)
                {
                    IDSet = Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "Id"));
                    if (gridView_ListDocPay.GetRowCellValue(Index[i], "PaymentType").ToString() == "پیش پرداخت" ||
                        gridView_ListDocPay.GetRowCellValue(Index[i], "PaymentType").ToString() == "کسورات")
                        continue;

                    try
                    {
                        if (comboBoxSetValue.SelectedIndex == 14)
                        {
                            int PatietIDSet = Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "PatientID"));
                            int VisitCodeSet = Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "VisitCode"));

                            DataClasses_MainDataContext DCMDC1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                            TBL_PatientVisit TPV = DCMDC1.TBL_PatientVisits.First(hj => hj.PatientID == PatietIDSet && hj.VisitCode == VisitCodeSet);
                            TPV.BonyadAddEven = Convert.ToInt16(comboBoxBonyadAddEven.SelectedIndex == -1 ? 0 : comboBoxBonyadAddEven.SelectedIndex);
                            DCMDC1.SubmitChanges();
                        }
                        else
                        {
                            TBL_DoctorPayment TP = MHDC.TBL_DoctorPayments.First(hj => hj.Id == IDSet);

                            if (comboBoxSetValue.SelectedIndex == 0)
                            {
                                TP.InsuLetterNo = textBoxSetValue.Text;
                                TP.InsuLetterDate = textBoxSetValue.Text == "" ? "" : DateSet;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 1)
                                TP.CostReqInsuIran = int.Parse(nUpDownSetValue.Value.ToString());
                            else if (comboBoxSetValue.SelectedIndex == 2)
                            {
                                TP.CostCachInsuIran = int.Parse(nUpDownSetValue.Value.ToString());
                                TP.CostVisitCo = Convert.ToInt32(Math.Round((int.Parse(nUpDownSetValue.Value.ToString()) * DefCostCo / 100), 0));
                                TP.CostVisitDoctor = TP.CostCachInsuIran - TP.CostVisitCo - TP.CostIncrease - TP.CostDoctorTax;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 3)
                            {
                                TP.SecretiatNo = textBoxSetValue.Text;
                                TP.SecretiatDate = textBoxSetValue.Text == "" ? "" : DateSet;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 4)
                            {
                                TP.AnalyzeNo = textBoxSetValue.Text;
                                TP.AnalyzeDate = textBoxSetValue.Text == "" ? "" : DateSet;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 5)
                                TP.AccountingDocumentNumber = textBoxSetValue.Text;
                            else if (comboBoxSetValue.SelectedIndex == 6)
                            {
                                TP.CostVisitCo = int.Parse(nUpDownSetValue.Value.ToString());
                                TP.CostVisitDoctor = TP.CostCachInsuIran - TP.CostVisitCo - TP.CostIncrease - TP.CostDoctorTax;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 7)
                            {
                                TP.CostIncrease = int.Parse(nUpDownSetValue.Value.ToString());
                                TP.CostIncreaseDate = nUpDownSetValue.Value == 0 ? "" : DateSet;

                                TP.CostVisitDoctor = TP.CostCachInsuIran - TP.CostVisitCo - TP.CostIncrease - TP.CostDoctorTax;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 8)
                            {
                                TP.CostIncrease = int.Parse(nUpDownSetValue.Value.ToString()) * TP.CostCachInsuIran / 100;
                                TP.CostIncreaseDate = nUpDownSetValue.Value == 0 ? "" : DateSet;

                                TP.CostVisitDoctor = TP.CostCachInsuIran - TP.CostVisitCo - TP.CostIncrease - TP.CostDoctorTax;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 9)
                                TP.PaymentDoctorDate = DateSet;
                            else if (comboBoxSetValue.SelectedIndex == 10)
                            {
                                if (comboBoxPaymentStatus.SelectedIndex == -1) comboBoxPaymentStatus.SelectedIndex = 0;
                                TP.PaymentStatus = comboBoxPaymentStatus.Text;
                                TP.PaymentStatusDate = DateSet;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 11)
                                TP.Description = textBoxSetValue.Text;
                            else if (comboBoxSetValue.SelectedIndex == 12)
                            {
                                TP.CostDoctorTax = int.Parse(nUpDownSetValue.Value.ToString());
                                TP.CostVisitDoctor = TP.CostCachInsuIran - TP.CostVisitCo - TP.CostIncrease - TP.CostDoctorTax;
                            }
                            else if (comboBoxSetValue.SelectedIndex == 13)
                            {
                                TP.CostDoctorTax = int.Parse(nUpDownSetValue.Value.ToString()) * (TP.CostCachInsuIran - TP.CostVisitCo) / 100;
                                TP.CostVisitDoctor = TP.CostCachInsuIran - TP.CostVisitCo - TP.CostIncrease - TP.CostDoctorTax;
                            }

                            MHDC.SubmitChanges();
                        }
                    
                    }
                    catch (Exception ex)
                    {
                        //if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        //    Tekrariha += gridView_ListDocPat.GetRowCellValue(Index[i], "DosiersNo").ToString() + ";  ";
                    }
                }
                //if (Tekrariha != "")
                //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, false, "موارد ثبت گردید به غیر از تکراری ها که در لیست آمده است", "شماره پرونده ها:" + Tekrariha);

                ShowListDocPay(Index[i - 1]);
            }
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSetValue.Visible = comboBoxSetValue.SelectedIndex == 0 || comboBoxSetValue.SelectedIndex == 3 || comboBoxSetValue.SelectedIndex == 4 || comboBoxSetValue.SelectedIndex == 5 || comboBoxSetValue.SelectedIndex == 11 || comboBoxSetValue.SelectedIndex == 9;
            nUpDownSetValue.Visible = comboBoxSetValue.SelectedIndex == 1 || comboBoxSetValue.SelectedIndex == 2 || comboBoxSetValue.SelectedIndex == 6 || comboBoxSetValue.SelectedIndex == 7 || comboBoxSetValue.SelectedIndex == 8 || comboBoxSetValue.SelectedIndex == 12 || comboBoxSetValue.SelectedIndex == 13;
            comboBoxPaymentStatus.Visible = comboBoxSetValue.SelectedIndex == 10;
            comboBoxBonyadAddEven.Visible = comboBoxSetValue.SelectedIndex == 14;
        }

        private void buttonItemNewVisit_Click(object sender, EventArgs e)
        {
            DoctorPaymentNE_frm Uc = new DoctorPaymentNE_frm();
            if (Uc.ShowDialog() == DialogResult.OK) 
                ShowListDocPay(gridView_ListDocPay.RowCount);
        }

        private void buttonItemPatVisitEdit_Click(object sender, EventArgs e)
        {
            if (gridView_ListDocPay.RowCount == 0) return;
            int Index = gridView_ListDocPay.FocusedRowHandle;

            if (gridView_ListDocPay.GetRowCellValue(Index, "PaymentType").ToString() != "پرداخت عادي")
            {
                DoctorPaymentNE_frm Uc = new DoctorPaymentNE_frm(Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index, "Id").ToString()));
                if (Uc.ShowDialog() == DialogResult.OK)
                    ShowListDocPay(Index);
            }
            else
                Global_Cls.Message_MehrGostar("امکان ویرایش ردیف انتخابی وجود ندارد", Global_Cls.MessageType.SError);
        }


        private void buttonItemPatVisitDel_Click(object sender, EventArgs e)
        {
            if (gridView_ListDocPay.RowCount == 0) return;
            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید ردیف (های) انتخابی حذف شوند؟ ")) return;

            int[] Index = gridView_ListDocPay.GetSelectedRows();
            for (int i = 0; i < gridView_ListDocPay.SelectedRowsCount; i++)
            {
                TBL_DoctorPayment tbd = DCSDC.TBL_DoctorPayments.First(dd => dd.Id == Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "Id")));
                DCSDC.TBL_DoctorPayments.DeleteOnSubmit(tbd);
                DCSDC.SubmitChanges();

                try
                {
                    TBL_PatientVisit tpv = DCMDC.TBL_PatientVisits.First(dd => dd.PatientID == Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "PatientID")) && dd.VisitCode == Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "VisitCode")));
                    tpv.VisitStatus = "در انتظار تایید";
                    DCMDC.SubmitChanges();
                }
                catch (Exception)
                {
                    TBL_DelPatientVisit tpv = DCMDC.TBL_DelPatientVisits.First(dd => dd.PatientID == Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "PatientID")) && dd.VisitCode == Convert.ToInt32(gridView_ListDocPay.GetRowCellValue(Index[i], "VisitCode")));
                    tpv.VisitStatus = "در انتظار تایید";
                    DCMDC.SubmitChanges();
                } 
            }
            ShowListDocPay(Index[0]);
        }

        private void buttonItemAllDoctorRemind_Click(object sender, EventArgs e)
        {
            if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید مانده ها محاسبه شوند؟ ")) return;
            try
            {
                DCSDC.SP_DoctorPaymentRemindForAllDoctor();
                Global_Cls.Message_MehrGostar("مانده ها ثبت شدند", Global_Cls.MessageType.SInformation);
            }
            catch (Exception ex)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, " اشکال ", ex.Message);
            }
        }

        
    }
}
