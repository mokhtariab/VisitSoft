namespace MehrParvarPrj
{
    partial class VaccinationList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinationList_Frm));
            this.gridControl_VaccinationList = new DevExpress.XtraGrid.GridControl();
            this.gridView_VaccinationList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VaccinationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VaccinationDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddVaccination = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditVaccination = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelVaccination = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemVaccinationPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_VaccinationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_VaccinationList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_VaccinationList
            // 
            this.gridControl_VaccinationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_VaccinationList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_VaccinationList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_VaccinationList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_VaccinationList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_VaccinationList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_VaccinationList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_VaccinationList.MainView = this.gridView_VaccinationList;
            this.gridControl_VaccinationList.Name = "gridControl_VaccinationList";
            this.gridControl_VaccinationList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_VaccinationList.TabIndex = 40;
            this.gridControl_VaccinationList.UseEmbeddedNavigator = true;
            this.gridControl_VaccinationList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_VaccinationList});
            // 
            // gridView_VaccinationList
            // 
            this.gridView_VaccinationList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_VaccinationList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_VaccinationList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_VaccinationList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_VaccinationList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_VaccinationList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_VaccinationList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_VaccinationList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_VaccinationList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_VaccinationList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_VaccinationList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_VaccinationList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_VaccinationList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_VaccinationList.ColumnPanelRowHeight = 25;
            this.gridView_VaccinationList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VaccinationId,
            this.VaccinationDsc});
            this.gridView_VaccinationList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_VaccinationList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_VaccinationList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_VaccinationList.GridControl = this.gridControl_VaccinationList;
            this.gridView_VaccinationList.Name = "gridView_VaccinationList";
            this.gridView_VaccinationList.OptionsBehavior.Editable = false;
            this.gridView_VaccinationList.OptionsCustomization.AllowGroup = false;
            this.gridView_VaccinationList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_VaccinationList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_VaccinationList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_VaccinationList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_VaccinationList.OptionsLayout.StoreAllOptions = true;
            this.gridView_VaccinationList.OptionsLayout.StoreAppearance = true;
            this.gridView_VaccinationList.OptionsPrint.PrintPreview = true;
            this.gridView_VaccinationList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_VaccinationList.OptionsView.ShowFooter = true;
            this.gridView_VaccinationList.OptionsView.ShowGroupPanel = false;
            this.gridView_VaccinationList.OptionsView.ShowIndicator = false;
            this.gridView_VaccinationList.PaintStyleName = "Skin";
            this.gridView_VaccinationList.RowHeight = 20;
            this.gridView_VaccinationList.DoubleClick += new System.EventHandler(this.buttonItemEditVaccination_Click);
            // 
            // VaccinationId
            // 
            this.VaccinationId.Caption = "کد واکسیناسیون";
            this.VaccinationId.FieldName = "Id";
            this.VaccinationId.Name = "VaccinationId";
            this.VaccinationId.Visible = true;
            this.VaccinationId.VisibleIndex = 1;
            this.VaccinationId.Width = 100;
            // 
            // VaccinationDsc
            // 
            this.VaccinationDsc.Caption = "عنوان واکسیناسیون";
            this.VaccinationDsc.FieldName = "TitleName";
            this.VaccinationDsc.Name = "VaccinationDsc";
            this.VaccinationDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.VaccinationDsc.Visible = true;
            this.VaccinationDsc.VisibleIndex = 0;
            this.VaccinationDsc.Width = 426;
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
            this.buttonItemAddVaccination,
            this.buttonItemEditVaccination,
            this.buttonItemDelVaccination,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemVaccinationPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddVaccination
            // 
            this.buttonItemAddVaccination.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddVaccination.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddVaccination.Image = global::MehrParvarPrj.Properties.Resources.virussafe;
            this.buttonItemAddVaccination.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddVaccination.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddVaccination.Name = "buttonItemAddVaccination";
            this.buttonItemAddVaccination.Text = "ثبت واکسیناسیون جدید";
            this.buttonItemAddVaccination.ThemeAware = true;
            this.buttonItemAddVaccination.Click += new System.EventHandler(this.buttonItemAddVaccination_Click);
            // 
            // buttonItemEditVaccination
            // 
            this.buttonItemEditVaccination.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditVaccination.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditVaccination.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditVaccination.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditVaccination.Name = "buttonItemEditVaccination";
            this.buttonItemEditVaccination.Text = "ویرایش";
            this.buttonItemEditVaccination.ThemeAware = true;
            this.buttonItemEditVaccination.Click += new System.EventHandler(this.buttonItemEditVaccination_Click);
            // 
            // buttonItemDelVaccination
            // 
            this.buttonItemDelVaccination.BeginGroup = true;
            this.buttonItemDelVaccination.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelVaccination.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelVaccination.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelVaccination.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelVaccination.Name = "buttonItemDelVaccination";
            this.buttonItemDelVaccination.Text = "حذف";
            this.buttonItemDelVaccination.ThemeAware = true;
            this.buttonItemDelVaccination.Click += new System.EventHandler(this.buttonItemDelVaccination_Click);
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
            // buttonItemVaccinationPrintList
            // 
            this.buttonItemVaccinationPrintList.BeginGroup = true;
            this.buttonItemVaccinationPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemVaccinationPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemVaccinationPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemVaccinationPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemVaccinationPrintList.Name = "buttonItemVaccinationPrintList";
            this.buttonItemVaccinationPrintList.Text = "چاپ لیست";
            this.buttonItemVaccinationPrintList.ThemeAware = true;
            this.buttonItemVaccinationPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // VaccinationList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_VaccinationList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VaccinationList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست واکسیناسیونها";
            this.Load += new System.EventHandler(this.VaccinationList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_VaccinationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_VaccinationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_VaccinationList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_VaccinationList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditVaccination;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelVaccination;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemVaccinationPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddVaccination;
        private DevExpress.XtraGrid.Columns.GridColumn VaccinationDsc;
        private DevExpress.XtraGrid.Columns.GridColumn VaccinationId;
    }
}