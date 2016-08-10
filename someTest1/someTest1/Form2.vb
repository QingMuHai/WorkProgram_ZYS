Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading
Imports System.Threading.Thread
Imports System.Math

Public Class Form2
    Dim Chartdisplaythread As Thread

#Region "图表显示"

    Private _productnumcount As Object

    Private Property productnumcount(i As Integer) As Object
        Get
            Return _productnumcount
        End Get
        Set(value As Object)
            _productnumcount = value
        End Set
    End Property

    Private Sub Chartsub()
        Chart1.ChartAreas.Clear()
        Dim newchartareas1 As New ChartArea("default1")
        '  Chart1.BackColor = Color.White
        Chart1.ChartAreas.Add(newchartareas1)
        Chart1.ChartAreas("default1").AxisX.IsMarginVisible = True
        Chart1.ChartAreas("default1").AxisX.Title = "时间"
        Chart1.ChartAreas("default1").AxisY.Title = "数量"
        Chart1.ChartAreas("default1").AxisX.Interval = 1
        'Chart1.ChartAreas("default1").AxisY.Interval = 1
        ' Chart1.ChartAreas("default1").AxisX.LineDashStyle = ChartDashStyle.Solid
        ' Chart1.ChartAreas("default1").AxisY.LineDashStyle = ChartDashStyle.Solid
        Chart1.ChartAreas("default1").AxisX.Minimum = 0
        Dim fonta As System.Drawing.Font
        fonta = New System.Drawing.Font("宋体", 16)
        Chart1.ChartAreas("default1").AxisX.TitleFont = fonta
        Chart1.ChartAreas("default1").AxisY.TitleFont = fonta
        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        Dim series1 As New Series("小时产量")
        series1.ChartType = SeriesChartType.Column
        series1.Color = Color.DimGray
        series1.XAxisType = AxisType.Primary
        series1.YAxisType = AxisType.Primary
        Chart1.ChartAreas(0).Axes(0).MajorGrid.LineColor = Color.Transparent
        Chart1.ChartAreas(0).Axes(1).MajorGrid.LineColor = Color.Transparent
        Chart1.ChartAreas(0).ShadowOffset = 15
        Chart1.ChartAreas(0).BackColor = Color.Transparent

        Chart1.Series.Add(series1)
        ' series1.IsValueShownAsLabel = True
        ' Chart1.Palette = ChartColorPalette.SeaGreen
        series1.ChartType = SeriesChartType.Spline  ' SeriesChartType.SplineArea 'SeriesChartType.Column SeriesChartType.Spline  '
        series1.Color = Color.DarkRed
        series1.Palette = ChartColorPalette.None
        ' ChartColorPalette.SeaGreen
        ''添加第二种数据图
        'Dim series2 As New Series("小时不良数")
        'series2.ChartType = SeriesChartType.Line
        'series2.IsValueShownAsLabel = True
        'series2.XAxisType = AxisType.Primary
        'series2.YAxisType = AxisType.Secondary
        'series2.Color = Color.DarkRed
        'Chart1.Series.Add(series2)
        Chartdisplaythread = (New System.Threading.Thread(AddressOf Chartdisplaysub))
        Chartdisplaythread.Start()
    End Sub
    Dim flag As Boolean

    Private Sub Chartdisplaysub()
        Do While Flag
            Me.Invoke(New eventhandler(AddressOf Chartdisplaytimer))
            Thread.Sleep(threadTime)
        Loop
    End Sub
    Dim a As Double

    Private Sub Chartdisplaytimer()
        Dim i As Integer

        Chart1.Series("小时产量").Points.Clear()
        For i = 0 To 23
            productnumcount(i) = 100 * Sin(a) '* Sin(a)Abs()
            a += amount ' 0.1
            'If i = 12 Then
            '    productnumcount(i) = 150
            'End If

            productnumcount(i) = Round(productnumcount(i), 1)
            Chart1.Series("小时产量").Points.AddXY(i, productnumcount(i)) 'useful
            Chart1.Series("小时产量").Points.AddY(200)
            Chart1.Series("小时产量").Points.AddY(-200)
        Next
    End Sub
#End Region

    Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Chartdisplaythread.Abort()

        flag = False
        ' Sleep(500)
    End Sub

    Private Sub Form2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Chartsub()
        flag = True
    End Sub
    Dim threadTime As Integer = 5
    Dim amount As Double = 0.01
    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        threadTime = TrackBar1.Value
        TextBox1.Text = threadTime

    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar2.Scroll
        amount = TrackBar2.Value / 100
        TextBox2.Text = amount

    End Sub
End Class