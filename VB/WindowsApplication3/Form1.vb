Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars
Imports System.Drawing.Drawing2D

Namespace DXSample

    Public Partial Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnCustomDrawBarItemLink(ByVal sender As Object, ByVal e As CustomDrawBarItemEventArgs)
            If TypeOf e.ItemLink Is BarSubItemLink Then e.Appearance.ForeColor = Color.Red
            If Equals(e.ItemLink.Item.Name, "barButtonItem1") Then
                If e.IsItemHotTracked Then
                    e.Cache.Graphics.FillRectangle(New LinearGradientBrush(e.Bounds, Color.DarkGreen, Color.LightGreen, LinearGradientMode.BackwardDiagonal), e.Bounds)
                    e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, New Point(e.Bounds.Right, e.Bounds.Y))
                    e.Cache.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.X, e.Bounds.Bottom), New Point(e.Bounds.Right, e.Bounds.Bottom))
                    e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, New Point(e.Bounds.X, e.Bounds.Bottom))
                    e.Cache.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.Right, e.Bounds.Y), New Point(e.Bounds.Right, e.Bounds.Bottom))
                Else
                    e.Cache.Graphics.FillRectangle(New SolidBrush(Color.LightSeaGreen), e.Bounds)
                End If

                e.Appearance.DrawString(e.Cache, e.ItemLink.Caption, e.CaptionBounds)
                If e.ItemLink.ImageIndex <> -1 Then
                    Dim image As Image = TryCast(e.ItemLink.Item.Images, ImageList).Images(e.ItemLink.ImageIndex)
                    e.Cache.Graphics.DrawImage(image, e.GlyphBounds)
                End If

                e.Handled = True
            End If

            If Equals(e.ItemLink.Item.Name, "barEditItem1") Then
                If e.IsItemHotTracked Then
                    e.Cache.Graphics.FillRectangle(New LinearGradientBrush(e.Bounds, Color.DarkOrange, Color.LightYellow, LinearGradientMode.BackwardDiagonal), e.Bounds)
                    e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, New Point(e.Bounds.Right, e.Bounds.Y))
                    e.Cache.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.X, e.Bounds.Bottom), New Point(e.Bounds.Right, e.Bounds.Bottom))
                    e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, New Point(e.Bounds.X, e.Bounds.Bottom))
                    e.Cache.Graphics.DrawLine(Pens.Black, New Point(e.Bounds.Right, e.Bounds.Y), New Point(e.Bounds.Right, e.Bounds.Bottom))
                Else
                    e.Cache.Graphics.FillRectangle(New SolidBrush(Color.Yellow), e.Bounds)
                End If

                e.Appearance.DrawString(e.Cache, e.ItemLink.Caption, e.CaptionBounds)
                If e.ItemLink.ImageIndex <> -1 Then
                    Dim image As Image = TryCast(e.ItemLink.Item.Images, ImageList).Images(e.ItemLink.ImageIndex)
                    e.Cache.Graphics.DrawImage(image, e.GlyphBounds)
                End If

                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
