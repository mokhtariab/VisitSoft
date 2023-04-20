using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MehrParvarPrj.DataLinq;
using Microsoft.Office.Interop;
using Microsoft.CSharp;



namespace MehrParvarPrj
{
    public partial class ExportExcel_Uc : UserControl
    {
        public ExportExcel_Uc()
        {
            InitializeComponent();
        }

        #region Export Excel

        private void ReadExcel(string pathStr, string SheetName)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            excelApp.ScreenUpdating = false;
            excelApp.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(pathStr, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Microsoft.Office.Interop.Excel.Sheets excelSheets = excelWorkbook.Worksheets;

            try
            {
                string currentSheet = SheetName;
                Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelSheets.get_Item(currentSheet);
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.UsedRange;
                //string sValue = (range.Cells[_row, _column] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                int i = (range as Microsoft.Office.Interop.Excel.Range).Columns.Count;
                int h = (range as Microsoft.Office.Interop.Excel.Range).Rows.Count;

                DataTable dt = new DataTable();
                for (int j = 1; j <= i; j++)
                    dt.Columns.Add((range.Cells[1, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(), Type.GetType("System.String"));

                for (int f = 2; f <= h; f++)
                {
                    DataRow dr = dt.NewRow();

                    for (int j = 1; j <= i; j++)
                    {
                        dr[j - 1] = ((range.Cells[f, j] as Microsoft.Office.Interop.Excel.Range).Value2 ?? "").ToString();
                    }
                    dt.Rows.Add(dr);
                }
                gridControl_ImportExcel.DataSource = dt;

                DevExpress.XtraGrid.Columns.GridColumn RowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
                RowNumber.FieldName = "RowNumber";
                RowNumber.Name = "RowNumber";
                RowNumber.Caption = "ردیف";
                RowNumber.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
                gridView_ImportExcel.Columns.Add(RowNumber);
                gridView_ImportExcel.Columns["RowNumber"].Width = 30;
                gridView_ImportExcel.Columns["RowNumber"].VisibleIndex = 0;
                gridView_ImportExcel.Columns["RowNumber"].Visible = true;
                gridView_ImportExcel.Columns["RowNumber"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            
            }
            catch (System.Exception ex)
            {
                if (ex.ToString().Contains("is not a valid"))
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام شيت اشتباه است");
                    textBoxPatientID.Focus();
                }
                else
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اشكال در لود ديتا", ex.Message);
            }

            excelWorkbook.Close();

            excelApp.Quit();
        }


       
        //private void SetExcelToGrid(string PathStr, string SheetName)
        //{
        //    System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

        //    conn.ConnectionString = @"provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + PathStr + @";Extended Properties=Excel 8.0;";

        //    System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand
        //    (
        //       "SELECT * FROM [" + SheetName + "$]", conn
        //    );
        //    System.Data.DataSet ds = new System.Data.DataSet();
        //    System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(command);
        //    try
        //    {
        //        adapter.Fill(ds);
        //        gridControl_ImportExcel.DataSource = null;
        //        gridControl_ImportExcel.DataSource = ds.Tables[0];

        //        DevExpress.XtraGrid.Columns.GridColumn RowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
        //        RowNumber.FieldName = "RowNumber";
        //        RowNumber.Name = "RowNumber";
        //        RowNumber.Caption = "ردیف";
        //        RowNumber.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
        //        gridView_ImportExcel.Columns.Add(RowNumber);
        //        gridView_ImportExcel.Columns["RowNumber"].Width = 30;
        //        gridView_ImportExcel.Columns["RowNumber"].VisibleIndex = 0;
        //        gridView_ImportExcel.Columns["RowNumber"].Visible = true;
        //        gridView_ImportExcel.Columns["RowNumber"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        if (ex.ToString().Contains("is not a valid"))
        //        {
        //            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام شيت اشتباه است");
        //            textBoxPatientID.Focus();
        //        }
        //        else
        //            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اشكال در لود ديتا", ex.Message);
        //    }
        //}

        #endregion

        private void buttonImport_Click(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCMDCc = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (gridView_ImportExcel.RowCount == 0)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات پر نشده است");
                textBoxPatientID.Focus();
                return;
            }

            listViewErrore.Items.Clear();
            int CntCheck = 0;
            for (int i = 0; i < gridView_ImportExcel.RowCount; i++)
            {

                System.Windows.Forms.Application.DoEvents();

                //if (gridView_ImportExcel.GetRowCellValue(i, "نسبت").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": نسبت خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                //if (gridView_ImportExcel.GetRowCellValue(i, "شماره پرونده").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": شماره پرونده خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                if (gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString() == "")
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی خالی می باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

                if (gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString().Replace("'","").Length > 10)
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی بایستی 10 رقم باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

                try
                {
                    string CodeMelli = gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString();
                    if (CodeMelli.Length < 10)
                        for (int h = 0; h < 10 - gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString().Length; h++)
                            CodeMelli = "0" + CodeMelli;
                }
                catch
                {
                }


                if (gridView_ImportExcel.GetRowCellValue(i, "نام").ToString() == "")
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": نام بیمار خالی می باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

                if (gridView_ImportExcel.GetRowCellValue(i, "نام خانوادگی").ToString() == "")
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": نام خانوادگی خالی می باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }


                try
                {
                        if ((from jh in DCMDCc.TBL_Doctors
                             where (jh.DoctorName+jh.DoctorFamily).Replace(" ","") == gridView_ImportExcel.GetRowCellValue(i, "پزشک سلامت").ToString().Replace(" ","")
                             select jh).Count() == 0)
                        {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": پزشک سلامت در لیست پزشکان نمی باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                        }
                }
                    catch
                    {
                        
                    }
            }
            if (CntCheck != 0) return;


            for (int j = 0; j < gridView_ImportExcel.RowCount; j++)
            {
                System.Windows.Forms.Application.DoEvents();

                try
                {
                    DataClasses_MainDataContext DCMDC = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    TBL_Patient THC = new TBL_Patient();

                    //if ((from jh in DCMDC.TBL_PatientTypes
                    //     where jh.PatientTypeDsc == gridView_ImportExcel.GetRowCellValue(j, "نسبت").ToString()
                    //     select jh).Count() > 0)
                    //    THC.PatientTypeId = DCMDC.TBL_PatientTypes.First(kk => kk.PatientTypeDsc == gridView_ImportExcel.GetRowCellValue(j, "نسبت").ToString()).PatientTypeId;
                    //else
                    //{
                    //    DataClasses_MainDataContext DCM1 = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    //    TBL_PatientType PT = new TBL_PatientType { PatientTypeDsc = gridView_ImportExcel.GetRowCellValue(j, "نسبت").ToString() };
                    //    DCM1.TBL_PatientTypes.InsertOnSubmit(PT);
                    //    DCM1.SubmitChanges();
                    //    THC.PatientTypeId = DCMDC.TBL_PatientTypes.First(kk => kk.PatientTypeDsc == gridView_ImportExcel.GetRowCellValue(j, "نسبت").ToString()).PatientTypeId;
                    //}

                    THC.DosiersNo = gridView_ImportExcel.GetRowCellValue(j, "شماره پرونده").ToString();

                    THC.CreateDate = DateTime.Now;

                    THC.PatientName = gridView_ImportExcel.GetRowCellValue(j, "نام").ToString();
                    THC.PatientFamily = gridView_ImportExcel.GetRowCellValue(j, "نام خانوادگی").ToString();
                    THC.ParentName = (gridView_ImportExcel.GetRowCellValue(j, "نام پدر") ?? "").ToString();
                    THC.IDNO = (gridView_ImportExcel.GetRowCellValue(j, "شماره شناسنامه") ?? "0").ToString();

                    string CodeMelli = gridView_ImportExcel.GetRowCellValue(j, "کدملی").ToString().Replace("'", "");
                    if (CodeMelli.Length < 10)

                        for (int h = 0; h < 10 - gridView_ImportExcel.GetRowCellValue(j, "کدملی").ToString().Replace("'", "").Length; h++)
                            CodeMelli = "0"+CodeMelli;
                    THC.NationalCode = CodeMelli;

                    THC.BrithDate = DateTime.Now.AddYears(-80);
                    try
                    {
                        if (gridView_ImportExcel.GetRowCellValue(j, "تاریخ تولد").ToString() != "")
                            THC.BrithDate = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(j, "تاریخ تولد").ToString()); 
                        else
                        if (gridView_ImportExcel.GetRowCellValue(j, "سن").ToString() != "")
                            THC.BrithDate = DateTime.Now.AddYears(-Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سن").ToString()));
                    }
                    catch
                    {
                        try
                        {
                            if (gridView_ImportExcel.GetRowCellValue(j, "سن").ToString() != "")
                                THC.BrithDate = DateTime.Now.AddYears(-Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سن").ToString()));
                        }
                        catch { }
                    }



                    THC.BrithCityName = (gridView_ImportExcel.GetRowCellValue(j, "صادره از") ?? "").ToString();

                    THC.PercentState = Convert.ToInt16(gridView_ImportExcel.GetRowCellValue(j, "درصد").ToString() == "" ? "0" : gridView_ImportExcel.GetRowCellValue(j, "درصد").ToString());

                    //THC.KinShipWith = (gridView_ImportExcel.GetRowCellValue(j, "نسبت") ?? "").ToString();
                    THC.WifeSituation = (gridView_ImportExcel.GetRowCellValue(j, "پرونده بنیادی") ?? "").ToString();
                    THC.ProtectSituation = (gridView_ImportExcel.GetRowCellValue(j, "وضعیت تاهل") ?? "").ToString();
                    //THC.WholeSituation = (gridView_ImportExcel.GetRowCellValue(j, "وضعیت کل") ?? "").ToString();
                    THC.Description = (gridView_ImportExcel.GetRowCellValue(j, "توضیحات") ?? "").ToString();

                    THC.PeriodVisit = Convert.ToInt16(gridView_ImportExcel.GetRowCellValue(j, "دوره بازدید").ToString() == "" ? "0" : gridView_ImportExcel.GetRowCellValue(j, "دوره بازدید").ToString());

                    THC.CityPart = (gridView_ImportExcel.GetRowCellValue(j, "شهر") ?? "").ToString();
                    THC.AddressPart = Convert.ToInt16(gridView_ImportExcel.GetRowCellValue(j, "منطقه").ToString() == "" ? "0" : gridView_ImportExcel.GetRowCellValue(j, "منطقه").ToString());
                    THC.Address = (gridView_ImportExcel.GetRowCellValue(j, "آدرس") ?? "").ToString();
                    THC.TelHome = (gridView_ImportExcel.GetRowCellValue(j, "تلفن منزل") ?? "").ToString();
                    THC.TelBusiness = (gridView_ImportExcel.GetRowCellValue(j, "تلفن") ?? "").ToString();
                    
                    
                    string Mobile = (gridView_ImportExcel.GetRowCellValue(j, "موبایل") ?? "").ToString();
                    if (Mobile.Length < 11 && Mobile.Length > 0)

                        for (int h = 0; h < 11 - gridView_ImportExcel.GetRowCellValue(j, "موبایل").ToString().Length; h++)
                            Mobile = "0" + Mobile;
                    THC.Mobile = Mobile;


                    string Mobile2 = (gridView_ImportExcel.GetRowCellValue(j, "موبایل2") ?? "").ToString();
                    if (Mobile2.Length < 11 && Mobile2.Length > 0)

                        for (int h = 0; h < 11 - gridView_ImportExcel.GetRowCellValue(j, "موبایل2").ToString().Length; h++)
                            Mobile2 = "0" + Mobile2;
                    THC.Mobile2 = Mobile2;
                    
                    THC.BasicInsurance = (gridView_ImportExcel.GetRowCellValue(j, "نوع بیمه") ?? "").ToString();
                    THC.CompletionInsurance = (gridView_ImportExcel.GetRowCellValue(j, "نوع بیمه تکمیلی") ?? "").ToString();
                     

                    THC.Email = "";

                    THC.ContractTypeId = 0;
                    //THC.LastDocHealthId = 0;
                    //THC.LastDocWatcherId = 0;


                    try
                    {
                        if (gridView_ImportExcel.GetRowCellValue(j, "مرد/زن").ToString().Replace(" ","")=="زن")
                            THC.Sex = 1;
                        else THC.Sex = 0;
                    }
                    catch
                    {
                        THC.Sex = 0;
                    }
                    
                    try
                    {
                        if (gridView_ImportExcel.GetRowCellValue(j, "فرد/زوج").ToString().Replace(" ","")=="زوج")
                            THC.BonyadAddEven = 1;
                        else THC.BonyadAddEven = 0;
                    }
                    catch
                    {
                        THC.BonyadAddEven = 0;
                    }

                    
                    try
                    {
                        if ((from jh in DCMDC.TBL_Doctors
                             where (jh.DoctorName+jh.DoctorFamily).Replace(" ","") == gridView_ImportExcel.GetRowCellValue(j, "پزشک سلامت").ToString().Replace(" ","")
                             select jh).Count() > 0)
                            THC.LastDocHealthId = (short)DCMDC.VW_Doctors.First(kk => (kk.DoctorName+kk.DoctorFamily).Replace(" ","") == gridView_ImportExcel.GetRowCellValue(j, "پزشک سلامت").ToString().Replace(" ","")).DoctorID;
                        else
                            THC.LastDocHealthId = 0;
                    }
                    catch
                    {
                        THC.LastDocHealthId = 0;
                    }

                    try
                    {
                        if (gridView_ImportExcel.GetRowCellValue(j, "تاریخ آخرین ویزیت").ToString() == "")
                            THC.LastOverhalDate = Global_Cls.ShamsiDateToMiladi("1387/01/01");
                        else THC.LastOverhalDate = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(j, "تاریخ آخرین ویزیت").ToString());
                    }
                    catch
                    {
                        THC.LastOverhalDate = Global_Cls.ShamsiDateToMiladi("1387/01/01");
                    }
                    
                    try
                    {
                        if (gridView_ImportExcel.GetRowCellValue(j, "تاریخ اولین ویزیت").ToString() == "")
                            THC.FirstOverhalDate = Global_Cls.ShamsiDateToMiladi("1387/01/01");
                        else THC.FirstOverhalDate = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(j, "تاریخ اولین ویزیت").ToString());
                    }
                    catch
                    {
                        THC.FirstOverhalDate = Global_Cls.ShamsiDateToMiladi("1387/01/01");
                    }

                    
                    
                    THC.Active = true;


                    DCMDC.TBL_Patients.InsertOnSubmit(THC);
                    DCMDC.SubmitChanges();




                    int NewPatientID = (from h in DCMDC.TBL_Patients select h.PatientID).Max();

                    try
                    {
                      
                        if ((from h in DCMDC.TBL_PatientTypes where h.PatientTypeDsc.Replace(" ","") == gridView_ImportExcel.GetRowCellValue(j, "نسبت").ToString().Replace(" ","") select h.PatientTypeId).Count()==0)
                        {
                             TBL_PatientType PatientT = new TBL_PatientType
                             {PatientTypeDsc = gridView_ImportExcel.GetRowCellValue(j, "نسبت").ToString()};
                                DCMDC.TBL_PatientTypes.InsertOnSubmit(PatientT);
                                DCMDC.SubmitChanges();
                        }
                        
                        TBL_PatientTypeGroup PatientTG = new TBL_PatientTypeGroup
                        {
                            PatientId = NewPatientID,
                            PatientTypeId = Convert.ToInt16((from h in DCMDC.TBL_PatientTypes where h.PatientTypeDsc == gridView_ImportExcel.GetRowCellValue(j, "نسبت").ToString() select h.PatientTypeId).Max())
                        };
                        DCMDC.TBL_PatientTypeGroups.InsertOnSubmit(PatientTG);
                        DCMDC.SubmitChanges();
                    }
                    catch { }



                    try
                    {
                        if (gridView_ImportExcel.GetRowCellValue(j, "نوع مجروحیت").ToString().Replace(" ", "") != "")
                        {

                            if ((from h in DCMDC.TBL_InjuryTypes where h.InjuryTypeDsc.Replace(" ", "") == gridView_ImportExcel.GetRowCellValue(j, "نوع مجروحیت").ToString().Replace(" ", "") select h.InjuryTypeId).Count() == 0)
                            {
                                TBL_InjuryType InjuryT = new TBL_InjuryType { InjuryTypeDsc = gridView_ImportExcel.GetRowCellValue(j, "نوع مجروحیت").ToString() };
                                DCMDC.TBL_InjuryTypes.InsertOnSubmit(InjuryT);
                                DCMDC.SubmitChanges();
                            }

                            TBL_InjuryTypePatient InjuryTG = new TBL_InjuryTypePatient
                            {
                                PatientId = NewPatientID,
                                InjuryTypeId = Convert.ToInt16((from h in DCMDC.TBL_InjuryTypes where h.InjuryTypeDsc == gridView_ImportExcel.GetRowCellValue(j, "نوع مجروحیت").ToString() select h.InjuryTypeId).Max())
                            };
                            DCMDC.TBL_InjuryTypePatients.InsertOnSubmit(InjuryTG);
                            DCMDC.SubmitChanges();
                        }
                    }
                    catch { }


                    try
                    {
                        TBL_Patient tbhc1 = DCMDC.TBL_Patients.First(thfh => thfh.PatientID.Equals(NewPatientID));
                        tbhc1.PatientTypeStr = DCMDC.PatientTypeStr(NewPatientID);
                        tbhc1.InjuryTypeStr = DCMDC.InjuryTypeStr(NewPatientID);
                        DCMDC.SubmitChanges();
                    }
                    catch { }

                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                    {
                        listViewErrore.Items.Add("ردیف " + (j + 1).ToString() + ": اطلاعات بیمار در سیستم وجود دارد و تکراری است!");
                        listViewErrore.Items[CntCheck].SubItems.Add(j.ToString());
                        CntCheck++;
                    }
                    else
                        if (ex.Message.IndexOf("Duplicated Tbl_Del!") > -1)
                        {
                            listViewErrore.Items.Add("ردیف " + (j + 1).ToString() + ": این بیمار در لیست حذفیات موجود می باشد!");
                            listViewErrore.Items[CntCheck].SubItems.Add(j.ToString());
                            CntCheck++;
                        }
                        else
                        {
                            listViewErrore.Items.Add("ردیف " + (j + 1).ToString() + ": اشکال در ثبت!" + ex.Message+"نوع مقادیر");
                            listViewErrore.Items[CntCheck].SubItems.Add(j.ToString());
                            CntCheck++;
                        }
                }
            }
            
            if (CntCheck == 0)
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SInformation, false, "اطلاعات بیماران به طور کامل در سیستم درج گردید");
            else
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات بیماران به غیر از اشکال دارها در سیستم درج گردید");
        }

        private void gridView_ImportExcel_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.RowHandle + 1;
        }

        private void gridView_ImportExcel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)

                if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, true, "آیا به حذف این ردیف(ها) اطمینان دارید؟"))
                    gridView_ImportExcel.DeleteSelectedRows();
        }

        private void listViewErrore_DoubleClick(object sender, EventArgs e)
        {
            int RF = int.Parse(listViewErrore.SelectedItems[0].SubItems[1].Text);
            gridView_ImportExcel.UnselectRow(gridView_ImportExcel.FocusedRowHandle);
            gridView_ImportExcel.SelectRow(RF);
            gridView_ImportExcel.FocusedRowHandle = RF;

        }

        private void buttonPatientID_Click(object sender, EventArgs e)
        {
            if (textBoxPatientID.Text == "")
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "نام شيت را وارد كنيد");
                textBoxPatientID.Focus();
                return;
            }


            System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();
            op.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx";
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //SetExcelToGrid(op.FileName, textBoxPatientID.Text);
                ReadExcel(op.FileName, textBoxPatientID.Text);
            }
        }
        
        
    }
}
