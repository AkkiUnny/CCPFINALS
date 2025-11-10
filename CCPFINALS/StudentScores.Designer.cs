namespace CCPFINALS
{
    partial class StudentScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScores));
            button3 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 186);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 27);
            label2.Name = "label2";
            label2.Size = new Size(383, 20);
            label2.TabIndex = 9;
            label2.Text = "Finished with your exams? Have a re-view at your scores!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 86);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 10;
            label1.Text = "Choose a Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 71);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 11;
            label3.Text = "Your score, out of 10:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(253, 91);
            label4.Name = "label4";
            label4.Size = new Size(178, 46);
            label4.TabIndex = 12;
            label4.Text = "[Number]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 158);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 13;
            label5.Text = "[Encouragement Text]";
            // 
            // StudentScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 227);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentScores";
            Text = "Rhodes Canvas - Scores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}