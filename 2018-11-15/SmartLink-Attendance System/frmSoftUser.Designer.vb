<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD NEW USER FOR LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(22, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User ID should be typed into User ID " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in login form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(22, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Name"
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.txtUserID.Location = New System.Drawing.Point(400, 123)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(261, 40)
        Me.txtUserID.TabIndex = 0
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.txtUsername.Location = New System.Drawing.Point(400, 198)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(261, 40)
        Me.txtUsername.TabIndex = 1
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(499, 334)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(162, 48)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.txtPassword.Location = New System.Drawing.Point(400, 274)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(261, 40)
        Me.txtPassword.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Label5.Location = New System.Drawing.Point(22, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 33)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Password"
        '
        'frmSoftUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 394)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSoftUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSoftUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
End Class
