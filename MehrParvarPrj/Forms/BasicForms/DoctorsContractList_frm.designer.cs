namespace MehrParvarPrj
{
    partial class DoctorsContractList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsContractList_Frm));
            this.gridControl_DoctorsContractList = new DevExpress.XtraGrid.GridControl();
            this.gridView_DoctorsContractList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddDoctorsContract = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditDoctorsContract = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelDoctorsContract = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorsContractPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DoctorsContractList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoctorsContractList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DoctorsContractList
            // 
            this.gridControl_DoctorsContractList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_DoctorsContractList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_DoctorsContractList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_DoctorsContractList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_DoctorsContractList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_DoctorsContractList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_DoctorsContractList.MainView = this.gridView_DoctorsContractList;
            this.gridControl_DoctorsContractList.Name = "gridControl_DoctorsContractList";
            this.gridControl_DoctorsContractList.Size = new System.Drawing.Size(679, 249);
            this.gridControl_DoctorsContractList.TabIndex = 40;
            this.gridControl_DoctorsContractList.UseEmbeddedNavigator = true;
            this.gridControl_DoctorsContractList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DoctorsContractList});
            // 
            // gridView_DoctorsContractList
            // 
            this.gridView_DoctorsContractList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_DoctorsContractList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorsContractList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DoctorsContractList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_DoctorsContractList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DoctorsContractList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DoctorsContractList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorsContractList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DoctorsContractList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_DoctorsContractList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorsContractList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DoctorsContractList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_DoctorsContractList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorsContractList.ColumnPanelRowHeight = 25;
            this.gridView_DoctorsContractList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.ContractNo,
            this.ContractDate,
            this.ContractEndDate,
            this.Active});
            this.gridView_DoctorsContractList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_DoctorsContractList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView_DoctorsContractList.GridControl = this.gridControl_DoctorsContractList;
            this.gridView_DoctorsContractList.Name = "gridView_DoctorsContractList";
            this.gridView_DoctorsContractList.OptionsBehavior.Editable = false;
            this.gridView_DoctorsContractList.OptionsCustomization.AllowGroup = false;
            this.gridView_DoctorsContractList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_DoctorsContractList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_DoctorsContractList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_DoctorsContractList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_DoctorsContractList.OptionsLayout.StoreAllOptions = true;
            this.gridView_DoctorsContractList.OptionsLayout.StoreAppearance = true;
            this.gridView_DoctorsContractList.OptionsPrint.PrintPreview = true;
            this.gridView_DoctorsContractList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_DoctorsContractList.OptionsView.ShowFooter = true;
            this.gridView_DoctorsContractList.OptionsView.ShowGroupPanel = false;
            this.gridView_DoctorsContractList.OptionsView.ShowIndicator = false;
            this.gridView_DoctorsContractList.PaintStyleName = "Skin";
            this.gridView_DoctorsContractList.RowHeight = 20;
            this.gridView_DoctorsContractList.DoubleClick += new System.EventHandler(this.buttonItemEditDoctorsContract_Click);
            // 
            // Id
            // 
            this.Id.Caption = "کد";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 4;
            // 
            // ContractNo
            // 
            this.ContractNo.Caption = "شماره قرارداد";
            this.ContractNo.FieldName = "ContractNo";
            this.ContractNo.Name = "ContractNo";
            this.ContractNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.ContractNo.Visible = true;
            this.ContractNo.VisibleIndex = 3;
            // 
            // ContractDate
            // 
            this.ContractDate.Caption = "تاریخ شروع قرارداد";
            this.ContractDate.FieldName = "ContractDate";
            this.ContractDate.Name = "ContractDate";
            this.ContractDate.Visible = true;
            this.ContractDate.VisibleIndex = 2;
            // 
            // ContractEndDate
            // 
            this.ContractEndDate.Caption = "تاریخ اتمام قرارداد";
            this.ContractEndDate.FieldName = "ContractEndDate";
            this.ContractEndDate.Name = "ContractEndDate";
            this.ContractEndDate.Visible = true;
            this.ContractEndDate.VisibleIndex = 1;
            // 
            // Active
            // 
            this.Active.Caption = "فعال";
            this.Active.FieldName = "Active";
            this.Active.Name = "Active";
            this.Active.Visible = true;
            this.Active.VisibleIndex = 0;
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
            this.buttonItemAddDoctorsContract,
            this.buttonItemEditDoctorsContract,
            this.buttonItemDelDoctorsContract,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemDoctorsContractPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(679, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddDoctorsContract
            // 
            this.buttonItemAddDoctorsContract.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddDoctorsContract.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddDoctorsContract.Image = global::MehrParvarPrj.Properties.Resources.surgeon;
            this.buttonItemAddDoctorsContract.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddDoctorsContract.Name = "buttonItemAddDoctorsContract";
            this.buttonItemAddDoctorsContract.Text = "جدید";
            this.buttonItemAddDoctorsContract.ThemeAware = true;
            this.buttonItemAddDoctorsContract.Click += new System.EventHandler(this.buttonItemAddDoctorsContract_Click);
            // 
            // buttonItemEditDoctorsContract
            // 
            this.buttonItemEditDoctorsContract.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditDoctorsContract.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditDoctorsContract.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditDoctorsContract.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditDoctorsContract.Name = "buttonItemEditDoctorsContract";
            this.buttonItemEditDoctorsContract.Text = "ویرایش";
            this.buttonItemEditDoctorsContract.ThemeAware = true;
            this.buttonItemEditDoctorsContract.Click += new System.EventHandler(this.buttonItemEditDoctorsContract_Click);
            // 
            // buttonItemDelDoctorsContract
            // 
            this.buttonItemDelDoctorsContract.BeginGroup = true;
            this.buttonItemDelDoctorsContract.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelDoctorsContract.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelDoctorsContract.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelDoctorsContract.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelDoctorsContract.Name = "buttonItemDelDoctorsContract";
            this.buttonItemDelDoctorsContract.Text = "حذف";
            this.buttonItemDelDoctorsContract.ThemeAware = true;
            this.buttonItemDelDoctorsContract.Click += new System.EventHandler(this.buttonItemDelDoctorsContract_Click);
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
            // buttonItemDoctorsContractPrintList
            // 
            this.buttonItemDoctorsContractPrintList.BeginGroup = true;
            this.buttonItemDoctorsContractPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorsContractPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorsContractPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemDoctorsContractPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorsContractPrintList.Name = "buttonItemDoctorsContractPrintList";
            this.buttonItemDoctorsContractPrintList.Text = "چاپ لیست";
            this.buttonItemDoctorsContractPrintList.ThemeAware = true;
            this.buttonItemDoctorsContractPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // DoctorsContractList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 306);
            this.Controls.Add(this.gridControl_DoctorsContractList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "DoctorsContractList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قرارداد پزشک";
            this.Load += new System.EventHandler(this.DoctorsContractList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DoctorsContractList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoctorsContractList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_DoctorsContractList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DoctorsContractList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditDoctorsContract;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelDoctorsContract;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorsContractPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddDoctorsContract;
        private DevExpress.XtraGrid.Columns.GridColumn ContractNo;
        private DevExpress.XtraGrid.Columns.GridColumn ContractDate;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn ContractEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
    }
}