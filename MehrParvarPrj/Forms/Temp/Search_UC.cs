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
    public partial class Search_UC : UserControl
    {
        public Search_UC()
        {
            InitializeComponent();
        }

        private DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void Search_UC_Load(object sender, EventArgs e)
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                //if (UPer.Contains(buttonItem_AddCustomer.Name)) buttonItem_AddCustomer.Enabled = false;
            }


            ////new
            //for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
            //{
            //    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
            //    Ch.Name = i.ToString();
            //    Ch.Text = Global_Cls.TypeHouseAllCases[i];
            //    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            //    Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
            //    if (i == 0) Ch.Checked = true;
            //    itemPanel_TypeHouse.Items.Add(Ch, i);
            //    itemPanel_TypeHouse.Refresh();
            //}
            //for (int i = 0; i < Global_Cls.HouseForPrm.Count; i++)//new
            //{
            //    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
            //    Ch.Name = i.ToString();
            //    Ch.Text = Global_Cls.HouseForPrm[i];//new
            //    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            //    Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
            //    if (i == 0) Ch.Checked = true;
            //    itemPanel_HouseFor.Items.Add(Ch, i);
            //    itemPanel_HouseFor.Refresh();
            //}

            SetDateToModules();

            //
            //label_Mny1.Text = Global_Cls.Money_Unit;
            //label_Mny2.Text = label_Mny1.Text;
            //label_Mny3.Text = label_Mny1.Text;
            //label_Mny4.Text = label_Mny1.Text;

