namespace XPIrisAnalysis
{
    partial class ASMABS31
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
            this.lvAnalysisData = new System.Windows.Forms.ListView();
            this.pbLeftImage = new System.Windows.Forms.PictureBox();
            this.pbRightImage = new System.Windows.Forms.PictureBox();
            this.btnGotoPrinter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAnalysisData
            // 
            this.lvAnalysisData.HideSelection = false;
            this.lvAnalysisData.Location = new System.Drawing.Point(285, 16);
            this.lvAnalysisData.Name = "lvAnalysisData";
            this.lvAnalysisData.Size = new System.Drawing.Size(500, 414);
            this.lvAnalysisData.TabIndex = 0;
            this.lvAnalysisData.UseCompatibleStateImageBehavior = false;
            // 
            // pbLeftImage
            // 
            this.pbLeftImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbLeftImage.Location = new System.Drawing.Point(25, 16);
            this.pbLeftImage.Name = "pbLeftImage";
            this.pbLeftImage.Size = new System.Drawing.Size(245, 161);
            this.pbLeftImage.TabIndex = 1;
            this.pbLeftImage.TabStop = false;
            this.pbLeftImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbRightImage
            // 
            this.pbRightImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbRightImage.Location = new System.Drawing.Point(25, 208);
            this.pbRightImage.Name = "pbRightImage";
            this.pbRightImage.Size = new System.Drawing.Size(245, 161);
            this.pbRightImage.TabIndex = 2;
            this.pbRightImage.TabStop = false;
            // 
            // btnGotoPrinter
            // 
            this.btnGotoPrinter.Location = new System.Drawing.Point(25, 386);
            this.btnGotoPrinter.Name = "btnGotoPrinter";
            this.btnGotoPrinter.Size = new System.Drawing.Size(244, 44);
            this.btnGotoPrinter.TabIndex = 3;
            this.btnGotoPrinter.Text = "출 력";
            this.btnGotoPrinter.UseVisualStyleBackColor = true;
            // 
            // ASMABS31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnGotoPrinter);
            this.Controls.Add(this.pbRightImage);
            this.Controls.Add(this.pbLeftImage);
            this.Controls.Add(this.lvAnalysisData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ASMABS31";
            this.Text = "홍채 분석 결과";
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAnalysisData;
        private System.Windows.Forms.PictureBox pbLeftImage;
        private System.Windows.Forms.PictureBox pbRightImage;
        private System.Windows.Forms.Button btnGotoPrinter;
    }
}