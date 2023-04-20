using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.Properties;
using MehrParvarPrj.DataLinq;

namespace MehrParvarPrj
{
    public partial class SearchPatientVisit_UC : UserControl
    {
        public SearchPatientVisit_UC()
        {
            InitializeComponent();
        }

        private DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
       
        private void SearchPatientVisit_UC_Load(object sender, EventArgs e)
        {
            if (itemPanelPatientType.Items.Count == 0)
                foreach (var item in DCDC.TBL_PatientTypes)
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.PatientTypeId.ToString();
                    Ch.Text = item.PatientTypeDsc;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelPatientType.Items.Add(Ch);
                    itemPanelPatientType.Refresh();
                }

            if (itemPanelInjuryType.Items.Count == 0)
                foreach (var item in DCDC.TBL_InjuryTypes)
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.InjuryTypeId.ToString();
                    Ch.Text = item.InjuryTypeDsc;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelInjuryType.Items.Add(Ch);
                    itemPanelInjuryType.Refresh();
                }

            if (itemPanel_AddressPart.Items.Count == 0)
                foreach (int? jj in (from prd in DCDC.TBL_Patients
                                    select prd.AddressPart).Distinct())
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = jj.ToString();
                    Ch.Text = jj.ToString();
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    //Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
                    itemPanel_AddressPart.Items.Add(Ch);
                    itemPanel_AddressPart.Refresh();
                }

            if (itemPanelInstitutePart.Items.Count == 0)
            {
                
                foreach (short? kk in (from prd in DCDC.TBL_Patients
                                    select prd.InstitutePart).Distinct())
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = kk.ToString();
                    Ch.Text = kk.ToString();
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    //Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
                    itemPanelInstitutePart.Items.Add(Ch);
                    itemPanelInstitutePart.Refresh();
                }
            }
            SetDateToModules();
        }

        #endregion


        #region Set Date Module

        private void SetDateToModules()
        {
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBoxYearLO1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString(); comboBoxYearLO2.Text = comboBoxYearLO1.Text;
            comboBoxMonthLO1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString(); comboBoxMonthLO2.Text = comboBoxMonthLO1.Text;
            comboBoxDayLO1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString(); comboBoxDayLO2.Text = comboBoxDayLO1.Text;
        }

        private void panelLastOverhalDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthLO1.Text) > 6 && Convert.ToInt16(comboBoxDayLO1.Text) == 31) comboBoxDayLO1.Text = "30";
            if (Convert.ToInt16(comboBoxMonthLO1.Text) == 12 && (Convert.ToInt16(comboBoxDayLO1.Text) == 31 || Convert.ToInt16(comboBoxDayLO1.Text) == 30)) comboBoxDayLO1.Text = "29";
        }

        private void panelLastOverhalDate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBoxMonthLO2.Text) > 6 && Convert.ToInt16(comboBoxDayLO2.Text) == 31) comboBoxDayLO2.Text = "30";
            if (Convert.ToInt16(comboBoxMonthLO2.Text) == 12 && (Convert.ToInt16(comboBoxDayLO2.Text) == 31 || Convert.ToInt16(comboBoxDayLO2.Text) == 30)) comboBoxDayLO2.Text = "29";
        }

        #endregion


        #region Search
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            DateTime DateStart = DateTime.MinValue; DateTime DateEnd = DateTime.MinValue;
            panelLastOverhalDate1_Leave(this, null);
            panelLastOverhalDate2_Leave(this, null);

            bool LastVisitCodeSet = false;

            List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();

            if (checkBoxOr.Checked)
            {
                if (CheckBoxNationalCode.Checked)
                {
                    for (int i = 0; i < textBoxNationalCode.Lines.Count(); i++)
                    {
                        filter.Add(
                        new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "NationalCode",
                            Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                            Value = textBoxNationalCode.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        }
                        );
                    }
                }

                if (checkBoxDosiersNo.Checked)
                {
                    for (int i = 0; i < textBoxDosiersNo.Lines.Count(); i++)
                    {
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "DosiersNo",
                            Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                            Value = textBoxDosiersNo.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });
                    }
                }


                if (checkBoxDoctors.Checked)
                {
                    for (int i = 0; i < textBoxDoctors.Lines.Count(); i++)
                    {
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "DoctorNameF",
                            Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                            Value = textBoxDoctors.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });
                    }
                }

                if (checkBoxAddress.Checked)
                {
                    for (int i = 0; i < textBoxAddress.Lines.Count(); i++)
                    {
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "Address",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = textBoxAddress.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });
                    }
                }

                if (checkBoxPatientType.Checked)
                {
                    foreach (var item in itemPanelPatientType.Items)
                    {
                        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        {
                            filter.Add(new QueryFilter.ExpressionBuilder.Filter
                            {
                                PropertyName = "PatientTypeStr",
                                Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                                Value = (item as DevComponents.DotNetBar.CheckBoxItem).Text,
                                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                            });
                        }
                    }
                }

                if (checkBoxInjuryType.Checked)
                {
                    foreach (var item in itemPanelInjuryType.Items)
                    {
                        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        {
                            filter.Add(new QueryFilter.ExpressionBuilder.Filter
                            {
                                PropertyName = "InjuryTypeStr",
                                Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                                Value = (item as DevComponents.DotNetBar.CheckBoxItem).Text,
                                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                            });
                        }
                    }
                }

                if (checkBoxPercentState.Checked)
                {
                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "PercentState",
                        Operation = QueryFilter.ExpressionBuilder.Op.GreaterThanOrEqual,
                        Value = Convert.ToInt16(numericUpDownPercentState1.Value),
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    });

                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "PercentState",
                        Operation = QueryFilter.ExpressionBuilder.Op.LessThanOrEqual,
                        Value = Convert.ToInt16(numericUpDownPercentState2.Value),
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    });
                }


                if (checkBoxInstitutePart.Checked)
                {
                    foreach (var item in itemPanelInstitutePart.Items)
                    {
                        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        {
                            filter.Add(new QueryFilter.ExpressionBuilder.Filter
                            {
                                PropertyName = "InstitutePart",
                                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                                Value = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Text),
                                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                            });
                        }
                    }
                }

                if (checkBoxAddressPrt.Checked)
                {
                    foreach (var item in itemPanel_AddressPart.Items)
                    {
                        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        {
                            filter.Add(new QueryFilter.ExpressionBuilder.Filter
                            {
                                PropertyName = "AddressPart",
                                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                                Value = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Text),
                                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                            });
                        }
                    }
                }

                if (checkBoxVisitDate.Checked)
                {
                    DateStart = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO1.Text, comboBoxMonthLO1.Text, comboBoxDayLO1.Text);
                    DateEnd = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO2.Text, comboBoxMonthLO2.Text, comboBoxDayLO2.Text);

                    //filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    //{
                    //    PropertyName = "VisitDateMiladi",
                    //    Operation = QueryFilter.ExpressionBuilder.Op.GreaterThanOrEqual,
                    //    Value = DateStart,
                    //    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    //});

                    //filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    //{
                    //    PropertyName = "VisitDateMiladi",
                    //    Operation = QueryFilter.ExpressionBuilder.Op.LessThanOrEqual,
                    //    Value = DateEnd,
                    //    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    //});
                }

                if (chkDrugsHistory.Checked)
                    for (int i = 0; i < listViewDrugsHistory.Items.Count; i++)
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "DrugsHistory",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = listViewDrugsHistory.Items[i].Text,
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });

                if (chkStateSickness.Checked)
                    for (int i = 0; i < listViewStateSickness.Items.Count; i++)
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "StateSickness",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = listViewStateSickness.Items[i].Text,
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });

                if (chkbedsore.Checked)
                    for (int i = 0; i < listViewBedsore.Items.Count; i++)
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "Bedsore",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = listViewBedsore.Items[i].Text,
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });


                if (chkParaclinic.Checked)
                    for (int i = 0; i < listViewParaclinic.Items.Count; i++)
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "Paraclinic",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = listViewParaclinic.Items[i].Text,
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });

                if (checkBoxLastVisitCode.Checked)
                    LastVisitCodeSet = true;
            
            }
            
            
            else
            
            
            
            
            {
                if (CheckBoxNationalCode.Checked)
                {
                    for (int i = 0; i < textBoxNationalCode.Lines.Count(); i++)
                    {
                        filter.Add(
                        new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "NationalCode",
                            Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                            Value = textBoxNationalCode.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        }
                        );
                    }

                    
                }

                if (checkBoxDosiersNo.Checked)
                {
                    for (int i = 0; i < textBoxDosiersNo.Lines.Count(); i++)
                    {
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "DosiersNo",
                            Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                            Value = textBoxDosiersNo.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });
                    }
                }


                if (checkBoxDoctors.Checked)
                {
                    for (int i = 0; i < textBoxDoctors.Lines.Count(); i++)
                    {
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "DoctorNameF",
                            Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                            Value = textBoxDoctors.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                        });
                    }
                }

                if (checkBoxAddress.Checked)
                {
                    for (int i = 0; i < textBoxAddress.Lines.Count(); i++)
                    {
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "Address",
                            Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                            Value = textBoxAddress.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                        });
                    }
                }

                if (checkBoxPatientType.Checked)
                {
                    foreach (var item in itemPanelPatientType.Items)
                    {
                        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        {
                            filter.Add(new QueryFilter.ExpressionBuilder.Filter
                            {
                                PropertyName = "PatientTypeStr",
                                Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                                Value = (item as DevComponents.DotNetBar.CheckBoxItem).Text,
                                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                            });
                        }
                    }
                }

                if (checkBoxInjuryType.Checked)
                {
                    foreach (var item in itemPanelInjuryType.Items)
                    {
                        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        {
                            filter.Add(new QueryFilter.ExpressionBuilder.Filter
                            {
                                PropertyName = "InjuryTypeStr",
                                Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                                Value = (item as DevComponents.DotNetBar.CheckBoxItem).Text,
                                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                            });
                        }
                    }
                }

                if (checkBoxPercentState.Checked)
                {
                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "PercentState",
                        Operation = QueryFilter.ExpressionBuilder.Op.GreaterThanOrEqual,
                        Value = Convert.ToInt16(numericUpDownPercentState1.Value),
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                    });

                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "PercentState",
                        Operation = QueryFilter.ExpressionBuilder.Op.LessThanOrEqual,
                        Value = Convert.ToInt16(numericUpDownPercentState2.Value),
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                    });
                }


                if (checkBoxInstitutePart.Checked)
                {
                    foreach (var item in itemPanelInstitutePart.Items)
                    {
                        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        {
                            filter.Add(new QueryFilter.ExpressionBuilder.Filter
                            {
                                PropertyName = "InstitutePart",
                                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                                Value = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Text),
                                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                            });
                        }
                    }
                }

                if (checkBoxAddressPrt.Checked)
                {
                    foreach (var item in itemPanel_AddressPart.Items)
                    {
                        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        {
                            filter.Add(new QueryFilter.ExpressionBuilder.Filter
                            {
                                PropertyName = "AddressPart",
                                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                                Value = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Text),
                                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                            });
                        }
                    }
                }

                
                if (checkBoxVisitDate.Checked)
                {
                    DateStart = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO1.Text, comboBoxMonthLO1.Text, comboBoxDayLO1.Text);
                    DateEnd = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO2.Text, comboBoxMonthLO2.Text, comboBoxDayLO2.Text);

                    //filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    //{
                    //    PropertyName = "VisitDateMiladi",
                    //    Operation = QueryFilter.ExpressionBuilder.Op.GreaterThanOrEqual,
                    //    Value = DateStart,
                    //    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                    //});

                    //filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    //{
                    //    PropertyName = "VisitDateMiladi",
                    //    Operation = QueryFilter.ExpressionBuilder.Op.LessThanOrEqual,
                    //    Value = DateEnd,
                    //    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                    //});
                }
                
                if (chkDrugsHistory.Checked)
                    for (int i = 0; i < listViewDrugsHistory.Items.Count; i++)
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "DrugsHistory",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = listViewDrugsHistory.Items[i].Text,
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                        });

                if (chkStateSickness.Checked)
                    for (int i = 0; i < listViewStateSickness.Items.Count; i++)
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "StateSickness",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = listViewStateSickness.Items[i].Text,
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                        });

                if (chkbedsore.Checked)
                    for (int i = 0; i < listViewBedsore.Items.Count; i++)
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "Bedsore",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = listViewBedsore.Items[i].Text,
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                        });


                if (chkParaclinic.Checked)
                    for (int i = 0; i < listViewParaclinic.Items.Count; i++)
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "Paraclinic",
                            Operation = QueryFilter.ExpressionBuilder.Op.Contains,
                            Value = listViewParaclinic.Items[i].Text,
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                        });

                if (checkBoxLastVisitCode.Checked)
                    LastVisitCodeSet = true;
            }


            try
            {
                ListPatientVisit_UC Uc = new ListPatientVisit_UC(LastVisitCodeSet, DateStart, DateEnd);
                Uc.filter = filter;
                Global_Cls.MainForm.AddTabToTabControl("ListPatientVisit" + DateTime.Now.ToLocalTime().ToString(), (string)((textBox_TabN.Text == "") ? " لیست انتخابی ویزیت بیماران " : (textBox_TabN.Text)), Uc);
            }
            catch { }

        }

        public List<VW_PatientVisit> GetListByFilter(List<QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = QueryFilter.ExpressionBuilder.GetExpression<VW_PatientVisit>(filter).Compile();
                var filteredCollection = (from d in DCDC.VW_PatientVisits select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }
        #endregion



        //////List<Tuple<string, string, QueryFilter.ColumnType>> A =
        //////               new List<Tuple<string, string, QueryFilter.ColumnType>>();

        //////if (CheckBoxNationalCode.Checked)
        //////    A.Add(new Tuple<string, string, QueryFilter.ColumnType>("NationalCode", textBoxNationalCode.Text, QueryFilter.ColumnType.String));
        //////if (checkBoxDosiersNo.Checked)
        //////    A.Add(new Tuple<string, string, QueryFilter.ColumnType>("DosiersNo", textBoxDosiersNo.Text, QueryFilter.ColumnType.String));
        //////if (checkBoxDoctors.Checked)
        //////    A.Add(new Tuple<string, string, QueryFilter.ColumnType>("LastDocHealthName", textBoxDoctors.Text, QueryFilter.ColumnType.String));
        //////if (checkBoxAddress.Checked)
        //////    A.Add(new Tuple<string, string, QueryFilter.ColumnType>("Address", textBoxAddress.Text, QueryFilter.ColumnType.String));

        //////if (checkBoxPatientType.Checked)
        //////    foreach (var item in itemPanelPatientType.Items)
        //////        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
        //////            A.Add(new Tuple<string, string, QueryFilter.ColumnType>("PatientTypeStr", (item as DevComponents.DotNetBar.CheckBoxItem).Text, QueryFilter.ColumnType.String));

        //////if (checkBoxInjuryType.Checked)
        //////    foreach (var item in itemPanelInjuryType.Items)
        //////        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
        //////            A.Add(new Tuple<string, string, QueryFilter.ColumnType>("InjuryTypeStr", (item as DevComponents.DotNetBar.CheckBoxItem).Text, QueryFilter.ColumnType.String));


        //////List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>()
        //////    {
        //////         new QueryFilter.ExpressionBuilder.Filter { PropertyName = "User_Id" , 
        //////             Operation = QueryFilter.ExpressionBuilder.Op.Equals, Value = _user_Id , OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And },
        //////         new QueryFilter.ExpressionBuilder.Filter { PropertyName = "SoftwareGroupName" , 
        //////             Operation = QueryFilter.ExpressionBuilder.Op.Equals, Value = item.Text, OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And  },
        //////         //new MSS.Library.Clasess.ViewModelCode.QueryFilter.ExpressionBuilder.Filter { PropertyName = "Salary" , 
        //////         //    Operation = MSS.Library.Clasess.ViewModelCode.QueryFilter.ExpressionBuilder.Op.GreaterThan, Value = 9000.0 }
        //////     };




        ////var SUS = from prd in DCDC.VW_PatientLists
        ////          select prd;

        ////string NationalCodeStr = "";
        ////if (CheckBoxNationalCode.Checked)
        ////{
        ////    for (int i = 0; i < textBoxNationalCode.Lines.Count(); i++)
        ////    {
        ////        NationalCodeStr += textBoxNationalCode.Lines[i] + ",";
        ////    }
        ////    SUS = SUS.Where(h => h.NationalCode.Contains(NationalCodeStr));
        ////}

        ////if (checkBoxDosiersNo.Checked)
        ////    SUS = SUS.Where(h => textBoxDosiersNo.Text.Contains(h.DosiersNo));
        ////if (checkBoxDoctors.Checked) 
        ////    SUS = SUS.Where(h => textBoxDoctors.Text.Contains(h.LastDocHealthName));
        ////if (checkBoxAddress.Checked)
        ////    SUS = SUS.Where(h => textBoxAddress.Text.Contains(h.Address));
        ////string StrPatientType = "";
        ////if (checkBoxPatientType.Checked)
        ////{
        ////    foreach (var item in itemPanelPatientType.Items)
        ////        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
        ////            StrPatientType += (item as DevComponents.DotNetBar.CheckBoxItem).Text + ",";
        ////    SUS = SUS.Where(h => h.PatientTypeStr.Contains(StrPatientType));
        ////}

        ////string StrInjuryType = "";
        ////if (checkBoxInjuryType.Checked)
        ////{
        ////    foreach (var item in itemPanelInjuryType.Items)
        ////        if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
        ////            StrInjuryType += (item as DevComponents.DotNetBar.CheckBoxItem).Text + ",";
        ////    SUS = SUS.Where(h => h.InjuryTypeStr.Contains(StrInjuryType));
        ////}

        //////if (checkBoxInstitutePart.Checked)
        //////    SUS = SUS.Where(h => h.InstitutePart >= Convert.ToInt16(numericUpDownInstitutePart1.Value) && h.InstitutePart <= Convert.ToInt16(numericUpDownInstitutePart2.Value));
        //////if (checkBoxAddressPrt.Checked)
        //////    SUS = SUS.Where(h => h.AddressPart >= Convert.ToInt16(numericUpDownAddressPrt1.Value) && h.AddressPart <= Convert.ToInt16(numericUpDownAddressPrt2.Value));
        ////if (checkBoxPercentState.Checked)
        ////    SUS = SUS.Where(h => h.PercentState >= Convert.ToInt16(numericUpDownPercentState1.Value) && h.PercentState <= Convert.ToInt16(numericUpDownPercentState2.Value));

        ////if (checkBoxVisitDate.Checked)
        ////{
        ////    //SUS = SUS.Where(h => h.LastOverhalDateDsc >= (comboBoxYearLO1.Text+"/"+comboBoxMonthLO1.Text+"/"+comboBoxDayLO1.Text)
        ////    //&& h.LastOverhalDateDsc >= (comboBoxYearLO1.Text + "/" + comboBoxMonthLO1.Text + "/" + comboBoxDayLO1.Text)
        ////    //);

        ////}

        #region Other
        TextBox tx = new TextBox();
        private void textBox_Subbuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar == '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }

        private void textBox_AHPrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            { e.KeyChar = '\0'; return; }

            if (e.KeyChar == (char)Keys.Space)
            {
                tx = (TextBox)sender;
                if (tx.Text.Length < 18) tx.Text = tx.Text + "000";
                tx.SelectionStart = tx.Text.Length;
            }
        }

        private void textBox_AHPrice1_TextChanged(object sender, EventArgs e)
        {
            tx = (TextBox)sender;

            string str = tx.Text;
            int ts = tx.SelectionStart;
            if (tx.Text != "")
            {
                try
                {
                    str = System.String.Format("{0:###,###}", System.Int64.Parse(str, System.Globalization.NumberStyles.Number));
                }
                catch
                {
                    str = str.Replace(",", "");
                }
                tx.Text = str.Replace(" ", "");
                tx.SelectionStart = ts + 1;
            }
        }
        #endregion


        #region  Select Doctors
        
        private void ButtonDoctors_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(1);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxDoctors.Tag = sp.CodeC;
                textBoxDoctors.Text += sp.NameC + "\r\n";
            }
        }
        
        #endregion


        #region VisitButton

        private void ButtonStateSickness_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(4);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                if (listViewStateSickness.Items.ContainsKey(sp.CodeC.ToString())) return;

                listViewStateSickness.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
                listViewStateSickness.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
            }
        }

        private void BottomStateSicknessDel_Click(object sender, EventArgs e)
        {
            int gh = listViewStateSickness.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                listViewStateSickness.SelectedItems[0].Remove();
        }

        private void ButtonBedsore_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(5);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                if (listViewBedsore.Items.ContainsKey(sp.CodeC.ToString())) return;

                listViewBedsore.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
                listViewBedsore.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
            }
        }

        private void ButtonBedsoreDel_Click(object sender, EventArgs e)
        {
            int gh = listViewBedsore.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                listViewBedsore.SelectedItems[0].Remove();
        }



        private void ButtonDrugsHistory_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(2);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                if (listViewDrugsHistory.Items.ContainsKey(sp.CodeC.ToString())) return;

                listViewDrugsHistory.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
                listViewDrugsHistory.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
            }
        }

        private void ButtonDrugsHistoryDel_Click(object sender, EventArgs e)
        {
            int gh = listViewDrugsHistory.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                listViewDrugsHistory.SelectedItems[0].Remove();
        }

        private void ButtonParaclinic_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(6);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                if (listViewParaclinic.Items.ContainsKey(sp.CodeC.ToString())) return;

                listViewParaclinic.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
                listViewParaclinic.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
            }
        }

        private void ButtonParaclinicDel_Click(object sender, EventArgs e)
        {
            int gh = listViewParaclinic.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                listViewParaclinic.SelectedItems[0].Remove();
        }


        #endregion
    }
}
