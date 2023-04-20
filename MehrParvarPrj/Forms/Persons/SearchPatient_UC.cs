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
    public partial class SearchPatient_UC : UserControl
    {
        public SearchPatient_UC()
        {
            InitializeComponent();
        }

        private DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
       
        private void SearchPatient_UC_Load(object sender, EventArgs e)
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
            panelLastOverhalDate1_Leave(this, null);
            panelLastOverhalDate2_Leave(this, null);


           
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
                            PropertyName = "LastDocHealthName",
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
                        Value = Convert.ChangeType(numericUpDownPercentState1.Value.ToString(), typeof(short)),
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    });

                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "PercentState",
                        Operation = QueryFilter.ExpressionBuilder.Op.LessThanOrEqual,
                        Value = Convert.ChangeType(numericUpDownPercentState2.Value.ToString(), typeof(short)),
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

                if (checkBoxLastOverhalDate.Checked)
                {
                    DateTime DateStart = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO1.Text, comboBoxMonthLO1.Text, comboBoxDayLO1.Text);
                    DateTime DateEnd = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO2.Text, comboBoxMonthLO2.Text, comboBoxDayLO2.Text);

                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "LastOverhalDateMiladi",
                        Operation = QueryFilter.ExpressionBuilder.Op.GreaterThanOrEqual,
                        Value = DateStart,
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    });

                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "LastOverhalDateMiladi",
                        Operation = QueryFilter.ExpressionBuilder.Op.LessThanOrEqual,
                        Value = DateEnd,
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    });
                }
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
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
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
                                               OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                                           });
                    }
                }


                if (checkBoxDoctors.Checked)
                {
                    for (int i = 0; i < textBoxDoctors.Lines.Count(); i++)
                    {
                        filter.Add(new QueryFilter.ExpressionBuilder.Filter
                        {
                            PropertyName = "LastDocHealthName",
                            Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                            Value = textBoxDoctors.Lines[i],
                            OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
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

                if (checkBoxLastOverhalDate.Checked)
                {
                    DateTime DateStart = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO1.Text, comboBoxMonthLO1.Text, comboBoxDayLO1.Text);
                    DateTime DateEnd = Global_Cls.ShamsiDateToMiladi(comboBoxYearLO2.Text, comboBoxMonthLO2.Text, comboBoxDayLO2.Text);

                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "LastOverhalDateMiladi",
                        Operation = QueryFilter.ExpressionBuilder.Op.GreaterThanOrEqual,
                        Value = DateStart,
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                    });

                    filter.Add(new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "LastOverhalDateMiladi",
                        Operation = QueryFilter.ExpressionBuilder.Op.LessThanOrEqual,
                        Value = DateEnd,
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                    });
                }
            }

            try
            {
                ListDocPat_UC Uc = new ListDocPat_UC(true);
                Uc.filterPatList = filter;
                Global_Cls.MainForm.AddTabToTabControl("ListDocPat" + DateTime.Now.ToLocalTime().ToString(), (string)((textBox_TabN.Text == "") ? " لیست انتخابی بیماران " : (textBox_TabN.Text)), Uc);
            }
            catch { }

        }

   
        #endregion


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

    }
}
