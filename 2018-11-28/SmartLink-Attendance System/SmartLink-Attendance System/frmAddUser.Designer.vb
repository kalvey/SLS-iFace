<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUser))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.cbbPrivilege = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbWorkHours = New System.Windows.Forms.ComboBox()
        Me.txtType2 = New System.Windows.Forms.TextBox()
        Me.txtType1 = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbbUserGroup = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbbEmployeeType = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnSubCon = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtKTP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbbDepart = New System.Windows.Forms.ComboBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage2.SuspendLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'dtpTo
        '
        Me.dtpTo.CalendarFont = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpTo.CustomFormat = "dd-MM-yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(164, 145)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(282, 32)
        Me.dtpTo.TabIndex = 20
        '
        'dtpFrom
        '
        Me.dtpFrom.CalendarFont = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpFrom.CustomFormat = "dd-MM-yyyy"
        Me.dtpFrom.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(164, 85)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(282, 32)
        Me.dtpFrom.TabIndex = 19
        '
        'cbbPrivilege
        '
        Me.cbbPrivilege.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbPrivilege.FormattingEnabled = True
        Me.cbbPrivilege.Items.AddRange(New Object() {"Normal User", "Super Admin"})
        Me.cbbPrivilege.Location = New System.Drawing.Point(164, 209)
        Me.cbbPrivilege.Name = "cbbPrivilege"
        Me.cbbPrivilege.Size = New System.Drawing.Size(282, 30)
        Me.cbbPrivilege.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(25, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Valid To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(25, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Valid From"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtCardNumber.Location = New System.Drawing.Point(164, 37)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(282, 30)
        Me.txtCardNumber.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(25, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Card Number"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtpTo)
        Me.TabPage2.Controls.Add(Me.dtpFrom)
        Me.TabPage2.Controls.Add(Me.cbbPrivilege)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtCardNumber)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1435, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User Card Management"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(25, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Privilege"
        '
        'cbbWorkHours
        '
        Me.cbbWorkHours.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbWorkHours.FormattingEnabled = True
        Me.cbbWorkHours.Items.AddRange(New Object() {"SHIFT", "NORMAL"})
        Me.cbbWorkHours.Location = New System.Drawing.Point(163, 469)
        Me.cbbWorkHours.Name = "cbbWorkHours"
        Me.cbbWorkHours.Size = New System.Drawing.Size(282, 30)
        Me.cbbWorkHours.TabIndex = 49
        Me.cbbWorkHours.Visible = False
        '
        'txtType2
        '
        Me.txtType2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtType2.Location = New System.Drawing.Point(163, 331)
        Me.txtType2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtType2.MaxLength = 1000
        Me.txtType2.Name = "txtType2"
        Me.txtType2.Size = New System.Drawing.Size(282, 30)
        Me.txtType2.TabIndex = 48
        Me.txtType2.Visible = False
        '
        'txtType1
        '
        Me.txtType1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtType1.Location = New System.Drawing.Point(163, 287)
        Me.txtType1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtType1.MaxLength = 1000
        Me.txtType1.Name = "txtType1"
        Me.txtType1.Size = New System.Drawing.Size(282, 30)
        Me.txtType1.TabIndex = 47
        Me.txtType1.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lbl3.Location = New System.Drawing.Point(24, 468)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(15, 23)
        Me.lbl3.TabIndex = 54
        Me.lbl3.Text = ":"
        Me.lbl3.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lbl2.Location = New System.Drawing.Point(24, 334)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(15, 23)
        Me.lbl2.TabIndex = 53
        Me.lbl2.Text = ":"
        Me.lbl2.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lbl1.Location = New System.Drawing.Point(24, 287)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(15, 23)
        Me.lbl1.TabIndex = 52
        Me.lbl1.Text = ":"
        Me.lbl1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(24, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 23)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Group"
        '
        'cbbUserGroup
        '
        Me.cbbUserGroup.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbUserGroup.FormattingEnabled = True
        Me.cbbUserGroup.Location = New System.Drawing.Point(163, 158)
        Me.cbbUserGroup.Name = "cbbUserGroup"
        Me.cbbUserGroup.Size = New System.Drawing.Size(282, 30)
        Me.cbbUserGroup.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(24, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 23)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Employee Type"
        '
        'cbbEmployeeType
        '
        Me.cbbEmployeeType.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbEmployeeType.FormattingEnabled = True
        Me.cbbEmployeeType.Items.AddRange(New Object() {"INTERNAL", "EXTERNAL"})
        Me.cbbEmployeeType.Location = New System.Drawing.Point(163, 243)
        Me.cbbEmployeeType.Name = "cbbEmployeeType"
        Me.cbbEmployeeType.Size = New System.Drawing.Size(282, 30)
        Me.cbbEmployeeType.TabIndex = 45
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtName.Location = New System.Drawing.Point(163, 115)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(282, 30)
        Me.txtName.TabIndex = 7
        '
        'txtUserId
        '
        Me.txtUserId.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtUserId.Location = New System.Drawing.Point(163, 32)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(282, 30)
        Me.txtUserId.TabIndex = 6
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(1162, 183)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(136, 36)
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Text = "Browse Picture"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'pbUser
        '
        Me.pbUser.BackgroundImage = CType(resources.GetObject("pbUser.BackgroundImage"), System.Drawing.Image)
        Me.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUser.Location = New System.Drawing.Point(1162, 35)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(136, 140)
        Me.pbUser.TabIndex = 4
        Me.pbUser.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User Id"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnSubCon)
        Me.TabPage1.Controls.Add(Me.txtPosition)
        Me.TabPage1.Controls.Add(Me.lblPosition)
        Me.TabPage1.Controls.Add(Me.txtSection)
        Me.TabPage1.Controls.Add(Me.lblSection)
        Me.TabPage1.Controls.Add(Me.txtEmpNo)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtAddr)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtTelp)
        Me.TabPage1.Controls.Add(Me.txtKTP)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.cbbDepart)
        Me.TabPage1.Controls.Add(Me.dtpEndDate)
        Me.TabPage1.Controls.Add(Me.dtpStartDate)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtPassword)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cbbWorkHours)
        Me.TabPage1.Controls.Add(Me.txtType2)
        Me.TabPage1.Controls.Add(Me.txtType1)
        Me.TabPage1.Controls.Add(Me.lbl3)
        Me.TabPage1.Controls.Add(Me.lbl2)
        Me.TabPage1.Controls.Add(Me.lbl1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cbbUserGroup)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cbbEmployeeType)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.txtUserId)
        Me.TabPage1.Controls.Add(Me.btnBrowse)
        Me.TabPage1.Controls.Add(Me.pbUser)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1435, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSubCon
        '
        Me.btnSubCon.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSubCon.FlatAppearance.BorderSize = 0
        Me.btnSubCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubCon.ForeColor = System.Drawing.Color.White
        Me.btnSubCon.Location = New System.Drawing.Point(451, 287)
        Me.btnSubCon.Name = "btnSubCon"
        Me.btnSubCon.Size = New System.Drawing.Size(75, 30)
        Me.btnSubCon.TabIndex = 84
        Me.btnSubCon.Text = "Subcon"
        Me.btnSubCon.UseVisualStyleBackColor = False
        Me.btnSubCon.Visible = False
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtPosition.Location = New System.Drawing.Point(163, 421)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPosition.MaxLength = 1000
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(282, 30)
        Me.txtPosition.TabIndex = 82
        Me.txtPosition.Visible = False
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblPosition.Location = New System.Drawing.Point(24, 421)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(15, 23)
        Me.lblPosition.TabIndex = 83
        Me.lblPosition.Text = ":"
        Me.lblPosition.Visible = False
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSection.Location = New System.Drawing.Point(163, 373)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSection.MaxLength = 1000
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(282, 30)
        Me.txtSection.TabIndex = 80
        Me.txtSection.Visible = False
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblSection.Location = New System.Drawing.Point(24, 373)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(15, 23)
        Me.lblSection.TabIndex = 81
        Me.lblSection.Text = ":"
        Me.lblSection.Visible = False
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtEmpNo.Location = New System.Drawing.Point(163, 74)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(282, 30)
        Me.txtEmpNo.TabIndex = 71
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(24, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 23)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Employee No"
        '
        'txtAddr
        '
        Me.txtAddr.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtAddr.Location = New System.Drawing.Point(627, 132)
        Me.txtAddr.Multiline = True
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(467, 200)
        Me.txtAddr.TabIndex = 69
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label15.Location = New System.Drawing.Point(492, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 23)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Address"
        '
        'txtTelp
        '
        Me.txtTelp.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtTelp.Location = New System.Drawing.Point(627, 84)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(282, 30)
        Me.txtTelp.TabIndex = 67
        '
        'txtKTP
        '
        Me.txtKTP.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtKTP.Location = New System.Drawing.Point(627, 32)
        Me.txtKTP.Name = "txtKTP"
        Me.txtKTP.Size = New System.Drawing.Size(282, 30)
        Me.txtKTP.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(488, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 23)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Telephone No"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label14.Location = New System.Drawing.Point(488, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 23)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Identity No"
        '
        'cbbDepart
        '
        Me.cbbDepart.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbDepart.FormattingEnabled = True
        Me.cbbDepart.Location = New System.Drawing.Point(163, 331)
        Me.cbbDepart.Name = "cbbDepart"
        Me.cbbDepart.Size = New System.Drawing.Size(282, 30)
        Me.cbbDepart.TabIndex = 63
        Me.cbbDepart.Visible = False
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CalendarFont = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpEndDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpEndDate.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(837, 394)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(153, 32)
        Me.dtpEndDate.TabIndex = 62
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CalendarFont = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpStartDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(627, 394)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(153, 32)
        Me.dtpStartDate.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(833, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 23)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Contract End Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label12.Location = New System.Drawing.Point(623, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 23)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Contract Start Date"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtPassword.Location = New System.Drawing.Point(163, 203)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(282, 30)
        Me.txtPassword.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(24, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 23)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Password"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 62)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1443, 564)
        Me.TabControl1.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnCancel.Location = New System.Drawing.Point(1340, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 38)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnSave.Location = New System.Drawing.Point(1235, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 38)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 626)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1443, 48)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1443, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1443, 62)
        Me.Panel1.TabIndex = 5
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 674)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddUser"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cbbWorkHours As ComboBox
    Friend WithEvents txtType2 As TextBox
    Friend WithEvents txtType1 As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbbUserGroup As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbbEmployeeType As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents cbbPrivilege As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cbbDepart As ComboBox
    Friend WithEvents txtAddr As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtKTP As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEmpNo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents lblSection As Label
    Friend WithEvents btnSubCon As Button
End Class
