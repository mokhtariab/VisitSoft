using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MehrParvarPrj.DataLinq;
using System.Data;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;

namespace MehrParvarPrj.Classes
{
    public class SMSClass
    {
        private static mCore.SMS objSMS = new mCore.SMS();

        public static bool ConnectToPort(bool A)
        {
            //SMS_Lib.SMSService.v2 df = new SMS_Lib.SMSService.v2();
            
            return true;
        }

        public static bool ConnectToPort()
        {
           //new 950308
            if (Global_Cls.SMSSet)
            {
                if (Global_Cls.SetConnection())
                    return true;
            }
            else
            {
                //new 950308
                try
                {
                    if (!objSMS.IsConnected && Global_Cls.SMSPort != "")
                    {
                        objSMS.Port = Global_Cls.SMSPort.ToString();
                        objSMS.BaudRate = (mCore.BaudRate)(Global_Cls.SMSBaudRate);
                        objSMS.DataBits = (mCore.DataBits)(Global_Cls.SMSDataBits);
                        objSMS.Parity = (mCore.Parity)(Global_Cls.SMSParity);
                        objSMS.StopBits = (mCore.StopBits)(Global_Cls.SMSStopBits);
                        objSMS.FlowControl = (mCore.FlowControl)Global_Cls.SMSFlowControl;

                        objSMS.ReadIntervalTimeout = Global_Cls.SMSTimeOut;
                        objSMS.DelayAfterPIN = 10000;
                        objSMS.LongMessage = (mCore.LongMessage)Global_Cls.SMSLongMsg;
                        objSMS.Encoding = (mCore.Encoding)Global_Cls.SMSEncoding;
                        objSMS.DeliveryReport = Global_Cls.SMSDeliveryReport;

                        objSMS.NewUSSDIndication = true;
                        objSMS.DisableCheckPIN = true;
                        //objSMS.Queue().Enabled = true;
                        objSMS.NewMessageConcatenate = true;


                        objSMS.SendDelay = (int)(1000);

                        objSMS.SendRetry = 1;

                        objSMS.Timeout = (long)(30 * 1000);

                        objSMS.Connect();
                        return true;
                    }
                    else
                        if (objSMS.Connect())
                            return true;

                }
                catch (mCore.GeneralException ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ارتباط با پورت امکان پذیر نمی باشد", ex.Message);
                }
            }
            return false;
        }

