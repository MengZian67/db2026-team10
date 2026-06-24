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

namespace UniversityManagementSystem
{
    public partial class CourseForm : Form
    {
        string conStr =
@"Data Source=DESKTOP-JN5GT2P\SQLEXPRESS;
Initial Catalog=University;
Integrated Security=True";  
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM course";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvCourse.DataSource = dt;
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCourse.Rows[e.RowIndex];

                txtCourseID.Text =
                    row.Cells["course_id"].Value.ToString();

                txtTitle.Text =
                    row.Cells["title"].Value.ToString();

                txtDepartment.Text =
                    row.Cells["dept_name"].Value.ToString();

                txtCredits.Text =
                    row.Cells["credits"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"INSERT INTO course
      VALUES(@id,@title,@dept,@credits)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtCourseID.Text);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
            cmd.Parameters.AddWithValue("@credits", txtCredits.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Course Added!");

            btnLoad_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"UPDATE course
      SET title=@title,
          dept_name=@dept,
          credits=@credits
      WHERE course_id=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtCourseID.Text);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@dept", txtDepartment.Text);
            cmd.Parameters.AddWithValue("@credits", txtCredits.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Course Updated!");

            btnLoad_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            "DELETE FROM course WHERE course_id=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtCourseID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Course Deleted!");

            btnLoad_Click(sender, e);
        }
    }
}
