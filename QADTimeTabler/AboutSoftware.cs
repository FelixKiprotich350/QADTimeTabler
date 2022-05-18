using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QADTimeTabler
{
    public partial class AboutSoftware : Form
    {
        public AboutSoftware()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
