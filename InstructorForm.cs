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
    public partial class InstructorForm : Form
    {
        string conStr = @"Data Source=.\SQLEXPRESS;
                  Initial Catalog=University;
                  Integrated Security=True";
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM Instructor";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvInstructor.DataSource = dt;
        }

        private void dgvInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInstructor.Rows[e.RowIndex];

                txtInstructorID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtDepartment.Text = row.Cells["dept_name"].Value.ToString();
                txtSalary.Text = row.Cells["salary"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = @"INSERT INTO Instructor
                    VALUES (@id, @name, @dept, @salary)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtInstructorID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Instructor Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = @"UPDATE Instructor
                     SET name = @name,
                         dept_name = @dept,
                         salary = @salary
                     WHERE ID = @id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtInstructorID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Instructor Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "DELETE FROM Instructor WHERE ID = @id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtInstructorID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Instructor Deleted!");

            btnLoad_Click(sender, e); // Refresh DataGridView
        }
    }
}
