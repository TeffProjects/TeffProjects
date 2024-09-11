using System;
using System.Windows.Forms;

namespace Student_management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Logout;
            Logout = MessageBox.Show("Are you sure you want to Log out","Student_management_system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Logout == DialogResult.Yes)
            {
                this.Hide();
                Login f = new Login();
                f.Show();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard D = new Dashboard();
            this.Hide();
            D.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
