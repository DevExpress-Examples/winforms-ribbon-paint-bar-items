Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.ViewInfo

Namespace DXSample
	Public Class MyRibbonBarManager
		Inherits RibbonBarManager
		Public Sub New(ByVal ribbonControl As RibbonControl)
			MyBase.New(ribbonControl)
		End Sub
		Friend Shadows ReadOnly Property SelectionInfo() As BarSelectionInfo
			Get
				Return MyBase.SelectionInfo
			End Get
		End Property
	End Class
End Namespace