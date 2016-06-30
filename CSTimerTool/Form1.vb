
Imports System.Runtime.InteropServices
Public Class CSTimerTool
    <DllImport("ntdll.dll", EntryPoint:="NtSetTimerResolution")>
    Public Shared Sub NtSetTimerResolution(desiredResolution As UInteger, setResolution As Boolean, ByRef currentResolution As UInteger)
    End Sub
    <DllImport("ntdll.dll", EntryPoint:="NtQueryTimerResolution")>
    Public Shared Sub NtQueryTimerResolution(MinimumResoltuion As UInteger, MaximumResolution As UInteger, currentResolution As UInteger)
    End Sub

    Public ContextMenu1 As New ContextMenu

    Private desiredResolution As UInteger = 5000
    Private setResolution = True
    Private currentResolution As UInteger
    Private p() As Process
    Private wasrunning As String
    Private showrunning As String

    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False

        showrunning = "0"
        CSStatus.Text = "CSGO Status: Not running"
        timerstatus.Text = "Timer status: Not set"
        Timer1.Enabled = True

        Traystuff.Visible = True
        Traystuff.Text = "CS Timer Tool"
        Traystuff.Icon = My.Resources.cstt
        Traystuff.BalloonTipIcon = ToolTipIcon.Info
        Traystuff.BalloonTipTitle = "Timer tool starting"
        Traystuff.BalloonTipText = "Application started and monitoring on background"
        Traystuff.ShowBalloonTip(50000)

        ShowInTaskbar = False

        PictureBox1.Show()
        PictureBox1.Refresh()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        p = Process.GetProcessesByName("CSGO")
        If p.Count > 0 Then
            desiredResolution = 5000
            NtSetTimerResolution(desiredResolution, setResolution, currentResolution)
            timerstatus.Text = "Timer status: Set"
            CSStatus.Text = "CSGO status: Running"
            If showrunning = "0" Then
                Traystuff.BalloonTipTitle = "CSGO Starting"
                Traystuff.BalloonTipText = "Timer activated!"
                Traystuff.ShowBalloonTip(1)
                showrunning = "1"
            Else

            End If
        Else
            CSStatus.Text = "CSGO status: Not running"
            timerstatus.Text = "Timer status: Not set"
            If showrunning = "1" Then
                Traystuff.BalloonTipTitle = "CSGO Closed"
                Traystuff.BalloonTipText = "Timer Deactivated!"
                Traystuff.ShowBalloonTip(1)
                desiredResolution = 10000
                NtSetTimerResolution(desiredResolution, setResolution, currentResolution)

                showrunning = "0"
            End If

        End If

    End Sub

    Private Sub Traystuff_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Traystuff.DoubleClick

        Me.WindowState = FormWindowState.Normal
        Traystuff.Visible = True
        ShowInTaskbar = False

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False

    End Sub

End Class
