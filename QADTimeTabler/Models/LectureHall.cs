using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    public class LectureHall
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string LHGuid { get; set; } 
        [Required]
        [MaxLength(200)]
        public string ShortName { get; set; }
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Location { get; set; }    
        [Required]
        public int TeachingCapacity { get; set; } 
        [Required]
        public int ExaminationCapacity { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nature { get; set; }    

    }
}
