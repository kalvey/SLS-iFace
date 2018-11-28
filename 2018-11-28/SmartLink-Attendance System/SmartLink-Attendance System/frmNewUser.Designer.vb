<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbUserGroup = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(655, 242)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 46)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(40, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Group"
        '
        'cbbUserGroup
        '
        Me.cbbUserGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbUserGroup.FormattingEnabled = True
        Me.cbbUserGroup.Location = New System.Drawing.Point(223, 199)
        Me.cbbUserGroup.Name = "cbbUserGroup"
        Me.cbbUserGroup.Size = New System.Drawing.Size(566, 24)
        Me.cbbUserGroup.TabIndex = 48
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label18.Location = New System.Drawing.Point(40, 159)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(149, 23)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Re-type password"
        '
        'txtRePassword
        '
        Me.txtRePassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRePassword.Location = New System.Drawing.Point(223, 159)
        Me.txtRePassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRePassword.MaxLength = 1000
        Me.txtRePassword.Multiline = True
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePassword.Size = New System.Drawing.Size(566, 22)
        Me.txtRePassword.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(223, 122)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.MaxLength = 1000
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(566, 22)
        Me.txtPassword.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(40, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(40, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.Location = New System.Drawing.Point(223, 82)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.MaxLength = 1000
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(566, 22)
        Me.txtUsername.TabIndex = 41
        '
        'txtUserId
        '
        Me.txtUserId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserId.Location = New System.Drawing.Point(223, 43)
        Me.txtUserId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserId.MaxLength = 12
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(566, 22)
        Me.txtUserId.TabIndex = 40
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 394)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbbUserGroup)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtRePassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmNewUser"
        Me.Text = "frmNewUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbUserGroup As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtRePassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtUserId As TextBox
End Class
