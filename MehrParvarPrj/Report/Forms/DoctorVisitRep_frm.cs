using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.Properties;
using System.Globalization;

namespace MehrParvarPrj
{
    public partial class DoctorVisitRep_frm : Form
    {
        public DoctorVisitRep_frm()
        {
            InitializeComponent();
        }

        private MehrParvarPrj.DataLinq.DataClasses_MainDataContext DCDC = new MehrParvarPrj.DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        private void DoctorVisitRep_frm_Load(object sender, EventArgs e)
        {
            SetDateToModules();
        }



        #region Set Date Module

        private void SetDateToModules()
        {
            PersianCalendar farsi = new PersianCalendar();

            System.Globalization.PersianCalendar ps = new System.Globalization.PersianCalendar();
            comboBox_PatientVisitday1.Text = "01";
            comboBox_PatientVisitMonth1.Text = ps.GetMonth(DateTime.Now).ToString("00");
            comboBox_PatientVisitYear1.Text = ps.GetYear(DateTime.Now).ToString();

            comboBox_PatientVisitDay2.Text = ps.GetMonth(DateTime.Now) <= 6 ? "31" : ps.GetMonth(DateTime.Now) == 12 ? "29" : "30";
            comboBox_PatientVisitMonth2.Text = ps.GetMonth(DateTime.Now).ToString("00");
            comboBox_PatientVisitYear2.Text = ps.GetYear(DateTime.Now).ToString();
        }

