using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            login(Usernametxt.Text,Passtxt.Text);
             
        }
        public void login(string UserName, string Password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Helper.CnnString("SMSDb")))
                {

                    string query="Select * from dbo.Login where UserName= '" + Usernametxt.Text + "' and Password= '" + Passtxt.Text + "'";
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query,con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                   
                    if (dt.Rows.Count==1)
                    {
                        this.Hide();
                        Dashboard f = new Dashboard();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct Login details");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usernametxt.Clear();
            Passtxt.Clear();
        }
    }
}
