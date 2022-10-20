using MySql.Data.MySqlClient;
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

namespace QADTimeTabler.Administration
{
    public partial class DataManager : Form
    {
        Population P = new Population();
        public DataManager()
        {
            InitializeComponent();
            GetComboboxSchools();
        }

        void GetComboboxSchools()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(P.GetStringSchools().ToArray());
        }
        private void Btn_SaveSchool_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim()=="")
                {
                    MessageBox.Show(this, "Enter the School code!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textBox3.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the School Name!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var db = new TimeDbContext();
                School s = new School()
                {
                    SchoolGuid = Guid.NewGuid().ToString(),
                    SchoolCode = textBox1.Text,
                    SchoolName = textBox3.Text,
                    CreationDate = Program.CurrentDate()
                };
                db.Schools.Add(s);
                int x = db.SaveChanges();
                MessageBox.Show(this, "School Added Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSchools();
                GetComboboxSchools();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SaveDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the Department Name!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (comboBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the School!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var db = new TimeDbContext(); 
                Department d = new Department
                {
                    SchoolGuid=Guid.NewGuid().ToString(),
                    DepartmentGuid = Guid.NewGuid().ToString(),
                    DepartmentCode = textBox4.Text,
                    DepartmentName = textBox2.Text,
                    CreationDate = Program.CurrentDate()
                };
                db.Departments.Add(d);
                int x = db.SaveChanges();
                MessageBox.Show(this, "Department saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_RefreshDepartments_Click(object sender, EventArgs e)
        {
            LoadDepartments();

        }
        void LoadDepartments()
        {
            try
            {

                Gridview_Departments.Rows.Clear();
                var db = new TimeDbContext();
                var list = db.Departments.AsNoTracking();
                if (list.Count()>0)
                {
                    foreach (var x in list)
                    {
                        Gridview_Departments.Rows.Add(x.DepartmentCode, x.DepartmentName);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No Departments found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_RefreshSchools_Click(object sender, EventArgs e)
        {
            LoadSchools();
        }
        void LoadSchools()
        {
            try
            {
                GridView_Schools.Rows.Clear();
                var db = new TimeDbContext();
                var list = db.Schools.AsNoTracking();
                if (list.Count() > 0)
                {
                    foreach (var x in list)
                    {
                        GridView_Schools.Rows.Add(x.SchoolCode, x.SchoolName);
                    }
                } 
                else
                {
                    MessageBox.Show(this, "No Schools found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
