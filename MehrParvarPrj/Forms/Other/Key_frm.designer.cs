namespace MehrParvarPrj
{
    partial class Key_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Key_frm));
            this.panelEx_Users = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.textBoxKey = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridView_SelectPerson = new System.Windows.Forms.DataGridView();
            this.KeyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelectPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx_Users
            // 
            this.panelEx_Users.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEx_Users.Controls.Add(this.label1);
            this.panelEx_Users.Controls.Add(this.btnDel);
            this.panelEx_Users.Controls.Add(this.btnNew);
            this.panelEx_Users.Controls.Add(this.textBoxKey);
            this.panelEx_Users.Controls.Add(this.dataGridView_SelectPerson);
            this.panelEx_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx_Users.Location = new System.Drawing.Point(0, 0);
            this.panelEx_Users.Margin = new System.Windows.Forms.Padding(0);
            this.panelEx_Users.Name = "panelEx_Users";
            this.panelEx_Users.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelEx_Users.ShowFocusRectangle = true;
            this.panelEx_Users.Size = new System.Drawing.Size(381, 488);
            this.panelEx_Users.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_Users.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx_Users.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeText;
            this.panelEx_Users.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_Users.Style.BorderColor.Color = System.Drawing.Color.Olive;
            this.panelEx_Users.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_Users.Style.GradientAngle = 90;
            this.panelEx_Users.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(291, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "متن مورد نظر:";
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Location = new System.Drawing.Point(27, 39);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(46, 21);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "حذف -";
            this.btnDel.Tooltip = "جدید";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(27, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(46, 21);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "اضافه +";
            this.btnNew.Tooltip = "اضافه";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.textBoxKey.Border.Class = "TextBoxBorder";
            this.textBoxKey.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxKey.ForeColor = System.Drawing.Color.Black;
            this.textBoxKey.Location = new System.Drawing.Point(79, 12);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(210, 47);
            this.textBoxKey.TabIndex = 13;
            // 
            // dataGridView_SelectPerson
            // 
            this.dataGridView_SelectPerson.AllowUserToAddRows = false;
            this.dataGridView_SelectPerson.AllowUserToDeleteRows = false;
            this.dataGridView_SelectPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SelectPerson.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SelectPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_SelectPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SelectPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyCode,
            this.KeyDsc});
            this.dataGridView_SelectPerson.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_SelectPerson.Location = new System.Drawing.Point(27, 67);
            this.dataGridView_SelectPerson.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_SelectPerson.Name = "dataGridView_SelectPerson";
            this.dataGridView_SelectPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_SelectPerson.RowHeadersVisible = false;
            this.dataGridView_SelectPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SelectPerson.Size = new System.Drawing.Size(327, 396);
            this.dataGridView_SelectPerson.TabIndex = 10;
            this.dataGridView_SelectPerson.DoubleClick += new System.EventHandler(this.dataGridView_SelectPerson_DoubleClick);
            // 
            // KeyCode
            // 
            this.KeyCode.DataPropertyName = "KeyCode";
            this.KeyCode.HeaderText = "کد";
            this.KeyCode.Name = "KeyCode";
            this.KeyCode.Visible = false;
            // 
            // KeyDsc
            // 
            this.KeyDsc.DataPropertyName = "KeyDsc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KeyDsc.DefaultCellStyle = dataGridViewCellStyle2;
            this.KeyDsc.HeaderText = "متن";
            this.KeyDsc.Name = "KeyDsc";
            this.KeyDsc.Width = 300;
            // 
            // Key_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 488);
            this.Controls.Add(this.panelEx_Users);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Key_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "جملات کلیدی";
            this.Load += new System.EventHandler(this.Key_frm_Load);
            this.panelEx_Users.ResumeLayout(false);
            this.panelEx_Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelectPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx_Users;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxKey;
        private System.Windows.Forms.DataGridView dataGridView_SelectPerson;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyDsc;
    }
}