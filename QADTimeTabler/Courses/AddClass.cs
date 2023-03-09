using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QADTimeTabler.HelperClasses;
using QADTimeTabler.Models;

namespace QADTimeTabler.Courses
{
    public partial class AddClass : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        readonly DataGridViewRow R; 
        public AddClass(DataGridViewRow r)
        {
            
            InitializeComponent();
            R = r;
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            textBox2.Text = R.Cells[0].Value.ToString();
            textBox1.Text = R.Cells[1].Value.ToString();
            textBox3.Text = R.Cells[2].Value.ToString();
            string[] coho = R.Cells[4].Value.ToString().Split(',').Where(m=>!string.IsNullOrEmpty(m)).ToArray();
            foreach (string c in coho)
            {

                var coh = ModelsLists.CohortsList.Where(k => k.ShortCode == c).FirstOrDefault();
                if (coh != null)
                {
                    Gridview_Cohorts.Rows.Add(c, coh.TotalCount); 
                }
                else
                { 
                    Gridview_Cohorts.Rows.Add(c, 0);
                }
            }
        }

        private void Btn_SaveDefault_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "You have not selected any Course!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textBox5.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Lecturer!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Gridview_Cohorts.RowCount<=0)
                {
                    MessageBox.Show(this, "The course does not contain any group of students!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!CheckBox_Subclasses.Checked) 
                {
                    string _Cohorts = "";
                    foreach (DataGridViewRow r in Gridview_Cohorts.Rows)
                    {
                        _Cohorts += r.Cells[0].Value.ToString() + ",";
                    }
                    var db = new TimeDbContext();
                    ClassObject pc = new ClassObject()
                    {
                        ClassGuid = Guid.NewGuid().ToString(),
                        CourseCode = textBox2.Text.Trim(),
                        Lecturer = textBox5.Text.Trim(),
                        ParentCourse = textBox1.Text.Trim(),
                        //Cohorts = _Cohorts,
                        Cohorts = _Cohorts,
                        IsChild = false
                    };
                    db.ClassObjects.Add(pc);
                    db.SaveChanges();
                    MessageBox.Show(this, "Class saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    SaveMultiple();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SelectLecturer_Click(object sender, EventArgs e)
        {
            SelectClassLecturer s = new SelectClassLecturer(this);
            s.ShowDialog();
        }

        private void CheckBox_Subclasses_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Subclasses.Checked)
            {
                if (int.TryParse(textBox6.Text,out int averageclass))
                {
                    GroupBox_MultipleGroups.Enabled = true;
                    DataGridView_subgroups.Rows.Clear();
                    BreakDownClass(averageclass);
                } 
                else
                {
                    MessageBox.Show("Enter the class Size!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CheckBox_Subclasses.Checked = false;
                } 
               
            }
            else
            {
                GroupBox_MultipleGroups.Enabled = false; 
                DataGridView_subgroups.Rows.Clear();
                textBox6.Text = "";
            }
        }
        void BreakDownClass(int average)
        {

        }

        void SaveMultiple()
        {
            try
            {
                var db = new TimeDbContext();
                foreach (var x in DataGridView_subgroups.Rows)
                {
                    string _Cohorts = "";
                    ClassObject pc = new ClassObject()
                    {
                        ClassGuid = Guid.NewGuid().ToString(),
                        CourseCode = textBox2.Text.Trim(),
                        Lecturer = textBox5.Text.Trim(),
                        ParentCourse = textBox1.Text.Trim(),
                        //Cohorts = _Cohorts, 
                        IsChild = false
                    };
                   // db.ClassObjects.Add(pc);
                   // db.SaveChanges();

                }
                MessageBox.Show(this, "Class saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
         
    }
}
