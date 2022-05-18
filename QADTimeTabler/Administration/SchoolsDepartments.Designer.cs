namespace QADTimeTabler.Administration
{
    partial class SchoolsDepartments
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
            this.Btn_RefreshSchools = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GridView_Schools = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_SaveSchool = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_SaveDepartment = new System.Windows.Forms.Button();
            this.Gridview_Departments = new System.Windows.Forms.DataGridView();
            this.Btn_RefreshDepartments = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Schools)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Departments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_RefreshSchools);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.GridView_Schools);
            this.groupBox1.Controls.Add(this.Btn_SaveSchool);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schools";
            // 
            // Btn_RefreshSchools
            // 
            this.Btn_RefreshSchools.Location = new System.Drawing.Point(224, 181);
            this.Btn_RefreshSchools.Name = "Btn_RefreshSchools";
            this.Btn_RefreshSchools.Size = new System.Drawing.Size(83, 29);
            this.Btn_RefreshSchools.TabIndex = 14;
            this.Btn_RefreshSchools.Text = "Refresh";
            this.Btn_RefreshSchools.UseVisualStyleBackColor = true;
            this.Btn_RefreshSchools.Click += new System.EventHandler(this.Btn_RefreshSchools_Click);
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(87, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 26);
            this.textBox3.TabIndex = 13;
            // 
            // GridView_Schools
            // 
            this.GridView_Schools.AllowUserToAddRows = false;
            this.GridView_Schools.AllowUserToDeleteRows = false;
            this.GridView_Schools.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Schools.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridView_Schools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Schools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.GridView_Schools.EnableHeadersVisualStyles = false;
            this.GridView_Schools.Location = new System.Drawing.Point(50, 232);
            this.GridView_Schools.Name = "GridView_Schools";
            this.GridView_Schools.ReadOnly = true;
            this.GridView_Schools.RowHeadersVisible = false;
            this.GridView_Schools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView_Schools.Size = new System.Drawing.Size(314, 233);
            this.GridView_Schools.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "SchoolCode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Btn_SaveSchool
            // 
            this.Btn_SaveSchool.Location = new System.Drawing.Point(116, 181);
            this.Btn_SaveSchool.Name = "Btn_SaveSchool";
            this.Btn_SaveSchool.Size = new System.Drawing.Size(83, 29);
            this.Btn_SaveSchool.TabIndex = 8;
            this.Btn_SaveSchool.Text = "Save";
            this.Btn_SaveSchool.UseVisualStyleBackColor = true;
            this.Btn_SaveSchool.Click += new System.EventHandler(this.Btn_SaveSchool_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Full Name";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(87, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "School Code";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(68, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 26);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "School";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(68, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 28);
            this.comboBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Department Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.Btn_SaveDepartment);
            this.groupBox2.Controls.Add(this.Gridview_Departments);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.Btn_RefreshDepartments);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(428, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 498);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departments";
            // 
            // Btn_SaveDepartment
            // 
            this.Btn_SaveDepartment.Location = new System.Drawing.Point(82, 181);
            this.Btn_SaveDepartment.Name = "Btn_SaveDepartment";
            this.Btn_SaveDepartment.Size = new System.Drawing.Size(83, 29);
            this.Btn_SaveDepartment.TabIndex = 14;
            this.Btn_SaveDepartment.Text = "Save";
            this.Btn_SaveDepartment.UseVisualStyleBackColor = true;
            this.Btn_SaveDepartment.Click += new System.EventHandler(this.Btn_SaveDepartment_Click);
            // 
            // Gridview_Departments
            // 
            this.Gridview_Departments.AllowUserToAddRows = false;
            this.Gridview_Departments.AllowUserToDeleteRows = false;
            this.Gridview_Departments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridview_Departments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gridview_Departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_Departments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1});
            this.Gridview_Departments.EnableHeadersVisualStyles = false;
            this.Gridview_Departments.Location = new System.Drawing.Point(54, 232);
            this.Gridview_Departments.Name = "Gridview_Departments";
            this.Gridview_Departments.ReadOnly = true;
            this.Gridview_Departments.RowHeadersVisible = false;
            this.Gridview_Departments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridview_Departments.Size = new System.Drawing.Size(385, 233);
            this.Gridview_Departments.TabIndex = 13;
            // 
            // Btn_RefreshDepartments
            // 
            this.Btn_RefreshDepartments.Location = new System.Drawing.Point(196, 181);
            this.Btn_RefreshDepartments.Name = "Btn_RefreshDepartments";
            this.Btn_RefreshDepartments.Size = new System.Drawing.Size(83, 29);
            this.Btn_RefreshDepartments.TabIndex = 9;
            this.Btn_RefreshDepartments.Text = "Refresh";
            this.Btn_RefreshDepartments.UseVisualStyleBackColor = true;
            this.Btn_RefreshDepartments.Click += new System.EventHandler(this.Btn_RefreshDepartments_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prority";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "School";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Priority";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // SchoolsDepartments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1167, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchoolsDepartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Users";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Schools)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Departments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_SaveSchool;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_RefreshDepartments;
        private System.Windows.Forms.DataGridView GridView_Schools;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView Gridview_Departments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Btn_RefreshSchools;
        private System.Windows.Forms.Button Btn_SaveDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}