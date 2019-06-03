Namespace dxSample_IAnyControl.IAny_Files
	Partial Public Class UserControl_GridWithChart
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colPersonLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPersonFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPersonTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colHomePhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colHireDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.colPersonID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colSales = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.gridControl1)
			Me.layoutControl1.Controls.Add(Me.chartControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(497, 176, 534, 545)
			Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
			Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25F)
			Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
			Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
			Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
			Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
			Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.layoutControl1.Root = Me.Root
			Me.layoutControl1.Size = New System.Drawing.Size(696, 633)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(12, 12)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemDateEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(672, 420)
			Me.gridControl1.TabIndex = 6
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colPersonID, Me.colPersonFirstName, Me.colPersonLastName, Me.colSales, Me.colPersonTitle, Me.colHireDate, Me.colHomePhone})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
			Me.advBandedGridView1.OptionsView.ShowColumnHeaders = False
			Me.advBandedGridView1.RowHeight = 50
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Contact Information"
			Me.gridBand1.Columns.Add(Me.colPersonLastName)
			Me.gridBand1.Columns.Add(Me.colPersonFirstName)
			Me.gridBand1.Columns.Add(Me.colPersonTitle)
			Me.gridBand1.Columns.Add(Me.colHomePhone)
			Me.gridBand1.Columns.Add(Me.colHireDate)
			Me.gridBand1.Columns.Add(Me.colPersonID)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.VisibleIndex = 0
			Me.gridBand1.Width = 262
			' 
			' colPersonLastName
			' 
			Me.colPersonLastName.Caption = "Person last name"
			Me.colPersonLastName.FieldName = "PersonLastName"
			Me.colPersonLastName.Name = "colPersonLastName"
			Me.colPersonLastName.OptionsColumn.AllowEdit = False
			Me.colPersonLastName.Visible = True
			Me.colPersonLastName.Width = 131
			' 
			' colPersonFirstName
			' 
			Me.colPersonFirstName.Caption = "Person first name"
			Me.colPersonFirstName.FieldName = "PersonFirstName"
			Me.colPersonFirstName.Name = "colPersonFirstName"
			Me.colPersonFirstName.OptionsColumn.AllowEdit = False
			Me.colPersonFirstName.Visible = True
			Me.colPersonFirstName.Width = 131
			' 
			' colPersonTitle
			' 
			Me.colPersonTitle.Caption = "Title"
			Me.colPersonTitle.FieldName = "PersonTitle"
			Me.colPersonTitle.Name = "colPersonTitle"
			Me.colPersonTitle.OptionsColumn.AllowEdit = False
			Me.colPersonTitle.RowIndex = 1
			Me.colPersonTitle.Visible = True
			Me.colPersonTitle.Width = 45
			' 
			' colHomePhone
			' 
			Me.colHomePhone.Caption = "Home phone"
			Me.colHomePhone.FieldName = "HomePhone"
			Me.colHomePhone.Name = "colHomePhone"
			Me.colHomePhone.OptionsColumn.AllowEdit = False
			Me.colHomePhone.RowIndex = 2
			Me.colHomePhone.Visible = True
			Me.colHomePhone.Width = 154
			' 
			' colHireDate
			' 
			Me.colHireDate.Caption = "Hire Date"
			Me.colHireDate.ColumnEdit = Me.repositoryItemDateEdit1
			Me.colHireDate.FieldName = "HireDate"
			Me.colHireDate.Name = "colHireDate"
			Me.colHireDate.OptionsColumn.AllowEdit = False
			Me.colHireDate.RowIndex = 3
			Me.colHireDate.Visible = True
			Me.colHireDate.Width = 125
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			' 
			' colPersonID
			' 
			Me.colPersonID.Caption = "Person ID"
			Me.colPersonID.FieldName = "PersonID"
			Me.colPersonID.Name = "colPersonID"
			Me.colPersonID.RowIndex = 4
			Me.colPersonID.Width = 378
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "% sales by Product Category"
			Me.gridBand2.Columns.Add(Me.colSales)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.VisibleIndex = 1
			Me.gridBand2.Width = 348
			' 
			' colSales
			' 
			Me.colSales.AutoFillDown = True
			Me.colSales.Caption = "% sales by Product Category"
			Me.colSales.FieldName = "SalesByProductCategory"
			Me.colSales.Name = "colSales"
			Me.colSales.Visible = True
			Me.colSales.Width = 348
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' chartControl1
			' 
			Me.chartControl1.Location = New System.Drawing.Point(12, 436)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			pieSeriesView1.RuntimeExploding = False
			pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
			Me.chartControl1.SeriesTemplate.View = pieSeriesView1
			Me.chartControl1.Size = New System.Drawing.Size(272, 185)
			Me.chartControl1.TabIndex = 4
			' 
			' Root
			' 
			Me.Root.CustomizationFormText = "Root"
			Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.Root.GroupBordersVisible = False
			Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.layoutControlItem3})
			Me.Root.Location = New System.Drawing.Point(0, 0)
			Me.Root.Name = "Root"
			Me.Root.Size = New System.Drawing.Size(696, 633)
			Me.Root.Text = "Root"
			Me.Root.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.chartControl1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 424)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(276, 189)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			Me.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(276, 424)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(400, 189)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.gridControl1
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(676, 424)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' UserControl_GridWithChart
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "UserControl_GridWithChart"
			Me.Size = New System.Drawing.Size(696, 633)
'			Me.Load += New System.EventHandler(Me.UC_Load)
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private Root As DevExpress.XtraLayout.LayoutControlGroup
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private colPersonLastName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPersonID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPersonFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colSales As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPersonTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colHireDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private colHomePhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	End Class
End Namespace
