namespace MehrParvarPrj
{
    partial class ExportExcelVisit_Uc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportExcelVisit_Uc));
            this.buttonImport = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPatientID = new DevComponents.DotNetBar.ButtonX();
            this.textBoxPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.listViewErrore = new System.Windows.Forms.ListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gridControl_ImportExcel = new DevExpress.XtraGrid.GridControl();
            this.gridView_ImportExcel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ImportExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ImportExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonImport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.Image = ((System.Drawing.Image)(resources.GetObject("buttonImport.Image")));
            this.buttonImport.Location = new System.Drawing.Point(65, 10);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(163, 44);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "ثبت در بانک اطلاعاتی";
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonPatientID);
            this.panel2.Controls.Add(this.textBoxPatientID);
            this.panel2.Controls.Add(this.buttonImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 64);
            this.panel2.TabIndex = 298;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "نام شیت اکسل:";
            // 
            // buttonPatientID
            // 
            this.buttonPatientID.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPatientID.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPatientID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonPatientID.Location = new System.Drawing.Point(451, 25);
            this.buttonPatientID.Name = "buttonPatientID";
            this.buttonPatientID.Size = new System.Drawing.Size(33, 21);
            this.buttonPatientID.TabIndex = 72;
            this.buttonPatientID.Text = "...";
            this.buttonPatientID.Click += new System.EventHandler(this.buttonPatientID_Click);
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPatientID.ForeColor = System.Drawing.Color.Black;
            this.textBoxPatientID.Location = new System.Drawing.Point(489, 25);
            this.textBoxPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPatientID.MaxLength = 50;
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(114, 21);
            this.textBoxPatientID.TabIndex = 71;
            this.textBoxPatientID.Text = "Visit";
            // 
            // listViewErrore
            // 
            this.listViewErrore.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewErrore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewErrore.FullRowSelect = true;
            this.listViewErrore.GridLines = true;
            this.listViewErrore.Location = new System.Drawing.Point(0, 490);
            this.listViewErrore.Name = "listViewErrore";
            this.listViewErrore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewErrore.RightToLeftLayout = true;
            this.listViewErrore.Size = new System.Drawing.Size(784, 49);
            this.listViewErrore.TabIndex = 300;
            this.listViewErrore.UseCompatibleStateImageBehavior = false;
            this.listViewErrore.View = System.Windows.Forms.View.List;
            this.listViewErrore.DoubleClick += new System.EventHandler(this.listViewErrore_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 487);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(784, 3);
            this.splitter1.TabIndex = 302;
            this.splitter1.TabStop = false;
            // 
            // gridControl_ImportExcel
            // 
            this.gridControl_ImportExcel.AllowDrop = true;
            this.gridControl_ImportExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ImportExcel.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_ImportExcel.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_ImportExcel.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_ImportExcel.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_ImportExcel.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_ImportExcel.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_ImportExcel.Location = new System.Drawing.Point(0, 64);
            this.gridControl_ImportExcel.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_ImportExcel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_ImportExcel.MainView = this.gridView_ImportExcel;
            this.gridControl_ImportExcel.Name = "gridControl_ImportExcel";
            this.gridControl_ImportExcel.Size = new System.Drawing.Size(784, 409);
            this.gridControl_ImportExcel.TabIndex = 303;
            this.gridControl_ImportExcel.UseEmbeddedNavigator = true;
            this.gridControl_ImportExcel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ImportExcel});
            // 
            // gridView_ImportExcel
            // 
            this.gridView_ImportExcel.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView_ImportExcel.GridControl = this.gridControl_ImportExcel;
            this.gridView_ImportExcel.Name = "gridView_ImportExcel";
            this.gridView_ImportExcel.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_ImportExcel.OptionsCustomization.AllowGroup = false;
            this.gridView_ImportExcel.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_ImportExcel.OptionsFilter.AllowFilterEditor = false;
            this.gridView_ImportExcel.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_ImportExcel.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_ImportExcel.OptionsLayout.StoreAllOptions = true;
            this.gridView_ImportExcel.OptionsLayout.StoreAppearance = true;
            this.gridView_ImportExcel.OptionsPrint.ExpandAllGroups = false;
            this.gridView_ImportExcel.OptionsSelection.MultiSelect = true;
            this.gridView_ImportExcel.OptionsView.ColumnAutoWidth = false;
            this.gridView_ImportExcel.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView_ImportExcel.OptionsView.ShowAutoFilterRow = true;
            this.gridView_ImportExcel.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_ImportExcel.OptionsView.ShowFooter = true;
            this.gridView_ImportExcel.OptionsView.ShowGroupPanel = false;
            this.gridView_ImportExcel.OptionsView.ShowIndicator = false;
            this.gridView_ImportExcel.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_ImportExcel_CustomUnboundColumnData);
            this.gridView_ImportExcel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_ImportExcel_KeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(784, 14);
            this.label2.TabIndex = 304;
            this.label2.Text = "اشکالات ثبتی";
            // 
            // ExportExcelVisit_Uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_ImportExcel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listViewErrore);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExportExcelVisit_Uc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(784, 539);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ImportExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ImportExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonImport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewErrore;
        private System.Windows.Forms.Splitter splitter1;
        private DevComponents.DotNetBar.ButtonX buttonPatientID;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPatientID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl_ImportExcel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ImportExcel;
        private System.Windows.Forms.Label label2;
    }
}
