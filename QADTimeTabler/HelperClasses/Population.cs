using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QADTimeTabler.HelperModels;
using QADTimeTabler.Models;

namespace QADTimeTabler.HelperClasses
{
    public class Population
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        readonly MySqlConnection Con;
        public Population()
        {
            Con = new MySqlConnection(db.DbConnectionString());
        }

        public void ReloadAllItems()
        {
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
                Con.Close();
                Con.Open();
                ModelsLists.Preclasses.Clear();
                MySqlCommand com = new MySqlCommand("SELECT s.*,l.Preferences,c.CourseNature FROM lecturers l, courses c, classes s where l.lecid=s.Lecturer and s.CourseCode=c.CourseCode;", Con);
                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        int TotalStudents = GetCohortsTotalCount(Dr["Cohorts"].ToString());
                        String LecPref = Dr["Preferences"].ToString();
                        ModelsLists.Preclasses.Add(new PreClass()
                        {
                            CourseCode = Dr["CourseCode"].ToString(),
                            Lecturer = Dr["Lecturer"].ToString(),
                            IsChild = Convert.ToBoolean(Dr["IsChild"].ToString()),
                            ParentCourse = Dr["ParentCourse"].ToString(),
                            Cohorts = GetCohortsList(Dr["Cohorts"].ToString()),
                            CourseNature = Dr["CourseNature"].ToString(),
                            LecturerPreferences = LecPref,
                            TotalStudents = TotalStudents,
                            CoursePriority = GetClassPriority(LecPref,TotalStudents)

                        }) ; 
                    }
                }
                else
                {
                    MessageBox.Show(null, "No Class found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                Con.Close();
                Con.Open();
                ModelsLists.Courses.Clear();
                MySqlCommand com = new MySqlCommand("select * from courses", Con);
                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        ModelsLists.Courses.Add(new Course()
                        {
                            CourseCode = Dr["CourseCode"].ToString(),
                            CourseTitle = Dr["CourseTitle"].ToString(),
                            Department = Dr["Department"].ToString(),
                            CourseNature = Dr["CourseNature"].ToString(),
                            Cohorts = Dr["Cohorts"].ToString()
                        }); 
                    }
                }
                else
                {
                    MessageBox.Show(null, "No Course found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                Con.Close();
                Con.Open();
                ModelsLists.LectureHalls.Clear();
                MySqlCommand com = new MySqlCommand("select * from lecrooms", Con);
                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        ModelsLists.LectureHalls.Add(new LectureHall()
                        {
                            LecHallID = Dr["FullName"].ToString(),
                            ShortName = Dr["ShortName"].ToString(),
                            Location = Dr["Location"].ToString(),
                            Nature = Dr["Nature"].ToString(),
                            Capacity = Convert.ToInt32(Dr["Capacity"].ToString())
                        }); 
                    }
                }
                else
                {
                    MessageBox.Show(null, "No Lecture Hall found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                Con.Close();
                Con.Open();
                ModelsLists.Lecturers.Clear();
                MySqlCommand com = new MySqlCommand("select * from lecturers", Con);
                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        ModelsLists.Lecturers.Add(new Lecturer()
                        {
                            LecturerID = Dr["lecid"].ToString(),
                            LecFullName = Dr["LecName"].ToString(),
                            Department = Dr["Department"].ToString(),
                            Preferences = Dr["Preferences"].ToString(),
                        }); 
                    }
                }
                else
                {
                    MessageBox.Show(null, "No Lecturers found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                Con.Close();
                Con.Open();
                ModelsLists.CohortsList.Clear();
                MySqlCommand com = new MySqlCommand("select * from cohorts", Con);
                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        ModelsLists.CohortsList.Add(new Cohort()
                        {
                            GroupID = Dr["GroupID"].ToString(),
                            ShortCode = Dr["ShortCode"].ToString(),
                            Fullname = Dr["Fullname"].ToString(),
                            School = Dr["School"].ToString(),
                            TotalCount = Convert.ToInt32(Dr["Count"].ToString())
                        }); 
                    }
                }
                else
                {
                    MessageBox.Show(null, "No Cohorts found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                Con.Close();
                Con.Open();
                ModelsLists.Schools.Clear();
                MySqlCommand com = new MySqlCommand("select * from schools", Con);
                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        ModelsLists.Schools.Add(new School() { SchoolCode = Dr["Code"].ToString(), SchoolName = Dr["SchoolName"].ToString() });
                    }
                }
                else
                {
                    MessageBox.Show(null, "No Schools found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                Con.Close();
                Con.Open();
                ModelsLists.Departments.Clear();
                MySqlCommand com = new MySqlCommand("select * from departments", Con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        ModelsLists.Departments.Add(new Department() { DepartmentName = Dr["Department"].ToString(), SchoolGuid = Dr["School"].ToString() });
                    }
                }
                else
                {
                    MessageBox.Show(null, "No Departments found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                Con.Close();
                Con.Open();
                ModelsLists.LHLocations.Clear();
                MySqlCommand com = new MySqlCommand("select * from locations", Con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        ModelsLists.LHLocations.Add(new LHLocation() { ShortName = Dr["ShortName"].ToString(), Description = Dr["Desciption"].ToString() });
                    }
                }
                else
                {
                    MessageBox.Show(null, "No Departments found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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