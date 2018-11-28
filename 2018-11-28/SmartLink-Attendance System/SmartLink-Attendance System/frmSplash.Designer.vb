<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbSplash = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(242, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "value"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbSplash
        '
        Me.pbSplash.Location = New System.Drawing.Point(246, 288)
        Me.pbSplash.Name = "pbSplash"
        Me.pbSplash.Size = New System.Drawing.Size(391, 35)
        Me.pbSplash.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbSplash.TabIndex = 0
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(864, 438)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents pbSplash As ProgressBar
End Class
