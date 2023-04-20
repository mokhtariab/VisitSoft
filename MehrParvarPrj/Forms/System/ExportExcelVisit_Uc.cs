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
    public partial class ExportExcelVisit_Uc : UserControl
    {
        public ExportExcelVisit_Uc()
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
            //DataClasses_MainDataContext DCMDC = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            //DataClassesSecondDataContext DCSDC = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);

            //if (gridView_ImportExcel.RowCount == 0)
            //{
            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات پر نشده است");
            //    textBoxPatientID.Focus();
            //    return;
            //}

            //listViewErrore.Items.Clear();
            //int CntCheck = 0, Cd = 0;
            //for (int i = 0; i < gridView_ImportExcel.RowCount; i++)
            //{

            //    System.Windows.Forms.Application.DoEvents();

            //    if (gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString() == "")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی خالی می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }

            //    if (gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString().Length > 10)
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی بایستی 10 رقم باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }


            //    string CodeMelli = gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString();
            //    try
            //    {
            //        if (CodeMelli.Length < 10)
            //            for (int h = 0; h < 10 - gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString().Length; h++)
            //                CodeMelli = "0" + CodeMelli;

            //        if ((from jh in DCMDC.TBL_DelPatients where jh.NationalCode == CodeMelli select jh).Count() > 0)
            //        {
            //            listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": جهت اطلاع: بیمار مورد نظر در لیست بیماران بایگانی وجود دارد");
            //            listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //            CntCheck++;
            //            Cd++;
            //        }
            //        else

            //            if ((from jh in DCMDC.TBL_Patients where jh.NationalCode == CodeMelli select jh).Count() == 0)
            //            {
            //                listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی بیمار مورد نظر در لیست بیماران وجود ندارد");
            //                listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //                CntCheck++;
            //            }
            //    }
            //    catch
            //    {
            //    }


            //    if (gridView_ImportExcel.GetRowCellValue(i, "تاریخ روز ویزیت").ToString() == "")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": تاریخ روز ویزیت خالی می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }

            //    try
            //    {
            //        DateTime dt = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(i, "تاریخ روز ویزیت").ToString());
            //    }
            //    catch
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": فرمت تاریخ روز ویزیت دارای اشکال می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }

            //    if (gridView_ImportExcel.GetRowCellValue(i, "شماره معرفینامه").ToString() == "")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": شماره معرفینامه خالی می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }



            //    if (gridView_ImportExcel.GetRowCellValue(i, "تاریخ ثبت هزینه").ToString() == "")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": تاریخ ثبت هزینه خالی می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }

            //    try
            //    {
            //        DateTime dt = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(i, "تاریخ ثبت هزینه").ToString());
            //    }
            //    catch
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": فرمت تاریخ ثبت هزینه دارای اشکال می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }


            //    if (gridView_ImportExcel.GetRowCellValue(i, "سهم بیمه ایران").ToString() == "")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": سهم بیمه ایران خالی می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }
            //    try
            //    {
            //        int dcost = Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(i, "سهم بیمه ایران").ToString());
            //    }
            //    catch
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": مقدار فیلد سهم بیمه ایران عددی نمی باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }



            //    if (gridView_ImportExcel.GetRowCellValue(i, "مبلغ کل").ToString() == "")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": مبلغ کل خالی می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }
            //    try
            //    {
            //        int dcost = Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(i, "مبلغ کل").ToString());
            //    }
            //    catch
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": مقدار فیلد مبلغ کل عددی نمی باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }



            //    if (gridView_ImportExcel.GetRowCellValue(i, "وضعیت").ToString() == "")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": وضعیت خالی می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }

            //    if (gridView_ImportExcel.GetRowCellValue(i, "زوج/فرد").ToString() == "")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": زوج/فرد خالی می باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }

            //    if (gridView_ImportExcel.GetRowCellValue(i, "زوج/فرد").ToString() != "0" && gridView_ImportExcel.GetRowCellValue(i, "زوج/فرد").ToString() != "1")
            //    {
            //        listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": زوج/فرد فقط بایستی 0 یا 1 باشد");
            //        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
            //        CntCheck++;
            //    }


            //}
            //if (CntCheck - Cd != 0) return;

            //for (int f = 0; f < gridView_ImportExcel.RowCount; f++)
            //{
            //    System.Windows.Forms.Application.DoEvents();
            //    string VisitDateCu = gridView_ImportExcel.GetRowCellValue(f, "تاریخ روز ویزیت").ToString();
            //    string CodeMelli = gridView_ImportExcel.GetRowCellValue(f, "کدملی").ToString();
            //    if (CodeMelli.Length < 10)
            //        for (int h = 0; h < 10 - gridView_ImportExcel.GetRowCellValue(f, "کدملی").ToString().Length; h++)
            //            CodeMelli = "0" + CodeMelli;

            //    if ((from prd in DCMDC.VW_PatientVisits
            //         where prd.NationalCode == CodeMelli && prd.VisitDate == VisitDateCu
            //         select prd).Count() == 0)
            //    {
            //        listViewErrore.Items.Add("ردیف " + (f + 1).ToString() + ": ویزیت بیمار در تاریخ مذکور ثبت نشده است");
            //        listViewErrore.Items[CntCheck].SubItems.Add(f.ToString());
            //        CntCheck++;
            //    }
            //}
            //if (CntCheck - Cd != 0) return;



            //for (int j = 0; j < gridView_ImportExcel.RowCount; j++)
            //{
            //    System.Windows.Forms.Application.DoEvents();



            //    string CodeMelli = gridView_ImportExcel.GetRowCellValue(j, "کدملی").ToString();
            //    if (CodeMelli.Length < 10)
            //        for (int h = 0; h < 10 - gridView_ImportExcel.GetRowCellValue(j, "کدملی").ToString().Length; h++)
            //            CodeMelli = "0" + CodeMelli;

            //    int PatientIDSet = ((from prd in DCMDC.TBL_Patients
            //                         where prd.NationalCode == CodeMelli
            //                         select new
            //                         {
            //                             prd.PatientID
            //                         }).Union(
            //                        from prd in DCMDC.TBL_DelPatients
            //                        where prd.NationalCode == CodeMelli
            //                        select new
            //                        {
            //                            prd.PatientID
            //                        })).Single().PatientID;

            //    int DoctorIDSet = ((from prd in DCMDC.TBL_Patients
            //                        where prd.PatientID == PatientIDSet
            //                        select new
            //                        {
            //                            prd.LastDocHealthId
            //                        }).Union(
            //                     from prd in DCMDC.TBL_DelPatients
            //                     where prd.PatientID == PatientIDSet
            //                     select new
            //                     {
            //                         prd.LastDocHealthId
            //                     })).Single().LastDocHealthId.Value;

            //    DateTime LastOverhalDate = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(j, "تاریخ روز ویزیت").ToString());

            //    int? RetValue = 0;

            //    try
            //    {
            //        DCMDC.SP_InsertPatientVisit(PatientIDSet, false, DoctorIDSet, true, LastOverhalDate, 0, false, "", "", "",
            //            Convert.ToInt16(gridView_ImportExcel.GetRowCellValue(j, "زوج/فرد").ToString()),
            //            //gridView_ImportExcel.GetRowCellValue(j, "وضعیت").ToString(), 
            //            "تاييد و ارسال",
            //            ref RetValue);
            //        if (RetValue.Value == 0)
            //        {
            //            string VisitDateCurrent = gridView_ImportExcel.GetRowCellValue(j, "تاریخ روز ویزیت").ToString();
            //            VisitDateCurrent = (from prd in DCMDC.VW_PatientVisits
            //                                where prd.PatientID == PatientIDSet && prd.VisitDate.Substring(0, 7) == VisitDateCurrent.Substring(0, 7)
            //                                select new
            //                                {
            //                                    prd.VisitDate
            //                                }).Single().VisitDate;


            //            if ((from prd in DCMDC.VW_PatientVisits
            //                 where prd.PatientID == PatientIDSet && prd.VisitDate == VisitDateCurrent && prd.VisitStatus == "تاييد و ارسال"
            //                 select prd).Count() != 0)
            //            {
            //                listViewErrore.Items.Add("ردیف " + (j + 1).ToString() + ": در ماه درخواستی ویزیت جهت بیمار مذکور به همراه مورد مالی ثبت شده است!");
            //                listViewErrore.Items[CntCheck].SubItems.Add(j.ToString());
            //                CntCheck++;
            //            }
            //            else
            //            {

            //                string DateNow = Global_Cls.MiladiDateToShamsi(DateTime.Now);
            //                int sint = Convert.ToInt32(Math.Round((Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()) * Convert.ToDecimal((from sd in DCSDC.TBL_Settings where sd.Name == "DefCostCo" select sd).Single().value) / 100),0));

            //                int DoctorIDCurrent = (from prd in DCMDC.VW_PatientVisits
            //                                       where prd.PatientID == PatientIDSet && prd.VisitDate == VisitDateCurrent
            //                                       select new
            //                                       {
            //                                           prd.DoctorID
            //                                       }).Single().DoctorID.Value;
            //                int VisitCodeCurrent = (from prd in DCMDC.VW_PatientVisits
            //                                        where prd.PatientID == PatientIDSet && prd.VisitDate == VisitDateCurrent
            //                                        select new
            //                                        {
            //                                            prd.VisitCode
            //                                        }).Single().VisitCode;


            //                DCSDC.SP_InsertVisitDoctorPayment(
            //                    DoctorIDCurrent,
            //                    PatientIDSet,
            //                    VisitCodeCurrent,
            //                    VisitDateCurrent,
            //                    "پرداخت عادی",
            //                    "آماده پرداخت",
            //                    DateNow,
            //                    gridView_ImportExcel.GetRowCellValue(j, "شماره معرفینامه").ToString(),
            //                    gridView_ImportExcel.GetRowCellValue(j, "تاریخ ثبت هزینه").ToString(),
            //                    Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "مبلغ کل").ToString()),
            //                    Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()),
            //                    "",
            //                    "",
            //                    "",
            //                    "",
            //                    "",
            //                    sint,
            //                    0,
            //                    "",
            //                    Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()) - sint,
            //                    0,
            //                    0,
            //                    "",
            //                    ""
            //                    );
            //            }
            //        }
            //        else
            //        {
            //            string DateNow = Global_Cls.MiladiDateToShamsi(DateTime.Now);
            //            int sint = Convert.ToInt32(Math.Round((Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()) * Convert.ToDecimal((from sd in DCSDC.TBL_Settings where sd.Name == "DefCostCo" select sd).Single().value) / 100),0));

            //            DCSDC.SP_InsertVisitDoctorPayment(
            //                DoctorIDSet,
            //                PatientIDSet,
            //                RetValue.Value,
            //                gridView_ImportExcel.GetRowCellValue(j, "تاریخ روز ویزیت").ToString(),
            //                "پرداخت عادی",
            //                "آماده پرداخت",
            //                DateNow,
            //                gridView_ImportExcel.GetRowCellValue(j, "شماره معرفینامه").ToString(),
            //                gridView_ImportExcel.GetRowCellValue(j, "تاریخ ثبت هزینه").ToString(),
            //                Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "مبلغ کل").ToString()),
            //                Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()),
            //                "",
            //                "",
            //                "",
            //                "",
            //                "",
            //                sint,
            //                0,
            //                "",
            //                Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()) - sint,
            //                0,
            //                0,
            //                "",
            //                ""
            //                );
            //        }
            //    }
            //    catch
            //    {
            //        listViewErrore.Items.Add("ردیف " + (j + 1).ToString() + ": اشکال ثبت ویزیت نامشخص!");
            //        listViewErrore.Items[CntCheck].SubItems.Add(j.ToString());
            //        CntCheck++;
            //    }
            //}

            //if (CntCheck - Cd == 0)
            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SInformation, false, "اطلاعات ویزیت بیماران به طور کامل در سیستم درج گردید");
            //else
            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات ویزیت بیماران به غیر از اشکال دارها در سیستم درج گردید");
        


            ////فقط جهت ثبت بدون پرداختی ها
            DataClasses_MainDataContext DCMDC = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            DataClassesSecondDataContext DCSDC = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);

            if (gridView_ImportExcel.RowCount == 0)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات پر نشده است");
                textBoxPatientID.Focus();
                return;
            }

            listViewErrore.Items.Clear();
            int CntCheck = 0, Cd = 0;
            for (int i = 0; i < gridView_ImportExcel.RowCount; i++)
            {

                System.Windows.Forms.Application.DoEvents();

                if (gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString() == "")
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی خالی می باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

                if (gridView_ImportExcel.GetRowCellValue(i, "کدملی").ToString().Length > 10)
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

                    if ((from jh in DCMDC.TBL_DelPatients where jh.NationalCode == CodeMelli select jh).Count() > 0)
                    {
                        //listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": جهت اطلاع: بیمار مورد نظر در لیست بیماران بایگانی وجود دارد");
                        //listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                        //CntCheck++;
                        // Cd++;
                    }
                    else

                        if ((from jh in DCMDC.TBL_Patients where jh.NationalCode == CodeMelli select jh).Count() == 0)
                        {
                            listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی بیمار مورد نظر در لیست بیماران وجود ندارد");
                            listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                            CntCheck++;
                        }
                }
                catch
                {
                }


                if (gridView_ImportExcel.GetRowCellValue(i, "تاریخ روز ویزیت").ToString() == "")
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": تاریخ روز ویزیت خالی می باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

                try
                {
                    DateTime dt = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(i, "تاریخ روز ویزیت").ToString());
                }
                catch
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": فرمت تاریخ روز ویزیت دارای اشکال می باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

                //if (gridView_ImportExcel.GetRowCellValue(i, "شماره معرفینامه").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": شماره معرفینامه خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}



                //if (gridView_ImportExcel.GetRowCellValue(i, "تاریخ ثبت هزینه").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": تاریخ ثبت هزینه خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                //try
                //{
                //    DateTime dt = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(i, "تاریخ ثبت هزینه").ToString());
                //}
                //catch
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": فرمت تاریخ ثبت هزینه دارای اشکال می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}


                // if (gridView_ImportExcel.GetRowCellValue(i, "سهم بیمه ایران").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": سهم بیمه ایران خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}
                //try
                //{
                //    int dcost = Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(i, "سهم بیمه ایران").ToString());
                //}
                //catch
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": مقدار فیلد سهم بیمه ایران عددی نمی باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}



                //if (gridView_ImportExcel.GetRowCellValue(i, "مبلغ کل").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": مبلغ کل خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}
                //try
                //{
                //    int dcost = Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(i, "مبلغ کل").ToString());
                //}
                //catch
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": مقدار فیلد مبلغ کل عددی نمی باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}



                //if (gridView_ImportExcel.GetRowCellValue(i, "وضعیت").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": وضعیت خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                if (gridView_ImportExcel.GetRowCellValue(i, "زوج/فرد").ToString() == "")
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": زوج/فرد خالی می باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

                if (gridView_ImportExcel.GetRowCellValue(i, "زوج/فرد").ToString() != "0" && gridView_ImportExcel.GetRowCellValue(i, "زوج/فرد").ToString() != "1")
                {
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": زوج/فرد فقط بایستی 0 یا 1 باشد");
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

                try
                {
                    if ((from jh in DCMDC.TBL_Doctors
                         where (jh.DoctorName + jh.DoctorFamily).Replace(" ", "") == gridView_ImportExcel.GetRowCellValue(i, "پزشک سلامت").ToString().Replace(" ", "")
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
            //if (CntCheck - Cd != 0) return;
            if (CntCheck != 0) return;


            for (int f = 0; f < gridView_ImportExcel.RowCount; f++)
            {
                System.Windows.Forms.Application.DoEvents();



                string CodeMelli = gridView_ImportExcel.GetRowCellValue(f, "کدملی").ToString();
                if (CodeMelli.Length < 10)
                    for (int h = 0; h < 10 - gridView_ImportExcel.GetRowCellValue(f, "کدملی").ToString().Length; h++)
                        CodeMelli = "0" + CodeMelli;

                int PatientIDSet = ((from prd in DCMDC.TBL_Patients
                                     where prd.NationalCode == CodeMelli
                                     select new
                                     {
                                         prd.PatientID
                                     }).Union(
                                    from prd in DCMDC.TBL_DelPatients
                                    where prd.NationalCode == CodeMelli
                                    select new
                                    {
                                        prd.PatientID
                                    })).Single().PatientID;

                int DoctorIDSet = 0;

                try
                {
                    if ((from jh in DCMDC.TBL_Doctors
                         where (jh.DoctorName + jh.DoctorFamily).Replace(" ", "") == gridView_ImportExcel.GetRowCellValue(f, "پزشک سلامت").ToString().Replace(" ", "")
                         select jh).Count() > 0)
                        DoctorIDSet = (short)DCMDC.VW_Doctors.First(kk => (kk.DoctorName + kk.DoctorFamily).Replace(" ", "") == gridView_ImportExcel.GetRowCellValue(f, "پزشک سلامت").ToString().Replace(" ", "")).DoctorID;
                    else
                        DoctorIDSet = 0;
                }
                catch
                {
                    DoctorIDSet = 0;
                }

                DateTime LastOverhalDate = Global_Cls.ShamsiDateToMiladi(gridView_ImportExcel.GetRowCellValue(f, "تاریخ روز ویزیت").ToString());
                int? RetValue = 0;

                try
                {
                    DCMDC.SP_InsertPatientVisit(PatientIDSet, false, DoctorIDSet, true, LastOverhalDate, 0, false, "", "", "",
                        Convert.ToInt16(gridView_ImportExcel.GetRowCellValue(f, "زوج/فرد").ToString()),
                        //"تاييد و ارسال",
                        "در انتظار تاييد",
                        ref RetValue);
                    if (RetValue.Value == 0)
                    {
                        listViewErrore.Items.Add("ردیف " + (f + 1).ToString() + ": در ماه درخواستی ویزیت جهت بیمار مذکور ثبت شده است!");
                        listViewErrore.Items[CntCheck].SubItems.Add(f.ToString());
                        CntCheck++;
                    }
                    else
                    {
                        //string DateNow = Global_Cls.MiladiDateToShamsi(DateTime.Now);
                        //int sint = Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()) * Convert.ToInt32((from sd in DCSDC.TBL_Settings where sd.Name == "DefCostCo" select sd).Single().value) / 100;

                        //DCSDC.SP_InsertVisitDoctorPayment(
                        //    DoctorIDSet,
                        //    PatientIDSet,
                        //    RetValue.Value,
                        //    gridView_ImportExcel.GetRowCellValue(j, "تاریخ روز ویزیت").ToString(),
                        //    "پرداخت عادی",
                        //    "آماده پرداخت",
                        //    DateNow,
                        //    gridView_ImportExcel.GetRowCellValue(j, "شماره معرفینامه").ToString(),
                        //    gridView_ImportExcel.GetRowCellValue(j, "تاریخ ثبت هزینه").ToString(),
                        //    Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "مبلغ کل").ToString()),
                        //    Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()),
                        //    "",
                        //    "",
                        //    "",
                        //    "",
                        //    "",
                        //    sint,
                        //    0,
                        //    "",
                        //    Convert.ToInt32(gridView_ImportExcel.GetRowCellValue(j, "سهم بیمه ایران").ToString()) - sint,
                        //    "",
                        //    ""
                        //    );
                    }
                }
                catch
                {
                    listViewErrore.Items.Add("ردیف " + (f + 1).ToString() + ": اشکال ثبت ویزیت نامشخص!");
                    listViewErrore.Items[CntCheck].SubItems.Add(f.ToString());
                    CntCheck++;
                }
            }

            if (CntCheck == 0)
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SInformation, false, "اطلاعات ویزیت بیماران به طور کامل در سیستم درج گردید");
            else
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات ویزیت بیماران به غیر از اشکال دارها در سیستم درج گردید");
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
