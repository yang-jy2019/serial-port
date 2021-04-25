<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.portnamebox = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.openbtn = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.baudratebox = New System.Windows.Forms.ComboBox()
        Me.sendbox = New System.Windows.Forms.TextBox()
        Me.receivebox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sendbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.statuslabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'portnamebox
        '
        Me.portnamebox.FormattingEnabled = True
        Me.portnamebox.Location = New System.Drawing.Point(126, 63)
        Me.portnamebox.Name = "portnamebox"
        Me.portnamebox.Size = New System.Drawing.Size(121, 23)
        Me.portnamebox.TabIndex = 0
        '
        'SerialPort1
        '
        '
        'openbtn
        '
        Me.openbtn.Location = New System.Drawing.Point(296, 62)
        Me.openbtn.Name = "openbtn"
        Me.openbtn.Size = New System.Drawing.Size(75, 23)
        Me.openbtn.TabIndex = 1
        Me.openbtn.Text = "连接"
        Me.openbtn.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(387, 62)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(75, 23)
        Me.closebtn.TabIndex = 2
        Me.closebtn.Text = "断开"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "串口:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "波特率:"
        '
        'baudratebox
        '
        Me.baudratebox.FormattingEnabled = True
        Me.baudratebox.Items.AddRange(New Object() {"9600", "19200", "25800", ""})
        Me.baudratebox.Location = New System.Drawing.Point(126, 102)
        Me.baudratebox.Name = "baudratebox"
        Me.baudratebox.Size = New System.Drawing.Size(121, 23)
        Me.baudratebox.TabIndex = 5
        '
        'sendbox
        '
        Me.sendbox.Location = New System.Drawing.Point(126, 195)
        Me.sendbox.Name = "sendbox"
        Me.sendbox.Size = New System.Drawing.Size(100, 25)
        Me.sendbox.TabIndex = 6
        '
        'receivebox
        '
        Me.receivebox.Location = New System.Drawing.Point(126, 247)
        Me.receivebox.Name = "receivebox"
        Me.receivebox.Size = New System.Drawing.Size(100, 25)
        Me.receivebox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "发送数据:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "接收数据:"
        '
        'sendbtn
        '
        Me.sendbtn.Location = New System.Drawing.Point(257, 196)
        Me.sendbtn.Name = "sendbtn"
        Me.sendbtn.Size = New System.Drawing.Size(75, 23)
        Me.sendbtn.TabIndex = 10
        Me.sendbtn.Text = "发送"
        Me.sendbtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "串口状态"
        '
        'statuslabel
        '
        Me.statuslabel.AutoSize = True
        Me.statuslabel.Location = New System.Drawing.Point(210, 151)
        Me.statuslabel.Name = "statuslabel"
        Me.statuslabel.Size = New System.Drawing.Size(82, 15)
        Me.statuslabel.TabIndex = 12
        Me.statuslabel.Text = "串口未连接"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Label7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 363)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.statuslabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sendbtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.receivebox)
        Me.Controls.Add(Me.sendbox)
        Me.Controls.Add(Me.baudratebox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.openbtn)
        Me.Controls.Add(Me.portnamebox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents portnamebox As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents openbtn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents baudratebox As ComboBox
    Friend WithEvents sendbox As TextBox
    Friend WithEvents receivebox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sendbtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents statuslabel As Label
    Friend WithEvents Label7 As Label
End Class
