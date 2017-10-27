using System.Drawing;
using System.Windows.Forms;

namespace LuckyDraw {
    public partial class FmPerson : Form {
        private Point formPoint = new Point();

        public FmPerson() {
            InitializeComponent();
        }

        private void FmPerson_Load(object sender, System.EventArgs e) {
            this.MouseDown += FmPerson_MouseDown;
            this.MouseMove += FmPerson_MouseMove;
        }

        private void FmPerson_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        private void FmPerson_MouseDown(object sender, MouseEventArgs e) {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }
    }
}
