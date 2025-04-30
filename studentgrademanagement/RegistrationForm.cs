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
using System.IO;

namespace studentgrademanagement
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";

            string studentID = txtStudentID.Text;
            string firstName = txtFname.Text;
            string lastName = txtLname.Text;
            string contact = txtcontactnum.Text;
            DateTime dob = dateTimePicker1.Value;
            string gender = radioButton_Male.Checked ? "Male" : "Female";
            string address = textBox_address.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

       
              

                string query = "INSERT INTO RegistrationForm (StudentID, FirstName, LastName, ContactNumber, DateOfBirth, Gender, Address) " +
                               "VALUES (@StudentID, @FirstName, @LastName, @ContactNumber, @DateOfBirth, @Gender, @Address)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                MessageBox.Show("Registration added successfully!");
                LoadStudentData();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtcontactnum.Clear();
            textBox_address.Clear();
            dateTimePicker1.Value = DateTime.Now;
            radioButton_Male.Checked = true; 
           
        }

        private void LoadStudentData()
        {
            string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentID,FirstName, LastName, ContactNumber, DateOfBirth, Gender, Address FROM RegistrationForm";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                guna2DataGridView1.DataSource = table;
            }
        }




    }
}
