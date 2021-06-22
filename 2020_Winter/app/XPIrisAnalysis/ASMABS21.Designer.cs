namespace XPIrisAnalysis
{
    partial class ASMABS21
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnIrisAnalysis = new System.Windows.Forms.Button();
            this.pbLeftEyeView = new System.Windows.Forms.PictureBox();
            this.pbRightEyeView = new System.Windows.Forms.PictureBox();
            this.lbImageNameLt = new System.Windows.Forms.Label();
            this.lbImageNameRt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftEyeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightEyeView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(40, 17);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(214, 37);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "불러오기";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            // 
            // btnIrisAnalysis
            // 
            this.btnIrisAnalysis.Location = new System.Drawing.Point(441, 17);
            this.btnIrisAnalysis.Name = "btnIrisAnalysis";
            this.btnIrisAnalysis.Size = new System.Drawing.Size(197, 37);
            this.btnIrisAnalysis.TabIndex = 1;
            this.btnIrisAnalysis.Text = "홍채분석";
            this.btnIrisAnalysis.UseVisualStyleBackColor = true;
            // 
            // pbLeftEyeView
            // 
            this.pbLeftEyeView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbLeftEyeView.Location = new System.Drawing.Point(18, 65);
            this.pbLeftEyeView.Name = "pbLeftEyeView";
            this.pbLeftEyeView.Size = new System.Drawing.Size(367, 304);
            this.pbLeftEyeView.TabIndex = 2;
            this.pbLeftEyeView.TabStop = false;
            // 
            // pbRightEyeView
            // 
            this.pbRightEyeView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbRightEyeView.Location = new System.Drawing.Point(406, 67);
            this.pbRightEyeView.Name = "pbRightEyeView";
            this.pbRightEyeView.Size = new System.Drawing.Size(376, 301);
            this.pbRightEyeView.TabIndex = 3;
            this.pbRightEyeView.TabStop = false;
            // 
            // lbImageNameLt
            // 
            this.lbImageNameLt.AutoSize = true;
            this.lbImageNameLt.Location = new System.Drawing.Point(22, 396);
            this.lbImageNameLt.Name = "lbImageNameLt";
            this.lbImageNameLt.Size = new System.Drawing.Size(138, 15);
            this.lbImageNameLt.TabIndex = 4;
            this.lbImageNameLt.Text = "left eye image name";
            // 
            // lbImageNameRt
            // 
            this.lbImageNameRt.AutoSize = true;
            this.lbImageNameRt.Location = new System.Drawing.Point(411, 391);
            this.lbImageNameRt.Name = "lbImageNameRt";
            this.lbImageNameRt.Size = new System.Drawing.Size(146, 15);
            this.lbImageNameRt.TabIndex = 5;
            this.lbImageNameRt.Text = "right eye image name";
            // 
            // ASMABS21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbImageNameRt);
            this.Controls.Add(this.lbImageNameLt);
            this.Controls.Add(this.pbRightEyeView);
            this.Controls.Add(this.pbLeftEyeView);
            this.Controls.Add(this.btnIrisAnalysis);
            this.Controls.Add(this.btnLoadImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ASMABS21";
            this.Text = "불러오기";
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftEyeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightEyeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnIrisAnalysis;
        private System.Windows.Forms.PictureBox pbLeftEyeView;
        private System.Windows.Forms.PictureBox pbRightEyeView;
        private System.Windows.Forms.Label lbImageNameLt;
        private System.Windows.Forms.Label lbImageNameRt;
    }
}