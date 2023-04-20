namespace MehrParvarPrj
{
    partial class StateSicknessMasterList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateSicknessMasterList_Frm));
            this.gridControl_StateSicknessMasterList = new DevExpress.XtraGrid.GridControl();
            this.gridView_StateSicknessMasterList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StateSicknessMasterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddStateSicknessMaster = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditStateSicknessMaster = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelStateSicknessMaster = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemStateSicknessMasterPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_StateSicknessMasterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StateSicknessMasterList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_StateSicknessMasterList
            // 
            this.gridControl_StateSicknessMasterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_StateSicknessMasterList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_StateSicknessMasterList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_StateSicknessMasterList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_StateSicknessMasterList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_StateSicknessMasterList.MainView = this.gridView_StateSicknessMasterList;
            this.gridControl_StateSicknessMasterList.Name = "gridControl_StateSicknessMasterList";
            this.gridControl_StateSicknessMasterList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_StateSicknessMasterList.TabIndex = 40;
            this.gridControl_StateSicknessMasterList.UseEmbeddedNavigator = true;
            this.gridControl_StateSicknessMasterList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_StateSicknessMasterList});
            // 
            // gridView_StateSicknessMasterList
            // 
            this.gridView_StateSicknessMasterList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_StateSicknessMasterList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_StateSicknessMasterList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_StateSicknessMasterList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_StateSicknessMasterList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_StateSicknessMasterList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_StateSicknessMasterList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_StateSicknessMasterList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_StateSicknessMasterList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_StateSicknessMasterList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_StateSicknessMasterList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_StateSicknessMasterList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_StateSicknessMasterList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_StateSicknessMasterList.ColumnPanelRowHeight = 25;
            this.gridView_StateSicknessMasterList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.StateSicknessMasterName});
            this.gridView_StateSicknessMasterList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_StateSicknessMasterList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_StateSicknessMasterList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_StateSicknessMasterList.GridControl = this.gridControl_StateSicknessMasterList;
            this.gridView_StateSicknessMasterList.Name = "gridView_StateSicknessMasterList";
            this.gridView_StateSicknessMasterList.OptionsBehavior.Editable = false;
            this.gridView_StateSicknessMasterList.OptionsCustomization.AllowGroup = false;
            this.gridView_StateSicknessMasterList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_StateSicknessMasterList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_StateSicknessMasterList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_StateSicknessMasterList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_StateSicknessMasterList.OptionsLayout.StoreAllOptions = true;
            this.gridView_StateSicknessMasterList.OptionsLayout.StoreAppearance = true;
            this.gridView_StateSicknessMasterList.OptionsPrint.PrintPreview = true;
            this.gridView_StateSicknessMasterList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_StateSicknessMasterList.OptionsView.ShowFooter = true;
            this.gridView_StateSicknessMasterList.OptionsView.ShowGroupPanel = false;
            this.gridView_StateSicknessMasterList.OptionsView.ShowIndicator = false;
            this.gridView_StateSicknessMasterList.PaintStyleName = "Skin";
            this.gridView_StateSicknessMasterList.RowHeight = 20;
            this.gridView_StateSicknessMasterList.DoubleClick += new System.EventHandler(this.buttonItemEditStateSicknessMaster_Click);
            // 
            // Id
            // 
            this.Id.Caption = "کد";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 1;
            this.Id.Width = 126;
            // 
            // StateSicknessMasterName
            // 
            this.StateSicknessMasterName.Caption = "عنوان کلی بیماری";
            this.StateSicknessMasterName.FieldName = "StateSicknessMasterName";
            this.StateSicknessMasterName.Name = "StateSicknessMasterName";
            this.StateSicknessMasterName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.StateSicknessMasterName.Visible = true;
            this.StateSicknessMasterName.VisibleIndex = 0;
            this.StateSicknessMasterName.Width = 389;
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
            this.buttonItemAddStateSicknessMaster,
            this.buttonItemEditStateSicknessMaster,
            this.buttonItemDelStateSicknessMaster,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemStateSicknessMasterPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddStateSicknessMaster
            // 
            this.buttonItemAddStateSicknessMaster.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddStateSicknessMaster.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddStateSicknessMaster.Image = global::MehrParvarPrj.Properties.Resources.virussafe;
            this.buttonItemAddStateSicknessMaster.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddStateSicknessMaster.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddStateSicknessMaster.Name = "buttonItemAddStateSicknessMaster";
            this.buttonItemAddStateSicknessMaster.Text = "ثبت وضعیت کلی بیماری";
            this.buttonItemAddStateSicknessMaster.ThemeAware = true;
            this.buttonItemAddStateSicknessMaster.Click += new System.EventHandler(this.buttonItemAddStateSicknessMaster_Click);
            // 
            // buttonItemEditStateSicknessMaster
            // 
            this.buttonItemEditStateSicknessMaster.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditStateSicknessMaster.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditStateSicknessMaster.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditStateSicknessMaster.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditStateSicknessMaster.Name = "buttonItemEditStateSicknessMaster";
            this.buttonItemEditStateSicknessMaster.Text = "ویرایش";
            this.buttonItemEditStateSicknessMaster.ThemeAware = true;
            this.buttonItemEditStateSicknessMaster.Click += new System.EventHandler(this.buttonItemEditStateSicknessMaster_Click);
            // 
            // buttonItemDelStateSicknessMaster
            // 
            this.buttonItemDelStateSicknessMaster.BeginGroup = true;
            this.buttonItemDelStateSicknessMaster.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelStateSicknessMaster.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelStateSicknessMaster.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelStateSicknessMaster.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelStateSicknessMaster.Name = "buttonItemDelStateSicknessMaster";
            this.buttonItemDelStateSicknessMaster.Text = "حذف";
            this.buttonItemDelStateSicknessMaster.ThemeAware = true;
            this.buttonItemDelStateSicknessMaster.Click += new System.EventHandler(this.buttonItemDelStateSicknessMaster_Click);
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
            // buttonItemStateSicknessMasterPrintList
            // 
            this.buttonItemStateSicknessMasterPrintList.BeginGroup = true;
            this.buttonItemStateSicknessMasterPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemStateSicknessMasterPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemStateSicknessMasterPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemStateSicknessMasterPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemStateSicknessMasterPrintList.Name = "buttonItemStateSicknessMasterPrintList";
            this.buttonItemStateSicknessMasterPrintList.Text = "چاپ لیست";
            this.buttonItemStateSicknessMasterPrintList.ThemeAware = true;
            this.buttonItemStateSicknessMasterPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // StateSicknessMasterList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_StateSicknessMasterList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StateSicknessMasterList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست وضعیت کلی بیماریها";
            this.Load += new System.EventHandler(this.StateSicknessMasterList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_StateSicknessMasterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StateSicknessMasterList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_StateSicknessMasterList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_StateSicknessMasterList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditStateSicknessMaster;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelStateSicknessMaster;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemStateSicknessMasterPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddStateSicknessMaster;
        private DevExpress.XtraGrid.Columns.GridColumn StateSicknessMasterName;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
    }
}