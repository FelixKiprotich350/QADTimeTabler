using Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = File.ReadAllText(@"D:\file.xml"); 
            var catalog1 = xml.ParseXML<catalog>();

            //string json = File.ReadAllText(@"D:\file.json");
            //var catalog2 = json.ParseJSON<JSONRoot>();
        }
    }
}
