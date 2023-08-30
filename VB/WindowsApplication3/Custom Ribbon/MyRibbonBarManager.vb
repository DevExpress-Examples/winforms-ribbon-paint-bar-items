Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.ViewInfo

Namespace DXSample

    Public Class MyRibbonBarManager
        Inherits RibbonBarManager

        Public Sub New(ByVal ribbonControl As RibbonControl)
            MyBase.New(ribbonControl)
        End Sub

        Friend Overloads ReadOnly Property SelectionInfo As BarSelectionInfo
            Get
                Return MyBase.SelectionInfo
            End Get
        End Property
    End Class
End Namespace
