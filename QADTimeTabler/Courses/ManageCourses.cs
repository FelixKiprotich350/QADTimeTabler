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

namespace QADTimeTabler.Courses
{
    public partial class ManageCourses : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
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
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("insert into courses (CourseCode, CourseTitle, Department, Cohorts, CourseNature) values (@CourseCode, @CourseTitle, @Department, @Cohorts, @CourseNature)", con);
                com.Parameters.AddWithValue("@CourseCode", textBox1.Text.Trim());
                com.Parameters.AddWithValue("@CourseTitle", textBox2.Text.Trim());
                com.Parameters.AddWithValue("@Department", comboBox1.Text.Trim());
                com.Parameters.AddWithValue("@Cohorts", _Cohorts);
                com.Parameters.AddWithValue("@CourseNature", comboBox2.Text.Trim());
                com.Parameters.Add("@Count", MySqlDbType.Int32);
                int x = com.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show(this, "Course saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCourses();
                }
                else
                {
                    MessageBox.Show(this, "Failed to add the Course!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from courses;", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        DataGridView_CourseList.Rows.Add(Dr["CourseCode"].ToString(), Dr["CourseTitle"].ToString(), Dr["CourseNature"].ToString(), Dr["Department"].ToString(), Dr["Cohorts"].ToString());
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
            SelectAddCohort s = new SelectAddCohort(this);
            s.ShowDialog();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            GridView_Cohorts.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
