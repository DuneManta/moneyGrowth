<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtGrowth = New System.Windows.Forms.TextBox()
        Me.txtCycles = New System.Windows.Forms.TextBox()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.btnFutureValue = New System.Windows.Forms.Button()
        Me.btnTimeToTarget = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "For future value of amount after specified cycles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Growth rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of cylces"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(322, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "For number of cycles to reach target amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Target amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Answer"
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(122, 416)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(194, 58)
        Me.lblAnswer.TabIndex = 7
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(168, 17)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtAmount.TabIndex = 8
        '
        'txtGrowth
        '
        Me.txtGrowth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrowth.Location = New System.Drawing.Point(168, 60)
        Me.txtGrowth.Name = "txtGrowth"
        Me.txtGrowth.Size = New System.Drawing.Size(100, 26)
        Me.txtGrowth.TabIndex = 9
        '
        'txtCycles
        '
        Me.txtCycles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCycles.Location = New System.Drawing.Point(168, 168)
        Me.txtCycles.Name = "txtCycles"
        Me.txtCycles.Size = New System.Drawing.Size(100, 26)
        Me.txtCycles.TabIndex = 10
        '
        'txtTarget
        '
        Me.txtTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarget.Location = New System.Drawing.Point(168, 315)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(100, 26)
        Me.txtTarget.TabIndex = 12
        '
        'btnFutureValue
        '
        Me.btnFutureValue.BackColor = System.Drawing.Color.LimeGreen
        Me.btnFutureValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFutureValue.Location = New System.Drawing.Point(132, 200)
        Me.btnFutureValue.Name = "btnFutureValue"
        Me.btnFutureValue.Size = New System.Drawing.Size(175, 36)
        Me.btnFutureValue.TabIndex = 11
        Me.btnFutureValue.Text = "Calculate future value"
        Me.btnFutureValue.UseVisualStyleBackColor = False
        '
        'btnTimeToTarget
        '
        Me.btnTimeToTarget.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnTimeToTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeToTarget.Location = New System.Drawing.Point(87, 347)
        Me.btnTimeToTarget.Name = "btnTimeToTarget"
        Me.btnTimeToTarget.Size = New System.Drawing.Size(261, 42)
        Me.btnTimeToTarget.TabIndex = 13
        Me.btnTimeToTarget.Text = "Calculate how long to reach target"
        Me.btnTimeToTarget.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(402, 499)
        Me.Controls.Add(Me.btnTimeToTarget)
        Me.Controls.Add(Me.btnFutureValue)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.txtCycles)
        Me.Controls.Add(Me.txtGrowth)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Money Growth"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtGrowth As TextBox
    Friend WithEvents txtCycles As TextBox
    Friend WithEvents txtTarget As TextBox
    Friend WithEvents btnFutureValue As Button
    Friend WithEvents btnTimeToTarget As Button
End Class
