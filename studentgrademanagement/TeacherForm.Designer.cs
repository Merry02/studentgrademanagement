namespace studentgrademanagement
{
    partial class TeacherForm
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
            this.TeacherGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add2 = new System.Windows.Forms.Button();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherGrid
            // 
            this.TeacherGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.TeacherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherGrid.Location = new System.Drawing.Point(8, 45);
            this.TeacherGrid.Name = "TeacherGrid";
            this.TeacherGrid.Size = new System.Drawing.Size(1079, 227);
            this.TeacherGrid.TabIndex = 76;
            this.TeacherGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherGrid_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(0, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 26);
            this.panel3.TabIndex = 72;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_clear.BackColor = System.Drawing.Color.Wheat;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.Brown;
            this.button_clear.Location = new System.Drawing.Point(759, 241);
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
            this.button_delete.Location = new System.Drawing.Point(840, 241);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 28);
            this.button_delete.TabIndex = 62;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_update.BackColor = System.Drawing.Color.YellowGreen;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.Brown;
            this.button_update.Location = new System.Drawing.Point(921, 241);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 28);
            this.button_update.TabIndex = 59;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
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
            this.label7.Text = "Teacher Management";
            // 
            // button_add2
            // 
            this.button_add2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_add2.BackColor = System.Drawing.Color.LightGray;
            this.button_add2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add2.ForeColor = System.Drawing.Color.Brown;
            this.button_add2.Location = new System.Drawing.Point(1002, 241);
            this.button_add2.Name = "button_add2";
            this.button_add2.Size = new System.Drawing.Size(75, 28);
            this.button_add2.TabIndex = 66;
            this.button_add2.Text = "Add";
            this.button_add2.UseVisualStyleBackColor = false;
            this.button_add2.Click += new System.EventHandler(this.button_add2_Click);
            // 
            // radioButton_female
            // 
            this.radioButton_female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.ForeColor = System.Drawing.Color.Brown;
            this.radioButton_female.Location = new System.Drawing.Point(260, 131);
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
            this.radioButton_Male.Location = new System.Drawing.Point(179, 131);
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
            this.label4.Location = new System.Drawing.Point(84, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "Gender:";
            // 
            // textbox_Lname
            // 
            this.textbox_Lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_Lname.Location = new System.Drawing.Point(534, 53);
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
            this.label2.Location = new System.Drawing.Point(439, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Last Name:";
            // 
            // textbox_Fname
            // 
            this.textbox_Fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_Fname.Location = new System.Drawing.Point(179, 53);
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
            this.label1.Location = new System.Drawing.Point(84, 56);
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
            this.panel2.Size = new System.Drawing.Size(1075, 11);
            this.panel2.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_add2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.button_clear);
            this.panel4.Controls.Add(this.button_delete);
            this.panel4.Controls.Add(this.button_update);
            this.panel4.Controls.Add(this.radioButton_female);
            this.panel4.Controls.Add(this.radioButton_Male);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textbox_Lname);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textbox_Fname);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 325);
            this.panel4.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 46);
            this.panel1.TabIndex = 71;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.TeacherGrid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TeacherGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_add2;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}