<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMasterData
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvMasterEMP = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearchEMP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnCloseEmployee = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvMasterPRJ = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSearchPRJ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEMPtoPRJ = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClosePRJ = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvSC = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtSearchSC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnDelSC = New System.Windows.Forms.Button()
        Me.btnEditSC = New System.Windows.Forms.Button()
        Me.btnAddSC = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvUserLogin = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnDelLogin = New System.Windows.Forms.Button()
        Me.btnEditLogin = New System.Windows.Forms.Button()
        Me.btnAddUserLogin = New System.Windows.Forms.Button()
        Me.btnCloseLogin = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgvUserGroup = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEditUG = New System.Windows.Forms.Button()
        Me.frmAddGroup = New System.Windows.Forms.Button()
        Me.btnCloseUG = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbbBySubcon = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvMasterEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvMasterPRJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvSC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvUserLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvUserGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1399, 658)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvMasterEMP)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1391, 623)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Master Data: Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvMasterEMP
        '
        Me.dgvMasterEMP.AllowUserToAddRows = False
        Me.dgvMasterEMP.AllowUserToDeleteRows = False
        Me.dgvMasterEMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterEMP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMasterEMP.Location = New System.Drawing.Point(3, 75)
        Me.dgvMasterEMP.Name = "dgvMasterEMP"
        Me.dgvMasterEMP.RowTemplate.Height = 24
        Me.dgvMasterEMP.Size = New System.Drawing.Size(1385, 469)
        Me.dgvMasterEMP.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.cbbBySubcon)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtSearchEMP)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1385, 72)
        Me.Panel2.TabIndex = 1
        '
        'txtSearchEMP
        '
        Me.txtSearchEMP.Location = New System.Drawing.Point(173, 18)
        Me.txtSearchEMP.Name = "txtSearchEMP"
        Me.txtSearchEMP.Size = New System.Drawing.Size(198, 30)
        Me.txtSearchEMP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEARCH EMPLOYEE:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.btnCloseEmployee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 544)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1385, 76)
        Me.Panel1.TabIndex = 0
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(9, 10)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(171, 55)
        Me.btnImport.TabIndex = 1
        Me.btnImport.Text = "IMPORT BATCH PERSONNEL"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnCloseEmployee
        '
        Me.btnCloseEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseEmployee.Location = New System.Drawing.Point(1209, 10)
        Me.btnCloseEmployee.Name = "btnCloseEmployee"
        Me.btnCloseEmployee.Size = New System.Drawing.Size(171, 55)
        Me.btnCloseEmployee.TabIndex = 0
        Me.btnCloseEmployee.Text = "CLOSE"
        Me.btnCloseEmployee.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvMasterPRJ)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1391, 623)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Master Data: Project"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvMasterPRJ
        '
        Me.dgvMasterPRJ.AllowUserToAddRows = False
        Me.dgvMasterPRJ.AllowUserToDeleteRows = False
        Me.dgvMasterPRJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterPRJ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMasterPRJ.Location = New System.Drawing.Point(3, 75)
        Me.dgvMasterPRJ.Name = "dgvMasterPRJ"
        Me.dgvMasterPRJ.RowTemplate.Height = 24
        Me.dgvMasterPRJ.Size = New System.Drawing.Size(1385, 469)
        Me.dgvMasterPRJ.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.txtSearchPRJ)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1385, 72)
        Me.Panel3.TabIndex = 4
        '
        'txtSearchPRJ
        '
        Me.txtSearchPRJ.Location = New System.Drawing.Point(173, 18)
        Me.txtSearchPRJ.Name = "txtSearchPRJ"
        Me.txtSearchPRJ.Size = New System.Drawing.Size(433, 30)
        Me.txtSearchPRJ.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SEARCH EMPLOYEE:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnEMPtoPRJ)
        Me.Panel4.Controls.Add(Me.btnDelete)
        Me.Panel4.Controls.Add(Me.btnEdit)
        Me.Panel4.Controls.Add(Me.btnAdd)
        Me.Panel4.Controls.Add(Me.btnClosePRJ)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(3, 544)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1385, 76)
        Me.Panel4.TabIndex = 3
        '
        'btnEMPtoPRJ
        '
        Me.btnEMPtoPRJ.Location = New System.Drawing.Point(407, 10)
        Me.btnEMPtoPRJ.Name = "btnEMPtoPRJ"
        Me.btnEMPtoPRJ.Size = New System.Drawing.Size(251, 55)
        Me.btnEMPtoPRJ.TabIndex = 4
        Me.btnEMPtoPRJ.Text = "Assign Employee to This Project"
        Me.btnEMPtoPRJ.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(273, 10)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 55)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(139, 10)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(128, 55)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(5, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 55)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClosePRJ
        '
        Me.btnClosePRJ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClosePRJ.Location = New System.Drawing.Point(1209, 10)
        Me.btnClosePRJ.Name = "btnClosePRJ"
        Me.btnClosePRJ.Size = New System.Drawing.Size(171, 55)
        Me.btnClosePRJ.TabIndex = 0
        Me.btnClosePRJ.Text = "CLOSE"
        Me.btnClosePRJ.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvSC)
        Me.TabPage3.Controls.Add(Me.Panel5)
        Me.TabPage3.Controls.Add(Me.Panel6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 31)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1391, 623)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Master Data: Subcon"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvSC
        '
        Me.dgvSC.AllowUserToAddRows = False
        Me.dgvSC.AllowUserToDeleteRows = False
        Me.dgvSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSC.Location = New System.Drawing.Point(3, 75)
        Me.dgvSC.Name = "dgvSC"
        Me.dgvSC.RowTemplate.Height = 24
        Me.dgvSC.Size = New System.Drawing.Size(1385, 469)
        Me.dgvSC.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.txtSearchSC)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1385, 72)
        Me.Panel5.TabIndex = 7
        '
        'txtSearchSC
        '
        Me.txtSearchSC.Location = New System.Drawing.Point(173, 18)
        Me.txtSearchSC.Name = "txtSearchSC"
        Me.txtSearchSC.Size = New System.Drawing.Size(433, 30)
        Me.txtSearchSC.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SEARCH EMPLOYEE:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnDelSC)
        Me.Panel6.Controls.Add(Me.btnEditSC)
        Me.Panel6.Controls.Add(Me.btnAddSC)
        Me.Panel6.Controls.Add(Me.Button6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 544)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1385, 76)
        Me.Panel6.TabIndex = 6
        '
        'btnDelSC
        '
        Me.btnDelSC.Location = New System.Drawing.Point(273, 10)
        Me.btnDelSC.Name = "btnDelSC"
        Me.btnDelSC.Size = New System.Drawing.Size(128, 55)
        Me.btnDelSC.TabIndex = 3
        Me.btnDelSC.Text = "DELETE"
        Me.btnDelSC.UseVisualStyleBackColor = True
        '
        'btnEditSC
        '
        Me.btnEditSC.Location = New System.Drawing.Point(139, 10)
        Me.btnEditSC.Name = "btnEditSC"
        Me.btnEditSC.Size = New System.Drawing.Size(128, 55)
        Me.btnEditSC.TabIndex = 2
        Me.btnEditSC.Text = "EDIT"
        Me.btnEditSC.UseVisualStyleBackColor = True
        '
        'btnAddSC
        '
        Me.btnAddSC.Location = New System.Drawing.Point(5, 10)
        Me.btnAddSC.Name = "btnAddSC"
        Me.btnAddSC.Size = New System.Drawing.Size(128, 55)
        Me.btnAddSC.TabIndex = 1
        Me.btnAddSC.Text = "ADD"
        Me.btnAddSC.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(1209, 10)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(171, 55)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "CLOSE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvUserLogin)
        Me.TabPage4.Controls.Add(Me.Panel7)
        Me.TabPage4.Controls.Add(Me.Panel8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 31)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1391, 623)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Master Data: User Login Data"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvUserLogin
        '
        Me.dgvUserLogin.AllowUserToAddRows = False
        Me.dgvUserLogin.AllowUserToDeleteRows = False
        Me.dgvUserLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserLogin.Location = New System.Drawing.Point(3, 75)
        Me.dgvUserLogin.Name = "dgvUserLogin"
        Me.dgvUserLogin.RowTemplate.Height = 24
        Me.dgvUserLogin.Size = New System.Drawing.Size(1385, 469)
        Me.dgvUserLogin.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1385, 72)
        Me.Panel7.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(173, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(433, 30)
        Me.TextBox1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Search User Here"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnDelLogin)
        Me.Panel8.Controls.Add(Me.btnEditLogin)
        Me.Panel8.Controls.Add(Me.btnAddUserLogin)
        Me.Panel8.Controls.Add(Me.btnCloseLogin)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(3, 544)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1385, 76)
        Me.Panel8.TabIndex = 3
        '
        'btnDelLogin
        '
        Me.btnDelLogin.Location = New System.Drawing.Point(275, 10)
        Me.btnDelLogin.Name = "btnDelLogin"
        Me.btnDelLogin.Size = New System.Drawing.Size(128, 55)
        Me.btnDelLogin.TabIndex = 6
        Me.btnDelLogin.Text = "DELETE"
        Me.btnDelLogin.UseVisualStyleBackColor = True
        '
        'btnEditLogin
        '
        Me.btnEditLogin.Location = New System.Drawing.Point(141, 10)
        Me.btnEditLogin.Name = "btnEditLogin"
        Me.btnEditLogin.Size = New System.Drawing.Size(128, 55)
        Me.btnEditLogin.TabIndex = 5
        Me.btnEditLogin.Text = "EDIT"
        Me.btnEditLogin.UseVisualStyleBackColor = True
        '
        'btnAddUserLogin
        '
        Me.btnAddUserLogin.Location = New System.Drawing.Point(7, 10)
        Me.btnAddUserLogin.Name = "btnAddUserLogin"
        Me.btnAddUserLogin.Size = New System.Drawing.Size(128, 55)
        Me.btnAddUserLogin.TabIndex = 4
        Me.btnAddUserLogin.Text = "ADD"
        Me.btnAddUserLogin.UseVisualStyleBackColor = True
        '
        'btnCloseLogin
        '
        Me.btnCloseLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseLogin.Location = New System.Drawing.Point(1209, 10)
        Me.btnCloseLogin.Name = "btnCloseLogin"
        Me.btnCloseLogin.Size = New System.Drawing.Size(171, 55)
        Me.btnCloseLogin.TabIndex = 0
        Me.btnCloseLogin.Text = "CLOSE"
        Me.btnCloseLogin.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgvUserGroup)
        Me.TabPage5.Controls.Add(Me.Panel9)
        Me.TabPage5.Controls.Add(Me.Panel10)
        Me.TabPage5.Location = New System.Drawing.Point(4, 31)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1391, 623)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Master Data: User Group"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgvUserGroup
        '
        Me.dgvUserGroup.AllowUserToAddRows = False
        Me.dgvUserGroup.AllowUserToDeleteRows = False
        Me.dgvUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserGroup.Location = New System.Drawing.Point(3, 75)
        Me.dgvUserGroup.Name = "dgvUserGroup"
        Me.dgvUserGroup.RowTemplate.Height = 24
        Me.dgvUserGroup.Size = New System.Drawing.Size(1385, 469)
        Me.dgvUserGroup.TabIndex = 8
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.TextBox2)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1385, 72)
        Me.Panel9.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(173, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(433, 30)
        Me.TextBox2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Search User Here"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Button1)
        Me.Panel10.Controls.Add(Me.btnEditUG)
        Me.Panel10.Controls.Add(Me.frmAddGroup)
        Me.Panel10.Controls.Add(Me.btnCloseUG)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(3, 544)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1385, 76)
        Me.Panel10.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(275, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 55)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "DELETE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEditUG
        '
        Me.btnEditUG.Location = New System.Drawing.Point(141, 10)
        Me.btnEditUG.Name = "btnEditUG"
        Me.btnEditUG.Size = New System.Drawing.Size(128, 55)
        Me.btnEditUG.TabIndex = 5
        Me.btnEditUG.Text = "EDIT"
        Me.btnEditUG.UseVisualStyleBackColor = True
        '
        'frmAddGroup
        '
        Me.frmAddGroup.Location = New System.Drawing.Point(7, 10)
        Me.frmAddGroup.Name = "frmAddGroup"
        Me.frmAddGroup.Size = New System.Drawing.Size(128, 55)
        Me.frmAddGroup.TabIndex = 4
        Me.frmAddGroup.Text = "ADD"
        Me.frmAddGroup.UseVisualStyleBackColor = True
        '
        'btnCloseUG
        '
        Me.btnCloseUG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseUG.Location = New System.Drawing.Point(1209, 10)
        Me.btnCloseUG.Name = "btnCloseUG"
        Me.btnCloseUG.Size = New System.Drawing.Size(171, 55)
        Me.btnCloseUG.TabIndex = 0
        Me.btnCloseUG.Text = "CLOSE"
        Me.btnCloseUG.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(427, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "By Subcon"
        '
        'cbbBySubcon
        '
        Me.cbbBySubcon.FormattingEnabled = True
        Me.cbbBySubcon.Location = New System.Drawing.Point(523, 17)
        Me.cbbBySubcon.Name = "cbbBySubcon"
        Me.cbbBySubcon.Size = New System.Drawing.Size(182, 30)
        Me.cbbBySubcon.TabIndex = 3
        '
        'frmMasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 658)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMasterData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMasterData"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvMasterEMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvMasterPRJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvSC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvUserLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgvUserGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCloseEmployee As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvMasterEMP As DataGridView
    Friend WithEvents dgvMasterPRJ As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClosePRJ As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEMPtoPRJ As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvSC As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnDelSC As Button
    Friend WithEvents btnEditSC As Button
    Friend WithEvents btnAddSC As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtSearchEMP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchPRJ As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchSC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvUserLogin As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnCloseLogin As Button
    Friend WithEvents btnDelLogin As Button
    Friend WithEvents btnEditLogin As Button
    Friend WithEvents btnAddUserLogin As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents dgvUserGroup As DataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEditUG As Button
    Friend WithEvents frmAddGroup As Button
    Friend WithEvents btnCloseUG As Button
    Friend WithEvents cbbBySubcon As ComboBox
    Friend WithEvents Label6 As Label
End Class
