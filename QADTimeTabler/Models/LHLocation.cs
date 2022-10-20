using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    public class LHLocation
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string LocationGuid { get; set; }
        [Required]
        [MaxLength(100)]
        [Index(IsUnique =true)]
        public string ShortName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }    
        

    }
}
