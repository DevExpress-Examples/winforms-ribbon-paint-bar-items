Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon.Drawing

Namespace DXSample

    Public Class MyRibbonPanelViewInfo
        Inherits RibbonPanelViewInfo

        Public Sub New(ByVal viewInfo As RibbonViewInfo)
            MyBase.New(viewInfo)
        End Sub

        Protected Overrides Function CreatePanelGroupPainter() As DevExpress.XtraBars.Ribbon.Drawing.RibbonPanelGroupPainter
            Return New MyRibbonPanelGroupPainter()
        End Function
    End Class
End Namespace
