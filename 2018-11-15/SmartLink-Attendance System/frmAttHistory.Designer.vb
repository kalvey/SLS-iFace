<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttHistory
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpSearch = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 100)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1060, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(322, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Attendance History"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtpSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1097, 52)
        Me.Panel2.TabIndex = 1
        '
        'dtpSearch
        '
        Me.dtpSearch.CalendarFont = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpSearch.CustomFormat = "yyyy-MM-dd"
        Me.dtpSearch.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSearch.Location = New System.Drawing.Point(150, 11)
        Me.dtpSearch.Name = "dtpSearch"
        Me.dtpSearch.Size = New System.Drawing.Size(140, 32)
        Me.dtpSearch.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sort by Date:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(296, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 32)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AllowUserToDeleteRows = False
        Me.dgvHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistory.Location = New System.Drawing.Point(0, 152)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.RowTemplate.Height = 24
        Me.dgvHistory.Size = New System.Drawing.Size(1097, 425)
        Me.dgvHistory.TabIndex = 2
        '
        'lblHistory
        '
        Me.lblHistory.Location = New System.Drawing.Point(3, 0)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(12, 52)
        Me.lblHistory.TabIndex = 3
        Me.lblHistory.Text = "."
        Me.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblHistory)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(827, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(270, 52)
        Me.Panel3.TabIndex = 4
        '
        'frmAttHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 577)
        Me.Controls.Add(Me.dgvHistory)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAttHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAttHistory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpSearch As DateTimePicker
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblHistory As Label
End Class
