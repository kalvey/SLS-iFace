<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSubcon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSubcon))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtWorkType = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnAddSub = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtSCName = New System.Windows.Forms.TextBox()
        Me.txtSCCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvSubCon = New System.Windows.Forms.DataGridView()
        Me.proDet = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.proSum = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSubCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.proDet.SuspendLayout()
        Me.proSum.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 339)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1126, 53)
        Me.Panel3.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnSave.Location = New System.Drawing.Point(1012, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 39)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtWorkType)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.btnAddSub)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1126, 61)
        Me.Panel2.TabIndex = 0
        '
        'txtWorkType
        '
        Me.txtWorkType.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtWorkType.Location = New System.Drawing.Point(112, 16)
        Me.txtWorkType.Name = "txtWorkType"
        Me.txtWorkType.Size = New System.Drawing.Size(183, 30)
        Me.txtWorkType.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label14.Location = New System.Drawing.Point(14, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 23)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Work Type"
        '
        'btnAddSub
        '
        Me.btnAddSub.Location = New System.Drawing.Point(310, 16)
        Me.btnAddSub.Name = "btnAddSub"
        Me.btnAddSub.Size = New System.Drawing.Size(75, 30)
        Me.btnAddSub.TabIndex = 3
        Me.btnAddSub.Text = "ADD"
        Me.btnAddSub.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(1052, 339)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(59, 48)
        Me.btnNext.TabIndex = 11
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtRemark.Location = New System.Drawing.Point(221, 154)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(256, 30)
        Me.txtRemark.TabIndex = 10
        '
        'txtSCName
        '
        Me.txtSCName.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSCName.Location = New System.Drawing.Point(221, 95)
        Me.txtSCName.Name = "txtSCName"
        Me.txtSCName.Size = New System.Drawing.Size(256, 30)
        Me.txtSCName.TabIndex = 7
        '
        'txtSCCode
        '
        Me.txtSCCode.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSCCode.Location = New System.Drawing.Point(221, 29)
        Me.txtSCCode.Name = "txtSCCode"
        Me.txtSCCode.Size = New System.Drawing.Size(256, 30)
        Me.txtSCCode.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(176, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(176, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(176, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Remark"
        '
        'dgvSubCon
        '
        Me.dgvSubCon.AllowUserToAddRows = False
        Me.dgvSubCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubCon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column5})
        Me.dgvSubCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSubCon.Location = New System.Drawing.Point(3, 64)
        Me.dgvSubCon.Name = "dgvSubCon"
        Me.dgvSubCon.RowTemplate.Height = 24
        Me.dgvSubCon.Size = New System.Drawing.Size(1126, 275)
        Me.dgvSubCon.TabIndex = 2
        '
        'proDet
        '
        Me.proDet.Controls.Add(Me.dgvSubCon)
        Me.proDet.Controls.Add(Me.Panel3)
        Me.proDet.Controls.Add(Me.Panel2)
        Me.proDet.Location = New System.Drawing.Point(4, 25)
        Me.proDet.Name = "proDet"
        Me.proDet.Padding = New System.Windows.Forms.Padding(3)
        Me.proDet.Size = New System.Drawing.Size(1132, 395)
        Me.proDet.TabIndex = 1
        Me.proDet.Text = "Project Detail"
        Me.proDet.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subcon Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subcon Code"
        '
        'proSum
        '
        Me.proSum.Controls.Add(Me.btnNext)
        Me.proSum.Controls.Add(Me.txtRemark)
        Me.proSum.Controls.Add(Me.txtSCName)
        Me.proSum.Controls.Add(Me.txtSCCode)
        Me.proSum.Controls.Add(Me.Label10)
        Me.proSum.Controls.Add(Me.Label8)
        Me.proSum.Controls.Add(Me.Label9)
        Me.proSum.Controls.Add(Me.Label5)
        Me.proSum.Controls.Add(Me.Label2)
        Me.proSum.Controls.Add(Me.Label1)
        Me.proSum.Location = New System.Drawing.Point(4, 25)
        Me.proSum.Name = "proSum"
        Me.proSum.Padding = New System.Windows.Forms.Padding(3)
        Me.proSum.Size = New System.Drawing.Size(1132, 395)
        Me.proSum.TabIndex = 0
        Me.proSum.Text = "Project Summary"
        Me.proSum.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.proSum)
        Me.TabControl1.Controls.Add(Me.proDet)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1140, 424)
        Me.TabControl1.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(1083, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(448, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 41)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "ADD SUBCON"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 75)
        Me.Panel1.TabIndex = 3
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'Column1
        '
        Me.Column1.HeaderText = "Subcon Code"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Subcon Name"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Work Type"
        Me.Column5.Name = "Column5"
        '
        'frmAddSubcon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 499)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddSubcon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddSubcon"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvSubCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.proDet.ResumeLayout(False)
        Me.proSum.ResumeLayout(False)
        Me.proSum.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents proSum As TabPage
    Friend WithEvents btnNext As Button
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtSCName As TextBox
    Friend WithEvents txtSCCode As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents proDet As TabPage
    Friend WithEvents dgvSubCon As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtWorkType As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAddSub As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
