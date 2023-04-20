namespace MehrParvarPrj
{
    partial class PatientTypeList_Frm
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientTypeList_Frm));
            this.gridControl_PatientTypeList = new DevExpress.XtraGrid.GridControl();
            this.gridView_PatientTypeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PatientTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientTypeDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddPatientType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditPatientType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelPatientType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemPatientTypePrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PatientTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PatientTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_PatientTypeList
            // 
            this.gridControl_PatientTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_PatientTypeList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_PatientTypeList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_PatientTypeList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_PatientTypeList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_PatientTypeList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_PatientTypeList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_PatientTypeList.MainView = this.gridView_PatientTypeList;
            this.gridControl_PatientTypeList.Name = "gridControl_PatientTypeList";
            this.gridControl_PatientTypeList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_PatientTypeList.TabIndex = 40;
            this.gridControl_PatientTypeList.UseEmbeddedNavigator = true;
            this.gridControl_PatientTypeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PatientTypeList});
            // 
            // gridView_PatientTypeList
            // 
            this.gridView_PatientTypeList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_PatientTypeList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_PatientTypeList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_PatientTypeList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_PatientTypeList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_PatientTypeList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_PatientTypeList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_PatientTypeList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_PatientTypeList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_PatientTypeList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_PatientTypeList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_PatientTypeList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_PatientTypeList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_PatientTypeList.ColumnPanelRowHeight = 25;
            this.gridView_PatientTypeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PatientTypeId,
            this.PatientTypeDsc});
            this.gridView_PatientTypeList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_PatientTypeList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_PatientTypeList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_PatientTypeList.GridControl = this.gridControl_PatientTypeList;
            this.gridView_PatientTypeList.Name = "gridView_PatientTypeList";
            this.gridView_PatientTypeList.OptionsBehavior.Editable = false;
            this.gridView_PatientTypeList.OptionsCustomization.AllowGroup = false;
            this.gridView_PatientTypeList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_PatientTypeList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_PatientTypeList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_PatientTypeList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_PatientTypeList.OptionsLayout.StoreAllOptions = true;
            this.gridView_PatientTypeList.OptionsLayout.StoreAppearance = true;
            this.gridView_PatientTypeList.OptionsPrint.PrintPreview = true;
            this.gridView_PatientTypeList.OptionsPrint.UsePrintStyles = true;
            this.gridView_PatientTypeList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_PatientTypeList.OptionsView.ShowFooter = true;
            this.gridView_PatientTypeList.OptionsView.ShowGroupPanel = false;
            this.gridView_PatientTypeList.OptionsView.ShowIndicator = false;
            this.gridView_PatientTypeList.PaintStyleName = "Skin";
            this.gridView_PatientTypeList.RowHeight = 20;
            this.gridView_PatientTypeList.DoubleClick += new System.EventHandler(this.buttonItemEditPatientType_Click);
            // 
            // PatientTypeId
            // 
            this.PatientTypeId.Caption = "کد نسبت";
            this.PatientTypeId.FieldName = "PatientTypeId";
            this.PatientTypeId.Name = "PatientTypeId";
            this.PatientTypeId.Visible = true;
            this.PatientTypeId.VisibleIndex = 1;
            this.PatientTypeId.Width = 100;
            // 
            // PatientTypeDsc
            // 
            this.PatientTypeDsc.Caption = "عنوان نسبت";
            this.PatientTypeDsc.FieldName = "PatientTypeDsc";
            this.PatientTypeDsc.Name = "PatientTypeDsc";
            this.PatientTypeDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.PatientTypeDsc.Visible = true;
            this.PatientTypeDsc.VisibleIndex = 0;
            this.PatientTypeDsc.Width = 426;
            // 
            // itemPanelCarSubRP
            // 
            // 
            // 
            // 
            this.itemPanelCarSubRP.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.itemPanelCarSubRP.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.itemPanelCarSubRP.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanelCarSubRP.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanelCarSubRP.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanelCarSubRP.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingRight = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingTop = 1;
            this.itemPanelCarSubRP.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelCarSubRP.FitButtonsToContainerWidth = true;
            this.itemPanelCarSubRP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelCarSubRP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelCarSubRP.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemAddPatientType,
            this.buttonItemEditPatientType,
            this.buttonItemDelPatientType,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemPatientTypePrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddPatientType
            // 
            this.buttonItemAddPatientType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddPatientType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddPatientType.Image = global::MehrParvarPrj.Properties.Resources.kcmdrkonqi;
            this.buttonItemAddPatientType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddPatientType.ImagePaddingHorizontal = 8;
            this.buttonItemAddPatientType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddPatientType.Name = "buttonItemAddPatientType";
            this.buttonItemAddPatientType.Text = "ثبت بیمار جدید";
            this.buttonItemAddPatientType.ThemeAware = true;
            this.buttonItemAddPatientType.Click += new System.EventHandler(this.buttonItemAddPatientType_Click);
            // 
            // buttonItemEditPatientType
            // 
            this.buttonItemEditPatientType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditPatientType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditPatientType.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditPatientType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemEditPatientType.ImagePaddingHorizontal = 8;
            this.buttonItemEditPatientType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditPatientType.Name = "buttonItemEditPatientType";
            this.buttonItemEditPatientType.Text = "ویرایش";
            this.buttonItemEditPatientType.ThemeAware = true;
            this.buttonItemEditPatientType.Click += new System.EventHandler(this.buttonItemEditPatientType_Click);
            // 
            // buttonItemDelPatientType
            // 
            this.buttonItemDelPatientType.BeginGroup = true;
            this.buttonItemDelPatientType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelPatientType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelPatientType.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelPatientType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemDelPatientType.ImagePaddingHorizontal = 8;
            this.buttonItemDelPatientType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelPatientType.Name = "buttonItemDelPatientType";
            this.buttonItemDelPatientType.Text = "حذف";
            this.buttonItemDelPatientType.ThemeAware = true;
            this.buttonItemDelPatientType.Click += new System.EventHandler(this.buttonItemDelPatientType_Click);
            // 
            // buttonItemCarSubRPSearch
            // 
            this.buttonItemCarSubRPSearch.AutoCheckOnClick = true;
            this.buttonItemCarSubRPSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCarSubRPSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCarSubRPSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCarSubRPSearch.Image")));
            this.buttonItemCarSubRPSearch.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemCarSubRPSearch.ImagePaddingHorizontal = 8;
            this.buttonItemCarSubRPSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCarSubRPSearch.Name = "buttonItemCarSubRPSearch";
            this.buttonItemCarSubRPSearch.Text = "جستجو";
            this.buttonItemCarSubRPSearch.ThemeAware = true;
            this.buttonItemCarSubRPSearch.Click += new System.EventHandler(this.buttonItemCarSubRPSearch_Click);
            // 
            // buttonItemSelector
            // 
            this.buttonItemSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSelector.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSelector.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSelector.Image")));
            this.buttonItemSelector.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemSelector.ImagePaddingHorizontal = 8;
            this.buttonItemSelector.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSelector.Name = "buttonItemSelector";
            this.buttonItemSelector.Text = "انتخاب فیلدها";
            this.buttonItemSelector.ThemeAware = true;
            this.buttonItemSelector.Click += new System.EventHandler(this.buttonItemSelector_Click);
            // 
            // buttonItemPatientTypePrintList
            // 
            this.buttonItemPatientTypePrintList.BeginGroup = true;
            this.buttonItemPatientTypePrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemPatientTypePrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemPatientTypePrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemPatientTypePrintList.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemPatientTypePrintList.ImagePaddingHorizontal = 8;
            this.buttonItemPatientTypePrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemPatientTypePrintList.Name = "buttonItemPatientTypePrintList";
            this.buttonItemPatientTypePrintList.Text = "چاپ لیست";
            this.buttonItemPatientTypePrintList.ThemeAware = true;
            this.buttonItemPatientTypePrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // PatientTypeList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_PatientTypeList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientTypeList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست انواع بیمارها";
            this.Load += new System.EventHandler(this.PatientTypeList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PatientTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PatientTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_PatientTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PatientTypeList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditPatientType;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelPatientType;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemPatientTypePrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddPatientType;
        private DevExpress.XtraGrid.Columns.GridColumn PatientTypeDsc;
        private DevExpress.XtraGrid.Columns.GridColumn PatientTypeId;
    }
}