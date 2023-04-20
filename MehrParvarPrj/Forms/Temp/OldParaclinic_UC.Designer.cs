namespace MehrParvarPrj.UserControls
{
    partial class OldParaclinic_UC
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
            this.chkParaclinics = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.textBoxVisitStateParaclinicDsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBoxParaclinicsState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.SuspendLayout();
            // 
            // chkParaclinics
            // 
            this.chkParaclinics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkParaclinics.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkParaclinics.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkParaclinics.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkParaclinics.Location = new System.Drawing.Point(325, 2);
            this.chkParaclinics.Name = "chkParaclinics";
            this.chkParaclinics.Size = new System.Drawing.Size(142, 20);
            this.chkParaclinics.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.chkParaclinics.TabIndex = 64;
            this.chkParaclinics.Text = "DBA";
            this.chkParaclinics.TextColor = System.Drawing.Color.Maroon;
            this.chkParaclinics.CheckedChanged += new System.EventHandler(this.chkStateSichness_CheckedChanged);
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
            this.textBoxVisitStateParaclinicDsc.Location = new System.Drawing.Point(5, 2);
            this.textBoxVisitStateParaclinicDsc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVisitStateParaclinicDsc.MaxLength = 4000;
            this.textBoxVisitStateParaclinicDsc.Name = "textBoxVisitStateParaclinicDsc";
            this.textBoxVisitStateParaclinicDsc.Size = new System.Drawing.Size(200, 21);
            this.textBoxVisitStateParaclinicDsc.TabIndex = 1;
            this.textBoxVisitStateParaclinicDsc.Visible = false;
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
            this.comboBoxParaclinicsState.Location = new System.Drawing.Point(211, 1);
            this.comboBoxParaclinicsState.Name = "comboBoxParaclinicsState";
            this.comboBoxParaclinicsState.Size = new System.Drawing.Size(113, 21);
            this.comboBoxParaclinicsState.TabIndex = 65;
            this.comboBoxParaclinicsState.Visible = false;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Abnormal";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Normal";
            // 
            // OldParaclinic_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.comboBoxParaclinicsState);
            this.Controls.Add(this.chkParaclinics);
            this.Controls.Add(this.textBoxVisitStateParaclinicDsc);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "OldParaclinic_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(471, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxVisitStateParaclinicDsc;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkParaclinics;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxParaclinicsState;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
    }
}
