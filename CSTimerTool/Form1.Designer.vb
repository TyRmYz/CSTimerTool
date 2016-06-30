<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSTimerTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CSTimerTool))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CSStatus = New System.Windows.Forms.Label()
        Me.timerstatus = New System.Windows.Forms.Label()
        Me.Traystuff = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CSStatus
        '
        Me.CSStatus.AutoSize = True
        Me.CSStatus.Location = New System.Drawing.Point(12, 275)
        Me.CSStatus.Name = "CSStatus"
        Me.CSStatus.Size = New System.Drawing.Size(73, 13)
        Me.CSStatus.TabIndex = 0
        Me.CSStatus.Text = "CSGO Status:"
        '
        'timerstatus
        '
        Me.timerstatus.AutoSize = True
        Me.timerstatus.Location = New System.Drawing.Point(254, 275)
        Me.timerstatus.Name = "timerstatus"
        Me.timerstatus.Size = New System.Drawing.Size(69, 13)
        Me.timerstatus.TabIndex = 1
        Me.timerstatus.Text = "Timer Status:"
        '
        'Traystuff
        '
        Me.Traystuff.Text = "CS Timer Tool"
        Me.Traystuff.Visible = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CSTimerTool.My.Resources.Resources.smallcs1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(482, 272)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'CSTimerTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 293)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.timerstatus)
        Me.Controls.Add(Me.CSStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CSTimerTool"
        Me.Text = "CS Timer Tool by KURttU"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CSStatus As System.Windows.Forms.Label
    Friend WithEvents timerstatus As System.Windows.Forms.Label
    Friend WithEvents Traystuff As System.Windows.Forms.NotifyIcon
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
