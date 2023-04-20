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
            this.textBoxVisitStateParaclinicDsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBoxParaclinicsState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.buttonDelete = new DevComponents.DotNetBar.ButtonX();
            this.buttonParaclinic = new DevComponents.DotNetBar.ButtonX();
            this.textBoxParaclinic = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.textBoxVisitStateParaclinicDsc.Size = new System.Drawing.Size(248, 21);
            this.textBoxVisitStateParaclinicDsc.TabIndex = 1;
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
            this.comboBoxParaclinicsState.Location = new System.Drawing.Point(259, 1);
            this.comboBoxParaclinicsState.Name = "comboBoxParaclinicsState";
            this.comboBoxParaclinicsState.Size = new System.Drawing.Size(113, 21);
            this.comboBoxParaclinicsState.TabIndex = 65;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Abnormal";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Normal";
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(638, 1);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(25, 23);
            this.buttonDelete.TabIndex = 77;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonParaclinic
            // 
            this.buttonParaclinic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonParaclinic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParaclinic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonParaclinic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonParaclinic.Location = new System.Drawing.Point(378, 3);
            this.buttonParaclinic.Name = "buttonParaclinic";
            this.buttonParaclinic.Size = new System.Drawing.Size(27, 21);
            this.buttonParaclinic.TabIndex = 82;
            this.buttonParaclinic.Text = "...";
            this.buttonParaclinic.Click += new System.EventHandler(this.buttonParaclinic_Click);
            // 
            // textBoxParaclinic
            // 
            this.textBoxParaclinic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxParaclinic.Border.Class = "TextBoxBorder";
            this.textBoxParaclinic.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxParaclinic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxParaclinic.ForeColor = System.Drawing.Color.Black;
            this.textBoxParaclinic.Location = new System.Drawing.Point(407, 2);
            this.textBoxParaclinic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxParaclinic.MaxLength = 50;
            this.textBoxParaclinic.Name = "textBoxParaclinic";
            this.textBoxParaclinic.ReadOnly = true;
            this.textBoxParaclinic.Size = new System.Drawing.Size(134, 21);
            this.textBoxParaclinic.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "عنوان پاراکلینیک:";
            // 
            // Paraclinic_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonParaclinic);
            this.Controls.Add(this.textBoxParaclinic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxParaclinicsState);
            this.Controls.Add(this.textBoxVisitStateParaclinicDsc);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Paraclinic_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(671, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxVisitStateParaclinicDsc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxParaclinicsState;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.ButtonX buttonDelete;
        private DevComponents.DotNetBar.ButtonX buttonParaclinic;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxParaclinic;
        private System.Windows.Forms.Label label1;
    }
}
