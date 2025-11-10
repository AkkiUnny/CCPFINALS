using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCPFINALS
{
    public partial class AdminQuestionBank : Form
    {
        public AdminQuestionBank()
        {
            InitializeComponent();
            LoadCategories();
            LoadQuestions();
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] { "Mathematics", "English", "Science", "History" });
            cboCategory.SelectedIndex = 0;
        }

        private void LoadQuestions()
        {
            string cat = cboCategory.SelectedItem?.ToString() ?? "Mathematics";
            using (var conn = Database.GetConnection(conn))
            using (var da = new MySqlDataAdapter("SELECT id,category,question,choiceA,choiceB,choiceC,choiceD,correct,points FROM questions WHERE category=@cat", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@cat", cat);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvQuestions.DataSource = dt;
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection(conn))
            using (var cmd = new MySqlCommand(@"INSERT INTO questions(category,question,choiceA,choiceB,choiceC,choiceD,correct,points)
VALUES(@c,@q,@a,@b,@c2,@d,@corr,@pts)", conn))
            {
                cmd.Parameters.AddWithValue("@c", cboCategory.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@q", txtQuestion.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtA.Text.Trim());
                cmd.Parameters.AddWithValue("@b", txtB.Text.Trim());
                cmd.Parameters.AddWithValue("@c2", txtC.Text.Trim());
                cmd.Parameters.AddWithValue("@d", txtD.Text.Trim());
                cmd.Parameters.AddWithValue("@corr", cboCorrect.SelectedItem?.ToString() ?? "A");
                cmd.Parameters.AddWithValue("@pts", numericPoints.Value);
                cmd.ExecuteNonQuery();
                LoadQuestions();
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null) return;
            var id = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["id"].Value);
            using (var conn = Database.GetConnection(conn))
            using (var cmd = new MySqlCommand("DELETE FROM questions WHERE id=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                LoadQuestions();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) => LoadQuestions();
    }
}
