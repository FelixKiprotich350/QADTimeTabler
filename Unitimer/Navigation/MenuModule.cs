using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitimer.Navigation
{ 
    public class MenuModule
    {
        public string GroupName { get; set; }
        public string GroupCode { get; set; }

        public ObservableCollection<ModuleFunction> SubMenuItems { get; set; }
        public MenuModule()
        {
            SubMenuItems = new ObservableCollection<ModuleFunction>();
        }
    }
}
