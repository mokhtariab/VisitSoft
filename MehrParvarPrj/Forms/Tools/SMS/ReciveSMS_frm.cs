using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.Properties;
using MehrParvarPrj.DataLinq;
using System.Collections.Generic;


namespace MehrParvarPrj
{
    public partial class ReciveSMS_frm : Form
    {
        public ReciveSMS_frm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable("ReciveSMS");
        private void ReciveSMS_frm_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Checked", typeof(bool));
            dt.Columns.Add("Message", typeof(string));
            dt.Columns.Add("Mobile", typeof(string));
            dt.Columns.Add("DateRecive", typeof(string));
            dt.Columns.Add("DateReciveMiladi", typeof(DateTime));
            dt.Columns.Add("TimeStampRFC", typeof(string));
            dt.Columns.Add("Index", typeof(int));
            dt.Columns.Add("ConfirmOK", typeof(int));
            dt.Columns.Add("RecipientNumber", typeof(string));
            dt.Columns.Add("MessageID", typeof(long));


            //codeing
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1")) //|| Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemSendList.Enabled = false;
            }
            //codeing

            System.Globalization.PersianCalendar ps = new System.Globalization.PersianCalendar();
            comboBox_Year1.Text = ps.GetYear(DateTime.Now).ToString();
            comboBox_Month1.Text = ps.GetMonth(DateTime.Now).ToString();
            comboBox_Day1.Text = ps.GetDayOfMonth(DateTime.Now).ToString();

