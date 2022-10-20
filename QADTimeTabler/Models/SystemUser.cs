using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    public class SystemUser
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string UserGuid { get; set; }
        [Required] 
        public int UserID { get; set; }
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Role { get; set; }
        [Required]
        [MaxLength(200)]
        public string Department { get; set; }
        [Required]
        [MaxLength(200)]
        public string Password { get; set; }
    }
    
}
