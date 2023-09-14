Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils

Namespace Q181266

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub checkEdit1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim cEdit As CheckEdit = CType(sender, CheckEdit)
            Dim cInfo As CheckEditViewInfo = CType(cEdit.GetViewInfo(), CheckEditViewInfo)
            Dim r As Rectangle = cInfo.CheckInfo.GlyphRect
            Dim editorRect As Rectangle = New Rectangle(New Point(0, 0), cEdit.Size)
            If Not r.Contains(e.Location) AndAlso editorRect.Contains(e.Location) Then CType(e, DXMouseEventArgs).Handled = True
        End Sub
    End Class
End Namespace