            comboBox_Day2.Text = ps.GetDayOfMonth(DateTime.Now).ToString();
            comboBox_Month2.Text = ps.GetMonth(DateTime.Now).ToString();
            comboBox_Year2.Text = ps.GetYear(DateTime.Now).ToString();
        }

        private void buttonItem_ListView_Click(object sender, EventArgs e)
        {
            DateTime Dt1 = Global_Cls.ShamsiDateToMiladiWithTime("", comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text,0,0,0);
            DateTime Dt2 = Global_Cls.ShamsiDateToMiladiWithTime("", comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text,23,59,59);

            ShowListRcvSMS(Dt1, Dt2);

            
        }

        int SimPhone = 0;
        private void ShowListRcvSMS(DateTime Dt1, DateTime Dt2)
        {
            //ribbonBar_SdAvSMS.Enabled = false;
            //labelSleep.Visible = true;

            //if (radiobtn_rbmsgsim.Checked) SimPhone = 0;
            //if (radiobtn_rbmsgphone.Checked) SimPhone = 1;

            //dt.Clear();

            //string SResult = Classes.SMSClass.ReadSMS(ref dt, SimPhone, Dt1, Dt2);
            //gridControl_ReciveSMS.DataSource = dt;

            //Global_Cls.Message_MehrGostar(SResult, Global_Cls.MessageType.SInformation);
            //labelSleep.Visible = false;
            //ribbonBar_SdAvSMS.Enabled = true;


            /////////---------------------New


            DataClasses_MainDataContext df = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            ribbonBar_SdAvSMS.Enabled = false;
            labelSleep.Visible = true;
            dt.Clear();

            if (radiobtn_rbmsgsim.Checked)
            {
                SimPhone = 0;

                string SResult = Classes.SMSClass.ReadSMS(ref dt, SimPhone, Dt1, Dt2);
                gridControl_ReciveSMS.DataSource = dt;

                Global_Cls.Message_MehrGostar(SResult, Global_Cls.MessageType.SInformation);
                labelSleep.Visible = false;
                ribbonBar_SdAvSMS.Enabled = true;

                try
                {
                    foreach (var Msg in dt.Select())
                    {
                        TBL_ReciveSM trs = new TBL_ReciveSM
                        {
                            MessageID = Convert.ToInt32(Msg["MessageID"]),
                            ReceiveDate = Convert.ToDateTime(Msg["DateReciveMiladi"]),
                            Body = Msg["Message"].ToString(),
                            RecipientNumber = Msg["RecipientNumber"].ToString(),
                            SenderNumber = Msg["Mobile"].ToString(),
                        };
                        df.TBL_ReciveSMs.InsertOnSubmit(trs);
                        df.SubmitChanges();
                    }
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت اطلاعات پیامک های جدید با مشکل مواجه گردید", ex.Message);
                }
            }
            else
            if (radiobtn_rbmsgphone.Checked)
            {
                int m = 0;
                foreach (TBL_ReciveSM Msg in df.TBL_ReciveSMs.Where(l => l.ReceiveDate >= Dt1 && l.ReceiveDate <= Dt2))
                {
                    DataRow DR = dt.NewRow();
                    DR["Checked"] = false;
                    DR["Mobile"] = Msg.SenderNumber;
                    DR["Message"] = Msg.Body;
                    DR["DateReciveMiladi"] = Msg.ReceiveDate;
                    DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(Msg.ReceiveDate.Value);
                    DR["Index"] = m++;
                    DR["ConfirmOK"] = 0;
                    dt.Rows.Add(DR);
                }


                gridControl_ReciveSMS.DataSource = dt;

                string Result = "مجموع پیامک ها: " + dt.Rows.Count.ToString();
                if (dt.Rows.Count > 0)
                    Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";
                Global_Cls.Message_MehrGostar(Result, Global_Cls.MessageType.SInformation);
                labelSleep.Visible = false;
                ribbonBar_SdAvSMS.Enabled = true;
            }

            //////////////////---------------------New


        }

       
        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridControl_ReciveSMS_DoubleClick(object sender, EventArgs e)
        {
            Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SInformation, false,
                " از: " + gridView_ReciveSMS.GetRowCellValue(gridView_ReciveSMS.FocusedRowHandle, "Mobile"),
                gridView_ReciveSMS.GetRowCellValue(gridView_ReciveSMS.FocusedRowHandle, "DateReciveMiladi")
                + "\r\n\r\n" +
                gridView_ReciveSMS.GetRowCellValue(gridView_ReciveSMS.FocusedRowHandle, "Message")
                );           
        }


        private void buttonItem_DelRcSMS_Click(object sender, EventArgs e)
        {
            string StrMsg = "";
            try
            {
                if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید پیامک های انتخابی حذف شوند؟"))
                {
                    ribbonBar_SdAvSMS.Enabled = false;
                    labelSleep.Visible = true; 
                    for (int i = 0; i < gridView_ReciveSMS.RowCount; i++)
                    {
                        if (bool.Parse(gridView_ReciveSMS.GetRowCellValue(i, "Checked").ToString()))
                        {
                            StrMsg = Classes.SMSClass.DeleteSMS(int.Parse(gridView_ReciveSMS.GetRowCellValue(i, "Index").ToString()), SimPhone);
                            if (StrMsg != "")
                                Global_Cls.Message_MehrGostar(StrMsg, Global_Cls.MessageType.SInformation);
                        }
                    }
                    labelSleep.Visible = false;
                    ribbonBar_SdAvSMS.Enabled = true;

                    DateTime Dt1 = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_Day1.Text);
                    DateTime Dt2 = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);
                    ShowListRcvSMS(Dt1, Dt2);
                }
            }
            catch { }
        }



        private void buttonItemSendList_Click(object sender, EventArgs e)
        {
            DataClasses_MainDataContext df = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            string strMb = "";

            //if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید پیامک های انتخابی ذخیره شوند؟"))
            //{
            listViewErrore.Clear();
            ribbonBar_SdAvSMS.Enabled = false;
            labelSleep.Visible = true;
            int CntCheck = 0;

            
            ///////////////////////////////////
            //string Msg1 = "6603753-3359745671";
            //try
            //{
            //    long.Parse(Msg1);
            //}
            //catch
            //{
            //    try
            //    {

            //        long.Parse(Msg1.Substring(0, Msg1.LastIndexOf("-")).Replace(" ", "").ToString());
            //        long.Parse(Msg1.Substring(Msg1.LastIndexOf("-") + 1, Msg1.Length - Msg1.LastIndexOf("-") - 1).Replace(" ", ""));
            //    }
            //    catch { }
            //}

            //try
            //{
            //    DataLinq.TBL_VisitHistory VH1 = new DataLinq.TBL_VisitHistory();

            //    if (Msg1.LastIndexOf("-") > 0)
            //    {
            //        VH1.DosiersNo = Msg1.Substring(0, Msg1.LastIndexOf("-")).Replace(" ", "");
            //        VH1.NationalCode = Msg1.Substring(Msg1.LastIndexOf("-")+1, Msg1.Length - Msg1.LastIndexOf("-")-1).Replace(" ", "");
            //    }
            //    else
            //    {
            //        VH1.DosiersNo = Msg1.ToString();
            //        VH1.NationalCode = df.TBL_Patients.First(hf => hf.DosiersNo.Equals(VH1.DosiersNo)).NationalCode;
            //    }
            //}
            //catch { }

            ////////////////////////////////////


            for (int i = 0; i < gridView_ReciveSMS.RowCount; i++)
            {
                if (bool.Parse(gridView_ReciveSMS.GetRowCellValue(i, "Checked").ToString()))
                {
                    string Msg = gridView_ReciveSMS.GetRowCellValue(i, "Message").ToString().Replace(" ", "");
                    try
                    {
                        long.Parse(Msg);
                    }
                    catch
                    {
                        try
                        {
                            long.Parse(Msg.Substring(0, Msg.LastIndexOf("-")).Replace(" ", "").ToString());
                            long.Parse(Msg.Substring(Msg.LastIndexOf("-") + 1, Msg.Length - Msg.LastIndexOf("-") - 1).Replace(" ", ""));
                        }
                        catch
                        {
                            listViewErrore.Items.Add("متن سطر " + gridView_ReciveSMS.GetRowCellValue(i, "Index") + " ایراد دارد");
                            listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                            CntCheck++;
                        }
                    }


                    strMb = gridView_ReciveSMS.GetRowCellValue(i, "Mobile").ToString().Replace("+98", "0");
                    if (strMb.Length != 11)
                    {
                        listViewErrore.Items.Add("شماره موبایل سطر " + gridView_ReciveSMS.GetRowCellValue(i, "Index") + " ایراد دارد");
                        listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                        CntCheck++;
                    }

                }
            }

            if (CntCheck == 0)
            {
                for (int i = 0; i < gridView_ReciveSMS.RowCount; i++)
                    if (bool.Parse(gridView_ReciveSMS.GetRowCellValue(i, "Checked").ToString()))
                    {
                        try
                        {
                            DataLinq.TBL_VisitHistory VH = new DataLinq.TBL_VisitHistory();

                            VH.DateVisit = DateTime.Parse(gridView_ReciveSMS.GetRowCellValue(i, "DateReciveMiladi").ToString());

                            string MsgNew = gridView_ReciveSMS.GetRowCellValue(i, "Message").ToString();
                            if (MsgNew.LastIndexOf("-") > 0)
                            {
                                    VH.DosiersNo = MsgNew.Substring(0, MsgNew.LastIndexOf("-")).Replace(" ", "");
                                    VH.NationalCode = MsgNew.Substring(MsgNew.LastIndexOf("-") + 1, MsgNew.Length - MsgNew.LastIndexOf("-") - 1).Replace(" ", "");
                            }
                            else
                            {
                                try
                                {
                                    VH.DosiersNo = MsgNew.ToString();
                                    VH.NationalCode = df.TBL_Patients.First(hf => hf.DosiersNo.Equals(VH.DosiersNo)).NationalCode;
                                //new 950308
                                }
                                catch
                                {
                                    VH.NationalCode = MsgNew;
                                }
                                //new 950308
                            }
                            
                            VH.MobileDoctor = gridView_ReciveSMS.GetRowCellValue(i, "Mobile").ToString().Replace("+98", "0");
                            VH.Description = "";

                            df.TBL_VisitHistories.InsertOnSubmit(VH);
                            df.SubmitChanges();
                            gridView_ReciveSMS.SetRowCellValue(i, "ConfirmOK", 1);
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.IndexOf("Cannot insert duplicate key in object") > -1)
                                gridView_ReciveSMS.SetRowCellValue(i, "ConfirmOK", 2);
                            else
                            {
                                listViewErrore.Items.Add("متن  و یا شماره موبایل سطر " + gridView_ReciveSMS.GetRowCellValue(i, "Index") + " ایراد دارد");
                                listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                                CntCheck++;
                            }
                        }
                    }
            }

            if (CntCheck == 0)
                Global_Cls.Message_MehrGostar("اطلاعات ثبت شدند", Global_Cls.MessageType.SInformation);
            //else Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اشکالات", StrMsg);

            labelSleep.Visible = false;
            ribbonBar_SdAvSMS.Enabled = true;
            //}

        }

        private void listViewErrore_DoubleClick(object sender, EventArgs e)
        {
            int RF = int.Parse(listViewErrore.SelectedItems[0].SubItems[1].Text);
            gridView_ReciveSMS.UnselectRow(gridView_ReciveSMS.FocusedRowHandle);
            gridView_ReciveSMS.SelectRow(RF);
            gridView_ReciveSMS.FocusedRowHandle = RF;
        }

        private void gridView_ReciveSMS_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "Checked")
            {
                int d = gridView_ReciveSMS.FocusedRowHandle;
                object g = e.Value;
                gridView_ReciveSMS.UnselectRow(d);
                gridView_ReciveSMS.SelectRow(d);
                //e.Value
                //gridView_ReciveSMS.FocusedRowHandle = d - 1;
                gridView_ReciveSMS.FocusedRowHandle = d;
                gridView_ReciveSMS.SetRowCellValue(d, "Checked", g);
            }
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            int d = checkBoxSelectAll.Checked == true ? 1 : 0;
            for (int i = 0; i < gridView_ReciveSMS.RowCount; i++)
                gridView_ReciveSMS.SetRowCellValue(i, "Checked", d);
        }

      


    }
}
