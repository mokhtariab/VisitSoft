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
    public partial class StateBedsore_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultStateBedsore = "";

        short _stateBedsoreID = 0;
        int _patientID = 0, _visitCode = 0;

        public StateBedsore_UC(int PatientID, int VisitCode, short StateBedsoreID)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;
            _stateBedsoreID = StateBedsoreID;


            SetComboList();
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            DataLinq.TBL_VisitStateBedsore vsb = DCMD.TBL_VisitStateBedsores.First(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.StateBedsoreId == StateBedsoreID);
            comboBoxBedsorePosition.Text = vsb.BedsorePosition;
            comboBoxBedsoreMeasurement.Text = vsb.BedsoreMeasurement;
            comboBoxBedsoreDeep.Text = vsb.BedsoreDeep;
            comboBoxBedsoreStartTime.Text = vsb.BedsoreStartTime;
            comboBoxBedsoreGrade.Text = vsb.BedsoreGrade;
            comboBoxBedsoreRemain.Text = vsb.BedsoreRemain;
        }

        public StateBedsore_UC(int PatientID, int VisitCode, ref short StateBedsoreID)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;

            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            try
            {
                _stateBedsoreID = (short)((from fg in DCMD.TBL_VisitStateBedsores where fg.PatientID == _patientID && fg.VisitCode == _visitCode select fg.StateBedsoreId).Max() + 1);
            }
            catch (Exception)
            {
                _stateBedsoreID = 1;
            }

            DataLinq.TBL_VisitStateBedsore kk = new DataLinq.TBL_VisitStateBedsore
            {
                PatientID = _patientID,
                VisitCode = _visitCode,
                StateBedsoreId = _stateBedsoreID
            };
            DCMD.TBL_VisitStateBedsores.InsertOnSubmit(kk);
            DCMD.SubmitChanges();

            StateBedsoreID = _stateBedsoreID;

            SetComboList();
        }

        public void save(int PatientID, int VisitCode, short StateBedsoreID)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (comboBoxBedsorePosition.Text == "")
            {
                SaveResult = false;
                MessageResultStateBedsore = "محل زخم را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                DCMD.SP_SaveVisitStateBedsore(PatientID, VisitCode, StateBedsoreID,
                            comboBoxBedsorePosition.Text, comboBoxBedsoreMeasurement.Text, comboBoxBedsoreDeep.Text,
                            comboBoxBedsoreStartTime.Text, comboBoxBedsoreGrade.Text, comboBoxBedsoreRemain.Text);
            }
            catch (Exception ex)
            {
                Global_Cls.Message_MehrGostar(ex.Message, Global_Cls.MessageType.SError);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید این مورد زخم بستر حذف شود؟"))
            {
                DCMD.SP_DeleteVisitStateBedsore(_patientID, _visitCode, _stateBedsoreID);
                this.Visible = false;
            }
        }

        private void SetComboList()
        {
            DataLinq.DataClasses_MainDataContext DCMD = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            var SUS = (from prd in DCMD.TBL_VisitStateBedsores
                       select new { prd.BedsorePosition }).Distinct();
            comboBoxBedsorePosition.DisplayMember = "BedsorePosition";
            comboBoxBedsorePosition.ValueMember = "BedsorePosition";
            comboBoxBedsorePosition.DataSource = SUS;


            var SUS1 = (from prd in DCMD.TBL_VisitStateBedsores
                        select new { prd.BedsoreMeasurement }).Distinct();
            comboBoxBedsoreMeasurement.DisplayMember = "BedsoreMeasurement";
            comboBoxBedsoreMeasurement.ValueMember = "BedsoreMeasurement";
            comboBoxBedsoreMeasurement.DataSource = SUS1;


            var SUS2 = (from prd in DCMD.TBL_VisitStateBedsores
                        select new { prd.BedsoreDeep }).Distinct();
            comboBoxBedsoreDeep.DisplayMember = "BedsoreDeep";
            comboBoxBedsoreDeep.ValueMember = "BedsoreDeep";
            comboBoxBedsoreDeep.DataSource = SUS2;


            var SUS3 = (from prd in DCMD.TBL_VisitStateBedsores
                        select new { prd.BedsoreStartTime }).Distinct();
            comboBoxBedsoreStartTime.DisplayMember = "BedsoreStartTime";
            comboBoxBedsoreStartTime.ValueMember = "BedsoreStartTime";
            comboBoxBedsoreStartTime.DataSource = SUS3;


            var SUS4 = (from prd in DCMD.TBL_VisitStateBedsores
                        select new { prd.BedsoreGrade }).Distinct();
            comboBoxBedsoreGrade.DisplayMember = "BedsoreGrade";
            comboBoxBedsoreGrade.ValueMember = "BedsoreGrade";
            comboBoxBedsoreGrade.DataSource = SUS4;


            var SUS5 = (from prd in DCMD.TBL_VisitStateBedsores
                        select new { prd.BedsoreRemain }).Distinct();
            comboBoxBedsoreRemain.DisplayMember = "BedsoreRemain";
            comboBoxBedsoreRemain.ValueMember = "BedsoreRemain";
            comboBoxBedsoreRemain.DataSource = SUS5;

        }
    }
}
