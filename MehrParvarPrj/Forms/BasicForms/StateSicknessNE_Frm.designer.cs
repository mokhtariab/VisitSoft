namespace MehrParvarPrj
{
    partial class StateSicknessNE_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateSicknessNE_Frm));
            this.ribbonBar_Cnclu = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.textBox_StateSicknessName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel_Check = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStateSicknessMaster = new DevComponents.DotNetBar.ButtonX();
            this.textBox_StateSicknessMasterName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel_Check.SuspendLayout();
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
            this.ribbonBar_Cnclu.Location = new System.Drawing.Point(0, 111);
            this.ribbonBar_Cnclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Cnclu.Name = "ribbonBar_Cnclu";
            this.ribbonBar_Cnclu.Size = new System.Drawing.Size(385, 61);
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
            // textBox_StateSicknessName
            // 
            this.textBox_StateSicknessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_StateSicknessName.Border.Class = "TextBoxBorder";
            this.textBox_StateSicknessName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_StateSicknessName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_StateSicknessName.ForeColor = System.Drawing.Color.Black;
            this.textBox_StateSicknessName.Location = new System.Drawing.Point(16, 54);
            this.textBox_StateSicknessName.MaxLength = 100;
            this.textBox_StateSicknessName.Name = "textBox_StateSicknessName";
            this.textBox_StateSicknessName.Size = new System.Drawing.Size(243, 21);
            this.textBox_StateSicknessName.TabIndex = 0;
            // 
            // groupPanel_Check
            // 
            this.groupPanel_Check.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Check.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Check.Controls.Add(this.ButtonStateSicknessMaster);
            this.groupPanel_Check.Controls.Add(this.textBox_StateSicknessMasterName);
            this.groupPanel_Check.Controls.Add(this.textBox_StateSicknessName);
            this.groupPanel_Check.Controls.Add(this.label1);
            this.groupPanel_Check.Controls.Add(this.label3);
            this.groupPanel_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_Check.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_Check.IsShadowEnabled = true;
            this.groupPanel_Check.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Check.Name = "groupPanel_Check";
            this.groupPanel_Check.Size = new System.Drawing.Size(385, 111);
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
            this.groupPanel_Check.Text = "وضعیت بیماری";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(268, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 325;
            this.label3.Text = "عنوان وضعیت بیماری:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(268, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 325;
            this.label1.Text = "عنوان کلی بیماری:";
            // 
            // ButtonStateSicknessMaster
            // 
            this.ButtonStateSicknessMaster.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonStateSicknessMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStateSicknessMaster.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonStateSicknessMaster.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonStateSicknessMaster.Location = new System.Drawing.Point(16, 16);
            this.ButtonStateSicknessMaster.Name = "ButtonStateSicknessMaster";
            this.ButtonStateSicknessMaster.Size = new System.Drawing.Size(27, 21);
            this.ButtonStateSicknessMaster.TabIndex = 328;
            this.ButtonStateSicknessMaster.Text = "...";
            this.ButtonStateSicknessMaster.Click += new System.EventHandler(this.ButtonStateSicknessMaster_Click);
            // 
            // textBox_StateSicknessMasterName
            // 
            this.textBox_StateSicknessMasterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_StateSicknessMasterName.Border.Class = "TextBoxBorder";
            this.textBox_StateSicknessMasterName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_StateSicknessMasterName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_StateSicknessMasterName.ForeColor = System.Drawing.Color.Black;
            this.textBox_StateSicknessMasterName.Location = new System.Drawing.Point(49, 16);
            this.textBox_StateSicknessMasterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_StateSicknessMasterName.MaxLength = 50;
            this.textBox_StateSicknessMasterName.Name = "textBox_StateSicknessMasterName";
            this.textBox_StateSicknessMasterName.ReadOnly = true;
            this.textBox_StateSicknessMasterName.Size = new System.Drawing.Size(210, 21);
            this.textBox_StateSicknessMasterName.TabIndex = 327;
            // 
            // StateSicknessNE_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 172);
            this.Controls.Add(this.groupPanel_Check);
            this.Controls.Add(this.ribbonBar_Cnclu);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(877, 210);
            this.MinimumSize = new System.Drawing.Size(264, 210);
            this.Name = "StateSicknessNE_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت وضعیت بیماریها";
            this.Load += new System.EventHandler(this.StateSicknessNE_Frm_Load);
            this.groupPanel_Check.ResumeLayout(false);
            this.groupPanel_Check.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Cnclu;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_StateSicknessName;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX ButtonStateSicknessMaster;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_StateSicknessMasterName;
    }
}