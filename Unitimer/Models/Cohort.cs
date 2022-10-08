using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitimer.Models
{
    public class Cohort
    {
        [Key]
        [MaxLength(100)]
        public string CohortGuid { get; set; }
        [Required]
        [MaxLength(200)]
        public string CohortName { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        

        //  Additional Properties
        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
