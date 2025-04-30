namespace studentgrademanagement
{
    partial class StudentManagement
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_sid = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textbox_contactnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.button_add2 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(843, 54);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(182, 20);
            this.textBox_search.TabIndex = 68;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.DimGray;
            this.button_search.Location = new System.Drawing.Point(1044, 52);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 28);
            this.button_search.TabIndex = 69;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ID.Location = new System.Drawing.Point(536, 84);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(173, 20);
            this.textBox_ID.TabIndex = 65;
            // 
            // label_sid
            // 
            this.label_sid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_sid.AutoSize = true;
            this.label_sid.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sid.ForeColor = System.Drawing.Color.Brown;
            this.label_sid.Location = new System.Drawing.Point(443, 83);
            this.label_sid.Name = "label_sid";
            this.label_sid.Size = new System.Drawing.Size(94, 19);
            this.label_sid.TabIndex = 64;
            this.label_sid.Text = "Student ID:";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_clear.BackColor = System.Drawing.Color.Wheat;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.Brown;
            this.button_clear.Location = new System.Drawing.Point(776, 241);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 28);
            this.button_clear.TabIndex = 63;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete.BackColor = System.Drawing.Color.LightCoral;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.Brown;
            this.button_delete.Location = new System.Drawing.Point(857, 241);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 28);
            this.button_delete.TabIndex = 62;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textbox_contactnum
            // 
            this.textbox_contactnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_contactnum.Location = new System.Drawing.Point(831, 35);
            this.textbox_contactnum.Name = "textbox_contactnum";
            this.textbox_contactnum.Size = new System.Drawing.Size(182, 20);
            this.textbox_contactnum.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(686, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Contact Number:";
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_update.BackColor = System.Drawing.Color.YellowGreen;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.Brown;
            this.button_update.Location = new System.Drawing.Point(938, 241);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 28);
            this.button_update.TabIndex = 59;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_add2);
            this.panel4.Controls.Add(this.textBox_ID);
            this.panel4.Controls.Add(this.label_sid);
            this.panel4.Controls.Add(this.button_clear);
            this.panel4.Controls.Add(this.button_delete);
            this.panel4.Controls.Add(this.textbox_contactnum);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button_update);
            this.panel4.Controls.Add(this.textBox_address);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.radioButton_female);
            this.panel4.Controls.Add(this.radioButton_Male);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textbox_Lname);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textbox_Fname);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1131, 289);
            this.panel4.TabIndex = 67;
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_address.Location = new System.Drawing.Point(179, 142);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(401, 127);
            this.textBox_address.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(100, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Address:";
            // 
            // radioButton_female
            // 
            this.radioButton_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.ForeColor = System.Drawing.Color.Brown;
            this.radioButton_female.Location = new System.Drawing.Point(907, 82);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(82, 23);
            this.radioButton_female.TabIndex = 54;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Checked = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.ForeColor = System.Drawing.Color.Brown;
            this.radioButton_Male.Location = new System.Drawing.Point(826, 82);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(65, 23);
            this.radioButton_Male.TabIndex = 53;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(731, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "Gender:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(216, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(100, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Date of Birth:";
            // 
            // textbox_Lname
            // 
            this.textbox_Lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_Lname.Location = new System.Drawing.Point(487, 35);
            this.textbox_Lname.Name = "textbox_Lname";
            this.textbox_Lname.Size = new System.Drawing.Size(182, 20);
            this.textbox_Lname.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(392, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Last Name:";
            // 
            // textbox_Fname
            // 
            this.textbox_Fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_Fname.Location = new System.Drawing.Point(195, 35);
            this.textbox_Fname.Name = "textbox_Fname";
            this.textbox_Fname.Size = new System.Drawing.Size(182, 20);
            this.textbox_Fname.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(100, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "First Name:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 11);
            this.panel2.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student Management";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 610);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 26);
            this.panel3.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 46);
            this.panel1.TabIndex = 65;
            // 
            // studentGrid
            // 
            this.studentGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Location = new System.Drawing.Point(12, 94);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.Size = new System.Drawing.Size(1107, 227);
            this.studentGrid.TabIndex = 70;
            this.studentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGrid_CellContentClick);
            // 
            // button_add2
            // 
            this.button_add2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_add2.BackColor = System.Drawing.Color.LightGray;
            this.button_add2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add2.ForeColor = System.Drawing.Color.Brown;
            this.button_add2.Location = new System.Drawing.Point(1019, 241);
            this.button_add2.Name = "button_add2";
            this.button_add2.Size = new System.Drawing.Size(75, 28);
            this.button_add2.TabIndex = 66;
            this.button_add2.Text = "Add";
            this.button_add2.UseVisualStyleBackColor = false;
            this.button_add2.Click += new System.EventHandler(this.button_add2_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 636);
            this.Controls.Add(this.studentGrid);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StudentManagement";
            this.Text = "StudentManagement";
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_sid;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textbox_contactnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.Button button_add2;
    }
}