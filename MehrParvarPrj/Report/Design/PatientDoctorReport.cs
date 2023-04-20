using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Collections.Generic;

namespace MehrParvarPrj.Report.Forms
{
    public partial class PatientDoctorReport : DevExpress.XtraReports.UI.XtraReport
    {
        private MehrParvarPrj.DataLinq.DataClasses_MainDataContext DCDC = new MehrParvarPrj.DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        public PatientDoctorReport(int PatientID)
        {
            InitializeComponent();
            var gg = new List<DataLinq.CLS_SPPatientDoctorReport>();

            var gg1 = (from l in DCDC.SP_PatientDoctorReport(PatientID) 
                            select new { l.Address, l.TelHome, l.AddressPart, l.BasicInsurance, l.PatientName, 
                                l.PatientFamily, l.BrithDateShamsi, l.NationalCode, l.Mobile, l.CompletionInsurance, l.DosiersNo, 
                                l.InjuryTypeStr, l.PatientTypeStr, l.DoctorName, l.DoctorMobile, l.Age, l.ProtectSituation, l.PercentState,
                                l.ReportDate }).ToList();

            bindingSource1.DataMember = "CLS_SPPatientDoctorReport";
            bindingSource1.DataSource = gg1;
        }

        

    }
}
