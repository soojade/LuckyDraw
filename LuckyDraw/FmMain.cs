using System.Drawing;
using System.Windows.Forms;

namespace LuckyDraw {
    public partial class FmMain : Form {
        Point formPoint = new Point();
        public static FmPersonnel fmPersonnel = null;  // static防止多次实例化 public让其他窗体可以访问的
        public static FmDrawSetting fmDrawSetting = null;
        public static FmDrawStart fmDrawStart = null;
        public static FmDrawResult fmDrawResult = null;

        public FmMain() {
            InitializeComponent();
        }

        // 窗体鼠标拖动
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

        // 最小化
        private void BtnMin_Click(object sender, System.EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        // 关闭按钮
        private void BtnClose_Click(object sender, System.EventArgs e) {
            DialogResult result = MessageBox.Show("是否退出程序？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        // 打开抽奖名单界面
        private void BtnPersonnel_Click(object sender, System.EventArgs e) {
            if (fmPersonnel == null) {
                fmPersonnel = new FmPersonnel();
                fmPersonnel.Show();
            } else {
                fmPersonnel.Activate();
                fmPersonnel.WindowState = FormWindowState.Normal;
            }
        }

        // 鼠标移入
        private void BtnPersonnel_MouseHover(object sender, System.EventArgs e) {
            BtnPersonnel.Width = 123;
            BtnPersonnel.Height = 46;
            BtnPersonnel.ForeColor = Color.MediumVioletRed;
        }

        // 鼠标移出
        private void BtnPersonnel_MouseLeave(object sender, System.EventArgs e) {
            BtnPersonnel.Width = 121;
            BtnPersonnel.Height = 45;
            BtnPersonnel.ForeColor = Color.Maroon;
        }

        // 打开奖品设置界面
        private void BtnSetting_Click(object sender, System.EventArgs e) {
            if (fmDrawSetting == null) {
                fmDrawSetting = new FmDrawSetting();
                fmDrawSetting.Show();
            } else {
                fmDrawSetting.Activate();
                fmDrawSetting.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnSetting_MouseHover(object sender, System.EventArgs e) {
            BtnSetting.Width = 123;
            BtnSetting.Height = 46;
            BtnSetting.ForeColor = Color.MediumVioletRed;
        }

        private void BtnSetting_MouseLeave(object sender, System.EventArgs e) {
            BtnSetting.Width = 121;
            BtnSetting.Height = 45;
            BtnSetting.ForeColor = Color.Maroon;
        }

        // 打开抽奖界面
        private void BtnStart_Click(object sender, System.EventArgs e) {
            if (fmDrawStart == null) {
                fmDrawStart = new FmDrawStart();
                fmDrawStart.Show();
            } else {
                fmDrawStart.Activate();
                fmDrawStart.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnStart_MouseHover(object sender, System.EventArgs e) {
            BtnStart.Width = 123;
            BtnStart.Height = 46;
            BtnStart.ForeColor = Color.MediumVioletRed;
        }

        private void BtnStart_MouseLeave(object sender, System.EventArgs e) {
            BtnStart.Width = 121;
            BtnStart.Height = 45;
            BtnStart.ForeColor = Color.Maroon;
        }
        // 打开中奖查询界面
        private void BtnResult_Click(object sender, System.EventArgs e) {
            if (fmDrawResult == null) {
                fmDrawResult = new FmDrawResult();
                fmDrawResult.Show();
            } else {
                fmDrawResult.Activate();
                fmDrawResult.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnResult_MouseHover(object sender, System.EventArgs e) {
            BtnResult.Width = 123;
            BtnResult.Height = 46;
            BtnResult.ForeColor = Color.MediumVioletRed;
        }

        private void BtnResult_MouseLeave(object sender, System.EventArgs e) {
            BtnResult.Width = 121;
            BtnResult.Height = 45;
            BtnResult.ForeColor = Color.Maroon;
        }


    }
}
