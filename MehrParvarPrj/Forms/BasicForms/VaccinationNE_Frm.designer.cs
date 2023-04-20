namespace MehrParvarPrj
{
    partial class VaccinationNE_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinationNE_Frm));
            this.ribbonBar_Cnclu = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.textBox_VaccinationDsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel_Check = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.ribbonBar_Cnclu.Location = new System.Drawing.Point(0, 55);
            this.ribbonBar_Cnclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Cnclu.Name = "ribbonBar_Cnclu";
            this.ribbonBar_Cnclu.Size = new System.Drawing.Size(349, 62);
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
            // textBox_VaccinationDsc
            // 
            this.textBox_VaccinationDsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_VaccinationDsc.Border.Class = "TextBoxBorder";
            this.textBox_VaccinationDsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_VaccinationDsc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_VaccinationDsc.ForeColor = System.Drawing.Color.Black;
            this.textBox_VaccinationDsc.Location = new System.Drawing.Point(4, 9);
            this.textBox_VaccinationDsc.MaxLength = 100;
            this.textBox_VaccinationDsc.Name = "textBox_VaccinationDsc";
            this.textBox_VaccinationDsc.Size = new System.Drawing.Size(222, 21);
            this.textBox_VaccinationDsc.TabIndex = 0;
            // 
            // groupPanel_Check
            // 
            this.groupPanel_Check.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Check.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Check.Controls.Add(this.textBox_VaccinationDsc);
            this.groupPanel_Check.Controls.Add(this.label3);
            this.groupPanel_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_Check.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_Check.IsShadowEnabled = true;
            this.groupPanel_Check.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Check.Name = "groupPanel_Check";
            this.groupPanel_Check.Size = new System.Drawing.Size(349, 55);
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
            this.groupPanel_Check.Text = "واکسیناسیون";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(237, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 325;
            this.label3.Text = "عنوان واکسیناسیون:";
            // 
            // VaccinationNE_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 117);
            this.Controls.Add(this.groupPanel_Check);
            this.Controls.Add(this.ribbonBar_Cnclu);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(877, 155);
            this.MinimumSize = new System.Drawing.Size(264, 155);
            this.Name = "VaccinationNE_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت واکسیناسیونها";
            this.Load += new System.EventHandler(this.VaccinationNE_Frm_Load);
            this.groupPanel_Check.ResumeLayout(false);
            this.groupPanel_Check.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Cnclu;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_VaccinationDsc;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Check;
        private System.Windows.Forms.Label label3;
    }
}