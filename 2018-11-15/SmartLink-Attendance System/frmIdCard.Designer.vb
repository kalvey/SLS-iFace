<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIdCard))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmpNo = New System.Windows.Forms.Label()
        Me.lblJabatan = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblName.Location = New System.Drawing.Point(83, 230)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(200, 31)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "NAMA KARYAWAN"
        '
        'lblEmpNo
        '
        Me.lblEmpNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmpNo.AutoSize = True
        Me.lblEmpNo.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblEmpNo.Location = New System.Drawing.Point(107, 272)
        Me.lblEmpNo.Name = "lblEmpNo"
        Me.lblEmpNo.Size = New System.Drawing.Size(159, 31)
        Me.lblEmpNo.TabIndex = 3
        Me.lblEmpNo.Text = "EMP NUMBER"
        '
        'lblJabatan
        '
        Me.lblJabatan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJabatan.AutoSize = True
        Me.lblJabatan.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblJabatan.Location = New System.Drawing.Point(126, 327)
        Me.lblJabatan.Name = "lblJabatan"
        Me.lblJabatan.Size = New System.Drawing.Size(102, 31)
        Me.lblJabatan.TabIndex = 4
        Me.lblJabatan.Text = "JABATAN"
        '
        'frmIdCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(393, 541)
        Me.Controls.Add(Me.lblJabatan)
        Me.Controls.Add(Me.lblEmpNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIdCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIdCard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblJabatan As Label
    Friend WithEvents lblEmpNo As Label
    Friend WithEvents lblName As Label
End Class
