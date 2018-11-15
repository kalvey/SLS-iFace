<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bom
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
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpAtt = New System.Windows.Forms.DateTimePicker()
        Me.cbbDepart = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployee
        '
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Location = New System.Drawing.Point(40, 96)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.RowTemplate.Height = 24
        Me.dgvEmployee.Size = New System.Drawing.Size(418, 317)
        Me.dgvEmployee.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpAtt
        '
        Me.dtpAtt.Location = New System.Drawing.Point(28, 13)
        Me.dtpAtt.Name = "dtpAtt"
        Me.dtpAtt.Size = New System.Drawing.Size(200, 22)
        Me.dtpAtt.TabIndex = 2
        '
        'cbbDepart
        '
        Me.cbbDepart.FormattingEnabled = True
        Me.cbbDepart.Location = New System.Drawing.Point(235, 9)
        Me.cbbDepart.Name = "cbbDepart"
        Me.cbbDepart.Size = New System.Drawing.Size(121, 24)
        Me.cbbDepart.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(513, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(418, 317)
        Me.DataGridView1.TabIndex = 4
        '
        'bom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 502)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbbDepart)
        Me.Controls.Add(Me.dtpAtt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvEmployee)
        Me.Name = "bom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bom"
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpAtt As DateTimePicker
    Friend WithEvents cbbDepart As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
