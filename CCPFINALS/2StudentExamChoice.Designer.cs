namespace CCPFINALS
{
    partial class _2StudentExamChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2StudentExamChoice));
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(94, 202);
            button4.Name = "button4";
            button4.Size = new Size(175, 34);
            button4.TabIndex = 10;
            button4.Text = "Science";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 318);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 9;
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(94, 152);
            button2.Name = "button2";
            button2.Size = new Size(175, 34);
            button2.TabIndex = 8;
            button2.Text = "Mathematics";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(94, 104);
            button1.Name = "button1";
            button1.Size = new Size(175, 34);
            button1.TabIndex = 7;
            button1.Text = "English";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(94, 252);
            button5.Name = "button5";
            button5.Size = new Size(175, 34);
            button5.TabIndex = 11;
            button5.Text = "History";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 39);
            label1.Name = "label1";
            label1.Size = new Size(251, 41);
            label1.TabIndex = 12;
            label1.Text = "Taking an Exam?";
            // 
            // _2StudentExamChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 364);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "_2StudentExamChoice";
            Text = "Rhodes Canvas - Exam Choice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Label label1;
    }
}