﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoint
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioAce = New System.Windows.Forms.RadioButton()
        Me.radioDouble = New System.Windows.Forms.RadioButton()
        Me.radioServiceWinner = New System.Windows.Forms.RadioButton()
        Me.radioForehandWinner = New System.Windows.Forms.RadioButton()
        Me.radioBackhandWinner = New System.Windows.Forms.RadioButton()
        Me.radioForehandError = New System.Windows.Forms.RadioButton()
        Me.radioBackhandError = New System.Windows.Forms.RadioButton()
        Me.radioVolleyWinner = New System.Windows.Forms.RadioButton()
        Me.radioVolleyError = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Point Details"
        '
        'radioAce
        '
        Me.radioAce.AutoSize = True
        Me.radioAce.Location = New System.Drawing.Point(35, 35)
        Me.radioAce.Name = "radioAce"
        Me.radioAce.Size = New System.Drawing.Size(47, 21)
        Me.radioAce.TabIndex = 0
        Me.radioAce.Text = "Ace"
        Me.radioAce.UseVisualStyleBackColor = True
        '
        'radioDouble
        '
        Me.radioDouble.AutoSize = True
        Me.radioDouble.Location = New System.Drawing.Point(91, 35)
        Me.radioDouble.Name = "radioDouble"
        Me.radioDouble.Size = New System.Drawing.Size(97, 21)
        Me.radioDouble.TabIndex = 1
        Me.radioDouble.Text = "Double fault"
        Me.radioDouble.UseVisualStyleBackColor = True
        '
        'radioServiceWinner
        '
        Me.radioServiceWinner.AutoSize = True
        Me.radioServiceWinner.Location = New System.Drawing.Point(194, 35)
        Me.radioServiceWinner.Name = "radioServiceWinner"
        Me.radioServiceWinner.Size = New System.Drawing.Size(109, 21)
        Me.radioServiceWinner.TabIndex = 2
        Me.radioServiceWinner.Text = "Service winner"
        Me.radioServiceWinner.UseVisualStyleBackColor = True
        '
        'radioForehandWinner
        '
        Me.radioForehandWinner.AutoSize = True
        Me.radioForehandWinner.Location = New System.Drawing.Point(48, 166)
        Me.radioForehandWinner.Name = "radioForehandWinner"
        Me.radioForehandWinner.Size = New System.Drawing.Size(123, 21)
        Me.radioForehandWinner.TabIndex = 6
        Me.radioForehandWinner.Text = "Forehand winner"
        Me.radioForehandWinner.UseVisualStyleBackColor = True
        '
        'radioBackhandWinner
        '
        Me.radioBackhandWinner.AutoSize = True
        Me.radioBackhandWinner.Location = New System.Drawing.Point(48, 193)
        Me.radioBackhandWinner.Name = "radioBackhandWinner"
        Me.radioBackhandWinner.Size = New System.Drawing.Size(123, 21)
        Me.radioBackhandWinner.TabIndex = 8
        Me.radioBackhandWinner.Text = "Backhand winner"
        Me.radioBackhandWinner.UseVisualStyleBackColor = True
        '
        'radioForehandError
        '
        Me.radioForehandError.AutoSize = True
        Me.radioForehandError.Location = New System.Drawing.Point(184, 166)
        Me.radioForehandError.Name = "radioForehandError"
        Me.radioForehandError.Size = New System.Drawing.Size(115, 21)
        Me.radioForehandError.TabIndex = 7
        Me.radioForehandError.Text = "Forehand error"
        Me.radioForehandError.UseVisualStyleBackColor = True
        '
        'radioBackhandError
        '
        Me.radioBackhandError.AutoSize = True
        Me.radioBackhandError.Location = New System.Drawing.Point(184, 193)
        Me.radioBackhandError.Name = "radioBackhandError"
        Me.radioBackhandError.Size = New System.Drawing.Size(115, 21)
        Me.radioBackhandError.TabIndex = 9
        Me.radioBackhandError.Text = "Backhand error"
        Me.radioBackhandError.UseVisualStyleBackColor = True
        '
        'radioVolleyWinner
        '
        Me.radioVolleyWinner.AutoSize = True
        Me.radioVolleyWinner.Location = New System.Drawing.Point(50, 35)
        Me.radioVolleyWinner.Name = "radioVolleyWinner"
        Me.radioVolleyWinner.Size = New System.Drawing.Size(102, 21)
        Me.radioVolleyWinner.TabIndex = 0
        Me.radioVolleyWinner.Text = "Volley winner"
        Me.radioVolleyWinner.UseVisualStyleBackColor = True
        '
        'radioVolleyError
        '
        Me.radioVolleyError.AutoSize = True
        Me.radioVolleyError.Location = New System.Drawing.Point(195, 35)
        Me.radioVolleyError.Name = "radioVolleyError"
        Me.radioVolleyError.Size = New System.Drawing.Size(94, 21)
        Me.radioVolleyError.TabIndex = 1
        Me.radioVolleyError.Text = "Volley error"
        Me.radioVolleyError.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(58, 337)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(102, 44)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(186, 337)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 44)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioAce)
        Me.GroupBox1.Controls.Add(Me.radioDouble)
        Me.GroupBox1.Controls.Add(Me.radioServiceWinner)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 90)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serve"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(3, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 90)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "Groundstroke"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radioVolleyError)
        Me.GroupBox3.Controls.Add(Me.radioVolleyWinner)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 90)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Volley"
        '
        'frmPoint
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.radioBackhandError)
        Me.Controls.Add(Me.radioForehandError)
        Me.Controls.Add(Me.radioBackhandWinner)
        Me.Controls.Add(Me.radioForehandWinner)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radioAce As RadioButton
    Friend WithEvents radioDouble As RadioButton
    Friend WithEvents radioServiceWinner As RadioButton
    Friend WithEvents radioForehandWinner As RadioButton
    Friend WithEvents radioBackhandWinner As RadioButton
    Friend WithEvents radioForehandError As RadioButton
    Friend WithEvents radioBackhandError As RadioButton
    Friend WithEvents radioVolleyWinner As RadioButton
    Friend WithEvents radioVolleyError As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
