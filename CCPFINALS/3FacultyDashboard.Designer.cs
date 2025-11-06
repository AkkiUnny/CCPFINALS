namespace CCPFINALS
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 279);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 11;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 69);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 10;
            label3.Text = "[Name Here]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 69);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 9;
            label2.Text = "Welcome,";
            // 
            // button2
            // 
            button2.Location = new Point(64, 182);
            button2.Name = "button2";
            button2.Size = new Size(207, 34);
            button2.TabIndex = 8;
            button2.Text = "View Performance Summary";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(82, 125);
            button1.Name = "button1";
            button1.Size = new Size(175, 34);
            button1.TabIndex = 7;
            button1.Text = "View Student Scores";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 6;
            label1.Text = "Faculty Dashboard";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 325);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Rhodes Canvas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}