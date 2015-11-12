<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(game))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.finish = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.score1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.car = New System.Windows.Forms.PictureBox()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-3, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1062, 11)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-3, 550)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1062, 11)
        Me.Label2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(-3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 552)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1049, -3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 564)
        Me.Label4.TabIndex = 4
        '
        'finish
        '
        Me.finish.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.finish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.finish.Font = New System.Drawing.Font("Hobo Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finish.ForeColor = System.Drawing.Color.Navy
        Me.finish.Location = New System.Drawing.Point(962, 515)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(86, 35)
        Me.finish.TabIndex = 5
        Me.finish.Text = "FINISH"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(65, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 159)
        Me.Label5.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(188, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 159)
        Me.Label7.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(534, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 0)
        Me.Label8.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(453, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 159)
        Me.Label9.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(319, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 159)
        Me.Label12.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(586, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 159)
        Me.Label14.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(988, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 159)
        Me.Label16.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(853, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 159)
        Me.Label15.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(722, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 159)
        Me.Label6.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(525, 391)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 159)
        Me.Label17.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(799, 391)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 159)
        Me.Label19.TabIndex = 24
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(131, 391)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 159)
        Me.Label21.TabIndex = 26
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(662, 391)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 159)
        Me.Label22.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(394, 391)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 159)
        Me.Label23.TabIndex = 28
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(256, 391)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 159)
        Me.Label24.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(926, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 159)
        Me.Label10.TabIndex = 30
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(-2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1062, 11)
        Me.Label11.TabIndex = 31
        '
        'score1
        '
        Me.score1.BackColor = System.Drawing.Color.MistyRose
        Me.score1.Font = New System.Drawing.Font("Myriad Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.score1.Location = New System.Drawing.Point(962, 11)
        Me.score1.Name = "score1"
        Me.score1.Size = New System.Drawing.Size(62, 26)
        Me.score1.TabIndex = 32
        Me.score1.Text = " 1000"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Myriad Pro Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(879, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 26)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "SCORE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Future TimeSplitters", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(511, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 25)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "My.Escape"
        '
        'car
        '
        Me.car.Image = Global.My.Escape.My.Resources.Resources.running3
        Me.car.Location = New System.Drawing.Point(12, 273)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(27, 47)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 0
        Me.car.TabStop = False
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1060, 559)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.score1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.car)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "game"
        Me.Text = "My.Escape_GAME"
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents car As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents finish As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents score1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
