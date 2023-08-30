Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon.Drawing

Namespace DXSample

    Public Class MyRibbonPanelGroupPainter
        Inherits RibbonPanelGroupPainter

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Sub DrawItem(ByVal viewInfo As RibbonViewInfo, ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal itemInfo As RibbonItemViewInfo)
            MyRibbonItemViewInfoCalculator.DrawItem(cache, itemInfo)
        End Sub
    End Class
End Namespace
