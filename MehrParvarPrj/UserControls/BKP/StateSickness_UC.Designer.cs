namespace MehrParvarPrj.UserControls
{
    partial class StateSickness_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateSickness_UC));
            this.buttonDelete = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStateSicknessId = new DevComponents.DotNetBar.ButtonX();
            this.textBoxStateSicknessId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStateSicknessDsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(692, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(32, 29);
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "نوع بیماری:";
            // 
            // buttonStateSicknessId
            // 
            this.buttonStateSicknessId.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonStateSicknessId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStateSicknessId.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonStateSicknessId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonStateSicknessId.Location = new System.Drawing.Point(416, 8);
            this.buttonStateSicknessId.Name = "buttonStateSicknessId";
            this.buttonStateSicknessId.Size = new System.Drawing.Size(27, 21);
            this.buttonStateSicknessId.TabIndex = 75;
            this.buttonStateSicknessId.Text = "...";
            this.buttonStateSicknessId.Click += new System.EventHandler(this.buttonSicknessId_Click);
            // 
            // textBoxStateSicknessId
            // 
            this.textBoxStateSicknessId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxStateSicknessId.Border.Class = "TextBoxBorder";
            this.textBoxStateSicknessId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStateSicknessId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxStateSicknessId.ForeColor = System.Drawing.Color.Black;
            this.textBoxStateSicknessId.Location = new System.Drawing.Point(449, 8);
            this.textBoxStateSicknessId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStateSicknessId.MaxLength = 50;
            this.textBoxStateSicknessId.Name = "textBoxStateSicknessId";
            this.textBoxStateSicknessId.ReadOnly = true;
            this.textBoxStateSicknessId.Size = new System.Drawing.Size(162, 21);
            this.textBoxStateSicknessId.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "توضیح:";
            // 
            // textBoxStateSicknessDsc
            // 
            this.textBoxStateSicknessDsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxStateSicknessDsc.Border.Class = "TextBoxBorder";
            this.textBoxStateSicknessDsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxStateSicknessDsc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxStateSicknessDsc.ForeColor = System.Drawing.Color.Black;
            this.textBoxStateSicknessDsc.Location = new System.Drawing.Point(14, 9);
            this.textBoxStateSicknessDsc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStateSicknessDsc.MaxLength = 4000;
            this.textBoxStateSicknessDsc.Name = "textBoxStateSicknessDsc";
            this.textBoxStateSicknessDsc.Size = new System.Drawing.Size(327, 21);
            this.textBoxStateSicknessDsc.TabIndex = 77;
            // 
            // StateSickness_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStateSicknessDsc);
            this.Controls.Add(this.buttonStateSicknessId);
            this.Controls.Add(this.textBoxStateSicknessId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StateSickness_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(731, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonDelete;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonStateSicknessId;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStateSicknessId;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStateSicknessDsc;
    }
}
