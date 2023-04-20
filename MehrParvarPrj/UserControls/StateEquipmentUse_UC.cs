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
    public partial class StateEquipmentUse_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultStateEquipmentUse = "";

        short _stateEquipmentUseId = 0;
        int _patientID = 0, _visitCode = 0;

        bool _delSet = false;

        public StateEquipmentUse_UC(int PatientID, int VisitCode, short StateEquipmentUseId)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;
            _stateEquipmentUseId = StateEquipmentUseId;


            DataLinq.DataClassesSecondDataContext DCMD = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);

            DataLinq.TBL_VisitStateEquipmentUse vsb = DCMD.TBL_VisitStateEquipmentUses.First(fg => fg.PatientID == PatientID && fg.VisitCode == VisitCode && fg.EquipmentUseId == StateEquipmentUseId);
            try
            {
                textBoxEquipmentUse.Text = DCMD.TBL_EquipmentUses.First(dd => dd.Id == vsb.EquipmentUseId).TitleName;
                textBoxEquipmentUse.Tag = vsb.EquipmentUseId;
            }
            catch { }
            nUpDownFew.Value = vsb.Few;
        }

        //public StateEquipmentUse_UC(int PatientID, int VisitCode, ref short StateEquipmentUseID)
        //{
        //    InitializeComponent();

        //    _patientID = PatientID;
        //    _visitCode = VisitCode;

        //    DataLinq.DataClassesSecondDataContext DCMD = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        //    try
        //    {
        //        _stateEquipmentUseId = (short)((from fg in DCMD.TBL_VisitStateEquipmentUses where fg.PatientID == _patientID && fg.VisitCode == _visitCode select fg.EquipmentUseId).Max() + 1);
        //    }
        //    catch (Exception)
        //    {
        //        _stateEquipmentUseId = 1;
        //    }

        //    DataLinq.TBL_VisitStateEquipmentUse kk = new DataLinq.TBL_VisitStateEquipmentUse
        //    {
        //        PatientID = _patientID,
        //        VisitCode = _visitCode,
        //        EquipmentUseId = _stateEquipmentUseId,
        //    };
        //    DCMD.TBL_VisitStateEquipmentUses.InsertOnSubmit(kk);
        //    DCMD.SubmitChanges();

        //    StateEquipmentUseID = _stateEquipmentUseId;
            
        //}

        public StateEquipmentUse_UC(int PatientID, int VisitCode)
        {
            InitializeComponent();

            _patientID = PatientID;
            _visitCode = VisitCode;

            _stateEquipmentUseId = 1;
            _delSet = true;

        }

        public void save(int PatientID, int VisitCode, short StateEquipmentUseID, bool StatusEquipment)
        {
            DataLinq.DataClassesSecondDataContext DCMD = new DataLinq.DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            if (textBoxEquipmentUse.Text == "" && StatusEquipment)
            {
                SaveResult = false;
                MessageResultStateEquipmentUse = "نام تجهیز را وارد نمایید";
                return;
            }
            if (nUpDownFew.Value == 0 && StatusEquipment)
            {
                SaveResult = false;
                MessageResultStateEquipmentUse = "تعداد تجهیز را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                DCMD.SP_SaveVisitStateEquipmentUse(PatientID, VisitCode, StateEquipmentUseID, StatusEquipment, Convert.ToInt32(nUpDownFew.Value));
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
                //DCMD.SP_DeleteVisitStateEquipmentUse(_patientID, _visitCode, _stateEquipmentUseId);
                this.Visible = false;
                if (_delSet) this.Tag = -1;
            }
        }


        private void buttonEquipmentUseId_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(8);
            sp.ShowDialog();
            if (sp.CodeC != 0 || sp.NameC != "")
            {
                textBoxEquipmentUse.Tag = sp.CodeC;
                textBoxEquipmentUse.Text = sp.NameC;
                this.Tag = sp.CodeC;
            }
        }
    }
}
