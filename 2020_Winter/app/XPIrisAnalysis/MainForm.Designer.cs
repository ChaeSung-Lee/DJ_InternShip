namespace XPIrisAnalysis
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RGMABS00 = new System.Windows.Forms.ToolStripMenuItem();
            this.RGMABS10 = new System.Windows.Forms.ToolStripMenuItem();
            this.RGMABS20 = new System.Windows.Forms.ToolStripMenuItem();
            this.FLMABS00 = new System.Windows.Forms.ToolStripMenuItem();
            this.FLMABS20 = new System.Windows.Forms.ToolStripMenuItem();
            this.FLMABS10 = new System.Windows.Forms.ToolStripMenuItem();
            this.FLMABS40 = new System.Windows.Forms.ToolStripMenuItem();
            this.ASMABS00 = new System.Windows.Forms.ToolStripMenuItem();
            this.ASMABS10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ASMABS20 = new System.Windows.Forms.ToolStripMenuItem();
            this.ASMABS30 = new System.Windows.Forms.ToolStripMenuItem();
            this.ASMABS40 = new System.Windows.Forms.ToolStripMenuItem();
            this.IFMABS00 = new System.Windows.Forms.ToolStripMenuItem();
            this.IFMABS20 = new System.Windows.Forms.ToolStripMenuItem();
            this.IFMABS10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RGMABS00,
            this.FLMABS00,
            this.ASMABS00,
            this.IFMABS00});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RGMABS00
            // 
            this.RGMABS00.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RGMABS10,
            this.RGMABS20});
            this.RGMABS00.Name = "RGMABS00";
            this.RGMABS00.Size = new System.Drawing.Size(53, 24);
            this.RGMABS00.Text = "등록";
            this.RGMABS00.Click += new System.EventHandler(this.RGMABS00_Click);
            // 
            // RGMABS10
            // 
            this.RGMABS10.Name = "RGMABS10";
            this.RGMABS10.Size = new System.Drawing.Size(172, 26);
            this.RGMABS10.Text = "사용자 등록";
            this.RGMABS10.Click += new System.EventHandler(this.RGMABS10_Click);
            // 
            // RGMABS20
            // 
            this.RGMABS20.Name = "RGMABS20";
            this.RGMABS20.Size = new System.Drawing.Size(172, 26);
            this.RGMABS20.Text = "피검자 등록";
            this.RGMABS20.Click += new System.EventHandler(this.RGMABS20_Click);
            // 
            // FLMABS00
            // 
            this.FLMABS00.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FLMABS20,
            this.FLMABS10,
            this.FLMABS40});
            this.FLMABS00.Name = "FLMABS00";
            this.FLMABS00.Size = new System.Drawing.Size(53, 24);
            this.FLMABS00.Text = "파일";
            // 
            // FLMABS20
            // 
            this.FLMABS20.Name = "FLMABS20";
            this.FLMABS20.Size = new System.Drawing.Size(122, 26);
            this.FLMABS20.Text = "검색";
            this.FLMABS20.Click += new System.EventHandler(this.FLMABS20_Click);
            // 
            // FLMABS10
            // 
            this.FLMABS10.Name = "FLMABS10";
            this.FLMABS10.Size = new System.Drawing.Size(122, 26);
            this.FLMABS10.Text = "저장";
            this.FLMABS10.Click += new System.EventHandler(this.FLMABS10_Click);
            // 
            // FLMABS40
            // 
            this.FLMABS40.Name = "FLMABS40";
            this.FLMABS40.Size = new System.Drawing.Size(122, 26);
            this.FLMABS40.Text = "출력";
            this.FLMABS40.Click += new System.EventHandler(this.FLMABS40_Click);
            // 
            // ASMABS00
            // 
            this.ASMABS00.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ASMABS10,
            this.ASMABS20,
            this.ASMABS30,
            this.ASMABS40});
            this.ASMABS00.Name = "ASMABS00";
            this.ASMABS00.Size = new System.Drawing.Size(53, 24);
            this.ASMABS00.Text = "분석";
            // 
            // ASMABS10
            // 
            this.ASMABS10.Name = "ASMABS10";
            this.ASMABS10.Size = new System.Drawing.Size(152, 26);
            this.ASMABS10.Text = "홍채촬영";
            this.ASMABS10.Click += new System.EventHandler(this.ASMABS10_Click);
            // 
            // ASMABS20
            // 
            this.ASMABS20.Name = "ASMABS20";
            this.ASMABS20.Size = new System.Drawing.Size(152, 26);
            this.ASMABS20.Text = "불러오기";
            this.ASMABS20.Click += new System.EventHandler(this.ASMABS20_Click);
            // 
            // ASMABS30
            // 
            this.ASMABS30.Name = "ASMABS30";
            this.ASMABS30.Size = new System.Drawing.Size(152, 26);
            this.ASMABS30.Text = "홍채분석";
            this.ASMABS30.Click += new System.EventHandler(this.ASMABS30_Click);
            // 
            // ASMABS40
            // 
            this.ASMABS40.Name = "ASMABS40";
            this.ASMABS40.Size = new System.Drawing.Size(152, 26);
            this.ASMABS40.Text = "문진표";
            this.ASMABS40.Click += new System.EventHandler(this.ASMABS40_Click);
            // 
            // IFMABS00
            // 
            this.IFMABS00.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IFMABS20,
            this.IFMABS10});
            this.IFMABS00.Name = "IFMABS00";
            this.IFMABS00.Size = new System.Drawing.Size(53, 24);
            this.IFMABS00.Text = "정보";
            // 
            // IFMABS20
            // 
            this.IFMABS20.Name = "IFMABS20";
            this.IFMABS20.Size = new System.Drawing.Size(187, 26);
            this.IFMABS20.Text = "사용자 정보";
            this.IFMABS20.Click += new System.EventHandler(this.IFMABS20_Click);
            // 
            // IFMABS10
            // 
            this.IFMABS10.Name = "IFMABS10";
            this.IFMABS10.Size = new System.Drawing.Size(187, 26);
            this.IFMABS10.Text = "프로그램 정보";
            this.IFMABS10.Click += new System.EventHandler(this.IFMABS10_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(919, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 682);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XP Iris Analysis";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RGMABS00;
        private System.Windows.Forms.ToolStripMenuItem RGMABS10;
        private System.Windows.Forms.ToolStripMenuItem RGMABS20;
        private System.Windows.Forms.ToolStripMenuItem FLMABS00;
        private System.Windows.Forms.ToolStripMenuItem FLMABS20;
        private System.Windows.Forms.ToolStripMenuItem FLMABS10;
        private System.Windows.Forms.ToolStripMenuItem FLMABS40;
        private System.Windows.Forms.ToolStripMenuItem ASMABS00;
        private System.Windows.Forms.ToolStripMenuItem ASMABS10;
        private System.Windows.Forms.ToolStripMenuItem ASMABS20;
        private System.Windows.Forms.ToolStripMenuItem ASMABS30;
        private System.Windows.Forms.ToolStripMenuItem ASMABS40;
        private System.Windows.Forms.ToolStripMenuItem IFMABS00;
        private System.Windows.Forms.ToolStripMenuItem IFMABS20;
        private System.Windows.Forms.ToolStripMenuItem IFMABS10;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

