<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditUG
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.txtGroupID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvHidden = New ns1.BunifuCustomDataGrid()
        Me.dgvAccess = New ns1.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtGroupName)
        Me.Panel2.Controls.Add(Me.txtGroupID)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1107, 111)
        Me.Panel2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(157, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(157, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = ":"
        '
        'txtGroupName
        '
        Me.txtGroupName.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtGroupName.Location = New System.Drawing.Point(194, 62)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(272, 32)
        Me.txtGroupName.TabIndex = 10
        '
        'txtGroupID
        '
        Me.txtGroupID.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtGroupID.Location = New System.Drawing.Point(194, 8)
        Me.txtGroupID.Name = "txtGroupID"
        Me.txtGroupID.Size = New System.Drawing.Size(272, 32)
        Me.txtGroupID.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Group Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Group ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1107, 91)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 625)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1107, 80)
        Me.Panel3.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(194, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(169, 60)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "CANCEL"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(16, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(169, 60)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(366, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(372, 49)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Form Edit User Group"
        '
        'dgvHidden
        '
        Me.dgvHidden.AllowUserToAddRows = False
        Me.dgvHidden.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHidden.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHidden.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvHidden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHidden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHidden.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHidden.ColumnHeadersHeight = 30
        Me.dgvHidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHidden.DoubleBuffered = True
        Me.dgvHidden.EnableHeadersVisualStyles = False
        Me.dgvHidden.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.dgvHidden.HeaderForeColor = System.Drawing.Color.White
        Me.dgvHidden.Location = New System.Drawing.Point(299, 588)
        Me.dgvHidden.Name = "dgvHidden"
        Me.dgvHidden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHidden.RowTemplate.Height = 24
        Me.dgvHidden.Size = New System.Drawing.Size(189, 151)
        Me.dgvHidden.TabIndex = 8
        '
        'dgvAccess
        '
        Me.dgvAccess.AllowUserToAddRows = False
        Me.dgvAccess.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvAccess.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAccess.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvAccess.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAccess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccess.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAccess.ColumnHeadersHeight = 30
        Me.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAccess.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAccess.DoubleBuffered = True
        Me.dgvAccess.EnableHeadersVisualStyles = False
        Me.dgvAccess.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.dgvAccess.HeaderForeColor = System.Drawing.Color.White
        Me.dgvAccess.Location = New System.Drawing.Point(0, 202)
        Me.dgvAccess.Name = "dgvAccess"
        Me.dgvAccess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAccess.RowTemplate.Height = 24
        Me.dgvAccess.Size = New System.Drawing.Size(1107, 423)
        Me.dgvAccess.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        '
        'frmEditUG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 705)
        Me.Controls.Add(Me.dgvAccess)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvHidden)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditUG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditUG"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvHidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGroupName As TextBox
    Friend WithEvents txtGroupID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvHidden As ns1.BunifuCustomDataGrid
    Friend WithEvents dgvAccess As ns1.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
End Class
