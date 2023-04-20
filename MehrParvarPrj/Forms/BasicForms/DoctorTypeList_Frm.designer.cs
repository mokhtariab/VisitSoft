namespace MehrParvarPrj
{
    partial class DoctorTypeList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorTypeList_Frm));
            this.gridControl_DoctorTypeList = new DevExpress.XtraGrid.GridControl();
            this.gridView_DoctorTypeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DoctorTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorTypeDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddDoctorType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditDoctorType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelDoctorType = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorTypePrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DoctorTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoctorTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DoctorTypeList
            // 
            this.gridControl_DoctorTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_DoctorTypeList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_DoctorTypeList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_DoctorTypeList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_DoctorTypeList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_DoctorTypeList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_DoctorTypeList.MainView = this.gridView_DoctorTypeList;
            this.gridControl_DoctorTypeList.Name = "gridControl_DoctorTypeList";
            this.gridControl_DoctorTypeList.Size = new System.Drawing.Size(517, 249);
            this.gridControl_DoctorTypeList.TabIndex = 40;
            this.gridControl_DoctorTypeList.UseEmbeddedNavigator = true;
            this.gridControl_DoctorTypeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DoctorTypeList});
            // 
            // gridView_DoctorTypeList
            // 
            this.gridView_DoctorTypeList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_DoctorTypeList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorTypeList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DoctorTypeList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_DoctorTypeList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DoctorTypeList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DoctorTypeList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorTypeList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DoctorTypeList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_DoctorTypeList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorTypeList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_DoctorTypeList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_DoctorTypeList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DoctorTypeList.ColumnPanelRowHeight = 25;
            this.gridView_DoctorTypeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DoctorTypeId,
            this.DoctorTypeDsc});
            this.gridView_DoctorTypeList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_DoctorTypeList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_DoctorTypeList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_DoctorTypeList.GridControl = this.gridControl_DoctorTypeList;
            this.gridView_DoctorTypeList.Name = "gridView_DoctorTypeList";
            this.gridView_DoctorTypeList.OptionsBehavior.Editable = false;
            this.gridView_DoctorTypeList.OptionsCustomization.AllowGroup = false;
            this.gridView_DoctorTypeList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_DoctorTypeList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_DoctorTypeList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_DoctorTypeList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_DoctorTypeList.OptionsLayout.StoreAllOptions = true;
            this.gridView_DoctorTypeList.OptionsLayout.StoreAppearance = true;
            this.gridView_DoctorTypeList.OptionsPrint.PrintPreview = true;
            this.gridView_DoctorTypeList.OptionsPrint.UsePrintStyles = true;
            this.gridView_DoctorTypeList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_DoctorTypeList.OptionsView.ShowFooter = true;
            this.gridView_DoctorTypeList.OptionsView.ShowGroupPanel = false;
            this.gridView_DoctorTypeList.OptionsView.ShowIndicator = false;
            this.gridView_DoctorTypeList.PaintStyleName = "Skin";
            this.gridView_DoctorTypeList.RowHeight = 20;
            this.gridView_DoctorTypeList.DoubleClick += new System.EventHandler(this.buttonItemEditDoctorType_Click);
            // 
            // DoctorTypeId
            // 
            this.DoctorTypeId.Caption = "کد نوع پزشک";
            this.DoctorTypeId.FieldName = "DoctorTypeId";
            this.DoctorTypeId.Name = "DoctorTypeId";
            this.DoctorTypeId.Visible = true;
            this.DoctorTypeId.VisibleIndex = 1;
            this.DoctorTypeId.Width = 100;
            // 
            // DoctorTypeDsc
            // 
            this.DoctorTypeDsc.Caption = "عنوان نوع پزشک";
            this.DoctorTypeDsc.FieldName = "DoctorTypeDsc";
            this.DoctorTypeDsc.Name = "DoctorTypeDsc";
            this.DoctorTypeDsc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.DoctorTypeDsc.Visible = true;
            this.DoctorTypeDsc.VisibleIndex = 0;
            this.DoctorTypeDsc.Width = 426;
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
            this.itemPanelCarSubRP.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingRight = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingTop = 1;
            this.itemPanelCarSubRP.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelCarSubRP.FitButtonsToContainerWidth = true;
            this.itemPanelCarSubRP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelCarSubRP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelCarSubRP.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemAddDoctorType,
            this.buttonItemEditDoctorType,
            this.buttonItemDelDoctorType,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemDoctorTypePrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(517, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddDoctorType
            // 
            this.buttonItemAddDoctorType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddDoctorType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddDoctorType.Image = global::MehrParvarPrj.Properties.Resources.surgeon;
            this.buttonItemAddDoctorType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemAddDoctorType.ImagePaddingHorizontal = 8;
            this.buttonItemAddDoctorType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddDoctorType.Name = "buttonItemAddDoctorType";
            this.buttonItemAddDoctorType.Text = "ثبت پزشک جدید";
            this.buttonItemAddDoctorType.ThemeAware = true;
            this.buttonItemAddDoctorType.Click += new System.EventHandler(this.buttonItemAddDoctorType_Click);
            // 
            // buttonItemEditDoctorType
            // 
            this.buttonItemEditDoctorType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditDoctorType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditDoctorType.Image = global::MehrParvarPrj.Properties.Resources.EditImage;
            this.buttonItemEditDoctorType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemEditDoctorType.ImagePaddingHorizontal = 8;
            this.buttonItemEditDoctorType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditDoctorType.Name = "buttonItemEditDoctorType";
            this.buttonItemEditDoctorType.Text = "ویرایش";
            this.buttonItemEditDoctorType.ThemeAware = true;
            this.buttonItemEditDoctorType.Click += new System.EventHandler(this.buttonItemEditDoctorType_Click);
            // 
            // buttonItemDelDoctorType
            // 
            this.buttonItemDelDoctorType.BeginGroup = true;
            this.buttonItemDelDoctorType.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelDoctorType.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelDoctorType.Image = global::MehrParvarPrj.Properties.Resources.DelImage;
            this.buttonItemDelDoctorType.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemDelDoctorType.ImagePaddingHorizontal = 8;
            this.buttonItemDelDoctorType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelDoctorType.Name = "buttonItemDelDoctorType";
            this.buttonItemDelDoctorType.Text = "حذف";
            this.buttonItemDelDoctorType.ThemeAware = true;
            this.buttonItemDelDoctorType.Click += new System.EventHandler(this.buttonItemDelDoctorType_Click);
            // 
            // buttonItemCarSubRPSearch
            // 
            this.buttonItemCarSubRPSearch.AutoCheckOnClick = true;
            this.buttonItemCarSubRPSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCarSubRPSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCarSubRPSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCarSubRPSearch.Image")));
            this.buttonItemCarSubRPSearch.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemCarSubRPSearch.ImagePaddingHorizontal = 8;
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
            this.buttonItemSelector.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemSelector.ImagePaddingHorizontal = 8;
            this.buttonItemSelector.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSelector.Name = "buttonItemSelector";
            this.buttonItemSelector.Text = "انتخاب فیلدها";
            this.buttonItemSelector.ThemeAware = true;
            this.buttonItemSelector.Click += new System.EventHandler(this.buttonItemSelector_Click);
            // 
            // buttonItemDoctorTypePrintList
            // 
            this.buttonItemDoctorTypePrintList.BeginGroup = true;
            this.buttonItemDoctorTypePrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorTypePrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorTypePrintList.Image = global::MehrParvarPrj.Properties.Resources.PrintListImage;
            this.buttonItemDoctorTypePrintList.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemDoctorTypePrintList.ImagePaddingHorizontal = 8;
            this.buttonItemDoctorTypePrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorTypePrintList.Name = "buttonItemDoctorTypePrintList";
            this.buttonItemDoctorTypePrintList.Text = "چاپ لیست";
            this.buttonItemDoctorTypePrintList.ThemeAware = true;
            this.buttonItemDoctorTypePrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // DoctorTypeList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.gridControl_DoctorTypeList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorTypeList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست انواع پزشکها";
            this.Load += new System.EventHandler(this.DoctorTypeList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DoctorTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DoctorTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_DoctorTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DoctorTypeList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditDoctorType;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelDoctorType;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorTypePrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddDoctorType;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorTypeDsc;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorTypeId;
    }
}