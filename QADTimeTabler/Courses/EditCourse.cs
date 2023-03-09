using QADTimeTabler.HelperClasses;
using QADTimeTabler.Models;
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
    public partial class EditCourse : Form
    {

        string sel_Course = "";
        public EditCourse(string code)
        {
            InitializeComponent();
            sel_Course = code;
        }

        private void EditCourse_Load(object sender, EventArgs e)
        {
            if (sel_Course=="")
            {
                MessageBox.Show("The Course Code is Empty!", "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadDepartments();
            LoadCourseDetails(sel_Course);
        }

        private void LoadDepartments()
        {
            try
            {
                List<Department> departments = new List<Department>();
                TimeDbContext db = new TimeDbContext();
                comboBox2.DataSource = new BindingSource() { DataSource = db.Departments.AsNoTracking().ToList() };
                comboBox2.DisplayMember = "DepartmentName";
                comboBox2.ValueMember = "DepartmentName";
                comboBox2.SelectedItem = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadCourseDetails(string coursecode)
        {
            try
            {
                List<Department> departments = new List<Department>();
                TimeDbContext db = new TimeDbContext();
                Course c = null;
                c = db.Courses.AsNoTracking().FirstOrDefault(k => k.CourseCode.ToLower() == coursecode.ToLower());
                if(c is null)
                {
                    MessageBox.Show("The Course Code Does not Exist!", "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                textBox1.Text = c.CourseCode; 
                textBox2.Text = c.CourseTitle;
                Department d = db.Departments.FirstOrDefault(k => k.DepartmentName == c.Department);
                if (d != null)
                { 
                    comboBox2.SelectedValue = d.DepartmentName;
                }
                comboBox1.SelectedItem = c.CourseNature;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Button_AdddCohort_Click(object sender, EventArgs e)
        {
            try
            {
                SelectAddCohort s = new SelectAddCohort();
                if (s.ShowDialog() == DialogResult.OK)
                {
                    foreach (var x in s.Selecteditems)
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
            catch
            {

            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                TimeDbContext db = new TimeDbContext();
                Course c = null;
                c = db.Courses.FirstOrDefault(k => k.CourseCode.ToLower() == textBox1.Text.ToLower());
                if(c is null)
                {
                    MessageBox.Show("The Course ID does not exist!", "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db.Courses.Remove(c);
                db.SaveChanges();
                MessageBox.Show("Success Course Deleted!", "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Course Nature!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox2.SelectedItem==null)
                {
                    MessageBox.Show(this, "Select the Department of the Course!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (GridView_Cohorts.Rows.Count<=0)
                {
                    MessageBox.Show(this, "Select the Cohorts of the Course!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                TimeDbContext db = new TimeDbContext();
                Course c = null;
                c = db.Courses.FirstOrDefault(k => k.CourseCode.ToLower() == textBox1.Text.ToLower());
                if (c is null)
                {
                    MessageBox.Show("The Course ID does not exist!", "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                c.CourseTitle = textBox2.Text;
                c.CourseNature = comboBox1.Text;
                c.Department = ((Department)comboBox2.SelectedItem).DepartmentName;
                string cohorts = "";
                foreach (DataGridViewRow x in GridView_Cohorts.Rows)
                {
                    cohorts += x.Cells[0].Value + ",";
                }
                c.Cohorts = cohorts;
                db.SaveChanges();
                MessageBox.Show("Success Course Updated!", "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messsage Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
