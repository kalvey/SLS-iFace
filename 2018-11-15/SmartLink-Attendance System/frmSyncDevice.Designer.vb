<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSyncDevice
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
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.cbbIP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.lvFace = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvDownload = New System.Windows.Forms.ListView()
        Me.ch1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dgvDevice = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTarget)
        Me.Panel1.Controls.Add(Me.cbbIP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 76)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(388, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Target IP"
        '
        'txtTarget
        '
        Me.txtTarget.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtTarget.Location = New System.Drawing.Point(472, 22)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(185, 30)
        Me.txtTarget.TabIndex = 3
        '
        'cbbIP
        '
        Me.cbbIP.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbIP.FormattingEnabled = True
        Me.cbbIP.Location = New System.Drawing.Point(244, 22)
        Me.cbbIP.Name = "cbbIP"
        Me.cbbIP.Size = New System.Drawing.Size(121, 30)
        Me.cbbIP.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Master Device IP ADDRESS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnUpload)
        Me.Panel2.Controls.Add(Me.btnGetData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 679)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1255, 83)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 65)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "UPLOAD DATA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(1080, 6)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(163, 65)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload Data to Selected Device"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(12, 6)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(163, 65)
        Me.btnGetData.TabIndex = 0
        Me.btnGetData.Text = "Get Data From Master Device"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'lvFace
        '
        Me.lvFace.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvFace.GridLines = True
        Me.lvFace.Location = New System.Drawing.Point(16, 281)
        Me.lvFace.Name = "lvFace"
        Me.lvFace.Size = New System.Drawing.Size(619, 371)
        Me.lvFace.TabIndex = 4
        Me.lvFace.UseCompatibleStateImageBehavior = False
        Me.lvFace.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "UserID"
        Me.ColumnHeader1.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 41
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FingerIndex"
        Me.ColumnHeader3.Width = 52
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "tmpData"
        Me.ColumnHeader4.Width = 72
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Privilege"
        Me.ColumnHeader5.Width = 62
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Password"
        Me.ColumnHeader6.Width = 92
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Ennabled"
        Me.ColumnHeader7.Width = 126
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Flag"
        Me.ColumnHeader8.Width = 101
        '
        'lvDownload
        '
        Me.lvDownload.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ch1, Me.ch2, Me.ch3, Me.ch4, Me.ch5, Me.ch6, Me.ch7, Me.ch8})
        Me.lvDownload.GridLines = True
        Me.lvDownload.Location = New System.Drawing.Point(641, 281)
        Me.lvDownload.Name = "lvDownload"
        Me.lvDownload.Size = New System.Drawing.Size(592, 371)
        Me.lvDownload.TabIndex = 5
        Me.lvDownload.UseCompatibleStateImageBehavior = False
        Me.lvDownload.View = System.Windows.Forms.View.Details
        '
        'ch1
        '
        Me.ch1.Text = "UserID"
        Me.ch1.Width = 54
        '
        'ch2
        '
        Me.ch2.Text = "Name"
        Me.ch2.Width = 41
        '
        'ch3
        '
        Me.ch3.Text = "FingerIndex"
        Me.ch3.Width = 52
        '
        'ch4
        '
        Me.ch4.Text = "tmpData"
        Me.ch4.Width = 72
        '
        'ch5
        '
        Me.ch5.Text = "Privilege"
        Me.ch5.Width = 62
        '
        'ch6
        '
        Me.ch6.Text = "Password"
        Me.ch6.Width = 92
        '
        'ch7
        '
        Me.ch7.Text = "Ennabled"
        Me.ch7.Width = 85
        '
        'ch8
        '
        Me.ch8.Text = "Flag"
        Me.ch8.Width = 103
        '
        'dgvDevice
        '
        Me.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDevice.Location = New System.Drawing.Point(0, 0)
        Me.dgvDevice.Name = "dgvDevice"
        Me.dgvDevice.RowTemplate.Height = 24
        Me.dgvDevice.Size = New System.Drawing.Size(1255, 762)
        Me.dgvDevice.TabIndex = 6
        '
        'frmSyncDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 762)
        Me.Controls.Add(Me.lvDownload)
        Me.Controls.Add(Me.lvFace)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvDevice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSyncDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSyncDevice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnGetData As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvDevice As DataGridView
    Private WithEvents lvDownload As ListView
    Private WithEvents ch1 As ColumnHeader
    Private WithEvents ch2 As ColumnHeader
    Private WithEvents ch3 As ColumnHeader
    Private WithEvents ch4 As ColumnHeader
    Private WithEvents ch5 As ColumnHeader
    Private WithEvents ch6 As ColumnHeader
    Private WithEvents ch7 As ColumnHeader
    Friend WithEvents ch8 As ColumnHeader
    Private WithEvents lvFace As ListView
    Private WithEvents ColumnHeader1 As ColumnHeader
    Private WithEvents ColumnHeader2 As ColumnHeader
    Private WithEvents ColumnHeader3 As ColumnHeader
    Private WithEvents ColumnHeader4 As ColumnHeader
    Private WithEvents ColumnHeader5 As ColumnHeader
    Private WithEvents ColumnHeader6 As ColumnHeader
    Private WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTarget As TextBox
    Friend WithEvents cbbIP As ComboBox
End Class
