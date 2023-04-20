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
    public partial class Paraclinic_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultParaclinic = "";

        short _ParaclinicId = 0;
        int _patientID = 0, _visitCode = 0;

        public Paraclinic_UC(int PatientID, int VisitCode, short ParaclinicId)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;
            _ParaclinicId = ParaclinicId;


            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            DataLinq.TBL_VisitStateParaclinic vsb = DCMD.TBL_VisitStateParaclinics.First(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.ParaclinicsId == ParaclinicId);
            try
            {
                textBoxParaclinicsId.Text = DCMD.TBL_Paraclinics.First(dd => dd.ParaclinicId == vsb.ParaclinicsId).ParaclinicName;
                textBoxParaclinicsId.Tag = vsb.ParaclinicsId;
            }
            catch { }
            comboBoxParaclinicsState.Text = vsb.ParaclinicsState;
            textBoxVisitStateParaclinicDsc.Text = vsb.VisitStateParaclinicDsc;
        }

        public Paraclinic_UC(int PatientID, int VisitCode, ref short ParaclinicID)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;

            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            try
            {
                _ParaclinicId = (short)((from fg in DCMD.TBL_VisitStateParaclinics where fg.PatientID == _patientID && fg.VisitCode == _visitCode select fg.ParaclinicsId).Max() + 1);
            }
            catch (Exception)
            {
                _ParaclinicId = 1;
            }

            DataLinq.TBL_VisitStateParaclinic kk = new DataLinq.TBL_VisitStateParaclinic
            {
                PatientID = _patientID,
                VisitCode = _visitCode,
                ParaclinicsId = _ParaclinicId,
            };
            DCMD.TBL_VisitStateParaclinics.InsertOnSubmit(kk);
            DCMD.SubmitChanges();

            ParaclinicID = _ParaclinicId;
            
        }

        public void save(int PatientID, int VisitCode, short ParaclinicID)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (textBoxParaclinicsId.Text == "")
            {
                SaveResult = false;
                MessageResultParaclinic = "عنوان پاراکلینیک را وارد نمایید";
                return;
            }
            if (textBoxVisitStateParaclinicDsc.Text == "")
            {
                SaveResult = false;
                MessageResultParaclinic = "توضیحات پاراکلینیک را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                DCMD.SP_SaveVisitStateParaclinic(PatientID, VisitCode, ParaclinicID, comboBoxParaclinicsState.Text, textBoxVisitStateParaclinicDsc.Text);
            }
            catch (Exception ex) 
            {
                Global_Cls.Message_MehrGostar(ex.Message, Global_Cls.MessageType.SError);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید این پاراکلینیک حذف شود؟"))
            {
                DCMD.SP_DeleteVisitStateParaclinics(_patientID, _visitCode, _ParaclinicId);
                this.Visible = false;
            }
        }

        private void buttonParaclinicsId_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(6);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                textBoxParaclinicsId.Tag = sp.CodeC;
                textBoxParaclinicsId.Text = sp.NameC;
            }
        }
    }
}
