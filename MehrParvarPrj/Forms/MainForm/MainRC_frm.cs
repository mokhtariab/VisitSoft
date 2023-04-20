using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;
using MehrParvarPrj.Properties;
using Microsoft.VisualBasic.FileIO;
using System.Collections.ObjectModel;
using System.Globalization;
using MehrParvarPrj.DataLinq;

namespace MehrParvarPrj
{
    public partial class MainRC_frm : Form
    {

        public MainRC_frm()
        {
            InitializeComponent();
        }

        
        #region All Events in Forms
        

        public string UserPermission;
        private void MainHM_frm_Shown(object sender, EventArgs e)
        {
            //main color
            if (Global_Cls.ColorDisplay == 0) { checkBoxItem_Black.Checked = true; checkBoxItem_Black_Click(this, null); }
            else if (Global_Cls.ColorDisplay == 1) { checkBoxItem_Silver.Checked = true; checkBoxItem_Silver_Click(this, null); }
            else if (Global_Cls.ColorDisplay == 2) { checkBoxItem_Blue.Checked = true; checkBoxItem_Blue_Click(this, null); }
            //

            //MehrParvarPrj.Properties.Settings.Default.Initialize( , Properties.Resources.ResourceManager.ResourceSetType.FullName = "\\Settings.settings";
            if (UserPermission != "" && UserPermission != "admin")
            {
                foreach (Control c in this.Controls["ribbonControl_Main"].Controls)
                {
                    if (c.Name != "")
                        foreach (Control c1 in this.Controls["ribbonControl_Main"].Controls[c.Name].Controls)
                        {
                            if (c1.Name != "")
                            {
                                string sp = UserPermission;
                                if (c1 is RibbonBar)
                                {
                                    if (sp.Contains((c1 as RibbonBar).Name + ","))
                                    {
                                        (c1 as RibbonBar).Enabled = false;
                                    }
                                }


                                string st = "";
                                while (sp != "")
                                {
                                    st = sp.Substring(0, sp.IndexOf(","));
                                    sp = sp.Substring(sp.IndexOf(",") + 1, sp.Length - (sp.IndexOf(",") + 1));
                                    BaseItem item = (c1 as RibbonBar).GetItem(st);
                                    try
                                    {
                                        item.Enabled = false;
                                    }
                                    catch 
                                    {
                                    }
                                }
                            }
                        }
                }
            }


            tabNameStr = "tabControlPanel_StartPnl,";


            reflectionLabel1.Text = Global_Cls.CONameStr;

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItem_SendSMS.Enabled = false;
                buttonItem_ReciveSMS.Enabled = false;
                buttonItemEmFxTel.Enabled = false;
                buttonItemVisitHistory.Enabled = false;
            }

            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItem_RepPatients.Enabled = false;
                buttonItemMainPatientReport.Visible = false;

                buttonItem_ieSearch.Enabled = false;
                buttonItem_SendEmail.Enabled = false;

                buttonItem_ChartPos.Enabled = false;

                buttonItemVisitHistory.Enabled = false;
                ribbonTabItem_UNet.Enabled = false;
            }

            if (Global_Cls.SoftwareCode.Contains("L2") || Global_Cls.SoftwareCode.Contains("N2")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemMainPatientReport.Visible = false;
            }

