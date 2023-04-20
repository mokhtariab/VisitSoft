namespace MehrParvarPrj.UserControls
{
    partial class StateDrugs_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateDrugs_UC));
            this.buttonDelete = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUseAmount = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNeedBackDsc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkNeedBack = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.buttonDrugsId = new DevComponents.DotNetBar.ButtonX();
            this.textBoxDrugsId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(796, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(32, 29);
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "داروی مصرفی:";
            // 
            // comboBoxUseAmount
            // 
            this.comboBoxUseAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUseAmount.DropDownWidth = 150;
            this.comboBoxUseAmount.FormattingEnabled = true;
            this.comboBoxUseAmount.Location = new System.Drawing.Point(301, 8);
            this.comboBoxUseAmount.Name = "comboBoxUseAmount";
            this.comboBoxUseAmount.Size = new System.Drawing.Size(173, 21);
            this.comboBoxUseAmount.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "میزان مصرف:";
            // 
            // comboBoxNeedBackDsc
            // 
            this.comboBoxNeedBackDsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNeedBackDsc.DropDownWidth = 250;
            this.comboBoxNeedBackDsc.FormattingEnabled = true;
            this.comboBoxNeedBackDsc.Location = new System.Drawing.Point(8, 8);
            this.comboBoxNeedBackDsc.Name = "comboBoxNeedBackDsc";
            this.comboBoxNeedBackDsc.Size = new System.Drawing.Size(187, 21);
            this.comboBoxNeedBackDsc.TabIndex = 71;
            this.comboBoxNeedBackDsc.Visible = false;
            // 
            // chkNeedBack
            // 
            this.chkNeedBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNeedBack.AutoSize = true;
            this.chkNeedBack.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkNeedBack.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkNeedBack.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkNeedBack.Location = new System.Drawing.Point(197, 10);
            this.chkNeedBack.Name = "chkNeedBack";
            this.chkNeedBack.Size = new System.Drawing.Size(97, 16);
            this.chkNeedBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.chkNeedBack.TabIndex = 72;
            this.chkNeedBack.Text = "نیاز به ارجاع دارد";
            this.chkNeedBack.CheckedChanged += new System.EventHandler(this.chkNeedBack_CheckedChanged);
            // 
            // buttonDrugsIdsId
            // 
            this.buttonDrugsId.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDrugsId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDrugsId.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonDrugsId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonDrugsId.Location = new System.Drawing.Point(548, 8);
            this.buttonDrugsId.Name = "buttonDrugsId";
            this.buttonDrugsId.Size = new System.Drawing.Size(27, 21);
            this.buttonDrugsId.TabIndex = 75;
            this.buttonDrugsId.Text = "...";
            this.buttonDrugsId.Click += new System.EventHandler(this.buttonDrugsIdsId_Click);
            // 
            // textBoxDrugsId
            // 
            this.textBoxDrugsId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxDrugsId.Border.Class = "TextBoxBorder";
            this.textBoxDrugsId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDrugsId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxDrugsId.ForeColor = System.Drawing.Color.Black;
            this.textBoxDrugsId.Location = new System.Drawing.Point(577, 8);
            this.textBoxDrugsId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDrugsId.MaxLength = 50;
            this.textBoxDrugsId.Name = "textBoxDrugsId";
            this.textBoxDrugsId.ReadOnly = true;
            this.textBoxDrugsId.Size = new System.Drawing.Size(134, 21);
            this.textBoxDrugsId.TabIndex = 74;
            // 
            // StateDrugs_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonDrugsId);
            this.Controls.Add(this.textBoxDrugsId);
            this.Controls.Add(this.chkNeedBack);
            this.Controls.Add(this.comboBoxNeedBackDsc);
            this.Controls.Add(this.comboBoxUseAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StateDrugs_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(831, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonDelete;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxUseAmount;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxNeedBackDsc;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkNeedBack;
        private DevComponents.DotNetBar.ButtonX buttonDrugsId;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDrugsId;
    }
}
