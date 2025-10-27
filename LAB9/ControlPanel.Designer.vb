<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanel
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.TimerButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PositionTrackBar = New System.Windows.Forms.TrackBar()
        Me.PositionLabel = New System.Windows.Forms.Label()
        Me.ADCCheckBox = New System.Windows.Forms.CheckBox()
        Me.ADCTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PositionTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(713, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(12, 49)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 22)
        Me.ConnectButton.TabIndex = 4
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'TimerButton
        '
        Me.TimerButton.Location = New System.Drawing.Point(713, 12)
        Me.TimerButton.Name = "TimerButton"
        Me.TimerButton.Size = New System.Drawing.Size(75, 23)
        Me.TimerButton.TabIndex = 5
        Me.TimerButton.Text = "Timer"
        Me.TimerButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PositionTrackBar
        '
        Me.PositionTrackBar.BackColor = System.Drawing.Color.Black
        Me.PositionTrackBar.LargeChange = 1
        Me.PositionTrackBar.Location = New System.Drawing.Point(12, 110)
        Me.PositionTrackBar.Maximum = 20
        Me.PositionTrackBar.Name = "PositionTrackBar"
        Me.PositionTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PositionTrackBar.Size = New System.Drawing.Size(45, 328)
        Me.PositionTrackBar.TabIndex = 7
        Me.PositionTrackBar.Value = 1
        '
        'PositionLabel
        '
        Me.PositionLabel.AutoSize = True
        Me.PositionLabel.Location = New System.Drawing.Point(12, 94)
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(75, 13)
        Me.PositionLabel.TabIndex = 8
        Me.PositionLabel.Text = "Servo Position"
        '
        'ADCCheckBox
        '
        Me.ADCCheckBox.AutoSize = True
        Me.ADCCheckBox.Location = New System.Drawing.Point(63, 415)
        Me.ADCCheckBox.Name = "ADCCheckBox"
        Me.ADCCheckBox.Size = New System.Drawing.Size(94, 17)
        Me.ADCCheckBox.TabIndex = 9
        Me.ADCCheckBox.Text = "ADC SAMPLE"
        Me.ADCCheckBox.UseVisualStyleBackColor = True
        '
        'ADCTextBox
        '
        Me.ADCTextBox.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADCTextBox.Location = New System.Drawing.Point(334, 210)
        Me.ADCTextBox.Name = "ADCTextBox"
        Me.ADCTextBox.ReadOnly = True
        Me.ADCTextBox.Size = New System.Drawing.Size(100, 32)
        Me.ADCTextBox.TabIndex = 11
        Me.ADCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(370, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ADC"
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ADCTextBox)
        Me.Controls.Add(Me.ADCCheckBox)
        Me.Controls.Add(Me.PositionLabel)
        Me.Controls.Add(Me.PositionTrackBar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TimerButton)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "ControlPanel"
        Me.Text = "Form1"
        CType(Me.PositionTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ExitButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents TimerButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PositionTrackBar As TrackBar
    Friend WithEvents PositionLabel As Label
    Friend WithEvents ADCCheckBox As CheckBox
    Friend WithEvents ADCTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
