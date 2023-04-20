namespace MehrParvarPrj
{
    partial class ContractTypeList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractTypeList_Frm));
            this.gridControl_ContractTypeList = new DevExpress.XtraGrid.GridControl();
            this.gridView_ContractTypeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ContractTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractTypeDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractTypePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitForcePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BothVisitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsurancePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaxPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OtherIncrement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OtherDecrement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddContractType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditContractType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelContractType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemContractTypePrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ContractTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ContractTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_ContractTypeList
            // 
            this.gridControl_ContractTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_ContractTypeList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_ContractTypeList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_ContractTypeList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_ContractTypeList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_ContractTypeList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_ContractTypeList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_ContractTypeList.MainView = this.gridView_ContractTypeList;
            this.gridControl_ContractTypeList.Name = "gridControl_ContractTypeList";
            this.gridControl_ContractTypeList.Size = new System.Drawing.Size(679, 249);
            this.gridControl_ContractTypeList.TabIndex = 40;
            this.gridControl_ContractTypeList.UseEmbeddedNavigator = true;
            this.gridControl_ContractTypeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ContractTypeList});
            // 
            // gridView_ContractTypeList
            // 
            this.gridView_ContractTypeList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_ContractTypeList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ContractTypeList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ContractTypeList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_ContractTypeList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_ContractTypeList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_ContractTypeList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ContractTypeList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ContractTypeList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_ContractTypeList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ContractTypeList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ContractTypeList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_ContractTypeList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ContractTypeList.ColumnPanelRowHeight = 25;
            this.gridView_ContractTypeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ContractTypeId,
            this.ContractTypeDsc,
            this.ContractTypePrice,
            this.VisitForcePrice,
            this.BothVisitPrice,
            this.InsurancePrice,
            this.TaxPrice,
            this.OtherIncrement,
            this.OtherDecrement});
            this.gridView_ContractTypeList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_ContractTypeList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_ContractTypeList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_ContractTypeList.GridControl = this.gridControl_ContractTypeList;
            this.gridView_ContractTypeList.Name = "gridView_ContractTypeList";
            this.gridView_ContractTypeList.OptionsBehavior.Editable = false;
            this.gridView_ContractTypeList.OptionsCustomization.AllowGroup = false;
            this.gridView_ContractTypeList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_ContractTypeList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_ContractTypeList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_ContractTypeList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_ContractTypeList.OptionsLayout.StoreAllOptions = true;
            this.gridView_ContractTypeList.OptionsLayout.StoreAppearance = true;
            this.gridView_ContractTypeList.OptionsPrint.PrintPreview = true;
            this.gridView_ContractTypeList.OptionsPrint.UsePrintStyles = true;
            this.gridView_ContractTypeList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_ContractTypeList.OptionsView.ShowFooter = true;
            this.gridView_ContractTypeList.OptionsView.ShowGroupPanel = false;
            this.gridView_ContractTypeList.OptionsView.ShowIndicator = false;
            this.gridView_ContractTypeList.PaintStyleName = "Skin";
            this.gridView_ContractTypeList.RowHeight = 20;
            this.gridView_ContractTypeList.DoubleClick += new System.EventHandler(this.buttonItemEditContractType_Click);
            // 
            // ContractTypeId
            // 
            this.ContractTypeId.Caption = "کد";
            this.ContractTypeId.FieldName = "ContractTypeId";
            this.ContractTypeId.Name = "ContractTypeId";
            this.ContractTypeId.Visible = true;
            this.ContractTypeId.VisibleIndex = 6;
            // 
            // ContractTypeDsc
            // 
            this.ContractTypeDsc.Caption = "عنوان قرارداد";
            this.ContractTypeDsc.FieldName = "ContractTypeDsc";
            this.ContractTypeDsc.Name = "ContractTypeDsc";
            this.ContractTypeDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ContractTypeDsc.Visible = true;
            this.ContractTypeDsc.VisibleIndex = 5;
            // 
            // ContractTypePrice
            // 
            this.ContractTypePrice.Caption = "مبلغ قرارداد";
            this.ContractTypePrice.FieldName = "ContractTypePrice";
            this.ContractTypePrice.Name = "ContractTypePrice";
            this.ContractTypePrice.Visible = true;
            this.ContractTypePrice.VisibleIndex = 4;
            // 
            // VisitForcePrice
            // 
            this.VisitForcePrice.Caption = "مابه تفاوت ویزیت فوری";
            this.VisitForcePrice.FieldName = "VisitForcePrice";
            this.VisitForcePrice.Name = "VisitForcePrice";
            this.VisitForcePrice.Visible = true;
            this.VisitForcePrice.VisibleIndex = 3;
            // 
            // BothVisitPrice
            // 
            this.BothVisitPrice.Caption = "مابه تفاوت ویزیت دوتایی";
            this.BothVisitPrice.FieldName = "BothVisitPrice";
            this.BothVisitPrice.Name = "BothVisitPrice";
            this.BothVisitPrice.Visible = true;
            this.BothVisitPrice.VisibleIndex = 2;
            // 
            // InsurancePrice
            // 
            this.InsurancePrice.Caption = "مبلغ بیمه";
            this.InsurancePrice.FieldName = "InsurancePrice";
            this.InsurancePrice.Name = "InsurancePrice";
            this.InsurancePrice.Visible = true;
            this.InsurancePrice.VisibleIndex = 1;
            // 
            // TaxPrice
            // 
            this.TaxPrice.Caption = "مبلغ مالیات";
            this.TaxPrice.FieldName = "TaxPrice";
            this.TaxPrice.Name = "TaxPrice";
            this.TaxPrice.Visible = true;
            this.TaxPrice.VisibleIndex = 0;
            // 
            // OtherIncrement
            // 
            this.OtherIncrement.Caption = "سایر مبالغ";
            this.OtherIncrement.FieldName = "OtherIncrement";
            this.OtherIncrement.Name = "OtherIncrement";
            // 
            // OtherDecrement
            // 
            this.OtherDecrement.Caption = "سایر کسورات";
            this.OtherDecrement.FieldName = "OtherDecrement";
            this.OtherDecrement.Name = "OtherDecrement";
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
            this.buttonItemAddContractType,
            this.buttonItemEditContractType,
            this.buttonItemDelContractType,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemContractTypePrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(679, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddContractType
            // 
            this.buttonItemAddContractType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddContractType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddContractType.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemAddContractType.Image")));
            this.buttonItemAddContractType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemAddContractType.ImagePaddingHorizontal = 8;
            this.buttonItemAddContractType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddContractType.Name = "buttonItemAddContractType";
            this.buttonItemAddContractType.Text = "ثبت قرارداد جدید";
            this.buttonItemAddContractType.ThemeAware = true;
            this.buttonItemAddContractType.Click += new System.EventHandler(this.buttonItemAddContractType_Click);
            // 
            // buttonItemEditContractType
            // 
            this.buttonItemEditContractType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditContractType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditContractType.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditContractType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemEditContractType.ImagePaddingHorizontal = 8;
            this.buttonItemEditContractType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditContractType.Name = "buttonItemEditContractType";
            this.buttonItemEditContractType.Text = "ویرایش";
            this.buttonItemEditContractType.ThemeAware = true;
            this.buttonItemEditContractType.Click += new System.EventHandler(this.buttonItemEditContractType_Click);
            // 
            // buttonItemDelContractType
            // 
            this.buttonItemDelContractType.BeginGroup = true;
            this.buttonItemDelContractType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelContractType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelContractType.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelContractType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemDelContractType.ImagePaddingHorizontal = 8;
            this.buttonItemDelContractType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelContractType.Name = "buttonItemDelContractType";
            this.buttonItemDelContractType.Text = "حذف";
            this.buttonItemDelContractType.ThemeAware = true;
            this.buttonItemDelContractType.Click += new System.EventHandler(this.buttonItemDelContractType_Click);
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
            // buttonItemContractTypePrintList
            // 
            this.buttonItemContractTypePrintList.BeginGroup = true;
            this.buttonItemContractTypePrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemContractTypePrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemContractTypePrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemContractTypePrintList.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemContractTypePrintList.ImagePaddingHorizontal = 8;
            this.buttonItemContractTypePrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemContractTypePrintList.Name = "buttonItemContractTypePrintList";
            this.buttonItemContractTypePrintList.Text = "چاپ لیست";
            this.buttonItemContractTypePrintList.ThemeAware = true;
            this.buttonItemContractTypePrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // ContractTypeList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 306);
            this.Controls.Add(this.gridControl_ContractTypeList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContractTypeList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست انواع قراردادها";
            this.Load += new System.EventHandler(this.ContractTypeList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ContractTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ContractTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_ContractTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ContractTypeList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditContractType;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelContractType;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemContractTypePrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddContractType;
        private DevExpress.XtraGrid.Columns.GridColumn ContractTypeDsc;
        private DevExpress.XtraGrid.Columns.GridColumn ContractTypePrice;
        private DevExpress.XtraGrid.Columns.GridColumn ContractTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn VisitForcePrice;
        private DevExpress.XtraGrid.Columns.GridColumn BothVisitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn InsurancePrice;
        private DevExpress.XtraGrid.Columns.GridColumn TaxPrice;
        private DevExpress.XtraGrid.Columns.GridColumn OtherIncrement;
        private DevExpress.XtraGrid.Columns.GridColumn OtherDecrement;
    }
}