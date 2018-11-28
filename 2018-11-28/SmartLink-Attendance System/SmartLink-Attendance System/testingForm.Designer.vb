<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testingForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtpAtt = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpAtt)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 63)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1157, 434)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(321, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtpAtt
        '
        Me.dtpAtt.Location = New System.Drawing.Point(637, 23)
        Me.dtpAtt.Name = "dtpAtt"
        Me.dtpAtt.Size = New System.Drawing.Size(200, 22)
        Me.dtpAtt.TabIndex = 2
        '
        'testingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 497)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "testingForm"
        Me.Text = "testingForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpAtt As DateTimePicker
    Friend WithEvents Button2 As Button
End Class
