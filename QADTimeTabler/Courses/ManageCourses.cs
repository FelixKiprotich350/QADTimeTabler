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
using QADTimeTabler.Models;

namespace QADTimeTabler.Courses
{
    public partial class ManageCourses : Form
    { 
        readonly Population P = new Population();
        public ManageCourses()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(P.GetStringDepartments().ToArray());
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the Course Code!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the Course Title!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Nature of the Course!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Department!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string _Cohorts = "";
                foreach (DataGridViewRow r in GridView_Cohorts.Rows)
                {
                    _Cohorts += r.Cells[0].Value.ToString() + ",";
                }
                var db = new TimeDbContext();
                Course c = new Course()
                {
                    CourseGuid = Guid.NewGuid().ToString(),
                    CourseCode= textBox1.Text.Trim(),
                    CourseTitle= textBox2.Text.Trim(),
                    CourseNature= comboBox2.Text.Trim(),
                    Department = comboBox1.Text.Trim(),
                    Cohorts= _Cohorts
                };
                db.Courses.Add(c);
                db.SaveChanges();
                MessageBox.Show(this, "Course saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCourses();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        DataGridView_CourseList.Rows.Add(x.CourseCode, x.CourseTitle, x.CourseNature,x.Department, x.Cohorts);
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

       
        private void Btn_SelectAdd_Click(object sender, EventArgs e)
        {
            SelectAddCohort s = new SelectAddCohort();
            if (s.ShowDialog()==DialogResult.OK)
            {
                foreach(var x in s.Selecteditems)
                {
                    bool itempresent = false;
                    foreach (DataGridViewRow r in GridView_Cohorts.Rows)
                    {
                        if (r.Cells[0].Value.ToString().ToLower() == x.ToLower())
                        {
                            itempresent = true;
                            break;
                        }
                    }
                    if (!itempresent)
                    {
                        GridView_Cohorts.Rows.Add(x);
                    }
                }
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            GridView_Cohorts.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void DataGridView_CourseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string code = DataGridView_CourseList.SelectedRows[0].Cells[0].Value.ToString();
            EditCourse ec = new EditCourse(code);
            ec.ShowDialog();
        }
    }
}
