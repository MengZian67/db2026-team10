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
    public partial class DepartmentForm : Form
    {
        string conStr = @"Data Source=.\SQLEXPRESS;
                  Initial Catalog=University;
                  Integrated Security=True";
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "SELECT * FROM department";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvDepartment.DataSource = dt;
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvDepartment.Rows[e.RowIndex];

                txtDeptName.Text =
                    row.Cells["dept_name"].Value.ToString();

                txtBuilding.Text =
                    row.Cells["building"].Value.ToString();

                txtBudget.Text =
                    row.Cells["budget"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            "INSERT INTO department VALUES (@dept,@building,@budget)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@dept", txtDeptName.Text);
            cmd.Parameters.AddWithValue("@building", txtBuilding.Text);
            cmd.Parameters.AddWithValue("@budget", txtBudget.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Department Added!");

            btnLoad_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"UPDATE department
      SET building=@building,
          budget=@budget
      WHERE dept_name=@dept";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@dept", txtDeptName.Text);
            cmd.Parameters.AddWithValue("@building", txtBuilding.Text);
            cmd.Parameters.AddWithValue("@budget", txtBudget.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Department Updated!");

            btnLoad_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            "DELETE FROM department WHERE dept_name=@dept";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@dept", txtDeptName.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Department Deleted!");

            btnLoad_Click(sender, e);
        }
    }
}
