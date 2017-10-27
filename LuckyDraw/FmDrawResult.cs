﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuckyDraw {
    public partial class FmDrawResult : Form {
        private Point formPoint = new Point();

        public FmDrawResult() {
            InitializeComponent();
        }

        // 鼠标拖动
        private void FmDrawResult_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        // 鼠标点击
        private void FmDrawResult_MouseDown(object sender, MouseEventArgs e) {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        private void BtnClose_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void FmDrawResult_FormClosing(object sender, FormClosingEventArgs e) {
            FmMain.fmDrawResult = null;
        }
    }
}
