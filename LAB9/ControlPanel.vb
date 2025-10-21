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
        'data(0) = &HAA ' ASCII code for $
        'data(1) = &H55
        Select Case timerState
            Case 1 : data(0) = &H55
            Case 2 : data(0) = &HAA
                '    Case 3 : data(1) = &B11
                '    Case 4 : data(1) = &B100
                '    Case 5 : data(1) = &B101
                '    Case 6 : data(1) = &B110
                '    Case 7 : data(1) = &B111
                '    Case 8 : data(1) = &B1000
                '    Case 9 : data(1) = &B1001
                '    Case 10 : data(1) = &B1010
                '    Case 11 : data(1) = &B1011
                '    Case 12 : data(1) = &B1100
                '    Case 13 : data(1) = &B1101
                '    Case 14 : data(1) = &B1110
                '    Case 15 : data(1) = &B1111
                '    Case 16 : data(1) = &B10000
                '    Case 17 : data(1) = &B10001
                '    Case 18 : data(1) = &B10010
                '    Case 19 : data(1) = &B10011
                '    Case 20 : data(1) = &B10100
        End Select

        timerState += 1
        If timerState > 2 Then timerState = 1

        SerialPort1.Write(data, 0, 1)

        'Read
        Dim something As String
        Do Until something = "10101010" Or something = "01010101"
            Dim TX(SerialPort1.BytesToRead) As Byte
            SerialPort1.Read(TX, 0, SerialPort1.BytesToRead) 'read bytes from
            For i = 0 To UBound(TX)
                something = Console.ReadLine()
                Console.Write(TX(i))
            Next
        Loop
        Console.WriteLine("hooray!")
    End Sub

    Sub Read()
        Dim something As String
        Dim TX(SerialPort1.BytesToRead) As Byte
        SerialPort1.Read(TX, 0, SerialPort1.BytesToRead) 'read bytes from
        something = CStr($"{TX(0)}{TX(1)}{TX(2)}{TX(3)}{TX(4)}{TX(5)}{TX(6)}{TX(7)}")

        Console.WriteLine("")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data(1) As Byte
        'data(0) = &HAA ' ASCII code for $
        'data(1) = &H55
        Select Case timerState
            Case 0 : timerState = 1
                data(0) = &H24
            Case 1 : data(0) = &H24
            Case 2 : data(0) = &H24
                '    Case 3 : data(1) = &B11
                '    Case 4 : data(1) = &B100
                '    Case 5 : data(1) = &B101
                '    Case 6 : data(1) = &B110
                '    Case 7 : data(1) = &B111
                '    Case 8 : data(1) = &B1000
                '    Case 9 : data(1) = &B1001
                '    Case 10 : data(1) = &B1010
                '    Case 11 : data(1) = &B1011
                '    Case 12 : data(1) = &B1100
                '    Case 13 : data(1) = &B1101
                '    Case 14 : data(1) = &B1110
                '    Case 15 : data(1) = &B1111
                '    Case 16 : data(1) = &B10000
                '    Case 17 : data(1) = &B10001
                '    Case 18 : data(1) = &B10010
                '    Case 19 : data(1) = &B10011
                '    Case 20 : data(1) = &B10100
        End Select

        timerState += 1
        If timerState > 2 Then timerState = 1

        SerialPort1.Write(data, 0, 1)

        'Read and wait for proper response befor moving on
        Dim something As String = 0
        Do Until something = "36"
            Dim TX(SerialPort1.BytesToRead) As Byte
            SerialPort1.Read(TX, 0, SerialPort1.BytesToRead) 'read bytes from
            something = CStr($"{TX(0)}")
        Loop
        Console.WriteLine("hooray!")
        Connect()
    End Sub
End Class
