using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UniversityManagementSystem
{
    public partial class ReportForm : Form
    {
        string conStr =
        @"Data Source=.\SQLEXPRESS;
          Initial Catalog=University;
          Integrated Security=True";

        public ReportForm()
        {
            InitializeComponent();
        }

        // ==========================
        // STUDENT REPORT
        // ==========================
        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                    "SELECT * FROM student";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==========================
        // COURSE REPORT
        // ==========================
        private void btnCourseReport_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                    "SELECT * FROM course";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==========================
        // ENROLLMENT REPORT
        // ==========================
        private void btnEnrollmentReport_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                @"SELECT
                    s.ID,
                    s.name,
                    c.course_id,
                    c.title,
                    t.grade
                  FROM takes t
                  INNER JOIN student s
                      ON t.ID = s.ID
                  INNER JOIN course c
                      ON t.course_id = c.course_id";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==========================
        // ANALYTICS
        // ==========================
        private void btnStudentAnalytics_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"SELECT dept_name,
             COUNT(*) AS TotalStudents
      FROM student
      GROUP BY dept_name";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            chartAnalytics.Series.Clear();

            Series series =
                new Series("Students");

            series.ChartType =
                SeriesChartType.Pie;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["dept_name"].ToString(),
                    Convert.ToInt32(row["TotalStudents"])
                );
            }

            chartAnalytics.Series.Add(series);

            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(
                "Students by Department");
        }

        // ==========================
        // CLOSE
        // ==========================
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCourseAnalytics_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"SELECT course_id,
             credits
      FROM course";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            chartAnalytics.Series.Clear();

            Series series =
                new Series("Credits");

            series.ChartType =
                SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["course_id"].ToString(),
                    Convert.ToInt32(row["credits"])
                );
            }

            chartAnalytics.Series.Add(series);

            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(
                "Course Credits Analysis");
        }

        private void btnEnrollmentAnalytics_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"SELECT course_id,
             COUNT(ID) AS TotalStudents
      FROM takes
      GROUP BY course_id";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            chartAnalytics.Series.Clear();

            Series series =
                new Series("Enrollment");

            series.ChartType =
                SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["course_id"].ToString(),
                    Convert.ToInt32(row["TotalStudents"])
                );
            }

            chartAnalytics.Series.Add(series);

            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(
                "Enrollment per Course");
        }
    }
}