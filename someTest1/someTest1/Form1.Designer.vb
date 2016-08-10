<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("针脚当前值")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("针脚标准值")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("转动中心")
        Me.list_pra = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.txt_2 = New System.Windows.Forms.TextBox()
        Me.txt_3 = New System.Windows.Forms.TextBox()
        Me.txt_4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cbxTest = New System.Windows.Forms.TextBox()
        Me.cbx_handNormalStatus = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_openFile = New System.Windows.Forms.Button()
        Me.txt_OpenFilePath = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'list_pra
        '
        Me.list_pra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.list_pra.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.list_pra.FullRowSelect = True
        Me.list_pra.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.list_pra.Location = New System.Drawing.Point(23, 81)
        Me.list_pra.Name = "list_pra"
        Me.list_pra.Size = New System.Drawing.Size(684, 135)
        Me.list_pra.TabIndex = 2
        Me.list_pra.UseCompatibleStateImageBehavior = False
        Me.list_pra.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "项目"
        Me.ColumnHeader1.Width = 119
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "X(P)"
        Me.ColumnHeader2.Width = 121
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Y(P)"
        Me.ColumnHeader3.Width = 116
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "角度(deg)"
        Me.ColumnHeader4.Width = 114
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 231)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(51, 228)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(65, 12)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(16, 274)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(100, 21)
        Me.txt_1.TabIndex = 14
        '
        'txt_2
        '
        Me.txt_2.Location = New System.Drawing.Point(122, 274)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(100, 21)
        Me.txt_2.TabIndex = 14
        '
        'txt_3
        '
        Me.txt_3.Location = New System.Drawing.Point(228, 274)
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(100, 21)
        Me.txt_3.TabIndex = 14
        '
        'txt_4
        '
        Me.txt_4.Location = New System.Drawing.Point(334, 274)
        Me.txt_4.Name = "txt_4"
        Me.txt_4.Size = New System.Drawing.Size(100, 21)
        Me.txt_4.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(441, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(441, 318)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "read"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 432)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 17
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(194, 430)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(275, 430)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 17
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(531, 432)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cbxTest)
        Me.GroupBox1.Controls.Add(Me.cbx_handNormalStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(732, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 158)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "combobox-slectItem测试"
        '
        'txt_cbxTest
        '
        Me.txt_cbxTest.Location = New System.Drawing.Point(36, 82)
        Me.txt_cbxTest.Name = "txt_cbxTest"
        Me.txt_cbxTest.Size = New System.Drawing.Size(100, 21)
        Me.txt_cbxTest.TabIndex = 11
        '
        'cbx_handNormalStatus
        '
        Me.cbx_handNormalStatus.FormattingEnabled = True
        Me.cbx_handNormalStatus.Items.AddRange(New Object() {"常开", "常闭"})
        Me.cbx_handNormalStatus.Location = New System.Drawing.Point(34, 33)
        Me.cbx_handNormalStatus.Name = "cbx_handNormalStatus"
        Me.cbx_handNormalStatus.Size = New System.Drawing.Size(91, 20)
        Me.cbx_handNormalStatus.TabIndex = 10
        Me.cbx_handNormalStatus.Text = "常开"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_openFile)
        Me.GroupBox2.Controls.Add(Me.txt_OpenFilePath)
        Me.GroupBox2.Location = New System.Drawing.Point(721, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 133)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "打开文件的实验"
        '
        'btn_openFile
        '
        Me.btn_openFile.Location = New System.Drawing.Point(47, 100)
        Me.btn_openFile.Name = "btn_openFile"
        Me.btn_openFile.Size = New System.Drawing.Size(75, 23)
        Me.btn_openFile.TabIndex = 1
        Me.btn_openFile.Text = "Button6"
        Me.btn_openFile.UseVisualStyleBackColor = True
        '
        'txt_OpenFilePath
        '
        Me.txt_OpenFilePath.Location = New System.Drawing.Point(11, 26)
        Me.txt_OpenFilePath.Multiline = True
        Me.txt_OpenFilePath.Name = "txt_OpenFilePath"
        Me.txt_OpenFilePath.Size = New System.Drawing.Size(183, 68)
        Me.txt_OpenFilePath.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(768, 401)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "chart"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 548)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_4)
        Me.Controls.Add(Me.txt_3)
        Me.Controls.Add(Me.txt_2)
        Me.Controls.Add(Me.txt_1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.list_pra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents list_pra As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_4 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cbxTest As System.Windows.Forms.TextBox
    Friend WithEvents cbx_handNormalStatus As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_openFile As System.Windows.Forms.Button
    Friend WithEvents txt_OpenFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
