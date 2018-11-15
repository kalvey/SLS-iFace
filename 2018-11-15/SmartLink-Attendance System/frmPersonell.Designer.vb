<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPersonell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonell))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvPersonell = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddDevice = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UnblockUserCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockUserCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnblockUserCardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableOrDisableUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPersonell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1109, 476)
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
        Me.TabPage1.Size = New System.Drawing.Size(1101, 447)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Issue Card for Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvPersonell)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1095, 349)
        Me.Panel3.TabIndex = 3
        '
        'dgvPersonell
        '
        Me.dgvPersonell.AllowUserToAddRows = False
        Me.dgvPersonell.AllowUserToDeleteRows = False
        Me.dgvPersonell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPersonell.Location = New System.Drawing.Point(0, 0)
        Me.dgvPersonell.Name = "dgvPersonell"
        Me.dgvPersonell.RowTemplate.Height = 24
        Me.dgvPersonell.Size = New System.Drawing.Size(1095, 349)
        Me.dgvPersonell.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnAddDevice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 394)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1095, 50)
        Me.Panel2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1047, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 45)
        Me.btnClose.TabIndex = 10
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Location = New System.Drawing.Point(102, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 45)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(51, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(45, 45)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAddDevice
        '
        Me.btnAddDevice.BackgroundImage = CType(resources.GetObject("btnAddDevice.BackgroundImage"), System.Drawing.Image)
        Me.btnAddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddDevice.Location = New System.Drawing.Point(0, 2)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(45, 45)
        Me.btnAddDevice.TabIndex = 7
        Me.btnAddDevice.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 42)
        Me.Panel1.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSearch.Location = New System.Drawing.Point(223, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(311, 30)
        Me.txtSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search Personell Here:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnblockUserCardToolStripMenuItem, Me.BlockUserCardToolStripMenuItem, Me.UnblockUserCardToolStripMenuItem1, Me.ReturnCardToolStripMenuItem, Me.EnableOrDisableUserToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(229, 124)
        '
        'UnblockUserCardToolStripMenuItem
        '
        Me.UnblockUserCardToolStripMenuItem.Name = "UnblockUserCardToolStripMenuItem"
        Me.UnblockUserCardToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.UnblockUserCardToolStripMenuItem.Text = "Issue Card"
        '
        'BlockUserCardToolStripMenuItem
        '
        Me.BlockUserCardToolStripMenuItem.Name = "BlockUserCardToolStripMenuItem"
        Me.BlockUserCardToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.BlockUserCardToolStripMenuItem.Text = "Block User Card"
        '
        'UnblockUserCardToolStripMenuItem1
        '
        Me.UnblockUserCardToolStripMenuItem1.Name = "UnblockUserCardToolStripMenuItem1"
        Me.UnblockUserCardToolStripMenuItem1.Size = New System.Drawing.Size(228, 24)
        Me.UnblockUserCardToolStripMenuItem1.Text = "Unblock User Card"
        '
        'ReturnCardToolStripMenuItem
        '
        Me.ReturnCardToolStripMenuItem.Name = "ReturnCardToolStripMenuItem"
        Me.ReturnCardToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.ReturnCardToolStripMenuItem.Text = "Return Card"
        '
        'EnableOrDisableUserToolStripMenuItem
        '
        Me.EnableOrDisableUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableUserToolStripMenuItem, Me.DisableUserToolStripMenuItem})
        Me.EnableOrDisableUserToolStripMenuItem.Name = "EnableOrDisableUserToolStripMenuItem"
        Me.EnableOrDisableUserToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.EnableOrDisableUserToolStripMenuItem.Text = "Enable or Disable User"
        '
        'EnableUserToolStripMenuItem
        '
        Me.EnableUserToolStripMenuItem.Name = "EnableUserToolStripMenuItem"
        Me.EnableUserToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.EnableUserToolStripMenuItem.Text = "Enable User"
        '
        'DisableUserToolStripMenuItem
        '
        Me.DisableUserToolStripMenuItem.Name = "DisableUserToolStripMenuItem"
        Me.DisableUserToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.DisableUserToolStripMenuItem.Text = "Disable User"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(154, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(141, 45)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmPersonell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 476)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPersonell"
        Me.Text = "frmPersonell"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvPersonell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAddDevice As Button
    Friend WithEvents dgvPersonell As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BlockUserCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnblockUserCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnblockUserCardToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReturnCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableOrDisableUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPrint As Button
End Class
