namespace MehrParvarPrj
{
    partial class DoctorList_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorList_UC));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.ContractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkNonActive = new System.Windows.Forms.RadioButton();
            this.chkAllDoctor = new System.Windows.Forms.RadioButton();
            this.textboxitem_status = new DevComponents.DotNetBar.TextBoxItem();
            this.buttonItem_StatusOK = new DevComponents.DotNetBar.ButtonItem();
            this.itemPanelCar = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItem_DoctorNew = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorEdit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorDel = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorSMSEmail = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorSMS = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorEmail = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorPrintList = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemExcelExportDoctorList = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorListContract = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemFileDoctors = new DevComponents.DotNetBar.ButtonItem();
            this.gridControl_DoctorList = new DevExpress.XtraGrid.GridControl();
            this.gridView_DoctorList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MedicalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorFamily = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NationalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ParentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorTypeDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractTypeDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrithDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrithCityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelHome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelBusiness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddressBusiness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationPart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CardBankNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CardBankNo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.exPanelFilter = new DevComponents.DotNetBar.ExpandablePanel();
            this.panel_Selector = new System.Windows.Forms.Panel();
            this.chkContract = new System.Windows.Forms.RadioButton();
            this.chkNonContract = new System.Windows.Forms.RadioButton();
            this.chkActive = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DoctorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoctorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.exPanelFilter.SuspendLayout();
            this.panel_Selector.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ContractNo
            // 
            this.ContractNo.Caption = "شماره قرارداد";
            this.ContractNo.FieldName = "ContractNo";
            this.ContractNo.Name = "ContractNo";
            this.ContractNo.Visible = true;
            this.ContractNo.VisibleIndex = 3;
            this.ContractNo.Width = 36;
            // 
            // Active
            // 
            this.Active.Caption = "فعال";
            this.Active.FieldName = "Active";
            this.Active.Name = "Active";
            // 
            // DoctorType
            // 
            this.DoctorType.Caption = "کد نوع پزشک";
            this.DoctorType.FieldName = "DoctorType";
            this.DoctorType.Name = "DoctorType";
            // 
            // chkNonActive
            // 
            this.chkNonActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkNonActive.AutoSize = true;
            this.chkNonActive.BackColor = System.Drawing.Color.Silver;
            this.chkNonActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkNonActive.Location = new System.Drawing.Point(484, 7);
            this.chkNonActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNonActive.Name = "chkNonActive";
            this.chkNonActive.Size = new System.Drawing.Size(66, 17);
            this.chkNonActive.TabIndex = 8;
            this.chkNonActive.Text = "غیرفعال";
            this.chkNonActive.UseVisualStyleBackColor = false;
            this.chkNonActive.CheckedChanged += new System.EventHandler(this.chkAllDoctor_CheckedChanged);
            // 
            // chkAllDoctor
            // 
            this.chkAllDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkAllDoctor.AutoSize = true;
            this.chkAllDoctor.BackColor = System.Drawing.Color.Transparent;
            this.chkAllDoctor.Checked = true;
            this.chkAllDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkAllDoctor.Location = new System.Drawing.Point(641, 7);
            this.chkAllDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAllDoctor.Name = "chkAllDoctor";
            this.chkAllDoctor.Size = new System.Drawing.Size(85, 17);
            this.chkAllDoctor.TabIndex = 7;
            this.chkAllDoctor.TabStop = true;
            this.chkAllDoctor.Text = "کل پزشکان";
            this.chkAllDoctor.UseVisualStyleBackColor = false;
            this.chkAllDoctor.CheckedChanged += new System.EventHandler(this.chkAllDoctor_CheckedChanged);
            // 
            // textboxitem_status
            // 
            this.textboxitem_status.Name = "textboxitem_status";
            this.textboxitem_status.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // buttonItem_StatusOK
            // 
            this.buttonItem_StatusOK.ForeColor = System.Drawing.Color.Black;
            this.buttonItem_StatusOK.HotFontBold = true;
            this.buttonItem_StatusOK.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem_StatusOK.Icon")));
            this.buttonItem_StatusOK.Name = "buttonItem_StatusOK";
            this.buttonItem_StatusOK.Text = "تایید";
            // 
            // itemPanelCar
            // 
            // 
            // 
            // 
            this.itemPanelCar.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.itemPanelCar.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.itemPanelCar.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanelCar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelCar.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelCar.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelCar.BackgroundStyle.PaddingRight = 1;
            this.itemPanelCar.BackgroundStyle.PaddingTop = 1;
            this.itemPanelCar.ContainerControlProcessDialogKey = true;
            this.itemPanelCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelCar.FitButtonsToContainerWidth = true;
            this.itemPanelCar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelCar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelCar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_DoctorNew,
            this.buttonItemDoctorEdit,
            this.buttonItemDoctorDel,
            this.buttonItemDoctorSearch,
            this.buttonItemSelector,
            this.buttonItemDoctorSMSEmail,
            this.buttonItemDoctorPrintList,
            this.buttonItemExcelExportDoctorList,
            this.buttonItemRefresh,
            this.buttonItemDoctorListContract,
            this.buttonItemFileDoctors});
            this.itemPanelCar.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemPanelCar.Name = "itemPanelCar";
            this.itemPanelCar.Size = new System.Drawing.Size(848, 57);
            this.itemPanelCar.TabIndex = 40;
            this.itemPanelCar.ThemeAware = true;
            // 
            // buttonItem_DoctorNew
            // 
            this.buttonItem_DoctorNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_DoctorNew.ForeColor = System.Drawing.Color.Gold;
            this.buttonItem_DoctorNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_DoctorNew.Image")));
            this.buttonItem_DoctorNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_DoctorNew.Name = "buttonItem_DoctorNew";
            this.buttonItem_DoctorNew.Text = "ثبت پزشک";
            this.buttonItem_DoctorNew.ThemeAware = true;
            this.buttonItem_DoctorNew.Click += new System.EventHandler(this.buttonItem_DoctorNew_Click);
            // 
            // buttonItemDoctorEdit
            // 
            this.buttonItemDoctorEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorEdit.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDoctorEdit.Image")));
            this.buttonItemDoctorEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorEdit.Name = "buttonItemDoctorEdit";
            this.buttonItemDoctorEdit.Text = "ویرایش";
            this.buttonItemDoctorEdit.ThemeAware = true;
            this.buttonItemDoctorEdit.Click += new System.EventHandler(this.buttonItemDoctorEdit_Click);
            // 
            // buttonItemDoctorDel
            // 
            this.buttonItemDoctorDel.BeginGroup = true;
            this.buttonItemDoctorDel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorDel.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorDel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDoctorDel.Image")));
            this.buttonItemDoctorDel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorDel.Name = "buttonItemDoctorDel";
            this.buttonItemDoctorDel.Text = "حذف";
            this.buttonItemDoctorDel.ThemeAware = true;
            this.buttonItemDoctorDel.Click += new System.EventHandler(this.buttonItemDoctorDel_Click);
            // 
            // buttonItemDoctorSearch
            // 
            this.buttonItemDoctorSearch.AutoCheckOnClick = true;
            this.buttonItemDoctorSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDoctorSearch.Image")));
            this.buttonItemDoctorSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorSearch.Name = "buttonItemDoctorSearch";
            this.buttonItemDoctorSearch.Text = "جستجو";
            this.buttonItemDoctorSearch.ThemeAware = true;
            this.buttonItemDoctorSearch.Click += new System.EventHandler(this.buttonItemDoctorSearch_Click);
            // 
            // buttonItemSelector
            // 
            this.buttonItemSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSelector.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSelector.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSelector.Image")));
            this.buttonItemSelector.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSelector.Name = "buttonItemSelector";
            this.buttonItemSelector.Text = "انتخاب فیلدها";
            this.buttonItemSelector.ThemeAware = true;
            this.buttonItemSelector.Click += new System.EventHandler(this.buttonItemSelector_Click);
            // 
            // buttonItemDoctorSMSEmail
            // 
            this.buttonItemDoctorSMSEmail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorSMSEmail.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorSMSEmail.Image = global::MehrParvarPrj.Properties.Resources.konqsidebar_mediaplayer;
            this.buttonItemDoctorSMSEmail.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorSMSEmail.Name = "buttonItemDoctorSMSEmail";
            this.buttonItemDoctorSMSEmail.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemDoctorSMS,
            this.buttonItemDoctorEmail});
            this.buttonItemDoctorSMSEmail.Text = "SMS Email";
            this.buttonItemDoctorSMSEmail.ThemeAware = true;
            // 
            // buttonItemDoctorSMS
            // 
            this.buttonItemDoctorSMS.Image = global::MehrParvarPrj.Properties.Resources.sms_protocol;
            this.buttonItemDoctorSMS.Name = "buttonItemDoctorSMS";
            this.buttonItemDoctorSMS.Text = "SMS";
            this.buttonItemDoctorSMS.ThemeAware = true;
            this.buttonItemDoctorSMS.Click += new System.EventHandler(this.buttonItemSMS_Click);
            // 
            // buttonItemDoctorEmail
            // 
            this.buttonItemDoctorEmail.Image = global::MehrParvarPrj.Properties.Resources.web;
            this.buttonItemDoctorEmail.Name = "buttonItemDoctorEmail";
            this.buttonItemDoctorEmail.Text = "Email";
            this.buttonItemDoctorEmail.ThemeAware = true;
            this.buttonItemDoctorEmail.Click += new System.EventHandler(this.buttonItemDoctorEmail_Click);
            // 
            // buttonItemDoctorPrintList
            // 
            this.buttonItemDoctorPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorPrintList.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDoctorPrintList.Image")));
            this.buttonItemDoctorPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorPrintList.Name = "buttonItemDoctorPrintList";
            this.buttonItemDoctorPrintList.Text = "چاپ لیست";
            this.buttonItemDoctorPrintList.ThemeAware = true;
            this.buttonItemDoctorPrintList.Click += new System.EventHandler(this.buttonItemDoctorPrintList_Click);
            // 
            // buttonItemExcelExportDoctorList
            // 
            this.buttonItemExcelExportDoctorList.BeginGroup = true;
            this.buttonItemExcelExportDoctorList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemExcelExportDoctorList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemExcelExportDoctorList.Image = global::MehrParvarPrj.Properties.Resources.MiniExcel;
            this.buttonItemExcelExportDoctorList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemExcelExportDoctorList.Name = "buttonItemExcelExportDoctorList";
            this.buttonItemExcelExportDoctorList.Text = "ارسال به اکسل";
            this.buttonItemExcelExportDoctorList.ThemeAware = true;
            this.buttonItemExcelExportDoctorList.Click += new System.EventHandler(this.buttonItemExcelExportDoctorList_Click);
            // 
            // buttonItemRefresh
            // 
            this.buttonItemRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemRefresh.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemRefresh.Image = global::MehrParvarPrj.Properties.Resources.agt_reload;
            this.buttonItemRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemRefresh.Name = "buttonItemRefresh";
            this.buttonItemRefresh.Text = "بازخوانی اطلاعات";
            this.buttonItemRefresh.ThemeAware = true;
            this.buttonItemRefresh.Click += new System.EventHandler(this.buttonItemRefresh_Click);
            // 
            // buttonItemDoctorListContract
            // 
            this.buttonItemDoctorListContract.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorListContract.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorListContract.Image = global::MehrParvarPrj.Properties.Resources.kudesigner;
            this.buttonItemDoctorListContract.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorListContract.Name = "buttonItemDoctorListContract";
            this.buttonItemDoctorListContract.Text = "قراردادهای پزشکان";
            this.buttonItemDoctorListContract.ThemeAware = true;
            this.buttonItemDoctorListContract.Click += new System.EventHandler(this.buttonItemDoctorContract_Click);
            // 
            // buttonItemFileDoctors
            // 
            this.buttonItemFileDoctors.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemFileDoctors.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemFileDoctors.Image = global::MehrParvarPrj.Properties.Resources.package_editors;
            this.buttonItemFileDoctors.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemFileDoctors.Name = "buttonItemFileDoctors";
            this.buttonItemFileDoctors.Text = "ثبت فایل";
            this.buttonItemFileDoctors.ThemeAware = true;
            this.buttonItemFileDoctors.Click += new System.EventHandler(this.buttonItemFileDoctors_Click);
            // 
            // gridControl_DoctorList
            // 
            this.gridControl_DoctorList.AllowDrop = true;
            this.gridControl_DoctorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DoctorList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_DoctorList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_DoctorList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_DoctorList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_DoctorList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_DoctorList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_DoctorList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_DoctorList.Location = new System.Drawing.Point(173, 57);
            this.gridControl_DoctorList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_DoctorList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_DoctorList.MainView = this.gridView_DoctorList;
            this.gridControl_DoctorList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_DoctorList.Name = "gridControl_DoctorList";
            this.gridControl_DoctorList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl_DoctorList.Size = new System.Drawing.Size(675, 331);
            this.gridControl_DoctorList.TabIndex = 41;
            this.gridControl_DoctorList.UseEmbeddedNavigator = true;
            this.gridControl_DoctorList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DoctorList});
            this.gridControl_DoctorList.DoubleClick += new System.EventHandler(this.buttonItemDoctorEdit_Click);
            // 
            // gridView_DoctorList
            // 
            this.gridView_DoctorList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DoctorList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DoctorList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_DoctorList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DoctorList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_DoctorList.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_DoctorList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_DoctorList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_DoctorList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RowNumber,
            this.DoctorID,
            this.CreateDate,
            this.MedicalCode,
            this.DoctorName,
            this.DoctorFamily,
            this.NationalCode,
            this.ParentName,
            this.DoctorTypeDsc,
            this.ContractTypeDsc,
            this.IDNO,
            this.BrithDate,
            this.BrithCityName,
            this.Address,
            this.TelHome,
            this.TelBusiness,
            this.Mobile,
            this.Email,
            this.AddressBusiness,
            this.LocationPart,
            this.CardBankNo1,
            this.CardBankNo2,
            this.Active,
            this.DoctorType,
            this.BankName,
            this.ContractNo,
            this.ContractDate,
            this.ContractEndDate});
            this.gridView_DoctorList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.ContractNo;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "([ContractNo] Is Null )";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Silver;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.Active;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "False";
            this.gridView_DoctorList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView_DoctorList.GridControl = this.gridControl_DoctorList;
            this.gridView_DoctorList.Name = "gridView_DoctorList";
            this.gridView_DoctorList.OptionsBehavior.Editable = false;
            this.gridView_DoctorList.OptionsCustomization.AllowGroup = false;
            this.gridView_DoctorList.OptionsCustomization.AllowRowSizing = true;
            this.gridView_DoctorList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_DoctorList.OptionsLayout.Columns.StoreLayout = false;
            this.gridView_DoctorList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView_DoctorList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_DoctorList.OptionsView.ShowGroupPanel = false;
            this.gridView_DoctorList.OptionsView.ShowIndicator = false;
            this.gridView_DoctorList.RowHeight = 60;
            this.gridView_DoctorList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_DoctorList_FocusedRowChanged);
            this.gridView_DoctorList.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_DoctorList_CustomUnboundColumnData);
            // 
            // RowNumber
            // 
            this.RowNumber.Caption = "ردیف";
            this.RowNumber.FieldName = "RowNumber";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.RowNumber.Visible = true;
            this.RowNumber.VisibleIndex = 16;
            this.RowNumber.Width = 37;
            // 
            // DoctorID
            // 
            this.DoctorID.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.DoctorID.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.DoctorID.AppearanceCell.Options.UseBackColor = true;
            this.DoctorID.Caption = "کد سیستمی پزشک";
            this.DoctorID.FieldName = "DoctorID";
            this.DoctorID.Name = "DoctorID";
            // 
            // CreateDate
            // 
            this.CreateDate.Caption = "تاریخ ثبت";
            this.CreateDate.FieldName = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            // 
            // MedicalCode
            // 
            this.MedicalCode.Caption = "کد نظام پزشکی";
            this.MedicalCode.FieldName = "MedicalCode";
            this.MedicalCode.Name = "MedicalCode";
            this.MedicalCode.Visible = true;
            this.MedicalCode.VisibleIndex = 15;
            this.MedicalCode.Width = 61;
            // 
            // DoctorName
            // 
            this.DoctorName.Caption = "نام";
            this.DoctorName.FieldName = "DoctorName";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DoctorName.Visible = true;
            this.DoctorName.VisibleIndex = 14;
            this.DoctorName.Width = 39;
            // 
            // DoctorFamily
            // 
            this.DoctorFamily.Caption = "نام خانوادگی";
            this.DoctorFamily.FieldName = "DoctorFamily";
            this.DoctorFamily.Name = "DoctorFamily";
            this.DoctorFamily.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DoctorFamily.Visible = true;
            this.DoctorFamily.VisibleIndex = 13;
            this.DoctorFamily.Width = 41;
            // 
            // NationalCode
            // 
            this.NationalCode.Caption = "کدملی";
            this.NationalCode.FieldName = "NationalCode";
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.NationalCode.Visible = true;
            this.NationalCode.VisibleIndex = 12;
            this.NationalCode.Width = 38;
            // 
            // ParentName
            // 
            this.ParentName.Caption = "نام پدر";
            this.ParentName.FieldName = "ParentName";
            this.ParentName.Name = "ParentName";
            this.ParentName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ParentName.Visible = true;
            this.ParentName.VisibleIndex = 11;
            this.ParentName.Width = 38;
            // 
            // DoctorTypeDsc
            // 
            this.DoctorTypeDsc.Caption = "نوع پزشک";
            this.DoctorTypeDsc.FieldName = "DoctorTypeDsc";
            this.DoctorTypeDsc.Name = "DoctorTypeDsc";
            this.DoctorTypeDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // ContractTypeDsc
            // 
            this.ContractTypeDsc.Caption = "نوع قرارداد";
            this.ContractTypeDsc.FieldName = "ContractTypeDsc";
            this.ContractTypeDsc.Name = "ContractTypeDsc";
            this.ContractTypeDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // IDNO
            // 
            this.IDNO.Caption = "شماره شناسنامه";
            this.IDNO.FieldName = "IDNO";
            this.IDNO.Name = "IDNO";
            this.IDNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // BrithDate
            // 
            this.BrithDate.Caption = "تاریخ تولد";
            this.BrithDate.FieldName = "BrithDate";
            this.BrithDate.Name = "BrithDate";
            // 
            // BrithCityName
            // 
            this.BrithCityName.Caption = "محل تولد/صدور";
            this.BrithCityName.FieldName = "BrithCityName";
            this.BrithCityName.Name = "BrithCityName";
            this.BrithCityName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // Address
            // 
            this.Address.Caption = "آدرس منزل";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 10;
            this.Address.Width = 38;
            // 
            // TelHome
            // 
            this.TelHome.Caption = "تلفن مطب";
            this.TelHome.FieldName = "TelHome";
            this.TelHome.Name = "TelHome";
            this.TelHome.Visible = true;
            this.TelHome.VisibleIndex = 9;
            this.TelHome.Width = 38;
            // 
            // TelBusiness
            // 
            this.TelBusiness.Caption = "تلفن منزل-موبایل 2";
            this.TelBusiness.FieldName = "TelBusiness";
            this.TelBusiness.Name = "TelBusiness";
            this.TelBusiness.Visible = true;
            this.TelBusiness.VisibleIndex = 8;
            this.TelBusiness.Width = 40;
            // 
            // Mobile
            // 
            this.Mobile.Caption = "موبایل-اصلی";
            this.Mobile.FieldName = "Mobile";
            this.Mobile.Name = "Mobile";
            this.Mobile.Visible = true;
            this.Mobile.VisibleIndex = 7;
            this.Mobile.Width = 40;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 6;
            this.Email.Width = 47;
            // 
            // AddressBusiness
            // 
            this.AddressBusiness.Caption = "آدرس مطب";
            this.AddressBusiness.FieldName = "AddressBusiness";
            this.AddressBusiness.Name = "AddressBusiness";
            this.AddressBusiness.Visible = true;
            this.AddressBusiness.VisibleIndex = 5;
            this.AddressBusiness.Width = 36;
            // 
            // LocationPart
            // 
            this.LocationPart.Caption = "مناطق تحت پوشش";
            this.LocationPart.FieldName = "LocationPart";
            this.LocationPart.Name = "LocationPart";
            this.LocationPart.Visible = true;
            this.LocationPart.VisibleIndex = 0;
            this.LocationPart.Width = 36;
            // 
            // CardBankNo1
            // 
            this.CardBankNo1.Caption = "شماره عابربانک";
            this.CardBankNo1.FieldName = "CardBankNo1";
            this.CardBankNo1.Name = "CardBankNo1";
            this.CardBankNo1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // CardBankNo2
            // 
            this.CardBankNo2.Caption = "شماره عابر بانک 2";
            this.CardBankNo2.FieldName = "CardBankNo2";
            this.CardBankNo2.Name = "CardBankNo2";
            this.CardBankNo2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // BankName
            // 
            this.BankName.Caption = "نام بانک";
            this.BankName.FieldName = "BankName";
            this.BankName.Name = "BankName";
            this.BankName.Visible = true;
            this.BankName.VisibleIndex = 4;
            this.BankName.Width = 36;
            // 
            // ContractDate
            // 
            this.ContractDate.Caption = "تاریخ شروع قرارداد";
            this.ContractDate.FieldName = "ContractDate";
            this.ContractDate.Name = "ContractDate";
            this.ContractDate.Visible = true;
            this.ContractDate.VisibleIndex = 2;
            this.ContractDate.Width = 36;
            // 
            // ContractEndDate
            // 
            this.ContractEndDate.Caption = "تاریخ پایان قرارداد";
            this.ContractEndDate.FieldName = "ContractEndDate";
            this.ContractEndDate.Name = "ContractEndDate";
            this.ContractEndDate.Visible = true;
            this.ContractEndDate.VisibleIndex = 1;
            this.ContractEndDate.Width = 36;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // exPanelFilter
            // 
            this.exPanelFilter.CanvasColor = System.Drawing.SystemColors.Control;
            this.exPanelFilter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.exPanelFilter.Controls.Add(this.panel_Selector);
            this.exPanelFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exPanelFilter.Location = new System.Drawing.Point(0, 388);
            this.exPanelFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exPanelFilter.Name = "exPanelFilter";
            this.exPanelFilter.Size = new System.Drawing.Size(848, 55);
            this.exPanelFilter.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.exPanelFilter.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.exPanelFilter.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.exPanelFilter.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.exPanelFilter.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.exPanelFilter.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.exPanelFilter.Style.GradientAngle = 90;
            this.exPanelFilter.TabIndex = 43;
            this.exPanelFilter.TitleHeight = 21;
            this.exPanelFilter.TitleStyle.Alignment = System.Drawing.StringAlignment.Far;
            this.exPanelFilter.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.exPanelFilter.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.exPanelFilter.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.exPanelFilter.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.exPanelFilter.TitleStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exPanelFilter.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.exPanelFilter.TitleStyle.GradientAngle = 90;
            this.exPanelFilter.TitleText = "فیلتر";
            // 
            // panel_Selector
            // 
            this.panel_Selector.AutoScroll = true;
            this.panel_Selector.AutoScrollMinSize = new System.Drawing.Size(830, 0);
            this.panel_Selector.Controls.Add(this.chkContract);
            this.panel_Selector.Controls.Add(this.chkNonContract);
            this.panel_Selector.Controls.Add(this.chkActive);
            this.panel_Selector.Controls.Add(this.chkNonActive);
            this.panel_Selector.Controls.Add(this.chkAllDoctor);
            this.panel_Selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Selector.Location = new System.Drawing.Point(0, 21);
            this.panel_Selector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Selector.Name = "panel_Selector";
            this.panel_Selector.Size = new System.Drawing.Size(848, 34);
            this.panel_Selector.TabIndex = 50;
            // 
            // chkContract
            // 
            this.chkContract.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkContract.AutoSize = true;
            this.chkContract.BackColor = System.Drawing.Color.Transparent;
            this.chkContract.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkContract.Location = new System.Drawing.Point(122, 7);
            this.chkContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkContract.Name = "chkContract";
            this.chkContract.Size = new System.Drawing.Size(158, 17);
            this.chkContract.TabIndex = 11;
            this.chkContract.Text = "پزشکانی که قرارداد دارند";
            this.chkContract.UseVisualStyleBackColor = false;
            this.chkContract.Click += new System.EventHandler(this.chkAllDoctor_CheckedChanged);
            // 
            // chkNonContract
            // 
            this.chkNonContract.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkNonContract.AutoSize = true;
            this.chkNonContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chkNonContract.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkNonContract.Location = new System.Drawing.Point(301, 7);
            this.chkNonContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNonContract.Name = "chkNonContract";
            this.chkNonContract.Size = new System.Drawing.Size(162, 17);
            this.chkNonContract.TabIndex = 10;
            this.chkNonContract.Text = "پزشکانی که قرارداد ندارند";
            this.chkNonContract.UseVisualStyleBackColor = false;
            this.chkNonContract.Click += new System.EventHandler(this.chkAllDoctor_CheckedChanged);
            // 
            // chkActive
            // 
            this.chkActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkActive.AutoSize = true;
            this.chkActive.BackColor = System.Drawing.Color.Transparent;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkActive.Location = new System.Drawing.Point(571, 7);
            this.chkActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(49, 17);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "فعال";
            this.chkActive.UseVisualStyleBackColor = false;
            this.chkActive.Click += new System.EventHandler(this.chkAllDoctor_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 331);
            this.panel1.TabIndex = 44;
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPic.Location = new System.Drawing.Point(14, 42);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(145, 218);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPic.TabIndex = 0;
            this.pictureBoxPic.TabStop = false;
            // 
            // DoctorList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_DoctorList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exPanelFilter);
            this.Controls.Add(this.itemPanelCar);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(10, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DoctorList_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(848, 443);
            this.Load += new System.EventHandler(this.DoctorList_UC_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.DoctorList_UC_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DoctorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoctorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.exPanelFilter.ResumeLayout(false);
            this.panel_Selector.ResumeLayout(false);
            this.panel_Selector.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TextBoxItem textboxitem_status;
        private DevComponents.DotNetBar.ButtonItem buttonItem_StatusOK;
        private DevComponents.DotNetBar.ItemPanel itemPanelCar;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorEdit;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorDel;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorPrintList;
        private System.Windows.Forms.RadioButton chkAllDoctor;
        private DevExpress.XtraGrid.GridControl gridControl_DoctorList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DoctorList;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorID;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn NationalCode;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorName;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorFamily;
        private DevExpress.XtraGrid.Columns.GridColumn ParentName;
        private DevExpress.XtraGrid.Columns.GridColumn IDNO;
        private DevExpress.XtraGrid.Columns.GridColumn BrithDate;
        private DevExpress.XtraGrid.Columns.GridColumn BrithCityName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn TelHome;
        private DevExpress.XtraGrid.Columns.GridColumn TelBusiness;
        private DevExpress.XtraGrid.Columns.GridColumn Mobile;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
        private DevExpress.XtraGrid.Columns.GridColumn ContractTypeDsc;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorTypeDsc;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorType;
        private DevExpress.XtraGrid.Columns.GridColumn MedicalCode;
        private System.Windows.Forms.RadioButton chkNonActive;
        private DevExpress.XtraGrid.Columns.GridColumn CardBankNo1;
        private DevExpress.XtraGrid.Columns.GridColumn CardBankNo2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevComponents.DotNetBar.ButtonItem buttonItemRefresh;
        private DevComponents.DotNetBar.ExpandablePanel exPanelFilter;
        private System.Windows.Forms.Panel panel_Selector;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorSMSEmail;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorSMS;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorEmail;
        private DevComponents.DotNetBar.ButtonItem buttonItem_DoctorNew;
        private DevComponents.DotNetBar.ButtonItem buttonItemExcelExportDoctorList;
        private DevExpress.XtraGrid.Columns.GridColumn AddressBusiness;
        private DevExpress.XtraGrid.Columns.GridColumn LocationPart;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.RadioButton chkActive;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorListContract;
        private DevExpress.XtraGrid.Columns.GridColumn ContractNo;
        private DevExpress.XtraGrid.Columns.GridColumn ContractDate;
        private DevExpress.XtraGrid.Columns.GridColumn ContractEndDate;
        private System.Windows.Forms.RadioButton chkNonContract;
        private System.Windows.Forms.RadioButton chkContract;
        private DevComponents.DotNetBar.ButtonItem buttonItemFileDoctors;
        private DevExpress.XtraGrid.Columns.GridColumn RowNumber;
    }
}
