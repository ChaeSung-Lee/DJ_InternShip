namespace XPIrisAnalysis
{
    partial class FLMABS42
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
            this.tbPatientInfoRo = new System.Windows.Forms.TextBox();
            this.btnRegistQuestionnaire = new System.Windows.Forms.Button();
            this.lvQuestionnaire = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbPatientInfoRo
            // 
            this.tbPatientInfoRo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPatientInfoRo.Location = new System.Drawing.Point(17, 11);
            this.tbPatientInfoRo.Name = "tbPatientInfoRo";
            this.tbPatientInfoRo.ReadOnly = true;
            this.tbPatientInfoRo.Size = new System.Drawing.Size(585, 25);
            this.tbPatientInfoRo.TabIndex = 0;
            this.tbPatientInfoRo.Text = "환 자 정 보";
            // 
            // btnRegistQuestionnaire
            // 
            this.btnRegistQuestionnaire.Location = new System.Drawing.Point(672, 10);
            this.btnRegistQuestionnaire.Name = "btnRegistQuestionnaire";
            this.btnRegistQuestionnaire.Size = new System.Drawing.Size(110, 25);
            this.btnRegistQuestionnaire.TabIndex = 1;
            this.btnRegistQuestionnaire.Text = "등록";
            this.btnRegistQuestionnaire.UseVisualStyleBackColor = true;
            // 
            // lvQuestionnaire
            // 
            this.lvQuestionnaire.HideSelection = false;
            this.lvQuestionnaire.Location = new System.Drawing.Point(20, 56);
            this.lvQuestionnaire.Name = "lvQuestionnaire";
            this.lvQuestionnaire.Size = new System.Drawing.Size(761, 368);
            this.lvQuestionnaire.TabIndex = 2;
            this.lvQuestionnaire.UseCompatibleStateImageBehavior = false;
            // 
            // FLMABS42
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lvQuestionnaire);
            this.Controls.Add(this.btnRegistQuestionnaire);
            this.Controls.Add(this.tbPatientInfoRo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLMABS42";
            this.Text = "문진표";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPatientInfoRo;
        private System.Windows.Forms.Button btnRegistQuestionnaire;
        private System.Windows.Forms.ListView lvQuestionnaire;
    }
}