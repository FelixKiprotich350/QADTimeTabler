using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QADTimeTabler
{
    internal static class Program
   {
        public static DateTime CurrentDate()
        {
            return DateTime.Now;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DialogResult Canstart = DialogResult.None;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using(Preloader PreloaderF=new Preloader())
            {
                Canstart = PreloaderF.ShowDialog();
               
            }
            if (Canstart==DialogResult.OK)
            {
                Application.Run(new Dashboard());
            }
            
        }



    }
}
