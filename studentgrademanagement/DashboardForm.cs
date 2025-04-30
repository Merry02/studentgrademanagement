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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void LoadDashboardData()
        {
            string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdStudents = new SqlCommand("SELECT COUNT(*) FROM RegistrationForm", conn);
                int studentCount = (int)cmdStudents.ExecuteScalar();
                labelStudents.Text = "Students : " + studentCount.ToString();

                SqlCommand cmdCourses = new SqlCommand("SELECT COUNT(*) FROM AddCourses", conn);
                int courseCount = (int)cmdCourses.ExecuteScalar();
                labelCourses.Text = "Courses : " + courseCount.ToString();

                SqlCommand cmdTeachers = new SqlCommand("SELECT COUNT(*) FROM Teachers", conn);
                int TeachersCount = (int)cmdTeachers.ExecuteScalar();
                labelTeachers.Text = "Teachers : " + TeachersCount.ToString();




                conn.Close();
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

       


        
    }
}
