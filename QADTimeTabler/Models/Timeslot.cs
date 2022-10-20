using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.Models
{
    [NotMapped]
    public class Timeslot
    {
        public string Day { get; set; }
        public string Session { get; set; }
    }
}
