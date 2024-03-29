﻿namespace QADTimeTabler
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TS_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Cohorts = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageCohortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectureHallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageLectureHallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Lecturers = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageLecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Courses = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Timetabling = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTimetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewTimetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modifyTimetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TimetablingSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolsDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Home,
            this.TS_Cohorts,
            this.lectureHallsToolStripMenuItem,
            this.TS_Lecturers,
            this.TS_Courses,
            this.TS_Timetabling,
            this.TS_Administration,
            this.TS_Windows,
            this.TS_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.TS_Windows;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TS_Home
            // 
            this.TS_Home.Name = "TS_Home";
            this.TS_Home.Size = new System.Drawing.Size(58, 23);
            this.TS_Home.Text = "Home";
            this.TS_Home.Click += new System.EventHandler(this.TS_Home_Click);
            // 
            // TS_Cohorts
            // 
            this.TS_Cohorts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageCohortsToolStripMenuItem});
            this.TS_Cohorts.Name = "TS_Cohorts";
            this.TS_Cohorts.Size = new System.Drawing.Size(70, 23);
            this.TS_Cohorts.Text = "Cohorts";
            // 
            // ManageCohortsToolStripMenuItem
            // 
            this.ManageCohortsToolStripMenuItem.Name = "ManageCohortsToolStripMenuItem";
            this.ManageCohortsToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.ManageCohortsToolStripMenuItem.Text = "Manage Cohorts";
            this.ManageCohortsToolStripMenuItem.Click += new System.EventHandler(this.ManageCohortsToolStripMenuItem_Click);
            // 
            // lectureHallsToolStripMenuItem
            // 
            this.lectureHallsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageLectureHallsToolStripMenuItem});
            this.lectureHallsToolStripMenuItem.Name = "lectureHallsToolStripMenuItem";
            this.lectureHallsToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.lectureHallsToolStripMenuItem.Text = "Lecture Halls";
            // 
            // ManageLectureHallsToolStripMenuItem
            // 
            this.ManageLectureHallsToolStripMenuItem.Name = "ManageLectureHallsToolStripMenuItem";
            this.ManageLectureHallsToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.ManageLectureHallsToolStripMenuItem.Text = "Manage LectureHalls";
            this.ManageLectureHallsToolStripMenuItem.Click += new System.EventHandler(this.ManageLectureHallsToolStripMenuItem_Click);
            // 
            // TS_Lecturers
            // 
            this.TS_Lecturers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageLecturersToolStripMenuItem});
            this.TS_Lecturers.Name = "TS_Lecturers";
            this.TS_Lecturers.Size = new System.Drawing.Size(77, 23);
            this.TS_Lecturers.Text = "Lecturers";
            // 
            // ManageLecturersToolStripMenuItem
            // 
            this.ManageLecturersToolStripMenuItem.Name = "ManageLecturersToolStripMenuItem";
            this.ManageLecturersToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.ManageLecturersToolStripMenuItem.Text = "Manage Lecturers";
            this.ManageLecturersToolStripMenuItem.Click += new System.EventHandler(this.ManageLecturersToolStripMenuItem_Click);
            // 
            // TS_Courses
            // 
            this.TS_Courses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.AddClassToolStripMenuItem,
            this.ViewClassesToolStripMenuItem});
            this.TS_Courses.Name = "TS_Courses";
            this.TS_Courses.Size = new System.Drawing.Size(70, 23);
            this.TS_Courses.Text = "Courses";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.addCourseToolStripMenuItem.Text = "Manage Courses";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.AddCourseToolStripMenuItem_Click);
            // 
            // AddClassToolStripMenuItem
            // 
            this.AddClassToolStripMenuItem.Name = "AddClassToolStripMenuItem";
            this.AddClassToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.AddClassToolStripMenuItem.Text = "Add Class";
            this.AddClassToolStripMenuItem.Click += new System.EventHandler(this.AddClassToolStripMenuItem_Click);
            // 
            // ViewClassesToolStripMenuItem
            // 
            this.ViewClassesToolStripMenuItem.Name = "ViewClassesToolStripMenuItem";
            this.ViewClassesToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.ViewClassesToolStripMenuItem.Text = "View Classes";
            this.ViewClassesToolStripMenuItem.Click += new System.EventHandler(this.ViewClassesToolStripMenuItem_Click);
            // 
            // TS_Timetabling
            // 
            this.TS_Timetabling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateTimetableToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewTimetableToolStripMenuItem,
            this.toolStripSeparator2,
            this.modifyTimetableToolStripMenuItem,
            this.toolStripSeparator3,
            this.TimetablingSettingsToolStripMenuItem});
            this.TS_Timetabling.Name = "TS_Timetabling";
            this.TS_Timetabling.Size = new System.Drawing.Size(92, 23);
            this.TS_Timetabling.Text = "Timetabling";
            // 
            // generateTimetableToolStripMenuItem
            // 
            this.generateTimetableToolStripMenuItem.Name = "generateTimetableToolStripMenuItem";
            this.generateTimetableToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.generateTimetableToolStripMenuItem.Text = "Generate Timetable";
            this.generateTimetableToolStripMenuItem.Click += new System.EventHandler(this.GenerateTimetableToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // viewTimetableToolStripMenuItem
            // 
            this.viewTimetableToolStripMenuItem.Name = "viewTimetableToolStripMenuItem";
            this.viewTimetableToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.viewTimetableToolStripMenuItem.Text = "View Timetable";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // modifyTimetableToolStripMenuItem
            // 
            this.modifyTimetableToolStripMenuItem.Name = "modifyTimetableToolStripMenuItem";
            this.modifyTimetableToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.modifyTimetableToolStripMenuItem.Text = "Modify Timetable";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // TimetablingSettingsToolStripMenuItem
            // 
            this.TimetablingSettingsToolStripMenuItem.Name = "TimetablingSettingsToolStripMenuItem";
            this.TimetablingSettingsToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.TimetablingSettingsToolStripMenuItem.Text = "Timetabling Settings";
            this.TimetablingSettingsToolStripMenuItem.Click += new System.EventHandler(this.TimetablingSettingsToolStripMenuItem_Click);
            // 
            // TS_Administration
            // 
            this.TS_Administration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolsDepartmentsToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.databaseManagementToolStripMenuItem});
            this.TS_Administration.Name = "TS_Administration";
            this.TS_Administration.Size = new System.Drawing.Size(111, 23);
            this.TS_Administration.Text = "Administration";
            // 
            // schoolsDepartmentsToolStripMenuItem
            // 
            this.schoolsDepartmentsToolStripMenuItem.Name = "schoolsDepartmentsToolStripMenuItem";
            this.schoolsDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.schoolsDepartmentsToolStripMenuItem.Text = "Schools && Departments";
            this.schoolsDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.SchoolsDepartmentsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // databaseManagementToolStripMenuItem
            // 
            this.databaseManagementToolStripMenuItem.Name = "databaseManagementToolStripMenuItem";
            this.databaseManagementToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.databaseManagementToolStripMenuItem.Text = "Data Manager";
            this.databaseManagementToolStripMenuItem.Click += new System.EventHandler(this.DatabaseManagementToolStripMenuItem_Click);
            // 
            // TS_Windows
            // 
            this.TS_Windows.Name = "TS_Windows";
            this.TS_Windows.Size = new System.Drawing.Size(77, 23);
            this.TS_Windows.Text = "Windows";
            // 
            // TS_Help
            // 
            this.TS_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.TS_Help.Name = "TS_Help";
            this.TS_Help.Size = new System.Drawing.Size(49, 23);
            this.TS_Help.Text = "Help";
            // 
            // HowToToolStripMenuItem
            // 
            this.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem";
            this.HowToToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.HowToToolStripMenuItem.Text = "How To";
            this.HowToToolStripMenuItem.Click += new System.EventHandler(this.HowToToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.AboutToolStripMenuItem.Text = "About QADTimeTabler";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 711);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1350, 726);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QAD Timetabler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Shown += new System.EventHandler(this.Dashboard_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TS_Home;
        private System.Windows.Forms.ToolStripMenuItem TS_Cohorts;
        private System.Windows.Forms.ToolStripMenuItem TS_Lecturers;
        private System.Windows.Forms.ToolStripMenuItem TS_Courses;
        private System.Windows.Forms.ToolStripMenuItem TS_Timetabling;
        private System.Windows.Forms.ToolStripMenuItem TS_Administration;
        private System.Windows.Forms.ToolStripMenuItem TS_Windows;
        private System.Windows.Forms.ToolStripMenuItem TS_Help;
        private System.Windows.Forms.ToolStripMenuItem HowToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTimetableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTimetableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyTimetableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem lectureHallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolsDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimetablingSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageCohortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageLectureHallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageLecturersToolStripMenuItem;
    }
}

