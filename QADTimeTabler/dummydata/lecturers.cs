using QADTimeTabler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QADTimeTabler
{
    public partial class automation : Form
    {
        Random R = new Random();
        List<Course> templect = new List<Course>();
        List<Cohort> cohorts = new List<Cohort>();
        List<Lecturer> lecturers = new List<Lecturer>();
        public automation()
        {
            InitializeComponent();
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                templect.Clear();
                DataGridView_Lecturers.Rows.Clear();
                var db = new TimeDbContext(); 
                
                int t = 0;
                while (t < 500)
                {
                    string gencode=RandomString(3);
                    Course l = new Course()
                    {
                        CourseGuid = Guid.NewGuid().ToString(),
                        CourseCode =gencode +"-"+t,
                        CourseTitle = "Course-"+gencode,
                        Department = "SST",
                        CourseNature = "Literature",
                        Cohorts = pref()
                    };
                    if( l.Cohorts.Trim() != "")
                    {
                        templect.Add(l);
                        DataGridView_Lecturers.Rows.Add(l.CourseCode, l.CourseTitle, l.Department, l.Cohorts);
                    }
                   
                    t++;
                }
              
                //db.SaveChanges();
                MessageBox.Show(this, "Lecturer saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string pref()
        {
            string returnvalue = "";
            Cohort[] days = cohorts.ToArray();
            int prefcount = R.Next(0, 10);
            int x = 0;
            while (x<prefcount)
            { 
                Cohort day = days[R.Next(0, days.Length)];
                if (!returnvalue.Contains(day.ShortCode))
                {
                    returnvalue += day.ShortCode + ",";
                }
                x++;
            }
            return returnvalue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              
                var db = new TimeDbContext(); 
                db.Courses.AddRange(templect);
                db.SaveChanges();
                MessageBox.Show(this, "Lecturer saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void automation_Load(object sender, EventArgs e)
        {
            try
            {

                var db = new TimeDbContext();
                cohorts = db.Cohorts.AsNoTracking().ToList() ;
                lecturers = db.Lecturers.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new TimeDbContext();
                var courses = db.Courses.AsNoTracking().ToList();
                foreach(Course x in courses)
                { 
                    ClassObject pc = new ClassObject()
                    {
                        ClassGuid = Guid.NewGuid().ToString(),
                        CourseCode = x.CourseCode, 
                        ParentCourse = x.CourseCode,
                        Cohorts = x.Cohorts,
                        IsChild = false
                    };
                    var l = getlecturer();
                    if(l is null)
                    {
                        return;
                    }
                    else
                    {
                        pc.Lecturer = l.LecPFNo;
                    }
                    db.ClassObjects.Add(pc);
                    DataGridView_Lecturers.Rows.Add(pc.CourseCode, pc.Lecturer, pc.Cohorts);
                }
                
                db.SaveChanges();
                MessageBox.Show(this, "Class saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        List<Lecturer> occlec = new List<Lecturer>();
        Lecturer getlecturer()
        {
            try
            {
                Lecturer ll = null;
                var newlecturers = lecturers;
                int count = 0;
                while (count<lecturers.Count)
                {
                    int pos = R.Next(0, newlecturers.Count);
                    var lec = newlecturers[pos];
                    if (occlec.Count(a => a.LecPFNo == lec.LecPFNo) >= 10)
                    {
                        newlecturers.Remove(lec);
                    }
                    else
                    {
                        ll = lec;
                        break;
                        
                    }
                }
                return ll;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
