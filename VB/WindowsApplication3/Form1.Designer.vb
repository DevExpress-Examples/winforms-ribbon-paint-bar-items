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
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.ribbonControl1 = New DXSample.MyRibbonControl()
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
            CType((Me.repositoryItemMRUEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = CType((resources.GetObject("imageList1.ImageStream")), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "Basket.png")
            Me.imageList1.Images.SetKeyName(1, "Check.png")
            Me.imageList1.Images.SetKeyName(2, "Customer.png")
            Me.imageList1.Images.SetKeyName(3, "Folder.png")
            Me.imageList1.Images.SetKeyName(4, "Home.png")
            Me.imageList1.Images.SetKeyName(5, "Key.png")
            Me.imageList1.Images.SetKeyName(6, "Mail.png")
            Me.imageList1.Images.SetKeyName(7, "Printing.png")
            Me.imageList1.Images.SetKeyName(8, "Product.png")
            Me.imageList1.Images.SetKeyName(9, "Products.png")
            Me.imageList1.Images.SetKeyName(10, "Report.png")
            Me.imageList1.Images.SetKeyName(11, "Scheduller.png")
            Me.imageList1.Images.SetKeyName(12, "Security Folder.png")
            Me.imageList1.Images.SetKeyName(13, "Task.png")
            Me.imageList1.Images.SetKeyName(14, "User Folder.png")
            Me.imageList1.Images.SetKeyName(15, "User.png")
            Me.imageList1.Images.SetKeyName(16, "UserKey.png")
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ApplicationButtonText = Nothing
            Me.ribbonControl1.AutoSizeItems = True
            ' 
            ' 
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.ExpandCollapseItem.Name = ""
            Me.ribbonControl1.Images = Me.imageList1
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.Co, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barSubItem1, Me.barButtonItem4, Me.barButtonItem5, Me.barEditItem1})
            Me.ribbonControl1.LargeImages = Me.imageList1
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 17
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.ribbonPage2, Me.ribbonPage3})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemMRUEdit1})
            Me.ribbonControl1.SelectedPage = Me.ribbonPage3
            Me.ribbonControl1.Size = New System.Drawing.Size(615, 142)
            AddHandler Me.ribbonControl1.CustomDrawBarItemLink, New DXSample.CustomDrawBarItemEventHandler(AddressOf Me.OnCustomDrawBarItemLink)
            ' 
            ' Co
            ' 
            Me.Co.Caption = "File"
            Me.Co.Id = 7
            Me.Co.ImageIndex = 0
            Me.Co.LargeImageIndex = 3
            Me.Co.Name = "Co"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Edit"
            Me.barButtonItem1.Id = 8
            Me.barButtonItem1.ImageIndex = 3
            Me.barButtonItem1.LargeImageIndex = 13
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "View"
            Me.barButtonItem2.Id = 9
            Me.barButtonItem2.ImageIndex = 2
            Me.barButtonItem2.LargeImageIndex = 10
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Tools"
            Me.barButtonItem3.Id = 10
            Me.barButtonItem3.ImageIndex = 1
            Me.barButtonItem3.LargeImageIndex = 9
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "AddText"
            Me.barSubItem1.Id = 11
            Me.barSubItem1.LargeGlyph = Global.DXSample.Properties.Resources.Mail
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
            Me.barEditItem1.Id = 16
            Me.barEditItem1.ImageIndex = 15
            Me.barEditItem1.Name = "barEditItem1"
            Me.barEditItem1.Width = 125
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
            CType((Me.repositoryItemMRUEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private imageList1 As System.Windows.Forms.ImageList

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private ribbonControl1 As DXSample.MyRibbonControl

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
    End Class
End Namespace
