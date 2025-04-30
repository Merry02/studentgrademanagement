namespace studentgrademanagement
{
    partial class AddGrade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewAg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDeleteGrade = new System.Windows.Forms.Button();
            this.buttonGrade = new System.Windows.Forms.Button();
            this.btnClearCourseGrade = new System.Windows.Forms.Button();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_updatecourse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 86);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(465, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Add Grade";
            // 
            // dataGridViewAg
            // 
            this.dataGridViewAg.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewAg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAg.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewAg.Name = "dataGridViewAg";
            this.dataGridViewAg.Size = new System.Drawing.Size(1058, 236);
            this.dataGridViewAg.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 11);
            this.panel2.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.button_updatecourse);
            this.panel3.Controls.Add(this.buttonDeleteGrade);
            this.panel3.Controls.Add(this.buttonGrade);
            this.panel3.Controls.Add(this.btnClearCourseGrade);
            this.panel3.Controls.Add(this.comboBoxSelect);
            this.panel3.Controls.Add(this.textBoxLastName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxFirstName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxGrade);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtStudentid);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 271);
            this.panel3.TabIndex = 71;
            // 
            // buttonDeleteGrade
            // 
            this.buttonDeleteGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteGrade.BackColor = System.Drawing.Color.Tomato;
            this.buttonDeleteGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteGrade.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteGrade.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonDeleteGrade.Location = new System.Drawing.Point(685, 205);
            this.buttonDeleteGrade.Name = "buttonDeleteGrade";
            this.buttonDeleteGrade.Size = new System.Drawing.Size(85, 38);
            this.buttonDeleteGrade.TabIndex = 76;
            this.buttonDeleteGrade.Text = "Delete";
            this.buttonDeleteGrade.UseVisualStyleBackColor = false;
            this.buttonDeleteGrade.Click += new System.EventHandler(this.buttonDeleteGrade_Click);
            // 
            // buttonGrade
            // 
            this.buttonGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGrade.BackColor = System.Drawing.Color.LightGray;
            this.buttonGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrade.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrade.ForeColor = System.Drawing.Color.Brown;
            this.buttonGrade.Location = new System.Drawing.Point(901, 205);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(99, 37);
            this.buttonGrade.TabIndex = 75;
            this.buttonGrade.Text = "Add";
            this.buttonGrade.UseVisualStyleBackColor = false;
            this.buttonGrade.Click += new System.EventHandler(this.buttonGrade_Click);
            // 
            // btnClearCourseGrade
            // 
            this.btnClearCourseGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearCourseGrade.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnClearCourseGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCourseGrade.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCourseGrade.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClearCourseGrade.Location = new System.Drawing.Point(790, 205);
            this.btnClearCourseGrade.Name = "btnClearCourseGrade";
            this.btnClearCourseGrade.Size = new System.Drawing.Size(89, 38);
            this.btnClearCourseGrade.TabIndex = 74;
            this.btnClearCourseGrade.Text = "Clear";
            this.btnClearCourseGrade.UseVisualStyleBackColor = false;
            this.btnClearCourseGrade.Click += new System.EventHandler(this.btnClearCourseGrade_Click);
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Location = new System.Drawing.Point(197, 125);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(302, 21);
            this.comboBoxSelect.TabIndex = 73;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textBoxLastName.Location = new System.Drawing.Point(668, 23);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(302, 29);
            this.textBoxLastName.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(565, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "Last Name :";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textBoxFirstName.Location = new System.Drawing.Point(197, 23);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(302, 29);
            this.textBoxFirstName.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(74, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 69;
            this.label4.Text = "First Name :";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Font = new System.Drawing.Font("Gadugi", 12F);
            this.textBoxGrade.Location = new System.Drawing.Point(668, 71);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(302, 29);
            this.textBoxGrade.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(581, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Grade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(54, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Select Course :";
            // 
            // txtStudentid
            // 
            this.txtStudentid.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtStudentid.Location = new System.Drawing.Point(197, 68);
            this.txtStudentid.Name = "txtStudentid";
            this.txtStudentid.Size = new System.Drawing.Size(302, 29);
            this.txtStudentid.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(74, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "Student ID :";
            // 
            // button_updatecourse
            // 
            this.button_updatecourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_updatecourse.BackColor = System.Drawing.Color.YellowGreen;
            this.button_updatecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updatecourse.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatecourse.ForeColor = System.Drawing.Color.DarkRed;
            this.button_updatecourse.Location = new System.Drawing.Point(583, 205);
            this.button_updatecourse.Name = "button_updatecourse";
            this.button_updatecourse.Size = new System.Drawing.Size(79, 38);
            this.button_updatecourse.TabIndex = 77;
            this.button_updatecourse.Text = "Update";
            this.button_updatecourse.UseVisualStyleBackColor = false;
            this.button_updatecourse.Click += new System.EventHandler(this.button_updatecourse_Click);
            // 
            // AddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewAg);
            this.Controls.Add(this.panel1);
            this.Name = "AddGrade";
            this.Text = "AddGrade";
            this.Load += new System.EventHandler(this.AddGrade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewAg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentid;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearCourseGrade;
        private System.Windows.Forms.Button buttonGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDeleteGrade;
        private System.Windows.Forms.Button button_updatecourse;
    }
}