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

namespace MehrParvarPrj
{
    public partial class PatientVisitChart_frm : Form
    {
        int _YAxis;
        int _SelTypeChart = 1;
        string _Title = "";

        public PatientVisitChart_frm(int YAxis, int SelTypeChart, string Title)
        {
            InitializeComponent();
            _YAxis = YAxis;
            _SelTypeChart = SelTypeChart;
            _Title = Title;
        }

        
        private void PatientVisitChart_frm_Load(object sender, EventArgs e)
        {
            LoadChart(_SelTypeChart, _YAxis, _Title);
        }

        public void LoadChart(int ChartType, int YAxis, string TitleStr)
        {
            SetTitle(TitleStr);
            SetChartType(ChartType);

            if (ChartType != 3)
            {
                chartControlPatientVisit.Series[0].PointOptions.PointView = DevExpress.XtraCharts.PointView.Values;
                //chartControlPatientVisit.Series[1].PointOptions.PointView = DevExpress.XtraCharts.PointView.Values;
                //chartControlPatientVisit.Series[2].PointOptions.PointView = DevExpress.XtraCharts.PointView.Values;
            }
            else
            {
                chartControlPatientVisit.Series[0].PointOptions.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
                //chartControlPatientVisit.Series[1].PointOptions.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
                //chartControlPatientVisit.Series[2].PointOptions.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
                chartControlPatientVisit.Series[0].ShowInLegend = false;
                //chartControlPatientVisit.Series[1].ShowInLegend = false;
                //chartControlPatientVisit.Series[2].ShowInLegend = false;
            }

            if (YAxis == 1)
                chartControlPatientVisit.Series[0].LegendText = "تعداد ویزیت";
            //else if (YAxis == 2)
            //    chartControlPatientVisit.Series[0].LegendText = "تعداد سرویس ها";
            //else if (YAxis == 3)
            //    chartControlPatientVisit.Series[0].LegendText = "مبالغ سرویس ها";
           // Data(Date1, Date2, WCodeStr, YAxis);

        }

        private void SetTitle(string TitleStr)
        {
            panelExMain.Text = TitleStr;
        }

        private void SortFunc(int SortType)
        {
            if (SortType == 1)
            {
                chartControlPatientVisit.Series[0].SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            }
            else
                if (SortType == 2)
                {
                    chartControlPatientVisit.Series[1].SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
                }
                else if (SortType == 3)
                {
                    chartControlPatientVisit.Series[2].SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
                }
        }

       

        private void SetChartType(int ChartType)
        {
            if (ChartType == 1)
            {
                chartControlPatientVisit.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.Bar);
                //chartControlPatientVisit.Series[1].ChangeView(DevExpress.XtraCharts.ViewType.Bar);
                //chartControlPatientVisit.Series[2].ChangeView(DevExpress.XtraCharts.ViewType.Bar);
            }
            else
                if (ChartType == 2)
                {
                    chartControlPatientVisit.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.Line);
                    //chartControlPatientVisit.Series[1].ChangeView(DevExpress.XtraCharts.ViewType.Line);
                    //chartControlPatientVisit.Series[2].ChangeView(DevExpress.XtraCharts.ViewType.Line);
                }
                else
                    if (ChartType == 3)
                    {
                        chartControlPatientVisit.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.Pie3D);
                        //chartControlPatientVisit.Series[1].ChangeView(DevExpress.XtraCharts.ViewType.Pie3D);
                        //chartControlPatientVisit.Series[2].ChangeView(DevExpress.XtraCharts.ViewType.Pie3D);
                    }
                    else
                        if (ChartType == 4)
                        {
                            chartControlPatientVisit.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.ManhattanBar);
                            //chartControlPatientVisit.Series[1].ChangeView(DevExpress.XtraCharts.ViewType.ManhattanBar);
                            //chartControlPatientVisit.Series[2].ChangeView(DevExpress.XtraCharts.ViewType.ManhattanBar);
                        }
        }



        
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chartControlPatientVisit.ShowPrintPreview(DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch);
            PrintPreview_frm PP = new PrintPreview_frm(chartControlPatientVisit);
            PP.ShowDialog();
        }
    }
}
