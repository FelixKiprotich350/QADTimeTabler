using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitimer.Navigation
{
    static  class ModulesCollection
    { 
        public static List<MenuModule> GetModules()
        {
            List<MenuModule> MenuCategories   = new List<MenuModule>
            {
                new MenuModule() { GroupName = "Cohorts", GroupCode = "A" },
                new MenuModule() { GroupName = "Lecturers", GroupCode = "B" },
                new MenuModule() { GroupName = "Lecturer Halls", GroupCode = "C"  },
                new MenuModule() { GroupName = "Programmes", GroupCode = "D"  },
                new MenuModule() { GroupName = "Timetabling", GroupCode = "E"  },
                new MenuModule() { GroupName = "Manage", GroupCode = "F" },
                new MenuModule() { GroupName = "Account", GroupCode = "G" },
                new MenuModule() { GroupName = "Help", GroupCode = "H" }
            };
            return MenuCategories; 
        }
    }
}
