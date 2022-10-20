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
    public class ClassObject
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string ClassGuid { get; set; }
        [Required]
        [Index(IsUnique =true)]
        [MaxLength(100)]
        public string CourseCode { get; set; }
        [Required]
        [MaxLength(200)]
        public string Lecturer { get; set; } 
        [Required] 
        public bool IsChild { get; set; }
        [Required]
        [MaxLength(100)]
        public string ParentCourse { get; set; }
        [Required]
        [MaxLength(1000)]  
        public string Cohorts { get; set; }


    }
}
