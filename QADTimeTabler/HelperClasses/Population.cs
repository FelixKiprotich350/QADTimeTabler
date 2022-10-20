using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using QADTimeTabler.Models;

namespace QADTimeTabler.HelperClasses
{
    public class Population
    {
         
        public Population()
        {
            ReloadAllItems();
        }

        public void ReloadAllItems()
        {
            Debug.WriteLine("Reloaded..........");
            ReloadDepartments();
            ReloadSchools();
            ReloadLectureHalls();
            ReloadCohorts();
            ReloadCourses();
            ReloadLecturers();
            ReloadPreClasses();
            ReloadLHLocations();
        }

        public void ReloadPreClasses()
        {
            try
            {
                ReloadCourses();
                ReloadCohorts();
                
                ModelsLists.Preclasses.Clear();
                //get joint data here from lecturer , class and courses
                //SELECT s.*,l.Preferences,c.CourseNature FROM lecturers l, courses c, classes s where l.lecid=s.Lecturer and s.CourseCode=c.CourseCode;
                var db = new TimeDbContext();
                //.Preclasses = db.PreClasses.AsNoTracking().ToList();
                var classes = db.ClassObjects.AsNoTracking().ToList();
                foreach(var a in classes)
                {
                    var lec = ModelsLists.Lecturers.Where(b=>b.LecturerID==a.Lecturer).FirstOrDefault();
                    var course = ModelsLists.Courses.Where(b=>b.CourseCode==a.CourseCode).FirstOrDefault();
                    PreClass p = new PreClass()
                    {
                        CourseCode = a.CourseCode,
                        IsChild = a.IsChild,
                        ParentCourse = a.ParentCourse,
                        CourseNature = course.CourseNature,
                        Lecturer = lec.LecturerID,
                        LecturerPreferences = lec.Preferences,
                        Cohorts = GetCohortsList(a.Cohorts),
                        TotalStudents = GetCohortsTotalCount(a.Cohorts),
                        CoursePriority = GetClassPriority(lec.Preferences, (decimal)GetCohortsTotalCount(a.Cohorts))

                    };
                    ModelsLists.Preclasses.Add(p);
                }
                //join b in db.Courses on a.CourseCode equals b.CourseCode
                //join c in db.Lecturers on a.Lecturer equals c.LecturerID
                //select new
                //{
                //    CourseCode = a.CourseCode,
                //    IsChild = a.IsChild,
                //    ParentCourse = a.ParentCourse,
                //    CourseNature = b.CourseNature,
                //    LecturerID = c.LecturerID,
                //    LecturerPreferences = c.Preferences,
                //    Cohorts=a.Cohorts,
                //    TotalStudents = GetCohortsTotalCount(a.Cohorts),
                //    CoursePriority = GetClassPriority(c.Preferences, (decimal)GetCohortsTotalCount(a.Cohorts))
                //};
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadCourses()
        {
            try
            { 
                ModelsLists.Courses.Clear();
                var db = new TimeDbContext();
                ModelsLists.Courses = db.Courses.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadLectureHalls()
        {
            try
            {
                
                ModelsLists.LectureHalls.Clear();
                var db = new TimeDbContext();
                ModelsLists.LectureHalls = db.LectureHalls.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadLecturers()
        {
            try
            { 
                ModelsLists.Lecturers.Clear();
                var db = new TimeDbContext();
                ModelsLists.Lecturers = db.Lecturers.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadCohorts()
        {
            try
            { 
                ModelsLists.CohortsList.Clear();
                var db = new TimeDbContext();
                ModelsLists.CohortsList = db.Cohorts.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadSchools()
        {
            try
            { 
                ModelsLists.Schools.Clear();
                var db = new TimeDbContext();
                ModelsLists.Schools = db.Schools.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadDepartments()
        {
            try
            { 
                ModelsLists.Departments.Clear();
                var db = new TimeDbContext();
                ModelsLists.Departments = db.Departments.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
        public void ReloadLHLocations()
        {
            try
            { 
                ModelsLists.LHLocations.Clear();
                var db = new TimeDbContext();
                ModelsLists.LHLocations = db.LHLocations.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public List<string> GetStringDepartments()
        {
            List<string> result = new List<string>() ;
            foreach (var a in ModelsLists.Departments)
            {
                result.Add(a.DepartmentName);
            }
            return result;

        }
        public List<string> GetStringSchools()
        {
            List<string> result = new List<string>();
            foreach (var a in ModelsLists.Schools)
            {
                result.Add(a.SchoolName);
            }
            return result;

        }
        public List<string> GetStringLHLocations()
        {
            List<string> result = new List<string>();
            foreach (var a in ModelsLists.LHLocations)
            {
                result.Add(a.ShortName);
            }
            return result;
        }


        #region Private functions
        private decimal GetClassPriority(string LecturerPreferences, decimal TotalStudents)
        {
            decimal x = 5;
            decimal y = LecturerPreferences.Split(',').Count(m => !string.IsNullOrEmpty(m));
            decimal z = TotalStudents;
            decimal _Priority = 0;
            _Priority = (x - y + 1) * (z / x);
            return _Priority;
        }
        private int GetCohortsTotalCount(string Cohorts)
        {
            int a = 0;
            try
            {
                if (ModelsLists.CohortsList.Count > 0)
                {
                    string[] Items = Cohorts.Split(',').Where(g => !string.IsNullOrEmpty(g)).ToArray();
                    foreach (string Item in Items)
                    {
                        int t = ModelsLists.CohortsList.Where(n => n.ShortCode == Item).Count();
                        a += t;
                    }
                }

            }
            catch
            {
                a = 0;
            }
            return a;
        }
        private List<Cohort> GetCohortsList(string cohorts)
        {
            List<Cohort> Flist=new List<Cohort>();
            try
            {
                if (ModelsLists.CohortsList.Count > 0)
                {
                    string[] Items = cohorts.Split(',').Where(g => !string.IsNullOrEmpty(g)).ToArray();
                    foreach (string Item in Items)
                    {
                        if(ModelsLists.CohortsList.Where(q => q.ShortCode == Item).Count() > 0)
                        {
                            Flist.Add(ModelsLists.CohortsList.Where(q => q.ShortCode == Item).First());
                        }
                    }
                }

            }
            catch
            {
                Flist = null;
            }
            return Flist;
        }
        #endregion
    }
 }