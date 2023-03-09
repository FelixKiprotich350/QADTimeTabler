using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QADTimeTabler.Timetabling
{
    public partial class ViewClassInfo : Form
    {
        public string Classcode = "";
        public ViewClassInfo(string classcode)
        {
            InitializeComponent();
            Classcode = classcode;
        }

        private void ViewClassInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
