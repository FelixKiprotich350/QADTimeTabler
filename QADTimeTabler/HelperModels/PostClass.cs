using QADTimeTabler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.HelperModels
{
    public class PostClass
    {
        public string CourseCode { get; set; }
        public string Lecturer { get; set; }
        public string CourseNature { get; set; }
        public bool IsChild { get; set; }
        public string ParentCourse { get; set; }
        public List<Cohort> Cohorts { get; set; }
        public int TotalStudents { get; set; }
        public Timeslot Timeslot { get; set; }
        public LectureHall LectureHall { get; set; }

    }
}
