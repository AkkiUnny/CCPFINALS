using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CCPFINALS
{
    public partial class AdminAccountManagement : Form
    {
        private bool addMode;

        public AdminAccountManagement(bool isAddMode = false)
        {
            InitializeComponent();
            addMode = isAddMode;
        }

        private void AdminAccountManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var conn = Database.GetConnection(conn))
            using (var cmd = new MySqlCommand("SELECT id, username, fullname, role, email FROM users", conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string role = cmbRole.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (username == "" || password == "" || role == "")
            {
                MessageBox.Show("Username, password, and role are required.");
                return;
            }

            using (var conn = Database.GetConnection(conn))
            using (var cmd = new MySqlCommand("INSERT INTO users (username, password, fullname, role, email) VALUES (@u,@p,@f,@r,@e)", conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@f", fullname);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User added successfully.");
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to delete.");
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["id"].Value);
            using (var conn = Database.GetConnection(conn))
            using (var cmd = new MySqlCommand("DELETE FROM users WHERE id=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User deleted.");
            LoadUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboardForm = new AdminDashboard();
            dashboardForm.Show();
            this.Hide();
        }
    }
}
