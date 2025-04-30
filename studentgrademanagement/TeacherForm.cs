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
using TheArtOfDevHtmlRenderer.Adapters;

namespace studentgrademanagement
{
    public partial class TeacherForm : Form
    {

        string connectionString = "Data Source=DESKTOP-EO9PHQR\\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void button_add2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string gender = radioButton_Male.Checked ? "Male" : "Female";
                string query = "INSERT INTO Teachers (FirstName, LastName, Gender) VALUES (@FirstName, @LastName, @Gender)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", textbox_Fname.Text);
                    cmd.Parameters.AddWithValue("@LastName", textbox_Lname.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadTeachers();
            ClearFields();
        }

        private void ClearFields()
        {

            textbox_Fname.Text = "";
            textbox_Lname.Text = "";
            radioButton_Male.Checked = true;

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void DeleteTeacher()
        {
            if (TeacherGrid.CurrentRow != null)
            {
                int teacherID = Convert.ToInt32(TeacherGrid.CurrentRow.Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Teachers WHERE TeacherID = @TeacherID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadTeachers();   // Refresh the DataGridView
                ClearFields();    // Clear the input fields
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DeleteTeacher();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (TeacherGrid.CurrentRow != null)
            {
                int teacherID = Convert.ToInt32(TeacherGrid.CurrentRow.Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string gender = radioButton_Male.Checked ? "Male" : "Female";
                    string query = "UPDATE Teachers SET FirstName=@FirstName, LastName=@LastName, Gender=@Gender WHERE TeacherID=@TeacherID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", textbox_Fname.Text);
                        cmd.Parameters.AddWithValue("@LastName", textbox_Lname.Text);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadTeachers();
                ClearFields();
            }
        }

        private void TeacherGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TeacherGrid.Rows[e.RowIndex];
                textbox_Fname.Text = row.Cells[0].Value?.ToString();
                textbox_Lname.Text = row.Cells[1].Value?.ToString();
                string gender = row.Cells[2].Value?.ToString();
                if (gender == "Male")
                    radioButton_Male.Checked = true;
                else
                    radioButton_Male.Checked = true;
            }
        }

        private void LoadTeachers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Teachers";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                TeacherGrid.DataSource = table;
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            TeacherGrid.ColumnCount = 4;
            TeacherGrid.Columns[0].Name = "ID";
            TeacherGrid.Columns[1].Name = "First Name";
            TeacherGrid.Columns[2].Name = "Last Name";
            TeacherGrid.Columns[3].Name = "Gender";

            LoadTeachers();
        }
    }
}
