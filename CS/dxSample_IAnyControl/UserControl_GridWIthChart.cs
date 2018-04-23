using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace dxSample_IAnyControl.IAny_Files {
    public partial class UserControl_GridWithChart : UserControl {
        private SeriesBase ChartSeries {
            get {
                if (chartControl1.Series.Count == 0) {
                    CreateChartSeries(chartControl1);
                }
                return chartControl1.Series["PieSeries"];
            }
        }
        private void CreateChartSeries(ChartControl chart) {
            chart.Series.Add("PieSeries", ViewType.Pie);
        }
        public UserControl_GridWithChart() {
            InitializeComponent();
        }
        private void UC_Load(object sender, EventArgs e) {
            gridControl1.DataSource = DataHelper.GetData();
            InitChartSeries(ChartSeries);
            CreateChartEdit(colSales, chartControl1);
        }
        private void InitChartSeries(SeriesBase chartSeries) {
            if (chartSeries == null) {
                return;
            }
            ChartSeries.LegendTextPattern = "{A}";
            ChartSeries.ArgumentDataMember = "CategoryName";
            ChartSeries.ValueDataMembers.AddRange("Quantity");
        }
        private static void CreateChartEdit(GridColumn column, ChartControl chartControl) {
            if (column.ColumnEdit != null) {
                return;
            }
            RepositoryItemAnyControl item = new RepositoryItemAnyControl();
            item.Control = new EmbeddedChartControl(chartControl);
            column.View.GridControl.RepositoryItems.Add(item);
            ((GridView)column.View).OptionsSelection.EnableAppearanceHideSelection = false;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsFilter.AllowFilter = false;
            column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            column.ColumnEdit = item;
        }
    }
}
