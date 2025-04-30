using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace studentgrademanagement
{
    public partial class PrintStudentForm : Form
    {
       
        Bitmap memoryImage;

        private void CaptureForm()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        public PrintStudentForm()
        {
            InitializeComponent();
        }

        

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {

        }

        public void SetStudentData(List<Student> students)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = students;
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            CaptureForm(); 
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

       
    }
}
