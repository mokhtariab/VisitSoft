namespace MehrParvarPrj
{
    partial class EquipmentUseList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentUseList_Frm));
            this.gridControl_EquipmentUseList = new DevExpress.XtraGrid.GridControl();
            this.gridView_EquipmentUseList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EquipmentUseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EquipmentUseDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddEquipmentUse = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditEquipmentUse = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelEquipmentUse = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEquipmentUsePrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_EquipmentUseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_EquipmentUseList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_EquipmentUseList
            // 
            this.gridControl_EquipmentUseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_EquipmentUseList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_EquipmentUseList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_EquipmentUseList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_EquipmentUseList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_EquipmentUseList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_EquipmentUseList.MainView = this.gridView_EquipmentUseList;
            this.gridControl_EquipmentUseList.Name = "gridControl_EquipmentUseList";
            this.gridControl_EquipmentUseList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_EquipmentUseList.TabIndex = 40;
            this.gridControl_EquipmentUseList.UseEmbeddedNavigator = true;
            this.gridControl_EquipmentUseList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_EquipmentUseList});
            // 
            // gridView_EquipmentUseList
            // 
            this.gridView_EquipmentUseList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_EquipmentUseList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_EquipmentUseList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_EquipmentUseList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_EquipmentUseList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_EquipmentUseList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_EquipmentUseList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_EquipmentUseList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_EquipmentUseList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_EquipmentUseList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_EquipmentUseList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_EquipmentUseList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_EquipmentUseList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_EquipmentUseList.ColumnPanelRowHeight = 25;
            this.gridView_EquipmentUseList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EquipmentUseId,
            this.EquipmentUseDsc});
            this.gridView_EquipmentUseList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_EquipmentUseList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_EquipmentUseList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_EquipmentUseList.GridControl = this.gridControl_EquipmentUseList;
            this.gridView_EquipmentUseList.Name = "gridView_EquipmentUseList";
            this.gridView_EquipmentUseList.OptionsBehavior.Editable = false;
            this.gridView_EquipmentUseList.OptionsCustomization.AllowGroup = false;
            this.gridView_EquipmentUseList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_EquipmentUseList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_EquipmentUseList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_EquipmentUseList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_EquipmentUseList.OptionsLayout.StoreAllOptions = true;
            this.gridView_EquipmentUseList.OptionsLayout.StoreAppearance = true;
            this.gridView_EquipmentUseList.OptionsPrint.PrintPreview = true;
            this.gridView_EquipmentUseList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_EquipmentUseList.OptionsView.ShowFooter = true;
            this.gridView_EquipmentUseList.OptionsView.ShowGroupPanel = false;
            this.gridView_EquipmentUseList.OptionsView.ShowIndicator = false;
            this.gridView_EquipmentUseList.PaintStyleName = "Skin";
            this.gridView_EquipmentUseList.RowHeight = 20;
            this.gridView_EquipmentUseList.DoubleClick += new System.EventHandler(this.buttonItemEditEquipmentUse_Click);
            // 
            // EquipmentUseId
            // 
            this.EquipmentUseId.Caption = "کد تجهیزات مصرفی";
            this.EquipmentUseId.FieldName = "Id";
            this.EquipmentUseId.Name = "EquipmentUseId";
            this.EquipmentUseId.Visible = true;
            this.EquipmentUseId.VisibleIndex = 1;
            this.EquipmentUseId.Width = 174;
            // 
            // EquipmentUseDsc
            // 
            this.EquipmentUseDsc.Caption = "عنوان تجهیزات مصرفی";
            this.EquipmentUseDsc.FieldName = "TitleName";
            this.EquipmentUseDsc.Name = "EquipmentUseDsc";
            this.EquipmentUseDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.EquipmentUseDsc.Visible = true;
            this.EquipmentUseDsc.VisibleIndex = 0;
            this.EquipmentUseDsc.Width = 341;
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
            this.buttonItemAddEquipmentUse,
            this.buttonItemEditEquipmentUse,
            this.buttonItemDelEquipmentUse,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemEquipmentUsePrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddEquipmentUse
            // 
            this.buttonItemAddEquipmentUse.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddEquipmentUse.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddEquipmentUse.Image = global::MehrParvarPrj.Properties.Resources.advancedsettings;
            this.buttonItemAddEquipmentUse.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddEquipmentUse.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddEquipmentUse.Name = "buttonItemAddEquipmentUse";
            this.buttonItemAddEquipmentUse.Text = "ثبت تجهیزات مصرفی جدید";
            this.buttonItemAddEquipmentUse.ThemeAware = true;
            this.buttonItemAddEquipmentUse.Click += new System.EventHandler(this.buttonItemAddEquipmentUse_Click);
            // 
            // buttonItemEditEquipmentUse
            // 
            this.buttonItemEditEquipmentUse.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditEquipmentUse.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditEquipmentUse.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditEquipmentUse.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditEquipmentUse.Name = "buttonItemEditEquipmentUse";
            this.buttonItemEditEquipmentUse.Text = "ویرایش";
            this.buttonItemEditEquipmentUse.ThemeAware = true;
            this.buttonItemEditEquipmentUse.Click += new System.EventHandler(this.buttonItemEditEquipmentUse_Click);
            // 
            // buttonItemDelEquipmentUse
            // 
            this.buttonItemDelEquipmentUse.BeginGroup = true;
            this.buttonItemDelEquipmentUse.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelEquipmentUse.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelEquipmentUse.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelEquipmentUse.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelEquipmentUse.Name = "buttonItemDelEquipmentUse";
            this.buttonItemDelEquipmentUse.Text = "حذف";
            this.buttonItemDelEquipmentUse.ThemeAware = true;
            this.buttonItemDelEquipmentUse.Click += new System.EventHandler(this.buttonItemDelEquipmentUse_Click);
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
            // buttonItemEquipmentUsePrintList
            // 
            this.buttonItemEquipmentUsePrintList.BeginGroup = true;
            this.buttonItemEquipmentUsePrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEquipmentUsePrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEquipmentUsePrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemEquipmentUsePrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEquipmentUsePrintList.Name = "buttonItemEquipmentUsePrintList";
            this.buttonItemEquipmentUsePrintList.Text = "چاپ لیست";
            this.buttonItemEquipmentUsePrintList.ThemeAware = true;
            this.buttonItemEquipmentUsePrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // EquipmentUseList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_EquipmentUseList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EquipmentUseList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست تجهیزات مصرفی";
            this.Load += new System.EventHandler(this.EquipmentUseList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_EquipmentUseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_EquipmentUseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_EquipmentUseList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_EquipmentUseList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditEquipmentUse;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelEquipmentUse;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemEquipmentUsePrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddEquipmentUse;
        private DevExpress.XtraGrid.Columns.GridColumn EquipmentUseDsc;
        private DevExpress.XtraGrid.Columns.GridColumn EquipmentUseId;
    }
}