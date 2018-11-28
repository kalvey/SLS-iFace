<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateTime
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
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd/ HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(232, 28)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Set Device Clock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(437, 130)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDateTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDateTime"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
