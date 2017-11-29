<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblP1Score = New System.Windows.Forms.Label()
        Me.btnP1Point = New System.Windows.Forms.Button()
        Me.btnP2Point = New System.Windows.Forms.Button()
        Me.lblP2Score = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.btnP1FirstServe = New System.Windows.Forms.Button()
        Me.btnP1SecondServe = New System.Windows.Forms.Button()
        Me.btnP2SecondServe = New System.Windows.Forms.Button()
        Me.btnP2FirstServe = New System.Windows.Forms.Button()
        Me.btnGameSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkPlayer1 = New System.Windows.Forms.CheckBox()
        Me.chkPlayer2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(58, 9)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(148, 46)
        Me.lblPlayer1.TabIndex = 15
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(332, 9)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(148, 46)
        Me.lblPlayer2.TabIndex = 16
        Me.lblPlayer2.Text = "Player 2"
        '
        'lblP1Score
        '
        Me.lblP1Score.AutoSize = True
        Me.lblP1Score.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Score.Location = New System.Drawing.Point(191, 93)
        Me.lblP1Score.Name = "lblP1Score"
        Me.lblP1Score.Size = New System.Drawing.Size(40, 46)
        Me.lblP1Score.TabIndex = 12
        Me.lblP1Score.Text = "0"
        '
        'btnP1Point
        '
        Me.btnP1Point.Location = New System.Drawing.Point(34, 144)
        Me.btnP1Point.Name = "btnP1Point"
        Me.btnP1Point.Size = New System.Drawing.Size(176, 176)
        Me.btnP1Point.TabIndex = 4
        Me.btnP1Point.Text = "Point"
        Me.btnP1Point.UseVisualStyleBackColor = True
        '
        'btnP2Point
        '
        Me.btnP2Point.Location = New System.Drawing.Point(285, 144)
        Me.btnP2Point.Name = "btnP2Point"
        Me.btnP2Point.Size = New System.Drawing.Size(176, 176)
        Me.btnP2Point.TabIndex = 5
        Me.btnP2Point.Text = "Point"
        Me.btnP2Point.UseVisualStyleBackColor = True
        '
        'lblP2Score
        '
        Me.lblP2Score.AutoSize = True
        Me.lblP2Score.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Score.Location = New System.Drawing.Point(273, 93)
        Me.lblP2Score.Name = "lblP2Score"
        Me.lblP2Score.Size = New System.Drawing.Size(40, 46)
        Me.lblP2Score.TabIndex = 14
        Me.lblP2Score.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 46)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "-"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(74, 49)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 27)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Server"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(340, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 27)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Server"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnP1FirstServe
        '
        Me.btnP1FirstServe.Location = New System.Drawing.Point(34, 326)
        Me.btnP1FirstServe.Name = "btnP1FirstServe"
        Me.btnP1FirstServe.Size = New System.Drawing.Size(176, 34)
        Me.btnP1FirstServe.TabIndex = 6
        Me.btnP1FirstServe.Text = "First serve"
        Me.btnP1FirstServe.UseVisualStyleBackColor = True
        '
        'btnP1SecondServe
        '
        Me.btnP1SecondServe.Location = New System.Drawing.Point(34, 366)
        Me.btnP1SecondServe.Name = "btnP1SecondServe"
        Me.btnP1SecondServe.Size = New System.Drawing.Size(176, 34)
        Me.btnP1SecondServe.TabIndex = 7
        Me.btnP1SecondServe.Text = "Second serve"
        Me.btnP1SecondServe.UseVisualStyleBackColor = True
        '
        'btnP2SecondServe
        '
        Me.btnP2SecondServe.Location = New System.Drawing.Point(285, 366)
        Me.btnP2SecondServe.Name = "btnP2SecondServe"
        Me.btnP2SecondServe.Size = New System.Drawing.Size(176, 34)
        Me.btnP2SecondServe.TabIndex = 9
        Me.btnP2SecondServe.Text = "Second serve"
        Me.btnP2SecondServe.UseVisualStyleBackColor = True
        '
        'btnP2FirstServe
        '
        Me.btnP2FirstServe.Location = New System.Drawing.Point(285, 326)
        Me.btnP2FirstServe.Name = "btnP2FirstServe"
        Me.btnP2FirstServe.Size = New System.Drawing.Size(176, 34)
        Me.btnP2FirstServe.TabIndex = 8
        Me.btnP2FirstServe.Text = "First serve"
        Me.btnP2FirstServe.UseVisualStyleBackColor = True
        '
        'btnGameSubmit
        '
        Me.btnGameSubmit.Location = New System.Drawing.Point(128, 434)
        Me.btnGameSubmit.Name = "btnGameSubmit"
        Me.btnGameSubmit.Size = New System.Drawing.Size(127, 34)
        Me.btnGameSubmit.TabIndex = 10
        Me.btnGameSubmit.Text = "Submit"
        Me.btnGameSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(261, 434)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 34)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkPlayer1
        '
        Me.chkPlayer1.AutoSize = True
        Me.chkPlayer1.Location = New System.Drawing.Point(69, 76)
        Me.chkPlayer1.Name = "chkPlayer1"
        Me.chkPlayer1.Size = New System.Drawing.Size(87, 27)
        Me.chkPlayer1.TabIndex = 1
        Me.chkPlayer1.Text = "Winner"
        Me.chkPlayer1.UseVisualStyleBackColor = True
        '
        'chkPlayer2
        '
        Me.chkPlayer2.AutoSize = True
        Me.chkPlayer2.Location = New System.Drawing.Point(340, 76)
        Me.chkPlayer2.Name = "chkPlayer2"
        Me.chkPlayer2.Size = New System.Drawing.Size(87, 27)
        Me.chkPlayer2.TabIndex = 3
        Me.chkPlayer2.Text = "Winner"
        Me.chkPlayer2.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AcceptButton = Me.btnGameSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 471)
        Me.Controls.Add(Me.chkPlayer2)
        Me.Controls.Add(Me.chkPlayer1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGameSubmit)
        Me.Controls.Add(Me.btnP2SecondServe)
        Me.Controls.Add(Me.btnP2FirstServe)
        Me.Controls.Add(Me.btnP1SecondServe)
        Me.Controls.Add(Me.btnP1FirstServe)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblP2Score)
        Me.Controls.Add(Me.btnP2Point)
        Me.Controls.Add(Me.btnP1Point)
        Me.Controls.Add(Me.lblP1Score)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "game_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents lblP1Score As Label
    Friend WithEvents btnP1Point As Button
    Friend WithEvents btnP2Point As Button
    Friend WithEvents lblP2Score As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents btnP1FirstServe As Button
    Friend WithEvents btnP1SecondServe As Button
    Friend WithEvents btnP2SecondServe As Button
    Friend WithEvents btnP2FirstServe As Button
    Friend WithEvents btnGameSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkPlayer1 As CheckBox
    Friend WithEvents chkPlayer2 As CheckBox
End Class
