using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MehrParvarPrj.UserControls
{
    public partial class OldParaclinic_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultParaclinic = "";


        public OldParaclinic_UC(int PatientID, int VisitCode, short ParaclinicID)
        {
            InitializeComponent();
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            chkParaclinics.Text = DCMD.TBL_Paraclinics.First(fg => fg.ParaclinicId == ParaclinicID).ParaclinicName;
            chkParaclinics.Checked = DCMD.TBL_VisitStateParaclinics.Count(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.ParaclinicsId == ParaclinicID) == 0 ? false : true;
            if (chkParaclinics.Checked)
            {
                comboBoxParaclinicsState.Text = DCMD.TBL_VisitStateParaclinics.First(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.ParaclinicsId == ParaclinicID).ParaclinicsState;
                textBoxVisitStateParaclinicDsc.Text = DCMD.TBL_VisitStateParaclinics.First(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.ParaclinicsId == ParaclinicID).VisitStateParaclinicDsc;
            }
        }

        public void save(int PatientID, int VisitCode, short ParaclinicID)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (chkParaclinics.Checked && textBoxVisitStateParaclinicDsc.Text == "")
            {
                SaveResult = false;
                MessageResultParaclinic = "توضیحات پاراکلینیک " + chkParaclinics.Text + " را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                //DCMD.SP_SaveVisitStateParaclinic(PatientID, VisitCode, ParaclinicID, chkParaclinics.Checked, comboBoxParaclinicsState.Text, textBoxVisitStateParaclinicDsc.Text);
            }
            catch (Exception ex)
            {
                Global_Cls.Message_MehrGostar(ex.Message, Global_Cls.MessageType.SError);
            }

        }

        private void chkStateSichness_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVisitStateParaclinicDsc.Visible = chkParaclinics.Checked;
            comboBoxParaclinicsState.Visible = chkParaclinics.Checked;
        }
    }
}
