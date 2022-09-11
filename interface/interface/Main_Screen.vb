Public Class Main_Screen

    Dim p1 As Process = New Process
    Dim p2 As Process = New Process
    Dim p3 As Process = New Process

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Main_Update_Timer.Start()
        p1.StartInfo.Arguments = "calc_total_water_usage.py"
        p1.StartInfo.FileName = "C:\Users\Hyper\AppData\Local\Programs\Python\Python310\python.exe"
        p1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p1.StartInfo.CreateNoWindow = True
        p1.StartInfo.RedirectStandardOutput = True
        p1.StartInfo.UseShellExecute = False
        p1.Start()
        AddHandler p1.OutputDataReceived, AddressOf proccess_ReturnValue
        p1.BeginOutputReadLine()
        p1.WaitForExit()

        TotUseLabel.Text = "Total Water Usage: " + Tot_Usage_Num + " (L)"
        p1.CancelOutputRead()

        p2.StartInfo.Arguments = "get_limit.py"
        p2.StartInfo.FileName = "C:\Users\Hyper\AppData\Local\Programs\Python\Python310\python.exe"
        p2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p2.StartInfo.CreateNoWindow = True
        p2.StartInfo.RedirectStandardOutput = True
        p2.StartInfo.UseShellExecute = False
        p2.Start()
        AddHandler p2.OutputDataReceived, AddressOf proccess_ReturnValue
        p2.BeginOutputReadLine()
        p2.WaitForExit()

        Limit_Label.Text = "Limit: " + Limit_Num + " (L)"
        p2.CancelOutputRead()

    End Sub

    Private Sub Limit_Click(sender As Object, e As EventArgs) Handles Limit.Click

        Limit_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub Usage_Click(sender As Object, e As EventArgs) Handles Usage.Click

        Usage_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Main_Update_Timer.Tick

        p1.StartInfo.Arguments = "calc_total_water_usage.py"
        p1.StartInfo.FileName = "C:\Users\Hyper\AppData\Local\Programs\Python\Python310\python.exe"
        p1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p1.StartInfo.CreateNoWindow = True
        p1.StartInfo.RedirectStandardOutput = True
        p1.StartInfo.UseShellExecute = False
        p1.Start()
        AddHandler p1.OutputDataReceived, AddressOf proccess_ReturnValue1
        p1.BeginOutputReadLine()
        p1.WaitForExit()

        TotUseLabel.Text = "Total Water Usage: " + Tot_Usage_Num + " (L)"
        p1.CancelOutputRead()

        p3.StartInfo.Arguments = "lake.py"
        p3.StartInfo.FileName = "C:\Users\Hyper\AppData\Local\Programs\Python\Python310\python.exe"
        p3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p3.StartInfo.CreateNoWindow = True
        p3.StartInfo.RedirectStandardOutput = True
        p3.StartInfo.UseShellExecute = False
        p3.Start()
        AddHandler p3.OutputDataReceived, AddressOf proccess_ReturnValue
        p3.BeginOutputReadLine()
        p3.WaitForExit()
        p3.CancelOutputRead()

        If Lake_Percent < 0 Then
            Lake_Image.Image = My.Resources.Resources.Union
        ElseIf Lake_Percent < 51 Then
            Lake_Image.Image = My.Resources.Resources.Group_2
        End If

    End Sub

    Public Sub proccess_ReturnValue(ByVal sender As Object, ByVal e As DataReceivedEventArgs)

        On Error Resume Next
        If e.Data = "" Then
        Else
            Tot_Usage_Num = e.Data
        End If

    End Sub

End Class
