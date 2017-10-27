using System.Drawing;
using System.Windows.Forms;

namespace LuckyDraw {
    public partial class FmMain : Form {
        private Point formPoint = new Point();

        public FmMain() {
            InitializeComponent();
        }

        // 窗体鼠标移动
        private void FmMain_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        // 窗体鼠标按下
        private void FmMain_MouseDown(object sender, MouseEventArgs e) {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        // 关闭按钮
        private void btnClose_Click(object sender, System.EventArgs e) {
            DialogResult result = MessageBox.Show("是否退出？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}
