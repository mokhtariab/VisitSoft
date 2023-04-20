using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MehrParvarPrj
{
    public partial class MessageMehrParvar_Frm : Form
    {
        public MessageMehrParvar_Frm()
        {
            InitializeComponent();
        }

        private void MessageMehrParvar_Frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }

        private void button_Details_Click(object sender, EventArgs e)
        {
            if (Height == 230) Height = 130;
            else Height = 230;
        }



    }
}
