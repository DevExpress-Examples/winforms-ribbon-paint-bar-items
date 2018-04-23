Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Drawing
Imports DevExpress.Utils.Drawing

Namespace DXSample
	Public Class MyRibbonPanelViewInfo
		Inherits RibbonPanelViewInfo
		Public Sub New(ByVal viewInfo As RibbonViewInfo)
			MyBase.New(viewInfo)
		End Sub



		Protected Overrides Function CreateGroupViewInfo(ByVal group As RibbonPageGroup) As RibbonPageGroupViewInfo
			Return New MyRibbonPageGroupViewInfo(ViewInfo, group)
		End Function

	End Class


	Friend Class MyRibbonPageGroupViewInfo
		Inherits RibbonPageGroupViewInfo
		Public Sub New(ByVal viewInfo As RibbonViewInfo, ByVal group As RibbonPageGroup)
			MyBase.New(viewInfo, group)
		End Sub

		Protected Overrides Function CreatePanelGroupPainter() As RibbonPanelGroupPainter
			Return New MyRibbonPanelGroupPainter()
		End Function
	End Class
End Namespace
