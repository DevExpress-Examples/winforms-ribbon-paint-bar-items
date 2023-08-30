Imports System
Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraBars

Namespace DXSample

    Public Delegate Sub CustomDrawBarItemEventHandler(ByVal sender As Object, ByVal e As CustomDrawBarItemEventArgs)

    Public Class CustomDrawBarItemEventArgs
        Inherits EventArgs

        Private cacheField As GraphicsCache

        Private appearanceField As AppearanceObject

        Private boundsField, captionBoundsField, glyphBoundsField As Rectangle

        Private itemLinkField As BarItemLink

        Private isItemHotTrackedField As Boolean, handledField As Boolean = False

        Public Sub New(ByVal cache As GraphicsCache, ByVal appearance As AppearanceObject, ByVal bounds As Rectangle, ByVal captionBounds As Rectangle, ByVal glyphBounds As Rectangle, ByVal itemLink As BarItemLink, ByVal isItemHotTracked As Boolean)
            cacheField = cache
            appearanceField = appearance
            boundsField = bounds
            captionBoundsField = captionBounds
            glyphBoundsField = glyphBounds
            itemLinkField = itemLink
            isItemHotTrackedField = isItemHotTracked
        End Sub

        Public ReadOnly Property Cache As GraphicsCache
            Get
                Return cacheField
            End Get
        End Property

        Public ReadOnly Property Appearance As AppearanceObject
            Get
                Return appearanceField
            End Get
        End Property

        Public ReadOnly Property Bounds As Rectangle
            Get
                Return boundsField
            End Get
        End Property

        Public ReadOnly Property CaptionBounds As Rectangle
            Get
                Return captionBoundsField
            End Get
        End Property

        Public ReadOnly Property GlyphBounds As Rectangle
            Get
                Return glyphBoundsField
            End Get
        End Property

        Public ReadOnly Property ItemLink As BarItemLink
            Get
                Return itemLinkField
            End Get
        End Property

        Public ReadOnly Property IsItemHotTracked As Boolean
            Get
                Return isItemHotTrackedField
            End Get
        End Property

        Public Property Handled As Boolean
            Get
                Return handledField
            End Get

            Set(ByVal value As Boolean)
                handledField = value
            End Set
        End Property
    End Class
End Namespace
