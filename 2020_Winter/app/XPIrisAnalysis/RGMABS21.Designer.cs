namespace XPIrisAnalysis
{
    partial class RGMABS21
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
            this.tbAgreementInfo = new System.Windows.Forms.TextBox();
            this.tbSecurityPledge = new System.Windows.Forms.TextBox();
            this.chkAgreement = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbAgreementInfo
            // 
            this.tbAgreementInfo.Location = new System.Drawing.Point(39, 27);
            this.tbAgreementInfo.Multiline = true;
            this.tbAgreementInfo.Name = "tbAgreementInfo";
            this.tbAgreementInfo.Size = new System.Drawing.Size(260, 221);
            this.tbAgreementInfo.TabIndex = 0;
            this.tbAgreementInfo.Text = "정보이용동의";
            // 
            // tbSecurityPledge
            // 
            this.tbSecurityPledge.Location = new System.Drawing.Point(450, 25);
            this.tbSecurityPledge.Multiline = true;
            this.tbSecurityPledge.Name = "tbSecurityPledge";
            this.tbSecurityPledge.Size = new System.Drawing.Size(291, 222);
            this.tbSecurityPledge.TabIndex = 1;
            this.tbSecurityPledge.Text = "불법사용금지";
            // 
            // chkAgreement
            // 
            this.chkAgreement.AutoSize = true;
            this.chkAgreement.Location = new System.Drawing.Point(47, 294);
            this.chkAgreement.Name = "chkAgreement";
            this.chkAgreement.Size = new System.Drawing.Size(104, 19);
            this.chkAgreement.TabIndex = 2;
            this.chkAgreement.Text = "동의합니다";
            this.chkAgreement.UseVisualStyleBackColor = true;
            this.chkAgreement.CheckedChanged += new System.EventHandler(this.chkAgreement_CheckedChanged);
            // 
            // RGMABS21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.chkAgreement);
            this.Controls.Add(this.tbSecurityPledge);
            this.Controls.Add(this.tbAgreementInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RGMABS21";
            this.Text = "문진표";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAgreementInfo;
        private System.Windows.Forms.TextBox tbSecurityPledge;
        private System.Windows.Forms.CheckBox chkAgreement;
    }
}