namespace XPIrisAnalysis
{
    partial class FLMABS21
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("이름");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("나이");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("일시");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("진행사항");
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchWords = new System.Windows.Forms.TextBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.lvSearchResult = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "통합검색";
            // 
            // tbSearchWords
            // 
            this.tbSearchWords.Location = new System.Drawing.Point(126, 10);
            this.tbSearchWords.Name = "tbSearchWords";
            this.tbSearchWords.Size = new System.Drawing.Size(469, 25);
            this.tbSearchWords.TabIndex = 1;
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(657, 8);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(99, 29);
            this.btnSearchAll.TabIndex = 2;
            this.btnSearchAll.Text = "검색";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            // 
            // lvSearchResult
            // 
            this.lvSearchResult.HideSelection = false;
            this.lvSearchResult.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvSearchResult.Location = new System.Drawing.Point(29, 75);
            this.lvSearchResult.Name = "lvSearchResult";
            this.lvSearchResult.Size = new System.Drawing.Size(726, 336);
            this.lvSearchResult.TabIndex = 3;
            this.lvSearchResult.UseCompatibleStateImageBehavior = false;
            // 
            // FLMABS21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lvSearchResult);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.tbSearchWords);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLMABS21";
            this.Text = "검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchWords;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.ListView lvSearchResult;
    }
}