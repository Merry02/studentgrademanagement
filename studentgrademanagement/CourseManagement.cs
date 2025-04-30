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

namespace studentgrademanagement
{
    public partial class CourseManagement : Form
    {
        public CourseManagement()
        {
            InitializeComponent(); 
        }

        private void LoadCourses()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=schoolDB;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); 
                    string query = "SELECT * FROM AddCourses";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewCourseM.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }


        private void CourseManagement_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void button_clearcourse_Click(object sender, EventArgs e)
        {
            txtCourseCode.Clear();
            txtCourseTitle.Clear();
            txtNoLec.Clear();
            txtHrsLab.Clear();
            txtUnits2.Clear();
            txtPrq.Clear();
            comboBoxAddCourse.SelectedIndex = -1;
            cboSemester1.SelectedIndex = -1;

            txtCourseCode.Focus();
        }

        private void button_searchcourse_Click(object sender, EventArgs e)
        {
           string connectionString = @"Server=localhost\SQLEXPRESS;Database=schoolDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AddCourses WHERE CourseCode LIKE @search OR CourseTitle LIKE @search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + button_searchcourse.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewCourseM.DataSource = table;
            }
        }

        private void button_deletecourse_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCourseCode.Text))
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=schoolDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM AddCourses WHERE CourseCode = @code";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtCourseCode.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Course deleted successfully.");
                LoadCourses();
                button_clearcourse_Click(sender, e); 
            }
        }

        private void button_updatecourse_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=schoolDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE AddCourses SET CourseTitle=@title, NoOfLec=@lec, NoOfLab=@lab, Units=@units, Prerequisite=@prereq, YearLevel=@year, Semester=@sem " +
                               "WHERE CourseCode=@code";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtCourseCode.Text);
                cmd.Parameters.AddWithValue("@title", txtCourseTitle.Text);
                cmd.Parameters.AddWithValue("@lec", int.Parse(txtNoLec.Text));
                cmd.Parameters.AddWithValue("@lab", int.Parse(txtHrsLab.Text));
                cmd.Parameters.AddWithValue("@units", int.Parse(txtUnits2.Text));
                cmd.Parameters.AddWithValue("@prereq", txtPrq.Text);
                cmd.Parameters.AddWithValue("@year", int.Parse(comboBoxAddCourse.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@sem", cboSemester1.SelectedItem.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Course updated successfully.");
                LoadCourses();
            }
        }

        private void dataGridViewCourseM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCourseM.Rows[e.RowIndex];
                txtCourseCode.Text = row.Cells["CourseCode"].Value.ToString();
                txtCourseTitle.Text = row.Cells["CourseTitle"].Value.ToString();
                txtNoLec.Text = row.Cells["NoOfLec"].Value.ToString();
                txtHrsLab.Text = row.Cells["NoOfLab"].Value.ToString();
                txtUnits2.Text = row.Cells["Units"].Value.ToString();
                txtPrq.Text = row.Cells["Prerequisite"].Value.ToString();
                comboBoxAddCourse.SelectedItem = row.Cells["YearLevel"].Value.ToString();
                cboSemester1.SelectedItem = row.Cells["Semester"].Value.ToString();
            }
        }
    }
}
