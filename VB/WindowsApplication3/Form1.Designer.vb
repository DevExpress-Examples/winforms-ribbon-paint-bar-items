Imports DevExpress.XtraBars.Ribbon

Namespace DXSample

    Partial Class Main

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DXSample.Main))
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.Co = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemMRUEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMRUEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ApplicationButtonText = Nothing
            Me.ribbonControl1.AutoSizeItems = True
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Images = Me.imageCollection1
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.Co, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barSubItem1, Me.barButtonItem4, Me.barButtonItem5, Me.barEditItem1})
            Me.ribbonControl1.LargeImages = Me.imageCollection1
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 17
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.ribbonPage2, Me.ribbonPage3})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemMRUEdit1})
            Me.ribbonControl1.Size = New System.Drawing.Size(615, 141)
            AddHandler Me.ribbonControl1.CustomDrawItem, AddressOf Me.RibbonControl1_CustomDrawItem
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.InsertGalleryImage("add_32x32.png", "images/actions/add_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/add_32x32.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "add_32x32.png")
            Me.imageCollection1.InsertGalleryImage("addfile_32x32.png", "images/actions/addfile_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/addfile_32x32.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "addfile_32x32.png")
            Me.imageCollection1.InsertGalleryImage("additem_32x32.png", "images/actions/additem_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/additem_32x32.png"), 2)
            Me.imageCollection1.Images.SetKeyName(2, "additem_32x32.png")
            Me.imageCollection1.InsertGalleryImage("apply_32x32.png", "images/actions/apply_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/apply_32x32.png"), 3)
            Me.imageCollection1.Images.SetKeyName(3, "apply_32x32.png")
            Me.imageCollection1.InsertGalleryImage("cancel_32x32.png", "images/actions/cancel_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/cancel_32x32.png"), 4)
            Me.imageCollection1.Images.SetKeyName(4, "cancel_32x32.png")
            Me.imageCollection1.InsertGalleryImage("clear_32x32.png", "images/actions/clear_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/clear_32x32.png"), 5)
            Me.imageCollection1.Images.SetKeyName(5, "clear_32x32.png")
            Me.imageCollection1.InsertGalleryImage("clearformatting_32x32.png", "images/actions/clearformatting_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/clearformatting_32x32.png"), 6)
            Me.imageCollection1.Images.SetKeyName(6, "clearformatting_32x32.png")
            Me.imageCollection1.InsertGalleryImage("cleartablestyle_32x32.png", "images/actions/cleartablestyle_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/cleartablestyle_32x32.png"), 7)
            Me.imageCollection1.Images.SetKeyName(7, "cleartablestyle_32x32.png")
            Me.imageCollection1.InsertGalleryImage("clip_32x32.png", "images/actions/clip_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/clip_32x32.png"), 8)
            Me.imageCollection1.Images.SetKeyName(8, "clip_32x32.png")
            Me.imageCollection1.InsertGalleryImage("close_32x32.png", "images/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/close_32x32.png"), 9)
            Me.imageCollection1.Images.SetKeyName(9, "close_32x32.png")
            Me.imageCollection1.InsertGalleryImage("convert_32x32.png", "images/actions/convert_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/convert_32x32.png"), 10)
            Me.imageCollection1.Images.SetKeyName(10, "convert_32x32.png")
            Me.imageCollection1.InsertGalleryImage("converttorange_32x32.png", "images/actions/converttorange_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/converttorange_32x32.png"), 11)
            Me.imageCollection1.Images.SetKeyName(11, "converttorange_32x32.png")
            Me.imageCollection1.InsertGalleryImage("deletelist_32x32.png", "images/actions/deletelist_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/deletelist_32x32.png"), 12)
            Me.imageCollection1.Images.SetKeyName(12, "deletelist_32x32.png")
            Me.imageCollection1.InsertGalleryImage("deletelist2_32x32.png", "images/actions/deletelist2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/deletelist2_32x32.png"), 13)
            Me.imageCollection1.Images.SetKeyName(13, "deletelist2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("down_32x32.png", "images/actions/down_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/down_32x32.png"), 14)
            Me.imageCollection1.Images.SetKeyName(14, "down_32x32.png")
            Me.imageCollection1.InsertGalleryImage("download_32x32.png", "images/actions/download_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/download_32x32.png"), 15)
            Me.imageCollection1.Images.SetKeyName(15, "download_32x32.png")
            Me.imageCollection1.InsertGalleryImage("editname_32x32.png", "images/actions/editname_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/editname_32x32.png"), 16)
            Me.imageCollection1.Images.SetKeyName(16, "editname_32x32.png")
            Me.imageCollection1.InsertGalleryImage("fill_32x32.png", "images/actions/fill_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/fill_32x32.png"), 17)
            Me.imageCollection1.Images.SetKeyName(17, "fill_32x32.png")
            Me.imageCollection1.InsertGalleryImage("formatastable_32x32.png", "images/actions/formatastable_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/formatastable_32x32.png"), 18)
            Me.imageCollection1.Images.SetKeyName(18, "formatastable_32x32.png")
            Me.imageCollection1.InsertGalleryImage("group_32x32.png", "images/actions/group_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/group_32x32.png"), 19)
            Me.imageCollection1.Images.SetKeyName(19, "group_32x32.png")
            Me.imageCollection1.InsertGalleryImage("group2_32x32.png", "images/actions/group2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/group2_32x32.png"), 20)
            Me.imageCollection1.Images.SetKeyName(20, "group2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("hide_32x32.png", "images/actions/hide_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/hide_32x32.png"), 21)
            Me.imageCollection1.Images.SetKeyName(21, "hide_32x32.png")
            Me.imageCollection1.InsertGalleryImage("importimage_32x32.png", "images/actions/importimage_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/importimage_32x32.png"), 22)
            Me.imageCollection1.Images.SetKeyName(22, "importimage_32x32.png")
            Me.imageCollection1.InsertGalleryImage("insert_32x32.png", "images/actions/insert_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/insert_32x32.png"), 23)
            Me.imageCollection1.Images.SetKeyName(23, "insert_32x32.png")
            Me.imageCollection1.InsertGalleryImage("left_32x32.png", "images/actions/left_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/left_32x32.png"), 24)
            Me.imageCollection1.Images.SetKeyName(24, "left_32x32.png")
            Me.imageCollection1.InsertGalleryImage("loadfrom_32x32.png", "images/actions/loadfrom_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/loadfrom_32x32.png"), 25)
            Me.imageCollection1.Images.SetKeyName(25, "loadfrom_32x32.png")
            Me.imageCollection1.InsertGalleryImage("merge_32x32.png", "images/actions/merge_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/merge_32x32.png"), 26)
            Me.imageCollection1.Images.SetKeyName(26, "merge_32x32.png")
            Me.imageCollection1.InsertGalleryImage("new_32x32.png", "images/actions/new_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/new_32x32.png"), 27)
            Me.imageCollection1.Images.SetKeyName(27, "new_32x32.png")
            Me.imageCollection1.InsertGalleryImage("newtablestyle_32x32.png", "images/actions/newtablestyle_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/newtablestyle_32x32.png"), 28)
            Me.imageCollection1.Images.SetKeyName(28, "newtablestyle_32x32.png")
            Me.imageCollection1.InsertGalleryImage("open_32x32.png", "images/actions/open_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/open_32x32.png"), 29)
            Me.imageCollection1.Images.SetKeyName(29, "open_32x32.png")
            Me.imageCollection1.InsertGalleryImage("open2_32x32.png", "images/actions/open2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/open2_32x32.png"), 30)
            Me.imageCollection1.Images.SetKeyName(30, "open2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("openhyperlink_32x32.png", "images/actions/openhyperlink_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/openhyperlink_32x32.png"), 31)
            Me.imageCollection1.Images.SetKeyName(31, "openhyperlink_32x32.png")
            Me.imageCollection1.InsertGalleryImage("reading_32x32.png", "images/actions/reading_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/reading_32x32.png"), 32)
            Me.imageCollection1.Images.SetKeyName(32, "reading_32x32.png")
            Me.imageCollection1.InsertGalleryImage("refresh_32x32.png", "images/actions/refresh_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/refresh_32x32.png"), 33)
            Me.imageCollection1.Images.SetKeyName(33, "refresh_32x32.png")
            Me.imageCollection1.InsertGalleryImage("refresh2_32x32.png", "images/actions/refresh2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/refresh2_32x32.png"), 34)
            Me.imageCollection1.Images.SetKeyName(34, "refresh2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("remove_32x32.png", "images/actions/remove_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/remove_32x32.png"), 35)
            Me.imageCollection1.Images.SetKeyName(35, "remove_32x32.png")
            Me.imageCollection1.InsertGalleryImage("removeitem_32x32.png", "images/actions/removeitem_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/removeitem_32x32.png"), 36)
            Me.imageCollection1.Images.SetKeyName(36, "removeitem_32x32.png")
            Me.imageCollection1.InsertGalleryImage("reset_32x32.png", "images/actions/reset_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/reset_32x32.png"), 37)
            Me.imageCollection1.Images.SetKeyName(37, "reset_32x32.png")
            Me.imageCollection1.InsertGalleryImage("reset2_32x32.png", "images/actions/reset2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/reset2_32x32.png"), 38)
            Me.imageCollection1.Images.SetKeyName(38, "reset2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("right_32x32.png", "images/actions/right_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/right_32x32.png"), 39)
            Me.imageCollection1.Images.SetKeyName(39, "right_32x32.png")
            Me.imageCollection1.InsertGalleryImage("selectall_32x32.png", "images/actions/selectall_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/selectall_32x32.png"), 40)
            Me.imageCollection1.Images.SetKeyName(40, "selectall_32x32.png")
            Me.imageCollection1.InsertGalleryImage("selectall2_32x32.png", "images/actions/selectall2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/selectall2_32x32.png"), 41)
            Me.imageCollection1.Images.SetKeyName(41, "selectall2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("show_32x32.png", "images/actions/show_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/show_32x32.png"), 42)
            Me.imageCollection1.Images.SetKeyName(42, "show_32x32.png")
            Me.imageCollection1.InsertGalleryImage("squeeze_32x32.png", "images/actions/squeeze_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/squeeze_32x32.png"), 43)
            Me.imageCollection1.Images.SetKeyName(43, "squeeze_32x32.png")
            Me.imageCollection1.InsertGalleryImage("stretch_32x32.png", "images/actions/stretch_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/stretch_32x32.png"), 44)
            Me.imageCollection1.Images.SetKeyName(44, "stretch_32x32.png")
            Me.imageCollection1.InsertGalleryImage("switchrowcolumn_32x32.png", "images/actions/switchrowcolumn_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/switchrowcolumn_32x32.png"), 45)
            Me.imageCollection1.Images.SetKeyName(45, "switchrowcolumn_32x32.png")
            Me.imageCollection1.InsertGalleryImage("trash_32x32.png", "images/actions/trash_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/trash_32x32.png"), 46)
            Me.imageCollection1.Images.SetKeyName(46, "trash_32x32.png")
            Me.imageCollection1.InsertGalleryImage("up2_32x32.png", "images/actions/up2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/up2_32x32.png"), 47)
            Me.imageCollection1.Images.SetKeyName(47, "up2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("alignhorizontalbottom_32x32.png", "images/alignment/alignhorizontalbottom_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/alignment/alignhorizontalbottom_32x32.png"), 48)
            Me.imageCollection1.Images.SetKeyName(48, "alignhorizontalbottom_32x32.png")
            Me.imageCollection1.InsertGalleryImage("alignhorizontalbottom2_32x32.png", "images/alignment/alignhorizontalbottom2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/alignment/alignhorizontalbottom2_32x32.png"), 49)
            Me.imageCollection1.Images.SetKeyName(49, "alignhorizontalbottom2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("alignhorizontalcenter_32x32.png", "images/alignment/alignhorizontalcenter_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/alignment/alignhorizontalcenter_32x32.png"), 50)
            Me.imageCollection1.Images.SetKeyName(50, "alignhorizontalcenter_32x32.png")
            Me.imageCollection1.InsertGalleryImage("alignhorizontalcenter2_32x32.png", "images/alignment/alignhorizontalcenter2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/alignment/alignhorizontalcenter2_32x32.png"), 51)
            Me.imageCollection1.Images.SetKeyName(51, "alignhorizontalcenter2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("alignhorizontaltop_32x32.png", "images/alignment/alignhorizontaltop_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/alignment/alignhorizontaltop_32x32.png"), 52)
            Me.imageCollection1.Images.SetKeyName(52, "alignhorizontaltop_32x32.png")
            Me.imageCollection1.InsertGalleryImage("alignhorizontaltop2_32x32.png", "images/alignment/alignhorizontaltop2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/alignment/alignhorizontaltop2_32x32.png"), 53)
            Me.imageCollection1.Images.SetKeyName(53, "alignhorizontaltop2_32x32.png")
            ' 
            ' Co
            ' 
            Me.Co.Caption = "File"
            Me.Co.Id = 7
            Me.Co.ImageOptions.ImageIndex = 0
            Me.Co.ImageOptions.LargeImageIndex = 3
            Me.Co.Name = "Co"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Edit"
            Me.barButtonItem1.Id = 8
            Me.barButtonItem1.ImageOptions.ImageIndex = 3
            Me.barButtonItem1.ImageOptions.LargeImageIndex = 13
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "View"
            Me.barButtonItem2.Id = 9
            Me.barButtonItem2.ImageOptions.ImageIndex = 2
            Me.barButtonItem2.ImageOptions.LargeImageIndex = 10
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Tools"
            Me.barButtonItem3.Id = 10
            Me.barButtonItem3.ImageOptions.ImageIndex = 1
            Me.barButtonItem3.ImageOptions.LargeImageIndex = 9
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "AddText"
            Me.barSubItem1.Id = 11
            Me.barSubItem1.ImageOptions.LargeImage = Global.DXSample.Properties.Resources.Mail
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5)})
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "Level1"
            Me.barButtonItem4.Id = 14
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "Level2"
            Me.barButtonItem5.Id = 15
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.Caption = "Data Search"
            Me.barEditItem1.Edit = Me.repositoryItemMRUEdit1
            Me.barEditItem1.EditWidth = 125
            Me.barEditItem1.Id = 16
            Me.barEditItem1.ImageOptions.ImageIndex = 15
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' repositoryItemMRUEdit1
            ' 
            Me.repositoryItemMRUEdit1.AutoHeight = False
            Me.repositoryItemMRUEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMRUEdit1.Name = "repositoryItemMRUEdit1"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.Co)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem3)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' ribbonPage2
            ' 
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup2})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "References"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barSubItem1)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "ribbonPageGroup2"
            ' 
            ' ribbonPage3
            ' 
            Me.ribbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup3})
            Me.ribbonPage3.Name = "ribbonPage3"
            Me.ribbonPage3.Text = "Search"
            ' 
            ' ribbonPageGroup3
            ' 
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barEditItem1)
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "ribbonPageGroup3"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(615, 375)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Main"
            Me.Text = "Custom Draw"
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMRUEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private Co As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private barSubItem1 As DevExpress.XtraBars.BarSubItem

        Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem

        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemMRUEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace
