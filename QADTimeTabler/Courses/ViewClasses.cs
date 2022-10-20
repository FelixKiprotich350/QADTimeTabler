using MySql.Data.MySqlClient;
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

namespace QADTimeTabler.Courses
{
    public partial class ViewClasses : Form
    {
        readonly DatabaseLogic db=new DatabaseLogic();
        public ViewClasses()
        {
            InitializeComponent();
        }

        private void Btn_ViewAll_Click(object sender, EventArgs e)
        {
            LoadClasses();
        }
        void LoadClasses()
        {
            try
            {
                DataGridView_Classlist.Rows.Clear();
                var db = new TimeDbContext();
                var items = db.ClassObjects.AsNoTracking().ToList();
                if (items.Count>0)
                {
                   foreach(var x in items)
                    {
                        DataGridView_Classlist.Rows.Add(x.CourseCode, x.Lecturer, x.IsChild, x.ParentCourse,x.Cohorts);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No Courses found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
