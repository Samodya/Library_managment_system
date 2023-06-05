<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mngBooks
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtBookname = New System.Windows.Forms.TextBox()
        Me.txtAuth = New System.Windows.Forms.TextBox()
        Me.txtLang = New System.Windows.Forms.TextBox()
        Me.txtPublish = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtPage = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.dtpreg_date = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStat = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnExt = New System.Windows.Forms.Button()
        Me.dgvBookM = New System.Windows.Forms.DataGridView()
        Me.isbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.language = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.publisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.catogory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reg_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dgvBookM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Book Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Author:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Language:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Publisher:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Catagory:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 164)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "No of Pages:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(345, 167)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(74, 234)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Added Date:"
        '
        'txtISBN
        '
        Me.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtISBN.Location = New System.Drawing.Point(173, 59)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(149, 22)
        Me.txtISBN.TabIndex = 1
        '
        'txtBookname
        '
        Me.txtBookname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBookname.Location = New System.Drawing.Point(478, 59)
        Me.txtBookname.Name = "txtBookname"
        Me.txtBookname.Size = New System.Drawing.Size(149, 22)
        Me.txtBookname.TabIndex = 1
        '
        'txtAuth
        '
        Me.txtAuth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAuth.Location = New System.Drawing.Point(173, 95)
        Me.txtAuth.Name = "txtAuth"
        Me.txtAuth.Size = New System.Drawing.Size(149, 22)
        Me.txtAuth.TabIndex = 1
        '
        'txtLang
        '
        Me.txtLang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLang.Location = New System.Drawing.Point(478, 95)
        Me.txtLang.Name = "txtLang"
        Me.txtLang.Size = New System.Drawing.Size(149, 22)
        Me.txtLang.TabIndex = 1
        '
        'txtPublish
        '
        Me.txtPublish.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPublish.Location = New System.Drawing.Point(173, 131)
        Me.txtPublish.Name = "txtPublish"
        Me.txtPublish.Size = New System.Drawing.Size(149, 22)
        Me.txtPublish.TabIndex = 1
        '
        'txtCat
        '
        Me.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCat.Location = New System.Drawing.Point(478, 131)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(149, 22)
        Me.txtCat.TabIndex = 1
        '
        'txtPage
        '
        Me.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPage.Location = New System.Drawing.Point(173, 166)
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Size = New System.Drawing.Size(149, 22)
        Me.txtPage.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice.Location = New System.Drawing.Point(478, 166)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(149, 22)
        Me.txtPrice.TabIndex = 1
        '
        'dtpreg_date
        '
        Me.dtpreg_date.Location = New System.Drawing.Point(180, 231)
        Me.dtpreg_date.Name = "dtpreg_date"
        Me.dtpreg_date.Size = New System.Drawing.Size(356, 29)
        Me.dtpreg_date.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(699, 59)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 36)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Book"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(74, 199)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 21)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Status:"
        '
        'txtStat
        '
        Me.txtStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStat.Enabled = False
        Me.txtStat.Location = New System.Drawing.Point(173, 201)
        Me.txtStat.Name = "txtStat"
        Me.txtStat.Size = New System.Drawing.Size(149, 22)
        Me.txtStat.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(838, 59)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 36)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(699, 114)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(121, 36)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.Red
        Me.btnExt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExt.Location = New System.Drawing.Point(838, 114)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(121, 36)
        Me.btnExt.TabIndex = 3
        Me.btnExt.Text = "Exit"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'dgvBookM
        '
        Me.dgvBookM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.isbn, Me.bookname, Me.author, Me.language, Me.publisher, Me.catogory, Me.pages, Me.price, Me.Status, Me.reg_date})
        Me.dgvBookM.Location = New System.Drawing.Point(74, 285)
        Me.dgvBookM.Name = "dgvBookM"
        Me.dgvBookM.RowTemplate.Height = 25
        Me.dgvBookM.Size = New System.Drawing.Size(914, 318)
        Me.dgvBookM.TabIndex = 6
        '
        'isbn
        '
        Me.isbn.HeaderText = "ISBN"
        Me.isbn.Name = "isbn"
        Me.isbn.ReadOnly = True
        Me.isbn.Width = 60
        '
        'bookname
        '
        Me.bookname.HeaderText = "Book Name"
        Me.bookname.Name = "bookname"
        Me.bookname.ReadOnly = True
        Me.bookname.Width = 120
        '
        'author
        '
        Me.author.HeaderText = "Author"
        Me.author.Name = "author"
        Me.author.ReadOnly = True
        Me.author.Width = 120
        '
        'language
        '
        Me.language.HeaderText = "Language"
        Me.language.Name = "language"
        Me.language.ReadOnly = True
        Me.language.Width = 80
        '
        'publisher
        '
        Me.publisher.HeaderText = "Publisher"
        Me.publisher.Name = "publisher"
        Me.publisher.ReadOnly = True
        '
        'catogory
        '
        Me.catogory.HeaderText = "Catagory"
        Me.catogory.Name = "catogory"
        Me.catogory.ReadOnly = True
        Me.catogory.Width = 80
        '
        'pages
        '
        Me.pages.HeaderText = "No of Pages"
        Me.pages.Name = "pages"
        Me.pages.Width = 60
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 50
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'reg_date
        '
        Me.reg_date.HeaderText = "Date"
        Me.reg_date.Name = "reg_date"
        Me.reg_date.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(542, 231)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 29)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Visible = False
        '
        'mngBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 630)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvBookM)
        Me.Controls.Add(Me.txtStat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpreg_date)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.txtLang)
        Me.Controls.Add(Me.txtPage)
        Me.Controls.Add(Me.txtPublish)
        Me.Controls.Add(Me.txtAuth)
        Me.Controls.Add(Me.txtBookname)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mngBooks"
        Me.Text = "Manage Book"
        CType(Me.dgvBookM, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtBookname As TextBox
    Friend WithEvents txtAuth As TextBox
    Friend WithEvents txtLang As TextBox
    Friend WithEvents txtPublish As TextBox
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtPage As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents dtpreg_date As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStat As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnExt As Button
    Friend WithEvents dgvBookM As DataGridView
    Friend WithEvents isbn As DataGridViewTextBoxColumn
    Friend WithEvents bookname As DataGridViewTextBoxColumn
    Friend WithEvents author As DataGridViewTextBoxColumn
    Friend WithEvents language As DataGridViewTextBoxColumn
    Friend WithEvents publisher As DataGridViewTextBoxColumn
    Friend WithEvents catogory As DataGridViewTextBoxColumn
    Friend WithEvents pages As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents reg_date As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
End Class
