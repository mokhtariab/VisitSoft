namespace MehrParvarPrj.UserControls
{
    partial class StateVaccination_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateVaccination_UC));
            this.buttonDelete = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVaccination = new DevComponents.DotNetBar.ButtonX();
            this.textBoxVaccination = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nUpDownFew = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownFew)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(531, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(32, 29);
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "نوع واکسن:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "تعداد:";
            // 
            // buttonVaccination
            // 
            this.buttonVaccination.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonVaccination.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonVaccination.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonVaccination.Location = new System.Drawing.Point(206, 7);
            this.buttonVaccination.Name = "buttonVaccination";
            this.buttonVaccination.Size = new System.Drawing.Size(27, 21);
            this.buttonVaccination.TabIndex = 75;
            this.buttonVaccination.Text = "...";
            this.buttonVaccination.Click += new System.EventHandler(this.buttonVaccinationId_Click);
            // 
            // textBoxVaccination
            // 
            this.textBoxVaccination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxVaccination.Border.Class = "TextBoxBorder";
            this.textBoxVaccination.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxVaccination.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxVaccination.ForeColor = System.Drawing.Color.Black;
            this.textBoxVaccination.Location = new System.Drawing.Point(239, 8);
            this.textBoxVaccination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVaccination.MaxLength = 50;
            this.textBoxVaccination.Name = "textBoxVaccination";
            this.textBoxVaccination.ReadOnly = true;
            this.textBoxVaccination.Size = new System.Drawing.Size(207, 21);
            this.textBoxVaccination.TabIndex = 74;
            // 
            // nUpDownFew
            // 
            this.nUpDownFew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nUpDownFew.ForeColor = System.Drawing.Color.Black;
            this.nUpDownFew.Location = new System.Drawing.Point(11, 7);
            this.nUpDownFew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownFew.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUpDownFew.Name = "nUpDownFew";
            this.nUpDownFew.Size = new System.Drawing.Size(149, 22);
            this.nUpDownFew.TabIndex = 76;
            this.nUpDownFew.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // StateVaccination_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nUpDownFew);
            this.Controls.Add(this.buttonVaccination);
            this.Controls.Add(this.textBoxVaccination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StateVaccination_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(566, 38);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownFew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX buttonVaccination;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxVaccination;
        private System.Windows.Forms.NumericUpDown nUpDownFew;
    }
}
