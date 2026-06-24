using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            InstructorForm inf = new InstructorForm();
            inf.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            DepartmentForm df = new DepartmentForm();
            df.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();

            this.Close();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseForm frm = new CourseForm();
            frm.Show();
        }
        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            EnrollmentForm frm = new EnrollmentForm();
            frm.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm frm = new ScheduleForm();

            frm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.Show();
        }
    }
}
