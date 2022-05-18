namespace QADTimeTabler.Courses
{
    partial class SelectClassCourse
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView_CourseList = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_ViewAll = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CourseList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(494, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(240, 28);
            this.comboBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Department";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(124, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1167, 498);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Course";
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
            this.DataGridView_CourseList.MultiSelect = false;
            this.DataGridView_CourseList.Name = "DataGridView_CourseList";
            this.DataGridView_CourseList.ReadOnly = true;
            this.DataGridView_CourseList.RowHeadersVisible = false;
            this.DataGridView_CourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_CourseList.Size = new System.Drawing.Size(1161, 401);
            this.DataGridView_CourseList.TabIndex = 9;
            this.DataGridView_CourseList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CourseList_CellDoubleClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_ViewAll);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 72);
            this.panel1.TabIndex = 0;
            // 
            // Btn_ViewAll
            // 
            this.Btn_ViewAll.Location = new System.Drawing.Point(23, 22);
            this.Btn_ViewAll.Name = "Btn_ViewAll";
            this.Btn_ViewAll.Size = new System.Drawing.Size(72, 29);
            this.Btn_ViewAll.TabIndex = 13;
            this.Btn_ViewAll.Text = "View All";
            this.Btn_ViewAll.UseVisualStyleBackColor = true;
            this.Btn_ViewAll.Click += new System.EventHandler(this.Btn_ViewAll_Click);
            // 
            // SelectClassCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1167, 498);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectClassCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Class Course";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CourseList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_ViewAll;
        public System.Windows.Forms.DataGridView DataGridView_CourseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}