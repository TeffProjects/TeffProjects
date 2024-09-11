using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("Are you sure you want to exit", "Student_management_system",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Exit == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control c in panel5.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.Insert(IDtxt.Text, Nametxt.Text, Coursetxt.Text, Contacttxt.Text, Addresstxt.Text,Etxt.Text);
            IDtxt.Text = " ";
            Nametxt.Text = " ";
            Coursetxt.Text = " ";
            Contacttxt.Text = " ";
            Addresstxt.Text = " ";
            Etxt.Text = " ";
            MessageBox.Show("Student has been succesfully inserted");
            FillDataGridView();
           
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.delete(IDtxt.Text);
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update1();
            FillDataGridView();
        }


        public void update1()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnString("SMSDb")))
            {

                if (IDtxt.Text != " " && Nametxt.Text != " " && Coursetxt.Text != " " && Contacttxt.Text != " " && Addresstxt.Text != " " && Etxt.Text != " ")
                {
                    SqlConnection con = new SqlConnection(Helper.CnnString("SMSDb"));
                    SqlCommand cmd = new SqlCommand("update dbo.Student_tbl set StudentName=@StudentName,Course=@Course,Contact=@Contact,ResidentialAddress=@ResidentialAddress, EmailAddress=@EmailAddress where StudentID=@StudentID", con);
                    con.Open();

                    cmd.Parameters.AddWithValue("@StudentID", IDtxt.Text);
                    cmd.Parameters.AddWithValue("@StudentName", Nametxt.Text);
                    cmd.Parameters.AddWithValue("@Course", Coursetxt.Text);
                    cmd.Parameters.AddWithValue("@Contact", Contacttxt.Text);
                    cmd.Parameters.AddWithValue("@ResidentialAddress", Addresstxt.Text);
                    cmd.Parameters.AddWithValue("@EmailAddress", Etxt.Text);

                    //clear textboxes
                    IDtxt.Text = " ";
                    Nametxt.Text = " ";
                    Coursetxt.Text = " ";
                    Contacttxt.Text = " ";
                    Addresstxt.Text = " ";
                    Etxt.Text = " ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Details has been successfully updated!");
                    FillDataGridView();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(Helper.CnnString("SMSDb")))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using(DataTable dt = new DataTable("student"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select * from student_tbl where StudentID = @StudentID", cn))
                        {
                            cmd.Parameters.AddWithValue("StudentID", Searchtxt.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
      public void FillDataGridView()
        { 
            using (SqlConnection connection = new SqlConnection(Helper.CnnString("SMSDb")))
            {
                DataTable dt = new DataTable("SMS");
                SqlDataAdapter adapter = new SqlDataAdapter("select * from dbo.Student_tbl", connection);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];

                IDtxt.Text = (selectedRow.Cells[0].Value.ToString());
                Nametxt.Text = (selectedRow.Cells[1].Value.ToString());
                Coursetxt.Text = (selectedRow.Cells[2].Value.ToString());
                Contacttxt.Text = (selectedRow.Cells[3].Value.ToString());
                Addresstxt.Text = (selectedRow.Cells[4].Value.ToString());
                Etxt.Text = (selectedRow.Cells[5].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
