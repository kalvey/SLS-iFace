<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEMPtoPRJ
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
        Me.lblSubCon = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsProjectCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsProjectName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbbSubCon = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvEMPtoPRJ = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEMP = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvEMPtoPRJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEMP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.lblSubCon)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 80)
        Me.Panel1.TabIndex = 0
        '
        'lblSubCon
        '
        Me.lblSubCon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubCon.AutoSize = True
        Me.lblSubCon.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.lblSubCon.ForeColor = System.Drawing.Color.White
        Me.lblSubCon.Location = New System.Drawing.Point(606, 21)
        Me.lblSubCon.Name = "lblSubCon"
        Me.lblSubCon.Size = New System.Drawing.Size(27, 41)
        Me.lblSubCon.TabIndex = 2
        Me.lblSubCon.Text = "."
        Me.lblSubCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(297, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Assign Employee For: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(1217, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(31, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 493)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1260, 70)
        Me.Panel2.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsProjectCode, Me.tsProjectName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 45)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1260, 25)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsProjectCode
        '
        Me.tsProjectCode.Name = "tsProjectCode"
        Me.tsProjectCode.Size = New System.Drawing.Size(91, 20)
        Me.tsProjectCode.Text = "projectCode"
        '
        'tsProjectName
        '
        Me.tsProjectName.Name = "tsProjectName"
        Me.tsProjectName.Size = New System.Drawing.Size(96, 20)
        Me.tsProjectName.Text = "projectName"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(1103, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 39)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbbSubCon)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1260, 59)
        Me.Panel3.TabIndex = 2
        '
        'cbbSubCon
        '
        Me.cbbSubCon.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbSubCon.FormattingEnabled = True
        Me.cbbSubCon.Location = New System.Drawing.Point(533, 12)
        Me.cbbSubCon.Name = "cbbSubCon"
        Me.cbbSubCon.Size = New System.Drawing.Size(234, 30)
        Me.cbbSubCon.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(451, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SUBCON"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSearch.Location = New System.Drawing.Point(175, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(234, 30)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEARCH EMPLOYEE"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvEMPtoPRJ, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvEMP, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInsert, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 139)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1260, 354)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'dgvEMPtoPRJ
        '
        Me.dgvEMPtoPRJ.AllowUserToAddRows = False
        Me.dgvEMPtoPRJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEMPtoPRJ.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column2, Me.Column3})
        Me.dgvEMPtoPRJ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEMPtoPRJ.Location = New System.Drawing.Point(653, 3)
        Me.dgvEMPtoPRJ.Name = "dgvEMPtoPRJ"
        Me.dgvEMPtoPRJ.RowTemplate.Height = 24
        Me.dgvEMPtoPRJ.Size = New System.Drawing.Size(604, 348)
        Me.dgvEMPtoPRJ.TabIndex = 2
        '
        'Column4
        '
        Me.Column4.HeaderText = "Project Code"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Project Name"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Subcon ID"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Subcon Name"
        Me.Column7.Name = "Column7"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Employee Number"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Employee Name"
        Me.Column3.Name = "Column3"
        '
        'dgvEMP
        '
        Me.dgvEMP.AllowUserToAddRows = False
        Me.dgvEMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEMP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvEMP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEMP.Location = New System.Drawing.Point(3, 3)
        Me.dgvEMP.Name = "dgvEMP"
        Me.dgvEMP.RowTemplate.Height = 24
        Me.dgvEMP.Size = New System.Drawing.Size(603, 348)
        Me.dgvEMP.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnInsert.Location = New System.Drawing.Point(612, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(35, 348)
        Me.btnInsert.TabIndex = 1
        Me.btnInsert.Text = ">>"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'frmEMPtoPRJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 563)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEMPtoPRJ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEMPtoPRJ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvEMPtoPRJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvEMPtoPRJ As DataGridView
    Friend WithEvents dgvEMP As DataGridView
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents btnInsert As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubCon As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbSubCon As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsProjectCode As ToolStripStatusLabel
    Friend WithEvents tsProjectName As ToolStripStatusLabel
End Class
