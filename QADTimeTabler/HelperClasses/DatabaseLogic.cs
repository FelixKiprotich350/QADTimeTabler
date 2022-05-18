using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADTimeTabler.HelperClasses
{
    public class DatabaseLogic
    {
        public string DbConnectionString()
        {
            string ConnectionString = "server=localhost; uid=root; database=dbtime; password=toor";
            return ConnectionString;
        }
    }
}
