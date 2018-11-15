<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnNotification = New ns1.BunifuFlatButton()
        Me.btnMasterData = New ns1.BunifuFlatButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPersonell = New ns1.BunifuFlatButton()
        Me.btnReport = New ns1.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDevice = New ns1.BunifuFlatButton()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EnableThisDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnNotification)
        Me.Panel1.Controls.Add(Me.btnMasterData)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnPersonell)
        Me.Panel1.Controls.Add(Me.btnReport)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnDevice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1762, 78)
        Me.Panel1.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnLogOut.Location = New System.Drawing.Point(1609, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(103, 32)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "LOGOUT"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnNotification
        '
        Me.btnNotification.Activecolor = System.Drawing.SystemColors.HotTrack
        Me.btnNotification.BackColor = System.Drawing.Color.LightSalmon
        Me.btnNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNotification.BorderRadius = 0
        Me.btnNotification.ButtonText = "   Notification"
        Me.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotification.DisabledColor = System.Drawing.Color.Gray
        Me.btnNotification.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNotification.Iconimage = CType(resources.GetObject("btnNotification.Iconimage"), System.Drawing.Image)
        Me.btnNotification.Iconimage_right = Nothing
        Me.btnNotification.Iconimage_right_Selected = Nothing
        Me.btnNotification.Iconimage_Selected = Nothing
        Me.btnNotification.IconMarginLeft = 0
        Me.btnNotification.IconMarginRight = 0
        Me.btnNotification.IconRightVisible = True
        Me.btnNotification.IconRightZoom = 0R
        Me.btnNotification.IconVisible = True
        Me.btnNotification.IconZoom = 40.0R
        Me.btnNotification.IsTab = False
        Me.btnNotification.Location = New System.Drawing.Point(1261, 0)
        Me.btnNotification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Normalcolor = System.Drawing.Color.LightSalmon
        Me.btnNotification.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.btnNotification.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNotification.selected = False
        Me.btnNotification.Size = New System.Drawing.Size(272, 83)
        Me.btnNotification.TabIndex = 4
        Me.btnNotification.Text = "   Notification"
        Me.btnNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNotification.Textcolor = System.Drawing.Color.White
        Me.btnNotification.TextFont = New System.Drawing.Font("Calibri", 12.0!)
        '
        'btnMasterData
        '
        Me.btnMasterData.Activecolor = System.Drawing.SystemColors.HotTrack
        Me.btnMasterData.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnMasterData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMasterData.BorderRadius = 0
        Me.btnMasterData.ButtonText = "   Master Data"
        Me.btnMasterData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasterData.DisabledColor = System.Drawing.Color.Gray
        Me.btnMasterData.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMasterData.Iconimage = CType(resources.GetObject("btnMasterData.Iconimage"), System.Drawing.Image)
        Me.btnMasterData.Iconimage_right = Nothing
        Me.btnMasterData.Iconimage_right_Selected = Nothing
        Me.btnMasterData.Iconimage_Selected = Nothing
        Me.btnMasterData.IconMarginLeft = 0
        Me.btnMasterData.IconMarginRight = 0
        Me.btnMasterData.IconRightVisible = True
        Me.btnMasterData.IconRightZoom = 0R
        Me.btnMasterData.IconVisible = True
        Me.btnMasterData.IconZoom = 90.0R
        Me.btnMasterData.IsTab = False
        Me.btnMasterData.Location = New System.Drawing.Point(981, 0)
        Me.btnMasterData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMasterData.Name = "btnMasterData"
        Me.btnMasterData.Normalcolor = System.Drawing.SystemColors.Highlight
        Me.btnMasterData.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.btnMasterData.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMasterData.selected = False
        Me.btnMasterData.Size = New System.Drawing.Size(305, 83)
        Me.btnMasterData.TabIndex = 6
        Me.btnMasterData.Text = "   Master Data"
        Me.btnMasterData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMasterData.Textcolor = System.Drawing.Color.White
        Me.btnMasterData.TextFont = New System.Drawing.Font("Calibri", 12.0!)
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnClose.Location = New System.Drawing.Point(1718, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPersonell
        '
        Me.btnPersonell.Activecolor = System.Drawing.SystemColors.HotTrack
        Me.btnPersonell.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPersonell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPersonell.BorderRadius = 0
        Me.btnPersonell.ButtonText = "     Personell and Card Management"
        Me.btnPersonell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonell.DisabledColor = System.Drawing.Color.Gray
        Me.btnPersonell.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPersonell.Iconimage = CType(resources.GetObject("btnPersonell.Iconimage"), System.Drawing.Image)
        Me.btnPersonell.Iconimage_right = Nothing
        Me.btnPersonell.Iconimage_right_Selected = Nothing
        Me.btnPersonell.Iconimage_Selected = Nothing
        Me.btnPersonell.IconMarginLeft = 0
        Me.btnPersonell.IconMarginRight = 0
        Me.btnPersonell.IconRightVisible = True
        Me.btnPersonell.IconRightZoom = 0R
        Me.btnPersonell.IconVisible = True
        Me.btnPersonell.IconZoom = 90.0R
        Me.btnPersonell.IsTab = False
        Me.btnPersonell.Location = New System.Drawing.Point(476, 0)
        Me.btnPersonell.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPersonell.Name = "btnPersonell"
        Me.btnPersonell.Normalcolor = System.Drawing.SystemColors.Highlight
        Me.btnPersonell.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.btnPersonell.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPersonell.selected = False
        Me.btnPersonell.Size = New System.Drawing.Size(296, 83)
        Me.btnPersonell.TabIndex = 3
        Me.btnPersonell.Text = "     Personell and Card Management"
        Me.btnPersonell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPersonell.Textcolor = System.Drawing.Color.White
        Me.btnPersonell.TextFont = New System.Drawing.Font("Calibri", 12.0!)
        '
        'btnReport
        '
        Me.btnReport.Activecolor = System.Drawing.SystemColors.HotTrack
        Me.btnReport.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.BorderRadius = 0
        Me.btnReport.ButtonText = "Report"
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.DisabledColor = System.Drawing.Color.Gray
        Me.btnReport.Iconcolor = System.Drawing.Color.Transparent
        Me.btnReport.Iconimage = CType(resources.GetObject("btnReport.Iconimage"), System.Drawing.Image)
        Me.btnReport.Iconimage_right = Nothing
        Me.btnReport.Iconimage_right_Selected = Nothing
        Me.btnReport.Iconimage_Selected = Nothing
        Me.btnReport.IconMarginLeft = 0
        Me.btnReport.IconMarginRight = 0
        Me.btnReport.IconRightVisible = True
        Me.btnReport.IconRightZoom = 0R
        Me.btnReport.IconVisible = True
        Me.btnReport.IconZoom = 90.0R
        Me.btnReport.IsTab = False
        Me.btnReport.Location = New System.Drawing.Point(760, 0)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Normalcolor = System.Drawing.SystemColors.Highlight
        Me.btnReport.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.btnReport.OnHoverTextColor = System.Drawing.Color.White
        Me.btnReport.selected = False
        Me.btnReport.Size = New System.Drawing.Size(243, 83)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnReport.Textcolor = System.Drawing.Color.White
        Me.btnReport.TextFont = New System.Drawing.Font("Calibri", 12.0!)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(253, 78)
        Me.Panel2.TabIndex = 1
        '
        'btnDevice
        '
        Me.btnDevice.Activecolor = System.Drawing.SystemColors.HotTrack
        Me.btnDevice.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDevice.BorderRadius = 0
        Me.btnDevice.ButtonText = "Device"
        Me.btnDevice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDevice.DisabledColor = System.Drawing.Color.Gray
        Me.btnDevice.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDevice.Iconimage = CType(resources.GetObject("btnDevice.Iconimage"), System.Drawing.Image)
        Me.btnDevice.Iconimage_right = Nothing
        Me.btnDevice.Iconimage_right_Selected = Nothing
        Me.btnDevice.Iconimage_Selected = Nothing
        Me.btnDevice.IconMarginLeft = 0
        Me.btnDevice.IconMarginRight = 0
        Me.btnDevice.IconRightVisible = True
        Me.btnDevice.IconRightZoom = 0R
        Me.btnDevice.IconVisible = True
        Me.btnDevice.IconZoom = 90.0R
        Me.btnDevice.IsTab = False
        Me.btnDevice.Location = New System.Drawing.Point(255, 0)
        Me.btnDevice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDevice.Name = "btnDevice"
        Me.btnDevice.Normalcolor = System.Drawing.SystemColors.Highlight
        Me.btnDevice.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.btnDevice.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDevice.selected = False
        Me.btnDevice.Size = New System.Drawing.Size(236, 83)
        Me.btnDevice.TabIndex = 0
        Me.btnDevice.Text = "Device"
        Me.btnDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDevice.Textcolor = System.Drawing.Color.White
        Me.btnDevice.TextFont = New System.Drawing.Font("Calibri", 12.0!)
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableThisDeviceToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 28)
        '
        'EnableThisDeviceToolStripMenuItem
        '
        Me.EnableThisDeviceToolStripMenuItem.Name = "EnableThisDeviceToolStripMenuItem"
        Me.EnableThisDeviceToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.EnableThisDeviceToolStripMenuItem.Text = "Enable this device"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3600000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1762, 630)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents btnReport As ns1.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDevice As ns1.BunifuFlatButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EnableThisDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPersonell As ns1.BunifuFlatButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnNotification As ns1.BunifuFlatButton
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMasterData As ns1.BunifuFlatButton
    Friend WithEvents btnLogOut As Button
End Class
