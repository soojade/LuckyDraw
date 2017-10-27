namespace LuckyDraw {
    partial class FmMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.BtnPersonnel = new System.Windows.Forms.Button();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPersonnel
            // 
            this.BtnPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.BtnPersonnel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonnel.BackgroundImage")));
            this.BtnPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPersonnel.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnPersonnel.FlatAppearance.BorderSize = 0;
            this.BtnPersonnel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPersonnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonnel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPersonnel.ForeColor = System.Drawing.Color.Maroon;
            this.BtnPersonnel.Location = new System.Drawing.Point(241, 22);
            this.BtnPersonnel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPersonnel.Name = "BtnPersonnel";
            this.BtnPersonnel.Size = new System.Drawing.Size(121, 45);
            this.BtnPersonnel.TabIndex = 1;
            this.BtnPersonnel.Text = "抽奖名单";
            this.BtnPersonnel.UseVisualStyleBackColor = false;
            this.BtnPersonnel.Click += new System.EventHandler(this.BtnPersonnel_Click);
            this.BtnPersonnel.MouseLeave += new System.EventHandler(this.BtnPersonnel_MouseLeave);
            this.BtnPersonnel.MouseHover += new System.EventHandler(this.BtnPersonnel_MouseHover);
            // 
            // BtnSetting
            // 
            this.BtnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.BtnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSetting.BackgroundImage")));
            this.BtnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnSetting.FlatAppearance.BorderSize = 0;
            this.BtnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetting.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSetting.Location = new System.Drawing.Point(373, 22);
            this.BtnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(121, 45);
            this.BtnSetting.TabIndex = 1;
            this.BtnSetting.Text = "奖项设置";
            this.BtnSetting.UseVisualStyleBackColor = false;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            this.BtnSetting.MouseLeave += new System.EventHandler(this.BtnSetting_MouseLeave);
            this.BtnSetting.MouseHover += new System.EventHandler(this.BtnSetting_MouseHover);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.BtnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStart.BackgroundImage")));
            this.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStart.ForeColor = System.Drawing.Color.Maroon;
            this.BtnStart.Location = new System.Drawing.Point(505, 22);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(121, 45);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "开始抽奖";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.BtnStart.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            this.BtnStart.MouseHover += new System.EventHandler(this.BtnStart_MouseHover);
            // 
            // BtnResult
            // 
            this.BtnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))));
            this.BtnResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnResult.BackgroundImage")));
            this.BtnResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnResult.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnResult.FlatAppearance.BorderSize = 0;
            this.BtnResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnResult.ForeColor = System.Drawing.Color.Maroon;
            this.BtnResult.Location = new System.Drawing.Point(637, 22);
            this.BtnResult.Margin = new System.Windows.Forms.Padding(4);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(121, 45);
            this.BtnResult.TabIndex = 1;
            this.BtnResult.Text = "中奖查询";
            this.BtnResult.UseVisualStyleBackColor = false;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            this.BtnResult.MouseLeave += new System.EventHandler(this.BtnResult_MouseLeave);
            this.BtnResult.MouseHover += new System.EventHandler(this.BtnResult_MouseHover);
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = true;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.ForeColor = System.Drawing.Color.Yellow;
            this.BtnClose.Location = new System.Drawing.Point(958, 6);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(26, 26);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.AutoSize = true;
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMin.BackgroundImage")));
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMin.ForeColor = System.Drawing.Color.Yellow;
            this.BtnMin.Location = new System.Drawing.Point(924, 6);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(26, 26);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 525);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnSetting);
            this.Controls.Add(this.BtnPersonnel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmMain";
            this.Opacity = 0.95D;
            this.Text = "幸运大抽奖";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmMain_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnPersonnel;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMin;
    }
}
