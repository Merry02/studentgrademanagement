using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentgrademanagement
{
    public partial class AddGrade : Form
    {
        public AddGrade()
        {
            InitializeComponent();
        }

        private void AddGrade_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadCourses();

        }

        private void btnClearCourseGrade_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            txtStudentid.Clear();
            comboBoxSelect.SelectedIndex = -1;
            textBoxGrade.Clear();
        }

        private void LoadStudentData()
        {
            string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentID,FirstName, LastName, Course, Grade FROM AddGrades";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewAg.DataSource = table;
            }
        }


        private void LoadCourses()
        {
            string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CourseCode, CourseTitle FROM AddCourses";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboBoxSelect.Items.Clear();

                    while (reader.Read())
                    {
                        string courseCode = reader["CourseCode"].ToString();
                        string courseTitle = reader["CourseTitle"].ToString();

                        string fullCourse = $"{courseCode} - {courseTitle}";
                        comboBoxSelect.Items.Add(fullCourse);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load courses: " + ex.Message);
                }
            }

        }


        private void buttonGrade_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO AddGrades (FirstName, LastName, StudentID, Course, Grade) VALUES (@FirstName, @LastName, @StudentID, @Course, @Grade)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@StudentID", txtStudentid.Text.Trim());
                        cmd.Parameters.AddWithValue("@Course", comboBoxSelect.Text);
                        cmd.Parameters.AddWithValue("@Grade", textBoxGrade.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Grade added successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonDeleteGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewAg.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this grade?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string studentID = dataGridViewAg.SelectedRows[0].Cells["StudentID"].Value.ToString();

                    string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM AddGrades WHERE StudentID = @StudentID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@StudentID", studentID);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Grade deleted successfully!");

                            
                            LoadStudentData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting grade: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button_updatecourse_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtStudentid.Text) ||
                string.IsNullOrWhiteSpace(textBoxGrade.Text) ||
                comboBoxSelect.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string studentID = txtStudentid.Text;
            string course = comboBoxSelect.SelectedItem.ToString();
            string grade = textBoxGrade.Text;

            string connectionString = @"your_connection_string_here"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Grades SET Grade = @grade WHERE StudentID = @studentID AND Course = @course";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@grade", grade);
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@course", course);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Grade updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Grade update failed. Please check the Student ID and Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
