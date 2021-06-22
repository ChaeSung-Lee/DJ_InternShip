namespace XPIrisAnalysis
{
    partial class FLMABS11
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
            this.pbOutputView = new System.Windows.Forms.PictureBox();
            this.rbtPng = new System.Windows.Forms.RadioButton();
            this.rbPdf = new System.Windows.Forms.RadioButton();
            this.rbDoc = new System.Windows.Forms.RadioButton();
            this.btnPrintOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutputView)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOutputView
            // 
            this.pbOutputView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbOutputView.Location = new System.Drawing.Point(29, 30);
            this.pbOutputView.Name = "pbOutputView";
            this.pbOutputView.Size = new System.Drawing.Size(743, 303);
            this.pbOutputView.TabIndex = 0;
            this.pbOutputView.TabStop = false;
            // 
            // rbtPng
            // 
            this.rbtPng.AutoSize = true;
            this.rbtPng.Location = new System.Drawing.Point(50, 371);
            this.rbtPng.Name = "rbtPng";
            this.rbtPng.Size = new System.Drawing.Size(58, 19);
            this.rbtPng.TabIndex = 1;
            this.rbtPng.TabStop = true;
            this.rbtPng.Text = "PNG";
            this.rbtPng.UseVisualStyleBackColor = true;
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Location = new System.Drawing.Point(196, 369);
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Size = new System.Drawing.Size(56, 19);
            this.rbPdf.TabIndex = 2;
            this.rbPdf.TabStop = true;
            this.rbPdf.Text = "PDF";
            this.rbPdf.UseVisualStyleBackColor = true;
            // 
            // rbDoc
            // 
            this.rbDoc.AutoSize = true;
            this.rbDoc.Location = new System.Drawing.Point(327, 371);
            this.rbDoc.Name = "rbDoc";
            this.rbDoc.Size = new System.Drawing.Size(60, 19);
            this.rbDoc.TabIndex = 3;
            this.rbDoc.TabStop = true;
            this.rbDoc.Text = "DOC";
            this.rbDoc.UseVisualStyleBackColor = true;
            // 
            // btnPrintOut
            // 
            this.btnPrintOut.Location = new System.Drawing.Point(548, 362);
            this.btnPrintOut.Name = "btnPrintOut";
            this.btnPrintOut.Size = new System.Drawing.Size(158, 47);
            this.btnPrintOut.TabIndex = 4;
            this.btnPrintOut.Text = "저장";
            this.btnPrintOut.UseVisualStyleBackColor = true;
            this.btnPrintOut.Click += new System.EventHandler(this.btnPrintOut_Click);
            // 
            // FLMABS11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrintOut);
            this.Controls.Add(this.rbDoc);
            this.Controls.Add(this.rbPdf);
            this.Controls.Add(this.rbtPng);
            this.Controls.Add(this.pbOutputView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLMABS11";
            this.Text = "저장";
            ((System.ComponentModel.ISupportInitialize)(this.pbOutputView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOutputView;
        private System.Windows.Forms.RadioButton rbtPng;
        private System.Windows.Forms.RadioButton rbPdf;
        private System.Windows.Forms.RadioButton rbDoc;
        private System.Windows.Forms.Button btnPrintOut;
    }
}