//new
        }
        #endregion


        #region Set Date Module

        private void SetDateToModules()
        {
            //string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            //comboBox_HYear1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString(); comboBox_HYear2.Text = comboBox_HYear1.Text;
            //comboBox_HMonth1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString(); comboBox_HMonth2.Text = comboBox_HMonth1.Text;
            //comboBox_Hday1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString(); comboBox_Hday2.Text = comboBox_Hday1.Text;
        }

        private void panel_HDate1_Leave(object sender, EventArgs e)
        {
            //if (Convert.ToInt16(comboBox_HMonth1.Text) > 6 && Convert.ToInt16(comboBox_Hday1.Text) == 31) comboBox_Hday1.Text = "30";
            //if (Convert.ToInt16(comboBox_HMonth1.Text) == 12 && (Convert.ToInt16(comboBox_Hday1.Text) == 31 || Convert.ToInt16(comboBox_Hday1.Text) == 30)) comboBox_Hday1.Text = "29";
        }

        private void panel_HDate2_Leave(object sender, EventArgs e)
        {
            //if (Convert.ToInt16(comboBox_HMonth2.Text) > 6 && Convert.ToInt16(comboBox_Hday2.Text) == 31) comboBox_Hday2.Text = "30";
            //if (Convert.ToInt16(comboBox_HMonth2.Text) == 12 && (Convert.ToInt16(comboBox_Hday2.Text) == 31 || Convert.ToInt16(comboBox_Hday2.Text) == 30)) comboBox_Hday2.Text = "29";
        }

        #endregion


        #region Search
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            //panel_HDate1_Leave(this, null);
            //panel_HDate2_Leave(this, null);

            ////new
            //string TypeHouseStr = "", HouseForStr = "";
            //for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
            //    if ((itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
            //    { TypeHouseStr = itemPanel_TypeHouse.Items[i].Text; break; }

            //for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
            //    if ((itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
            //    { HouseForStr = itemPanel_HouseFor.Items[i].Text; break; }

            /*string HouseFor = "";
            if (checkBox_Buy.Checked) HouseFor = "فروش";
            else if (checkBox_Rent.Checked && checkBox_Mortgage.Checked) HouseFor = "رهن و اجاره";
            else if (checkBox_Mortgage.Checked) HouseFor = "رهن";
            else if (checkBox_Rent.Checked) HouseFor = "اجاره";
            else if (checkBox_PreBuy.Checked) HouseFor = "پیش فروش";
            else if (checkBox_Prtpc.Checked) HouseFor = "مشارکت";

            string TypeHouse = "";
            if (radioButton_Apartmnt.Checked) TypeHouse = "آپارتمان";
            else if (radioButton_Dila.Checked) TypeHouse = "کلنگی";
            else if (radioButton_Garden.Checked) TypeHouse = "باغ";
            else if (radioButton_Ln.Checked) TypeHouse = "زمین";
            else if (radioButton_PLn.Checked) TypeHouse = "زمین نیمه کاره";
            else if (radioButton_SGarden.Checked) TypeHouse = "باغچه";
            else if (radioButton_Shop.Checked) TypeHouse = "مغازه";
            else if (radioButton_SR.Checked) TypeHouse = "انبار";
            else if (radioButton_St.Checked) TypeHouse = "سوئیت";
            else if (radioButton_Tent.Checked) TypeHouse = "مستغلات";
            else if (radioButton_Villa.Checked) TypeHouse = "ویلا";
            else if (radioButton_WR.Checked) TypeHouse = "دفتر کار";*/
            //new


            string ListWhereSearch = " 1=1 ";

            if (RadioButtonDosiers.Checked) ListWhereSearch += " And (DosiersNo in ( '" + (textBox_FileNo1.Text == "" ? "0" : textBox_FileNo1.Text).Replace(",", "','") + "'))";
            if (checkBox1.Checked) ListWhereSearch += " And (Address like ( '%" + textBox1.Text+ "%'))";
            //if (checkBox_FileNo.Checked) ListWhereSearch = textBox_FileNo1.Text == "" ? "0" : textBox_FileNo1.Text;
           
            
            //if (checkBox_Date.Checked) ListWhereSearch += " And (Modify_Date >= '" + Global_Cls.ShamsiDateToMiladi(comboBox_HYear1.Text, comboBox_HMonth1.Text, comboBox_Hday1.Text).ToShortDateString() + "') And (Modify_Date <= '" + Global_Cls.ShamsiDateToMiladi(comboBox_HYear2.Text, comboBox_HMonth2.Text, comboBox_Hday2.Text).ToShortDateString() + "')";

            //if (checkBox_HouseFor.Checked) ListWhereSearch += " And (HouseFor = N'" + HouseForStr + "')";
            // //New
            //else if (Global_Cls.MainForm.UserPrmHouseFor != "admin")
            //        ListWhereSearch += " And (patindex('%'+HouseFor+'%',N'" + Global_Cls.MainForm.UserPrmHouseFor + "')>0 )";
            ////New
            
            //if (checkBox_TypeHouse.Checked) ListWhereSearch += " And (TypeHouse = N'" + TypeHouseStr + "')";

            //if (checkBox_AHPrice.Checked) ListWhereSearch += " And (Price_HouseAll >= " + (string)((textBox_AHPrice1.Text == "") ? "0" : (textBox_AHPrice1.Text)).Replace(",", "") + ") And (Price_HouseAll <= " + (string)((textBox_AHPrice2.Text == "") ? "0" : (textBox_AHPrice2.Text)).Replace(",", "") + ")";
            //if (checkBox_MHPrice.Checked) ListWhereSearch += " And (Price_HouseMeter >= " + (string)((textBox_MHPrice1.Text == "") ? "0" : (textBox_MHPrice1.Text)).Replace(",", "") + ") And (Price_HouseMeter <= " + (string)((textBox_MHPrice2.Text == "") ? "0" : (textBox_MHPrice2.Text)).Replace(",", "") + ")";
            //if (checkBox_MPrice.Checked) ListWhereSearch += " And (Price_Mortgage >= " + (string)((textBox_MPrice1.Text == "") ? "0" : (textBox_MPrice1.Text)).Replace(",", "") + ") And (Price_Mortgage <= " + (string)((textBox_MPrice2.Text == "") ? "0" : (textBox_MPrice2.Text)).Replace(",", "") + ")";
            //if (checkBox_RPrice.Checked) ListWhereSearch += " And (Price_Rent >= " + (string)((textBox_RPrice1.Text == "") ? "0" : (textBox_RPrice1.Text)).Replace(",", "") + ") And (Price_Rent <= " + (string)((textBox_RPrice2.Text == "") ? "0" : (textBox_RPrice2.Text)).Replace(",", "") + ")";

            //if (checkBox_Subbuild.Checked) ListWhereSearch += " And (FH_Submeter >= " + (string)((textBox_Subbuild1.Text == "") ? "0" : (textBox_Subbuild1.Text)) + ") And (FH_Submeter <= " + (string)((textBox_Subbuild2.Text == "") ? "0" : (textBox_Subbuild2.Text)) + ")";
            //if (checkBox_FewFloor.Checked) ListWhereSearch += " And (Few_estate >= " + nUpDown_FewFloor1.Value.ToString() + ") And (Few_estate <= " + nUpDown_FewFloor2.Value.ToString() + ")";
            //if (checkBox_FUF.Checked) ListWhereSearch += " And (Few_estateunit >= " + nUpDown_FUF1.Value.ToString() + ") And (Few_estateunit <= " + nUpDown_FUF2.Value.ToString() + ")";
            //if (checkBox_FBed.Checked) ListWhereSearch += " And (FH_BedRoomFew >= " + nUpDown_FBed1.Value.ToString() + ") And (FH_BedRoomFew <= " + nUpDown_FBed2.Value.ToString() + ")";

            //if (checkBox_MK.Checked) ListWhereSearch += " And (FH_KitchenModel = N'" + comboBox_MK.Text + "') ";
            //if (checkBox_CT.Checked) ListWhereSearch += " And (FH_CupbrdType = N'" + comboBox_CT.Text + "') ";
            //if (checkBox_BedRoom.Checked) ListWhereSearch += " And (FH_BedRoom = N'" + comboBox_BedRoom.Text + "') ";
            //if (checkBox_RcRoom.Checked) ListWhereSearch += " And (FH_RcRoom = N'" + comboBox_RcRoom.Text + "') ";
            //if (checkBox_BldLow.Checked) ListWhereSearch += " And (FH_BldLow = N'" + comboBox_BldLow.Text + "') ";
            //if (checkBox_WallCover.Checked) ListWhereSearch += " And (FH_WallCover = N'" + comboBox_WallCover.Text + "') ";

            //if (checkBox_FWc.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (FH_WcForeign = " + Convert.ToInt16(checkBox_FWc.Checked).ToString() + ")";
            //if (checkBox_Parking.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (FH_Parking = " + Convert.ToInt16(checkBox_Parking.Checked).ToString() + ")";
            //if (checkBox_StRoom.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (FH_StoreRoom = " + Convert.ToInt16(checkBox_StRoom.Checked).ToString() + ")";
            //if (checkBox_Yard.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (FH_Yard = " + Convert.ToInt16(checkBox_Yard.Checked).ToString() + ")";
            //if (checkBox_Cellar.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (FH_Cellar = " + Convert.ToInt16(checkBox_Cellar.Checked).ToString() + ")";
            //if (checkBox_RDoor.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (FH_RemotingDoor = " + Convert.ToInt16(checkBox_RDoor.Checked).ToString() + ")";
            //if (checkBox_Elevatoor.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (CH_Elevator = " + Convert.ToInt16(checkBox_Elevatoor.Checked).ToString() + ")";
            //if (checkBox_AV.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (FH_AifoonVideo = " + Convert.ToInt16(checkBox_AV.Checked).ToString() + ")";
            //if (checkBox_Cooler.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (CH_Cooler = " + Convert.ToInt16(checkBox_Cooler.Checked).ToString() + ")";
            //if (checkBox_Heat.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (CH_Heat = " + Convert.ToInt16(checkBox_Heat.Checked).ToString() + ")";
            //if (checkBox_Jacuzzi.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (CH_Jacuzzi = " + Convert.ToInt16(checkBox_Jacuzzi.Checked).ToString() + ")";
            //if (checkBox_Pool.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (CH_pool = " + Convert.ToInt16(checkBox_Pool.Checked).ToString() + ")";

            //if (checkBox_LndArea.Checked) ListWhereSearch += " And (RH_LandArea >= " + (string)((textBox_LndArea1.Text == "") ? "0" : (textBox_LndArea1.Text)) + ") And (RH_LandArea <= " + (string)((textBox_LndArea2.Text == "") ? "0" : (textBox_LndArea2.Text)) + ")";
            //if (checkBox_BldAge.Checked) ListWhereSearch += " And (RH_Bldage >= " + nUpDown_BldAge1.Value.ToString() + ") And (RH_Bldage <= " + nUpDown_BldAge2.Value.ToString() + ")";

            //if (checkBox_UseType.Checked) ListWhereSearch += " And (RH_UseType = N'" + comboBox_UseType.Text + "') ";
            //if (checkBox_DocType.Checked) ListWhereSearch += " And (RH_DocType = N'" + comboBox_DocType.Text + "') ";

            //if (checkBox_DocUse.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (RH_DocUse = " + Convert.ToInt16(checkBox_DocUse.Checked).ToString() + ")";
            //if (checkBox_Property.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (RH_Property = " + Convert.ToInt16(checkBox_Property.Checked).ToString() + ")";
            //if (checkBox_LordExist.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (OH_LordExist = " + Convert.ToInt16(checkBox_LordExist.Checked).ToString() + ")";
            //if (checkBox_KeyMoney.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (RH_KeyMoney = " + Convert.ToInt16(checkBox_KeyMoney.Checked).ToString() + ")";
            //if (checkBox_Discharge.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (OH_Discharge = " + Convert.ToInt16(checkBox_Discharge.Checked).ToString() + ")";
            //if (checkBox_RentUse.CheckState != CheckState.Indeterminate) ListWhereSearch += " And (OH_RentUse = " + Convert.ToInt16(checkBox_RentUse.Checked).ToString() + ")";

            //if (checkBox_MaxPeople.Checked) ListWhereSearch += " And (OH_MaxPeople >= " + nUpDown_MaxPeople1.Value.ToString() + ") And (OH_MaxPeople <= " + nUpDown_MaxPeople2.Value.ToString() + ")";

            //if (checkBox_HPart.Checked)
            //{
            //    ListWhereSearch += " And (1<>1 ";
            //    if (comboBox_HPart1.Text != "") ListWhereSearch += " Or Lord_Part = " + comboBox_HPart1.SelectedValue.ToString();
            //    if (comboBox_HPart2.Text != "") ListWhereSearch += " Or Lord_Part = " + comboBox_HPart2.SelectedValue.ToString();
            //    if (comboBox_HPart3.Text != "") ListWhereSearch += " Or Lord_Part = " + comboBox_HPart3.SelectedValue.ToString();
            //    if (comboBox_HPart4.Text != "") ListWhereSearch += " Or Lord_Part = " + comboBox_HPart4.SelectedValue.ToString();
            //    ListWhereSearch += " ) ";
            //}



            try
            {
                ListDocPat_UC Uc = new ListDocPat_UC();
                //Uc._searchOrNo = true;
                Uc._listWhereSearch = ListWhereSearch;

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


        #region  Select Part
        private int CntID, StID, CyID;
        private void comboBox_Country_Enter(object sender, EventArgs e)
        {
            if (comboBox_HCountry.DataSource == null)
            {
                var hh = from prd in DCDC.TBL_PrtCountries
                         select prd;
                comboBox_HCountry.DataSource = hh;
            }
        }

        private void comboBox_Country_Leave(object sender, EventArgs e)
        {
            CntID = Convert.ToInt32(comboBox_HCountry.SelectedValue);
        }

        private void comboBox_State_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HState.Tag.Equals(CntID))
            {
                comboBox_HState.Tag = CntID;
                var hh = from prd in DCDC.TBL_PrtStates
                         where prd.CountryID == CntID
                         select prd;
                comboBox_HState.DataSource = hh;
            }
        }

        private void comboBox_State_Leave(object sender, EventArgs e)
        {
            StID = Convert.ToInt32(comboBox_HState.SelectedValue);
        }

        private void comboBox_City_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HCity.Tag.Equals(StID))
            {
                comboBox_HCity.Tag = StID;
                var hh = from prd in DCDC.TBL_PrtCities
                         where prd.StateID == StID
                         select prd;
                comboBox_HCity.DataSource = hh;
            }
        }

        private void comboBox_City_Leave(object sender, EventArgs e)
        {
            CyID = Convert.ToInt32(comboBox_HCity.SelectedValue);
        }

        private void comboBox_Part1_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart1.Tag.Equals(CyID))
            {
                comboBox_HPart1.Tag = CyID;
                var h1 = from prd in DCDC.TBL_PrtParts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart1.DataSource = h1;
            }
        }

        private void comboBox_Part2_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart2.Tag.Equals(CyID))
            {
                comboBox_HPart2.Tag = CyID;
                var h2 = from prd in DCDC.TBL_PrtParts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart2.DataSource = h2;
            }
        }

        private void comboBox_Part3_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart3.Tag.Equals(CyID))
            {
                comboBox_HPart3.Tag = CyID;
                var h3 = from prd in DCDC.TBL_PrtParts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart3.DataSource = h3;
            }
        }

        private void comboBox_Part4_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart4.Tag.Equals(CyID))
            {
                comboBox_HPart4.Tag = CyID;
                var h4 = from prd in DCDC.TBL_PrtParts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart4.DataSource = h4;
            }
        }
        #endregion

    }
}
