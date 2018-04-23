using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using dxSample_IAnyControl.IAny_Files;

namespace dxSample_IAnyControl {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            UserControl_GridWithChart test = new UserControl_GridWithChart();
            test.Location = new Point(0, 0);
            test.Dock = DockStyle.Fill;
            Controls.Add(test);
        }
    }
}
