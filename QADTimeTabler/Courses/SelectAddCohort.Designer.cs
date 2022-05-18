namespace QADTimeTabler.Courses
{
    partial class SelectAddCohort
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
            this.DataGridView_CohortsList = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_ViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CohortsList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_CohortsList
            // 
            this.DataGridView_CohortsList.AllowUserToAddRows = false;
            this.DataGridView_CohortsList.AllowUserToDeleteRows = false;
            this.DataGridView_CohortsList.AllowUserToResizeColumns = false;
            this.DataGridView_CohortsList.AllowUserToResizeRows = false;
            this.DataGridView_CohortsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_CohortsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_CohortsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_CohortsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column4,
            this.dataGridViewTextBoxColumn2,
            this.Column5});
            this.DataGridView_CohortsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_CohortsList.EnableHeadersVisualStyles = false;
            this.DataGridView_CohortsList.Location = new System.Drawing.Point(0, 72);
            this.DataGridView_CohortsList.Name = "DataGridView_CohortsList";
            this.DataGridView_CohortsList.ReadOnly = true;
            this.DataGridView_CohortsList.RowHeadersVisible = false;
            this.DataGridView_CohortsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_CohortsList.Size = new System.Drawing.Size(756, 426);
            this.DataGridView_CohortsList.TabIndex = 9;
            this.DataGridView_CohortsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CohortsList_CellDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ShortCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Title";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Count";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "School";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_ViewAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 72);
            this.panel1.TabIndex = 0;
            // 
            // Btn_ViewAll
            // 
            this.Btn_ViewAll.Location = new System.Drawing.Point(30, 22);
            this.Btn_ViewAll.Name = "Btn_ViewAll";
            this.Btn_ViewAll.Size = new System.Drawing.Size(83, 29);
            this.Btn_ViewAll.TabIndex = 10;
            this.Btn_ViewAll.Text = "View All";
            this.Btn_ViewAll.UseVisualStyleBackColor = true;
            this.Btn_ViewAll.Click += new System.EventHandler(this.Btn_ViewAll_Click_1);
            // 
            // SelectAddCohort
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(756, 498);
            this.Controls.Add(this.DataGridView_CohortsList);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectAddCohort";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Cohort";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CohortsList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView_CohortsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Btn_ViewAll;
    }
}