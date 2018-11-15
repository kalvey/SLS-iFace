<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbbDevice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGetLogs = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvReport = New ns1.BunifuCustomDataGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblKeseluruhan = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbbEmpType = New System.Windows.Forms.ComboBox()
        Me.cbbSubcon = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbbDevName = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSearchDate = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtInOut = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPersonellID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnCloseAtt = New System.Windows.Forms.Button()
        Me.btnExporttoExcel = New System.Windows.Forms.Button()
        Me.dgvHidden = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtSearchEMP = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbbDepart = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpAtt = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.dgvLate = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLateUser = New System.Windows.Forms.DataGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnCloseLate = New System.Windows.Forms.Button()
        Me.btnLateExcel = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtLateEMPname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbbLateDPT = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpLateAtt = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGetLate = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.dgvExit = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvExitUser = New System.Windows.Forms.DataGridView()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnCloseEP = New System.Windows.Forms.Button()
        Me.btnExportEXIT = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cbDeptExit = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpExit = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGetExit = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.dgvGetOT = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btnCloseOT = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.txtOTname = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbbDeptOT = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpOT = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnGetOT = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvSubProject = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.btnSP = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpSubProject = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSubProject = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgvSpS = New System.Windows.Forms.DataGridView()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpSpS = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSpS = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.dgvHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.dgvLate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLateUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.dgvExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExitUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.dgvGetOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvSpS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1849, 47)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.Controls.Add(Me.cbbDevice)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btnGetLogs)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtIP)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1849, 47)
        Me.Panel4.TabIndex = 7
        '
        'cbbDevice
        '
        Me.cbbDevice.FormattingEnabled = True
        Me.cbbDevice.Location = New System.Drawing.Point(90, 9)
        Me.cbbDevice.Name = "cbbDevice"
        Me.cbbDevice.Size = New System.Drawing.Size(121, 24)
        Me.cbbDevice.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Device"
        '
        'btnGetLogs
        '
        Me.btnGetLogs.Location = New System.Drawing.Point(479, 9)
        Me.btnGetLogs.Name = "btnGetLogs"
        Me.btnGetLogs.Size = New System.Drawing.Size(94, 24)
        Me.btnGetLogs.TabIndex = 4
        Me.btnGetLogs.Text = "Find Report"
        Me.btnGetLogs.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(239, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IP Address"
        '
        'txtIP
        '
        Me.txtIP.Enabled = False
        Me.txtIP.Location = New System.Drawing.Point(351, 10)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(121, 22)
        Me.txtIP.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 47)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1849, 938)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1841, 909)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Attendance Activity"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvReport)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1835, 727)
        Me.Panel3.TabIndex = 5
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReport.DoubleBuffered = True
        Me.dgvReport.EnableHeadersVisualStyles = False
        Me.dgvReport.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.dgvReport.HeaderForeColor = System.Drawing.Color.White
        Me.dgvReport.Location = New System.Drawing.Point(0, 0)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(1835, 727)
        Me.dgvReport.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblKeseluruhan)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 867)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1835, 39)
        Me.Panel2.TabIndex = 4
        '
        'lblKeseluruhan
        '
        Me.lblKeseluruhan.AutoSize = True
        Me.lblKeseluruhan.Location = New System.Drawing.Point(61, 12)
        Me.lblKeseluruhan.Name = "lblKeseluruhan"
        Me.lblKeseluruhan.Size = New System.Drawing.Size(59, 17)
        Me.lblKeseluruhan.TabIndex = 13
        Me.lblKeseluruhan.Text = "Label16"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(1781, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(41, 36)
        Me.btnClose.TabIndex = 12
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.cbbEmpType)
        Me.Panel5.Controls.Add(Me.cbbSubcon)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.cbbDevName)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.btnSearchDate)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.dtpTo)
        Me.Panel5.Controls.Add(Me.dtpFrom)
        Me.Panel5.Controls.Add(Me.btnClear)
        Me.Panel5.Controls.Add(Me.btnExport)
        Me.Panel5.Controls.Add(Me.btnSearch)
        Me.Panel5.Controls.Add(Me.txtInOut)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txtPersonellID)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1835, 137)
        Me.Panel5.TabIndex = 3
        '
        'cbbEmpType
        '
        Me.cbbEmpType.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbEmpType.FormattingEnabled = True
        Me.cbbEmpType.Items.AddRange(New Object() {"INTERNAL", "EXTERNAL"})
        Me.cbbEmpType.Location = New System.Drawing.Point(342, 67)
        Me.cbbEmpType.Name = "cbbEmpType"
        Me.cbbEmpType.Size = New System.Drawing.Size(198, 30)
        Me.cbbEmpType.TabIndex = 28
        '
        'cbbSubcon
        '
        Me.cbbSubcon.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbSubcon.FormattingEnabled = True
        Me.cbbSubcon.Items.AddRange(New Object() {"Check In", "Check Out", "Break Out", "Break In", "Overtime In", "Overtime Out"})
        Me.cbbSubcon.Location = New System.Drawing.Point(593, 67)
        Me.cbbSubcon.Name = "cbbSubcon"
        Me.cbbSubcon.Size = New System.Drawing.Size(198, 30)
        Me.cbbSubcon.TabIndex = 26
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label23.Location = New System.Drawing.Point(375, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(125, 23)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Employee Type"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label22.Location = New System.Drawing.Point(649, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 23)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Subcon"
        '
        'cbbDevName
        '
        Me.cbbDevName.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbDevName.FormattingEnabled = True
        Me.cbbDevName.Location = New System.Drawing.Point(1327, 67)
        Me.cbbDevName.Name = "cbbDevName"
        Me.cbbDevName.Size = New System.Drawing.Size(198, 30)
        Me.cbbDevName.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(1365, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 23)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Device Name"
        '
        'btnSearchDate
        '
        Me.btnSearchDate.Location = New System.Drawing.Point(223, 95)
        Me.btnSearchDate.Name = "btnSearchDate"
        Me.btnSearchDate.Size = New System.Drawing.Size(75, 32)
        Me.btnSearchDate.TabIndex = 22
        Me.btnSearchDate.Text = "Search"
        Me.btnSearchDate.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label15.Location = New System.Drawing.Point(92, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 23)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Filter by Date"
        '
        'dtpTo
        '
        Me.dtpTo.CalendarFont = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpTo.CustomFormat = "yyyy-MM-dd"
        Me.dtpTo.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(178, 59)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(120, 30)
        Me.dtpTo.TabIndex = 20
        '
        'dtpFrom
        '
        Me.dtpFrom.CalendarFont = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFrom.CustomFormat = "yyyy-MM-dd"
        Me.dtpFrom.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(11, 59)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(120, 30)
        Me.dtpFrom.TabIndex = 19
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnClear.Location = New System.Drawing.Point(1697, 93)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 33)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnExport.Location = New System.Drawing.Point(1697, 54)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(107, 33)
        Me.btnExport.TabIndex = 17
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnSearch.Location = New System.Drawing.Point(1697, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(107, 33)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtInOut
        '
        Me.txtInOut.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtInOut.FormattingEnabled = True
        Me.txtInOut.Items.AddRange(New Object() {"Check In", "Check Out", "Break Out", "Break In", "Overtime In", "Overtime Out"})
        Me.txtInOut.Location = New System.Drawing.Point(1082, 67)
        Me.txtInOut.Name = "txtInOut"
        Me.txtInOut.Size = New System.Drawing.Size(198, 30)
        Me.txtInOut.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(1120, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "In/Out Status"
        '
        'txtPersonellID
        '
        Me.txtPersonellID.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtPersonellID.Location = New System.Drawing.Point(840, 67)
        Me.txtPersonellID.Name = "txtPersonellID"
        Me.txtPersonellID.Size = New System.Drawing.Size(196, 30)
        Me.txtPersonellID.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(848, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Personnel ID or Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1841, 909)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Employee Attendance"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.dgvEmployee)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.dgvHidden)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 61)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1835, 845)
        Me.Panel7.TabIndex = 3
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6})
        Me.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmployee.Location = New System.Drawing.Point(0, 0)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.ReadOnly = True
        Me.dgvEmployee.RowHeadersVisible = False
        Me.dgvEmployee.RowTemplate.Height = 24
        Me.dgvEmployee.Size = New System.Drawing.Size(1835, 790)
        Me.dgvEmployee.TabIndex = 7
        '
        'Column6
        '
        Me.Column6.HeaderText = "No"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnCloseAtt)
        Me.Panel8.Controls.Add(Me.btnExporttoExcel)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 790)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1835, 55)
        Me.Panel8.TabIndex = 6
        '
        'btnCloseAtt
        '
        Me.btnCloseAtt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseAtt.BackgroundImage = CType(resources.GetObject("btnCloseAtt.BackgroundImage"), System.Drawing.Image)
        Me.btnCloseAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCloseAtt.Location = New System.Drawing.Point(1788, 8)
        Me.btnCloseAtt.Name = "btnCloseAtt"
        Me.btnCloseAtt.Size = New System.Drawing.Size(41, 36)
        Me.btnCloseAtt.TabIndex = 13
        Me.btnCloseAtt.UseVisualStyleBackColor = True
        '
        'btnExporttoExcel
        '
        Me.btnExporttoExcel.Location = New System.Drawing.Point(9, 3)
        Me.btnExporttoExcel.Name = "btnExporttoExcel"
        Me.btnExporttoExcel.Size = New System.Drawing.Size(140, 47)
        Me.btnExporttoExcel.TabIndex = 0
        Me.btnExporttoExcel.Text = "Generate Report to Excel"
        Me.btnExporttoExcel.UseVisualStyleBackColor = True
        '
        'dgvHidden
        '
        Me.dgvHidden.AllowUserToAddRows = False
        Me.dgvHidden.AllowUserToDeleteRows = False
        Me.dgvHidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHidden.Location = New System.Drawing.Point(704, 60)
        Me.dgvHidden.Name = "dgvHidden"
        Me.dgvHidden.ReadOnly = True
        Me.dgvHidden.RowTemplate.Height = 24
        Me.dgvHidden.Size = New System.Drawing.Size(662, 150)
        Me.dgvHidden.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtSearchEMP)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.cbbDepart)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.dtpAtt)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.btnAttendance)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1835, 58)
        Me.Panel6.TabIndex = 2
        '
        'txtSearchEMP
        '
        Me.txtSearchEMP.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtSearchEMP.Location = New System.Drawing.Point(777, 14)
        Me.txtSearchEMP.Name = "txtSearchEMP"
        Me.txtSearchEMP.Size = New System.Drawing.Size(168, 30)
        Me.txtSearchEMP.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label18.Location = New System.Drawing.Point(617, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 23)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Employee Name"
        '
        'cbbDepart
        '
        Me.cbbDepart.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbDepart.FormattingEnabled = True
        Me.cbbDepart.Location = New System.Drawing.Point(421, 16)
        Me.cbbDepart.Name = "cbbDepart"
        Me.cbbDepart.Size = New System.Drawing.Size(174, 30)
        Me.cbbDepart.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(299, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DEPARTMENT"
        '
        'dtpAtt
        '
        Me.dtpAtt.CustomFormat = "MM/yyyy"
        Me.dtpAtt.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpAtt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAtt.Location = New System.Drawing.Point(154, 16)
        Me.dtpAtt.Name = "dtpAtt"
        Me.dtpAtt.Size = New System.Drawing.Size(122, 30)
        Me.dtpAtt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SELECT MONTH"
        '
        'btnAttendance
        '
        Me.btnAttendance.Location = New System.Drawing.Point(974, 13)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(112, 30)
        Me.btnAttendance.TabIndex = 0
        Me.btnAttendance.Text = "GET REPORT"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel11)
        Me.TabPage3.Controls.Add(Me.Panel10)
        Me.TabPage3.Controls.Add(Me.Panel9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1841, 909)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Employee Late"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.dgvLate)
        Me.Panel11.Controls.Add(Me.dgvLateUser)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(3, 61)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1835, 790)
        Me.Panel11.TabIndex = 7
        '
        'dgvLate
        '
        Me.dgvLate.AllowUserToAddRows = False
        Me.dgvLate.AllowUserToDeleteRows = False
        Me.dgvLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLate.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLate.Location = New System.Drawing.Point(0, 0)
        Me.dgvLate.Name = "dgvLate"
        Me.dgvLate.ReadOnly = True
        Me.dgvLate.RowHeadersVisible = False
        Me.dgvLate.RowTemplate.Height = 24
        Me.dgvLate.Size = New System.Drawing.Size(1835, 790)
        Me.dgvLate.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.HeaderText = "No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'dgvLateUser
        '
        Me.dgvLateUser.AllowUserToAddRows = False
        Me.dgvLateUser.AllowUserToDeleteRows = False
        Me.dgvLateUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLateUser.Location = New System.Drawing.Point(704, 60)
        Me.dgvLateUser.Name = "dgvLateUser"
        Me.dgvLateUser.ReadOnly = True
        Me.dgvLateUser.RowTemplate.Height = 24
        Me.dgvLateUser.Size = New System.Drawing.Size(240, 150)
        Me.dgvLateUser.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnCloseLate)
        Me.Panel10.Controls.Add(Me.btnLateExcel)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(3, 851)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1835, 55)
        Me.Panel10.TabIndex = 6
        '
        'btnCloseLate
        '
        Me.btnCloseLate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseLate.BackgroundImage = CType(resources.GetObject("btnCloseLate.BackgroundImage"), System.Drawing.Image)
        Me.btnCloseLate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCloseLate.Location = New System.Drawing.Point(1788, 8)
        Me.btnCloseLate.Name = "btnCloseLate"
        Me.btnCloseLate.Size = New System.Drawing.Size(41, 36)
        Me.btnCloseLate.TabIndex = 13
        Me.btnCloseLate.UseVisualStyleBackColor = True
        '
        'btnLateExcel
        '
        Me.btnLateExcel.Location = New System.Drawing.Point(9, 3)
        Me.btnLateExcel.Name = "btnLateExcel"
        Me.btnLateExcel.Size = New System.Drawing.Size(140, 47)
        Me.btnLateExcel.TabIndex = 0
        Me.btnLateExcel.Text = "Generate Report to Excel"
        Me.btnLateExcel.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.txtLateEMPname)
        Me.Panel9.Controls.Add(Me.Label17)
        Me.Panel9.Controls.Add(Me.cbbLateDPT)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.dtpLateAtt)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Controls.Add(Me.btnGetLate)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1835, 58)
        Me.Panel9.TabIndex = 3
        '
        'txtLateEMPname
        '
        Me.txtLateEMPname.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtLateEMPname.Location = New System.Drawing.Point(757, 16)
        Me.txtLateEMPname.Name = "txtLateEMPname"
        Me.txtLateEMPname.Size = New System.Drawing.Size(168, 30)
        Me.txtLateEMPname.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label17.Location = New System.Drawing.Point(617, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 23)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Employee Name"
        '
        'cbbLateDPT
        '
        Me.cbbLateDPT.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbLateDPT.FormattingEnabled = True
        Me.cbbLateDPT.Location = New System.Drawing.Point(421, 16)
        Me.cbbLateDPT.Name = "cbbLateDPT"
        Me.cbbLateDPT.Size = New System.Drawing.Size(174, 30)
        Me.cbbLateDPT.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(299, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "DEPARTMENT"
        '
        'dtpLateAtt
        '
        Me.dtpLateAtt.CustomFormat = "MM/yyyy"
        Me.dtpLateAtt.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpLateAtt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLateAtt.Location = New System.Drawing.Point(154, 16)
        Me.dtpLateAtt.Name = "dtpLateAtt"
        Me.dtpLateAtt.Size = New System.Drawing.Size(122, 30)
        Me.dtpLateAtt.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(18, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "SELECT MONTH"
        '
        'btnGetLate
        '
        Me.btnGetLate.Location = New System.Drawing.Point(946, 16)
        Me.btnGetLate.Name = "btnGetLate"
        Me.btnGetLate.Size = New System.Drawing.Size(112, 30)
        Me.btnGetLate.TabIndex = 0
        Me.btnGetLate.Text = "GET REPORT"
        Me.btnGetLate.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel14)
        Me.TabPage4.Controls.Add(Me.Panel13)
        Me.TabPage4.Controls.Add(Me.Panel12)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1841, 909)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Employee Exit Permit"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.dgvExit)
        Me.Panel14.Controls.Add(Me.dgvExitUser)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 58)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1841, 796)
        Me.Panel14.TabIndex = 8
        '
        'dgvExit
        '
        Me.dgvExit.AllowUserToAddRows = False
        Me.dgvExit.AllowUserToDeleteRows = False
        Me.dgvExit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9})
        Me.dgvExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExit.Location = New System.Drawing.Point(0, 0)
        Me.dgvExit.Name = "dgvExit"
        Me.dgvExit.ReadOnly = True
        Me.dgvExit.RowHeadersVisible = False
        Me.dgvExit.RowTemplate.Height = 24
        Me.dgvExit.Size = New System.Drawing.Size(1841, 796)
        Me.dgvExit.TabIndex = 0
        '
        'Column9
        '
        Me.Column9.HeaderText = "No"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'dgvExitUser
        '
        Me.dgvExitUser.AllowUserToAddRows = False
        Me.dgvExitUser.AllowUserToDeleteRows = False
        Me.dgvExitUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExitUser.Location = New System.Drawing.Point(704, 60)
        Me.dgvExitUser.Name = "dgvExitUser"
        Me.dgvExitUser.ReadOnly = True
        Me.dgvExitUser.RowTemplate.Height = 24
        Me.dgvExitUser.Size = New System.Drawing.Size(551, 150)
        Me.dgvExitUser.TabIndex = 1
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.btnCloseEP)
        Me.Panel13.Controls.Add(Me.btnExportEXIT)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(0, 854)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1841, 55)
        Me.Panel13.TabIndex = 7
        '
        'btnCloseEP
        '
        Me.btnCloseEP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseEP.BackgroundImage = CType(resources.GetObject("btnCloseEP.BackgroundImage"), System.Drawing.Image)
        Me.btnCloseEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCloseEP.Location = New System.Drawing.Point(1791, 8)
        Me.btnCloseEP.Name = "btnCloseEP"
        Me.btnCloseEP.Size = New System.Drawing.Size(41, 36)
        Me.btnCloseEP.TabIndex = 13
        Me.btnCloseEP.UseVisualStyleBackColor = True
        '
        'btnExportEXIT
        '
        Me.btnExportEXIT.Location = New System.Drawing.Point(9, 3)
        Me.btnExportEXIT.Name = "btnExportEXIT"
        Me.btnExportEXIT.Size = New System.Drawing.Size(140, 47)
        Me.btnExportEXIT.TabIndex = 0
        Me.btnExportEXIT.Text = "Generate Report to Excel"
        Me.btnExportEXIT.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.cbDeptExit)
        Me.Panel12.Controls.Add(Me.Label9)
        Me.Panel12.Controls.Add(Me.dtpExit)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Controls.Add(Me.btnGetExit)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1841, 58)
        Me.Panel12.TabIndex = 4
        '
        'cbDeptExit
        '
        Me.cbDeptExit.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbDeptExit.FormattingEnabled = True
        Me.cbDeptExit.Location = New System.Drawing.Point(421, 16)
        Me.cbDeptExit.Name = "cbDeptExit"
        Me.cbDeptExit.Size = New System.Drawing.Size(174, 30)
        Me.cbDeptExit.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(299, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "DEPARTMENT"
        '
        'dtpExit
        '
        Me.dtpExit.CustomFormat = "MM/yyyy"
        Me.dtpExit.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpExit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExit.Location = New System.Drawing.Point(154, 16)
        Me.dtpExit.Name = "dtpExit"
        Me.dtpExit.Size = New System.Drawing.Size(122, 30)
        Me.dtpExit.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(18, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SELECT MONTH"
        '
        'btnGetExit
        '
        Me.btnGetExit.Location = New System.Drawing.Point(601, 16)
        Me.btnGetExit.Name = "btnGetExit"
        Me.btnGetExit.Size = New System.Drawing.Size(112, 30)
        Me.btnGetExit.TabIndex = 0
        Me.btnGetExit.Text = "GET REPORT"
        Me.btnGetExit.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.dgvGetOT)
        Me.TabPage7.Controls.Add(Me.Panel17)
        Me.TabPage7.Controls.Add(Me.Panel20)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1841, 909)
        Me.TabPage7.TabIndex = 7
        Me.TabPage7.Text = "Over Time "
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'dgvGetOT
        '
        Me.dgvGetOT.AllowUserToAddRows = False
        Me.dgvGetOT.AllowUserToDeleteRows = False
        Me.dgvGetOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGetOT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8})
        Me.dgvGetOT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGetOT.Location = New System.Drawing.Point(3, 61)
        Me.dgvGetOT.Name = "dgvGetOT"
        Me.dgvGetOT.ReadOnly = True
        Me.dgvGetOT.RowHeadersVisible = False
        Me.dgvGetOT.RowTemplate.Height = 24
        Me.dgvGetOT.Size = New System.Drawing.Size(1835, 790)
        Me.dgvGetOT.TabIndex = 11
        '
        'Column8
        '
        Me.Column8.HeaderText = "No"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.btnCloseOT)
        Me.Panel17.Controls.Add(Me.Button5)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(3, 851)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1835, 55)
        Me.Panel17.TabIndex = 10
        '
        'btnCloseOT
        '
        Me.btnCloseOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseOT.BackgroundImage = CType(resources.GetObject("btnCloseOT.BackgroundImage"), System.Drawing.Image)
        Me.btnCloseOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCloseOT.Location = New System.Drawing.Point(1785, 8)
        Me.btnCloseOT.Name = "btnCloseOT"
        Me.btnCloseOT.Size = New System.Drawing.Size(41, 36)
        Me.btnCloseOT.TabIndex = 13
        Me.btnCloseOT.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(9, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 47)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Generate Report to Excel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.txtOTname)
        Me.Panel20.Controls.Add(Me.Label21)
        Me.Panel20.Controls.Add(Me.cbbDeptOT)
        Me.Panel20.Controls.Add(Me.Label19)
        Me.Panel20.Controls.Add(Me.dtpOT)
        Me.Panel20.Controls.Add(Me.Label20)
        Me.Panel20.Controls.Add(Me.btnGetOT)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(3, 3)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1835, 58)
        Me.Panel20.TabIndex = 9
        '
        'txtOTname
        '
        Me.txtOTname.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.txtOTname.Location = New System.Drawing.Point(760, 16)
        Me.txtOTname.Name = "txtOTname"
        Me.txtOTname.Size = New System.Drawing.Size(168, 30)
        Me.txtOTname.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label21.Location = New System.Drawing.Point(620, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 23)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Employee Name"
        '
        'cbbDeptOT
        '
        Me.cbbDeptOT.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.cbbDeptOT.FormattingEnabled = True
        Me.cbbDeptOT.Location = New System.Drawing.Point(421, 16)
        Me.cbbDeptOT.Name = "cbbDeptOT"
        Me.cbbDeptOT.Size = New System.Drawing.Size(174, 30)
        Me.cbbDeptOT.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label19.Location = New System.Drawing.Point(299, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 23)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "DEPARTMENT"
        '
        'dtpOT
        '
        Me.dtpOT.CustomFormat = "MM/yyyy"
        Me.dtpOT.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpOT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOT.Location = New System.Drawing.Point(154, 16)
        Me.dtpOT.Name = "dtpOT"
        Me.dtpOT.Size = New System.Drawing.Size(122, 30)
        Me.dtpOT.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label20.Location = New System.Drawing.Point(18, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 23)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "SELECT MONTH"
        '
        'btnGetOT
        '
        Me.btnGetOT.Location = New System.Drawing.Point(934, 16)
        Me.btnGetOT.Name = "btnGetOT"
        Me.btnGetOT.Size = New System.Drawing.Size(112, 30)
        Me.btnGetOT.TabIndex = 0
        Me.btnGetOT.Text = "GET REPORT"
        Me.btnGetOT.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DataGridView3)
        Me.TabPage6.Controls.Add(Me.DataGridView1)
        Me.TabPage6.Controls.Add(Me.dgvSubProject)
        Me.TabPage6.Controls.Add(Me.Panel18)
        Me.TabPage6.Controls.Add(Me.Panel19)
        Me.TabPage6.Controls.Add(Me.DataGridView2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1841, 909)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Date Attendance Subcont Per Project"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(733, 61)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(1105, 780)
        Me.DataGridView3.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(733, 841)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1105, 10)
        Me.DataGridView1.TabIndex = 13
        Me.DataGridView1.Visible = False
        '
        'dgvSubProject
        '
        Me.dgvSubProject.AllowUserToAddRows = False
        Me.dgvSubProject.AllowUserToDeleteRows = False
        Me.dgvSubProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubProject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSubProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubProject.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvSubProject.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvSubProject.Location = New System.Drawing.Point(3, 61)
        Me.dgvSubProject.Name = "dgvSubProject"
        Me.dgvSubProject.ReadOnly = True
        Me.dgvSubProject.RowHeadersVisible = False
        Me.dgvSubProject.RowTemplate.Height = 24
        Me.dgvSubProject.Size = New System.Drawing.Size(730, 790)
        Me.dgvSubProject.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.FillWeight = 58.82011!
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 130.1395!
        Me.Column2.HeaderText = "HULL-NO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 50.76142!
        Me.Column3.HeaderText = "No"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 130.1395!
        Me.Column4.HeaderText = "SUB CONT"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 130.1395!
        Me.Column5.HeaderText = "JENIS PEKERJAAN"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.btnSP)
        Me.Panel18.Controls.Add(Me.Button1)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Location = New System.Drawing.Point(3, 851)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1835, 55)
        Me.Panel18.TabIndex = 11
        '
        'btnSP
        '
        Me.btnSP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSP.BackgroundImage = CType(resources.GetObject("btnSP.BackgroundImage"), System.Drawing.Image)
        Me.btnSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSP.Location = New System.Drawing.Point(1788, 8)
        Me.btnSP.Name = "btnSP"
        Me.btnSP.Size = New System.Drawing.Size(41, 36)
        Me.btnSP.TabIndex = 13
        Me.btnSP.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generate Report to Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel19
        '
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.ComboBox1)
        Me.Panel19.Controls.Add(Me.Label13)
        Me.Panel19.Controls.Add(Me.dtpSubProject)
        Me.Panel19.Controls.Add(Me.Label14)
        Me.Panel19.Controls.Add(Me.btnSubProject)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(3, 3)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1835, 58)
        Me.Panel19.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(421, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 30)
        Me.ComboBox1.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(299, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 23)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "DEPARTMENT"
        '
        'dtpSubProject
        '
        Me.dtpSubProject.CustomFormat = "MM/yyyy"
        Me.dtpSubProject.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpSubProject.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSubProject.Location = New System.Drawing.Point(154, 16)
        Me.dtpSubProject.Name = "dtpSubProject"
        Me.dtpSubProject.Size = New System.Drawing.Size(122, 30)
        Me.dtpSubProject.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label14.Location = New System.Drawing.Point(18, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "SELECT MONTH"
        '
        'btnSubProject
        '
        Me.btnSubProject.Location = New System.Drawing.Point(601, 16)
        Me.btnSubProject.Name = "btnSubProject"
        Me.btnSubProject.Size = New System.Drawing.Size(112, 30)
        Me.btnSubProject.TabIndex = 0
        Me.btnSubProject.Text = "GET REPORT"
        Me.btnSubProject.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1123, 399)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(200, 137)
        Me.DataGridView2.TabIndex = 14
        Me.DataGridView2.Visible = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgvSpS)
        Me.TabPage5.Controls.Add(Me.Panel15)
        Me.TabPage5.Controls.Add(Me.Panel16)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1841, 909)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Date Attendance Subcont per Subcont"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgvSpS
        '
        Me.dgvSpS.AllowUserToAddRows = False
        Me.dgvSpS.AllowUserToDeleteRows = False
        Me.dgvSpS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSpS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSpS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10})
        Me.dgvSpS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSpS.Location = New System.Drawing.Point(3, 61)
        Me.dgvSpS.Name = "dgvSpS"
        Me.dgvSpS.ReadOnly = True
        Me.dgvSpS.RowHeadersVisible = False
        Me.dgvSpS.RowTemplate.Height = 24
        Me.dgvSpS.Size = New System.Drawing.Size(1835, 790)
        Me.dgvSpS.TabIndex = 24
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Button3)
        Me.Panel15.Controls.Add(Me.Button4)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel15.Location = New System.Drawing.Point(3, 851)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1835, 55)
        Me.Panel15.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(1788, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 36)
        Me.Button3.TabIndex = 13
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 47)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Generate Report to Excel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.ComboBox2)
        Me.Panel16.Controls.Add(Me.Label11)
        Me.Panel16.Controls.Add(Me.dtpSpS)
        Me.Panel16.Controls.Add(Me.Label12)
        Me.Panel16.Controls.Add(Me.btnSpS)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1835, 58)
        Me.Panel16.TabIndex = 22
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(421, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(174, 30)
        Me.ComboBox2.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(299, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 23)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "DEPARTMENT"
        '
        'dtpSpS
        '
        Me.dtpSpS.CustomFormat = "MM/yyyy"
        Me.dtpSpS.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.dtpSpS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSpS.Location = New System.Drawing.Point(154, 16)
        Me.dtpSpS.Name = "dtpSpS"
        Me.dtpSpS.Size = New System.Drawing.Size(122, 30)
        Me.dtpSpS.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label12.Location = New System.Drawing.Point(18, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "SELECT MONTH"
        '
        'btnSpS
        '
        Me.btnSpS.Location = New System.Drawing.Point(601, 16)
        Me.btnSpS.Name = "btnSpS"
        Me.btnSpS.Size = New System.Drawing.Size(112, 30)
        Me.btnSpS.TabIndex = 0
        Me.btnSpS.Text = "GET REPORT"
        Me.btnSpS.UseVisualStyleBackColor = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Column10
        '
        Me.Column10.HeaderText = "No"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1849, 985)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.dgvHidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.dgvLate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLateUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.dgvExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExitUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.dgvGetOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgvSpS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbbDevice As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGetLogs As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvReport As ns1.BunifuCustomDataGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtInOut As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPersonellID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dtpAtt As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbDepart As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnAttendance As Button
    Friend WithEvents dgvHidden As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents cbbLateDPT As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpLateAtt As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGetLate As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnLateExcel As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents dgvLate As DataGridView
    Friend WithEvents dgvLateUser As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel12 As Panel
    Friend WithEvents cbDeptExit As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpExit As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGetExit As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents dgvExit As DataGridView
    Friend WithEvents dgvExitUser As DataGridView
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btnExportEXIT As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dgvSubProject As DataGridView
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpSubProject As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSubProject As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnExporttoExcel As Button
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnCloseAtt As Button
    Friend WithEvents btnCloseLate As Button
    Friend WithEvents btnCloseEP As Button
    Friend WithEvents btnSP As Button
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents dgvSpS As DataGridView
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpSpS As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSpS As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents btnSearchDate As Button
    Friend WithEvents lblKeseluruhan As Label
    Friend WithEvents cbbDevName As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtLateEMPname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSearchEMP As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Panel17 As Panel
    Friend WithEvents btnCloseOT As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel20 As Panel
    Friend WithEvents cbbDeptOT As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents dtpOT As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents btnGetOT As Button
    Friend WithEvents dgvGetOT As DataGridView
    Friend WithEvents txtOTname As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents cbbSubcon As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbbEmpType As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
