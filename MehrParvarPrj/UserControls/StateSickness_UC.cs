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
    public partial class StateSickness_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultStateSickness = "";

        short _StateSicknessId = 0;
        int _patientID = 0, _visitCode = 0;
        bool _delSet = false;


        public StateSickness_UC(int PatientID, int VisitCode, short StateSicknessID)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;
            _StateSicknessId = StateSicknessID;
            
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            DataLinq.TBL_VisitStateSickness vsb = DCMD.TBL_VisitStateSicknesses.First(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.StateSicknessId == StateSicknessID);
            try
            {
                textBoxSickness.Text = DCMD.VW_StateSicknesses.First(dd => dd.StateSicknessId == vsb.StateSicknessId).StateSicknessMasterName + "-" + DCMD.VW_StateSicknesses.First(dd => dd.StateSicknessId == vsb.StateSicknessId).StateSicknessName;
                textBoxSickness.Tag = vsb.StateSicknessId;
            }
            catch { }
            textBoxStateSicknessDsc.Text = vsb.StateSicknessDsc;

        }

        //public StateSickness_UC(int PatientID, int VisitCode, ref short StateSicknessID)
        //{
        //    InitializeComponent();

        //    _patientID = PatientID;
        //    _visitCode = VisitCode;

        //    DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        //    try
        //    {
        //        _StateSicknessId = (short)((from fg in DCMD.TBL_VisitStateSicknesses where fg.PatientID == _patientID && fg.VisitCode == _visitCode select fg.StateSicknessId).Max() + 1);
        //    }
        //    catch (Exception)
        //    {
        //        _StateSicknessId = 1;
        //    }

        //    DataLinq.TBL_VisitStateSickness kk = new DataLinq.TBL_VisitStateSickness
        //    {
        //        PatientID = _patientID,
        //        VisitCode = _visitCode,
        //        StateSicknessId = _StateSicknessId,
        //    };
        //    DCMD.TBL_VisitStateSicknesses.InsertOnSubmit(kk);
        //    DCMD.SubmitChanges();

        //    StateSicknessID = _StateSicknessId;
            
        //}

        public StateSickness_UC(int PatientID, int VisitCode)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;
            _StateSicknessId = 1;

            _delSet = true;
        }

        
        public void save(int PatientID, int VisitCode, short StateSicknessID, bool StatusSickness)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (textBoxSickness.Text == "" && StatusSickness)
            {
                SaveResult = false;
                MessageResultStateSickness = "نام بیماری را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                DCMD.SP_SaveVisitStateSickness(PatientID, VisitCode, StateSicknessID, StatusSickness,
                    textBoxStateSicknessDsc.Text);
            }
            catch (Exception ex)
            {
                Global_Cls.Message_MehrGostar(ex.Message, Global_Cls.MessageType.SError);
            }

        }

        private void buttonSickness_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(4);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxSickness.Tag = sp.CodeC;
                textBoxSickness.Text = sp.NameC;
                this.Tag = sp.CodeC;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید این بیماری حذف شود؟"))
            {
                //DCMD.SP_DeleteVisitStateSickness(_patientID, _visitCode, _StateSicknessId);
                this.Visible = false;
                if (_delSet) this.Tag = -1;
            }

        }
    }
}
