'Imports System.Web '.'Script.Serialization
Imports System.IO

Public Class Form1
    Dim a As Integer
    Dim cla1 As Class1
    Dim test1 As test
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        test1 = New test
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        list_pra.Items.Item(0).SubItems.Clear()
        list_pra.Items.Item(0).Text = "a"
        list_pra.Items.Item(0).SubItems.Add(a)
        list_pra.Items.Item(0).SubItems.Add(a + 1)
        list_pra.Items.Item(0).SubItems.Add(a + 2)
        list_pra.Items.Item(1).SubItems.Clear()
        list_pra.Items.Item(1).Text = "a2"
        list_pra.Items.Item(1).SubItems.Add(a)
        list_pra.Items.Item(1).SubItems.Add(a + 3)
        list_pra.Items.Item(1).SubItems.Add(a + 4)
        a = a + 1

      


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
dim masas as integer =0

    End Sub

    Private Sub list_pra_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles list_pra.SelectedIndexChanged
        Dim asa As Integer
        Dim a1 As Object
        'asa = list_pra.ListItems(list_pra.SelectedItem.Index).Text

        a1 = list_pra.SelectedItems
        txt_1.Text = a1.ToString

        If list_pra.SelectedItems.Count > 0 Then
            If list_pra.SelectedItems(0).SubItems IsNot Nothing Then
                If list_pra.SelectedItems(0).SubItems.Count = 4 Then
                    txt_1.Text = list_pra.SelectedItems(0).SubItems(0).Text
                    txt_2.Text = list_pra.SelectedItems(0).SubItems(1).Text
                    txt_3.Text = list_pra.SelectedItems(0).SubItems(2).Text
                    txt_4.Text = list_pra.SelectedItems(0).SubItems(3).Text
                End If
            End If
        End If

        test1.a1 = txt_1.Text
        test1.a2 = txt_2.Text
        test1.a3 = txt_3.Text
        test1.a4 = txt_4.Text


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim mpath As String = System.IO.Path.Combine(Environment.CurrentDirectory, "config1\") '"config\123.json"
        Dim path1file As String = Path.Combine(mpath, "123.json")
        If Not Directory.Exists(mpath) Then
            Dim strdir2 As DirectoryInfo = Directory.CreateDirectory(mpath)
        End If
        do_SaveData(path1file, test1)
    End Sub
    Sub do_SaveData(ByVal vPath As String, ByVal vClassType As test)
        Dim _jsConvert As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim _json As String = _jsConvert.Serialize(vClassType)

        File.WriteAllText(vPath, _json)
    End Sub

    Public Sub do_ReadData(ByVal vPath As String, ByRef vClassType As test)
        Dim _jsConvert As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim _str As String = File.ReadAllText(vPath)
        vClassType = _jsConvert.Deserialize(Of test)(_str) '

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim mpath As String = System.IO.Path.Combine(Environment.CurrentDirectory, "config.json")

        do_ReadData(mpath, test1)
        txt_1.Text = test1.a1 + "100"
        txt_2.Text = test1.a2 + "100"
        txt_3.Text = test1.a3 + "100"
        txt_4.Text = test1.a4 + "100"



    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim temp As Integer
        temp = Integer.Parse(Val(TextBox1.Text))

        TextBox2.Text = temp

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Then 'e.KeyChar = Chr(8) Or e.KeyChar = "." 
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim cls2 As New Class2

        cls2.sub1(Class2.pra.two)

    End Sub

    Private Sub cbx_handNormalStatus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbx_handNormalStatus.SelectedIndexChanged
        txt_cbxTest.Text = cbx_handNormalStatus.SelectedIndex
    End Sub

    Private Sub btn_openFile_Click(sender As System.Object, e As System.EventArgs) Handles btn_openFile.Click
        ' txt_OpenFilePath.Text = OpenFileDialog1.ShowDialog()
        Dim myStream As System.IO.Stream

        OpenFileDialog1.InitialDirectory = "D:\"
        OpenFileDialog1.Filter = "CSV files (*.CSV)|*.CSV|Excel files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' MsgBox(OpenFileDialog1.FileName)
            txt_OpenFilePath.Text = OpenFileDialog1.FileName
            myStream = OpenFileDialog1.OpenFile()
            If Not (myStream Is Nothing) Then
                ' MessageBox.Show(myStream.Length.ToString)
                '  myStream.Close()
            End If

            If File.Exists(txt_OpenFilePath.Text) Then
                Dim _stra_dxf As String = My.Application.Info.DirectoryPath & "\shishishis1.xlsx"
                File.Copy(txt_OpenFilePath.Text, _stra_dxf)  '复制并重命名文件

            End If
        End If


        '2.


        '3
        ' Directory .



    End Sub

    Private Sub btn_openFile_DoubleClick(sender As Object, e As System.EventArgs) Handles btn_openFile.DoubleClick

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim frm As Form2
        frm = New Form2
        Me.ShowInTaskbar = False
        Me.Opacity = 0

        frm.ShowDialog()
        Me.Opacity = 1
        Me.ShowInTaskbar = True
    End Sub
End Class
Public Class test
    Public a1 As String
    Public a2 As String
    Public a3 As String
    Public a4 As String
    Public ab1 As testB
    Public Sub New()
        ab1 = New testB
        ab1.b1 = "bb1"
        ab1.b2 = "bb2"
        ab1.b3 = "bb3"
        ab1.b4 = "bb4"
    End Sub

End Class
Public Class testB
    Public b1 As String
    Public b2 As String
    Public b3 As String
    Public b4 As String
End Class
