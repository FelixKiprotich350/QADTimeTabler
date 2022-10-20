using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    public class Lecturer
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string LecturerGuid { get; set; }    
        [Required]
        [MaxLength(100)]
        [Index(IsUnique =true)]
        public string LecturerID { get; set; }
        [Required]
        [MaxLength(200)]
        public string LecFullName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Department { get; set; }
        [Required]
        [MaxLength(500)]
        public string Preferences { get; set; }    

    }
}
