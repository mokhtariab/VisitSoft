namespace MehrParvarPrj
{
    partial class BankList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankList_Frm));
            this.gridControl_BankList = new DevExpress.XtraGrid.GridControl();
            this.gridView_BankList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BankId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddBank = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditBank = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelBank = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemBankPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_BankList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BankList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_BankList
            // 
            this.gridControl_BankList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_BankList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_BankList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_BankList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_BankList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_BankList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_BankList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_BankList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_BankList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_BankList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_BankList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_BankList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_BankList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_BankList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_BankList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_BankList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_BankList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_BankList.MainView = this.gridView_BankList;
            this.gridControl_BankList.Name = "gridControl_BankList";
            this.gridControl_BankList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_BankList.TabIndex = 40;
            this.gridControl_BankList.UseEmbeddedNavigator = true;
            this.gridControl_BankList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_BankList});
            // 
            // gridView_BankList
            // 
            this.gridView_BankList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_BankList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_BankList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_BankList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_BankList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_BankList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_BankList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_BankList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_BankList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_BankList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_BankList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_BankList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_BankList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_BankList.ColumnPanelRowHeight = 25;
            this.gridView_BankList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BankId,
            this.BankDsc});
            this.gridView_BankList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_BankList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_BankList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_BankList.GridControl = this.gridControl_BankList;
            this.gridView_BankList.Name = "gridView_BankList";
            this.gridView_BankList.OptionsBehavior.Editable = false;
            this.gridView_BankList.OptionsCustomization.AllowGroup = false;
            this.gridView_BankList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_BankList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_BankList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_BankList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_BankList.OptionsLayout.StoreAllOptions = true;
            this.gridView_BankList.OptionsLayout.StoreAppearance = true;
            this.gridView_BankList.OptionsPrint.PrintPreview = true;
            this.gridView_BankList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_BankList.OptionsView.ShowFooter = true;
            this.gridView_BankList.OptionsView.ShowGroupPanel = false;
            this.gridView_BankList.OptionsView.ShowIndicator = false;
            this.gridView_BankList.PaintStyleName = "Skin";
            this.gridView_BankList.RowHeight = 20;
            this.gridView_BankList.DoubleClick += new System.EventHandler(this.buttonItemEditBank_Click);
            // 
            // BankId
            // 
            this.BankId.Caption = "کد بانک";
            this.BankId.FieldName = "Id";
            this.BankId.Name = "BankId";
            this.BankId.Visible = true;
            this.BankId.VisibleIndex = 1;
            this.BankId.Width = 100;
            // 
            // BankDsc
            // 
            this.BankDsc.Caption = "عنوان بانک";
            this.BankDsc.FieldName = "TitleName";
            this.BankDsc.Name = "BankDsc";
            this.BankDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.BankDsc.Visible = true;
            this.BankDsc.VisibleIndex = 0;
            this.BankDsc.Width = 426;
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
            this.buttonItemAddBank,
            this.buttonItemEditBank,
            this.buttonItemDelBank,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemBankPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddBank
            // 
            this.buttonItemAddBank.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddBank.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddBank.Image = global::MehrParvarPrj.Properties.Resources.web;
            this.buttonItemAddBank.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddBank.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddBank.Name = "buttonItemAddBank";
            this.buttonItemAddBank.Text = "ثبت بانک جدید";
            this.buttonItemAddBank.ThemeAware = true;
            this.buttonItemAddBank.Click += new System.EventHandler(this.buttonItemAddBank_Click);
            // 
            // buttonItemEditBank
            // 
            this.buttonItemEditBank.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditBank.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditBank.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditBank.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditBank.Name = "buttonItemEditBank";
            this.buttonItemEditBank.Text = "ویرایش";
            this.buttonItemEditBank.ThemeAware = true;
            this.buttonItemEditBank.Click += new System.EventHandler(this.buttonItemEditBank_Click);
            // 
            // buttonItemDelBank
            // 
            this.buttonItemDelBank.BeginGroup = true;
            this.buttonItemDelBank.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelBank.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelBank.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelBank.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelBank.Name = "buttonItemDelBank";
            this.buttonItemDelBank.Text = "حذف";
            this.buttonItemDelBank.ThemeAware = true;
            this.buttonItemDelBank.Click += new System.EventHandler(this.buttonItemDelBank_Click);
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
            // buttonItemBankPrintList
            // 
            this.buttonItemBankPrintList.BeginGroup = true;
            this.buttonItemBankPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemBankPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemBankPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemBankPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemBankPrintList.Name = "buttonItemBankPrintList";
            this.buttonItemBankPrintList.Text = "چاپ لیست";
            this.buttonItemBankPrintList.ThemeAware = true;
            this.buttonItemBankPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // BankList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_BankList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست بانکها";
            this.Load += new System.EventHandler(this.BankList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_BankList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BankList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_BankList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_BankList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditBank;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelBank;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemBankPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddBank;
        private DevExpress.XtraGrid.Columns.GridColumn BankDsc;
        private DevExpress.XtraGrid.Columns.GridColumn BankId;
    }
}