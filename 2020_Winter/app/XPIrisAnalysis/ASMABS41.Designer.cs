namespace XPIrisAnalysis
{
    partial class ASMABS41
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
            this.tbPatientSearchWord = new System.Windows.Forms.TextBox();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.lvSearchResultPatient = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "피검자 검색";
            // 
            // tbPatientSearchWord
            // 
            this.tbPatientSearchWord.Location = new System.Drawing.Point(141, 10);
            this.tbPatientSearchWord.Name = "tbPatientSearchWord";
            this.tbPatientSearchWord.Size = new System.Drawing.Size(301, 25);
            this.tbPatientSearchWord.TabIndex = 1;
            this.tbPatientSearchWord.Text = "환자 이름, 모바일, 이메일";
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.Location = new System.Drawing.Point(596, 12);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(176, 33);
            this.btnPatientSearch.TabIndex = 2;
            this.btnPatientSearch.Text = "검색";
            this.btnPatientSearch.UseVisualStyleBackColor = true;
            // 
            // lvSearchResultPatient
            // 
            this.lvSearchResultPatient.HideSelection = false;
            this.lvSearchResultPatient.Location = new System.Drawing.Point(19, 51);
            this.lvSearchResultPatient.Name = "lvSearchResultPatient";
            this.lvSearchResultPatient.Size = new System.Drawing.Size(752, 372);
            this.lvSearchResultPatient.TabIndex = 3;
            this.lvSearchResultPatient.UseCompatibleStateImageBehavior = false;
            // 
            // ASMABS41
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lvSearchResultPatient);
            this.Controls.Add(this.btnPatientSearch);
            this.Controls.Add(this.tbPatientSearchWord);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ASMABS41";
            this.Text = "문진표";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPatientSearchWord;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.ListView lvSearchResultPatient;
    }
}