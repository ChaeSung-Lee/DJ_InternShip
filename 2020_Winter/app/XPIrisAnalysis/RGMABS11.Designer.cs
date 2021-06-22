namespace XPIrisAnalysis
{
    partial class RGMABS11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RGMABS11));
            this.txAgreementInfo = new System.Windows.Forms.TextBox();
            this.txSecurityPledge = new System.Windows.Forms.TextBox();
            this.cbAgreement = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txAgreementInfo
            // 
            resources.ApplyResources(this.txAgreementInfo, "txAgreementInfo");
            this.txAgreementInfo.Name = "txAgreementInfo";
            // 
            // txSecurityPledge
            // 
            resources.ApplyResources(this.txSecurityPledge, "txSecurityPledge");
            this.txSecurityPledge.Name = "txSecurityPledge";
            // 
            // cbAgreement
            // 
            resources.ApplyResources(this.cbAgreement, "cbAgreement");
            this.cbAgreement.Name = "cbAgreement";
            this.cbAgreement.UseVisualStyleBackColor = true;
            this.cbAgreement.CheckedChanged += new System.EventHandler(this.cbAgreement_CheckedChanged);
            // 
            // RGMABS11
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.cbAgreement);
            this.Controls.Add(this.txSecurityPledge);
            this.Controls.Add(this.txAgreementInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGMABS11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txAgreementInfo;
        private System.Windows.Forms.TextBox txSecurityPledge;
        private System.Windows.Forms.CheckBox cbAgreement;
    }
}