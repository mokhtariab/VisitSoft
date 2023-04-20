using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MehrParvarPrj.DataLinq;

namespace MehrParvarPrj
{
    public partial class Key_frm: Form
    {
        public Key_frm()
        {
            InitializeComponent();
        }

        private void Key_frm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        public void DataBind()
        {
            var SU = from prd in DCDC.TBL_Keys
                     select new
                     {
                         prd.KeyCode,
                         prd.KeyDsc
                     };
            dataGridView_SelectPerson.DataSource = SU;
        }


        public int KeyCodeSet = 0;
        public string KeyDscSet = "";

        private void dataGridView_SelectPerson_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                KeyCodeSet = int.Parse(dataGridView_SelectPerson.CurrentRow.Cells["KeyCode"].Value.ToString());
                KeyDscSet = dataGridView_SelectPerson.CurrentRow.Cells["KeyDsc"].Value.ToString();
                Close();
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TBL_Key Ky = new TBL_Key();
            Ky.KeyDsc = textBoxKey.Text;
            DCDC.TBL_Keys.InsertOnSubmit(Ky);
            DCDC.SubmitChanges();

            DataBind();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            TBL_Key Ky = DCDC.TBL_Keys.First(j => j.KeyCode == int.Parse(dataGridView_SelectPerson.CurrentRow.Cells["KeyCode"].Value.ToString()));
            DCDC.TBL_Keys.DeleteOnSubmit(Ky);
            DCDC.SubmitChanges();

            DataBind();
        }

    }
}
