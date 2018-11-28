<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDevice
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblDevModel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFirmware = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSerialNo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rdbIP = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtCommPW = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.chkReset = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkSync = New System.Windows.Forms.CheckBox()
        Me.cbbArea = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDeviceName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAddDevice = New System.Windows.Forms.Button()
        Me.grbIP = New System.Windows.Forms.GroupBox()
        Me.chkMaster = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.grbIP.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 73)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(912, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(360, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 49)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ADD DEVICE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 27)
        Me.Panel2.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDevModel, Me.lblFirmware, Me.lblSerialNo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 2)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(980, 25)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblDevModel
        '
        Me.lblDevModel.Name = "lblDevModel"
        Me.lblDevModel.Size = New System.Drawing.Size(101, 20)
        Me.lblDevModel.Text = "Device Model"
        '
        'lblFirmware
        '
        Me.lblFirmware.Name = "lblFirmware"
        Me.lblFirmware.Size = New System.Drawing.Size(122, 20)
        Me.lblFirmware.Text = "Firmware Version"
        '
        'lblSerialNo
        '
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(70, 20)
        Me.lblSerialNo.Text = "Serial No"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdbIP)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(980, 38)
        Me.Panel3.TabIndex = 5
        '
        'rdbIP
        '
        Me.rdbIP.AutoSize = True
        Me.rdbIP.Checked = True
        Me.rdbIP.Location = New System.Drawing.Point(166, 9)
        Me.rdbIP.Name = "rdbIP"
        Me.rdbIP.Size = New System.Drawing.Size(72, 21)
        Me.rdbIP.TabIndex = 5
        Me.rdbIP.TabStop = True
        Me.rdbIP.Text = "TCP/IP"
        Me.rdbIP.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Connection Type:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnTest)
        Me.Panel4.Controls.Add(Me.txtCommPW)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtPort)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtIP)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(23, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(446, 186)
        Me.Panel4.TabIndex = 14
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(334, 142)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(72, 26)
        Me.btnTest.TabIndex = 20
        Me.btnTest.Text = "Connect"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtCommPW
        '
        Me.txtCommPW.Location = New System.Drawing.Point(266, 112)
        Me.txtCommPW.Name = "txtCommPW"
        Me.txtCommPW.Size = New System.Drawing.Size(140, 22)
        Me.txtCommPW.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(17, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Communication Password:"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(266, 69)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(140, 22)
        Me.txtPort.TabIndex = 17
        Me.txtPort.Text = "4370"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(17, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Port:"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(266, 25)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(140, 22)
        Me.txtIP.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(17, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "IP Address:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.chkMaster)
        Me.Panel5.Controls.Add(Me.chkReset)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.chkSync)
        Me.Panel5.Controls.Add(Me.cbbArea)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.txtDeviceName)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Location = New System.Drawing.Point(490, 48)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(446, 186)
        Me.Panel5.TabIndex = 21
        '
        'chkReset
        '
        Me.chkReset.AutoSize = True
        Me.chkReset.Location = New System.Drawing.Point(167, 148)
        Me.chkReset.Name = "chkReset"
        Me.chkReset.Size = New System.Drawing.Size(18, 17)
        Me.chkReset.TabIndex = 24
        Me.chkReset.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(17, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Reset Device"
        '
        'chkSync
        '
        Me.chkSync.AutoSize = True
        Me.chkSync.Location = New System.Drawing.Point(167, 112)
        Me.chkSync.Name = "chkSync"
        Me.chkSync.Size = New System.Drawing.Size(18, 17)
        Me.chkSync.TabIndex = 22
        Me.chkSync.UseVisualStyleBackColor = True
        '
        'cbbArea
        '
        Me.cbbArea.FormattingEnabled = True
        Me.cbbArea.Items.AddRange(New Object() {"Office"})
        Me.cbbArea.Location = New System.Drawing.Point(246, 67)
        Me.cbbArea.Name = "cbbArea"
        Me.cbbArea.Size = New System.Drawing.Size(140, 24)
        Me.cbbArea.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(17, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Sync Date Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(17, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Area:"
        '
        'txtDeviceName
        '
        Me.txtDeviceName.Location = New System.Drawing.Point(246, 24)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.Size = New System.Drawing.Size(140, 22)
        Me.txtDeviceName.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(17, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Device Name:"
        '
        'btnAddDevice
        '
        Me.btnAddDevice.Enabled = False
        Me.btnAddDevice.Location = New System.Drawing.Point(841, 240)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(95, 49)
        Me.btnAddDevice.TabIndex = 22
        Me.btnAddDevice.Text = "Add Device"
        Me.btnAddDevice.UseVisualStyleBackColor = True
        '
        'grbIP
        '
        Me.grbIP.Controls.Add(Me.btnAddDevice)
        Me.grbIP.Controls.Add(Me.Panel5)
        Me.grbIP.Controls.Add(Me.Panel4)
        Me.grbIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbIP.Location = New System.Drawing.Point(0, 111)
        Me.grbIP.Name = "grbIP"
        Me.grbIP.Size = New System.Drawing.Size(980, 301)
        Me.grbIP.TabIndex = 6
        Me.grbIP.TabStop = False
        Me.grbIP.Text = "TCP/IP Connection "
        '
        'chkMaster
        '
        Me.chkMaster.AutoSize = True
        Me.chkMaster.Location = New System.Drawing.Point(368, 117)
        Me.chkMaster.Name = "chkMaster"
        Me.chkMaster.Size = New System.Drawing.Size(18, 17)
        Me.chkMaster.TabIndex = 26
        Me.chkMaster.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(243, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 23)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Master Device"
        '
        'frmAddDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 439)
        Me.Controls.Add(Me.grbIP)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddDevice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.grbIP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rdbIP As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblDevModel As ToolStripStatusLabel
    Friend WithEvents lblFirmware As ToolStripStatusLabel
    Friend WithEvents lblSerialNo As ToolStripStatusLabel
    Friend WithEvents btnClose As Button
    Friend WithEvents grbIP As GroupBox
    Friend WithEvents btnAddDevice As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents chkReset As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkSync As CheckBox
    Friend WithEvents cbbArea As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDeviceName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnTest As Button
    Friend WithEvents txtCommPW As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkMaster As CheckBox
    Friend WithEvents Label10 As Label
End Class
