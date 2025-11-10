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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void StudentScores_Click(object sender, EventArgs e)
        {
            FacultyScores studentScoresForm = new FacultyScores();
            studentScoresForm.Show();
            this.Hide();
        }

        private void PerformanceSummary_Click(object sender, EventArgs e)
        {
            FacultyPerformance studentPerformanceForm = new FacultyPerformance();
            studentPerformanceForm.Show();
            this.Hide();
        }

        private void AccountManagement_Click(object sender, EventArgs e)
        {
            AdminAccountManagement accountManagementForm = new AdminAccountManagement();
            accountManagementForm.Show();
            this.Hide();
        }

        private void QuestionBank_Click(object sender, EventArgs e)
        {
            AdminQuestionBank questionBankForm = new AdminQuestionBank();
            questionBankForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
