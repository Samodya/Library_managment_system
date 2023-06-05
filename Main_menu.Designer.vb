<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_menu
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
        Me.btnAddmember = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddmember
        '
        Me.btnAddmember.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddmember.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddmember.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddmember.Location = New System.Drawing.Point(510, 188)
        Me.btnAddmember.Name = "btnAddmember"
        Me.btnAddmember.Size = New System.Drawing.Size(247, 49)
        Me.btnAddmember.TabIndex = 0
        Me.btnAddmember.Text = "Manage Members"
        Me.btnAddmember.UseVisualStyleBackColor = False
        '
        'btnBooks
        '
        Me.btnBooks.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBooks.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBooks.Location = New System.Drawing.Point(510, 243)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(247, 49)
        Me.btnBooks.TabIndex = 0
        Me.btnBooks.Text = "Manage Books"
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnexit.Location = New System.Drawing.Point(510, 298)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(247, 49)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnBooks)
        Me.Controls.Add(Me.btnAddmember)
        Me.Location = New System.Drawing.Point(498, 284)
        Me.Name = "Main_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddmember As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnexit As Button
End Class
