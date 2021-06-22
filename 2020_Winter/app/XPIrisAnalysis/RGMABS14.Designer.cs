namespace XPIrisAnalysis
{
    partial class RGMABS14
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStartProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "등록이 완료되었습니다";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(707, 236);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "인사말이나 소개말\r\n또는 듀토리얼";
            // 
            // btnStartProgram
            // 
            this.btnStartProgram.Location = new System.Drawing.Point(302, 335);
            this.btnStartProgram.Name = "btnStartProgram";
            this.btnStartProgram.Size = new System.Drawing.Size(209, 53);
            this.btnStartProgram.TabIndex = 2;
            this.btnStartProgram.Text = "시작하기";
            this.btnStartProgram.UseVisualStyleBackColor = true;
            this.btnStartProgram.Click += new System.EventHandler(this.btnStartProgram_Click);
            // 
            // RGMABS14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 422);
            this.ControlBox = false;
            this.Controls.Add(this.btnStartProgram);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RGMABS14";
            this.Text = "RGMABS14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStartProgram;
    }
}