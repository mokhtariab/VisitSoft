using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Collections.Generic;

namespace MehrParvarPrj.Report.Forms
{
    public partial class DoctorVisitCostReportNew : DevExpress.XtraReports.UI.XtraReport
    {
        private MehrParvarPrj.DataLinq.DataClassesSecondDataContext DCDC = new MehrParvarPrj.DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        public DoctorVisitCostReportNew(string DateStart, string DateEnd, string HeaderText1, string HeaderText2, string HeaderText3, Image ImageSet, bool LetterDateNew)
        {
            InitializeComponent();

            var gg = new List<DataLinq.CLS_SPDoctorVisitCostReport>();

            var gg1 = (from l in DCDC.SP_DoctorVisitCostReport(DateStart,DateEnd, LetterDateNew ) 
                            select new { 
                                l.BankName, 
                                l.TelHome, 
                                l.CardBankNo1, 
                                l.CardBankNo2, 
                                l.ParentName, 
                                l.DoctorName, 
                                l.DoctorFamily, 
                                l.ContractDate, 
                                l.Mobile, 
                                l.ContractEndDate, 
                                l.MaxVisitCoAdd, 
                                l.CountAdd, 
                                l.CountAll, 
                                l.CountEven, 
                                l.LocationPart, 
                                l.MaxReqInsuAdd, 
                                l.MaxReqInsuEven,
                                l.MaxVisitCoEven,
                                l.MedicalCode,
                                l.NationalCodeDoctor,
                                l.SumAll,
                                l.SUMCostCachInsuIran,
                                l.SumReqInsuAdd,
                                l.SumReqInsuEven,
                                l.SUMVisitCoAdd,
                                l.SUMVisitCoEven,
                                l.sumCostVisitCo,
                                l.TelBusiness
                                   }).AsEnumerable()
                        .Select((l, j) => new
                        {
                            RowNumber = j + 1,
                            l.BankName,
                            l.TelHome,
                            l.CardBankNo1,
                            l.CardBankNo2,
                            l.ParentName,
                            l.DoctorName,
                            l.DoctorFamily,
                            l.ContractDate,
                            l.Mobile,
                            l.ContractEndDate,
                            l.MaxVisitCoAdd,
                            l.CountAdd,
                            l.CountAll,
                            l.CountEven,
                            l.LocationPart,
                            l.MaxReqInsuAdd,
                            l.MaxReqInsuEven,
                            l.MaxVisitCoEven,
                            l.MedicalCode,
                            l.NationalCodeDoctor,
                            l.SumAll,
                            l.SUMCostCachInsuIran,
                            l.SumReqInsuAdd,
                            l.SumReqInsuEven,
                            l.SUMVisitCoAdd,
                            l.SUMVisitCoEven,
                            l.sumCostVisitCo,
                            l.TelBusiness
                        }).ToList();

            bindingSource1.DataMember = "CLS_SPDoctorVisitCostReport";
            bindingSource1.DataSource = gg1;
            
            TableCellHeader1.Text = HeaderText1;
            TableCellHeader2.Text = HeaderText2;
            TableCellHeader3.Text = HeaderText3;

            TableCellDate.Text = "تاریخ گزارش: " + Global_Cls.MiladiDateToShamsi(DateTime.Now);
            TableCellTime.Text = "ساعت گزارش: " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

            PictureBoxSet.Image = ImageSet;
        }
    }
}
