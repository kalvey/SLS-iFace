<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupRestore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDataFile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDataFile
        '
        Me.txtDataFile.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtDataFile.Location = New System.Drawing.Point(95, 61)
        Me.txtDataFile.Name = "txtDataFile"
        Me.txtDataFile.Size = New System.Drawing.Size(214, 30)
        Me.txtDataFile.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "UPLOAD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackupRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 351)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDataFile)
        Me.Name = "BackupRestore"
        Me.Text = "BackupRestore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDataFile As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
