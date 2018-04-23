Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Drawing

Namespace DXSample
	Public Class MyRibbonViewInfo
		Inherits RibbonViewInfo
		Public Sub New(ByVal ribbonControl As RibbonControl)
			MyBase.New(ribbonControl)
		End Sub
		Protected Overrides Function CreateItemCalculator() As RibbonItemViewInfoCalculator
			Return New MyRibbonItemViewInfoCalculator(Me)
		End Function

		Public Shadows ReadOnly Property Manager() As MyRibbonBarManager
			Get
				Return TryCast(MyBase.Manager, MyRibbonBarManager)
			End Get
		End Property
		Protected Overrides Function CreatePanelInfo() As RibbonPanelViewInfo
			Return New MyRibbonPanelViewInfo(Me)
		End Function


	End Class
End Namespace