Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon
Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraBars

Namespace DXSample
	Public Delegate Sub CustomDrawBarItemEventHandler(ByVal sender As Object, ByVal e As CustomDrawBarItemEventArgs)
	Public Class CustomDrawBarItemEventArgs
		Inherits EventArgs
		Private cache_Renamed As GraphicsCache
		Private appearance_Renamed As AppearanceObject
		Private bounds_Renamed, captionBounds_Renamed, glyphBounds_Renamed As Rectangle
		Private itemLink_Renamed As BarItemLink
		Private isItemHotTracked_Renamed As Boolean, handled_Renamed As Boolean = False

		Public Sub New(ByVal cache As GraphicsCache, ByVal appearance As AppearanceObject, ByVal bounds As Rectangle, ByVal captionBounds As Rectangle, ByVal glyphBounds As Rectangle, ByVal itemLink As BarItemLink, ByVal isItemHotTracked As Boolean)
			Me.cache_Renamed = cache
			Me.appearance_Renamed = appearance
			Me.bounds_Renamed = bounds
			Me.captionBounds_Renamed = captionBounds
			Me.glyphBounds_Renamed = glyphBounds
			Me.itemLink_Renamed = itemLink
			Me.isItemHotTracked_Renamed = isItemHotTracked
		End Sub

		Public ReadOnly Property Cache() As GraphicsCache
			Get
				Return cache_Renamed
			End Get
		End Property

		Public ReadOnly Property Appearance() As AppearanceObject
			Get
				Return appearance_Renamed
			End Get
		End Property

		Public ReadOnly Property Bounds() As Rectangle
			Get
				Return bounds_Renamed
			End Get
		End Property

		Public ReadOnly Property CaptionBounds() As Rectangle
			Get
				Return captionBounds_Renamed
			End Get
		End Property

		Public ReadOnly Property GlyphBounds() As Rectangle
			Get
				Return glyphBounds_Renamed
			End Get
		End Property

		Public ReadOnly Property ItemLink() As BarItemLink
			Get
				Return itemLink_Renamed
			End Get
		End Property

		Public ReadOnly Property IsItemHotTracked() As Boolean
			Get
				Return isItemHotTracked_Renamed
			End Get
		End Property

		Public Property Handled() As Boolean
			Get
				Return handled_Renamed
			End Get
			Set(ByVal value As Boolean)
				handled_Renamed = value
			End Set
		End Property
	End Class
End Namespace