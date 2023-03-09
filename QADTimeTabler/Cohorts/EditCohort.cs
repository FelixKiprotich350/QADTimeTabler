using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QADTimeTabler.Cohorts
{
    public partial class EditCohort : Form
    {
        public string editingcohort = "";
        public EditCohort(string code)
        {
            InitializeComponent();
            editingcohort = code;
        }

        private void EditCohort_Load(object sender, EventArgs e)
        {
            try
            {
                var db = new TimeDbContext();
                var cohort = db.Cohorts.AsNoTracking().Where(k=>k.ShortCode==editingcohort).FirstOrDefault();
                if (cohort !=null)
                {
                    this.Text = "Editing" + cohort.ShortCode + "-" + cohort.Fullname;
                    textBox1.Text = cohort.ShortCode;
                }
                else
                {
                    MessageBox.Show(this, "The selected cohort does not Exist!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

        }
        
        private void Button_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
