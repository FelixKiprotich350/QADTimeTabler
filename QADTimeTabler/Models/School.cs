using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    public class School
    {
        [Key]
        [MaxLength(100)]
        public string SchoolGuid { get; set; }
        [Required]
        [MaxLength(200)]
        [Index(IsUnique =true)]
        public string SchoolCode { get; set; }
        [Required]
        [MaxLength(500)]
        public string SchoolName { get; set; } 
        [Required]
        public DateTime CreationDate { get; set; }


        //  Additional Properties
        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
