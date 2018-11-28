<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditProject))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtWorkType = New System.Windows.Forms.ComboBox()
        Me.txtSubCon = New System.Windows.Forms.ComboBox()
        Me.txtSubPIC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnAddSub = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.txtProName = New System.Windows.Forms.TextBox()
        Me.txtProCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvSubCon = New System.Windows.Forms.DataGridView()
        Me.proDet = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.proSum = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
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
        Me.btnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1012, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 39)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtWorkType)
        Me.Panel2.Controls.Add(Me.txtSubCon)
        Me.Panel2.Controls.Add(Me.txtSubPIC)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.btnAddSub)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1126, 61)
        Me.Panel2.TabIndex = 0
        '
        'txtWorkType
        '
        Me.txtWorkType.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtWorkType.FormattingEnabled = True
        Me.txtWorkType.Location = New System.Drawing.Point(416, 18)
        Me.txtWorkType.Name = "txtWorkType"
        Me.txtWorkType.Size = New System.Drawing.Size(172, 30)
        Me.txtWorkType.TabIndex = 8
        '
        'txtSubCon
        '
        Me.txtSubCon.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSubCon.FormattingEnabled = True
        Me.txtSubCon.Location = New System.Drawing.Point(99, 18)
        Me.txtSubCon.Name = "txtSubCon"
        Me.txtSubCon.Size = New System.Drawing.Size(172, 30)
        Me.txtSubCon.TabIndex = 7
        '
        'txtSubPIC
        '
        Me.txtSubPIC.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSubPIC.Location = New System.Drawing.Point(726, 18)
        Me.txtSubPIC.Name = "txtSubPIC"
        Me.txtSubPIC.Size = New System.Drawing.Size(183, 30)
        Me.txtSubPIC.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(614, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 23)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Subcon PIC"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label14.Location = New System.Drawing.Point(308, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 23)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Work Type"
        '
        'btnAddSub
        '
        Me.btnAddSub.Location = New System.Drawing.Point(925, 18)
        Me.btnAddSub.Name = "btnAddSub"
        Me.btnAddSub.Size = New System.Drawing.Size(75, 30)
        Me.btnAddSub.TabIndex = 3
        Me.btnAddSub.Text = "ADD"
        Me.btnAddSub.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label12.Location = New System.Drawing.Point(26, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Subcon"
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
        Me.txtRemark.Location = New System.Drawing.Point(221, 301)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(256, 30)
        Me.txtRemark.TabIndex = 10
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "yyyy/MM/dd"
        Me.dtpEnd.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(221, 238)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(256, 30)
        Me.dtpEnd.TabIndex = 9
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "yyyy/MM/dd"
        Me.dtpStart.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(221, 168)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(256, 30)
        Me.dtpStart.TabIndex = 8
        '
        'txtProName
        '
        Me.txtProName.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtProName.Location = New System.Drawing.Point(221, 102)
        Me.txtProName.Name = "txtProName"
        Me.txtProName.Size = New System.Drawing.Size(256, 30)
        Me.txtProName.TabIndex = 7
        '
        'txtProCode
        '
        Me.txtProCode.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtProCode.Location = New System.Drawing.Point(221, 29)
        Me.txtProCode.Name = "txtProCode"
        Me.txtProCode.Size = New System.Drawing.Size(256, 30)
        Me.txtProCode.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(176, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(176, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(176, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(176, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Remark"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Project End Date"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Project Start Date"
        '
        'dgvSubCon
        '
        Me.dgvSubCon.AllowUserToAddRows = False
        Me.dgvSubCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
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
        Me.Label2.Location = New System.Drawing.Point(24, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Project Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project Code"
        '
        'proSum
        '
        Me.proSum.Controls.Add(Me.btnNext)
        Me.proSum.Controls.Add(Me.txtRemark)
        Me.proSum.Controls.Add(Me.dtpEnd)
        Me.proSum.Controls.Add(Me.dtpStart)
        Me.proSum.Controls.Add(Me.txtProName)
        Me.proSum.Controls.Add(Me.txtProCode)
        Me.proSum.Controls.Add(Me.Label10)
        Me.proSum.Controls.Add(Me.Label8)
        Me.proSum.Controls.Add(Me.Label9)
        Me.proSum.Controls.Add(Me.Label7)
        Me.proSum.Controls.Add(Me.Label6)
        Me.proSum.Controls.Add(Me.Label5)
        Me.proSum.Controls.Add(Me.Label3)
        Me.proSum.Controls.Add(Me.Label4)
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
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(448, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 41)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "EDIT PROJECT"
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
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(1096, 18)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 23)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'frmEditProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 499)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditProject"
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
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents txtProName As TextBox
    Friend WithEvents txtProCode As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents proDet As TabPage
    Friend WithEvents dgvSubCon As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSubPIC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAddSub As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents btnClose As Button
    Friend WithEvents txtWorkType As ComboBox
    Friend WithEvents txtSubCon As ComboBox
End Class
