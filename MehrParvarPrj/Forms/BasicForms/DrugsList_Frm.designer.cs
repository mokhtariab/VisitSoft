namespace MehrParvarPrj
{
    partial class DrugsList_Frm
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugsList_Frm));
            this.gridControl_DrugsList = new DevExpress.XtraGrid.GridControl();
            this.gridView_DrugsList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DrugsId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DrugsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddDrugs = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditDrugs = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelDrugs = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDrugsPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DrugsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DrugsList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DrugsList
            // 
            this.gridControl_DrugsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_DrugsList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_DrugsList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_DrugsList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_DrugsList.Location = new System.Drawing.Point(0, 62);
            this.gridControl_DrugsList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_DrugsList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_DrugsList.MainView = this.gridView_DrugsList;
            this.gridControl_DrugsList.Name = "gridControl_DrugsList";
            this.gridControl_DrugsList.Size = new System.Drawing.Size(517, 244);
            this.gridControl_DrugsList.TabIndex = 40;
            this.gridControl_DrugsList.UseEmbeddedNavigator = true;
            this.gridControl_DrugsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DrugsList});
            // 
            // gridView_DrugsList
            // 
            this.gridView_DrugsList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_DrugsList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DrugsList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DrugsList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_DrugsList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DrugsList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DrugsList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DrugsList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DrugsList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_DrugsList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DrugsList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DrugsList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_DrugsList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DrugsList.ColumnPanelRowHeight = 25;
            this.gridView_DrugsList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DrugsId,
            this.DrugsName});
            this.gridView_DrugsList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_DrugsList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition2.Value1 = "1";
            this.gridView_DrugsList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridView_DrugsList.GridControl = this.gridControl_DrugsList;
            this.gridView_DrugsList.Name = "gridView_DrugsList";
            this.gridView_DrugsList.OptionsBehavior.Editable = false;
            this.gridView_DrugsList.OptionsCustomization.AllowGroup = false;
            this.gridView_DrugsList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_DrugsList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_DrugsList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_DrugsList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_DrugsList.OptionsLayout.StoreAllOptions = true;
            this.gridView_DrugsList.OptionsLayout.StoreAppearance = true;
            this.gridView_DrugsList.OptionsPrint.PrintPreview = true;
            this.gridView_DrugsList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_DrugsList.OptionsView.ShowFooter = true;
            this.gridView_DrugsList.OptionsView.ShowGroupPanel = false;
            this.gridView_DrugsList.OptionsView.ShowIndicator = false;
            this.gridView_DrugsList.PaintStyleName = "Skin";
            this.gridView_DrugsList.RowHeight = 20;
            this.gridView_DrugsList.DoubleClick += new System.EventHandler(this.buttonItemEditDrugs_Click);
            // 
            // DrugsId
            // 
            this.DrugsId.Caption = "کد دارو";
            this.DrugsId.FieldName = "DrugsId";
            this.DrugsId.Name = "DrugsId";
            this.DrugsId.Visible = true;
            this.DrugsId.VisibleIndex = 1;
            this.DrugsId.Width = 100;
            // 
            // DrugsName
            // 
            this.DrugsName.Caption = "عنوان دارو";
            this.DrugsName.FieldName = "DrugsName";
            this.DrugsName.Name = "DrugsName";
            this.DrugsName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DrugsName.Visible = true;
            this.DrugsName.VisibleIndex = 0;
            this.DrugsName.Width = 426;
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
            this.buttonItemAddDrugs,
            this.buttonItemEditDrugs,
            this.buttonItemDelDrugs,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemDrugsPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 62);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddDrugs
            // 
            this.buttonItemAddDrugs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddDrugs.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddDrugs.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemAddDrugs.Image")));
            this.buttonItemAddDrugs.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.buttonItemAddDrugs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddDrugs.Name = "buttonItemAddDrugs";
            this.buttonItemAddDrugs.Text = "ثبت داروی جدید";
            this.buttonItemAddDrugs.ThemeAware = true;
            this.buttonItemAddDrugs.Click += new System.EventHandler(this.buttonItemAddDrugs_Click);
            // 
            // buttonItemEditDrugs
            // 
            this.buttonItemEditDrugs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditDrugs.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditDrugs.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditDrugs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditDrugs.Name = "buttonItemEditDrugs";
            this.buttonItemEditDrugs.Text = "ویرایش";
            this.buttonItemEditDrugs.ThemeAware = true;
            this.buttonItemEditDrugs.Click += new System.EventHandler(this.buttonItemEditDrugs_Click);
            // 
            // buttonItemDelDrugs
            // 
            this.buttonItemDelDrugs.BeginGroup = true;
            this.buttonItemDelDrugs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelDrugs.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelDrugs.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelDrugs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelDrugs.Name = "buttonItemDelDrugs";
            this.buttonItemDelDrugs.Text = "حذف";
            this.buttonItemDelDrugs.ThemeAware = true;
            this.buttonItemDelDrugs.Click += new System.EventHandler(this.buttonItemDelDrugs_Click);
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
            // buttonItemDrugsPrintList
            // 
            this.buttonItemDrugsPrintList.BeginGroup = true;
            this.buttonItemDrugsPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDrugsPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDrugsPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemDrugsPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDrugsPrintList.Name = "buttonItemDrugsPrintList";
            this.buttonItemDrugsPrintList.Text = "چاپ لیست";
            this.buttonItemDrugsPrintList.ThemeAware = true;
            this.buttonItemDrugsPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // DrugsList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_DrugsList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrugsList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست داروها";
            this.Load += new System.EventHandler(this.DrugsList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DrugsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DrugsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_DrugsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DrugsList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditDrugs;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelDrugs;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemDrugsPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddDrugs;
        private DevExpress.XtraGrid.Columns.GridColumn DrugsName;
        private DevExpress.XtraGrid.Columns.GridColumn DrugsId;
    }
}