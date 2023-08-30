Imports DevExpress.XtraBars.Ribbon

Namespace DXSample

    Public Class MyRibbonControl
        Inherits RibbonControl

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Function CreateViewInfo() As ViewInfo.RibbonViewInfo
            Return New MyRibbonViewInfo(Me)
        End Function

        Protected Overrides Function CreateBarManager() As RibbonBarManager
            Return New MyRibbonBarManager(Me)
        End Function

        Public Event CustomDrawBarItemLink As CustomDrawBarItemEventHandler

        Friend Sub RaiseCustomDrawBarItemLink(ByVal e As CustomDrawBarItemEventArgs)
            RaiseEvent CustomDrawBarItemLink(Me, e)
        End Sub
    End Class
End Namespace
