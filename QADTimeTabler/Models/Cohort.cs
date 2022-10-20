using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    public class Cohort
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupID { get; set; }
        [Required]
        [MaxLength(200)]
        public string ShortCode { get; set; }
        [Required]
        [MaxLength(500)]
        public string Fullname { get; set; }
        [Required]
        [MaxLength(200)]
        public string School { get; set; }
        [Required]
        [MaxLength(200)]
        public string Department { get; set; }
        [Required]
        public int TotalCount { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }


        //  Additional Properties
        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
