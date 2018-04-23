using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.CustomEditor;
using System.Drawing;
using System.ComponentModel;
using System.Collections;


namespace dxSample_IAnyControl {
    [ToolboxItem(false)]
    internal class EmbeddedChartControl : Control, IAnyControlEdit, ICloneable {
        private object _EditValue;
        private ChartControl _Chart;
        public EmbeddedChartControl() {
        }
        public EmbeddedChartControl(ChartControl chart) {
            AddChart(chart);
        }
        public Size RecommendedSize { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        Browsable(false)]
        public ChartControl Chart {
            get {
                return _Chart;
            }
        }
        public void AddChart(ChartControl chart) {
            if (_Chart != null) {
                _Chart.Dispose();
            }
            _Chart = chart;
            RecommendedSize = chart.Size;
            _Chart.Parent = this;
            _Chart.Dock = DockStyle.Fill;
        }
        protected override void OnBackColorChanged(EventArgs e) {
            base.OnBackColorChanged(e);
            if (Chart != null) {
                Chart.BackColor = BackColor;
            }
        }
        public object Clone() {
            EmbeddedChartControl c = new EmbeddedChartControl();
            if (Chart != null) {
                c.AddChart(Chart.Clone() as ChartControl);
                c.RecommendedSize = RecommendedSize;
            }
            return c;
        }
        private event EventHandler editValueChanged;
        public event EventHandler EditValueChanged {
            add {
                editValueChanged += value;
            }
            remove {
                editValueChanged -= value;
            }
        }
        public bool AllowBitmapCache {
            get {
                return true;
            }
        }

        public bool AllowBorder {
            get {
                return true;
            }
        }

        public bool AllowClick(Point point) {
            return false;
        }

        public Size CalcSize(Graphics g) {
            return RecommendedSize;
        }

        public void Draw(DevExpress.Utils.Drawing.GraphicsCache cache, AnyControlEditViewInfo viewInfo) {
        }

        public object EditValue {
            get {
                return _EditValue;
            }
            set {
                if (value == _EditValue) {
                    return;
                }
                _EditValue = value;
                OnEditValueChanging(value);
            }
        }
        private void OnEditValueChanging(object value) {
            if (Chart == null) {
                return;
            }
            if (value is IList || value == null) {
                Chart.DataSource = value;
            }
        }


        public string GetDisplayText(object EditValue) {
            return RepositoryItemAnyControl.GetBasicDisplayText(EditValue);
        }

        public bool IsNeededKey(KeyEventArgs e) {
            return false;
        }

        public void SetupAsDrawControl() {
        }

        public void SetupAsEditControl() {
        }

        public bool SupportsDraw {
            get {
                return false;
            }
        }
    }
}