            if (Global_Cls.SoftwareCode.Contains("L3")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemMainPatientReport.Visible = false;
                //buttonItemDoctorPayList.Visible = false;
                buttonItemPationtVisit.Visible = false;
            }
            //if (Global_Cls.SoftwareCode == "Trial")
            //{
            //    buttonItem_ieSearch.Enabled = false;
            //    buttonItem_SearchHouse.Enabled = false;
            //}
            //codeing


        }



        private void MainHM_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!Function_Cls.ExitForce)
                if (!Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا از برنامه خارج می شوید؟"))
                {
                    e.Cancel = true;
                    return;
                }

            try
            {
                for (int i = 0; i < tabControl_Main.Tabs.Count; i++)
                    tabControl_Main.Tabs.RemoveAt(i);
            }
            catch { }


            //setting
            if (Global_Cls.BkpExitType == 2)
            {
                string RootStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                RootStr = RootStr.Replace("/", "");
                RootStr = Global_Cls.BkpAutoRoot + "\\" + RootStr + " " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + ".bak";
                Function_Cls.SetBackUpDBAll(RootStr);
            }
            if (Global_Cls.BkpExitType == 1) Func_CallTheBackUp();

            //main color
            if (checkBoxItem_Black.Checked) Global_Cls.ColorDisplay = 0;
            else if (checkBoxItem_Silver.Checked) Global_Cls.ColorDisplay = 1;
            else if (checkBoxItem_Blue.Checked) Global_Cls.ColorDisplay = 2;
            //

            Function_Cls.WriteToXmlFiles();

            timer_Main.Enabled = false;
        }


        private void MainHM_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        public bool CloseAllOK = false;
        private void notifyToolStrip_ItemExit_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOK = true;
                Close();
            }
            catch { }
        }

        private void MainHM_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl_Main.SelectedTabIndex == tabControl_Main.Tabs.Count - 1)
                    tabControl_Main.SelectedTabIndex = 0;
                else
                    tabControl_Main.SelectNextTab();
            }
        }

        #endregion



        #region Add Tabs to TabControl Functions & Add UserControl to Tabs

        //private int Cnt;
        public string tabNameStr;

        public void AddTabToTabControl(string tabName, string tabCaption, UserControl UC)
        {
            if (tabNameStr != null && tabNameStr.Contains(tabName + "Pnl,"))
            {
                tabControl_Main.SelectedPanel = (TabControlPanel)tabControl_Main.Controls[tabName + "Pnl"];
                UC.Dispose();
                return;
            }

            DevComponents.DotNetBar.TabItem NewTabItem = new DevComponents.DotNetBar.TabItem(this.components);
            DevComponents.DotNetBar.TabControlPanel NewTabControlPanel = new DevComponents.DotNetBar.TabControlPanel();

            NewTabControlPanel.Controls.Add(UC);
            UC.Dock = DockStyle.Fill;
            NewTabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            NewTabControlPanel.Location = new System.Drawing.Point(0, 0);
            NewTabControlPanel.Padding = new System.Windows.Forms.Padding(1);
            NewTabControlPanel.Size = new System.Drawing.Size(778, 289);
            NewTabControlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            NewTabControlPanel.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark;
            NewTabControlPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                 | DevComponents.DotNetBar.eBorderSide.Top)));
            NewTabControlPanel.Style.GradientAngle = -90;
            NewTabControlPanel.TabIndex = 1;

            NewTabControlPanel.TabItem = NewTabItem;
            NewTabItem.AttachedControl = NewTabControlPanel;

            
            //
            tabNameStr += tabName + "Pnl,";

            NewTabControlPanel.Name = tabName + "Pnl";
            NewTabControlPanel.Text = tabCaption;

            try
            {
                NewTabItem.Name = tabName + "Itm";
            }
            catch
            {
            }
            NewTabItem.Text = tabCaption;

            tabControl_Main.Controls.Add(NewTabControlPanel);
            tabControl_Main.Tabs.Add(NewTabItem);
            tabControl_Main.Refresh();

            tabControl_Main.SelectedPanel = NewTabControlPanel;
        }

        public void DeleteTabFromTabControl(DevComponents.DotNetBar.TabItem TabItemName)
        {
            tabControl_Main.Tabs.Remove(TabItemName);
            tabControl_Main.Controls.Remove(TabItemName.AttachedControl);
        }


        private void tabControl_Main_ControlRemoved(object sender, ControlEventArgs e)
        {
            tabNameStr = tabNameStr.Replace(tabControl_Main.SelectedPanel.Name + ",", "");
            tabControl_Main.Tabs.Capacity--;
        }
        
        private void buttonItem_Users_Click(object sender, EventArgs e)
        {
            ListUser_UC Uc = new ListUser_UC();
            AddTabToTabControl("User", " کاربران ", Uc);
        }


        private void buttonItem_PerTelMob_Click(object sender, EventArgs e)
        {
            ListTelMob_UC Uc = new ListTelMob_UC();
            AddTabToTabControl("ListTelMob", " دفتر تلفن ", Uc);
        }

        #endregion



        #region Backup Or Restore Functions
        private void buttonItem_Bkp_Click(object sender, EventArgs e)
        {
            Func_CallTheBackUp();
        }

        private void Func_CallTheBackUp()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files(*.bak)|*.bak";
            if (dlg.ShowDialog() == DialogResult.OK)
                Function_Cls.SetBackUpDBAll(dlg.FileName);
        }
       
        private void buttonItem_Rst_Click(object sender, EventArgs e)
        {
            Func_CallTheRestore();
        }

        private void Func_CallTheRestore()
        {
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا نسبت به عمل بازیابی مطمئنید؟"))
                Function_Cls.Restore_Func(false);
        }
        #endregion



        #region All Settings
        private void checkBoxItem_Black_Click(object sender, EventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black);
            //ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
        }

        private void checkBoxItem_Silver_Click(object sender, EventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver);
            //ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
        }

        private void checkBoxItem_Blue_Click(object sender, EventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue);
            //ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue;
        }

        private static void SettingForm_Open(int tabindex)
        {
            Setting_frm Sf = new Setting_frm();
            //Sf.tabControl_Setting.SelectedTabIndex = tabindex;
            //if (tabindex != 4) Sf.treeView_Setting.SelectedNode = Sf.treeView_Setting.Nodes[tabindex].Nodes[0];
            //else 
            Sf.treeView_Setting.SelectedNode = Sf.treeView_Setting.Nodes[tabindex];
            Sf.ShowDialog();
        }

        private void ribbonBar_MainSet_DialogLauncherMouseDown(object sender, MouseEventArgs e)
        {
            //SettingForm_Open(0);
        }

        private void buttonItem_FirstSet_Click(object sender, EventArgs e)
        {
            SettingForm_Open(0);
        }

        private void buttonItem_AgencySet_Click(object sender, EventArgs e)
        {
            //SettingForm_Open(1);
        }

        private void buttonItem_BkpRstSet_Click(object sender, EventArgs e)
        {
            //SettingForm_Open(4);
        }

        private void buttonItem_OtherSet_Click(object sender, EventArgs e)
        {
            //SettingForm_Open(3);
        }

        private void buttonItem_SetSystem_Click(object sender, EventArgs e)
        {
            //SettingForm_Open(2);
        }


        #endregion



        #region Tools


        private void buttonItem_SendSMS_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(true, "", "");
        }

        private void buttonItem_SendEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("", "");
        }

        private void buttonItem_ReciveSMS_Click(object sender, EventArgs e)
        {
            ReciveSMS_frm rsf = new ReciveSMS_frm();
            rsf.ShowDialog();
        }

        private void buttonItem_Calc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void buttonItem_Notepad_Click(object sender, EventArgs e)
        {
            Process.Start("NotePad");
        }

        private void buttonItem_ieSearch_Click(object sender, EventArgs e)
        {
            Function_Cls.SearchInternet(1);
        }

        private void buttonItem_ChartPos_Click(object sender, EventArgs e)
        {
            Function_Cls.SearchInternet(2);
        }


        #endregion



        #region Reports


        private void buttonItem_RepPatients_Click(object sender, EventArgs e)
        {
            PatientVisitRep_frm pvr = new PatientVisitRep_frm();
            pvr.ShowDialog();
        }


        #endregion



        #region Date Time UserName
        Int16 CounterColor = 0;
        private void timer_Main_Tick(object sender, EventArgs e)
        {
            //if (CounterColor == 100) CounterColor = 0;
            //label_main.ForeColor = Convert.ChangeType(CounterColor++, System.Drawing.Color);// Color.Khaki;// CounterColor++;
            label_main.Text = taghvim() + "           ساعت: " +
                DateTime.Now.TimeOfDay.Hours.ToString() + ":" +
                DateTime.Now.TimeOfDay.Minutes.ToString() + ":" +
                DateTime.Now.TimeOfDay.Seconds.ToString() + "         کاربر: " +
                Global_Cls.UserName_Exist.ToString();
            label_main.Left = bar_MainView.Width/2 - 250;
        }

        private string taghvim()
        {
            string TghvmStr = "";

            string[] fasl = new string[12];
            fasl[0] = "فروردین";
            fasl[1] = "اردیبهشت";
            fasl[2] = "خرداد";
            fasl[3] = "تیر";
            fasl[4] = "مرداد";
            fasl[5] = "شهریور";
            fasl[6] = "مهر";
            fasl[7] = "آبان";
            fasl[8] = "آذر";
            fasl[9] = "دی";
            fasl[10] = "بهمن";
            fasl[11] = "اسفند";
            string[] rooz = new string[7];
            rooz[0] = "شنبه"; rooz[1] = "یکشنبه"; rooz[2] = "دوشنبه"; rooz[3] = "سه شنبه"; rooz[4] = "چهارشنبه"; rooz[5] = "پنج شنبه"; rooz[6] = "جمعه";

            PersianCalendar farsi = new PersianCalendar();
            int a;
            DayOfWeek dd;

            dd = farsi.GetDayOfWeek(DateTime.Now);
            switch (dd.ToString())
            {
                case "Saturday":
                    TghvmStr = rooz[0].ToString();
                    break;
                case "Sunday":
                    TghvmStr = rooz[1].ToString();
                    break;
                case "Monday":
                    TghvmStr = rooz[2].ToString();
                    break;
                case "Tuesday":
                    TghvmStr = rooz[3].ToString();
                    break;
                case "Wednesday":
                    TghvmStr = rooz[4].ToString();
                    break;
                case "Thursday":
                    TghvmStr = rooz[5].ToString();
                    break;
                case "Friday":
                    TghvmStr = rooz[6].ToString();
                    break;
            }
            string str;
            a = farsi.GetDayOfMonth(DateTime.Now);
            TghvmStr += " " + Convert.ToString(a);
            str = Convert.ToString(a);
            a = farsi.GetMonth(DateTime.Now);
            TghvmStr += " " + fasl[a - 1];
            str += "/" + Convert.ToString(a);
            a = farsi.GetYear(DateTime.Now);
            TghvmStr += " " + Convert.ToString(a);
            str += "/" + Convert.ToString(a);

            return TghvmStr;
        }
        #endregion


        #region Button Click

        private void buttonItem_Help_Click(object sender, EventArgs e)
        {
            //Process.Start("RentHelp.chm");
        }
        private void buttonItemVisitHistory_Click(object sender, EventArgs e)
        {
            //Function_Cls.CheckKeyFile();
            ListVisitHistory_UC Uc = new ListVisitHistory_UC();
            AddTabToTabControl("ListVisitHistory", " لیست پیامک های دریافتی ویزیت ", Uc);
        }

        private void buttonItem_PatientList_Click(object sender, EventArgs e)
        {
            ListDocPat_UC Uc = new ListDocPat_UC();
            AddTabToTabControl("ListDocPat", " لیست بیماران ", Uc);
        }

        private void buttonItem_DoctorList_Click(object sender, EventArgs e)
        {
            DoctorList_UC Uc = new DoctorList_UC();
            AddTabToTabControl("DoctorList", " لیست پزشکان", Uc);
            Function_Cls.CheckKeyFile();
        }

        //private void buttonItem_CuPatient_Click(object sender, EventArgs e)
        //{
        //    PatientNE_frm Uc = new PatientNE_frm(true, 1, 0, true);
        //    Uc.ShowDialog();
        //    try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
        //    catch { }
        //}

        //private void buttonItem_DoctorNew_Click_1(object sender, EventArgs e)
        //{
        //    DoctorNE_frm Uc = new DoctorNE_frm();
        //    Uc.ShowDialog();
        //    try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
        //    catch { }
        //}

        private void buttonItemListDelDocPat_Click(object sender, EventArgs e)
        {
            ListDelDocPat_UC Uc = new ListDelDocPat_UC();
            AddTabToTabControl("ListDelDocPat", " لیست بیماران بایگانی شده ", Uc);
        }

        private void buttonItemListVsit_Click(object sender, EventArgs e)
        {
            
            ListPatientVisit_UC Uc = new ListPatientVisit_UC(true, true, 0);
            AddTabToTabControl("ListPatientVisit", " لیست ویزیت بیماران ", Uc);
        }

        //private void buttonItemNewVisit_Click(object sender, EventArgs e)
        //{
        //    PatientVisitNE_frm Uc = new PatientVisitNE_frm();
        //    Uc.ShowDialog();
        //    try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
        //    catch { }
        //}

        private void buttonItem_SearchWireBS_Click(object sender, EventArgs e)
        {
            SearchPatient_UC Uc = new SearchPatient_UC();
            AddTabToTabControl("SearchPatient", " جستجوی بیماران ", Uc);
        }

        private void buttonItem_LdExcel_Click(object sender, EventArgs e)
        {
            Function_Cls.CheckKeyFile(); 
            ExportExcel_Uc Uc = new ExportExcel_Uc();
            AddTabToTabControl("ExportExcel", " بازخوانی از اکسل ", Uc);
        }

        private void buttonItemPationtVisit_Click(object sender, EventArgs e)
        {
            Function_Cls.CheckKeyFile();
            ExportExcelVisit_Uc Uc = new ExportExcelVisit_Uc();
            AddTabToTabControl("ExportExcelVisit", " بازخوانی از اکسل ویزیت ", Uc);
        }

        private void buttonItemPayment_Click(object sender, EventArgs e)
        {
            ListDoctorPayment_UC Uc = new ListDoctorPayment_UC();
            AddTabToTabControl("ListDoctorPayment", " وضعیت پرداختی ها ", Uc);
        }

        private void buttonItemMartyrsList_Click(object sender, EventArgs e)
        {
            MartyrsList_UC Uc = new MartyrsList_UC();
            AddTabToTabControl("MartyrsList", " لیست خانواده شهدا", Uc);
            //Function_Cls.CheckKeyFile();
        }

        private void buttonItemSearchPatient_Click(object sender, EventArgs e)
        {
            SearchPatient_UC Uc = new SearchPatient_UC();
            AddTabToTabControl("SearchPatient", "جستجوی پیشرفته بیماران", Uc);
        }

        private void buttonItemSearchPatientVisit_Click(object sender, EventArgs e)
        {
            SearchPatientVisit_UC Uc = new SearchPatientVisit_UC();
            AddTabToTabControl("SearchPatientVisit", "جستجوی پیشرفته ویزیت بیماران", Uc);
        }
        
        private void buttonItem_ContractTypeList_Click(object sender, EventArgs e)
        {
            ContractTypeList_Frm Ct = new ContractTypeList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemDoctorTypeList_Click(object sender, EventArgs e)
        {
            DoctorTypeList_Frm Ct = new DoctorTypeList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemPatientTypeList_Click(object sender, EventArgs e)
        {
            PatientTypeList_Frm Ct = new PatientTypeList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemStateSicknessMaster_Click(object sender, EventArgs e)
        {
            StateSicknessMasterList_Frm Ct = new StateSicknessMasterList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemStateSickness_Click(object sender, EventArgs e)
        {
            StateSicknessList_Frm Ct = new StateSicknessList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemDrugs_Click(object sender, EventArgs e)
        {
            DrugsList_Frm Ct = new DrugsList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemParaclinics_Click(object sender, EventArgs e)
        {
            ParaclinicList_Frm Ct = new ParaclinicList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemInjuryType_Click(object sender, EventArgs e)
        {
            InjuryTypeList_Frm Ct = new InjuryTypeList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemBank_Click(object sender, EventArgs e)
        {
            BankList_Frm Ct = new BankList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemLocationPart_Click(object sender, EventArgs e)
        {
            LocationPartList_Frm Ct = new LocationPartList_Frm();
            Ct.ShowDialog();
        }


        private void buttonItemVaccination_Click(object sender, EventArgs e)
        {
            VaccinationList_Frm Ct = new VaccinationList_Frm();
            Ct.ShowDialog();
        }

        private void buttonItemEquipmentUse_Click(object sender, EventArgs e)
        {
            EquipmentUseList_Frm Ct = new EquipmentUseList_Frm();
            Ct.ShowDialog();
        }

       
        #endregion

        private void buttonItemPatientReport_Click(object sender, EventArgs e)
        {
            Report.Forms.PatientReport PT = new Report.Forms.PatientReport(0);
            PrintPreview_frm PP = new PrintPreview_frm(PT);
            PP.ShowDialog();
        }

        private void buttonItemDoctorPayList_Click(object sender, EventArgs e)
        {
            DoctorVisitRep_frm pvr = new DoctorVisitRep_frm();
            pvr.ShowDialog();
        }

       
      
    }
}
