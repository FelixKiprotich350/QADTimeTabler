using QADTimeTabler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
  
    public class PreClass
    {
         
        [Required]
        [MaxLength(100)]
        public string CourseCode { get; set; }
        [Required]
        [MaxLength(200)]
        public string Lecturer { get; set; }
        [Required]
        [MaxLength(500)]
        public string LecturerPreferences { get; set; }
        [Required] 
        public bool IsChild { get; set; }
        [Required]
        [MaxLength(100)]
        public string ParentCourse { get; set; }
        [Required]
        [MaxLength(100)]
        public string CourseNature { get; set; }
        [Required] 
        public int TotalStudents { get; set; }
        [Required] 
        public decimal CoursePriority { get; set; }
        [Required]
        public List<Cohort> Cohorts { get; set; } 


    }
}
