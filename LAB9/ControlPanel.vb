Imports System.IO.Ports

Public Class ControlPanel
    Public timerState As Integer
    Sub Connect()
        SerialPort1.Close()
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        Try
            If ComboBox1.SelectedItem.ToString Is Nothing Then
                MsgBox("Select a valid COM port", MsgBoxStyle.Critical)
            ElseIf ComboBox1.SelectedItem.ToString <> Nothing Then
                SerialPort1.PortName = ComboBox1.SelectedItem.ToString
            End If
        Catch ex As Exception
            MsgBox("Select a valid COM port", MsgBoxStyle.Critical)
        End Try

        SerialPort1.Open()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        SerialPort1.Close()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim data(1) As Byte
        data(0) = &H24 ' ASCII code for $
        Select Case timerState
            Case 1 : data(1) = &B1
            Case 2 : data(1) = &B10
            Case 3 : data(1) = &B11
            Case 4 : data(1) = &B100
            Case 5 : data(1) = &B101
            Case 6 : data(1) = &B110
            Case 7 : data(1) = &B111
            Case 8 : data(1) = &B1000
            Case 9 : data(1) = &B1001
            Case 10 : data(1) = &B1010
            Case 11 : data(1) = &B1011
            Case 12 : data(1) = &B1100
            Case 13 : data(1) = &B1101
            Case 14 : data(1) = &B1110
            Case 15 : data(1) = &B1111
            Case 16 : data(1) = &B10000
            Case 17 : data(1) = &B10001
            Case 18 : data(1) = &B10010
            Case 19 : data(1) = &B10011
            Case 20 : data(1) = &B10100
        End Select

        timerState += 1
        If timerState > 25 Then timerState = 1

        SerialPort1.Write(data, 0, 2)
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Connect()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For port = 0 To SerialPort.GetPortNames.Length - 1
            ComboBox1.Items.Add(SerialPort.GetPortNames()(port))
        Next
    End Sub

    Private Sub TimerButton_Click(sender As Object, e As EventArgs) Handles TimerButton.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            TimerButton.Text = "Stop Timer"
        Else Timer1.Enabled = True
            Timer1.Enabled = False
            TimerButton.Text = "Start Timer"
        End If
    End Sub
End Class
