Namespace Q181266

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(38, 26)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "checkEdit1"
            Me.checkEdit1.Size = New System.Drawing.Size(81, 19)
            Me.checkEdit1.TabIndex = 0
            AddHandler Me.checkEdit1.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.checkEdit1_MouseDown)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(872, 597)
            Me.Controls.Add(Me.checkEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace
