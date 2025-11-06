namespace CCPFINALS
{
    partial class AdminRegis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegis));
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(176, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 44);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(118, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 27);
            textBox3.TabIndex = 13;
            textBox3.Text = "Password";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(118, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 27);
            textBox2.TabIndex = 12;
            textBox2.Text = "ID Number";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(118, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 11;
            textBox1.Text = "Name";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(118, 320);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Student";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 83);
            label1.Name = "label1";
            label1.Size = new Size(314, 41);
            label1.TabIndex = 8;
            label1.Text = "Account Registration";
            // 
            // button2
            // 
            button2.Location = new Point(263, 320);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Faculty";
            button2.UseVisualStyleBackColor = true;
            // 
            // AdminRegis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 428);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminRegis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Account Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}