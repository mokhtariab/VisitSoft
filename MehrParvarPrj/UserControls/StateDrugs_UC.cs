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
    public partial class StateDrugs_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultStateDrugs = "";

        short _stateDrugsId = 0;
        int _patientID = 0, _visitCode = 0;

        public StateDrugs_UC(int PatientID, int VisitCode, short StateDrugsId)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;
            _stateDrugsId = StateDrugsId;


            SetComboList();

            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            DataLinq.TBL_VisitStateDrug vsb = DCMD.TBL_VisitStateDrugs.First(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.StateDrugsId == StateDrugsId);
            try
            {
                textBoxDrugsId.Text = DCMD.TBL_Drugs.First(dd => dd.DrugsId == vsb.DrugsId).DrugsName;
                textBoxDrugsId.Tag = vsb.DrugsId;
            }
            catch { }
            comboBoxUseAmount.Text = vsb.UseAmount;
            chkNeedBack.Checked = vsb.NeedBack.Value;
            comboBoxNeedBackDsc.Text = vsb.NeedBackDsc;
        }

        public StateDrugs_UC(int PatientID, int VisitCode, ref short StateDrugsID)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;

            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            try
            {
                _stateDrugsId = (short)((from fg in DCMD.TBL_VisitStateDrugs where fg.PatientID == _patientID && fg.VisitCode == _visitCode select fg.StateDrugsId).Max() + 1);
            }
            catch (Exception)
            {
                _stateDrugsId = 1;
            }

            DataLinq.TBL_VisitStateDrug kk = new DataLinq.TBL_VisitStateDrug
            {
                PatientID = _patientID,
                VisitCode = _visitCode,
                StateDrugsId = _stateDrugsId,
                NeedBack = false
            };
            DCMD.TBL_VisitStateDrugs.InsertOnSubmit(kk);
            DCMD.SubmitChanges();

            StateDrugsID = _stateDrugsId;
            
            SetComboList();
        }

        public void save(int PatientID, int VisitCode, short StateDrugsID)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (textBoxDrugsId.Text == "")
            {
                SaveResult = false;
                MessageResultStateDrugs = "نام داروی مصرفی را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                if (!chkNeedBack.Checked) comboBoxNeedBackDsc.Text = "";
                DCMD.SP_SaveVisitStateDrugs(PatientID, VisitCode, StateDrugsID, int.Parse(textBoxDrugsId.Tag.ToString()), 
                    comboBoxUseAmount.Text, chkNeedBack.Checked, comboBoxNeedBackDsc.Text);
            }
            catch (Exception ex) 
            {
                Global_Cls.Message_MehrGostar(ex.Message, Global_Cls.MessageType.SError);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید این دارو حذف شود؟"))
            {
                DCMD.SP_DeleteVisitStateDrugs(_patientID, _visitCode, _stateDrugsId);
                this.Visible = false;
            }
        }

        private void SetComboList()
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            var SUS = (from prd in DCMD.TBL_VisitStateDrugs
                       select new { prd.UseAmount }).Distinct();
            comboBoxUseAmount.DisplayMember = "UseAmount";
            comboBoxUseAmount.ValueMember = "UseAmount";
            comboBoxUseAmount.DataSource = SUS;


            var SUS1 = (from prd in DCMD.TBL_VisitStateDrugs
                        select new { prd.NeedBackDsc }).Distinct();
            comboBoxNeedBackDsc.DisplayMember = "NeedBackDsc";
            comboBoxNeedBackDsc.ValueMember = "NeedBackDsc";
            comboBoxNeedBackDsc.DataSource = SUS1;
        }

        private void chkNeedBack_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxNeedBackDsc.Visible = chkNeedBack.Checked;
        }

        private void buttonDrugsIdsId_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(2);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxDrugsId.Tag = sp.CodeC;
                textBoxDrugsId.Text = sp.NameC;
            }
        }
    }
}
