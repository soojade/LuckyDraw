using System.Drawing;
using System.Windows.Forms;

namespace LuckyDraw {
    public partial class FmDrawStart : Form {
        private Point formPoint = new Point();

        public FmDrawStart() {
            InitializeComponent();
        }
        // 鼠标拖动
        private void FmDrawStart_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        // 鼠标点击
        private void FmDrawStart_MouseDown(object sender, MouseEventArgs e) {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        // 最小化
        private void BtnMin_Click(object sender, System.EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        // 关闭
        private void BtnClose_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void FmDrawStart_FormClosing(object sender, FormClosingEventArgs e) {
            FmMain.fmDrawStart = null;
        }

        private void BtnStart_MouseDown(object sender, MouseEventArgs e) {
            BtnStart.Width = 112;
            BtnStart.Height = 102;
        }

        private void BtnStart_MouseUp(object sender, MouseEventArgs e) {
            BtnStart.Width = 110;
            BtnStart.Height = 100;
        }

    }
}
