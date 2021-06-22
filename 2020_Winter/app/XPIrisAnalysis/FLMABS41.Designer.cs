namespace XPIrisAnalysis
{
    partial class FLMABS41
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
            this.pbPreviewPrint = new System.Windows.Forms.PictureBox();
            this.lbPrintType = new System.Windows.Forms.ListBox();
            this.tbPrintInfo = new System.Windows.Forms.TextBox();
            this.btnPrinter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPreviewPrint
            // 
            this.pbPreviewPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPreviewPrint.Location = new System.Drawing.Point(12, 71);
            this.pbPreviewPrint.Name = "pbPreviewPrint";
            this.pbPreviewPrint.Size = new System.Drawing.Size(768, 367);
            this.pbPreviewPrint.TabIndex = 0;
            this.pbPreviewPrint.TabStop = false;
            // 
            // lbPrintType
            // 
            this.lbPrintType.FormattingEnabled = true;
            this.lbPrintType.ItemHeight = 15;
            this.lbPrintType.Items.AddRange(new object[] {
            "프린트",
            "이메일",
            "모바일"});
            this.lbPrintType.Location = new System.Drawing.Point(29, 18);
            this.lbPrintType.Name = "lbPrintType";
            this.lbPrintType.Size = new System.Drawing.Size(97, 19);
            this.lbPrintType.TabIndex = 1;
            // 
            // tbPrintInfo
            // 
            this.tbPrintInfo.Location = new System.Drawing.Point(165, 16);
            this.tbPrintInfo.Name = "tbPrintInfo";
            this.tbPrintInfo.Size = new System.Drawing.Size(353, 25);
            this.tbPrintInfo.TabIndex = 2;
            // 
            // btnPrinter
            // 
            this.btnPrinter.Location = new System.Drawing.Point(631, 15);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(136, 38);
            this.btnPrinter.TabIndex = 3;
            this.btnPrinter.Text = "출 력";
            this.btnPrinter.UseVisualStyleBackColor = true;
            // 
            // FLMABS41
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.tbPrintInfo);
            this.Controls.Add(this.lbPrintType);
            this.Controls.Add(this.pbPreviewPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLMABS41";
            this.Text = "출력";
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPreviewPrint;
        private System.Windows.Forms.ListBox lbPrintType;
        private System.Windows.Forms.TextBox tbPrintInfo;
        private System.Windows.Forms.Button btnPrinter;
    }
}