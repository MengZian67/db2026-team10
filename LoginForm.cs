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
using System.Configuration;

namespace UniversityManagementSystem
{

    public partial class LoginForm : Form
    {
        string conStr = ConfigurationManager
                        .ConnectionStrings["UniversityDB"]
                        .ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM [user] WHERE username=@username AND password=@password AND role=@role";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@role", cboRole.Text);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string role = dr["role"].ToString().Trim();

                if (role == "Admin")
                {
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();
                }
                else if (role.Trim() == "Student")
                {
                    StudentForm student = new StudentForm();
                    student.Show();
                    this.Hide();
                }
                else if (role.Trim() == "Instructor")
                {
                    InstructorForm instructor = new InstructorForm();
                    instructor.Show();
                    this.Hide();
                }
                else if (role.Trim() == "Instructor")
                {
                    EnrollmentForm enrollment = new EnrollmentForm();
                    enrollment.Show();
                    this.Hide();
                }
                else if (role.Trim() == "Instructor")
                {
                    CourseForm course = new CourseForm();
                    course.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username, Password, or Role!");
            }

            con.Close();
        
    }
    }
}
