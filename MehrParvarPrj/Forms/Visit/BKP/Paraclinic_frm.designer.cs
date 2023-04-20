namespace MehrParvarPrj
{
    partial class Paraclinic_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paraclinic_frm));
            this.ribbonBar_Cnclu = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel_All = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonAddParaclinics = new DevComponents.DotNetBar.ButtonX();
            this.buttonCuVisit = new DevComponents.DotNetBar.ButtonX();
            this.textBoxVisitCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVisitDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonNextVisit = new DevComponents.DotNetBar.ButtonX();
            this.buttonPreVisit = new DevComponents.DotNetBar.ButtonX();
            this.label_Date = new System.Windows.Forms.Label();
            this.tableLayoutPanelVisit = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel_All.SuspendLayout();
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
            this.ribbonBar_Cnclu.Location = new System.Drawing.Point(0, 431);
            this.ribbonBar_Cnclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Cnclu.Name = "ribbonBar_Cnclu";
            this.ribbonBar_Cnclu.Size = new System.Drawing.Size(849, 63);
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
            // groupPanel_All
            // 
            this.groupPanel_All.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_All.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_All.Controls.Add(this.buttonAddParaclinics);
            this.groupPanel_All.Controls.Add(this.buttonCuVisit);
            this.groupPanel_All.Controls.Add(this.textBoxVisitCode);
            this.groupPanel_All.Controls.Add(this.label1);
            this.groupPanel_All.Controls.Add(this.textBoxVisitDate);
            this.groupPanel_All.Controls.Add(this.buttonNextVisit);
            this.groupPanel_All.Controls.Add(this.buttonPreVisit);
            this.groupPanel_All.Controls.Add(this.label_Date);
            this.groupPanel_All.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel_All.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_All.IsShadowEnabled = true;
            this.groupPanel_All.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_All.Name = "groupPanel_All";
            this.groupPanel_All.Size = new System.Drawing.Size(849, 52);
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
            this.groupPanel_All.Text = "مشخصات ویزیت";
            // 
            // buttonAddParaclinics
            // 
            this.buttonAddParaclinics.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAddParaclinics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddParaclinics.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonAddParaclinics.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonAddParaclinics.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddParaclinics.Image")));
            this.buttonAddParaclinics.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonAddParaclinics.Location = new System.Drawing.Point(463, -1);
            this.buttonAddParaclinics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddParaclinics.Name = "buttonAddParaclinics";
            this.buttonAddParaclinics.Size = new System.Drawing.Size(68, 26);
            this.buttonAddParaclinics.TabIndex = 72;
            this.buttonAddParaclinics.Text = "اضافه";
            this.buttonAddParaclinics.TextColor = System.Drawing.Color.Black;
            this.buttonAddParaclinics.Click += new System.EventHandler(this.buttonAddParaclinics_Click);
            // 
            // buttonCuVisit
            // 
            this.buttonCuVisit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCuVisit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCuVisit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonCuVisit.Image = ((System.Drawing.Image)(resources.GetObject("buttonCuVisit.Image")));
            this.buttonCuVisit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonCuVisit.Location = new System.Drawing.Point(186, 0);
            this.buttonCuVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCuVisit.Name = "buttonCuVisit";
            this.buttonCuVisit.Size = new System.Drawing.Size(85, 26);
            this.buttonCuVisit.TabIndex = 69;
            this.buttonCuVisit.Text = "ویزیت فعلی";
            this.buttonCuVisit.TextColor = System.Drawing.Color.Black;
            this.buttonCuVisit.Click += new System.EventHandler(this.buttonCuVisit_Click);
            // 
            // textBoxVisitCode
            // 
            this.textBoxVisitCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxVisitCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxVisitCode.Location = new System.Drawing.Point(537, 3);
            this.textBoxVisitCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVisitCode.Name = "textBoxVisitCode";
            this.textBoxVisitCode.ReadOnly = true;
            this.textBoxVisitCode.Size = new System.Drawing.Size(47, 14);
            this.textBoxVisitCode.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(585, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "کد:";
            // 
            // textBoxVisitDate
            // 
            this.textBoxVisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxVisitDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxVisitDate.Location = new System.Drawing.Point(613, 3);
            this.textBoxVisitDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVisitDate.Name = "textBoxVisitDate";
            this.textBoxVisitDate.ReadOnly = true;
            this.textBoxVisitDate.Size = new System.Drawing.Size(154, 14);
            this.textBoxVisitDate.TabIndex = 66;
            // 
            // buttonNextVisit
            // 
            this.buttonNextVisit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonNextVisit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonNextVisit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonNextVisit.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextVisit.Image")));
            this.buttonNextVisit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonNextVisit.Location = new System.Drawing.Point(9, 0);
            this.buttonNextVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextVisit.Name = "buttonNextVisit";
            this.buttonNextVisit.Size = new System.Drawing.Size(85, 26);
            this.buttonNextVisit.TabIndex = 65;
            this.buttonNextVisit.Text = "ویزیت بعدی";
            this.buttonNextVisit.TextColor = System.Drawing.Color.Black;
            this.buttonNextVisit.Click += new System.EventHandler(this.buttonNextVisit_Click);
            // 
            // buttonPreVisit
            // 
            this.buttonPreVisit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPreVisit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPreVisit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonPreVisit.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreVisit.Image")));
            this.buttonPreVisit.Location = new System.Drawing.Point(98, 0);
            this.buttonPreVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreVisit.Name = "buttonPreVisit";
            this.buttonPreVisit.Size = new System.Drawing.Size(85, 26);
            this.buttonPreVisit.TabIndex = 64;
            this.buttonPreVisit.Text = "ویزیت قبلی";
            this.buttonPreVisit.TextColor = System.Drawing.Color.Black;
            this.buttonPreVisit.Click += new System.EventHandler(this.buttonPreVisit_Click);
            // 
            // label_Date
            // 
            this.label_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.Color.Transparent;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Date.ForeColor = System.Drawing.Color.Black;
            this.label_Date.Location = new System.Drawing.Point(771, 7);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(61, 13);
            this.label_Date.TabIndex = 33;
            this.label_Date.Text = "تاریخ ویزیت:";
            // 
            // tableLayoutPanelVisit
            // 
            this.tableLayoutPanelVisit.AutoScroll = true;
            this.tableLayoutPanelVisit.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanelVisit.ColumnCount = 1;
            this.tableLayoutPanelVisit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVisit.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanelVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelVisit.Name = "tableLayoutPanelVisit";
            this.tableLayoutPanelVisit.RowCount = 1;
            this.tableLayoutPanelVisit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVisit.Size = new System.Drawing.Size(849, 379);
            this.tableLayoutPanelVisit.TabIndex = 6;
            // 
            // Paraclinic_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 494);
            this.Controls.Add(this.tableLayoutPanelVisit);
            this.Controls.Add(this.groupPanel_All);
            this.Controls.Add(this.ribbonBar_Cnclu);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Paraclinic_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "وضعیت پاراکلینک ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Paraclinic_frm_FormClosed);
            this.Load += new System.EventHandler(this.Paraclinic_frm_Load);
            this.groupPanel_All.ResumeLayout(false);
            this.groupPanel_All.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Cnclu;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_All;
        private System.Windows.Forms.Label label_Date;
        private DevComponents.DotNetBar.ButtonX buttonPreVisit;
        private DevComponents.DotNetBar.ButtonX buttonNextVisit;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxVisitDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVisit;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxVisitCode;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonCuVisit;
        private DevComponents.DotNetBar.ButtonX buttonAddParaclinics;
    }
}