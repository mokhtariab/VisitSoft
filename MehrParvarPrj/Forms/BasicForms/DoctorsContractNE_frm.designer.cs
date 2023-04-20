namespace MehrParvarPrj
{
    partial class DoctorsContractNE_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsContractNE_frm));
            this.ribbonBar_Cnclu = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.label26 = new System.Windows.Forms.Label();
            this.TextBoxContractNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel_Check = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelContractEndDate = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxYearED = new System.Windows.Forms.ComboBox();
            this.comboBoxDayED = new System.Windows.Forms.ComboBox();
            this.comboBoxMonthED = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelContractDate = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxYearBD = new System.Windows.Forms.ComboBox();
            this.comboBoxDayBD = new System.Windows.Forms.ComboBox();
            this.comboBoxMonthBD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPanel_Check.SuspendLayout();
            this.panelContractEndDate.SuspendLayout();
            this.panelContractDate.SuspendLayout();
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
            this.ribbonBar_Cnclu.Location = new System.Drawing.Point(0, 137);
            this.ribbonBar_Cnclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Cnclu.Name = "ribbonBar_Cnclu";
            this.ribbonBar_Cnclu.Size = new System.Drawing.Size(336, 60);
            this.ribbonBar_Cnclu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.ribbonBar_Cnclu.TabIndex = 5;
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
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(207, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 13);
            this.label26.TabIndex = 325;
            this.label26.Text = "تاریخ شروع قرارداد:";
            // 
            // TextBoxContractNo
            // 
            this.TextBoxContractNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxContractNo.Border.Class = "TextBoxBorder";
            this.TextBoxContractNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxContractNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxContractNo.ForeColor = System.Drawing.Color.Black;
            this.TextBoxContractNo.Location = new System.Drawing.Point(33, 10);
            this.TextBoxContractNo.MaxLength = 100;
            this.TextBoxContractNo.Name = "TextBoxContractNo";
            this.TextBoxContractNo.Size = new System.Drawing.Size(169, 21);
            this.TextBoxContractNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 332;
            this.label1.Text = "تاریخ پایان قرارداد:";
            // 
            // groupPanel_Check
            // 
            this.groupPanel_Check.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Check.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Check.Controls.Add(this.panelContractEndDate);
            this.groupPanel_Check.Controls.Add(this.panelContractDate);
            this.groupPanel_Check.Controls.Add(this.label1);
            this.groupPanel_Check.Controls.Add(this.TextBoxContractNo);
            this.groupPanel_Check.Controls.Add(this.label3);
            this.groupPanel_Check.Controls.Add(this.label26);
            this.groupPanel_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_Check.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_Check.IsShadowEnabled = true;
            this.groupPanel_Check.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Check.Name = "groupPanel_Check";
            this.groupPanel_Check.Size = new System.Drawing.Size(336, 137);
            // 
            // 
            // 
            this.groupPanel_Check.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Check.Style.BackColorGradientAngle = 90;
            this.groupPanel_Check.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Check.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Check.Style.BorderBottomWidth = 1;
            this.groupPanel_Check.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Check.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Check.Style.BorderLeftWidth = 1;
            this.groupPanel_Check.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Check.Style.BorderRightWidth = 1;
            this.groupPanel_Check.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Check.Style.BorderTopWidth = 1;
            this.groupPanel_Check.Style.CornerDiameter = 4;
            this.groupPanel_Check.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Check.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Check.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Check.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_Check.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_Check.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_Check.TabIndex = 1;
            this.groupPanel_Check.Text = "مشخصات قرارداد";
            // 
            // panelContractEndDate
            // 
            this.panelContractEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContractEndDate.BackColor = System.Drawing.Color.Transparent;
            this.panelContractEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContractEndDate.Controls.Add(this.label5);
            this.panelContractEndDate.Controls.Add(this.comboBoxYearED);
            this.panelContractEndDate.Controls.Add(this.comboBoxDayED);
            this.panelContractEndDate.Controls.Add(this.comboBoxMonthED);
            this.panelContractEndDate.Controls.Add(this.label6);
            this.panelContractEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelContractEndDate.Location = new System.Drawing.Point(50, 74);
            this.panelContractEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContractEndDate.Name = "panelContractEndDate";
            this.panelContractEndDate.Size = new System.Drawing.Size(152, 27);
            this.panelContractEndDate.TabIndex = 334;
            this.panelContractEndDate.Leave += new System.EventHandler(this.panelContractEndDate_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(101, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "/";
            // 
            // comboBoxYearED
            // 
            this.comboBoxYearED.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYearED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYearED.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxYearED.ForeColor = System.Drawing.Color.Black;
            this.comboBoxYearED.IntegralHeight = false;
            this.comboBoxYearED.Items.AddRange(new object[] {
            "1300",
            "1301",
            "1302",
            "1303",
            "1304",
            "1305",
            "1306",
            "1307",
            "1308",
            "1309",
            "1310",
            "1311",
            "1312",
            "1313",
            "1314",
            "1315",
            "1316",
            "1317",
            "1318",
            "1319",
            "1320",
            "1321",
            "1322",
            "1323",
            "1324",
            "1325",
            "1326",
            "1327",
            "1328",
            "1329",
            "1330",
            "1331",
            "1332",
            "1333",
            "1334",
            "1335",
            "1336",
            "1337",
            "1338",
            "1339",
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
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
            this.comboBoxYearED.Location = new System.Drawing.Point(3, 2);
            this.comboBoxYearED.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxYearED.Name = "comboBoxYearED";
            this.comboBoxYearED.Size = new System.Drawing.Size(53, 21);
            this.comboBoxYearED.TabIndex = 2;
            // 
            // comboBoxDayED
            // 
            this.comboBoxDayED.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDayED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDayED.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxDayED.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDayED.IntegralHeight = false;
            this.comboBoxDayED.Items.AddRange(new object[] {
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
            this.comboBoxDayED.Location = new System.Drawing.Point(112, 2);
            this.comboBoxDayED.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxDayED.Name = "comboBoxDayED";
            this.comboBoxDayED.Size = new System.Drawing.Size(35, 21);
            this.comboBoxDayED.TabIndex = 0;
            // 
            // comboBoxMonthED
            // 
            this.comboBoxMonthED.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonthED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMonthED.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxMonthED.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMonthED.IntegralHeight = false;
            this.comboBoxMonthED.Items.AddRange(new object[] {
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
            this.comboBoxMonthED.Location = new System.Drawing.Point(65, 2);
            this.comboBoxMonthED.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxMonthED.Name = "comboBoxMonthED";
            this.comboBoxMonthED.Size = new System.Drawing.Size(36, 21);
            this.comboBoxMonthED.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "/";
            // 
            // panelContractDate
            // 
            this.panelContractDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContractDate.BackColor = System.Drawing.Color.Transparent;
            this.panelContractDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContractDate.Controls.Add(this.label2);
            this.panelContractDate.Controls.Add(this.comboBoxYearBD);
            this.panelContractDate.Controls.Add(this.comboBoxDayBD);
            this.panelContractDate.Controls.Add(this.comboBoxMonthBD);
            this.panelContractDate.Controls.Add(this.label4);
            this.panelContractDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelContractDate.Location = new System.Drawing.Point(50, 41);
            this.panelContractDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContractDate.Name = "panelContractDate";
            this.panelContractDate.Size = new System.Drawing.Size(152, 27);
            this.panelContractDate.TabIndex = 333;
            this.panelContractDate.Leave += new System.EventHandler(this.panelContractDate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(101, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "/";
            // 
            // comboBoxYearBD
            // 
            this.comboBoxYearBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYearBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYearBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxYearBD.ForeColor = System.Drawing.Color.Black;
            this.comboBoxYearBD.IntegralHeight = false;
            this.comboBoxYearBD.Items.AddRange(new object[] {
            "1300",
            "1301",
            "1302",
            "1303",
            "1304",
            "1305",
            "1306",
            "1307",
            "1308",
            "1309",
            "1310",
            "1311",
            "1312",
            "1313",
            "1314",
            "1315",
            "1316",
            "1317",
            "1318",
            "1319",
            "1320",
            "1321",
            "1322",
            "1323",
            "1324",
            "1325",
            "1326",
            "1327",
            "1328",
            "1329",
            "1330",
            "1331",
            "1332",
            "1333",
            "1334",
            "1335",
            "1336",
            "1337",
            "1338",
            "1339",
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
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
            this.comboBoxYearBD.Location = new System.Drawing.Point(3, 2);
            this.comboBoxYearBD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxYearBD.Name = "comboBoxYearBD";
            this.comboBoxYearBD.Size = new System.Drawing.Size(53, 21);
            this.comboBoxYearBD.TabIndex = 2;
            // 
            // comboBoxDayBD
            // 
            this.comboBoxDayBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDayBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDayBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxDayBD.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDayBD.IntegralHeight = false;
            this.comboBoxDayBD.Items.AddRange(new object[] {
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
            this.comboBoxDayBD.Location = new System.Drawing.Point(112, 2);
            this.comboBoxDayBD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxDayBD.Name = "comboBoxDayBD";
            this.comboBoxDayBD.Size = new System.Drawing.Size(35, 21);
            this.comboBoxDayBD.TabIndex = 0;
            // 
            // comboBoxMonthBD
            // 
            this.comboBoxMonthBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonthBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMonthBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxMonthBD.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMonthBD.IntegralHeight = false;
            this.comboBoxMonthBD.Items.AddRange(new object[] {
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
            this.comboBoxMonthBD.Location = new System.Drawing.Point(65, 2);
            this.comboBoxMonthBD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxMonthBD.Name = "comboBoxMonthBD";
            this.comboBoxMonthBD.Size = new System.Drawing.Size(36, 21);
            this.comboBoxMonthBD.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "/";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(207, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 325;
            this.label3.Text = "شماره قرارداد:";
            // 
            // DoctorsContractNE_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 197);
            this.Controls.Add(this.groupPanel_Check);
            this.Controls.Add(this.ribbonBar_Cnclu);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(877, 340);
            this.MinimumSize = new System.Drawing.Size(352, 230);
            this.Name = "DoctorsContractNE_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قرارداد پزشکان";
            this.Load += new System.EventHandler(this.DoctorsContractNE_frm_Load);
            this.groupPanel_Check.ResumeLayout(false);
            this.groupPanel_Check.PerformLayout();
            this.panelContractEndDate.ResumeLayout(false);
            this.panelContractEndDate.PerformLayout();
            this.panelContractDate.ResumeLayout(false);
            this.panelContractDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Cnclu;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxContractNo;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContractEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxYearED;
        private System.Windows.Forms.ComboBox comboBoxDayED;
        private System.Windows.Forms.ComboBox comboBoxMonthED;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelContractDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxYearBD;
        private System.Windows.Forms.ComboBox comboBoxDayBD;
        private System.Windows.Forms.ComboBox comboBoxMonthBD;
        public System.Windows.Forms.Label label4;
    }
}