using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Collections.Generic;

namespace MehrParvarPrj.Report.Forms
{
    public partial class DoctorVisitFewReport : DevExpress.XtraReports.UI.XtraReport
    {
        private MehrParvarPrj.DataLinq.DataClassesSecondDataContext DCDC = new MehrParvarPrj.DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        public DoctorVisitFewReport(string DateStart, string DateEnd, string HeaderText1, string HeaderText2, string HeaderText3, Image ImageSet)
        {
            InitializeComponent();
            var gg = new List<DataLinq.CLS_SPDoctorVisitFewReport>();

            var gg1 = (from l in DCDC.SP_DoctorVisitFewReport(DateStart, DateEnd)
                       select
                       new
                       {
                           l.TelHome,
                           l.ParentName,
                           l.NationalCode,
                           l.SpecialDisease,
                           l.Mobile,
                           l.CountAdd,
                           l.CountAll,
                           l.CountEven,
                           l.LocationPart,
                           l.MedicalCode,
                           l.CountVisitStatusNoOdati,
                           l.CountVisitStatusOdati,
                           l.DoctorNameF,
                           l.TelBusiness
                       }).AsEnumerable()
                        .Select((l, j) => new
                        {
                            RowNumber = j + 1,
                            l.TelHome,
                            l.ParentName,
                            l.NationalCode,
                            l.SpecialDisease,
                            l.Mobile,
                            l.CountAdd,
                            l.CountAll,
                            l.CountEven,
                            l.LocationPart,
                            l.MedicalCode,
                            l.CountVisitStatusNoOdati,
                            l.CountVisitStatusOdati,
                            l.DoctorNameF,
                            l.TelBusiness
                        }).ToList();

            bindingSource1.DataMember = "CLS_SPDoctorVisitFewReport";
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
