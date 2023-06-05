<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.txtun = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtun
        '
        Me.txtun.BackColor = System.Drawing.SystemColors.Window
        Me.txtun.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtun.Location = New System.Drawing.Point(171, 180)
        Me.txtun.Name = "txtun"
        Me.txtun.Size = New System.Drawing.Size(254, 23)
        Me.txtun.TabIndex = 6
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(171, 247)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpw.Size = New System.Drawing.Size(254, 23)
        Me.txtpw.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Username"
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.Yellow
        Me.btnLog.Location = New System.Drawing.Point(195, 308)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(170, 26)
        Me.btnLog.TabIndex = 3
        Me.btnLog.Text = "Register User"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 514)
        Me.Controls.Add(Me.txtun)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLog)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtun As TextBox
    Friend WithEvents txtpw As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLog As Button
End Class
