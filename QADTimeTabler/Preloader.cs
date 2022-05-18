using QADTimeTabler.HelperClasses;
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
    public partial class Preloader : Form
    {
        readonly Population P = new Population();
        public bool LoadStatus = false;
        public Preloader()
        {
            InitializeComponent();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Preloader_Load(object sender, EventArgs e)
        {
            P.ReloadAllItems();
        }
    }
}
