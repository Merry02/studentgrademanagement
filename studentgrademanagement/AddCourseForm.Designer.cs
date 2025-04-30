namespace studentgrademanagement
{
    partial class AddCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_addcourse = new System.Windows.Forms.Button();
            this.button_clearcourse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoursecode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrerequisite = new System.Windows.Forms.TextBox();
            this.txtHrsWks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoursetitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.comboBoxAddcourse = new System.Windows.Forms.ComboBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.cboYearlevel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cboYearlevel);
            this.panel4.Controls.Add(this.cboSemester);
            this.panel4.Controls.Add(this.comboBoxAddcourse);
            this.panel4.Controls.Add(this.txtUnits);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtCoursetitle);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtHrsWks);
            this.panel4.Controls.Add(this.txtPrerequisite);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.button_addcourse);
            this.panel4.Controls.Add(this.button_clearcourse);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtNoL);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtCoursecode);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-8, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1134, 348);
            this.panel4.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(8, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1134, 72);
            this.panel3.TabIndex = 58;
            // 
            // button_addcourse
            // 
            this.button_addcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addcourse.BackColor = System.Drawing.Color.LightGray;
            this.button_addcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addcourse.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addcourse.ForeColor = System.Drawing.Color.Brown;
            this.button_addcourse.Location = new System.Drawing.Point(936, 242);
            this.button_addcourse.Name = "button_addcourse";
            this.button_addcourse.Size = new System.Drawing.Size(86, 28);
            this.button_addcourse.TabIndex = 57;
            this.button_addcourse.Text = "Add";
            this.button_addcourse.UseVisualStyleBackColor = false;
            this.button_addcourse.Click += new System.EventHandler(this.button_addcourse_Click);
            // 
            // button_clearcourse
            // 
            this.button_clearcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearcourse.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_clearcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearcourse.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearcourse.ForeColor = System.Drawing.Color.Brown;
            this.button_clearcourse.Location = new System.Drawing.Point(828, 242);
            this.button_clearcourse.Name = "button_clearcourse";
            this.button_clearcourse.Size = new System.Drawing.Size(81, 28);
            this.button_clearcourse.TabIndex = 54;
            this.button_clearcourse.Text = "Clear";
            this.button_clearcourse.UseVisualStyleBackColor = false;
            this.button_clearcourse.Click += new System.EventHandler(this.button_clearcourse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(103, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Hours/Weeks Lab:";
            // 
            // txtNoL
            // 
            this.txtNoL.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtNoL.Location = new System.Drawing.Point(255, 79);
            this.txtNoL.Name = "txtNoL";
            this.txtNoL.Size = new System.Drawing.Size(302, 29);
            this.txtNoL.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(103, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "No of Lec :";
            // 
            // txtCoursecode
            // 
            this.txtCoursecode.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtCoursecode.Location = new System.Drawing.Point(255, 22);
            this.txtCoursecode.Name = "txtCoursecode";
            this.txtCoursecode.Size = new System.Drawing.Size(302, 29);
            this.txtCoursecode.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(103, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Course Code:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Add Course";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 46);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(8, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 11);
            this.panel2.TabIndex = 30;
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewCourse.Location = new System.Drawing.Point(8, 52);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.Size = new System.Drawing.Size(1096, 212);
            this.dataGridViewCourse.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(103, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Prerequisite:";
            // 
            // txtPrerequisite
            // 
            this.txtPrerequisite.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtPrerequisite.Location = new System.Drawing.Point(252, 200);
            this.txtPrerequisite.Name = "txtPrerequisite";
            this.txtPrerequisite.Size = new System.Drawing.Size(305, 29);
            this.txtPrerequisite.TabIndex = 60;
            // 
            // txtHrsWks
            // 
            this.txtHrsWks.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtHrsWks.Location = new System.Drawing.Point(255, 141);
            this.txtHrsWks.Name = "txtHrsWks";
            this.txtHrsWks.Size = new System.Drawing.Size(302, 29);
            this.txtHrsWks.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(602, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "Course Title:";
            // 
            // txtCoursetitle
            // 
            this.txtCoursetitle.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtCoursetitle.Location = new System.Drawing.Point(729, 22);
            this.txtCoursetitle.Name = "txtCoursetitle";
            this.txtCoursetitle.Size = new System.Drawing.Size(302, 29);
            this.txtCoursetitle.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(622, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Units:";
            // 
            // txtUnits
            // 
            this.txtUnits.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtUnits.Location = new System.Drawing.Point(729, 89);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(302, 29);
            this.txtUnits.TabIndex = 65;
            // 
            // comboBoxAddcourse
            // 
            this.comboBoxAddcourse.FormattingEnabled = true;
            this.comboBoxAddcourse.Location = new System.Drawing.Point(729, 144);
            this.comboBoxAddcourse.Name = "comboBoxAddcourse";
            this.comboBoxAddcourse.Size = new System.Drawing.Size(194, 21);
            this.comboBoxAddcourse.TabIndex = 66;
            // 
            // cboSemester
            // 
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Location = new System.Drawing.Point(729, 184);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(194, 21);
            this.cboSemester.TabIndex = 67;
            // 
            // cboYearlevel
            // 
            this.cboYearlevel.AutoSize = true;
            this.cboYearlevel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYearlevel.ForeColor = System.Drawing.Color.Brown;
            this.cboYearlevel.Location = new System.Drawing.Point(632, 146);
            this.cboYearlevel.Name = "cboYearlevel";
            this.cboYearlevel.Size = new System.Drawing.Size(91, 19);
            this.cboYearlevel.TabIndex = 68;
            this.cboYearlevel.Text = "Year Level:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(632, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 69;
            this.label9.Text = "Semester:";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 642);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_addcourse;
        private System.Windows.Forms.Button button_clearcourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoursecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.TextBox txtPrerequisite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoursetitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHrsWks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cboYearlevel;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.ComboBox comboBoxAddcourse;
    }
}