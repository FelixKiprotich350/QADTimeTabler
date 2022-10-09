using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitimer.Navigation
{ 
     
    public class ModuleFunction
    {
        [Key]
        [MaxLength(100)]
        public string FunctionCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string ParentModule { get; set; }
        [Required]
        [MaxLength(100)]
        public string RightLevel { get; set; }
        [Required]
        [MaxLength(100)]
        public string RightShortName { get; set; }
        [Required]
        [MaxLength(500)]
        public string RightFullName { get; set; }

        public bool IsSelected { get; set; }
        public object PageView { get; set; }

        public List<ModuleFunction> GetAllRights()
        {
            try
            {
                List<ModuleFunction> p = new List<ModuleFunction>
                {
                   // cohorts or student groups

                };
                return p;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
