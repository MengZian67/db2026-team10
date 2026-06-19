using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class ScheduleForm : Form
    {
        string conStr =
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=University;
              Integrated Security=True";

        public ScheduleForm()
        {
            InitializeComponent();

            LoadSchedules();

            LoadCourses();
            LoadBuildings();
            LoadRooms();
            LoadTimeSlots();

            LoadManualValues();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            LoadSchedules();
        }

        private void LoadManualValues()
        {
            cmbSectionID.Items.Clear();
            cmbSemester.Items.Clear();
            cmbYear.Items.Clear();

            cmbSectionID.Items.Add("1");
            cmbSectionID.Items.Add("2");
            cmbSectionID.Items.Add("3");

            cmbSemester.Items.Add("Spring");
            cmbSemester.Items.Add("Summer");
            cmbSemester.Items.Add("Fall");
            cmbSemester.Items.Add("Winter");

            cmbYear.Items.Add("2017");
            cmbYear.Items.Add("2018");
            cmbYear.Items.Add("2019");
            cmbYear.Items.Add("2020");
        }

        private void LoadSchedules()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                "SELECT * FROM section";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dgvSchedule.DataSource = dt;
        }

        private void LoadCourses()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT course_id FROM course",
                    con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbCourseID.DataSource = dt;
            cmbCourseID.DisplayMember = "course_id";
        }

        private void LoadBuildings()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT DISTINCT building FROM classroom",
                    con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbBuilding.DataSource = dt;
            cmbBuilding.DisplayMember = "building";
        }

        private void LoadRooms()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT room_number FROM classroom",
                    con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbRoomNumber.DataSource = dt;
            cmbRoomNumber.DisplayMember = "room_number";
        }

        private void LoadTimeSlots()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT DISTINCT time_slot_id FROM time_slot",
                    con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbTimeSlot.DataSource = dt;
            cmbTimeSlot.DisplayMember = "time_slot_id";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSchedules();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                @"INSERT INTO section
        (
            course_id,
            sec_id,
            semester,
            year,
            building,
            room_number,
            time_slot_id
        )
        VALUES
        (
            @course_id,
            @sec_id,
            @semester,
            @year,
            @building,
            @room_number,
            @time_slot_id
        )";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@course_id",
                    cmbCourseID.Text);

                cmd.Parameters.AddWithValue(
                    "@sec_id",
                    cmbSectionID.Text);

                cmd.Parameters.AddWithValue(
                    "@semester",
                    cmbSemester.Text);

                cmd.Parameters.AddWithValue(
                    "@year",
                    Convert.ToInt32(cmbYear.Text));

                cmd.Parameters.AddWithValue(
                    "@building",
                    cmbBuilding.Text);

                cmd.Parameters.AddWithValue(
                    "@room_number",
                    cmbRoomNumber.Text);

                cmd.Parameters.AddWithValue(
                    "@time_slot_id",
                    cmbTimeSlot.Text);

                con.Open();

                int rows =
                    cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(
                    "Rows Added: " + rows);

                LoadSchedules();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                @"UPDATE section
          SET
              building=@building,
              room_number=@room_number,
              time_slot_id=@time_slot_id
          WHERE
              course_id=@course_id
              AND sec_id=@sec_id
              AND semester=@semester
              AND year=@year";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@course_id",
                    cmbCourseID.Text);

                cmd.Parameters.AddWithValue(
                    "@sec_id",
                    cmbSectionID.Text);

                cmd.Parameters.AddWithValue(
                    "@semester",
                    cmbSemester.Text);

                cmd.Parameters.AddWithValue(
                    "@year",
                    Convert.ToInt32(cmbYear.Text));

                cmd.Parameters.AddWithValue(
                    "@building",
                    cmbBuilding.Text);

                cmd.Parameters.AddWithValue(
                    "@room_number",
                    cmbRoomNumber.Text);

                cmd.Parameters.AddWithValue(
                    "@time_slot_id",
                    cmbTimeSlot.Text);

                con.Open();

                int rows =
                    cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(
                    "Rows Updated: " + rows);

                LoadSchedules();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                @"DELETE FROM section
          WHERE
              course_id=@course_id
              AND sec_id=@sec_id
              AND semester=@semester
              AND year=@year";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@course_id",
                    cmbCourseID.Text);

                cmd.Parameters.AddWithValue(
                    "@sec_id",
                    cmbSectionID.Text);

                cmd.Parameters.AddWithValue(
                    "@semester",
                    cmbSemester.Text);

                cmd.Parameters.AddWithValue(
                    "@year",
                    Convert.ToInt32(cmbYear.Text));

                con.Open();

                int rows =
                    cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(
                    "Rows Deleted: " + rows);

                LoadSchedules();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSchedule_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvSchedule.Rows[e.RowIndex];

                cmbCourseID.Text =
                    row.Cells["course_id"].Value.ToString();

                cmbSectionID.Text =
                    row.Cells["sec_id"].Value.ToString();

                cmbSemester.Text =
                    row.Cells["semester"].Value.ToString();

                cmbYear.Text =
                    row.Cells["year"].Value.ToString();

                cmbBuilding.Text =
                    row.Cells["building"].Value.ToString();

                cmbRoomNumber.Text =
                    row.Cells["room_number"].Value.ToString();

                cmbTimeSlot.Text =
                    row.Cells["time_slot_id"].Value.ToString();
            }
        }

        private void dgvSchedule_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvSchedule.Rows[e.RowIndex];

                cmbCourseID.Text =
                    row.Cells["course_id"].Value.ToString();

                cmbSectionID.Text =
                    row.Cells["sec_id"].Value.ToString();

                cmbSemester.Text =
                    row.Cells["semester"].Value.ToString();

                cmbYear.Text =
                    row.Cells["year"].Value.ToString();

                cmbBuilding.Text =
                    row.Cells["building"].Value.ToString();

                cmbRoomNumber.Text =
                    row.Cells["room_number"].Value.ToString();

                cmbTimeSlot.Text =
                    row.Cells["time_slot_id"].Value.ToString();
            }
        }
    }
}