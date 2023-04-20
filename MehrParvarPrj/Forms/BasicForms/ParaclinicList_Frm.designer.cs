namespace MehrParvarPrj
{
    partial class ParaclinicList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaclinicList_Frm));
            this.gridControl_ParaclinicList = new DevExpress.XtraGrid.GridControl();
            this.gridView_ParaclinicList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ParaclinicId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ParaclinicName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddParaclinic = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditParaclinic = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelParaclinic = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemParaclinicPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ParaclinicList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ParaclinicList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_ParaclinicList
            // 
            this.gridControl_ParaclinicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_ParaclinicList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_ParaclinicList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_ParaclinicList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_ParaclinicList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_ParaclinicList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_ParaclinicList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_ParaclinicList.MainView = this.gridView_ParaclinicList;
            this.gridControl_ParaclinicList.Name = "gridControl_ParaclinicList";
            this.gridControl_ParaclinicList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_ParaclinicList.TabIndex = 40;
            this.gridControl_ParaclinicList.UseEmbeddedNavigator = true;
            this.gridControl_ParaclinicList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ParaclinicList});
            // 
            // gridView_ParaclinicList
            // 
            this.gridView_ParaclinicList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_ParaclinicList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ParaclinicList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ParaclinicList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_ParaclinicList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_ParaclinicList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_ParaclinicList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ParaclinicList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ParaclinicList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_ParaclinicList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ParaclinicList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ParaclinicList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_ParaclinicList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ParaclinicList.ColumnPanelRowHeight = 25;
            this.gridView_ParaclinicList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ParaclinicId,
            this.ParaclinicName});
            this.gridView_ParaclinicList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_ParaclinicList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_ParaclinicList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_ParaclinicList.GridControl = this.gridControl_ParaclinicList;
            this.gridView_ParaclinicList.Name = "gridView_ParaclinicList";
            this.gridView_ParaclinicList.OptionsBehavior.Editable = false;
            this.gridView_ParaclinicList.OptionsCustomization.AllowGroup = false;
            this.gridView_ParaclinicList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_ParaclinicList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_ParaclinicList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_ParaclinicList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_ParaclinicList.OptionsLayout.StoreAllOptions = true;
            this.gridView_ParaclinicList.OptionsLayout.StoreAppearance = true;
            this.gridView_ParaclinicList.OptionsPrint.PrintPreview = true;
            this.gridView_ParaclinicList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_ParaclinicList.OptionsView.ShowFooter = true;
            this.gridView_ParaclinicList.OptionsView.ShowGroupPanel = false;
            this.gridView_ParaclinicList.OptionsView.ShowIndicator = false;
            this.gridView_ParaclinicList.PaintStyleName = "Skin";
            this.gridView_ParaclinicList.RowHeight = 20;
            this.gridView_ParaclinicList.DoubleClick += new System.EventHandler(this.buttonItemEditParaclinic_Click);
            // 
            // ParaclinicId
            // 
            this.ParaclinicId.Caption = "کد پاراکلینیک";
            this.ParaclinicId.FieldName = "ParaclinicId";
            this.ParaclinicId.Name = "ParaclinicId";
            this.ParaclinicId.Visible = true;
            this.ParaclinicId.VisibleIndex = 1;
            this.ParaclinicId.Width = 136;
            // 
            // ParaclinicName
            // 
            this.ParaclinicName.Caption = "عنوان پاراکلینیک";
            this.ParaclinicName.FieldName = "ParaclinicName";
            this.ParaclinicName.Name = "ParaclinicName";
            this.ParaclinicName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ParaclinicName.Visible = true;
            this.ParaclinicName.VisibleIndex = 0;
            this.ParaclinicName.Width = 379;
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
            this.buttonItemAddParaclinic,
            this.buttonItemEditParaclinic,
            this.buttonItemDelParaclinic,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemParaclinicPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddParaclinic
            // 
            this.buttonItemAddParaclinic.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddParaclinic.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddParaclinic.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemAddParaclinic.Image")));
            this.buttonItemAddParaclinic.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddParaclinic.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddParaclinic.Name = "buttonItemAddParaclinic";
            this.buttonItemAddParaclinic.Text = "ثبت پاراکلینیک جدید";
            this.buttonItemAddParaclinic.ThemeAware = true;
            this.buttonItemAddParaclinic.Click += new System.EventHandler(this.buttonItemAddParaclinic_Click);
            // 
            // buttonItemEditParaclinic
            // 
            this.buttonItemEditParaclinic.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditParaclinic.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditParaclinic.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditParaclinic.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditParaclinic.Name = "buttonItemEditParaclinic";
            this.buttonItemEditParaclinic.Text = "ویرایش";
            this.buttonItemEditParaclinic.ThemeAware = true;
            this.buttonItemEditParaclinic.Click += new System.EventHandler(this.buttonItemEditParaclinic_Click);
            // 
            // buttonItemDelParaclinic
            // 
            this.buttonItemDelParaclinic.BeginGroup = true;
            this.buttonItemDelParaclinic.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelParaclinic.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelParaclinic.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelParaclinic.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelParaclinic.Name = "buttonItemDelParaclinic";
            this.buttonItemDelParaclinic.Text = "حذف";
            this.buttonItemDelParaclinic.ThemeAware = true;
            this.buttonItemDelParaclinic.Click += new System.EventHandler(this.buttonItemDelParaclinic_Click);
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
            // buttonItemParaclinicPrintList
            // 
            this.buttonItemParaclinicPrintList.BeginGroup = true;
            this.buttonItemParaclinicPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemParaclinicPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemParaclinicPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemParaclinicPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemParaclinicPrintList.Name = "buttonItemParaclinicPrintList";
            this.buttonItemParaclinicPrintList.Text = "چاپ لیست";
            this.buttonItemParaclinicPrintList.ThemeAware = true;
            this.buttonItemParaclinicPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // ParaclinicList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_ParaclinicList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParaclinicList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست پاراکلینیکها";
            this.Load += new System.EventHandler(this.ParaclinicList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ParaclinicList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ParaclinicList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_ParaclinicList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ParaclinicList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditParaclinic;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelParaclinic;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemParaclinicPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddParaclinic;
        private DevExpress.XtraGrid.Columns.GridColumn ParaclinicName;
        private DevExpress.XtraGrid.Columns.GridColumn ParaclinicId;
    }
}