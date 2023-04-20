using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Collections.Generic;

namespace MehrParvarPrj.Report.Forms
{
    public partial class PatientReport : DevExpress.XtraReports.UI.XtraReport
    {
        private MehrParvarPrj.DataLinq.DataClasses_MainDataContext DCDC = new MehrParvarPrj.DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        public PatientReport(int PatientID)
        {
            InitializeComponent();
            var gg = new List<DataLinq.CLS_SPPatientReport>();

            var gg1 = (from l in DCDC.SP_PatientReport(PatientID) 
                            select new { l.VisitDate, l.TelHome, l.Sickness, l.ReportDate, l.PatientName, 
                                l.PatientFamily, l.Paraclinics, l.NationalCode, l.Mobile, l.Drugs, //l.DosiersNo, 
                                l.BrithDateShamsi, l.Bedsore, l.AddressPart, l.Address }).ToList();

            bindingSource1.DataMember = "CLS_SPPatientReport";
            bindingSource1.DataSource = gg1;
        }

        

    }
}
