namespace MehrParvarPrj
{
    partial class MartyrsList_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MartyrsList_UC));
            this.textboxitem_status = new DevComponents.DotNetBar.TextBoxItem();
            this.buttonItem_StatusOK = new DevComponents.DotNetBar.ButtonItem();
            this.itemPanelCar = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItem_MartyrsNew = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemMartyrsEdit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemMartyrsDel = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemMartyrsSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemMartyrsPrintList = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemExcelExportMartyr = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.gridControl_MartyrsList = new DevExpress.XtraGrid.GridControl();
            this.gridView_MartyrsList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MartyrId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrNameFamily = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrFew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DosiersNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrithDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrLocation1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DosiersNo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrithDate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrLocation2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrDate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrName3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DosiersNo3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrithDate3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrLocation3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MartyrDate3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.NationalCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NationalCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NationalCode3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_MartyrsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_MartyrsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxitem_status
            // 
            this.textboxitem_status.Name = "textboxitem_status";
            this.textboxitem_status.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // buttonItem_StatusOK
            // 
            this.buttonItem_StatusOK.ForeColor = System.Drawing.Color.Black;
            this.buttonItem_StatusOK.HotFontBold = true;
            this.buttonItem_StatusOK.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem_StatusOK.Icon")));
            this.buttonItem_StatusOK.Name = "buttonItem_StatusOK";
            this.buttonItem_StatusOK.Text = "تایید";
            // 
            // itemPanelCar
            // 
            // 
            // 
            // 
            this.itemPanelCar.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.itemPanelCar.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.itemPanelCar.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanelCar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelCar.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelCar.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelCar.BackgroundStyle.PaddingRight = 1;
            this.itemPanelCar.BackgroundStyle.PaddingTop = 1;
            this.itemPanelCar.ContainerControlProcessDialogKey = true;
            this.itemPanelCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelCar.FitButtonsToContainerWidth = true;
            this.itemPanelCar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelCar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelCar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_MartyrsNew,
            this.buttonItemMartyrsEdit,
            this.buttonItemMartyrsDel,
            this.buttonItemMartyrsSearch,
            this.buttonItemSelector,
            this.buttonItemMartyrsPrintList,
            this.buttonItemExcelExportMartyr,
            this.buttonItemRefresh});
            this.itemPanelCar.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemPanelCar.Name = "itemPanelCar";
            this.itemPanelCar.Size = new System.Drawing.Size(848, 57);
            this.itemPanelCar.TabIndex = 40;
            this.itemPanelCar.ThemeAware = true;
            // 
            // buttonItem_MartyrsNew
            // 
            this.buttonItem_MartyrsNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_MartyrsNew.ForeColor = System.Drawing.Color.Gold;
            this.buttonItem_MartyrsNew.Image = global::MehrParvarPrj.Properties.Resources.agt_login;
            this.buttonItem_MartyrsNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_MartyrsNew.Name = "buttonItem_MartyrsNew";
            this.buttonItem_MartyrsNew.Text = "ثبت خانواده شهدا";
            this.buttonItem_MartyrsNew.ThemeAware = true;
            this.buttonItem_MartyrsNew.Click += new System.EventHandler(this.buttonItem_MartyrsNew_Click);
            // 
            // buttonItemMartyrsEdit
            // 
            this.buttonItemMartyrsEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemMartyrsEdit.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemMartyrsEdit.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemMartyrsEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemMartyrsEdit.Name = "buttonItemMartyrsEdit";
            this.buttonItemMartyrsEdit.Text = "ویرایش";
            this.buttonItemMartyrsEdit.ThemeAware = true;
            this.buttonItemMartyrsEdit.Click += new System.EventHandler(this.buttonItemMartyrsEdit_Click);
            // 
            // buttonItemMartyrsDel
            // 
            this.buttonItemMartyrsDel.BeginGroup = true;
            this.buttonItemMartyrsDel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemMartyrsDel.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemMartyrsDel.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemMartyrsDel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemMartyrsDel.Name = "buttonItemMartyrsDel";
            this.buttonItemMartyrsDel.Text = "حذف";
            this.buttonItemMartyrsDel.ThemeAware = true;
            this.buttonItemMartyrsDel.Click += new System.EventHandler(this.buttonItemMartyrsDel_Click);
            // 
            // buttonItemMartyrsSearch
            // 
            this.buttonItemMartyrsSearch.AutoCheckOnClick = true;
            this.buttonItemMartyrsSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemMartyrsSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemMartyrsSearch.Image = global::MehrParvarPrj.Properties.Resources.SearchImage;
            this.buttonItemMartyrsSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemMartyrsSearch.Name = "buttonItemMartyrsSearch";
            this.buttonItemMartyrsSearch.Text = "جستجو";
            this.buttonItemMartyrsSearch.ThemeAware = true;
            this.buttonItemMartyrsSearch.Click += new System.EventHandler(this.buttonItemMartyrsSearch_Click);
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
            // buttonItemMartyrsPrintList
            // 
            this.buttonItemMartyrsPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemMartyrsPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemMartyrsPrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemMartyrsPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemMartyrsPrintList.Name = "buttonItemMartyrsPrintList";
            this.buttonItemMartyrsPrintList.Text = "چاپ لیست";
            this.buttonItemMartyrsPrintList.ThemeAware = true;
            this.buttonItemMartyrsPrintList.Click += new System.EventHandler(this.buttonItemMartyrsPrintList_Click);
            // 
            // buttonItemExcelExportMartyr
            // 
            this.buttonItemExcelExportMartyr.BeginGroup = true;
            this.buttonItemExcelExportMartyr.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemExcelExportMartyr.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemExcelExportMartyr.Image = global::MehrParvarPrj.Properties.Resources.MiniExcel;
            this.buttonItemExcelExportMartyr.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemExcelExportMartyr.Name = "buttonItemExcelExportMartyr";
            this.buttonItemExcelExportMartyr.Text = "ارسال به اکسل";
            this.buttonItemExcelExportMartyr.ThemeAware = true;
            this.buttonItemExcelExportMartyr.Click += new System.EventHandler(this.buttonItemExcelExportMartyr_Click);
            // 
            // buttonItemRefresh
            // 
            this.buttonItemRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemRefresh.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemRefresh.Image = global::MehrParvarPrj.Properties.Resources.agt_reload;
            this.buttonItemRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemRefresh.Name = "buttonItemRefresh";
            this.buttonItemRefresh.Text = "بازخوانی اطلاعات";
            this.buttonItemRefresh.ThemeAware = true;
            this.buttonItemRefresh.Click += new System.EventHandler(this.buttonItemRefresh_Click);
            // 
            // gridControl_MartyrsList
            // 
            this.gridControl_MartyrsList.AllowDrop = true;
            this.gridControl_MartyrsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_MartyrsList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_MartyrsList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_MartyrsList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_MartyrsList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_MartyrsList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_MartyrsList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_MartyrsList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_MartyrsList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_MartyrsList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_MartyrsList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_MartyrsList.MainView = this.gridView_MartyrsList;
            this.gridControl_MartyrsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_MartyrsList.Name = "gridControl_MartyrsList";
            this.gridControl_MartyrsList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl_MartyrsList.Size = new System.Drawing.Size(848, 386);
            this.gridControl_MartyrsList.TabIndex = 41;
            this.gridControl_MartyrsList.UseEmbeddedNavigator = true;
            this.gridControl_MartyrsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_MartyrsList});
            this.gridControl_MartyrsList.DoubleClick += new System.EventHandler(this.buttonItemMartyrsEdit_Click);
            // 
            // gridView_MartyrsList
            // 
            this.gridView_MartyrsList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_MartyrsList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_MartyrsList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_MartyrsList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_MartyrsList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_MartyrsList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_MartyrsList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_MartyrsList.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView_MartyrsList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_MartyrsList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_MartyrsList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_MartyrsList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MartyrId,
            this.MartyrNameFamily,
            this.MartyrFew,
            this.MartyrName1,
            this.DosiersNo1,
            this.NationalCode1,
            this.BrithDate1,
            this.MartyrLocation1,
            this.MartyrDate1,
            this.MartyrName2,
            this.DosiersNo2,
            this.NationalCode2,
            this.BrithDate2,
            this.MartyrLocation2,
            this.MartyrDate2,
            this.MartyrName3,
            this.DosiersNo3,
            this.NationalCode3,
            this.BrithDate3,
            this.MartyrLocation3,
            this.MartyrDate3,
            this.Description});
            this.gridView_MartyrsList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView_MartyrsList.GridControl = this.gridControl_MartyrsList;
            this.gridView_MartyrsList.Name = "gridView_MartyrsList";
            this.gridView_MartyrsList.OptionsBehavior.Editable = false;
            this.gridView_MartyrsList.OptionsCustomization.AllowGroup = false;
            this.gridView_MartyrsList.OptionsCustomization.AllowRowSizing = true;
            this.gridView_MartyrsList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_MartyrsList.OptionsLayout.Columns.StoreLayout = false;
            this.gridView_MartyrsList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView_MartyrsList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_MartyrsList.OptionsView.ShowGroupPanel = false;
            this.gridView_MartyrsList.OptionsView.ShowIndicator = false;
            this.gridView_MartyrsList.RowHeight = 20;
            // 
            // MartyrId
            // 
            this.MartyrId.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.MartyrId.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.MartyrId.AppearanceCell.Options.UseBackColor = true;
            this.MartyrId.Caption = "کد خانواده";
            this.MartyrId.FieldName = "MartyrId";
            this.MartyrId.Name = "MartyrId";
            // 
            // MartyrNameFamily
            // 
            this.MartyrNameFamily.Caption = "نام خانواده شهید";
            this.MartyrNameFamily.FieldName = "MartyrNameFamily";
            this.MartyrNameFamily.Name = "MartyrNameFamily";
            this.MartyrNameFamily.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MartyrNameFamily.Visible = true;
            this.MartyrNameFamily.VisibleIndex = 20;
            this.MartyrNameFamily.Width = 91;
            // 
            // MartyrFew
            // 
            this.MartyrFew.Caption = "تعداد شهید";
            this.MartyrFew.FieldName = "MartyrFew";
            this.MartyrFew.Name = "MartyrFew";
            this.MartyrFew.Visible = true;
            this.MartyrFew.VisibleIndex = 19;
            this.MartyrFew.Width = 37;
            // 
            // MartyrName1
            // 
            this.MartyrName1.Caption = "نام شهید1";
            this.MartyrName1.FieldName = "MartyrName1";
            this.MartyrName1.Name = "MartyrName1";
            this.MartyrName1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MartyrName1.Visible = true;
            this.MartyrName1.VisibleIndex = 18;
            this.MartyrName1.Width = 41;
            // 
            // DosiersNo1
            // 
            this.DosiersNo1.Caption = "شماره پرونده1";
            this.DosiersNo1.FieldName = "DosiersNo1";
            this.DosiersNo1.Name = "DosiersNo1";
            this.DosiersNo1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DosiersNo1.Visible = true;
            this.DosiersNo1.VisibleIndex = 17;
            this.DosiersNo1.Width = 40;
            // 
            // BrithDate1
            // 
            this.BrithDate1.Caption = "تاریخ تولد1";
            this.BrithDate1.FieldName = "BrithDate1";
            this.BrithDate1.Name = "BrithDate1";
            this.BrithDate1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.BrithDate1.Visible = true;
            this.BrithDate1.VisibleIndex = 15;
            this.BrithDate1.Width = 41;
            // 
            // MartyrLocation1
            // 
            this.MartyrLocation1.Caption = "محل شهادت1";
            this.MartyrLocation1.FieldName = "MartyrLocation1";
            this.MartyrLocation1.Name = "MartyrLocation1";
            this.MartyrLocation1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MartyrLocation1.Visible = true;
            this.MartyrLocation1.VisibleIndex = 14;
            this.MartyrLocation1.Width = 41;
            // 
            // MartyrDate1
            // 
            this.MartyrDate1.Caption = "تاریخ شهادت1";
            this.MartyrDate1.FieldName = "MartyrDate1";
            this.MartyrDate1.Name = "MartyrDate1";
            this.MartyrDate1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MartyrDate1.Visible = true;
            this.MartyrDate1.VisibleIndex = 13;
            this.MartyrDate1.Width = 48;
            // 
            // MartyrName2
            // 
            this.MartyrName2.Caption = "نام شهید2";
            this.MartyrName2.FieldName = "MartyrName2";
            this.MartyrName2.Name = "MartyrName2";
            this.MartyrName2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MartyrName2.Visible = true;
            this.MartyrName2.VisibleIndex = 12;
            this.MartyrName2.Width = 48;
            // 
            // DosiersNo2
            // 
            this.DosiersNo2.Caption = "شماره پرونده2";
            this.DosiersNo2.FieldName = "DosiersNo2";
            this.DosiersNo2.Name = "DosiersNo2";
            this.DosiersNo2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DosiersNo2.Visible = true;
            this.DosiersNo2.VisibleIndex = 11;
            this.DosiersNo2.Width = 67;
            // 
            // BrithDate2
            // 
            this.BrithDate2.Caption = "تاریخ تولد2";
            this.BrithDate2.FieldName = "BrithDate2";
            this.BrithDate2.Name = "BrithDate2";
            this.BrithDate2.Visible = true;
            this.BrithDate2.VisibleIndex = 9;
            this.BrithDate2.Width = 48;
            // 
            // MartyrLocation2
            // 
            this.MartyrLocation2.Caption = "محل شهادت2";
            this.MartyrLocation2.FieldName = "MartyrLocation2";
            this.MartyrLocation2.Name = "MartyrLocation2";
            this.MartyrLocation2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MartyrLocation2.Visible = true;
            this.MartyrLocation2.VisibleIndex = 8;
            this.MartyrLocation2.Width = 48;
            // 
            // MartyrDate2
            // 
            this.MartyrDate2.Caption = "تاریخ شهادت2";
            this.MartyrDate2.FieldName = "MartyrDate2";
            this.MartyrDate2.Name = "MartyrDate2";
            this.MartyrDate2.Visible = true;
            this.MartyrDate2.VisibleIndex = 7;
            this.MartyrDate2.Width = 48;
            // 
            // MartyrName3
            // 
            this.MartyrName3.Caption = "نام شهید3";
            this.MartyrName3.FieldName = "MartyrName3";
            this.MartyrName3.Name = "MartyrName3";
            this.MartyrName3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MartyrName3.Visible = true;
            this.MartyrName3.VisibleIndex = 6;
            this.MartyrName3.Width = 48;
            // 
            // DosiersNo3
            // 
            this.DosiersNo3.Caption = "شماره پرونده3";
            this.DosiersNo3.FieldName = "DosiersNo3";
            this.DosiersNo3.Name = "DosiersNo3";
            this.DosiersNo3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DosiersNo3.Visible = true;
            this.DosiersNo3.VisibleIndex = 5;
            this.DosiersNo3.Width = 40;
            // 
            // BrithDate3
            // 
            this.BrithDate3.Caption = "تاریخ تولد3";
            this.BrithDate3.FieldName = "BrithDate3";
            this.BrithDate3.Name = "BrithDate3";
            this.BrithDate3.Visible = true;
            this.BrithDate3.VisibleIndex = 3;
            this.BrithDate3.Width = 40;
            // 
            // MartyrLocation3
            // 
            this.MartyrLocation3.Caption = "محل شهادت3";
            this.MartyrLocation3.FieldName = "MartyrLocation3";
            this.MartyrLocation3.Name = "MartyrLocation3";
            this.MartyrLocation3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.MartyrLocation3.Visible = true;
            this.MartyrLocation3.VisibleIndex = 2;
            this.MartyrLocation3.Width = 40;
            // 
            // MartyrDate3
            // 
            this.MartyrDate3.Caption = "تاریخ شهادت3";
            this.MartyrDate3.FieldName = "MartyrDate3";
            this.MartyrDate3.Name = "MartyrDate3";
            this.MartyrDate3.Visible = true;
            this.MartyrDate3.VisibleIndex = 1;
            this.MartyrDate3.Width = 40;
            // 
            // Description
            // 
            this.Description.Caption = "توضیحات";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 0;
            this.Description.Width = 40;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // NationalCode1
            // 
            this.NationalCode1.Caption = "کد ملی 1";
            this.NationalCode1.FieldName = "NationalCode1";
            this.NationalCode1.Name = "NationalCode1";
            this.NationalCode1.Visible = true;
            this.NationalCode1.VisibleIndex = 16;
            // 
            // NationalCode2
            // 
            this.NationalCode2.Caption = "کد ملی 2";
            this.NationalCode2.FieldName = "NationalCode2";
            this.NationalCode2.Name = "NationalCode2";
            this.NationalCode2.Visible = true;
            this.NationalCode2.VisibleIndex = 10;
            // 
            // NationalCode3
            // 
            this.NationalCode3.Caption = "کدملی 3";
            this.NationalCode3.FieldName = "NationalCode3";
            this.NationalCode3.Name = "NationalCode3";
            this.NationalCode3.Visible = true;
            this.NationalCode3.VisibleIndex = 4;
            // 
            // MartyrsList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_MartyrsList);
            this.Controls.Add(this.itemPanelCar);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(10, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MartyrsList_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(848, 443);
            this.Load += new System.EventHandler(this.MartyrsList_UC_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MartyrsList_UC_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_MartyrsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_MartyrsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TextBoxItem textboxitem_status;
        private DevComponents.DotNetBar.ButtonItem buttonItem_StatusOK;
        private DevComponents.DotNetBar.ItemPanel itemPanelCar;
        private DevComponents.DotNetBar.ButtonItem buttonItemMartyrsEdit;
        private DevComponents.DotNetBar.ButtonItem buttonItemMartyrsDel;
        private DevComponents.DotNetBar.ButtonItem buttonItemMartyrsSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemMartyrsPrintList;
        private DevExpress.XtraGrid.GridControl gridControl_MartyrsList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_MartyrsList;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrId;
        private DevExpress.XtraGrid.Columns.GridColumn DosiersNo1;
        private DevExpress.XtraGrid.Columns.GridColumn BrithDate1;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrFew;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrName1;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrLocation1;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrDate1;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrNameFamily;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevComponents.DotNetBar.ButtonItem buttonItemRefresh;
        private DevComponents.DotNetBar.ButtonItem buttonItem_MartyrsNew;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrName2;
        private DevExpress.XtraGrid.Columns.GridColumn BrithDate2;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrLocation2;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrDate2;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrName3;
        private DevExpress.XtraGrid.Columns.GridColumn BrithDate3;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrLocation3;
        private DevExpress.XtraGrid.Columns.GridColumn MartyrDate3;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevComponents.DotNetBar.ButtonItem buttonItemExcelExportMartyr;
        private DevExpress.XtraGrid.Columns.GridColumn DosiersNo2;
        private DevExpress.XtraGrid.Columns.GridColumn DosiersNo3;
        private DevExpress.XtraGrid.Columns.GridColumn NationalCode1;
        private DevExpress.XtraGrid.Columns.GridColumn NationalCode2;
        private DevExpress.XtraGrid.Columns.GridColumn NationalCode3;
    }
}
