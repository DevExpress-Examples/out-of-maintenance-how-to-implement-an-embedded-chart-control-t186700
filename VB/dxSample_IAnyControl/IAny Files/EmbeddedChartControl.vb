Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.CustomEditor
Imports System.Drawing
Imports System.ComponentModel
Imports System.Collections


Namespace dxSample_IAnyControl
	<ToolboxItem(False)>
	Friend Class EmbeddedChartControl
		Inherits Control
		Implements IAnyControlEdit, ICloneable

		Private _EditValue As Object
		Private _Chart As ChartControl
		Public Sub New()
		End Sub
		Public Sub New(ByVal chart As ChartControl)
			AddChart(chart)
		End Sub
		Public Property RecommendedSize() As Size
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)>
		Public ReadOnly Property Chart() As ChartControl
			Get
				Return _Chart
			End Get
		End Property
		Public Sub AddChart(ByVal chart As ChartControl)
			If _Chart IsNot Nothing Then
				_Chart.Dispose()
			End If
			_Chart = chart
			RecommendedSize = chart.Size
			_Chart.Parent = Me
			_Chart.Dock = DockStyle.Fill
		End Sub
		Protected Overrides Sub OnBackColorChanged(ByVal e As EventArgs)
			MyBase.OnBackColorChanged(e)
			If Chart IsNot Nothing Then
				Chart.BackColor = BackColor
			End If
		End Sub
		Public Function Clone() As Object Implements ICloneable.Clone
			Dim c As New EmbeddedChartControl()
			If Chart IsNot Nothing Then
				c.AddChart(TryCast(Chart.Clone(), ChartControl))
				c.RecommendedSize = RecommendedSize
			End If
			Return c
		End Function
		Private Event _EditValueChanged As EventHandler
		Public Custom Event EditValueChanged As EventHandler Implements IAnyControlEdit.EditValueChanged
			AddHandler(ByVal value As EventHandler)
				AddHandler _EditValueChanged, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler _EditValueChanged, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
				RaiseEvent _EditValueChanged(sender, e)
			End RaiseEvent
		End Event
		Public ReadOnly Property AllowBitmapCache() As Boolean Implements IAnyControlEdit.AllowBitmapCache
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property AllowBorder() As Boolean Implements IAnyControlEdit.AllowBorder
			Get
				Return True
			End Get
		End Property

		Public Function AllowClick(ByVal point As Point) As Boolean Implements IAnyControlEdit.AllowClick
			Return False
		End Function

		Public Function CalcSize(ByVal g As Graphics) As Size Implements IAnyControlEdit.CalcSize
			Return RecommendedSize
		End Function

		Public Sub Draw(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal viewInfo As AnyControlEditViewInfo) Implements IAnyControlEdit.Draw
		End Sub

		Public Property EditValue() As Object Implements IAnyControlEdit.EditValue
			Get
				Return _EditValue
			End Get
			Set(ByVal value As Object)
				If value Is _EditValue Then
					Return
				End If
				_EditValue = value
				OnEditValueChanging(value)
			End Set
		End Property
		Private Sub OnEditValueChanging(ByVal value As Object)
			If Chart Is Nothing Then
				Return
			End If
			If TypeOf value Is IList OrElse value Is Nothing Then
				Chart.DataSource = value
			End If
		End Sub


		Public Function GetDisplayText(ByVal EditValue As Object) As String Implements IAnyControlEdit.GetDisplayText
			Return RepositoryItemAnyControl.GetBasicDisplayText(EditValue)
		End Function

		Public Function IsNeededKey(ByVal e As KeyEventArgs) As Boolean Implements IAnyControlEdit.IsNeededKey
			Return False
		End Function

		Public Sub SetupAsDrawControl() Implements IAnyControlEdit.SetupAsDrawControl
		End Sub

		Public Sub SetupAsEditControl() Implements IAnyControlEdit.SetupAsEditControl
		End Sub

		Public ReadOnly Property SupportsDraw() As Boolean Implements IAnyControlEdit.SupportsDraw
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace
