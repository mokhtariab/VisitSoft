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
            this.textBoxStateSicknessDsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonSickness = new DevComponents.DotNetBar.ButtonX();
            this.textBoxSickness = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
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
            this.textBoxStateSicknessDsc.Location = new System.Drawing.Point(5, 2);
            this.textBoxStateSicknessDsc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStateSicknessDsc.MaxLength = 4000;
            this.textBoxStateSicknessDsc.Name = "textBoxStateSicknessDsc";
            this.textBoxStateSicknessDsc.Size = new System.Drawing.Size(475, 21);
            this.textBoxStateSicknessDsc.TabIndex = 1;
            // 
            // buttonSickness
            // 
            this.buttonSickness.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSickness.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonSickness.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonSickness.Location = new System.Drawing.Point(486, 3);
            this.buttonSickness.Name = "buttonSickness";
            this.buttonSickness.Size = new System.Drawing.Size(27, 21);
            this.buttonSickness.TabIndex = 79;
            this.buttonSickness.Text = "...";
            this.buttonSickness.Click += new System.EventHandler(this.buttonSickness_Click);
            // 
            // textBoxSickness
            // 
            this.textBoxSickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxSickness.Border.Class = "TextBoxBorder";
            this.textBoxSickness.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxSickness.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxSickness.ForeColor = System.Drawing.Color.Black;
            this.textBoxSickness.Location = new System.Drawing.Point(515, 2);
            this.textBoxSickness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSickness.MaxLength = 50;
            this.textBoxSickness.Name = "textBoxSickness";
            this.textBoxSickness.ReadOnly = true;
            this.textBoxSickness.Size = new System.Drawing.Size(134, 21);
            this.textBoxSickness.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "نام بیماری:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(718, 1);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(25, 23);
            this.buttonDelete.TabIndex = 76;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // StateSickness_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonSickness);
            this.Controls.Add(this.textBoxSickness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxStateSicknessDsc);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "StateSickness_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(744, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxStateSicknessDsc;
        private DevComponents.DotNetBar.ButtonX buttonSickness;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxSickness;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonDelete;
    }
}
