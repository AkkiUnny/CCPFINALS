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
    public partial class StudentPerformance : Form
    {
        public StudentPerformance()
        {
            InitializeComponent();
        }

        private void _2StudentPerformance_Load(object sender, EventArgs e)
        {
            LoadReports();
        }
        private void LoadReports()
        {
            try
            {
                using (var conn = Database.GetConnection(conn))
                using (var cmd = new MySqlCommand(
                    "SELECT s.fullname AS 'Student Name', e.category AS 'Category', " +
                    "e.score AS 'Score', e.percentage AS 'Percentage', e.status AS 'Status' " +
                    "FROM exam_results e JOIN users s ON e.student_id = s.id " +
                    "ORDER BY e.score DESC", conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvReports.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }
    }
}
