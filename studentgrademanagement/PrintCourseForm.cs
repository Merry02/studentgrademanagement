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
using System.Drawing.Printing;

namespace studentgrademanagement
{
    public partial class PrintCourseForm : Form
    {
        PrintDocument printDoc = new PrintDocument();
        int currentRowIndex = 0;
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);
            preview.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int rowHeight = 20;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            int y = topMargin;

            // Print column headers
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
            {
                string header = dataGridView2.Columns[j].HeaderText;
                e.Graphics.DrawString(header, font, brush, leftMargin + j * 100, y);
            }

            y += rowHeight;

            // Print rows
            while (currentRowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[currentRowIndex];
                if (!row.IsNewRow)
                {
                    for (int j = 0; j < row.Cells.Count; j++)
                    {
                        string value = row.Cells[j].Value?.ToString() ?? "";
                        e.Graphics.DrawString(value, font, brush, leftMargin + j * 100, y);
                    }
                    y += rowHeight;
                }

                currentRowIndex++;

                // If there’s not enough room for more rows, go to the next page
                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Reset for next print
            currentRowIndex = 0;
            e.HasMorePages = false;
        }


        private void LoadCourses()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=schoolDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT * FROM AddCourses";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;
            }
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
    }
}
