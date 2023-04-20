namespace MehrParvarPrj
{
    partial class DoctorPaymentNE_frm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPaymentNE_frm));
            this.ribbonBar_Cnclu = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel_All = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCostVisitDoctorBes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.label33 = new System.Windows.Forms.Label();
            this.buttonDoctorId = new DevComponents.DotNetBar.ButtonX();
            this.label_FName = new System.Windows.Forms.Label();
            this.textBoxDoctorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxAccountingDocumentNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelPaymentDoctorDate = new System.Windows.Forms.Panel();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelVisitCreateDate = new System.Windows.Forms.Panel();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.label_Date1 = new System.Windows.Forms.Label();
            this.label_Date2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.groupPanel_All.SuspendLayout();
            this.panelPaymentDoctorDate.SuspendLayout();
            this.panelVisitCreateDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBar_Cnclu
            // 
            this.ribbonBar_Cnclu.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_Cnclu.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Cnclu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_Cnclu.ContainerControlProcessDialogKey = true;
            this.ribbonBar_Cnclu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonBar_Cnclu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ribbonBar_Cnclu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_OK,
            this.buttonItem_Cancel});
            this.ribbonBar_Cnclu.Location = new System.Drawing.Point(0, 193);
            this.ribbonBar_Cnclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Cnclu.Name = "ribbonBar_Cnclu";
            this.ribbonBar_Cnclu.Size = new System.Drawing.Size(683, 59);
            this.ribbonBar_Cnclu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.ribbonBar_Cnclu.TabIndex = 2;
            // 
            // 
            // 
            this.ribbonBar_Cnclu.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Cnclu.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_Cnclu.TitleVisible = false;
            // 
            // buttonItem_OK
            // 
            this.buttonItem_OK.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_OK.FixedSize = new System.Drawing.Size(160, 60);
            this.buttonItem_OK.HotFontBold = true;
            this.buttonItem_OK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_OK.Image")));
            this.buttonItem_OK.ImagePaddingHorizontal = 20;
            this.buttonItem_OK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_OK.Name = "buttonItem_OK";
            this.buttonItem_OK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem_OK.SubItemsExpandWidth = 20;
            this.buttonItem_OK.Text = "تایید و بسته شدن";
            this.buttonItem_OK.Click += new System.EventHandler(this.buttonItem_OK_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem_Cancel.HotFontBold = true;
            this.buttonItem_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Cancel.Image")));
            this.buttonItem_Cancel.ImagePaddingHorizontal = 20;
            this.buttonItem_Cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Cancel.Name = "buttonItem_Cancel";
            this.buttonItem_Cancel.SubItemsExpandWidth = 14;
            this.buttonItem_Cancel.Text = "انصراف";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // groupPanel_All
            // 
            this.groupPanel_All.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_All.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_All.Controls.Add(this.label4);
            this.groupPanel_All.Controls.Add(this.textBoxCostVisitDoctorBes);
            this.groupPanel_All.Controls.Add(this.label3);
            this.groupPanel_All.Controls.Add(this.comboBoxPaymentType);
            this.groupPanel_All.Controls.Add(this.label33);
            this.groupPanel_All.Controls.Add(this.buttonDoctorId);
            this.groupPanel_All.Controls.Add(this.label_FName);
            this.groupPanel_All.Controls.Add(this.textBoxDoctorName);
            this.groupPanel_All.Controls.Add(this.textBoxDescription);
            this.groupPanel_All.Controls.Add(this.textBoxAccountingDocumentNumber);
            this.groupPanel_All.Controls.Add(this.label6);
            this.groupPanel_All.Controls.Add(this.label9);
            this.groupPanel_All.Controls.Add(this.panelPaymentDoctorDate);
            this.groupPanel_All.Controls.Add(this.panelVisitCreateDate);
            this.groupPanel_All.Controls.Add(this.label1);
            this.groupPanel_All.Controls.Add(this.label_Date);
            this.groupPanel_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_All.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_All.IsShadowEnabled = true;
            this.groupPanel_All.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_All.Name = "groupPanel_All";
            this.groupPanel_All.Size = new System.Drawing.Size(683, 193);
            // 
            // 
            // 
            this.groupPanel_All.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_All.Style.BackColorGradientAngle = 90;
            this.groupPanel_All.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_All.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderBottomWidth = 1;
            this.groupPanel_All.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_All.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderLeftWidth = 1;
            this.groupPanel_All.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderRightWidth = 1;
            this.groupPanel_All.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderTopWidth = 1;
            this.groupPanel_All.Style.CornerDiameter = 4;
            this.groupPanel_All.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_All.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_All.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_All.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_All.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_All.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_All.TabIndex = 1;
            this.groupPanel_All.Text = "مشخصات اولیه";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "ریال";
            // 
            // textBoxCostVisitDoctorBes
            // 
            this.textBoxCostVisitDoctorBes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxCostVisitDoctorBes.Border.Class = "TextBoxBorder";
            this.textBoxCostVisitDoctorBes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCostVisitDoctorBes.Location = new System.Drawing.Point(384, 70);
            this.textBoxCostVisitDoctorBes.Name = "textBoxCostVisitDoctorBes";
            this.textBoxCostVisitDoctorBes.Size = new System.Drawing.Size(173, 21);
            this.textBoxCostVisitDoctorBes.TabIndex = 5;
            this.textBoxCostVisitDoctorBes.Text = "0";
            this.textBoxCostVisitDoctorBes.TextChanged += new System.EventHandler(this.textBox_Price_TextChanged);
            this.textBoxCostVisitDoctorBes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "مبلغ پرداختی پزشک:";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPaymentType.DisplayMember = "Text";
            this.comboBoxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentType.ItemHeight = 13;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem10,
            this.comboItem9});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(384, 37);
            this.comboBoxPaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(173, 21);
            this.comboBoxPaymentType.TabIndex = 3;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "پرداختی";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "کسورات";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "پيش پرداخت";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(559, 42);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(62, 13);
            this.label33.TabIndex = 81;
            this.label33.Text = "نوع پرداخت:";
            // 
            // buttonDoctorId
            // 
            this.buttonDoctorId.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDoctorId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoctorId.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonDoctorId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonDoctorId.Location = new System.Drawing.Point(324, 7);
            this.buttonDoctorId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDoctorId.Name = "buttonDoctorId";
            this.buttonDoctorId.Size = new System.Drawing.Size(53, 17);
            this.buttonDoctorId.TabIndex = 1;
            this.buttonDoctorId.Text = "...";
            this.buttonDoctorId.Click += new System.EventHandler(this.buttonPatientID_Click);
            // 
            // label_FName
            // 
            this.label_FName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FName.AutoSize = true;
            this.label_FName.BackColor = System.Drawing.Color.Transparent;
            this.label_FName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_FName.ForeColor = System.Drawing.Color.Black;
            this.label_FName.Location = new System.Drawing.Point(559, 11);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(57, 13);
            this.label_FName.TabIndex = 65;
            this.label_FName.Text = "نام پزشک:";
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxDoctorName.Border.Class = "TextBoxBorder";
            this.textBoxDoctorName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDoctorName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxDoctorName.ForeColor = System.Drawing.Color.Black;
            this.textBoxDoctorName.Location = new System.Drawing.Point(384, 7);
            this.textBoxDoctorName.MaxLength = 50;
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.ReadOnly = true;
            this.textBoxDoctorName.Size = new System.Drawing.Size(173, 21);
            this.textBoxDoctorName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxDescription.Border.Class = "TextBoxBorder";
            this.textBoxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.Black;
            this.textBoxDescription.Location = new System.Drawing.Point(22, 105);
            this.textBoxDescription.MaxLength = 0;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(533, 45);
            this.textBoxDescription.TabIndex = 7;
            // 
            // textBoxAccountingDocumentNumber
            // 
            // 
            // 
            // 
            this.textBoxAccountingDocumentNumber.Border.Class = "TextBoxBorder";
            this.textBoxAccountingDocumentNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxAccountingDocumentNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxAccountingDocumentNumber.ForeColor = System.Drawing.Color.Black;
            this.textBoxAccountingDocumentNumber.Location = new System.Drawing.Point(22, 39);
            this.textBoxAccountingDocumentNumber.MaxLength = 20;
            this.textBoxAccountingDocumentNumber.Name = "textBoxAccountingDocumentNumber";
            this.textBoxAccountingDocumentNumber.Size = new System.Drawing.Size(154, 21);
            this.textBoxAccountingDocumentNumber.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(559, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "توضیحات:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(176, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "شماره سند حسابداری:";
            // 
            // panelPaymentDoctorDate
            // 
            this.panelPaymentDoctorDate.BackColor = System.Drawing.Color.Transparent;
            this.panelPaymentDoctorDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaymentDoctorDate.Controls.Add(this.comboBoxYear);
            this.panelPaymentDoctorDate.Controls.Add(this.comboBoxDay);
            this.panelPaymentDoctorDate.Controls.Add(this.comboBoxMonth);
            this.panelPaymentDoctorDate.Controls.Add(this.label2);
            this.panelPaymentDoctorDate.Controls.Add(this.label5);
            this.panelPaymentDoctorDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelPaymentDoctorDate.Location = new System.Drawing.Point(22, 67);
            this.panelPaymentDoctorDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPaymentDoctorDate.Name = "panelPaymentDoctorDate";
            this.panelPaymentDoctorDate.Size = new System.Drawing.Size(154, 27);
            this.panelPaymentDoctorDate.TabIndex = 6;
            this.panelPaymentDoctorDate.Leave += new System.EventHandler(this.panelPaymentDoctorDate_Leave);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYear.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxYear.ForeColor = System.Drawing.Color.Black;
            this.comboBoxYear.IntegralHeight = false;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410"});
            this.comboBoxYear.Location = new System.Drawing.Point(3, 2);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(53, 21);
            this.comboBoxYear.TabIndex = 2;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDay.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxDay.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDay.IntegralHeight = false;
            this.comboBoxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(112, 2);
            this.comboBoxDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(35, 21);
            this.comboBoxDay.TabIndex = 0;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMonth.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxMonth.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMonth.IntegralHeight = false;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(66, 2);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(36, 21);
            this.comboBoxMonth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(102, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "/";
            // 
            // panelVisitCreateDate
            // 
            this.panelVisitCreateDate.BackColor = System.Drawing.Color.Transparent;
            this.panelVisitCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVisitCreateDate.Controls.Add(this.comboBox_Year);
            this.panelVisitCreateDate.Controls.Add(this.comboBox_Day);
            this.panelVisitCreateDate.Controls.Add(this.comboBox_Month);
            this.panelVisitCreateDate.Controls.Add(this.label_Date1);
            this.panelVisitCreateDate.Controls.Add(this.label_Date2);
            this.panelVisitCreateDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelVisitCreateDate.Location = new System.Drawing.Point(22, 8);
            this.panelVisitCreateDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVisitCreateDate.Name = "panelVisitCreateDate";
            this.panelVisitCreateDate.Size = new System.Drawing.Size(154, 27);
            this.panelVisitCreateDate.TabIndex = 2;
            this.panelVisitCreateDate.Leave += new System.EventHandler(this.panel_CDate1_Leave);
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Year.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Year.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Year.IntegralHeight = false;
            this.comboBox_Year.Items.AddRange(new object[] {
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410"});
            this.comboBox_Year.Location = new System.Drawing.Point(3, 2);
            this.comboBox_Year.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(53, 21);
            this.comboBox_Year.TabIndex = 2;
            // 
            // comboBox_Day
            // 
            this.comboBox_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Day.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Day.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Day.IntegralHeight = false;
            this.comboBox_Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_Day.Location = new System.Drawing.Point(112, 2);
            this.comboBox_Day.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(35, 21);
            this.comboBox_Day.TabIndex = 0;
            // 
            // comboBox_Month
            // 
            this.comboBox_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Month.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Month.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Month.IntegralHeight = false;
            this.comboBox_Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_Month.Location = new System.Drawing.Point(66, 2);
            this.comboBox_Month.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(36, 21);
            this.comboBox_Month.TabIndex = 1;
            // 
            // label_Date1
            // 
            this.label_Date1.AutoSize = true;
            this.label_Date1.BackColor = System.Drawing.Color.Transparent;
            this.label_Date1.Location = new System.Drawing.Point(102, 5);
            this.label_Date1.Name = "label_Date1";
            this.label_Date1.Size = new System.Drawing.Size(11, 13);
            this.label_Date1.TabIndex = 16;
            this.label_Date1.Text = "/";
            // 
            // label_Date2
            // 
            this.label_Date2.AutoSize = true;
            this.label_Date2.Location = new System.Drawing.Point(56, 4);
            this.label_Date2.Name = "label_Date2";
            this.label_Date2.Size = new System.Drawing.Size(11, 13);
            this.label_Date2.TabIndex = 17;
            this.label_Date2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(176, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "تاریخ پرداخت:";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.Color.Transparent;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Date.ForeColor = System.Drawing.Color.Black;
            this.label_Date.Location = new System.Drawing.Point(176, 15);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(82, 13);
            this.label_Date.TabIndex = 33;
            this.label_Date.Text = "تاریخ ویزیت/ثبت:";
            // 
            // DoctorPaymentNE_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 252);
            this.Controls.Add(this.groupPanel_All);
            this.Controls.Add(this.ribbonBar_Cnclu);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DoctorPaymentNE_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرداختی ویزیت به پزشک";
            this.Load += new System.EventHandler(this.DoctorPaymentNE_frm_Load);
            this.groupPanel_All.ResumeLayout(false);
            this.groupPanel_All.PerformLayout();
            this.panelPaymentDoctorDate.ResumeLayout(false);
            this.panelPaymentDoctorDate.PerformLayout();
            this.panelVisitCreateDate.ResumeLayout(false);
            this.panelVisitCreateDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Cnclu;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_All;
        private System.Windows.Forms.Panel panelVisitCreateDate;
        public System.Windows.Forms.Label label_Date2;
        private System.Windows.Forms.Label label_Date1;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.Label label_Date;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxAccountingDocumentNumber;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.ButtonX buttonDoctorId;
        private System.Windows.Forms.Label label_FName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDoctorName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxPaymentType;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem10;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCostVisitDoctorBes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPaymentDoctorDate;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDescription;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.ComboItem comboItem1;
    }
}