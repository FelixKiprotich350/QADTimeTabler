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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoID { get; set; }
        [Required]
        [MaxLength(100)] 
        [Index(IsUnique = true)]
        public string LecGuid { get; set; }
        [Required]
        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string LecPFNo { get; set; }
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
