using QADTimeTabler.Cohorts;
using QADTimeTabler.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QADTimeTabler.LecHalls;
using QADTimeTabler.Timetabling;
using QADTimeTabler.Courses;
using QADTimeTabler.Lecturers;
using QADTimeTabler.HelperClasses; 

namespace QADTimeTabler
{
    public partial class Dashboard : Form
    {

        Population PP = new Population();
        public Dashboard()
        {
            Home h = new Home();
            InitializeComponent();
            ShowForm(h);
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {

        }

        private void ShowForm(Form c)
        {
            try
            {
                PP.ReloadAllItems();
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == c.GetType())
                    {
                        //f.BringToFront();
                        //f.Activate();
                        f.Close(); 
                    }

                }

                c.MdiParent = this;
                c.Dock = DockStyle.Fill;
                c.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TS_Home_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            ShowForm(h);
        }

        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ManageCourses());
        }

        private void GenerateTimetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new GenerateTimetable());
        }

        private void SchoolsDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new SchoolsDepartments());
        }

        private void AddClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new SelectClassCourse());
        }

        private void ViewClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ViewClasses());
        }

        private void TimetablingSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageLecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ManageLecturers());
        }

        private void ManageLectureHallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ManageRooms());
        }

        private void ManageCohortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ManageCohorts());
        }

        private void DatabaseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new DataManager());
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog(this);
        }

        private void HowToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToForm h = new HowToForm();
            h.Show(this);
        }
    }
}
