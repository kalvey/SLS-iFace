<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpContract
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvEmp = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvLog = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpAtt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAbsence = New System.Windows.Forms.DataGridView()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ThisEmployeeIsNotActiveAnymoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.uID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAbsence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1241, 615)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvEmp)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1233, 580)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NEARLY OVER CONTRACT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvEmp
        '
        Me.dgvEmp.AllowUserToAddRows = False
        Me.dgvEmp.AllowUserToDeleteRows = False
        Me.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 11.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmp.EnableHeadersVisualStyles = False
        Me.dgvEmp.Location = New System.Drawing.Point(3, 58)
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.ReadOnly = True
        Me.dgvEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvEmp.RowTemplate.Height = 30
        Me.dgvEmp.Size = New System.Drawing.Size(1227, 466)
        Me.dgvEmp.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1227, 55)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOTIFICATION: THESE EMPLOYEE WILL BE END OF CONTRACT SOON!"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 524)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1227, 53)
        Me.Panel3.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(1079, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 41)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvLog)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.dgvAbsence)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1233, 580)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "EMPLOYEE ABSENCE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvLog
        '
        Me.dgvLog.AllowUserToAddRows = False
        Me.dgvLog.AllowUserToDeleteRows = False
        Me.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.uID, Me.Column1, Me.Column2, Me.Column4, Me.Column3})
        Me.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLog.Location = New System.Drawing.Point(3, 58)
        Me.dgvLog.Name = "dgvLog"
        Me.dgvLog.ReadOnly = True
        Me.dgvLog.RowTemplate.Height = 24
        Me.dgvLog.Size = New System.Drawing.Size(1227, 290)
        Me.dgvLog.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.dtpAtt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1227, 55)
        Me.Panel1.TabIndex = 4
        '
        'dtpAtt
        '
        Me.dtpAtt.Location = New System.Drawing.Point(1011, 15)
        Me.dtpAtt.Name = "dtpAtt"
        Me.dtpAtt.Size = New System.Drawing.Size(200, 30)
        Me.dtpAtt.TabIndex = 1
        Me.dtpAtt.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(541, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NOTIFICATION: THESE EMPLOYEE WILL BE END OF CONTRACT SOON!"
        '
        'dgvAbsence
        '
        Me.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAbsence.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvAbsence.Location = New System.Drawing.Point(3, 348)
        Me.dgvAbsence.Name = "dgvAbsence"
        Me.dgvAbsence.RowTemplate.Height = 24
        Me.dgvAbsence.Size = New System.Drawing.Size(1227, 229)
        Me.dgvAbsence.TabIndex = 0
        Me.dgvAbsence.Visible = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThisEmployeeIsNotActiveAnymoreToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(322, 28)
        '
        'ThisEmployeeIsNotActiveAnymoreToolStripMenuItem
        '
        Me.ThisEmployeeIsNotActiveAnymoreToolStripMenuItem.Name = "ThisEmployeeIsNotActiveAnymoreToolStripMenuItem"
        Me.ThisEmployeeIsNotActiveAnymoreToolStripMenuItem.Size = New System.Drawing.Size(321, 24)
        Me.ThisEmployeeIsNotActiveAnymoreToolStripMenuItem.Text = "This Employee is not Active anymore"
        '
        'uID
        '
        Me.uID.HeaderText = "User ID"
        Me.uID.Name = "uID"
        Me.uID.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Employee Number"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Employee Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Department"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Absence Days"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'frmEmpContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 615)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmpContract"
        Me.Text = "frmEmpContract"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvAbsence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ThisEmployeeIsNotActiveAnymoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvAbsence As DataGridView
    Friend WithEvents dgvLog As DataGridView
    Friend WithEvents dtpAtt As DateTimePicker
    Friend WithEvents uID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
