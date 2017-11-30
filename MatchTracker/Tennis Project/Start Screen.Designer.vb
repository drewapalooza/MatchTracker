<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start_Screen
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQuickStart = New System.Windows.Forms.Button()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("AR DESTINE", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(195, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(271, 43)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "MatchTracker"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Player 1"
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(59, 137)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(176, 30)
        Me.txtPlayer1.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 113)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(420, 34)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(103, 64)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start Match"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Scoring:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(295, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(83, 27)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "No AD"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox2.Location = New System.Drawing.Point(143, 72)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(60, 31)
        Me.ComboBox2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Games per set:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ComboBox1.Location = New System.Drawing.Point(143, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(60, 31)
        Me.ComboBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Number of sets:"
        '
        'btnQuickStart
        '
        Me.btnQuickStart.Location = New System.Drawing.Point(277, 137)
        Me.btnQuickStart.Name = "btnQuickStart"
        Me.btnQuickStart.Size = New System.Drawing.Size(107, 30)
        Me.btnQuickStart.TabIndex = 37
        Me.btnQuickStart.Text = "QuickStart"
        Me.btnQuickStart.UseVisualStyleBackColor = True
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(426, 137)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(176, 30)
        Me.txtPlayer2.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(421, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Player 2"
        '
        'Start_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 335)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnQuickStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Start_Screen"
        Me.Text = "MatchTracker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlayer1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnQuickStart As Button
    Friend WithEvents txtPlayer2 As TextBox
    Friend WithEvents Label2 As Label
End Class
