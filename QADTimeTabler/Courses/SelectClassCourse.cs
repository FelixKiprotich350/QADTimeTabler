using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QADTimeTabler.HelperClasses;

namespace QADTimeTabler.Courses
{
    public partial class SelectClassCourse : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        public SelectClassCourse()
        {
            InitializeComponent();
        }

        private void Btn_ViewAll_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        void LoadCourses()
        {
            try
            {
                DataGridView_CourseList.Rows.Clear();
                var db = new TimeDbContext();
                var items = db.Courses.AsNoTracking().ToList();
                if (items.Count>0)
                {
                   foreach(var x in items)
                    {
                        DataGridView_CourseList.Rows.Add(x.CourseCode, x.CourseTitle,x.CourseNature, x.Department, x.Cohorts);
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

        private void DataGridView_CourseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddClass a = new AddClass(DataGridView_CourseList.Rows[e.RowIndex]);
            a.ShowDialog();
        }
    }
}
