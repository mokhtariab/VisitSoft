namespace MehrParvarPrj
{
    partial class StateSicknessList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateSicknessList_Frm));
            this.gridControl_StateSicknessList = new DevExpress.XtraGrid.GridControl();
            this.gridView_StateSicknessList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StateSicknessId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StateSicknessMasterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StateSicknessName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddStateSickness = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditStateSickness = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelStateSickness = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemStateSicknessPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_StateSicknessList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StateSicknessList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_StateSicknessList
            // 
            this.gridControl_StateSicknessList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_StateSicknessList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_StateSicknessList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_StateSicknessList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_StateSicknessList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_StateSicknessList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_StateSicknessList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_StateSicknessList.MainView = this.gridView_StateSicknessList;
            this.gridControl_StateSicknessList.Name = "gridControl_StateSicknessList";
            this.gridControl_StateSicknessList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_StateSicknessList.TabIndex = 40;
            this.gridControl_StateSicknessList.UseEmbeddedNavigator = true;
            this.gridControl_StateSicknessList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_StateSicknessList});
            // 
            // gridView_StateSicknessList
            // 
            this.gridView_StateSicknessList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_StateSicknessList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_StateSicknessList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_StateSicknessList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_StateSicknessList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_StateSicknessList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_StateSicknessList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_StateSicknessList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_StateSicknessList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_StateSicknessList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_StateSicknessList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_StateSicknessList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_StateSicknessList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_StateSicknessList.ColumnPanelRowHeight = 25;
            this.gridView_StateSicknessList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StateSicknessId,
            this.StateSicknessMasterName,
            this.StateSicknessName});
            this.gridView_StateSicknessList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_StateSicknessList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_StateSicknessList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_StateSicknessList.GridControl = this.gridControl_StateSicknessList;
            this.gridView_StateSicknessList.Name = "gridView_StateSicknessList";
            this.gridView_StateSicknessList.OptionsBehavior.Editable = false;
            this.gridView_StateSicknessList.OptionsCustomization.AllowGroup = false;
            this.gridView_StateSicknessList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_StateSicknessList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_StateSicknessList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_StateSicknessList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_StateSicknessList.OptionsLayout.StoreAllOptions = true;
            this.gridView_StateSicknessList.OptionsLayout.StoreAppearance = true;
            this.gridView_StateSicknessList.OptionsPrint.PrintPreview = true;
            this.gridView_StateSicknessList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_StateSicknessList.OptionsView.ShowFooter = true;
            this.gridView_StateSicknessList.OptionsView.ShowGroupPanel = false;
            this.gridView_StateSicknessList.OptionsView.ShowIndicator = false;
            this.gridView_StateSicknessList.PaintStyleName = "Skin";
            this.gridView_StateSicknessList.RowHeight = 20;
            this.gridView_StateSicknessList.DoubleClick += new System.EventHandler(this.buttonItemEditStateSickness_Click);
            // 
            // StateSicknessId
            // 
            this.StateSicknessId.Caption = "کد بیماری";
            this.StateSicknessId.FieldName = "StateSicknessId";
            this.StateSicknessId.Name = "StateSicknessId";
            this.StateSicknessId.Visible = true;
            this.StateSicknessId.VisibleIndex = 2;
            this.StateSicknessId.Width = 79;
            // 
            // StateSicknessMasterName
            // 
            this.StateSicknessMasterName.Caption = "عنوان کلی";
            this.StateSicknessMasterName.FieldName = "StateSicknessMasterName";
            this.StateSicknessMasterName.Name = "StateSicknessMasterName";
            this.StateSicknessMasterName.Visible = true;
            this.StateSicknessMasterName.VisibleIndex = 1;
            this.StateSicknessMasterName.Width = 189;
            // 
            // StateSicknessName
            // 
            this.StateSicknessName.Caption = "عنوان وضعیت بیماری";
            this.StateSicknessName.FieldName = "StateSicknessName";
            this.StateSicknessName.Name = "StateSicknessName";
            this.StateSicknessName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.StateSicknessName.Visible = true;
            this.StateSicknessName.VisibleIndex = 0;
            this.StateSicknessName.Width = 247;
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
            this.buttonItemAddStateSickness,
            this.buttonItemEditStateSickness,
            this.buttonItemDelStateSickness,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemStateSicknessPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddStateSickness
            // 
            this.buttonItemAddStateSickness.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddStateSickness.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddStateSickness.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemAddStateSickness.Image")));
            this.buttonItemAddStateSickness.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddStateSickness.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddStateSickness.Name = "buttonItemAddStateSickness";
            this.buttonItemAddStateSickness.Text = "ثبت وضعیت بیماری جدید";
            this.buttonItemAddStateSickness.ThemeAware = true;
            this.buttonItemAddStateSickness.Click += new System.EventHandler(this.buttonItemAddStateSickness_Click);
            // 
            // buttonItemEditStateSickness
            // 
            this.buttonItemEditStateSickness.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditStateSickness.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditStateSickness.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditStateSickness.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditStateSickness.Name = "buttonItemEditStateSickness";
            this.buttonItemEditStateSickness.Text = "ویرایش";
            this.buttonItemEditStateSickness.ThemeAware = true;
            this.buttonItemEditStateSickness.Click += new System.EventHandler(this.buttonItemEditStateSickness_Click);
            // 
            // buttonItemDelStateSickness
            // 
            this.buttonItemDelStateSickness.BeginGroup = true;
            this.buttonItemDelStateSickness.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelStateSickness.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelStateSickness.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelStateSickness.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelStateSickness.Name = "buttonItemDelStateSickness";
            this.buttonItemDelStateSickness.Text = "حذف";
            this.buttonItemDelStateSickness.ThemeAware = true;
            this.buttonItemDelStateSickness.Click += new System.EventHandler(this.buttonItemDelStateSickness_Click);
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
            // buttonItemStateSicknessPrintList
            // 
            this.buttonItemStateSicknessPrintList.BeginGroup = true;
            this.buttonItemStateSicknessPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemStateSicknessPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemStateSicknessPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemStateSicknessPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemStateSicknessPrintList.Name = "buttonItemStateSicknessPrintList";
            this.buttonItemStateSicknessPrintList.Text = "چاپ لیست";
            this.buttonItemStateSicknessPrintList.ThemeAware = true;
            this.buttonItemStateSicknessPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // StateSicknessList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_StateSicknessList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StateSicknessList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست وضعیت بیماریها";
            this.Load += new System.EventHandler(this.StateSicknessList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_StateSicknessList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StateSicknessList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_StateSicknessList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_StateSicknessList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditStateSickness;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelStateSickness;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemStateSicknessPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddStateSickness;
        private DevExpress.XtraGrid.Columns.GridColumn StateSicknessName;
        private DevExpress.XtraGrid.Columns.GridColumn StateSicknessId;
        private DevExpress.XtraGrid.Columns.GridColumn StateSicknessMasterName;
    }
}