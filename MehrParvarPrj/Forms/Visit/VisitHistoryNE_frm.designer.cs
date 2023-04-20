namespace MehrParvarPrj
{
    partial class VisitHistoryNE_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitHistoryNE_frm));
            this.ribbonBar_Cnclu = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDosiersNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_CFamily = new System.Windows.Forms.Label();
            this.panel_VisitDate = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_YearBD = new System.Windows.Forms.ComboBox();
            this.comboBox_DayBD = new System.Windows.Forms.ComboBox();
            this.comboBox_MonthBD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupPanel_Other = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBoxNationalCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.NUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Mobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_MobileDoctor = new System.Windows.Forms.Label();
            this.label_LName = new System.Windows.Forms.Label();
            this.textBoxDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel_VisitDate.SuspendLayout();
            this.groupPanel_Other.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownMinute)).BeginInit();
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
            this.ribbonBar_Cnclu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ribbonBar_Cnclu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_OK,
            this.buttonItem_Cancel});
            this.ribbonBar_Cnclu.Location = new System.Drawing.Point(0, 260);
            this.ribbonBar_Cnclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Cnclu.Name = "ribbonBar_Cnclu";
            this.ribbonBar_Cnclu.Size = new System.Drawing.Size(494, 61);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(389, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "تاریخ دریافت:";
            // 
            // textBoxDosiersNo
            // 
            this.textBoxDosiersNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxDosiersNo.Border.Class = "TextBoxBorder";
            this.textBoxDosiersNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDosiersNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxDosiersNo.ForeColor = System.Drawing.Color.Black;
            this.textBoxDosiersNo.Location = new System.Drawing.Point(232, 114);
            this.textBoxDosiersNo.MaxLength = 10;
            this.textBoxDosiersNo.Name = "textBoxDosiersNo";
            this.textBoxDosiersNo.Size = new System.Drawing.Size(152, 21);
            this.textBoxDosiersNo.TabIndex = 4;
            // 
            // label_CFamily
            // 
            this.label_CFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CFamily.AutoSize = true;
            this.label_CFamily.BackColor = System.Drawing.Color.Transparent;
            this.label_CFamily.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CFamily.ForeColor = System.Drawing.Color.Black;
            this.label_CFamily.Location = new System.Drawing.Point(389, 118);
            this.label_CFamily.Name = "label_CFamily";
            this.label_CFamily.Size = new System.Drawing.Size(95, 13);
            this.label_CFamily.TabIndex = 53;
            this.label_CFamily.Text = "شماره پرونده بیمار:";
            // 
            // panel_VisitDate
            // 
            this.panel_VisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_VisitDate.BackColor = System.Drawing.Color.Transparent;
            this.panel_VisitDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_VisitDate.Controls.Add(this.label3);
            this.panel_VisitDate.Controls.Add(this.comboBox_YearBD);
            this.panel_VisitDate.Controls.Add(this.comboBox_DayBD);
            this.panel_VisitDate.Controls.Add(this.comboBox_MonthBD);
            this.panel_VisitDate.Controls.Add(this.label2);
            this.panel_VisitDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel_VisitDate.Location = new System.Drawing.Point(232, 7);
            this.panel_VisitDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_VisitDate.Name = "panel_VisitDate";
            this.panel_VisitDate.Size = new System.Drawing.Size(152, 27);
            this.panel_VisitDate.TabIndex = 1;
            this.panel_VisitDate.Leave += new System.EventHandler(this.panel_BrithDate_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(101, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "/";
            // 
            // comboBox_YearBD
            // 
            this.comboBox_YearBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_YearBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_YearBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_YearBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_YearBD.IntegralHeight = false;
            this.comboBox_YearBD.Items.AddRange(new object[] {
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
            this.comboBox_YearBD.Location = new System.Drawing.Point(3, 2);
            this.comboBox_YearBD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_YearBD.Name = "comboBox_YearBD";
            this.comboBox_YearBD.Size = new System.Drawing.Size(53, 21);
            this.comboBox_YearBD.TabIndex = 2;
            // 
            // comboBox_DayBD
            // 
            this.comboBox_DayBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DayBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_DayBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_DayBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_DayBD.IntegralHeight = false;
            this.comboBox_DayBD.Items.AddRange(new object[] {
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
            this.comboBox_DayBD.Location = new System.Drawing.Point(112, 2);
            this.comboBox_DayBD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_DayBD.Name = "comboBox_DayBD";
            this.comboBox_DayBD.Size = new System.Drawing.Size(35, 21);
            this.comboBox_DayBD.TabIndex = 0;
            // 
            // comboBox_MonthBD
            // 
            this.comboBox_MonthBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MonthBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_MonthBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_MonthBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_MonthBD.IntegralHeight = false;
            this.comboBox_MonthBD.Items.AddRange(new object[] {
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
            this.comboBox_MonthBD.Location = new System.Drawing.Point(65, 2);
            this.comboBox_MonthBD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_MonthBD.Name = "comboBox_MonthBD";
            this.comboBox_MonthBD.Size = new System.Drawing.Size(36, 21);
            this.comboBox_MonthBD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "/";
            // 
            // groupPanel_Other
            // 
            this.groupPanel_Other.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Other.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Other.Controls.Add(this.textBoxNationalCode);
            this.groupPanel_Other.Controls.Add(this.label5);
            this.groupPanel_Other.Controls.Add(this.panel1);
            this.groupPanel_Other.Controls.Add(this.textBox_Mobile);
            this.groupPanel_Other.Controls.Add(this.label_MobileDoctor);
            this.groupPanel_Other.Controls.Add(this.label_LName);
            this.groupPanel_Other.Controls.Add(this.textBoxDescription);
            this.groupPanel_Other.Controls.Add(this.label1);
            this.groupPanel_Other.Controls.Add(this.panel_VisitDate);
            this.groupPanel_Other.Controls.Add(this.textBoxDosiersNo);
            this.groupPanel_Other.Controls.Add(this.label_CFamily);
            this.groupPanel_Other.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_Other.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_Other.IsShadowEnabled = true;
            this.groupPanel_Other.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_Other.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Other.Name = "groupPanel_Other";
            this.groupPanel_Other.Size = new System.Drawing.Size(494, 260);
            // 
            // 
            // 
            this.groupPanel_Other.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Other.Style.BackColorGradientAngle = 90;
            this.groupPanel_Other.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Other.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Other.Style.BorderBottomWidth = 1;
            this.groupPanel_Other.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Other.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Other.Style.BorderLeftWidth = 1;
            this.groupPanel_Other.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Other.Style.BorderRightWidth = 1;
            this.groupPanel_Other.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Other.Style.BorderTopWidth = 1;
            this.groupPanel_Other.Style.CornerDiameter = 4;
            this.groupPanel_Other.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Other.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Other.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Other.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_Other.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_Other.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_Other.TabIndex = 1;
            this.groupPanel_Other.Text = "مشخصات";
            // 
            // textBoxNationalCode
            // 
            this.textBoxNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxNationalCode.Border.Class = "TextBoxBorder";
            this.textBoxNationalCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxNationalCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxNationalCode.ForeColor = System.Drawing.Color.Black;
            this.textBoxNationalCode.Location = new System.Drawing.Point(232, 83);
            this.textBoxNationalCode.MaxLength = 10;
            this.textBoxNationalCode.Name = "textBoxNationalCode";
            this.textBoxNationalCode.Size = new System.Drawing.Size(152, 21);
            this.textBoxNationalCode.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(389, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "*کد ملی بیمار:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NUpDownHour);
            this.panel1.Controls.Add(this.NUpDownMinute);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(130, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 30);
            this.panel1.TabIndex = 2;
            // 
            // NUpDownHour
            // 
            this.NUpDownHour.Location = new System.Drawing.Point(4, 4);
            this.NUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUpDownHour.Name = "NUpDownHour";
            this.NUpDownHour.Size = new System.Drawing.Size(40, 21);
            this.NUpDownHour.TabIndex = 2;
            // 
            // NUpDownMinute
            // 
            this.NUpDownMinute.Location = new System.Drawing.Point(50, 4);
            this.NUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUpDownMinute.Name = "NUpDownMinute";
            this.NUpDownMinute.Size = new System.Drawing.Size(40, 21);
            this.NUpDownMinute.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = ":";
            // 
            // textBox_Mobile
            // 
            this.textBox_Mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_Mobile.Border.Class = "TextBoxBorder";
            this.textBox_Mobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_Mobile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_Mobile.ForeColor = System.Drawing.Color.Black;
            this.textBox_Mobile.Location = new System.Drawing.Point(232, 47);
            this.textBox_Mobile.MaxLength = 50;
            this.textBox_Mobile.Name = "textBox_Mobile";
            this.textBox_Mobile.Size = new System.Drawing.Size(152, 21);
            this.textBox_Mobile.TabIndex = 3;
            // 
            // label_MobileDoctor
            // 
            this.label_MobileDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MobileDoctor.AutoSize = true;
            this.label_MobileDoctor.BackColor = System.Drawing.Color.Transparent;
            this.label_MobileDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_MobileDoctor.ForeColor = System.Drawing.Color.Black;
            this.label_MobileDoctor.Location = new System.Drawing.Point(389, 51);
            this.label_MobileDoctor.Name = "label_MobileDoctor";
            this.label_MobileDoctor.Size = new System.Drawing.Size(78, 13);
            this.label_MobileDoctor.TabIndex = 37;
            this.label_MobileDoctor.Text = "*موبایل پزشک:";
            // 
            // label_LName
            // 
            this.label_LName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LName.AutoSize = true;
            this.label_LName.BackColor = System.Drawing.Color.Transparent;
            this.label_LName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LName.ForeColor = System.Drawing.Color.Black;
            this.label_LName.Location = new System.Drawing.Point(389, 150);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(51, 13);
            this.label_LName.TabIndex = 35;
            this.label_LName.Text = "توضیحات:";
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
            this.textBoxDescription.Location = new System.Drawing.Point(13, 150);
            this.textBoxDescription.MaxLength = 4000;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(371, 74);
            this.textBoxDescription.TabIndex = 5;
            // 
            // VisitHistoryNE_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 321);
            this.Controls.Add(this.groupPanel_Other);
            this.Controls.Add(this.ribbonBar_Cnclu);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(877, 540);
            this.MinimumSize = new System.Drawing.Size(510, 270);
            this.Name = "VisitHistoryNE_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویزیت";
            this.panel_VisitDate.ResumeLayout(false);
            this.panel_VisitDate.PerformLayout();
            this.groupPanel_Other.ResumeLayout(false);
            this.groupPanel_Other.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Cnclu;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private System.Windows.Forms.Panel panel_VisitDate;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_YearBD;
        private System.Windows.Forms.ComboBox comboBox_DayBD;
        private System.Windows.Forms.ComboBox comboBox_MonthBD;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Other;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_Mobile;
        private System.Windows.Forms.Label label_MobileDoctor;
        private System.Windows.Forms.Label label_LName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDescription;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDosiersNo;
        private System.Windows.Forms.Label label_CFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUpDownHour;
        private System.Windows.Forms.NumericUpDown NUpDownMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxNationalCode;
        private System.Windows.Forms.Label label5;
    }
}