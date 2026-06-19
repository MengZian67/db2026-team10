using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversityManagementSystem
{
    public partial class StudentForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;
                      Initial Catalog=University;
                      Integrated Security=True";
        public StudentForm()
        {
            InitializeComponent();
            LoadStudents();
        }
        private void LoadStudents()
        {
            SqlConnection con =
                new SqlConnection(connectionString);

            string query =
                "SELECT * FROM student";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void txtDepartment_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query =
                "INSERT INTO Student(ID, name, dept_name, tot_cred) " +
                "VALUES(@id, @name, @dept, @cred)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
            cmd.Parameters.AddWithValue("@cred", txtCredits.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Student Added Successfully!");

            txtID.Clear();
            txtName.Clear();
            txtDepartment.Clear();
            txtCredits.Clear();

            btnLoad_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query =
                "UPDATE Student " +
                "SET name=@name, dept_name=@dept, tot_cred=@cred " +
                "WHERE ID=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
            cmd.Parameters.AddWithValue("@cred", txtCredits.Text);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Rows Updated: " + rows);

            btnLoad_Click(sender, e);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query =
                "DELETE FROM Student " +
                "WHERE ID=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtID.Text);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Rows Deleted: " + rows);

            btnLoad_Click(sender, e);
        }

        private void CellClick(object sender, EventArgs e)
        {
            
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtDepartment.Text = row.Cells["dept_name"].Value.ToString();
                txtCredits.Text = row.Cells["tot_cred"].Value.ToString();
            }
        }
    }
}
