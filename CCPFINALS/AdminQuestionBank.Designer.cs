namespace CCPFINALS
{
    partial class AdminQuestionBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminQuestionBank));
            button1 = new Button();
            btnRefresh = new Button();
            btnDeleteQuestion = new Button();
            btnAddQuestion = new Button();
            numericPoints = new NumericUpDown();
            cboCorrect = new ComboBox();
            txtD = new TextBox();
            txtC = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            txtQuestion = new TextBox();
            dgvQuestions = new DataGridView();
            cboCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 460);
            button1.Name = "button1";
            button1.Size = new Size(120, 34);
            button1.TabIndex = 25;
            button1.Text = "Return";
            button1.Click += button1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(652, 390);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 34);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.Location = new Point(512, 390);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(120, 34);
            btnDeleteQuestion.TabIndex = 14;
            btnDeleteQuestion.Text = "Delete";
            btnDeleteQuestion.Click += btnDeleteQuestion_Click;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(372, 390);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(120, 34);
            btnAddQuestion.TabIndex = 15;
            btnAddQuestion.Text = "Add ";
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // numericPoints
            // 
            numericPoints.Location = new Point(150, 396);
            numericPoints.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPoints.Name = "numericPoints";
            numericPoints.Size = new Size(120, 27);
            numericPoints.TabIndex = 16;
            numericPoints.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboCorrect
            // 
            cboCorrect.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCorrect.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cboCorrect.Location = new Point(12, 396);
            cboCorrect.Name = "cboCorrect";
            cboCorrect.Size = new Size(120, 28);
            cboCorrect.TabIndex = 17;
            // 
            // txtD
            // 
            txtD.Location = new Point(576, 355);
            txtD.Name = "txtD";
            txtD.PlaceholderText = "Choice D";
            txtD.Size = new Size(196, 27);
            txtD.TabIndex = 18;
            // 
            // txtC
            // 
            txtC.Location = new Point(388, 355);
            txtC.Name = "txtC";
            txtC.PlaceholderText = "Choice C";
            txtC.Size = new Size(180, 27);
            txtC.TabIndex = 19;
            // 
            // txtB
            // 
            txtB.Location = new Point(200, 355);
            txtB.Name = "txtB";
            txtB.PlaceholderText = "Choice B";
            txtB.Size = new Size(180, 27);
            txtB.TabIndex = 20;
            // 
            // txtA
            // 
            txtA.Location = new Point(12, 355);
            txtA.Name = "txtA";
            txtA.PlaceholderText = "Choice A";
            txtA.Size = new Size(180, 27);
            txtA.TabIndex = 21;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(12, 325);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.PlaceholderText = "Question text";
            txtQuestion.Size = new Size(760, 27);
            txtQuestion.TabIndex = 22;
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeight = 29;
            dgvQuestions.Location = new Point(12, 65);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.ReadOnly = true;
            dgvQuestions.RowHeadersWidth = 51;
            dgvQuestions.Size = new Size(760, 250);
            dgvQuestions.TabIndex = 23;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(12, 27);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 28);
            cboCategory.TabIndex = 24;
            // 
            // AdminQuestionBank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 506);
            Controls.Add(button1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteQuestion);
            Controls.Add(btnAddQuestion);
            Controls.Add(numericPoints);
            Controls.Add(cboCorrect);
            Controls.Add(txtD);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(txtQuestion);
            Controls.Add(dgvQuestions);
            Controls.Add(cboCategory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminQuestionBank";
            Text = "Admin - Question Bank";
            ((System.ComponentModel.ISupportInitialize)numericPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnRefresh;
        private Button btnDeleteQuestion;
        private Button btnAddQuestion;
        private NumericUpDown numericPoints;
        private ComboBox cboCorrect;
        private TextBox txtD;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private TextBox txtQuestion;
        private DataGridView dgvQuestions;
        private ComboBox cboCategory;
    }
}