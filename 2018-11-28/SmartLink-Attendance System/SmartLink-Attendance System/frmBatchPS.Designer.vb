<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchPS
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.dgvBatch = New System.Windows.Forms.DataGridView()
        Me.cn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBatch, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1295, 74)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnImport)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 502)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1295, 89)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(589, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(352, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(174, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(156, 59)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 15)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(156, 59)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "IMPORT"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'dgvBatch
        '
        Me.dgvBatch.AllowUserToAddRows = False
        Me.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cn})
        Me.dgvBatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBatch.Location = New System.Drawing.Point(0, 74)
        Me.dgvBatch.Name = "dgvBatch"
        Me.dgvBatch.RowTemplate.Height = 24
        Me.dgvBatch.Size = New System.Drawing.Size(1295, 428)
        Me.dgvBatch.TabIndex = 2
        '
        'cn
        '
        Me.cn.HeaderText = "Card Number"
        Me.cn.Name = "cn"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(461, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IMPORT BATCH: PERSONNEL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBatchPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 591)
        Me.Controls.Add(Me.dgvBatch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBatchPS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBatchPS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvBatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents dgvBatch As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
