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

namespace studentgrademanagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=schoolDB;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @user AND Password = @pass AND Role = @role";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@role", role);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0 && (role == "Admin" || role == "Teacher"))
                {
                    MessageBox.Show("Login successful!");

                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials or role.");
                }
            }
        }
    }
}
