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
    public partial class StudentManagement : Form
    {
        int selectedID = -1;
        string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textbox_Fname.Clear();
            textbox_Lname.Clear();
            textbox_contactnum.Clear();
            textBox_address.Clear();
            dateTimePicker2.Value = DateTime.Now;
            radioButton_Male.Checked = true;

            selectedID = -1;
        }

        private void studentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedID = Convert.ToInt32(studentGrid.Rows[e.RowIndex].Cells["ID"].Value);
                textbox_Fname.Text = studentGrid.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                textbox_Lname.Text = studentGrid.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                textbox_contactnum.Text = studentGrid.Rows[e.RowIndex].Cells["ContactNumber"].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(studentGrid.Rows[e.RowIndex].Cells["DateOfBirth"].Value);

              
                string gender = studentGrid.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                radioButton_Male.Checked = (gender == "Male");

                textBox_address.Text = studentGrid.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
        }

        private void LoadStudentData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM RegistrationForm";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                studentGrid.DataSource = table;
            }
        }


        private void button_update_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE RegistrationForm SET FirstName = @fname, LastName = @lname, ContactNumber = @contactnumber, DateOfBirth = @dob, Gender = @gender, Address = @address WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fname", textbox_Fname.Text);
                    cmd.Parameters.AddWithValue("@lname", textbox_Lname.Text);
                    cmd.Parameters.AddWithValue("@contactnumber", textbox_contactnum.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker2.Value);
                    string gender = radioButton_Male.Checked ? "Male" : "Female";
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", textBox_address.Text);
                    cmd.Parameters.AddWithValue("@id", selectedID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Student updated successfully!");
                    LoadStudentData();
                }
            }

        

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM RegistrationForm WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", selectedID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Student deleted successfully!");
                    button_clear.PerformClick();
                    LoadStudentData();
                }
            }
        }

        private void button_add2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";

            string firstName = textbox_Fname.Text;
            string lastName = textbox_Lname.Text;
            string contact = textbox_contactnum.Text;
            DateTime dob = dateTimePicker2.Value;
            string gender = radioButton_Male.Checked ? "Male" : "Female";
            string address = textBox_address.Text;

           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO RegistrationForm (FirstName, LastName, ContactNumber, DateOfBirth, Gender, Address) " +
                               "VALUES (@FirstName, @LastName, @ContactNumber, @DOB, @Gender, @Address)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student added successfully!");

                           
                            DataTable studentsTable = new DataTable();
                            string selectQuery = "SELECT * FROM RegistrationForm";

                            using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn))
                            {
                                adapter.Fill(studentsTable);
                            }

                            List<Student> studentList = new List<Student>();

                            foreach (DataRow row in studentsTable.Rows)
                            {
                                studentList.Add(new Student
                                {
                                    ID = Convert.ToInt32(row["ID"]),
                                    FirstName = row["FirstName"].ToString(),
                                    LastName = row["LastName"].ToString(),
                                    Contact = row["ContactNumber"].ToString(),
                                    DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                                    Gender = row["Gender"].ToString(),
                                    Address = row["Address"].ToString()
                                });
                            }

                            PrintStudentForm printForm = new PrintStudentForm();
                            printForm.SetStudentData(studentList); 
                            printForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("No student was added. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
