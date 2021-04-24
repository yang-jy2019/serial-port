Imports System.IO.Ports
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ports As String() = SerialPort.GetPortNames()
        Dim port As String
        For Each port In ports
            portnamebox.Items.Add(port)
        Next port
        baudratebox.SelectedIndex() = 0
        portnamebox.SelectedIndex() = 0
        Serial_Port1()
        Label7.Text = SerialPort1.IsOpen
        statuslabel.Text = "串口未连接"
        statuslabel.ForeColor = Color.Red
<<<<<<< HEAD
        sendbox.Text = "请输入信息"
=======
        sendbox.Text = "请输入"
>>>>>>> 9ce2334effdba505073948b9702bb1b19e6c8d33

    End Sub

    Private Sub Serial_Port1()
        SerialPort1.BaudRate = Val(baudratebox.Text)
        SerialPort1.PortName = portnamebox.Text
        SerialPort1.DataBits = 8
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.Parity = IO.Ports.Parity.None
    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Try
            SerialPort1.Close()
            Label7.Text = SerialPort1.IsOpen
            If SerialPort1.IsOpen = False Then
                statuslabel.Text = "串口未连接"
                statuslabel.ForeColor = Color.Red
                receivebox.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub openbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openbtn.Click
        Try
            SerialPort1.Open()
            Label7.Text = SerialPort1.IsOpen
            If SerialPort1.IsOpen = True Then
                statuslabel.Text = "串口连接成功"
                statuslabel.ForeColor = Color.Green
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendbtn.Click
        Try
            SerialPort1.Write(sendbox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Sp_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Me.Invoke(New EventHandler(AddressOf Sp_Receiving))
    End Sub


    Private Sub Sp_Receiving(ByVal sender As Object, ByVal e As EventArgs)
        Dim strIncoming As String
        Try
            If SerialPort1.BytesToRead > 0 Then
                Threading.Thread.Sleep(100)
                strIncoming = SerialPort1.ReadExisting.ToString
                SerialPort1.DiscardInBuffer()
                receivebox.Text = strIncoming
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
