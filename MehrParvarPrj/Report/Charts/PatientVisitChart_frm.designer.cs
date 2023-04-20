﻿namespace MehrParvarPrj
{
    partial class PatientVisitChart_frm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.contextMenuStripPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelExMain = new DevComponents.DotNetBar.PanelEx();
            this.chartControlPatientVisit = new DevExpress.XtraCharts.ChartControl();
            this.contextMenuStripPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlPatientVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripPrint
            // 
            this.contextMenuStripPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintToolStripMenuItem});
            this.contextMenuStripPrint.Name = "contextMenuStripPrint";
            this.contextMenuStripPrint.Size = new System.Drawing.Size(97, 26);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.PrintToolStripMenuItem.Text = "چاپ";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // panelExMain
            // 
            this.panelExMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelExMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExMain.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelExMain.Location = new System.Drawing.Point(0, 0);
            this.panelExMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelExMain.Name = "panelExMain";
            this.panelExMain.Size = new System.Drawing.Size(744, 42);
            this.panelExMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelExMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelExMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelExMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExMain.Style.GradientAngle = 90;
            this.panelExMain.TabIndex = 4;
            this.panelExMain.Text = "گزارشات آماری براساس";
            // 
            // chartControlPatientVisit
            // 
            this.chartControlPatientVisit.ContextMenuStrip = this.contextMenuStripPrint;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            xyDiagram1.AxisY.NumericOptions.Precision = 0;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlPatientVisit.Diagram = xyDiagram1;
            this.chartControlPatientVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlPatientVisit.Location = new System.Drawing.Point(0, 42);
            this.chartControlPatientVisit.Name = "chartControlPatientVisit";
            this.chartControlPatientVisit.PaletteName = "Civic";
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendText = "ساعتی";
            series1.Name = "Series 1";
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            this.chartControlPatientVisit.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.chartControlPatientVisit.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chartControlPatientVisit.Size = new System.Drawing.Size(744, 469);
            this.chartControlPatientVisit.TabIndex = 1;
            // 
            // PatientVisitChart_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.Controls.Add(this.chartControlPatientVisit);
            this.Controls.Add(this.panelExMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PatientVisitChart_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "چارت وضعیت بیماران";
            this.Load += new System.EventHandler(this.PatientVisitChart_frm_Load);
            this.contextMenuStripPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlPatientVisit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelExMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrint;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        public DevExpress.XtraCharts.ChartControl chartControlPatientVisit;

    }
}
