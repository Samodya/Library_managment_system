<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mngMembers
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
        Me.btnMstudent = New System.Windows.Forms.Button()
        Me.btmMStaff = New System.Windows.Forms.Button()
        Me.btnMLec = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMstudent
        '
        Me.btnMstudent.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnMstudent.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMstudent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMstudent.Location = New System.Drawing.Point(498, 113)
        Me.btnMstudent.Name = "btnMstudent"
        Me.btnMstudent.Size = New System.Drawing.Size(229, 51)
        Me.btnMstudent.TabIndex = 0
        Me.btnMstudent.Text = "Manage Student"
        Me.btnMstudent.UseVisualStyleBackColor = False
        '
        'btmMStaff
        '
        Me.btmMStaff.BackColor = System.Drawing.SystemColors.Highlight
        Me.btmMStaff.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btmMStaff.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btmMStaff.Location = New System.Drawing.Point(498, 170)
        Me.btmMStaff.Name = "btmMStaff"
        Me.btmMStaff.Size = New System.Drawing.Size(229, 51)
        Me.btmMStaff.TabIndex = 0
        Me.btmMStaff.Text = "Manage Staff"
        Me.btmMStaff.UseVisualStyleBackColor = False
        '
        'btnMLec
        '
        Me.btnMLec.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnMLec.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMLec.ForeColor = System.Drawing.Color.White
        Me.btnMLec.Location = New System.Drawing.Point(498, 227)
        Me.btnMLec.Name = "btnMLec"
        Me.btnMLec.Size = New System.Drawing.Size(229, 51)
        Me.btnMLec.TabIndex = 0
        Me.btnMLec.Text = "Manage Lecturer"
        Me.btnMLec.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnexit.Location = New System.Drawing.Point(498, 284)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(229, 49)
        Me.btnexit.TabIndex = 1
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'mngMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnMLec)
        Me.Controls.Add(Me.btmMStaff)
        Me.Controls.Add(Me.btnMstudent)
        Me.Name = "mngMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Members"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMstudent As Button
    Friend WithEvents btmMStaff As Button
    Friend WithEvents btnMLec As Button
    Friend WithEvents btnexit As Button
End Class
