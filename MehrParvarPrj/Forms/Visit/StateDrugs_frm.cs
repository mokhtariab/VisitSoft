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
    public partial class StateDrugs_frm : Form
    {
        int _patientID = 0, _visitCode = 0;
        string _status;
        int PreNextVisitCode = 0;

        public StateDrugs_frm(int PatientID, int VisitCode, string Status)
        {
            InitializeComponent();
            _patientID = PatientID;
            _visitCode = VisitCode;
            _status = Status;
            PreNextVisitCode = _visitCode;
        }


        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void StateDrugs_frm_Load(object sender, EventArgs e)
        {
            buttonCuVisit_Click(this, null);
        }

        int i = 0;
        private void FillComponents(int VisitCodeSet)
        {
            try
            {
                i = 0;
                tableLayoutPanelVisit.Controls.Clear();

                foreach (short fg in (from g in DCMD.TBL_VisitStateDrugs where g.PatientID == _patientID && g.VisitCode == VisitCodeSet select g.StateDrugsId))
                {
                    UserControls.StateDrugs_UC SSUC = new UserControls.StateDrugs_UC(_patientID, VisitCodeSet, fg);
                    SSUC.Tag = fg;
                    SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tableLayoutPanelVisit.Controls.Add(SSUC, 1, i++);
                }
            }
            catch (Exception ex)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اشکال وجود دارد!", ex.Message);
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید تغییرات در ویزیت مورخ " + textBoxVisitDate.Text + " اعمال شود؟"))
            {
                foreach (Control fg in tableLayoutPanelVisit.Controls)
                {
                    (fg as UserControls.StateDrugs_UC).save(_patientID, PreNextVisitCode, short.Parse(fg.Tag.ToString()));
                    if (!(fg as UserControls.StateDrugs_UC).SaveResult)
                    {
                        Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, (fg as UserControls.StateDrugs_UC).MessageResultStateDrugs);
                        return;
                    }
                }
                DCMD.SP_SetStateDrugsIdInVisitStateDrugs(_patientID, PreNextVisitCode);

                Close();
            }
        }


        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void buttonCuVisit_Click(object sender, EventArgs e)
        {
            textBoxVisitDate.Text = Global_Cls.MiladiDateToShamsi(DCMD.TBL_PatientVisits.First(hh => hh.PatientID == _patientID && hh.VisitCode == _visitCode).VisitDate.Value);
            textBoxVisitCode.Text = _visitCode.ToString();
            PreNextVisitCode = _visitCode;
            FillComponents(_visitCode);
        }


        private void buttonPreVisit_Click(object sender, EventArgs e)
        {
            if (PreNextVisitCode - 1 > 0)
            {
                try
                {
                    --PreNextVisitCode;
                    textBoxVisitDate.Text = Global_Cls.MiladiDateToShamsi(DCMD.TBL_PatientVisits.First(hh => hh.PatientID == _patientID && hh.VisitCode == PreNextVisitCode).VisitDate.Value);
                    textBoxVisitCode.Text = PreNextVisitCode.ToString();

                    FillComponents(PreNextVisitCode);
                }
                catch 
                { 
                    buttonPreVisit_Click(this, null);
                }
            }
        }

        private void buttonNextVisit_Click(object sender, EventArgs e)
        {
            int MaxVisit = (from fg in DCMD.TBL_PatientVisits where fg.PatientID == _patientID select fg.VisitCode).Max();
            if (PreNextVisitCode + 1 <= MaxVisit)
            {
                try
                {
                    ++PreNextVisitCode;
                    textBoxVisitDate.Text = Global_Cls.MiladiDateToShamsi(DCMD.TBL_PatientVisits.First(hh => hh.PatientID == _patientID && hh.VisitCode == PreNextVisitCode).VisitDate.Value);
                    textBoxVisitCode.Text = PreNextVisitCode.ToString();

                    FillComponents(PreNextVisitCode);
                }
                catch
                {
                    buttonNextVisit_Click(this, null);
                }
            }
        }

        private void buttonAddDrugs_Click(object sender, EventArgs e)
        {
            short fg = 0;
            UserControls.StateDrugs_UC SSUC = new UserControls.StateDrugs_UC(_patientID, PreNextVisitCode, ref fg);
            SSUC.Tag = fg;
            SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            tableLayoutPanelVisit.Controls.Add(SSUC, 1, i++);
        }

        private void StateDrugs_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            TBL_PatientVisit g = DCMD.TBL_PatientVisits.First(h => h.PatientID == _patientID && h.VisitCode == _visitCode);
            g.DrugsHistoryDsc = DCMD.VisitStateDrugsStr(_patientID, _visitCode);
            DCMD.SubmitChanges();
        }

       
        
       
        

       
    }
}
