using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace studentgrademanagement
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            customizeDesign();


        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panelstdsubmenu);
        }
        #region stdsubmenu
        private void button_registration_Click(object sender, EventArgs e)
        {
            RegistrationForm fr = new RegistrationForm();
            fr.Show();
            hideSubmenu();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void customizeDesign()
        {
            panelstdsubmenu.Visible = false;
            panelcoursesubmenu.Visible = false;
            panelgradesubmenu.Visible = false;
            
        }

        private void hideSubmenu()
        {
            if (panelstdsubmenu.Visible == true)
                panelstdsubmenu.Visible = false;
            if (panelcoursesubmenu.Visible == true)
                panelcoursesubmenu.Visible = false;
            if (panelgradesubmenu.Visible == true)
                panelgradesubmenu.Visible = false;
           
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_stdmanagement_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            StudentManagement smf = new StudentManagement();
            smf.Show();
        }

        private void button_printstd_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            PrintStudentForm psf = new PrintStudentForm();
            psf.Show();
        }
        #endregion stdsubmenu
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panelcoursesubmenu);
        }
        #region coursesubmenu
        private void button_addcourse_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            AddCourseForm acf = new AddCourseForm();
            acf.Show();
        }

        private void button_coursemngt_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            CourseManagement cmm = new CourseManagement();
            cmm.Show();
        }

        private void button_printcourse_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            PrintCourseForm pcf = new PrintCourseForm();
            pcf.Show();
        }
        #endregion coursesubmenu
        private void button_grades_Click(object sender, EventArgs e)
        {
            showSubmenu(panelgradesubmenu);
        }
        #region gradesubmenu
        private void button_addgrade_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            AddGrade ag = new AddGrade();
            ag.Show();
        }

        private void button_grademngt_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_printgrade_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion gradesubmenu

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            DashboardForm df = new DashboardForm();
            df.Show();
        }

        private void dashboard_button_Click_1(object sender, EventArgs e)
        {

            DashboardForm df = new DashboardForm();
            df.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeacherForm tf = new TeacherForm();
            tf.Show();
        }
    }
}
