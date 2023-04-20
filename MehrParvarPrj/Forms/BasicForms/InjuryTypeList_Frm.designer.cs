namespace MehrParvarPrj
{
    partial class InjuryTypeList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InjuryTypeList_Frm));
            this.gridControl_InjuryTypeList = new DevExpress.XtraGrid.GridControl();
            this.gridView_InjuryTypeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.InjuryTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InjuryTypeDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddInjuryType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditInjuryType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelInjuryType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemInjuryTypePrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_InjuryTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_InjuryTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_InjuryTypeList
            // 
            this.gridControl_InjuryTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_InjuryTypeList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_InjuryTypeList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_InjuryTypeList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_InjuryTypeList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_InjuryTypeList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_InjuryTypeList.MainView = this.gridView_InjuryTypeList;
            this.gridControl_InjuryTypeList.Name = "gridControl_InjuryTypeList";
            this.gridControl_InjuryTypeList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_InjuryTypeList.TabIndex = 40;
            this.gridControl_InjuryTypeList.UseEmbeddedNavigator = true;
            this.gridControl_InjuryTypeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_InjuryTypeList});
            // 
            // gridView_InjuryTypeList
            // 
            this.gridView_InjuryTypeList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_InjuryTypeList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_InjuryTypeList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_InjuryTypeList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_InjuryTypeList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_InjuryTypeList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_InjuryTypeList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_InjuryTypeList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_InjuryTypeList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_InjuryTypeList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_InjuryTypeList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_InjuryTypeList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_InjuryTypeList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_InjuryTypeList.ColumnPanelRowHeight = 25;
            this.gridView_InjuryTypeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.InjuryTypeId,
            this.InjuryTypeDsc});
            this.gridView_InjuryTypeList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_InjuryTypeList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_InjuryTypeList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_InjuryTypeList.GridControl = this.gridControl_InjuryTypeList;
            this.gridView_InjuryTypeList.Name = "gridView_InjuryTypeList";
            this.gridView_InjuryTypeList.OptionsBehavior.Editable = false;
            this.gridView_InjuryTypeList.OptionsCustomization.AllowGroup = false;
            this.gridView_InjuryTypeList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_InjuryTypeList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_InjuryTypeList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_InjuryTypeList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_InjuryTypeList.OptionsLayout.StoreAllOptions = true;
            this.gridView_InjuryTypeList.OptionsLayout.StoreAppearance = true;
            this.gridView_InjuryTypeList.OptionsPrint.PrintPreview = true;
            this.gridView_InjuryTypeList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_InjuryTypeList.OptionsView.ShowFooter = true;
            this.gridView_InjuryTypeList.OptionsView.ShowGroupPanel = false;
            this.gridView_InjuryTypeList.OptionsView.ShowIndicator = false;
            this.gridView_InjuryTypeList.PaintStyleName = "Skin";
            this.gridView_InjuryTypeList.RowHeight = 20;
            this.gridView_InjuryTypeList.DoubleClick += new System.EventHandler(this.buttonItemEditInjuryType_Click);
            // 
            // InjuryTypeId
            // 
            this.InjuryTypeId.Caption = "کد نوع مجروحیت";
            this.InjuryTypeId.FieldName = "InjuryTypeId";
            this.InjuryTypeId.Name = "InjuryTypeId";
            this.InjuryTypeId.Visible = true;
            this.InjuryTypeId.VisibleIndex = 1;
            this.InjuryTypeId.Width = 115;
            // 
            // InjuryTypeDsc
            // 
            this.InjuryTypeDsc.Caption = "عنوان نوع مجروحیت";
            this.InjuryTypeDsc.FieldName = "InjuryTypeDsc";
            this.InjuryTypeDsc.Name = "InjuryTypeDsc";
            this.InjuryTypeDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.InjuryTypeDsc.Visible = true;
            this.InjuryTypeDsc.VisibleIndex = 0;
            this.InjuryTypeDsc.Width = 400;
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
            this.itemPanelCarSubRP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingRight = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingTop = 1;
            this.itemPanelCarSubRP.ContainerControlProcessDialogKey = true;
            this.itemPanelCarSubRP.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelCarSubRP.FitButtonsToContainerWidth = true;
            this.itemPanelCarSubRP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelCarSubRP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelCarSubRP.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemAddInjuryType,
            this.buttonItemEditInjuryType,
            this.buttonItemDelInjuryType,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemInjuryTypePrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddInjuryType
            // 
            this.buttonItemAddInjuryType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddInjuryType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddInjuryType.Image = global::MehrParvarPrj.Properties.Resources.surgeon;
            this.buttonItemAddInjuryType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddInjuryType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddInjuryType.Name = "buttonItemAddInjuryType";
            this.buttonItemAddInjuryType.Text = "ثبت مجروحیت جدید";
            this.buttonItemAddInjuryType.ThemeAware = true;
            this.buttonItemAddInjuryType.Click += new System.EventHandler(this.buttonItemAddInjuryType_Click);
            // 
            // buttonItemEditInjuryType
            // 
            this.buttonItemEditInjuryType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditInjuryType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditInjuryType.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditInjuryType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditInjuryType.Name = "buttonItemEditInjuryType";
            this.buttonItemEditInjuryType.Text = "ویرایش";
            this.buttonItemEditInjuryType.ThemeAware = true;
            this.buttonItemEditInjuryType.Click += new System.EventHandler(this.buttonItemEditInjuryType_Click);
            // 
            // buttonItemDelInjuryType
            // 
            this.buttonItemDelInjuryType.BeginGroup = true;
            this.buttonItemDelInjuryType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelInjuryType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelInjuryType.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelInjuryType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelInjuryType.Name = "buttonItemDelInjuryType";
            this.buttonItemDelInjuryType.Text = "حذف";
            this.buttonItemDelInjuryType.ThemeAware = true;
            this.buttonItemDelInjuryType.Click += new System.EventHandler(this.buttonItemDelInjuryType_Click);
            // 
            // buttonItemCarSubRPSearch
            // 
            this.buttonItemCarSubRPSearch.AutoCheckOnClick = true;
            this.buttonItemCarSubRPSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCarSubRPSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCarSubRPSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCarSubRPSearch.Image")));
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
            this.buttonItemSelector.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSelector.Name = "buttonItemSelector";
            this.buttonItemSelector.Text = "انتخاب فیلدها";
            this.buttonItemSelector.ThemeAware = true;
            this.buttonItemSelector.Click += new System.EventHandler(this.buttonItemSelector_Click);
            // 
            // buttonItemInjuryTypePrintList
            // 
            this.buttonItemInjuryTypePrintList.BeginGroup = true;
            this.buttonItemInjuryTypePrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemInjuryTypePrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemInjuryTypePrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemInjuryTypePrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemInjuryTypePrintList.Name = "buttonItemInjuryTypePrintList";
            this.buttonItemInjuryTypePrintList.Text = "چاپ لیست";
            this.buttonItemInjuryTypePrintList.ThemeAware = true;
            this.buttonItemInjuryTypePrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // InjuryTypeList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_InjuryTypeList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InjuryTypeList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست انواع مجروحیتها";
            this.Load += new System.EventHandler(this.InjuryTypeList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_InjuryTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_InjuryTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_InjuryTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_InjuryTypeList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditInjuryType;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelInjuryType;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemInjuryTypePrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddInjuryType;
        private DevExpress.XtraGrid.Columns.GridColumn InjuryTypeDsc;
        private DevExpress.XtraGrid.Columns.GridColumn InjuryTypeId;
    }
}