        public static bool DisconnectPort()
        {
            //new 950308
            if (Global_Cls.SMSSet)
            {
                return true;
            }
            else
            {
                //new 950308
                try
                {
                    if (objSMS.IsConnected)
                        objSMS.Disconnect();
                    return true;
                }
                catch (mCore.GeneralException ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اشکال عمومی", ex.Message);
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
            return false;
        }

        public static string SendSMS(string PhoneNumber, string MessageStr)
        {
            if (PhoneNumber.Trim().Length <= 0)
            {
                return "شماره موبایل صحیح نمی باشد";
            }

            System.Windows.Forms.Application.DoEvents();

            //new 950308
            if (Global_Cls.SMSSet)
            {
                try
                {
                    long smsId = SMS_Cls.SendSMS(Global_Cls.IntUserName, Global_Cls.IntPassword,
                         Global_Cls.IntTelNumber, PhoneNumber, MessageStr);
                    return "ارسال شد!\r\n\r\n[Message Ref.: " + smsId + "]";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                //new 950308

                try
                {
                    //Set message validity period
                    //objSMS.Validity = "24H";

                    //Send the message
                    string strSendResult = objSMS.SendSMS(PhoneNumber, MessageStr);

                    return "ارسال شد!\r\n\r\n[Message Ref.: " + strSendResult + "]";
                }
                catch (mCore.SMSSendException ex)
                {
                    return ex.Message;
                }
                catch (mCore.GeneralException ex)
                {
                    return ex.Message;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static int InsertToSMSList(string MobileNo, string SMSText)
        {
            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            TBL_SendSMS th = new TBL_SendSMS();
            th.Mobile_No = MobileNo;
            th.MessageText = SMSText; //+ " 'R.C.M' ";
            th.Status = 0;
            th.SMS_Few = 1;
            th.Archive = false;
            th.SendDate = Global_Cls.MiladiDateToShamsi(DateTime.Now);
            th.SendTime = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString("00") + ":" + DateTime.Now.TimeOfDay.Seconds.ToString("00");
            th.UserCode = Global_Cls.UserCode_Exist;
            th.UseName = Global_Cls.UserName_Exist;
            th.Description = "";
            DCDC.TBL_SendSMS.InsertOnSubmit(th);
            DCDC.SubmitChanges();

            int jj = int.Parse((from fg in DCDC.TBL_SendSMS select fg.SMSCode).Max().ToString());
            return jj;
        }

        public static void SendList(int SMSCode)
        {
            ConnectToPort();
            DataClasses_MainDataContext df = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            string ResultStrSMS = "";

            var ggg = from gh in df.TBL_SendSMS
                      where gh.Status == 0
                      select gh;
            if (SMSCode != 0)
                ggg = ggg.Where(jh => jh.SMSCode == SMSCode);

            foreach (var ft in ggg)
            {
                try
                {
                    ResultStrSMS = SendSMS(ft.Mobile_No, ft.MessageText);

                    TBL_SendSMS hy = df.TBL_SendSMS.First(kk => kk.SMSCode == ft.SMSCode);
                    hy.Description = "ارسال شد";
                    hy.SendDate = Global_Cls.MiladiDateToShamsi(DateTime.Now);
                    hy.SendTime = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
                    hy.Status = 1;
                    df.SubmitChanges();
                }
                catch (Exception ex)
                {
                    string str = "";
                    if (ex.Message.Contains("COM")) str = "پورت شناسایی نشد";
                    if (ex.Message.Contains("Message service error 144")) str = "شماره موبایل اشتباه است!";
                    if (ex.Message.Contains("Message service error 322")) str = "حافظه پر است!";

                    TBL_SendSMS hy = df.TBL_SendSMS.First(kk => kk.SMSCode == ft.SMSCode);
                    hy.Description = str;
                    hy.Status = 2;
                    df.SubmitChanges();
                }
            }
            DisconnectPort();
        }



        // new 950308
        public static double GetCreditSMS(string UserName, string Password)
        {
            double resCredit = 0;
            resCredit = SMS_Cls.GetCreditSMS(UserName, Password);
            return resCredit;
        }
        // new 950308


        public static string MessageDelete(int Index)
        {
            try
            {
                objSMS.Inbox().Message(Index).Delete();
                return "";
            }
            catch (mCore.SMSReadException ex)
            {
                return ex.Message;
            }
            catch (mCore.GeneralException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }







        public static string ReciveSMS(ref DataTable DT, int RSType)
        {
            string Result = "";
            
            ConnectToPort();

        // new 950308
            if (Global_Cls.SMSSet)
            {
                int i = 0;
                List<SMS_Cls.ListReciveSMS> LLRS = SMS_Cls.RecivedSMS(Global_Cls.IntUserName, Global_Cls.IntPassword, Global_Cls.IntTelNumber, true);
                try
                {
                    
                    string PhoneName = "";
                    //MsgCount = LLRS.Count();
                    foreach (SMS_Cls.ListReciveSMS Msg in LLRS)
                    {
                        DataRow DR = DT.NewRow();
                        DR["Checked"] = false;
                        DR["Mobile"] = Msg.SenderNumber;
                        DR["Message"] = Msg.Body;
                        DR["DateReciveMiladi"] = Msg.ReceiveDate;
                        DR["DateRecive"] = Msg.ReceiveDate;//Global_Cls.MiladiDateToShamsiWithTime(Msg.ReceiveDate);
                        DR["TimeStampRFC"] = Msg.ReceiveDate;//Msg.TimeStampRFC;
                        DR["Index"] = i;//Msg.Index;
                        DR["ConfirmOK"] = 0;
                        DT.Rows.Add(DR);
                        i++;
                    }
                    return "";
                }
                catch { }


                Result = "مجموع پیامک ها: " + i;
                if (i > 0)
                    Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";

            }
            else
            {
                // new 950308

                mCore.Inbox objInbox = objSMS.Inbox();



                switch (RSType)
                {
                    case 0:
                        {
                            objSMS.MessageMemory = mCore.MessageMemory.SM;
                            break;
                        }
                    case 1:
                        {
                            objSMS.MessageMemory = mCore.MessageMemory.ME;
                            break;
                        }
                    case 2:
                        {
                            objSMS.MessageMemory = mCore.MessageMemory.MT;
                            break;
                        }
                }

                System.Windows.Forms.Application.DoEvents();

                try
                {
                    objInbox.Refresh();
                }
                catch (mCore.SMSReadException ex)
                {
                    Result = ex.Message;
                }
                catch (mCore.GeneralException ex)
                {
                    Result = ex.Message;
                }
                catch (Exception ex)
                {
                    Result = ex.Message;
                }

                if (Result != "")
                {
                    DisconnectPort();
                    return Result;
                }

                try
                {
                    foreach (mCore.Message Msg in objInbox)
                    {
                        DataRow DR = DT.NewRow();
                        DR["Checked"] = false;
                        DR["Mobile"] = System.Text.ASCIIEncoding.UTF8.GetString(System.Text.ASCIIEncoding.UTF8.GetBytes(Msg.Phone));
                        DR["Message"] = System.Text.ASCIIEncoding.UTF8.GetString(System.Text.ASCIIEncoding.UTF8.GetBytes(Msg.Text));
                        DR["DateReciveMiladi"] = Msg.TimeStamp;
                        DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(Msg.TimeStamp);
                        DR["TimeStampRFC"] = Msg.TimeStampRFC;
                        DR["Index"] = Msg.Index;
                        DR["ConfirmOK"] = 0;
                        DT.Rows.Add(DR);
                    }

                    Result = "مجموع پیامک ها: " + objInbox.Count;
                    if (objInbox.Count > 0)
                        Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";
                }
                catch (mCore.SMSReadException ex)
                {
                    Result = ex.Message;
                }
                catch (mCore.GeneralException ex)
                {
                    Result = ex.Message;
                }
                catch (Exception ex)
                {
                    Result = ex.Message;
                }
            }
            DisconnectPort();
            return Result;
        }


        public static GsmCommMain comm;
        public static string ReadSMS(ref DataTable DT, int i, DateTime Dt1, DateTime Dt2)
        {

            string Result = "";
            
             // new 950308
            if (Global_Cls.SMSSet)
            {
                int m = 0;
                List<SMS_Cls.ListReciveSMS> LLRS = SMS_Cls.RecivedSMS(Global_Cls.IntUserName, Global_Cls.IntPassword, Global_Cls.IntTelNumber, i==1);
                try
                {
                    System.DateTime dateT = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                    //string PhoneName = "";
                    //MsgCount = LLRS.Count();
                    foreach (SMS_Cls.ListReciveSMS Msg in LLRS)
                    {
                        //if (dateT.AddSeconds(double.Parse(Msg.ReceiveDate)) >= Dt1 &&
                        //    dateT.AddSeconds(double.Parse(Msg.ReceiveDate)) <= Dt2)
                        if (UnixTimeStampToDateTime(double.Parse(Msg.ReceiveDate)).Date >= Dt1.Date &&
                            UnixTimeStampToDateTime(double.Parse(Msg.ReceiveDate)).Date <= Dt2.Date)
                        {
                            DataRow DR = DT.NewRow();
                            DR["Checked"] = false;
                            DR["Mobile"] = Msg.SenderNumber;
                            DR["Message"] = Msg.Body;
                            DR["DateReciveMiladi"] = dateT.AddSeconds(double.Parse(Msg.ReceiveDate));
                                                   //UnixTimeStampToDateTime(double.Parse(Msg.ReceiveDate))
                            DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(dateT.AddSeconds(double.Parse(Msg.ReceiveDate)));
                            DR["TimeStampRFC"] = Msg.ReceiveDate;//Msg.TimeStampRFC;
                            DR["Index"] = m;//Msg.Index;
                            DR["ConfirmOK"] = 0;
                            DR["RecipientNumber"] = Msg.RecipientNumber;
                            DR["MessageID"] = Msg.MessageID;
                            DT.Rows.Add(DR);
                            m++;
                        }
                    }
                    //return "";
                }
                catch { }


                Result = "مجموع پیامک ها: " + m;
                if (m > 0)
                    Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";

            }
            else
            {
                // new 950308

                string storage = "";

                if (i == 0) storage = PhoneStorageType.Sim;
                else storage = PhoneStorageType.Phone;

                try
                {

                    comm = new GsmCommMain(
                        Convert.ToInt16(Global_Cls.SMSPort.Replace("COM", "")),
                        Convert.ToInt32(Global_Cls.SMSBaudRate),
                        400);
                    comm.Open();
                    DecodedShortMessage[] messages = comm.ReadMessages(PhoneMessageStatus.All, storage);
                    foreach (DecodedShortMessage message in messages)
                    {
                        FillDataTable(message.Data, ref DT, message.Index);
                    }

                    Result = "مجموع پیامک ها: " + messages.Count();
                    if (messages.Count() > 0)
                        Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";

                }
                catch (Exception ex)
                {
                    Result = ex.Message;
                }
                comm.Close();
            }
            return Result;
        }

        private static void FillDataTable(SmsPdu pdu, ref DataTable DT, int index)
        {
            if (pdu is SmsSubmitPdu)
            {
                // Stored (sent/unsent) message
                SmsSubmitPdu data = (SmsSubmitPdu)pdu;

                DataRow DR = DT.NewRow(); 
                DR["Checked"] = false;
                DR["Mobile"] = data.DestinationAddress;
                DR["Message"] = data.UserDataText;
                DR["DateReciveMiladi"] = DateTime.Parse(("20" + data.GetTimestamp().Year + "-" + data.GetTimestamp().Month.ToString("00") + "-" + data.GetTimestamp().Day.ToString("00") + " " + data.GetTimestamp().Hour + ":" + data.GetTimestamp().Minute).ToString());
                DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(DateTime.Parse(("20" + data.GetTimestamp().Year + "-" + data.GetTimestamp().Month.ToString("00") + "-" + data.GetTimestamp().Day.ToString("00") + " " + data.GetTimestamp().Hour + ":" + data.GetTimestamp().Minute).ToString()));
                DR["TimeStampRFC"] = data.GetTimestamp();
                DR["Index"] = index;
                DR["ConfirmOK"] = 0;

                DT.Rows.Add(DR);
                return;
            }
            if (pdu is SmsDeliverPdu)
            {
                // Received message
                SmsDeliverPdu data = (SmsDeliverPdu)pdu;
                DataRow DR = DT.NewRow(); 
                DR["Checked"] = false;
                DR["Mobile"] = data.OriginatingAddress;
                DR["Message"] = data.UserDataText;
                DR["DateReciveMiladi"] = DateTime.Parse(("20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month.ToString("00") + "-" + data.SCTimestamp.Day.ToString("00") + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute).ToString());
                DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(DateTime.Parse(("20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month.ToString("00") + "-" + data.SCTimestamp.Day.ToString("00") + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute).ToString()));
                DR["TimeStampRFC"] = data.SCTimestamp;
                DR["Index"] = index;
                DR["ConfirmOK"] = 0;
                
                DT.Rows.Add(DR);
                return;
            }
            if (pdu is SmsStatusReportPdu)
            {
                // Status report
                SmsStatusReportPdu data = (SmsStatusReportPdu)pdu;
                
                DataRow DR = DT.NewRow();
                DR["Checked"] = false;
                DR["Mobile"] = data.RecipientAddress;
                DR["Message"] = data.UserDataText;
                DR["DateReciveMiladi"] = DateTime.Parse(("20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month.ToString("00") + "-" + data.SCTimestamp.Day.ToString("00") + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute).ToString());
                DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(DateTime.Parse(("20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month.ToString("00") + "-" + data.SCTimestamp.Day.ToString("00") + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute).ToString()));
                DR["TimeStampRFC"] = data.SCTimestamp;
                DR["Index"] = index;
                DR["ConfirmOK"] = 0;

                DT.Rows.Add(DR);
                return;
            }
            //Output("Unknown message type: " + pdu.GetType().ToString());

        }

        public static string DeleteSMS(int index, int SimPhone)
        {
            string Result = "";

            // new 950308
            if (Global_Cls.SMSSet)
            {
            }
            else
            {
                string storage = "";
                if (SimPhone == 0) storage = PhoneStorageType.Sim;
                else storage = PhoneStorageType.Phone;

                comm = new GsmCommMain(
                    Convert.ToInt16(Global_Cls.SMSPort.Replace("COM", "")),
                    Convert.ToInt32(Global_Cls.SMSBaudRate),
                    400);

                try
                {
                    comm.Open();
                    comm.DeleteMessage(index, storage);
                }
                catch (Exception ex)
                {
                    Result = ex.Message;
                }
                comm.Close();
            }
            return Result;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
