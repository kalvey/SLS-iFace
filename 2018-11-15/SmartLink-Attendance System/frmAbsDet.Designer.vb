<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbsDet
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvAbsence = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvAbsence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(993, 93)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(993, 93)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ABSENCE DETAIL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtDept)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(993, 45)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 432)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(993, 44)
        Me.Panel3.TabIndex = 2
        '
        'dgvAbsence
        '
        Me.dgvAbsence.BackgroundColor = System.Drawing.Color.White
        Me.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAbsence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAbsence.Location = New System.Drawing.Point(0, 138)
        Me.dgvAbsence.Name = "dgvAbsence"
        Me.dgvAbsence.RowTemplate.Height = 24
        Me.dgvAbsence.Size = New System.Drawing.Size(993, 294)
        Me.dgvAbsence.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtName.Location = New System.Drawing.Point(83, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(199, 32)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(314, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Department Name:"
        '
        'txtDept
        '
        Me.txtDept.Enabled = False
        Me.txtDept.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtDept.Location = New System.Drawing.Point(490, 8)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(199, 32)
        Me.txtDept.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(888, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 37)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "EXIT"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmAbsDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 476)
        Me.Controls.Add(Me.dgvAbsence)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAbsDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAbsDet"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvAbsence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvAbsence As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDept As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnClose As Button
End Class
