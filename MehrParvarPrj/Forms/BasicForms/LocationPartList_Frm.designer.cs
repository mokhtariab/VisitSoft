namespace MehrParvarPrj
{
    partial class LocationPartList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationPartList_Frm));
            this.gridControl_LocationPartList = new DevExpress.XtraGrid.GridControl();
            this.gridView_LocationPartList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LocationPartId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationPartDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddLocationPart = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditLocationPart = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelLocationPart = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemLocationPartPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LocationPartList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LocationPartList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_LocationPartList
            // 
            this.gridControl_LocationPartList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_LocationPartList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_LocationPartList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_LocationPartList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_LocationPartList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_LocationPartList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_LocationPartList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_LocationPartList.MainView = this.gridView_LocationPartList;
            this.gridControl_LocationPartList.Name = "gridControl_LocationPartList";
            this.gridControl_LocationPartList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_LocationPartList.TabIndex = 40;
            this.gridControl_LocationPartList.UseEmbeddedNavigator = true;
            this.gridControl_LocationPartList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_LocationPartList});
            // 
            // gridView_LocationPartList
            // 
            this.gridView_LocationPartList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_LocationPartList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_LocationPartList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_LocationPartList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_LocationPartList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_LocationPartList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_LocationPartList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_LocationPartList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_LocationPartList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_LocationPartList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_LocationPartList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_LocationPartList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_LocationPartList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_LocationPartList.ColumnPanelRowHeight = 25;
            this.gridView_LocationPartList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LocationPartId,
            this.LocationPartDsc});
            this.gridView_LocationPartList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_LocationPartList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_LocationPartList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_LocationPartList.GridControl = this.gridControl_LocationPartList;
            this.gridView_LocationPartList.Name = "gridView_LocationPartList";
            this.gridView_LocationPartList.OptionsBehavior.Editable = false;
            this.gridView_LocationPartList.OptionsCustomization.AllowGroup = false;
            this.gridView_LocationPartList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_LocationPartList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_LocationPartList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_LocationPartList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_LocationPartList.OptionsLayout.StoreAllOptions = true;
            this.gridView_LocationPartList.OptionsLayout.StoreAppearance = true;
            this.gridView_LocationPartList.OptionsPrint.PrintPreview = true;
            this.gridView_LocationPartList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_LocationPartList.OptionsView.ShowFooter = true;
            this.gridView_LocationPartList.OptionsView.ShowGroupPanel = false;
            this.gridView_LocationPartList.OptionsView.ShowIndicator = false;
            this.gridView_LocationPartList.PaintStyleName = "Skin";
            this.gridView_LocationPartList.RowHeight = 20;
            this.gridView_LocationPartList.DoubleClick += new System.EventHandler(this.buttonItemEditLocationPart_Click);
            // 
            // LocationPartId
            // 
            this.LocationPartId.Caption = "کد منطقه";
            this.LocationPartId.FieldName = "Id";
            this.LocationPartId.Name = "LocationPartId";
            this.LocationPartId.Visible = true;
            this.LocationPartId.VisibleIndex = 1;
            this.LocationPartId.Width = 100;
            // 
            // LocationPartDsc
            // 
            this.LocationPartDsc.Caption = "عنوان منطقه";
            this.LocationPartDsc.FieldName = "TitleName";
            this.LocationPartDsc.Name = "LocationPartDsc";
            this.LocationPartDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.LocationPartDsc.Visible = true;
            this.LocationPartDsc.VisibleIndex = 0;
            this.LocationPartDsc.Width = 426;
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
            this.buttonItemAddLocationPart,
            this.buttonItemEditLocationPart,
            this.buttonItemDelLocationPart,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemLocationPartPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddLocationPart
            // 
            this.buttonItemAddLocationPart.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddLocationPart.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddLocationPart.Image = global::MehrParvarPrj.Properties.Resources.web;
            this.buttonItemAddLocationPart.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddLocationPart.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddLocationPart.Name = "buttonItemAddLocationPart";
            this.buttonItemAddLocationPart.Text = "ثبت منطقه جدید";
            this.buttonItemAddLocationPart.ThemeAware = true;
            this.buttonItemAddLocationPart.Click += new System.EventHandler(this.buttonItemAddLocationPart_Click);
            // 
            // buttonItemEditLocationPart
            // 
            this.buttonItemEditLocationPart.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditLocationPart.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditLocationPart.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditLocationPart.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditLocationPart.Name = "buttonItemEditLocationPart";
            this.buttonItemEditLocationPart.Text = "ویرایش";
            this.buttonItemEditLocationPart.ThemeAware = true;
            this.buttonItemEditLocationPart.Click += new System.EventHandler(this.buttonItemEditLocationPart_Click);
            // 
            // buttonItemDelLocationPart
            // 
            this.buttonItemDelLocationPart.BeginGroup = true;
            this.buttonItemDelLocationPart.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelLocationPart.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelLocationPart.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelLocationPart.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelLocationPart.Name = "buttonItemDelLocationPart";
            this.buttonItemDelLocationPart.Text = "حذف";
            this.buttonItemDelLocationPart.ThemeAware = true;
            this.buttonItemDelLocationPart.Click += new System.EventHandler(this.buttonItemDelLocationPart_Click);
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
            // buttonItemLocationPartPrintList
            // 
            this.buttonItemLocationPartPrintList.BeginGroup = true;
            this.buttonItemLocationPartPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemLocationPartPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemLocationPartPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemLocationPartPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemLocationPartPrintList.Name = "buttonItemLocationPartPrintList";
            this.buttonItemLocationPartPrintList.Text = "چاپ لیست";
            this.buttonItemLocationPartPrintList.ThemeAware = true;
            this.buttonItemLocationPartPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // LocationPartList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_LocationPartList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocationPartList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست مناطق";
            this.Load += new System.EventHandler(this.LocationPartList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LocationPartList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LocationPartList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_LocationPartList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_LocationPartList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditLocationPart;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelLocationPart;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemLocationPartPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddLocationPart;
        private DevExpress.XtraGrid.Columns.GridColumn LocationPartDsc;
        private DevExpress.XtraGrid.Columns.GridColumn LocationPartId;
    }
}