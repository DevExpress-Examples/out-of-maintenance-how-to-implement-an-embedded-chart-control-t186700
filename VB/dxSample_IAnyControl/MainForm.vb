Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports dxSample_IAnyControl.IAny_Files

Namespace dxSample_IAnyControl
	Partial Public Class MainForm
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim test As New UserControl_GridWithChart()
			test.Location = New Point(0, 0)
			test.Dock = DockStyle.Fill
			Controls.Add(test)
		End Sub
	End Class
End Namespace
