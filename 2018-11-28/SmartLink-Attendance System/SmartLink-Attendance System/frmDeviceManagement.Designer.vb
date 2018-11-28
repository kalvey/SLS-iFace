<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeviceManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeviceManagement))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvDevice = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddDevice = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvArea = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtSearchArea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnClose2 = New System.Windows.Forms.Button()
        Me.btnDeleteArea = New System.Windows.Forms.Button()
        Me.btnEditArea = New System.Windows.Forms.Button()
        Me.btnAddArea = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UseThisDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDeviceDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SynchronizeClockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDeviceDateAndTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SynchronizeDeviceDateAndTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAdministratorPrivilegeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableThisDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnounceDataToDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1243, 507)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1235, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Device Management"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvDevice)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1229, 362)
        Me.Panel3.TabIndex = 2
        '
        'dgvDevice
        '
        Me.dgvDevice.AllowUserToAddRows = False
        Me.dgvDevice.AllowUserToDeleteRows = False
        Me.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDevice.Location = New System.Drawing.Point(0, 0)
        Me.dgvDevice.Name = "dgvDevice"
        Me.dgvDevice.RowTemplate.Height = 24
        Me.dgvDevice.Size = New System.Drawing.Size(1229, 362)
        Me.dgvDevice.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnAddDevice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 407)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1229, 68)
        Me.Panel2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1179, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 45)
        Me.btnClose.TabIndex = 11
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Location = New System.Drawing.Point(112, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 45)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(61, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(45, 45)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAddDevice
        '
        Me.btnAddDevice.BackgroundImage = CType(resources.GetObject("btnAddDevice.BackgroundImage"), System.Drawing.Image)
        Me.btnAddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddDevice.Location = New System.Drawing.Point(10, 12)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(45, 45)
        Me.btnAddDevice.TabIndex = 4
        Me.btnAddDevice.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1229, 42)
        Me.Panel1.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSearch.Location = New System.Drawing.Point(187, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(311, 30)
        Me.txtSearch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Device Here:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1235, 478)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Area Management"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvArea)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 45)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1229, 362)
        Me.Panel6.TabIndex = 5
        '
        'dgvArea
        '
        Me.dgvArea.AllowUserToAddRows = False
        Me.dgvArea.AllowUserToDeleteRows = False
        Me.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvArea.Location = New System.Drawing.Point(0, 0)
        Me.dgvArea.Name = "dgvArea"
        Me.dgvArea.RowTemplate.Height = 24
        Me.dgvArea.Size = New System.Drawing.Size(1229, 362)
        Me.dgvArea.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtSearchArea)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1229, 42)
        Me.Panel4.TabIndex = 2
        '
        'txtSearchArea
        '
        Me.txtSearchArea.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSearchArea.Location = New System.Drawing.Point(159, 6)
        Me.txtSearchArea.Name = "txtSearchArea"
        Me.txtSearchArea.Size = New System.Drawing.Size(311, 30)
        Me.txtSearchArea.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search Area Here:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnClose2)
        Me.Panel5.Controls.Add(Me.btnDeleteArea)
        Me.Panel5.Controls.Add(Me.btnEditArea)
        Me.Panel5.Controls.Add(Me.btnAddArea)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 407)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1229, 68)
        Me.Panel5.TabIndex = 4
        '
        'btnClose2
        '
        Me.btnClose2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose2.BackgroundImage = CType(resources.GetObject("btnClose2.BackgroundImage"), System.Drawing.Image)
        Me.btnClose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose2.Location = New System.Drawing.Point(1179, 12)
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(45, 45)
        Me.btnClose2.TabIndex = 11
        Me.btnClose2.UseVisualStyleBackColor = True
        '
        'btnDeleteArea
        '
        Me.btnDeleteArea.BackgroundImage = CType(resources.GetObject("btnDeleteArea.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteArea.Location = New System.Drawing.Point(112, 12)
        Me.btnDeleteArea.Name = "btnDeleteArea"
        Me.btnDeleteArea.Size = New System.Drawing.Size(45, 45)
        Me.btnDeleteArea.TabIndex = 6
        Me.btnDeleteArea.UseVisualStyleBackColor = True
        '
        'btnEditArea
        '
        Me.btnEditArea.BackgroundImage = CType(resources.GetObject("btnEditArea.BackgroundImage"), System.Drawing.Image)
        Me.btnEditArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditArea.Location = New System.Drawing.Point(61, 12)
        Me.btnEditArea.Name = "btnEditArea"
        Me.btnEditArea.Size = New System.Drawing.Size(45, 45)
        Me.btnEditArea.TabIndex = 5
        Me.btnEditArea.UseVisualStyleBackColor = True
        '
        'btnAddArea
        '
        Me.btnAddArea.BackgroundImage = CType(resources.GetObject("btnAddArea.BackgroundImage"), System.Drawing.Image)
        Me.btnAddArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddArea.Location = New System.Drawing.Point(10, 12)
        Me.btnAddArea.Name = "btnAddArea"
        Me.btnAddArea.Size = New System.Drawing.Size(45, 45)
        Me.btnAddArea.TabIndex = 4
        Me.btnAddArea.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UseThisDeviceToolStripMenuItem, Me.UpdateDeviceDataToolStripMenuItem, Me.SynchronizeClockToolStripMenuItem, Me.ClearAdministratorPrivilegeToolStripMenuItem, Me.ResetDeviceToolStripMenuItem, Me.RestartDeviceToolStripMenuItem, Me.ShutDownDeviceToolStripMenuItem, Me.EnableThisDeviceToolStripMenuItem, Me.AnnounceDataToDeviceToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(269, 220)
        '
        'UseThisDeviceToolStripMenuItem
        '
        Me.UseThisDeviceToolStripMenuItem.Name = "UseThisDeviceToolStripMenuItem"
        Me.UseThisDeviceToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.UseThisDeviceToolStripMenuItem.Text = "Use This Device"
        '
        'UpdateDeviceDataToolStripMenuItem
        '
        Me.UpdateDeviceDataToolStripMenuItem.Name = "UpdateDeviceDataToolStripMenuItem"
        Me.UpdateDeviceDataToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.UpdateDeviceDataToolStripMenuItem.Text = "Get Newest Device Data"
        '
        'SynchronizeClockToolStripMenuItem
        '
        Me.SynchronizeClockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetDeviceDateAndTimeToolStripMenuItem, Me.SynchronizeDeviceDateAndTimeToolStripMenuItem})
        Me.SynchronizeClockToolStripMenuItem.Name = "SynchronizeClockToolStripMenuItem"
        Me.SynchronizeClockToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.SynchronizeClockToolStripMenuItem.Text = "Device Clock"
        '
        'SetDeviceDateAndTimeToolStripMenuItem
        '
        Me.SetDeviceDateAndTimeToolStripMenuItem.Name = "SetDeviceDateAndTimeToolStripMenuItem"
        Me.SetDeviceDateAndTimeToolStripMenuItem.Size = New System.Drawing.Size(314, 26)
        Me.SetDeviceDateAndTimeToolStripMenuItem.Text = "Set Device Date and Time"
        '
        'SynchronizeDeviceDateAndTimeToolStripMenuItem
        '
        Me.SynchronizeDeviceDateAndTimeToolStripMenuItem.Name = "SynchronizeDeviceDateAndTimeToolStripMenuItem"
        Me.SynchronizeDeviceDateAndTimeToolStripMenuItem.Size = New System.Drawing.Size(314, 26)
        Me.SynchronizeDeviceDateAndTimeToolStripMenuItem.Text = "Synchronize Device Date and Time"
        '
        'ClearAdministratorPrivilegeToolStripMenuItem
        '
        Me.ClearAdministratorPrivilegeToolStripMenuItem.Name = "ClearAdministratorPrivilegeToolStripMenuItem"
        Me.ClearAdministratorPrivilegeToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.ClearAdministratorPrivilegeToolStripMenuItem.Text = "Clear Administrator Privilege"
        '
        'ResetDeviceToolStripMenuItem
        '
        Me.ResetDeviceToolStripMenuItem.Name = "ResetDeviceToolStripMenuItem"
        Me.ResetDeviceToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.ResetDeviceToolStripMenuItem.Text = "Reset Device"
        '
        'RestartDeviceToolStripMenuItem
        '
        Me.RestartDeviceToolStripMenuItem.Name = "RestartDeviceToolStripMenuItem"
        Me.RestartDeviceToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.RestartDeviceToolStripMenuItem.Text = "Restart Device"
        '
        'ShutDownDeviceToolStripMenuItem
        '
        Me.ShutDownDeviceToolStripMenuItem.Name = "ShutDownDeviceToolStripMenuItem"
        Me.ShutDownDeviceToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.ShutDownDeviceToolStripMenuItem.Text = "Shut Down Device"
        '
        'EnableThisDeviceToolStripMenuItem
        '
        Me.EnableThisDeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableDeviceToolStripMenuItem, Me.DisableDeviceToolStripMenuItem})
        Me.EnableThisDeviceToolStripMenuItem.Name = "EnableThisDeviceToolStripMenuItem"
        Me.EnableThisDeviceToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.EnableThisDeviceToolStripMenuItem.Text = "Enable or Disable Device"
        '
        'EnableDeviceToolStripMenuItem
        '
        Me.EnableDeviceToolStripMenuItem.Name = "EnableDeviceToolStripMenuItem"
        Me.EnableDeviceToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.EnableDeviceToolStripMenuItem.Text = "Enable Device"
        '
        'DisableDeviceToolStripMenuItem
        '
        Me.DisableDeviceToolStripMenuItem.Name = "DisableDeviceToolStripMenuItem"
        Me.DisableDeviceToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.DisableDeviceToolStripMenuItem.Text = "Disable Device"
        '
        'AnnounceDataToDeviceToolStripMenuItem
        '
        Me.AnnounceDataToDeviceToolStripMenuItem.Name = "AnnounceDataToDeviceToolStripMenuItem"
        Me.AnnounceDataToDeviceToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.AnnounceDataToDeviceToolStripMenuItem.Text = "Announce Data to Device"
        '
        'frmDeviceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 507)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDeviceManagement"
        Me.Text = "frmDeviceManagement"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvDevice As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAddDevice As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EnableThisDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SynchronizeClockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetDeviceDateAndTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SynchronizeDeviceDateAndTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutDownDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateDeviceDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAdministratorPrivilegeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtSearchArea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnDeleteArea As Button
    Friend WithEvents btnEditArea As Button
    Friend WithEvents btnAddArea As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvArea As DataGridView
    Friend WithEvents ResetDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClose2 As Button
    Friend WithEvents UseThisDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnnounceDataToDeviceToolStripMenuItem As ToolStripMenuItem
End Class
