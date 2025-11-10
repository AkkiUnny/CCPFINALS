namespace CCPFINALS
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            PerformanceSummary = new Button();
            StudentScores = new Button();
            label1 = new Label();
            AccountManagement = new Button();
            QuestionBank = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 404);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 17;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 110);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 16;
            label3.Text = "[Name Here]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 110);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 15;
            label2.Text = "Welcome,";
            // 
            // PerformanceSummary
            // 
            PerformanceSummary.Location = new Point(285, 283);
            PerformanceSummary.Name = "PerformanceSummary";
            PerformanceSummary.Size = new Size(207, 34);
            PerformanceSummary.TabIndex = 14;
            PerformanceSummary.Text = "View Performance Summary";
            PerformanceSummary.UseVisualStyleBackColor = true;
            PerformanceSummary.Click += PerformanceSummary_Click;
            // 
            // StudentScores
            // 
            StudentScores.Location = new Point(285, 193);
            StudentScores.Name = "StudentScores";
            StudentScores.Size = new Size(207, 34);
            StudentScores.TabIndex = 13;
            StudentScores.Text = "View Student Scores";
            StudentScores.UseVisualStyleBackColor = true;
            StudentScores.Click += StudentScores_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 64);
            label1.Name = "label1";
            label1.Size = new Size(309, 46);
            label1.TabIndex = 12;
            label1.Text = "Admin Dashboard";
            // 
            // AccountManagement
            // 
            AccountManagement.Location = new Point(36, 193);
            AccountManagement.Name = "AccountManagement";
            AccountManagement.Size = new Size(207, 34);
            AccountManagement.TabIndex = 18;
            AccountManagement.Text = "Account Management";
            AccountManagement.UseVisualStyleBackColor = true;
            AccountManagement.Click += AccountManagement_Click;
            // 
            // QuestionBank
            // 
            QuestionBank.Location = new Point(36, 283);
            QuestionBank.Name = "QuestionBank";
            QuestionBank.Size = new Size(207, 34);
            QuestionBank.TabIndex = 19;
            QuestionBank.Text = "Question Bank Editor";
            QuestionBank.UseVisualStyleBackColor = true;
            QuestionBank.Click += QuestionBank_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(QuestionBank);
            Controls.Add(AccountManagement);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PerformanceSummary);
            Controls.Add(StudentScores);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboard";
            Text = "Admin - Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label3;
        private Label label2;
        private Button PerformanceSummary;
        private Button StudentScores;
        private Label label1;
        private Button AccountManagement;
        private Button QuestionBank;
    }
}