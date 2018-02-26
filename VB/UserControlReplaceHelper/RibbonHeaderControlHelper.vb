Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace Example
	Public Class RibbonHeaderControlHelper
		Inherits Component

		#Region "Fields"
		Private _RibbonControl As RibbonControl
		Private _HeaderControl As Control
		#End Region


		Public Sub New()
			_RibbonControl = Nothing
			_HeaderControl = Nothing
		End Sub

		#Region "Properties"
		Public Property RibbonControl() As RibbonControl
			Get
				Return _RibbonControl
			End Get
			Set(ByVal value As RibbonControl)
				_RibbonControl = value
				OnRibbonControlChanged()
			End Set
		End Property

		Protected Overridable Sub OnRibbonControlChanged()
			SubscribeRibbonEvents(True)
		End Sub

		Public Property HeaderControl() As Control
			Get
				Return _HeaderControl
			End Get
			Set(ByVal value As Control)
				If _HeaderControl IsNot Nothing Then
					_HeaderControl.Visible = False
				End If
				_HeaderControl = value
				OnHeaderControlChanged()
			End Set
		End Property

		Protected Overridable Sub OnHeaderControlChanged()
			If RibbonControlNotNull Then
				ReplaceUserControl()
			End If
		End Sub

		Protected ReadOnly Property RibbonControlNotNull() As Boolean
			Get
				Return _RibbonControl IsNot Nothing
			End Get
		End Property
		Protected ReadOnly Property HeaderControlNotNull() As Boolean
			Get
				Return _HeaderControl IsNot Nothing
			End Get
		End Property
		#End Region


		Private Sub SubscribeRibbonEvents(ByVal subscribe As Boolean)
			If RibbonControlNotNull Then
				RemoveHandler _RibbonControl.Paint, AddressOf RibbonControl_Paint
				If subscribe Then
					AddHandler _RibbonControl.Paint, AddressOf RibbonControl_Paint
				End If
			End If
		End Sub

		Private Sub RibbonControl_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
			ReplaceUserControl()
		End Sub

		Protected Overridable Sub ReplaceUserControl()
			If HeaderControlNotNull Then
				HeaderControl.Parent = RibbonControl
				HeaderControl.Visible = True
				Dim vi As RibbonViewInfo = RibbonControl.ViewInfo
				Dim captionInfo As RibbonCaptionViewInfo = vi.Caption
				Dim height As Integer = If(HeaderControl.Height <= 1, 17, HeaderControl.Height)
				Dim width As Integer = HeaderControl.Width
				Dim buttonRect As New Rectangle(captionInfo.ContentBounds.Right - width, captionInfo.ContentBounds.Y + (captionInfo.ContentBounds.Height - height) \ 2, width, height)
				HeaderControl.Bounds = buttonRect
			End If
		End Sub

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			SubscribeRibbonEvents(False)
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
