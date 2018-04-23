Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils

Namespace Q181266
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkEdit1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles checkEdit1.MouseDown
			Dim cEdit As CheckEdit = CType(sender, CheckEdit)
			Dim cInfo As CheckEditViewInfo = CType(cEdit.GetViewInfo(), CheckEditViewInfo)
			Dim r As Rectangle = cInfo.CheckInfo.GlyphRect
			Dim editorRect As New Rectangle(New Point(0, 0), cEdit.Size)
			If (Not r.Contains(e.Location)) AndAlso editorRect.Contains(e.Location) Then
				CType(e, DXMouseEventArgs).Handled = True
			End If
		End Sub
	End Class
End Namespace