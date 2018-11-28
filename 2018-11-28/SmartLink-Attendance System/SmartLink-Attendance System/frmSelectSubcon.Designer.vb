<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSubcon
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
        Me.dgvSubcon = New System.Windows.Forms.DataGridView()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSubcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(958, 100)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT SUBCON"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSelect)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 405)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(958, 48)
        Me.Panel2.TabIndex = 1
        '
        'dgvSubcon
        '
        Me.dgvSubcon.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubcon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSubcon.Location = New System.Drawing.Point(0, 100)
        Me.dgvSubcon.Name = "dgvSubcon"
        Me.dgvSubcon.RowTemplate.Height = 24
        Me.dgvSubcon.Size = New System.Drawing.Size(958, 305)
        Me.dgvSubcon.TabIndex = 2
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(726, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(102, 41)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(834, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 41)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmSelectSubcon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 453)
        Me.Controls.Add(Me.dgvSubcon)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSelectSubcon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSelectSubcon"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvSubcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvSubcon As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSelect As Button
End Class
