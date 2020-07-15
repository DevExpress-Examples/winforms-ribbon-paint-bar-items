Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports System.Drawing.Drawing2D


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub RibbonControl1_CustomDrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraBars.BarItemCustomDrawEventArgs) Handles ribbonControl1.CustomDrawItem
			If e.RibbonItemInfo Is Nothing Then
				Return
			End If
			Dim link = TryCast(e.RibbonItemInfo.Item, BarItemLink)
			If TypeOf link Is BarSubItemLink Then
				e.RibbonItemInfo.Appearance.ForeColor = Color.Red
			End If
			If link.Item.Name = "barButtonItem1" Then
				If e.State = DevExpress.XtraBars.ViewInfo.BarLinkState.Highlighted Then
					Using backBrush = New LinearGradientBrush(e.Bounds, Color.DarkGreen, Color.LightGreen, LinearGradientMode.BackwardDiagonal)
						e.Cache.FillRectangle(backBrush, e.Bounds)
					End Using
					e.Graphics.DrawLine(Pens.White, e.Bounds.Location, New Point(e.Bounds.Right, e.Bounds.Y))
					e.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.X, e.Bounds.Bottom), New Point(e.Bounds.Right, e.Bounds.Bottom))
					e.Graphics.DrawLine(Pens.White, e.Bounds.Location, New Point(e.Bounds.X, e.Bounds.Bottom))
					e.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.Right, e.Bounds.Y), New Point(e.Bounds.Right, e.Bounds.Bottom))
				Else
					e.Cache.FillRectangle(Brushes.LightSeaGreen, e.Bounds)
				End If
				e.DrawText()
				e.DrawGlyph()
				e.Handled = True
			End If
			If link.Item.Name = "barEditItem1" Then
				If e.State = DevExpress.XtraBars.ViewInfo.BarLinkState.Highlighted Then
					Using backBrush = New LinearGradientBrush(e.Bounds, Color.DarkOrange, Color.LightYellow, LinearGradientMode.BackwardDiagonal)
						e.Cache.Graphics.FillRectangle(backBrush, e.Bounds)
						e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, New Point(e.Bounds.Right, e.Bounds.Y))
						e.Cache.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.X, e.Bounds.Bottom), New Point(e.Bounds.Right, e.Bounds.Bottom))
						e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, New Point(e.Bounds.X, e.Bounds.Bottom))
						e.Cache.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.Right, e.Bounds.Y), New Point(e.Bounds.Right, e.Bounds.Bottom))
					End Using
				Else
					e.Cache.FillRectangle(Brushes.Yellow, e.Bounds)
				End If
				e.DrawText()
				e.DrawGlyph()
				e.DrawEditor()
				e.Handled = True
			End If
		End Sub
	End Class
End Namespace
