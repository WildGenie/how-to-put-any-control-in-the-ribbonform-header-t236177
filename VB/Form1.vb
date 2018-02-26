Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Example
	Partial Public Class Form1
		Inherits RibbonForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub toggleSwitch1_Toggled(ByVal sender As Object, ByVal e As EventArgs) Handles toggleSwitch1.Toggled
			Me.AllowFormGlass = If(toggleSwitch1.IsOn, DefaultBoolean.True, DefaultBoolean.False)
		End Sub

		Private Function GetHeaderControl() As Control
			If toggleSwitch2.IsOn Then
				Return simpleButton1
			Else
				Return pictureBox1
			End If
		End Function


		Private Sub toggleSwitch2_Toggled(ByVal sender As Object, ByVal e As EventArgs) Handles toggleSwitch2.Toggled
			userControlReplaceHelper1.HeaderControl = GetHeaderControl()
		End Sub
	End Class
End Namespace
