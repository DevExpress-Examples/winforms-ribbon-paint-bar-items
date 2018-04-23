Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing
Imports System.Drawing
Imports DevExpress.Utils.Drawing.Animation
Imports DevExpress.XtraBars.Ribbon.Drawing
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraEditors.Drawing

Namespace DXSample
	Public Class MyRibbonItemViewInfoCalculator
		Inherits RibbonItemViewInfoCalculator
		Public Sub New(ByVal viewInfo As BaseRibbonViewInfo)
			MyBase.New(viewInfo)
		End Sub

		Public Shared Shadows Sub DrawItem(ByVal cache As GraphicsCache, ByVal itemInfo As RibbonItemViewInfo)
			XtraAnimator.Current.DrawAnimationHelper(cache, TryCast(itemInfo.Owner, ISupportXtraAnimation), itemInfo, New RibbonItemPainter(), New RibbonDrawInfo(itemInfo), Nothing, itemInfo)
		End Sub

		Public Overrides Sub DrawButton(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal item As RibbonItemViewInfo)
			CheckItemViewInfo(cache, item)
			Dim args As New CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds, item.CaptionBounds, item.GlyphBounds, TryCast(item.Item, BarItemLink), IsItemHotTracked(item))
			Ribbon.RaiseCustomDrawBarItemLink(args)
			If (Not args.Handled) Then
				MyBase.DrawButton(cache, item)
			Else
				DrawSelection(cache, item)
			End If
		End Sub

		Public Overrides Sub DrawDropDownButton(ByVal cache As GraphicsCache, ByVal item As RibbonItemViewInfo)
			CheckItemViewInfo(cache, item)
			Dim args As New CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds, item.CaptionBounds, item.GlyphBounds, TryCast(item.Item, BarItemLink), IsItemHotTracked(item))
			Ribbon.RaiseCustomDrawBarItemLink(args)
			If (Not args.Handled) Then
				MyBase.DrawDropDownButton(cache, item)
			Else
				DrawSelection(cache, item)
			End If

		End Sub
		Public Overrides Sub DrawLargeDropDownButton(ByVal cache As GraphicsCache, ByVal item As RibbonItemViewInfo)
			CheckItemViewInfo(cache, item)
			Dim args As New CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds, item.CaptionBounds, item.GlyphBounds, TryCast(item.Item, BarItemLink), IsItemHotTracked(item))
			Ribbon.RaiseCustomDrawBarItemLink(args)
			If (Not args.Handled) Then
				MyBase.DrawLargeDropDownButton(cache, item)
			Else
				DrawSelection(cache, item)
			End If
		End Sub

		Public Overrides Sub DrawEditItem(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal item As RibbonItemViewInfo)
			CheckItemViewInfo(cache, item)
			Dim args As New CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds, item.CaptionBounds, item.GlyphBounds, TryCast(item.Item, BarItemLink), IsItemHotTracked(item))
			Ribbon.RaiseCustomDrawBarItemLink(args)
			If (Not args.Handled) Then
				MyBase.DrawEditItem(cache, item)
			Else
				Dim editItem As RibbonEditItemViewInfo = CType(item, RibbonEditItemViewInfo)
				If editItem.EditBounds.IsEmpty Then
					Return
				End If
				Dim oldPaint As XPaint = Nothing
				Dim infoArgs As New ControlGraphicsInfoArgs(editItem.EditViewInfo, cache, editItem.EditBounds, ShouldDrawTextOnGlass(item))
				If (Not ViewInfo.OwnerControl.Enabled) Then
					infoArgs.ViewInfo.State = ObjectState.Disabled
				End If
				editItem.EditPainter.Draw(infoArgs)
				If oldPaint IsNot Nothing Then
					cache.Paint = oldPaint
				End If
				DrawSelection(cache, item)
			End If
		End Sub

		Public Overrides Sub DrawLargeButton(ByVal cache As GraphicsCache, ByVal item As RibbonItemViewInfo)
			CheckItemViewInfo(cache, item)
			Dim args As New CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds, item.CaptionBounds, item.GlyphBounds, TryCast(item.Item, BarItemLink), IsItemHotTracked(item))
			Ribbon.RaiseCustomDrawBarItemLink(args)
			If (Not args.Handled) Then
				MyBase.DrawLargeButton(cache, item)
			Else
				DrawSelection(cache, item)
			End If
		End Sub

		Protected Overridable Function IsItemHotTracked(ByVal item As RibbonItemViewInfo) As Boolean
			Return Object.Equals (ViewInfo.Manager.SelectionInfo.HighlightedLink , item.Item)
		End Function

		Public Shadows ReadOnly Property ViewInfo() As MyRibbonViewInfo
			Get
				Return TryCast(MyBase.ViewInfo, MyRibbonViewInfo)
			End Get
		End Property

		Public ReadOnly Property Ribbon() As MyRibbonControl
			Get
				Return TryCast(ViewInfo.Ribbon, MyRibbonControl)
			End Get
		End Property
	End Class
End Namespace