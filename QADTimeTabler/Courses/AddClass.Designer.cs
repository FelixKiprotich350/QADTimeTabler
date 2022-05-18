namespace QADTimeTabler.Courses
{
    partial class AddClass
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
            this.Btn_SelectLecturer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Gridview_Cohorts = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBox_Subclasses = new System.Windows.Forms.CheckBox();
            this.DataGridView_subgroups = new System.Windows.Forms.DataGridView();
            this.Btn_SaveSubClasses = new System.Windows.Forms.Button();
            this.Btn_SaveDefault = new System.Windows.Forms.Button();
            this.GroupBox_MultipleGroups = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Cohorts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_subgroups)).BeginInit();
            this.GroupBox_MultipleGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_SelectLecturer
            // 
            this.Btn_SelectLecturer.Location = new System.Drawing.Point(400, 104);
            this.Btn_SelectLecturer.Name = "Btn_SelectLecturer";
            this.Btn_SelectLecturer.Size = new System.Drawing.Size(70, 28);
            this.Btn_SelectLecturer.TabIndex = 0;
            this.Btn_SelectLecturer.Text = "Select";
            this.Btn_SelectLecturer.UseVisualStyleBackColor = true;
            this.Btn_SelectLecturer.Click += new System.EventHandler(this.Btn_SelectLecturer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Title";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(126, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(346, 26);
            this.textBox1.TabIndex = 2;
            // 
            // Gridview_Cohorts
            // 
            this.Gridview_Cohorts.AllowUserToAddRows = false;
            this.Gridview_Cohorts.AllowUserToDeleteRows = false;
            this.Gridview_Cohorts.AllowUserToResizeColumns = false;
            this.Gridview_Cohorts.AllowUserToResizeRows = false;
            this.Gridview_Cohorts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridview_Cohorts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gridview_Cohorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_Cohorts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4});
            this.Gridview_Cohorts.Location = new System.Drawing.Point(12, 89);
            this.Gridview_Cohorts.Name = "Gridview_Cohorts";
            this.Gridview_Cohorts.ReadOnly = true;
            this.Gridview_Cohorts.RowHeadersVisible = false;
            this.Gridview_Cohorts.Size = new System.Drawing.Size(154, 151);
            this.Gridview_Cohorts.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(126, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(122, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Code";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(372, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course Nature";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(275, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(190, 26);
            this.textBox4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Full Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(275, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(106, 26);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lecturer ID";
            // 
            // CheckBox_Subclasses
            // 
            this.CheckBox_Subclasses.AutoSize = true;
            this.CheckBox_Subclasses.Location = new System.Drawing.Point(184, 196);
            this.CheckBox_Subclasses.Name = "CheckBox_Subclasses";
            this.CheckBox_Subclasses.Size = new System.Drawing.Size(113, 24);
            this.CheckBox_Subclasses.TabIndex = 13;
            this.CheckBox_Subclasses.Text = "SubClasses";
            this.CheckBox_Subclasses.UseVisualStyleBackColor = true;
            this.CheckBox_Subclasses.CheckedChanged += new System.EventHandler(this.CheckBox_Subclasses_CheckedChanged);
            // 
            // DataGridView_subgroups
            // 
            this.DataGridView_subgroups.AllowUserToAddRows = false;
            this.DataGridView_subgroups.AllowUserToDeleteRows = false;
            this.DataGridView_subgroups.AllowUserToResizeColumns = false;
            this.DataGridView_subgroups.AllowUserToResizeRows = false;
            this.DataGridView_subgroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_subgroups.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView_subgroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_subgroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.Column2});
            this.DataGridView_subgroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridView_subgroups.Location = new System.Drawing.Point(3, 22);
            this.DataGridView_subgroups.Name = "DataGridView_subgroups";
            this.DataGridView_subgroups.ReadOnly = true;
            this.DataGridView_subgroups.RowHeadersVisible = false;
            this.DataGridView_subgroups.Size = new System.Drawing.Size(349, 138);
            this.DataGridView_subgroups.TabIndex = 14;
            // 
            // Btn_SaveSubClasses
            // 
            this.Btn_SaveSubClasses.Location = new System.Drawing.Point(373, 66);
            this.Btn_SaveSubClasses.Name = "Btn_SaveSubClasses";
            this.Btn_SaveSubClasses.Size = new System.Drawing.Size(70, 28);
            this.Btn_SaveSubClasses.TabIndex = 15;
            this.Btn_SaveSubClasses.Text = "Save";
            this.Btn_SaveSubClasses.UseVisualStyleBackColor = true;
            // 
            // Btn_SaveDefault
            // 
            this.Btn_SaveDefault.Location = new System.Drawing.Point(373, 192);
            this.Btn_SaveDefault.Name = "Btn_SaveDefault";
            this.Btn_SaveDefault.Size = new System.Drawing.Size(70, 28);
            this.Btn_SaveDefault.TabIndex = 16;
            this.Btn_SaveDefault.Text = "Save";
            this.Btn_SaveDefault.UseVisualStyleBackColor = true;
            this.Btn_SaveDefault.Click += new System.EventHandler(this.Btn_SaveDefault_Click);
            // 
            // GroupBox_MultipleGroups
            // 
            this.GroupBox_MultipleGroups.Controls.Add(this.DataGridView_subgroups);
            this.GroupBox_MultipleGroups.Controls.Add(this.Btn_SaveSubClasses);
            this.GroupBox_MultipleGroups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox_MultipleGroups.Enabled = false;
            this.GroupBox_MultipleGroups.Location = new System.Drawing.Point(0, 246);
            this.GroupBox_MultipleGroups.Name = "GroupBox_MultipleGroups";
            this.GroupBox_MultipleGroups.Size = new System.Drawing.Size(477, 163);
            this.GroupBox_MultipleGroups.TabIndex = 17;
            this.GroupBox_MultipleGroups.TabStop = false;
            this.GroupBox_MultipleGroups.Text = "Multiple Groups";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Group";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ClassID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cohorts";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // AddClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(477, 409);
            this.Controls.Add(this.GroupBox_MultipleGroups);
            this.Controls.Add(this.Btn_SaveDefault);
            this.Controls.Add(this.CheckBox_Subclasses);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gridview_Cohorts);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_SelectLecturer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Class";
            this.Load += new System.EventHandler(this.AddClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_Cohorts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_subgroups)).EndInit();
            this.GroupBox_MultipleGroups.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SelectLecturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Gridview_Cohorts;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckBox_Subclasses;
        private System.Windows.Forms.DataGridView DataGridView_subgroups;
        private System.Windows.Forms.Button Btn_SaveSubClasses;
        private System.Windows.Forms.Button Btn_SaveDefault;
        private System.Windows.Forms.GroupBox GroupBox_MultipleGroups;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}