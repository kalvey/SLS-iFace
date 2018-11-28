<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailATT
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1079, 100)
        Me.Panel1.TabIndex = 4
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
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1042, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvHistory
        '
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistory.GridColor = System.Drawing.Color.White
        Me.dgvHistory.Location = New System.Drawing.Point(0, 100)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.RowTemplate.Height = 24
        Me.dgvHistory.Size = New System.Drawing.Size(1079, 430)
        Me.dgvHistory.TabIndex = 5
        '
        'frmDetailATT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 530)
        Me.Controls.Add(Me.dgvHistory)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDetailATT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetailATT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvHistory As DataGridView
End Class
