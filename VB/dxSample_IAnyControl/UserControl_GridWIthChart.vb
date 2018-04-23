Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Namespace dxSample_IAnyControl.IAny_Files
	Partial Public Class UserControl_GridWithChart
		Inherits UserControl

		Private ReadOnly Property ChartSeries() As SeriesBase
			Get
				If chartControl1.Series.Count = 0 Then
					CreateChartSeries(chartControl1)
				End If
				Return chartControl1.Series("PieSeries")
			End Get
		End Property
		Private Sub CreateChartSeries(ByVal chart As ChartControl)
			chart.Series.Add("PieSeries", ViewType.Pie)
		End Sub
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub UC_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.DataSource = DataHelper.GetData()
			InitChartSeries(ChartSeries)
			CreateChartEdit(colSales, chartControl1)
		End Sub
		Private Sub InitChartSeries(ByVal chartSeries As SeriesBase)
			If chartSeries Is Nothing Then
				Return
			End If
			Me.ChartSeries.LegendTextPattern = "{A}"
			Me.ChartSeries.ArgumentDataMember = "CategoryName"
			Me.ChartSeries.ValueDataMembers.AddRange("Quantity")
		End Sub
		Private Shared Sub CreateChartEdit(ByVal column As GridColumn, ByVal chartControl As ChartControl)
			If column.ColumnEdit IsNot Nothing Then
				Return
			End If
			Dim item As New RepositoryItemAnyControl()
			item.Control = New EmbeddedChartControl(chartControl)
			column.View.GridControl.RepositoryItems.Add(item)
			CType(column.View, GridView).OptionsSelection.EnableAppearanceHideSelection = False
			column.OptionsColumn.AllowEdit = False
			column.OptionsFilter.AllowFilter = False
			column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			column.ColumnEdit = item
		End Sub
	End Class
End Namespace
