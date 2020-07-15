using DevExpress.XtraBars.Ribbon;

namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new RibbonControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.Co = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMRUEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.imageCollection1;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.Co,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barSubItem1,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barEditItem1});
            this.ribbonControl1.LargeImages = this.imageCollection1;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemMRUEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(615, 141);
            this.ribbonControl1.CustomDrawItem += RibbonControl1_CustomDrawItem;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("add_32x32.png", "images/actions/add_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "add_32x32.png");
            this.imageCollection1.InsertGalleryImage("addfile_32x32.png", "images/actions/addfile_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/addfile_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "addfile_32x32.png");
            this.imageCollection1.InsertGalleryImage("additem_32x32.png", "images/actions/additem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_32x32.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "additem_32x32.png");
            this.imageCollection1.InsertGalleryImage("apply_32x32.png", "images/actions/apply_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "apply_32x32.png");
            this.imageCollection1.InsertGalleryImage("cancel_32x32.png", "images/actions/cancel_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "cancel_32x32.png");
            this.imageCollection1.InsertGalleryImage("clear_32x32.png", "images/actions/clear_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clear_32x32.png"), 5);
            this.imageCollection1.Images.SetKeyName(5, "clear_32x32.png");
            this.imageCollection1.InsertGalleryImage("clearformatting_32x32.png", "images/actions/clearformatting_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clearformatting_32x32.png"), 6);
            this.imageCollection1.Images.SetKeyName(6, "clearformatting_32x32.png");
            this.imageCollection1.InsertGalleryImage("cleartablestyle_32x32.png", "images/actions/cleartablestyle_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cleartablestyle_32x32.png"), 7);
            this.imageCollection1.Images.SetKeyName(7, "cleartablestyle_32x32.png");
            this.imageCollection1.InsertGalleryImage("clip_32x32.png", "images/actions/clip_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clip_32x32.png"), 8);
            this.imageCollection1.Images.SetKeyName(8, "clip_32x32.png");
            this.imageCollection1.InsertGalleryImage("close_32x32.png", "images/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_32x32.png"), 9);
            this.imageCollection1.Images.SetKeyName(9, "close_32x32.png");
            this.imageCollection1.InsertGalleryImage("convert_32x32.png", "images/actions/convert_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/convert_32x32.png"), 10);
            this.imageCollection1.Images.SetKeyName(10, "convert_32x32.png");
            this.imageCollection1.InsertGalleryImage("converttorange_32x32.png", "images/actions/converttorange_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/converttorange_32x32.png"), 11);
            this.imageCollection1.Images.SetKeyName(11, "converttorange_32x32.png");
            this.imageCollection1.InsertGalleryImage("deletelist_32x32.png", "images/actions/deletelist_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist_32x32.png"), 12);
            this.imageCollection1.Images.SetKeyName(12, "deletelist_32x32.png");
            this.imageCollection1.InsertGalleryImage("deletelist2_32x32.png", "images/actions/deletelist2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist2_32x32.png"), 13);
            this.imageCollection1.Images.SetKeyName(13, "deletelist2_32x32.png");
            this.imageCollection1.InsertGalleryImage("down_32x32.png", "images/actions/down_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/down_32x32.png"), 14);
            this.imageCollection1.Images.SetKeyName(14, "down_32x32.png");
            this.imageCollection1.InsertGalleryImage("download_32x32.png", "images/actions/download_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/download_32x32.png"), 15);
            this.imageCollection1.Images.SetKeyName(15, "download_32x32.png");
            this.imageCollection1.InsertGalleryImage("editname_32x32.png", "images/actions/editname_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/editname_32x32.png"), 16);
            this.imageCollection1.Images.SetKeyName(16, "editname_32x32.png");
            this.imageCollection1.InsertGalleryImage("fill_32x32.png", "images/actions/fill_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/fill_32x32.png"), 17);
            this.imageCollection1.Images.SetKeyName(17, "fill_32x32.png");
            this.imageCollection1.InsertGalleryImage("formatastable_32x32.png", "images/actions/formatastable_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/formatastable_32x32.png"), 18);
            this.imageCollection1.Images.SetKeyName(18, "formatastable_32x32.png");
            this.imageCollection1.InsertGalleryImage("group_32x32.png", "images/actions/group_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group_32x32.png"), 19);
            this.imageCollection1.Images.SetKeyName(19, "group_32x32.png");
            this.imageCollection1.InsertGalleryImage("group2_32x32.png", "images/actions/group2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group2_32x32.png"), 20);
            this.imageCollection1.Images.SetKeyName(20, "group2_32x32.png");
            this.imageCollection1.InsertGalleryImage("hide_32x32.png", "images/actions/hide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/hide_32x32.png"), 21);
            this.imageCollection1.Images.SetKeyName(21, "hide_32x32.png");
            this.imageCollection1.InsertGalleryImage("importimage_32x32.png", "images/actions/importimage_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/importimage_32x32.png"), 22);
            this.imageCollection1.Images.SetKeyName(22, "importimage_32x32.png");
            this.imageCollection1.InsertGalleryImage("insert_32x32.png", "images/actions/insert_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/insert_32x32.png"), 23);
            this.imageCollection1.Images.SetKeyName(23, "insert_32x32.png");
            this.imageCollection1.InsertGalleryImage("left_32x32.png", "images/actions/left_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/left_32x32.png"), 24);
            this.imageCollection1.Images.SetKeyName(24, "left_32x32.png");
            this.imageCollection1.InsertGalleryImage("loadfrom_32x32.png", "images/actions/loadfrom_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/loadfrom_32x32.png"), 25);
            this.imageCollection1.Images.SetKeyName(25, "loadfrom_32x32.png");
            this.imageCollection1.InsertGalleryImage("merge_32x32.png", "images/actions/merge_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/merge_32x32.png"), 26);
            this.imageCollection1.Images.SetKeyName(26, "merge_32x32.png");
            this.imageCollection1.InsertGalleryImage("new_32x32.png", "images/actions/new_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/new_32x32.png"), 27);
            this.imageCollection1.Images.SetKeyName(27, "new_32x32.png");
            this.imageCollection1.InsertGalleryImage("newtablestyle_32x32.png", "images/actions/newtablestyle_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/newtablestyle_32x32.png"), 28);
            this.imageCollection1.Images.SetKeyName(28, "newtablestyle_32x32.png");
            this.imageCollection1.InsertGalleryImage("open_32x32.png", "images/actions/open_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open_32x32.png"), 29);
            this.imageCollection1.Images.SetKeyName(29, "open_32x32.png");
            this.imageCollection1.InsertGalleryImage("open2_32x32.png", "images/actions/open2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open2_32x32.png"), 30);
            this.imageCollection1.Images.SetKeyName(30, "open2_32x32.png");
            this.imageCollection1.InsertGalleryImage("openhyperlink_32x32.png", "images/actions/openhyperlink_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_32x32.png"), 31);
            this.imageCollection1.Images.SetKeyName(31, "openhyperlink_32x32.png");
            this.imageCollection1.InsertGalleryImage("reading_32x32.png", "images/actions/reading_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reading_32x32.png"), 32);
            this.imageCollection1.Images.SetKeyName(32, "reading_32x32.png");
            this.imageCollection1.InsertGalleryImage("refresh_32x32.png", "images/actions/refresh_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_32x32.png"), 33);
            this.imageCollection1.Images.SetKeyName(33, "refresh_32x32.png");
            this.imageCollection1.InsertGalleryImage("refresh2_32x32.png", "images/actions/refresh2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh2_32x32.png"), 34);
            this.imageCollection1.Images.SetKeyName(34, "refresh2_32x32.png");
            this.imageCollection1.InsertGalleryImage("remove_32x32.png", "images/actions/remove_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/remove_32x32.png"), 35);
            this.imageCollection1.Images.SetKeyName(35, "remove_32x32.png");
            this.imageCollection1.InsertGalleryImage("removeitem_32x32.png", "images/actions/removeitem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/removeitem_32x32.png"), 36);
            this.imageCollection1.Images.SetKeyName(36, "removeitem_32x32.png");
            this.imageCollection1.InsertGalleryImage("reset_32x32.png", "images/actions/reset_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset_32x32.png"), 37);
            this.imageCollection1.Images.SetKeyName(37, "reset_32x32.png");
            this.imageCollection1.InsertGalleryImage("reset2_32x32.png", "images/actions/reset2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset2_32x32.png"), 38);
            this.imageCollection1.Images.SetKeyName(38, "reset2_32x32.png");
            this.imageCollection1.InsertGalleryImage("right_32x32.png", "images/actions/right_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/right_32x32.png"), 39);
            this.imageCollection1.Images.SetKeyName(39, "right_32x32.png");
            this.imageCollection1.InsertGalleryImage("selectall_32x32.png", "images/actions/selectall_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall_32x32.png"), 40);
            this.imageCollection1.Images.SetKeyName(40, "selectall_32x32.png");
            this.imageCollection1.InsertGalleryImage("selectall2_32x32.png", "images/actions/selectall2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall2_32x32.png"), 41);
            this.imageCollection1.Images.SetKeyName(41, "selectall2_32x32.png");
            this.imageCollection1.InsertGalleryImage("show_32x32.png", "images/actions/show_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_32x32.png"), 42);
            this.imageCollection1.Images.SetKeyName(42, "show_32x32.png");
            this.imageCollection1.InsertGalleryImage("squeeze_32x32.png", "images/actions/squeeze_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/squeeze_32x32.png"), 43);
            this.imageCollection1.Images.SetKeyName(43, "squeeze_32x32.png");
            this.imageCollection1.InsertGalleryImage("stretch_32x32.png", "images/actions/stretch_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/stretch_32x32.png"), 44);
            this.imageCollection1.Images.SetKeyName(44, "stretch_32x32.png");
            this.imageCollection1.InsertGalleryImage("switchrowcolumn_32x32.png", "images/actions/switchrowcolumn_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/switchrowcolumn_32x32.png"), 45);
            this.imageCollection1.Images.SetKeyName(45, "switchrowcolumn_32x32.png");
            this.imageCollection1.InsertGalleryImage("trash_32x32.png", "images/actions/trash_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/trash_32x32.png"), 46);
            this.imageCollection1.Images.SetKeyName(46, "trash_32x32.png");
            this.imageCollection1.InsertGalleryImage("up2_32x32.png", "images/actions/up2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/up2_32x32.png"), 47);
            this.imageCollection1.Images.SetKeyName(47, "up2_32x32.png");
            this.imageCollection1.InsertGalleryImage("alignhorizontalbottom_32x32.png", "images/alignment/alignhorizontalbottom_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignhorizontalbottom_32x32.png"), 48);
            this.imageCollection1.Images.SetKeyName(48, "alignhorizontalbottom_32x32.png");
            this.imageCollection1.InsertGalleryImage("alignhorizontalbottom2_32x32.png", "images/alignment/alignhorizontalbottom2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignhorizontalbottom2_32x32.png"), 49);
            this.imageCollection1.Images.SetKeyName(49, "alignhorizontalbottom2_32x32.png");
            this.imageCollection1.InsertGalleryImage("alignhorizontalcenter_32x32.png", "images/alignment/alignhorizontalcenter_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignhorizontalcenter_32x32.png"), 50);
            this.imageCollection1.Images.SetKeyName(50, "alignhorizontalcenter_32x32.png");
            this.imageCollection1.InsertGalleryImage("alignhorizontalcenter2_32x32.png", "images/alignment/alignhorizontalcenter2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignhorizontalcenter2_32x32.png"), 51);
            this.imageCollection1.Images.SetKeyName(51, "alignhorizontalcenter2_32x32.png");
            this.imageCollection1.InsertGalleryImage("alignhorizontaltop_32x32.png", "images/alignment/alignhorizontaltop_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignhorizontaltop_32x32.png"), 52);
            this.imageCollection1.Images.SetKeyName(52, "alignhorizontaltop_32x32.png");
            this.imageCollection1.InsertGalleryImage("alignhorizontaltop2_32x32.png", "images/alignment/alignhorizontaltop2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignhorizontaltop2_32x32.png"), 53);
            this.imageCollection1.Images.SetKeyName(53, "alignhorizontaltop2_32x32.png");
            // 
            // Co
            // 
            this.Co.Caption = "File";
            this.Co.Id = 7;
            this.Co.ImageOptions.ImageIndex = 0;
            this.Co.ImageOptions.LargeImageIndex = 3;
            this.Co.Name = "Co";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Edit";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.ImageIndex = 3;
            this.barButtonItem1.ImageOptions.LargeImageIndex = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "View";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.ImageOptions.ImageIndex = 2;
            this.barButtonItem2.ImageOptions.LargeImageIndex = 10;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tools";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.ImageOptions.ImageIndex = 1;
            this.barButtonItem3.ImageOptions.LargeImageIndex = 9;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "AddText";
            this.barSubItem1.Id = 11;
            this.barSubItem1.ImageOptions.LargeImage = global::DXSample.Properties.Resources.Mail;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Level1";
            this.barButtonItem4.Id = 14;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Level2";
            this.barButtonItem5.Id = 15;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Data Search";
            this.barEditItem1.Edit = this.repositoryItemMRUEdit1;
            this.barEditItem1.EditWidth = 125;
            this.barEditItem1.Id = 16;
            this.barEditItem1.ImageOptions.ImageIndex = 15;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemMRUEdit1
            // 
            this.repositoryItemMRUEdit1.AutoHeight = false;
            this.repositoryItemMRUEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMRUEdit1.Name = "repositoryItemMRUEdit1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Co);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "References";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barSubItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Search";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 375);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Custom Draw";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraBars.BarButtonItem Co;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit repositoryItemMRUEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}

