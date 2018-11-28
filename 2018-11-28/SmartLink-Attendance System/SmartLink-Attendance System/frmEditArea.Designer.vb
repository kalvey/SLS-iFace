<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditArea
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtAreaName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAreaNo = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 70)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(163, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 41)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Edit Area"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(191, 153)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(158, 22)
        Me.txtRemark.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(85, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Remark:"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(274, 181)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 37)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "Save"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtAreaName
        '
        Me.txtAreaName.Location = New System.Drawing.Point(191, 106)
        Me.txtAreaName.Name = "txtAreaName"
        Me.txtAreaName.Size = New System.Drawing.Size(158, 22)
        Me.txtAreaName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(84, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Area Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Area Number:"
        '
        'lblAreaNo
        '
        Me.lblAreaNo.AutoSize = True
        Me.lblAreaNo.Location = New System.Drawing.Point(187, 75)
        Me.lblAreaNo.Name = "lblAreaNo"
        Me.lblAreaNo.Size = New System.Drawing.Size(16, 17)
        Me.lblAreaNo.TabIndex = 14
        Me.lblAreaNo.Text = "0"
        '
        'frmEditArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 235)
        Me.Controls.Add(Me.lblAreaNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtAreaName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditArea"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtAreaName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAreaNo As Label
    Friend WithEvents Label2 As Label
End Class
