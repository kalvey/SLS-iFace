<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgv
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtpAtt = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.dtpAtt)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1432, 90)
        Me.Panel1.TabIndex = 3
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1210, 47)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(794, 21)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 50)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "populate DGV2 with Data"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(645, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "populate DGV2 with Data"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(492, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "populate DGV2 with Data"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(329, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "populate DGV2 with Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(180, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "generateSQL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtpAtt
        '
        Me.dtpAtt.Location = New System.Drawing.Point(955, 33)
        Me.dtpAtt.Name = "dtpAtt"
        Me.dtpAtt.Size = New System.Drawing.Size(200, 22)
        Me.dtpAtt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "generate Format on DGV2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 697)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1432, 60)
        Me.Panel2.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgv2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgv1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 90)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1432, 607)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'dgv2
        '
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.empNo, Me.empName, Me.Department})
        Me.dgv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv2.Location = New System.Drawing.Point(3, 306)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.RowTemplate.Height = 24
        Me.dgv2.Size = New System.Drawing.Size(1426, 298)
        Me.dgv2.TabIndex = 1
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        '
        'empNo
        '
        Me.empNo.HeaderText = "Employee Number"
        Me.empNo.Name = "empNo"
        '
        'empName
        '
        Me.empName.HeaderText = "Employee Name"
        Me.empName.Name = "empName"
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 3)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(1426, 297)
        Me.dgv1.TabIndex = 0
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1230, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(444, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 8
        Me.DataGridView1.Visible = False
        '
        'dgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1432, 757)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "dgv"
        Me.Text = "dgv"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents empNo As DataGridViewTextBoxColumn
    Friend WithEvents empName As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents dtpAtt As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
