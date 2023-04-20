namespace MehrParvarPrj.UserControls
{
    partial class Paraclinic_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paraclinic_UC));
            this.buttonDelete = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonParaclinicsId = new DevComponents.DotNetBar.ButtonX();
            this.textBoxParaclinicsId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBoxParaclinicsState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.textBoxVisitStateParaclinicDsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
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
            this.label1.Location = new System.Drawing.Point(717, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "پاراکلینیک:";
            // 
            // buttonParaclinicsId
            // 
            this.buttonParaclinicsId.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonParaclinicsId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParaclinicsId.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonParaclinicsId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonParaclinicsId.Location = new System.Drawing.Point(548, 8);
            this.buttonParaclinicsId.Name = "buttonParaclinicsId";
            this.buttonParaclinicsId.Size = new System.Drawing.Size(27, 21);
            this.buttonParaclinicsId.TabIndex = 75;
            this.buttonParaclinicsId.Text = "...";
            this.buttonParaclinicsId.Click += new System.EventHandler(this.buttonParaclinicsId_Click);
            // 
            // textBoxParaclinicsId
            // 
            this.textBoxParaclinicsId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxParaclinicsId.Border.Class = "TextBoxBorder";
            this.textBoxParaclinicsId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxParaclinicsId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxParaclinicsId.ForeColor = System.Drawing.Color.Black;
            this.textBoxParaclinicsId.Location = new System.Drawing.Point(577, 8);
            this.textBoxParaclinicsId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxParaclinicsId.MaxLength = 50;
            this.textBoxParaclinicsId.Name = "textBoxParaclinicsId";
            this.textBoxParaclinicsId.ReadOnly = true;
            this.textBoxParaclinicsId.Size = new System.Drawing.Size(134, 21);
            this.textBoxParaclinicsId.TabIndex = 74;
            // 
            // comboBoxParaclinicsState
            // 
            this.comboBoxParaclinicsState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxParaclinicsState.DisplayMember = "text";
            this.comboBoxParaclinicsState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxParaclinicsState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParaclinicsState.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParaclinicsState.ItemHeight = 15;
            this.comboBoxParaclinicsState.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.comboBoxParaclinicsState.Location = new System.Drawing.Point(414, 9);
            this.comboBoxParaclinicsState.Name = "comboBoxParaclinicsState";
            this.comboBoxParaclinicsState.Size = new System.Drawing.Size(113, 21);
            this.comboBoxParaclinicsState.TabIndex = 77;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Abnormal";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Normal";
            // 
            // textBoxVisitStateParaclinicDsc
            // 
            this.textBoxVisitStateParaclinicDsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxVisitStateParaclinicDsc.Border.Class = "TextBoxBorder";
            this.textBoxVisitStateParaclinicDsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxVisitStateParaclinicDsc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxVisitStateParaclinicDsc.ForeColor = System.Drawing.Color.Black;
            this.textBoxVisitStateParaclinicDsc.Location = new System.Drawing.Point(8, 9);
            this.textBoxVisitStateParaclinicDsc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVisitStateParaclinicDsc.MaxLength = 4000;
            this.textBoxVisitStateParaclinicDsc.Name = "textBoxVisitStateParaclinicDsc";
            this.textBoxVisitStateParaclinicDsc.Size = new System.Drawing.Size(354, 21);
            this.textBoxVisitStateParaclinicDsc.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "توضیح:";
            // 
            // Paraclinic_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxParaclinicsState);
            this.Controls.Add(this.textBoxVisitStateParaclinicDsc);
            this.Controls.Add(this.buttonParaclinicsId);
            this.Controls.Add(this.textBoxParaclinicsId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Paraclinic_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(831, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonDelete;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonParaclinicsId;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxParaclinicsId;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxParaclinicsState;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxVisitStateParaclinicDsc;
        private System.Windows.Forms.Label label3;
    }
}
