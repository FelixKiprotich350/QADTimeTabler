using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    public class Course
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string CourseGuid { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(100)]
        public string CourseCode { get; set; }
        [Required]
        [MaxLength(200)]
        public string CourseTitle { get; set; }
        [Required]
        [MaxLength(200)]
        public string CourseNature { get; set; }
        [Required]
        [MaxLength(200)]
        public string Department { get; set; }
        [Required] 
        public string Cohorts { get; set; }

    }
}
