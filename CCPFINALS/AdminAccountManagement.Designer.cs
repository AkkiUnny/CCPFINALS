namespace CCPFINALS
{
    partial class AdminAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccountManagement));
            btnDelete = new Button();
            btnAdd = new Button();
            txtEmail = new TextBox();
            cmbRole = new ComboBox();
            txtFullname = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblEmail = new Label();
            lblRole = new Label();
            lblFullname = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            dgvUsers = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(493, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete User";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(353, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add User";
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(433, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 15;
            // 
            // cmbRole
            // 
            cmbRole.Items.AddRange(new object[] { "Admin", "Faculty", "Student" });
            cmbRole.Location = new Point(433, 43);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(180, 28);
            cmbRole.TabIndex = 16;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(153, 113);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(160, 27);
            txtFullname.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(160, 27);
            txtPassword.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(153, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(160, 27);
            txtUsername.TabIndex = 19;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(353, 81);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(353, 46);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 20);
            lblRole.TabIndex = 21;
            lblRole.Text = "Role:";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(58, 116);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(79, 20);
            lblFullname.TabIndex = 22;
            lblFullname.Text = "Full Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(58, 81);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 23;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(58, 46);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 24;
            lblUsername.Text = "Username:";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(23, 181);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(640, 250);
            dgvUsers.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(11, 460);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 25;
            button1.Text = "Return";
            button1.Click += button1_Click;
            // 
            // AdminAccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 507);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(cmbRole);
            Controls.Add(txtFullname);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblRole);
            Controls.Add(lblFullname);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(dgvUsers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminAccountManagement";
            Text = "Admin - Account Management";
            Load += AdminAccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private TextBox txtFullname;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblEmail;
        private Label lblRole;
        private Label lblFullname;
        private Label lblPassword;
        private Label lblUsername;
        private DataGridView dgvUsers;
        private Button button1;
    }
}