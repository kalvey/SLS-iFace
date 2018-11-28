<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashScreen))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbSplash = New ns1.BunifuProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(244, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 212)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pbSplash
        '
        Me.pbSplash.BackColor = System.Drawing.Color.Snow
        Me.pbSplash.BorderRadius = 5
        Me.pbSplash.Location = New System.Drawing.Point(188, 313)
        Me.pbSplash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbSplash.MaximumValue = 100
        Me.pbSplash.Name = "pbSplash"
        Me.pbSplash.ProgressColor = System.Drawing.Color.Goldenrod
        Me.pbSplash.Size = New System.Drawing.Size(547, 12)
        Me.pbSplash.TabIndex = 1
        Me.pbSplash.Value = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'splashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(941, 438)
        Me.Controls.Add(Me.pbSplash)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splashScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbSplash As ns1.BunifuProgressBar
    Friend WithEvents Timer1 As Timer
End Class
