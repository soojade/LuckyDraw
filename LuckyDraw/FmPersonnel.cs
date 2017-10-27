using System.Drawing;
using System.Windows.Forms;

namespace LuckyDraw {
    public partial class FmPersonnel : Form {
        private Point formPoint = new Point();

        public FmPersonnel() {
            InitializeComponent();
        }

        // 鼠标拖动
        private void FmPersonnel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        // 鼠标点击
        private void FmPersonnel_MouseDown(object sender, MouseEventArgs e) {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        // 关闭界面
        private void BtnClose_Click(object sender, System.EventArgs e) {
            Close();
        }

        // 界面关闭前将对象设置为null
        private void FmPersonnel_FormClosing(object sender, FormClosingEventArgs e) {
            FmMain.fmPersonnel = null;
        }
    }
}
