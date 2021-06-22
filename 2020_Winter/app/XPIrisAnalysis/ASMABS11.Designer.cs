namespace XPIrisAnalysis
{
    partial class ASMABS11
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
            this.pbLeftView = new System.Windows.Forms.PictureBox();
            this.pbRightView = new System.Windows.Forms.PictureBox();
            this.cbLeftCamera = new System.Windows.Forms.ComboBox();
            this.cbRightCamera = new System.Windows.Forms.ComboBox();
            this.btnTakePicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightView)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLeftView
            // 
            this.pbLeftView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbLeftView.Location = new System.Drawing.Point(27, 51);
            this.pbLeftView.Name = "pbLeftView";
            this.pbLeftView.Size = new System.Drawing.Size(361, 325);
            this.pbLeftView.TabIndex = 0;
            this.pbLeftView.TabStop = false;
            // 
            // pbRightView
            // 
            this.pbRightView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbRightView.Location = new System.Drawing.Point(426, 51);
            this.pbRightView.Name = "pbRightView";
            this.pbRightView.Size = new System.Drawing.Size(343, 324);
            this.pbRightView.TabIndex = 1;
            this.pbRightView.TabStop = false;
            // 
            // cbLeftCamera
            // 
            this.cbLeftCamera.FormattingEnabled = true;
            this.cbLeftCamera.Location = new System.Drawing.Point(27, 15);
            this.cbLeftCamera.Name = "cbLeftCamera";
            this.cbLeftCamera.Size = new System.Drawing.Size(361, 23);
            this.cbLeftCamera.TabIndex = 2;
            // 
            // cbRightCamera
            // 
            this.cbRightCamera.FormattingEnabled = true;
            this.cbRightCamera.Location = new System.Drawing.Point(426, 16);
            this.cbRightCamera.Name = "cbRightCamera";
            this.cbRightCamera.Size = new System.Drawing.Size(343, 23);
            this.cbRightCamera.TabIndex = 3;
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.Location = new System.Drawing.Point(27, 390);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(741, 45);
            this.btnTakePicture.TabIndex = 4;
            this.btnTakePicture.Text = "촬영";
            this.btnTakePicture.UseVisualStyleBackColor = true;
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // ASMABS11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnTakePicture);
            this.Controls.Add(this.cbRightCamera);
            this.Controls.Add(this.cbLeftCamera);
            this.Controls.Add(this.pbRightView);
            this.Controls.Add(this.pbLeftView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ASMABS11";
            this.Text = "홍채촬영";
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLeftView;
        private System.Windows.Forms.PictureBox pbRightView;
        private System.Windows.Forms.ComboBox cbLeftCamera;
        private System.Windows.Forms.ComboBox cbRightCamera;
        private System.Windows.Forms.Button btnTakePicture;
    }
}