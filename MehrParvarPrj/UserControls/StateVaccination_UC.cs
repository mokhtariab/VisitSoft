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
    public partial class StateVaccination_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultStateVaccination = "";

        short _stateVaccinationId = 0;
        int _patientID = 0, _visitCode = 0;
        bool _delSet = false;

        public StateVaccination_UC(int PatientID, int VisitCode, short StateVaccinationId)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;
            _stateVaccinationId = StateVaccinationId;



            DataLinq.DataClassesSecondDataContext DCMD = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);

            DataLinq.TBL_VisitStateVaccination vsb = DCMD.TBL_VisitStateVaccinations.First(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.VaccinationId == StateVaccinationId);
            try
            {
                textBoxVaccination.Text = DCMD.TBL_Vaccinations.First(dd => dd.Id == vsb.VaccinationId).TitleName;
                textBoxVaccination.Tag = vsb.VaccinationId;
            }
            catch { }
            nUpDownFew.Value = vsb.Few;
        }

        //public StateVaccination_UC(int PatientID, int VisitCode, ref short StateVaccinationID)
        //{
        //    InitializeComponent();

        //    _patientID = PatientID;
        //    _visitCode = VisitCode;

        //    DataLinq.DataClassesSecondDataContext DCMD = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        //    try
        //    {
        //        _stateVaccinationId = (short)((from fg in DCMD.TBL_VisitStateVaccinations where fg.PatientID == _patientID && fg.VisitCode == _visitCode select fg.VaccinationId).Max() + 1);
        //    }
        //    catch (Exception)
        //    {
        //        _stateVaccinationId = 1;
        //    }

        //    DataLinq.TBL_VisitStateVaccination kk = new DataLinq.TBL_VisitStateVaccination
        //    {
        //        PatientID = _patientID,
        //        VisitCode = _visitCode,
        //        VaccinationId = _stateVaccinationId,
        //    };
        //    DCMD.TBL_VisitStateVaccinations.InsertOnSubmit(kk);
        //    DCMD.SubmitChanges();

        //    StateVaccinationID = _stateVaccinationId;
            
        //}


        public StateVaccination_UC(int PatientID, int VisitCode)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;
            _stateVaccinationId = 1;

            _delSet = true;
        }


        public void save(int PatientID, int VisitCode, short StateVaccinationID, bool StatusVaccination)
        {
            DataLinq.DataClassesSecondDataContext DCMD = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            if (textBoxVaccination.Text == "" && StatusVaccination)
            {
                SaveResult = false;
                MessageResultStateVaccination = "نام واکسن را وارد نمایید";
                return;
            }
            if (nUpDownFew.Value == 0 && StatusVaccination)
            {
                SaveResult = false;
                MessageResultStateVaccination = "تعداد واکسن را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                DCMD.SP_SaveVisitStateVaccination(PatientID, VisitCode, StateVaccinationID, StatusVaccination, int.Parse(nUpDownFew.Value.ToString()));
            }
            catch (Exception ex) 
            {
                Global_Cls.Message_MehrGostar(ex.Message, Global_Cls.MessageType.SError);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataLinq.DataClassesSecondDataContext DCMD = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید این واکسن حذف شود؟"))
            {
                //DCMD.SP_DeleteVisitStateVaccination(_patientID, _visitCode, _stateVaccinationId);
                this.Visible = false;
                if (_delSet) this.Tag = -1;
            }
        }


        private void buttonVaccinationId_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(7);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxVaccination.Tag = sp.CodeC;
                textBoxVaccination.Text = sp.NameC;
                this.Tag = sp.CodeC;
            }
        }
    }
}
