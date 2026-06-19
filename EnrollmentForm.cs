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
    public partial class EnrollmentForm : Form
    {
        string conStr =
            @"Data Source=DESKTOP-JN5GT2P\SQLEXPRESS;
              Initial Catalog=University;
              Integrated Security=True";

        public EnrollmentForm()
        {
            InitializeComponent();

            LoadEnrollments();
            LoadCourses();
            LoadSections();
            LoadSemesters();
            LoadYears();
        }
        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            LoadEnrollments();
        }

        private void LoadEnrollments()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                "SELECT * FROM takes";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dgvEnrollment.DataSource = dt;
        }

        private void LoadCourses()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                "SELECT DISTINCT course_id FROM section";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbCourseID.DataSource = dt;
            cmbCourseID.DisplayMember = "course_id";
            cmbCourseID.ValueMember = "course_id";
        }

        private void LoadSections()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                "SELECT DISTINCT sec_id FROM section";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbSectionID.DataSource = dt;
            cmbSectionID.DisplayMember = "sec_id";
            cmbSectionID.ValueMember = "sec_id";
        }

        private void LoadSemesters()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                "SELECT DISTINCT semester FROM section";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbSemester.DataSource = dt;
            cmbSemester.DisplayMember = "semester";
            cmbSemester.ValueMember = "semester";
        }

        private void LoadYears()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                "SELECT DISTINCT year FROM section";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbYear.DataSource = dt;
            cmbYear.DisplayMember = "year";
            cmbYear.ValueMember = "year";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEnrollments();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                    @"INSERT INTO takes
                    (ID, course_id, sec_id, semester, year, grade)
                    VALUES
                    (@ID, @CourseID, @SecID, @Semester, @Year, @Grade)";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", txtStudentsID.Text);
                cmd.Parameters.AddWithValue("@CourseID", cmbCourseID.Text);
                cmd.Parameters.AddWithValue("@SecID", cmbSectionID.Text);
                cmd.Parameters.AddWithValue("@Semester", cmbSemester.Text);
                cmd.Parameters.AddWithValue("@Year", cmbYear.Text);
                cmd.Parameters.AddWithValue("@Grade", txtGrade.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Enrollment Added Successfully!");

                LoadEnrollments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                @"UPDATE takes
                  SET grade = @Grade
                  WHERE ID = @ID
                  AND course_id = @CourseID";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Grade", txtGrade.Text);
            cmd.Parameters.AddWithValue("@ID", txtStudentsID.Text);
            cmd.Parameters.AddWithValue("@CourseID", cmbCourseID.Text);

            con.Open();

            int rows =
                cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(
                "Rows Updated: " + rows);

            LoadEnrollments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                @"DELETE FROM takes
                  WHERE ID = @ID
                  AND course_id = @CourseID";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", txtStudentsID.Text);
            cmd.Parameters.AddWithValue("@CourseID", cmbCourseID.Text);

            con.Open();

            int rows =
                cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(
                "Rows Deleted: " + rows);

            LoadEnrollments();
        }

        private void dgvEnrollment_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvEnrollment.Rows[e.RowIndex];

                txtStudentsID.Text =
                    row.Cells["ID"].Value.ToString();

                cmbCourseID.Text =
                    row.Cells["course_id"].Value.ToString();

                cmbSectionID.Text =
                    row.Cells["sec_id"].Value.ToString();

                cmbSemester.Text =
                    row.Cells["semester"].Value.ToString();

                cmbYear.Text =
                    row.Cells["year"].Value.ToString();

                txtGrade.Text =
                    row.Cells["grade"].Value == DBNull.Value
                    ? ""
                    : row.Cells["grade"].Value.ToString();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm frm =
                new LoginForm();

            frm.Show();

            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}