        private void panel_DPatientVisit1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_PatientVisitMonth1.Text) > 6 && Convert.ToInt16(comboBox_PatientVisitday1.Text) == 31) comboBox_PatientVisitday1.Text = "30";
            if (Convert.ToInt16(comboBox_PatientVisitMonth1.Text) == 12 && (Convert.ToInt16(comboBox_PatientVisitday1.Text) == 31 || Convert.ToInt16(comboBox_PatientVisitday1.Text) == 30)) comboBox_PatientVisitday1.Text = "29";
        }


        private void panel_DPatientVisit2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_PatientVisitMonth2.Text) > 6 && Convert.ToInt16(comboBox_PatientVisitDay2.Text) == 31) comboBox_PatientVisitDay2.Text = "30";
            if (Convert.ToInt16(comboBox_PatientVisitMonth2.Text) == 12 && (Convert.ToInt16(comboBox_PatientVisitDay2.Text) == 31 || Convert.ToInt16(comboBox_PatientVisitDay2.Text) == 30)) comboBox_PatientVisitDay2.Text = "29";
        }

        #endregion


        #region Preview Chart

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            //DateTime DateStart = Global_Cls.ShamsiDateToMiladi(comboBox_PatientVisitYear1.Text, comboBox_PatientVisitMonth1.Text, comboBox_PatientVisitday1.Text);
            //DateTime DateEnd = Global_Cls.ShamsiDateToMiladi(comboBox_PatientVisitYear2.Text, comboBox_PatientVisitMonth2.Text, comboBox_PatientVisitDay2.Text);
            
            string DateStart = comboBox_PatientVisitYear1.Text+"/"+comboBox_PatientVisitMonth1.Text+"/"+comboBox_PatientVisitday1.Text;
            string DateEnd = comboBox_PatientVisitYear2.Text+"/"+comboBox_PatientVisitMonth2.Text+"/"+comboBox_PatientVisitDay2.Text;

            if (RadioButtonFunctionalityDoctorPrice.Checked)
            {
                Report.Forms.DoctorVisitCostReport PT = new Report.Forms.DoctorVisitCostReport(DateStart, DateEnd, textBoxHeader1.Text, textBoxHeader2.Text, textBoxHeader3.Text, pictureBoxLogoSet.Image, checkBoxLetterDate.Checked);
                PrintPreview_frm PP = new PrintPreview_frm(PT);
                PP.ShowDialog();
            }
            else if (RadioButtonFunctionalityDoctorPriceNew.Checked)
            {
                Report.Forms.DoctorVisitCostReportNew PT = new Report.Forms.DoctorVisitCostReportNew(DateStart, DateEnd, textBoxHeader1.Text, textBoxHeader2.Text, textBoxHeader3.Text, pictureBoxLogoSet.Image, checkBoxLetterDateNew.Checked);
                PrintPreview_frm PP = new PrintPreview_frm(PT);
                PP.ShowDialog();
            }
            else if (RadioButtonFunctionalityDoctorVisit.Checked)
            {
                Report.Forms.DoctorVisitFewReport PT = new Report.Forms.DoctorVisitFewReport(DateStart, DateEnd, textBoxHeader1.Text, textBoxHeader2.Text, textBoxHeader3.Text, pictureBoxLogoSet.Image);
                PrintPreview_frm PP = new PrintPreview_frm(PT);
                PP.ShowDialog();
            }
            else if (RadioButtonBilanDoctorCost.Checked)
            {
                if (textBoxDoctorName.Tag == null) Global_Cls.Message_MehrGostar("لطفا نام پزشک را مشخص نمایید", Global_Cls.MessageType.SError);
                else
                {
                    Report.Forms.DoctorVisitBilanCostReport PT = new Report.Forms.DoctorVisitBilanCostReport(DateStart, DateEnd, textBoxHeader1.Text, textBoxHeader2.Text, textBoxHeader3.Text, pictureBoxLogoSet.Image, Convert.ToInt32(textBoxDoctorName.Tag.ToString()), checkBoxSeparateDate.Checked);
                    PrintPreview_frm PP = new PrintPreview_frm(PT);
                    PP.ShowDialog();
                }
            }

        }
            //if (RadioButtonAddressPart.Checked)
            //{
            //    DCDC.Tbl_temps.DeleteAllOnSubmit(DCDC.Tbl_temps);
            //    DCDC.SubmitChanges();

            //    foreach (DevComponents.DotNetBar.CheckBoxItem AP in itemPanel_AddressPart.Items)
            //    {
            //        if (AP.Checked)
            //        {
            //            DataLinq.Tbl_temp f = new DataLinq.Tbl_temp();
            //            f.id = int.Parse(AP.Name);
            //            DCDC.Tbl_temps.InsertOnSubmit(f);
            //            DCDC.SubmitChanges();
            //        }
            //    }
            //}

            //var gg = new List<DataLinq.CLS_BedsorePosition>();

            ////bedsore
            //if (RadioButtonFunctionalityDoctorPrice.Checked)
            //{
            //    if (chkbedsore.Checked)
            //        gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(0, true, "", null, null) select l).ToList();
            //    //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Bedsore.Items)
            //    //{
            //    //    if (Ch.Checked)
            //    //        gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(0, false, Ch.Name, null, null) select l).ToList();
            //    //}

            //    for (int i = 0; i < listViewBedsore.Items.Count; i++)
            //        gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(0, false, listViewBedsore.Items[i].Text, null, null) select l).ToList();
            //}
            //else
            //    if (RadioButtonFunctionalityDoctorVisit.Checked)
            //    {
            //        if (chkbedsore.Checked)
            //            gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(1, true, "", DateStart, DateEnd) select l).ToList();
            //        //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Bedsore.Items)
            //        //{
            //        //    if (Ch.Checked)
            //        //        gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(1, false, Ch.Name, DateStart, DateEnd) select l).ToList();
            //        //}
            //        for (int i = 0; i < listViewBedsore.Items.Count; i++)
            //            gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(1, false, listViewBedsore.Items[i].Text, DateStart, DateEnd) select l).ToList();
            //    }
            //    else
            //        if (RadioButtonAddressPart.Checked)
            //        {
            //            if (chkbedsore.Checked)
            //                gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(2, true, "", null, null) select l).ToList();
            //            //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Bedsore.Items)
            //            //{
            //            //    if (Ch.Checked)
            //            //        gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(2, false, Ch.Name, null, null) select l).ToList();
            //            //}
            //            for (int i = 0; i < listViewBedsore.Items.Count; i++)
            //                gg = gg.Union(from l in DCDC.SP_ChartVisitBedsore(2, false, listViewBedsore.Items[i].Text, null, null) select l).ToList();
            //        }


            ////Drugs
            //if (RadioButtonFunctionalityDoctorPrice.Checked)
            //{
            //    if (chkDrugsHistory.Checked)
            //        gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(0, true, 0, null, null) select l).ToList();
            //    //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_DrugsHistory.Items)
            //    //{
            //    //    if (Ch.Checked)
            //    //        gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(0, false, int.Parse(Ch.Name), null, null) select l).ToList();
            //    //}
            //    for (int i = 0; i < listViewDrugsHistory.Items.Count; i++)
            //        gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(0, false, int.Parse(listViewDrugsHistory.Items[i].Tag.ToString()), null, null) select l).ToList();
            //}
            //else
            //    if (RadioButtonFunctionalityDoctorVisit.Checked)
            //    {
            //        if (chkDrugsHistory.Checked)
            //            gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(1, true, 0, DateStart, DateEnd) select l).ToList();
            //        //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_DrugsHistory.Items)
            //        //{
            //        //    if (Ch.Checked)
            //        //        gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(1, false, int.Parse(Ch.Name), DateStart, DateEnd) select l).ToList();
            //        //}
            //        for (int i = 0; i < listViewDrugsHistory.Items.Count; i++)
            //            gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(1, false, int.Parse(listViewDrugsHistory.Items[i].Tag.ToString()), DateStart, DateEnd) select l).ToList();
            //    }
            //    else
            //        if (RadioButtonAddressPart.Checked)
            //        {
            //            if (chkDrugsHistory.Checked)
            //                gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(2, true, 0, null, null) select l).ToList();
            //            //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_DrugsHistory.Items)
            //            //{
            //            //    if (Ch.Checked)
            //            //        gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(2, false, int.Parse(Ch.Name), null, null) select l).ToList();
            //            //}
            //            for (int i = 0; i < listViewDrugsHistory.Items.Count; i++)
            //                gg = gg.Union(from l in DCDC.SP_ChartVisitDrugs(2, false, int.Parse(listViewDrugsHistory.Items[i].Tag.ToString()), null, null) select l).ToList();
            //        }


            ////Paraclinics
            //if (RadioButtonFunctionalityDoctorPrice.Checked)
            //{
            //    if (chkParaclinic.Checked)
            //        gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(0, true, 0, null, null) select l).ToList();
            //    //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Paraclinic.Items)
            //    //{
            //    //    if (Ch.Checked)
            //    //        gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(0, false, int.Parse(Ch.Name), null, null) select l).ToList();
            //    //}
            //    for (int i = 0; i < listViewParaclinic.Items.Count; i++)
            //        gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(0, false, int.Parse(listViewParaclinic.Items[i].Tag.ToString()), null, null) select l).ToList();
            //}
            //else
            //    if (RadioButtonFunctionalityDoctorVisit.Checked)
            //    {
            //        if (chkParaclinic.Checked)
            //            gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(1, true, 0, DateStart, DateEnd) select l).ToList();
            //        //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Paraclinic.Items)
            //        //{
            //        //    if (Ch.Checked)
            //        //        gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(1, false, int.Parse(Ch.Name), DateStart, DateEnd) select l).ToList();
            //        //}
            //        for (int i = 0; i < listViewParaclinic.Items.Count; i++)
            //            gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(1, false, int.Parse(listViewParaclinic.Items[i].Tag.ToString()), DateStart, DateEnd) select l).ToList();
            //    }
            //    else
            //        if (RadioButtonAddressPart.Checked)
            //        {
            //            if (chkParaclinic.Checked)
            //                gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(2, true, 0, null, null) select l).ToList();
            //            //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Paraclinic.Items)
            //            //{
            //            //    if (Ch.Checked)
            //            //        gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(2, false, int.Parse(Ch.Name), null, null) select l).ToList();
            //            //}
            //            for (int i = 0; i < listViewParaclinic.Items.Count; i++)
            //                gg = gg.Union(from l in DCDC.SP_ChartVisitParaclinics(2, false, int.Parse(listViewParaclinic.Items[i].Tag.ToString()), null, null) select l).ToList();
            //        }


            ////Sickness
            //if (RadioButtonFunctionalityDoctorPrice.Checked)
            //{
            //    if (chkStateSickness.Checked)
            //        gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(0, true, 0, null, null) select l).ToList();
            //    //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_StateSickness.Items)
            //    //{
            //    //    if (Ch.Checked)
            //    //        gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(0, false, int.Parse(Ch.Name), null, null) select l).ToList();
            //    //}
            //    for (int i = 0; i < listViewStateSickness.Items.Count; i++)
            //        gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(0, false, int.Parse(listViewStateSickness.Items[i].Tag.ToString()), null, null) select l).ToList();

            //}
            //else
            //    if (RadioButtonFunctionalityDoctorVisit.Checked)
            //    {
            //        if (chkStateSickness.Checked)
            //            gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(1, true, 0, DateStart, DateEnd) select l).ToList();
            //        //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_StateSickness.Items)
            //        //{
            //        //    if (Ch.Checked)
            //        //        gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(1, false, int.Parse(Ch.Name), DateStart, DateEnd) select l).ToList();
            //        //}
            //        for (int i = 0; i < listViewStateSickness.Items.Count; i++)
            //            gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(1, false, int.Parse(listViewStateSickness.Items[i].Tag.ToString()), DateStart, DateEnd) select l).ToList();
            //    }
            //    else
            //        if (RadioButtonAddressPart.Checked)
            //        {
            //            if (chkStateSickness.Checked)
            //                gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(2, true, 0, null, null) select l).ToList();
            //            //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_StateSickness.Items)
            //            //{
            //            //    if (Ch.Checked)
            //            //        gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(2, false, int.Parse(Ch.Name), null, null) select l).ToList();
            //            //}
            //            for (int i = 0; i < listViewStateSickness.Items.Count; i++)
            //                gg = gg.Union(from l in DCDC.SP_ChartVisitSicknesss(2, false, int.Parse(listViewStateSickness.Items[i].Tag.ToString()), null, null) select l).ToList();
            //        }






            ////Sel Type Chart
            //int SelTypeChart = comboBox_ChartType.SelectedIndex == -1 ? 0 : comboBox_ChartType.SelectedIndex;

            //string Tit = "";
            //if (RadioButtonFunctionalityDoctorPrice.Checked)
            //    Tit = "گزارش تعداد ویزیت بیماران";
            //else
            //    if (RadioButtonFunctionalityDoctorVisit.Checked)
            //        Tit = " گزارش ویزیت بیماران از تاریخ " + comboBox_PatientVisitYear1.Text + "/" + comboBox_PatientVisitMonth1.Text + "/" + comboBox_PatientVisitday1.Text + " تا تاریخ " + comboBox_PatientVisitYear2.Text + "/" + comboBox_PatientVisitMonth2.Text + "/" + comboBox_PatientVisitDay2.Text;
            //    else
            //        if (RadioButtonAddressPart.Checked)
            //            Tit = "گزارش ویزیت بیماران برحسب مناطق";

            //PatientVisitChart_frm CC = new PatientVisitChart_frm(1, SelTypeChart + 1, Tit);

            //CC.chartControlPatientVisit.DataSource = gg;

            //CC.chartControlPatientVisit.Series[0].DataSource = gg;
            //CC.chartControlPatientVisit.Series[0].ArgumentDataMember = "NameAxis";
            //CC.chartControlPatientVisit.Series[0].ValueDataMembers[0] = "CountAxis";

            //CC.ShowDialog();

        //}

        //private void buttonItemAnd_Click(object sender, EventArgs e)
        //{
        //    DateTime DateStart = Global_Cls.ShamsiDateToMiladi(comboBox_PatientVisitYear1.Text, comboBox_PatientVisitMonth1.Text, comboBox_PatientVisitday1.Text);
        //    DateTime DateEnd = Global_Cls.ShamsiDateToMiladi(comboBox_PatientVisitYear2.Text, comboBox_PatientVisitMonth2.Text, comboBox_PatientVisitDay2.Text);
        //    if (RadioButtonAddressPart.Checked)
        //    {
        //        DCDC.Tbl_temps.DeleteAllOnSubmit(DCDC.Tbl_temps);
        //        DCDC.SubmitChanges();

        //        foreach (DevComponents.DotNetBar.CheckBoxItem AP in itemPanel_AddressPart.Items)
        //        {
        //            if (AP.Checked)
        //            {
        //                DataLinq.Tbl_temp f = new DataLinq.Tbl_temp();
        //                f.id = int.Parse(AP.Name);
        //                DCDC.Tbl_temps.InsertOnSubmit(f);
        //                DCDC.SubmitChanges();
        //            }
        //        }
        //    }

        //    var gg = new List<DataLinq.CLS_BedsorePosition>();
        //    string WhereStr = "";

        //    //bedsore
        //    if (chkbedsore.Checked)
        //        WhereStr += "زخم بستر,";
        //    //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Bedsore.Items)
        //    //{
        //    //    if (Ch.Checked)
        //    //        WhereStr += Ch.Text + ",";
        //    //}
        //    for (int i = 0; i < listViewBedsore.Items.Count; i++)
        //        WhereStr += listViewBedsore.Items[i].Text + ",";

        //    //Drugs
        //    if (chkDrugsHistory.Checked)
        //        WhereStr += "داروی مصرفی,";
        //    //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_DrugsHistory.Items)
        //    //{
        //    //    if (Ch.Checked)
        //    //        WhereStr += Ch.Text + ",";
        //    //}
        //    for (int i = 0; i < listViewDrugsHistory.Items.Count; i++)
        //        WhereStr += listViewDrugsHistory.Items[i].Text + ",";

        //    //Paraclinic
        //    if (chkParaclinic.Checked)
        //        WhereStr += "پاراکلینیک,";
        //    //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Paraclinic.Items)
        //    //{
        //    //    if (Ch.Checked)
        //    //        WhereStr += Ch.Text + ",";
        //    //}
        //    for (int i = 0; i < listViewParaclinic.Items.Count; i++)
        //        WhereStr += listViewParaclinic.Items[i].Text + ",";



        //    //Sickness
        //    if (chkStateSickness.Checked)
        //        WhereStr += "بیماری ندارد,";
        //    //foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_StateSickness.Items)
        //    //{
        //    //    if (Ch.Checked)
        //    //        WhereStr += Ch.Text + ",";
        //    //}

        //    for (int i = 0; i < listViewStateSickness.Items.Count; i++)
        //        WhereStr += listViewStateSickness.Items[i].Text + ",";

        //    try
        //    {
        //        WhereStr = WhereStr.Remove(WhereStr.Length - 1, 1);
        //    }
        //    catch { }


        //    if (RadioButtonFunctionalityDoctorPrice.Checked)
        //        gg = gg.Union(from l in DCDC.SP_ChartVisitAll(0, WhereStr, null, null) select l).ToList();
        //    else
        //        if (RadioButtonFunctionalityDoctorVisit.Checked)
        //            gg = gg.Union(from l in DCDC.SP_ChartVisitAll(1, WhereStr, DateStart, DateEnd) select l).ToList();
        //        else
        //            if (RadioButtonAddressPart.Checked)
        //                gg = gg.Union(from l in DCDC.SP_ChartVisitAll(2, WhereStr, null, null) select l).ToList();


        //    //Sel Type Chart
        //    int SelTypeChart = comboBox_ChartType.SelectedIndex == -1 ? 0 : comboBox_ChartType.SelectedIndex;

        //    string Tit = "";
        //    if (RadioButtonFunctionalityDoctorPrice.Checked)
        //        Tit = "گزارش تعداد ویزیت بیماران";
        //    else
        //        if (RadioButtonFunctionalityDoctorVisit.Checked)
        //            Tit = " گزارش ویزیت بیماران از تاریخ " + comboBox_PatientVisitYear1.Text + "/" + comboBox_PatientVisitMonth1.Text + "/" + comboBox_PatientVisitday1.Text + " تا تاریخ " + comboBox_PatientVisitYear2.Text + "/" + comboBox_PatientVisitMonth2.Text + "/" + comboBox_PatientVisitDay2.Text;
        //        else
        //            if (RadioButtonAddressPart.Checked)
        //                Tit = "گزارش ویزیت بیماران برحسب مناطق";

        //    PatientVisitChart_frm CC = new PatientVisitChart_frm(1, SelTypeChart + 1, Tit);

        //    CC.chartControlPatientVisit.DataSource = gg;

        //    CC.chartControlPatientVisit.Series[0].DataSource = gg;
        //    CC.chartControlPatientVisit.Series[0].ArgumentDataMember = "NameAxis";
        //    CC.chartControlPatientVisit.Series[0].ValueDataMembers[0] = "CountAxis";

        //    CC.ShowDialog();
        //}


        #endregion



        #region Buttons Click

        //private void ButtonStateSickness_Click(object sender, EventArgs e)
        //{
        //    SelectPerson_frm sp = new SelectPerson_frm(4);
        //    sp.ShowDialog();
        //    if (sp.CodeC != 0)
        //    {
        //        if (listViewStateSickness.Items.ContainsKey(sp.CodeC.ToString())) return;

        //        listViewStateSickness.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
        //        listViewStateSickness.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
        //    }
        //}

        //private void BottomStateSicknessDel_Click(object sender, EventArgs e)
        //{
        //    int gh = listViewStateSickness.SelectedItems.Count;
        //    for (int i = 0; i < gh; i++)
        //        listViewStateSickness.SelectedItems[0].Remove();
        //}

        //private void ButtonBedsore_Click(object sender, EventArgs e)
        //{
        //    SelectPerson_frm sp = new SelectPerson_frm(5);
        //    sp.ShowDialog();
        //    if (sp.CodeC != 0)
        //    {
        //        if (listViewBedsore.Items.ContainsKey(sp.CodeC.ToString())) return;

        //        listViewBedsore.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
        //        listViewBedsore.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
        //    }
        //}

        //private void ButtonBedsoreDel_Click(object sender, EventArgs e)
        //{
        //    int gh = listViewBedsore.SelectedItems.Count;
        //    for (int i = 0; i < gh; i++)
        //        listViewBedsore.SelectedItems[0].Remove();
        //}



        //private void ButtonDrugsHistory_Click(object sender, EventArgs e)
        //{
        //    SelectPerson_frm sp = new SelectPerson_frm(2);
        //    sp.ShowDialog();
        //    if (sp.CodeC != 0)
        //    {
        //        if (listViewDrugsHistory.Items.ContainsKey(sp.CodeC.ToString())) return;

        //        listViewDrugsHistory.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
        //        listViewDrugsHistory.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
        //    }
        //}

        //private void ButtonDrugsHistoryDel_Click(object sender, EventArgs e)
        //{
        //    int gh = listViewDrugsHistory.SelectedItems.Count;
        //    for (int i = 0; i < gh; i++)
        //        listViewDrugsHistory.SelectedItems[0].Remove();
        //}

        //private void ButtonParaclinic_Click(object sender, EventArgs e)
        //{
        //    SelectPerson_frm sp = new SelectPerson_frm(6);
        //    sp.ShowDialog();
        //    if (sp.CodeC != 0)
        //    {
        //        if (listViewParaclinic.Items.ContainsKey(sp.CodeC.ToString())) return;

        //        listViewParaclinic.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
        //        listViewParaclinic.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
        //    }
        //}

        //private void ButtonParaclinicDel_Click(object sender, EventArgs e)
        //{
        //    int gh = listViewParaclinic.SelectedItems.Count;
        //    for (int i = 0; i < gh; i++)
        //        listViewParaclinic.SelectedItems[0].Remove();
        //}

        #endregion

        private void buttonItem_list_Click(object sender, EventArgs e)
        {
            //DateTime DateStart = Global_Cls.ShamsiDateToMiladi(comboBox_PatientVisitYear1.Text, comboBox_PatientVisitMonth1.Text, comboBox_PatientVisitday1.Text);
            //DateTime DateEnd = Global_Cls.ShamsiDateToMiladi(comboBox_PatientVisitYear2.Text, comboBox_PatientVisitMonth2.Text, comboBox_PatientVisitDay2.Text);
            //if (RadioButtonAddressPart.Checked)
            //{
            //    DCDC.Tbl_temps.DeleteAllOnSubmit(DCDC.Tbl_temps);
            //    DCDC.SubmitChanges();

            //    foreach (DevComponents.DotNetBar.CheckBoxItem AP in itemPanel_AddressPart.Items)
            //    {
            //        if (AP.Checked)
            //        {
            //            DataLinq.Tbl_temp f = new DataLinq.Tbl_temp();
            //            f.id = int.Parse(AP.Name);
            //            DCDC.Tbl_temps.InsertOnSubmit(f);
            //            DCDC.SubmitChanges();
            //        }
            //    }
            //}

            //var gg = new List<DataLinq.VW_PatientVisit>();

           
            //{

            //    string WhereStr = "";

                //bedsore
            //    if (chkbedsore.Checked)
            //        WhereStr += "زخم بستر,";
            //    foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanelBedsore.Items)
            //    {
            //        if (Ch.Checked)
            //            WhereStr += Ch.Text + ",";
            //    }

            //    //Drugs
            //    if (chkDrugsHistory.Checked)
            //        WhereStr += "داروی مصرفی,";
            //    foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_DrugsHistory.Items)
            //    {
            //        if (Ch.Checked)
            //            WhereStr += Ch.Text + ",";
            //    }

            //    //Paraclinic
            //    if (chkParaclinic.Checked)
            //        WhereStr += "پاراکلینیک,";
            //    foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_Paraclinic.Items)
            //    {
            //        if (Ch.Checked)
            //            WhereStr += Ch.Text + ",";
            //    }



            //    //Sickness
            //    if (chkStateSickness.Checked)
            //        WhereStr += "بیماری ندارد,";
            //    foreach (DevComponents.DotNetBar.CheckBoxItem Ch in itemPanel_StateSickness.Items)
            //    {
            //        if (Ch.Checked)
            //            WhereStr += Ch.Text + ",";
            //    }
            //    try
            //    {
            //        WhereStr = WhereStr.Remove(WhereStr.Length - 1, 1);
            //    }
            //    catch { }


            //    if (RadioButtonLastVisitCode.Checked)
            //        gg = gg.Union(from l in DCDC.SP_ReportVisitAll(0, WhereStr, null, null) select l).ToList();
            //    else
            //        if (RadioButtonPeriod.Checked)
            //            gg = gg.Union(from l in DCDC.SP_ReportVisitAll(1, WhereStr, DateStart, DateEnd) select l).ToList();
            //        else
            //            if (RadioButtonAddressPart.Checked)
            //                gg = gg.Union(from l in DCDC.SP_ReportVisitAll(2, WhereStr, null, null) select l).ToList();

           //}



            ////Sel Type Chart
            //int SelTypeChart = comboBox_ChartType.SelectedIndex == -1 ? 0 : comboBox_ChartType.SelectedIndex;

            //string Tit = "";
            //if (RadioButtonFunctionalityDoctorPrice.Checked)
            //    Tit = "گزارش تعداد ویزیت بیماران";
            //else
            //    if (RadioButtonFunctionalityDoctorVisit.Checked)
            //        Tit = " گزارش ویزیت بیماران از تاریخ " + comboBox_PatientVisitYear1.Text + "/" + comboBox_PatientVisitMonth1.Text + "/" + comboBox_PatientVisitday1.Text + " تا تاریخ " + comboBox_PatientVisitYear2.Text + "/" + comboBox_PatientVisitMonth2.Text + "/" + comboBox_PatientVisitDay2.Text;
            //    else
            //        if (RadioButtonAddressPart.Checked)
            //            Tit = "گزارش ویزیت بیماران برحسب مناطق";

            //ListDoctorVisitReport_frm CC = new ListDoctorVisitReport_frm(true, true, 0, 0);

            //CC.gridControl_ListPatVisit.DataSource = gg;

            //CC.ShowDialog();


        }

        private void buttonItemAnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxLogoSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Image File|*.Jpg;*.Jpeg;*.bmp;*.png;*.tiff;*.tif;*.gif;*.ico";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxLogoSet.Image = System.Drawing.Image.FromFile(op.FileName);
                }
                catch
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, " مسیر فایل و یا سورس فایل نامعتبر است. دوباره سعی کنید ");
                }
            }

        }

        private void button_DelPic_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxLogoSet.Image = null;
                pictureBoxLogoSet.Load("");
            }
            catch { }

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
    }
}
