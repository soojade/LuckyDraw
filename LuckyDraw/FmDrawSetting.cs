using System.Drawing;
using System.Windows.Forms;

namespace LuckyDraw {
    public partial class FmDrawSetting : Form {
        private Point formPoint = new Point();

        public FmDrawSetting() {
            InitializeComponent();
        }

        // 鼠标拖动
        private void FmDrawSetting_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        // 鼠标点击
        private void FmDrawSetting_MouseDown(object sender, MouseEventArgs e) {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        private void BtnClose_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void FmDrawSetting_FormClosing(object sender, FormClosingEventArgs e) {
            FmMain.fmDrawSetting = null;
        }
    }
}
