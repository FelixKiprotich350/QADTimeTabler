﻿using QADTimeTabler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    public class FinalPostClass
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; } 
        [Required]
        [MaxLength(100)]
        public string CourseGuid { get; set; } 
        [Required]
        [MaxLength(100)]
        public string CourseCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string Lecturer { get; set; }
        [Required]
        [MaxLength(100)]
        public string CourseNature { get; set; }
        [Required] 
        public bool IsChild { get; set; }
        [Required]
        [MaxLength(100)]
        public string ParentCourse { get; set; }
        [Required] 
        public int TotalStudents { get; set; }
        [Required] 
        public string Timeslot { get; set; }
        [Required] 
        public string LectureHall { get; set; }
        [Required] 
        public string Cohorts { get; set; }

    }
}
