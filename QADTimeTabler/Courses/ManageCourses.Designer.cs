namespace QADTimeTabler.Courses
{
    partial class ManageCourses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_SelectAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView_CourseList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_ViewAll = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridView_Cohorts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CourseList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Cohorts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridView_Cohorts);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Btn_Reset);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_SelectAdd);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Course";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Department";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(12, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 26);
            this.textBox2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Course Title";
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(172, 372);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(72, 29);
            this.Btn_Reset.TabIndex = 13;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Practical",
            "Literature",
            "Mathematical"});
            this.comboBox2.Location = new System.Drawing.Point(12, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(240, 28);
            this.comboBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Course Nature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cohorts";
            // 
            // Btn_SelectAdd
            // 
            this.Btn_SelectAdd.Location = new System.Drawing.Point(172, 309);
            this.Btn_SelectAdd.Name = "Btn_SelectAdd";
            this.Btn_SelectAdd.Size = new System.Drawing.Size(72, 29);
            this.Btn_SelectAdd.TabIndex = 9;
            this.Btn_SelectAdd.Text = "Select";
            this.Btn_SelectAdd.UseVisualStyleBackColor = true;
            this.Btn_SelectAdd.Click += new System.EventHandler(this.Btn_SelectAdd_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(172, 441);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(72, 29);
            this.Btn_Save.TabIndex = 8;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridView_CourseList);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(268, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 498);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courses List";
            // 
            // DataGridView_CourseList
            // 
            this.DataGridView_CourseList.AllowUserToAddRows = false;
            this.DataGridView_CourseList.AllowUserToDeleteRows = false;
            this.DataGridView_CourseList.AllowUserToResizeRows = false;
            this.DataGridView_CourseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_CourseList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_CourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_CourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column4,
            this.dataGridViewTextBoxColumn2});
            this.DataGridView_CourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_CourseList.EnableHeadersVisualStyles = false;
            this.DataGridView_CourseList.Location = new System.Drawing.Point(3, 94);
            this.DataGridView_CourseList.Name = "DataGridView_CourseList";
            this.DataGridView_CourseList.ReadOnly = true;
            this.DataGridView_CourseList.RowHeadersVisible = false;
            this.DataGridView_CourseList.Size = new System.Drawing.Size(893, 401);
            this.DataGridView_CourseList.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_ViewAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 72);
            this.panel1.TabIndex = 0;
            // 
            // Btn_ViewAll
            // 
            this.Btn_ViewAll.Location = new System.Drawing.Point(25, 25);
            this.Btn_ViewAll.Name = "Btn_ViewAll";
            this.Btn_ViewAll.Size = new System.Drawing.Size(87, 29);
            this.Btn_ViewAll.TabIndex = 10;
            this.Btn_ViewAll.Text = "View All";
            this.Btn_ViewAll.UseVisualStyleBackColor = true;
            this.Btn_ViewAll.Click += new System.EventHandler(this.Btn_ViewAll_Click);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Course Code";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Course Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CourseNature";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Department";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cohorts";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // GridView_Cohorts
            // 
            this.GridView_Cohorts.AllowUserToAddRows = false;
            this.GridView_Cohorts.AllowUserToDeleteRows = false;
            this.GridView_Cohorts.AllowUserToResizeRows = false;
            this.GridView_Cohorts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Cohorts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridView_Cohorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Cohorts.ColumnHeadersVisible = false;
            this.GridView_Cohorts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.GridView_Cohorts.EnableHeadersVisualStyles = false;
            this.GridView_Cohorts.Location = new System.Drawing.Point(12, 300);
            this.GridView_Cohorts.Name = "GridView_Cohorts";
            this.GridView_Cohorts.ReadOnly = true;
            this.GridView_Cohorts.RowHeadersVisible = false;
            this.GridView_Cohorts.Size = new System.Drawing.Size(150, 186);
            this.GridView_Cohorts.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cohort";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ManageCourses
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1167, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Courses";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CourseList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Cohorts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_SelectAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_ViewAll;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridView DataGridView_CourseList;
        public System.Windows.Forms.DataGridView GridView_Cohorts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}