<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 69)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 51)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtUsername.Location = New System.Drawing.Point(102, 117)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(296, 30)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtPassword.Location = New System.Drawing.Point(102, 192)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(296, 30)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(98, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USER ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(98, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnLogin.Location = New System.Drawing.Point(323, 235)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 33)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 285)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
End Class
