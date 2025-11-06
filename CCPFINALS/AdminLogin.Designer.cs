namespace CCPFINALS
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(176, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 44);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(118, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 27);
            textBox3.TabIndex = 12;
            textBox3.Text = "Password";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(118, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 27);
            textBox2.TabIndex = 11;
            textBox2.Text = "ID Number";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(118, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 10;
            textBox1.Text = "Name";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(189, 347);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 106);
            label1.Name = "label1";
            label1.Size = new Size(267, 41);
            label1.TabIndex = 8;
            label1.Text = "Welcome, Admin!";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(474, 435);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(492, 482);
            MinimumSize = new Size(492, 482);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
    }
}