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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            comboBoxAddcourse.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboSemester.Items.AddRange(new object[] { "1", "2", "Summer" });
            LoadCourses();
        }

        private void button_addcourse_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=DESKTOP-EO9PHQR\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO AddCourses (CourseCode, CourseTitle, NoOfLec, NoOfLab, Units, Prerequisite, YearLevel, Semester) " +
                               "VALUES (@code, @title, @lec, @lab, @units, @prereq, @year, @sem)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtCoursecode.Text);
                cmd.Parameters.AddWithValue("@title", txtCoursetitle.Text);
                cmd.Parameters.AddWithValue("@lec", int.Parse(txtNoL.Text));
                cmd.Parameters.AddWithValue("@lab", int.Parse(txtHrsWks.Text));
                cmd.Parameters.AddWithValue("@units", int.Parse(txtUnits.Text));
                cmd.Parameters.AddWithValue("@prereq", txtPrerequisite.Text);
                cmd.Parameters.AddWithValue("@year", int.Parse(comboBoxAddcourse.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@sem", cboSemester.SelectedItem.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Course added successfully!");
                LoadCourses();
            }
        }

        private void LoadCourses()
        {
            string connectionString = @"Data Source=DESKTOP-EO9PHQR\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AddCourses";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewCourse.DataSource = table;
            }


        }


        private void button_clearcourse_Click(object sender, EventArgs e)
        {
            
            txtCoursecode.Clear();
            txtCoursetitle.Clear();
            txtNoL.Clear();
            txtHrsWks.Clear();
            txtUnits.Clear();
            txtPrerequisite.Clear();

            
            comboBoxAddcourse.SelectedIndex = -1;
            cboSemester.SelectedIndex = -1;

            
            txtCoursecode.Focus();
        }
    }
}
