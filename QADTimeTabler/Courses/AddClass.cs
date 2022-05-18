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
                Gridview_Cohorts.Rows.Add(c);
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
                string _Cohorts = "";
                foreach (DataGridViewRow r in Gridview_Cohorts.Rows)
                {
                    _Cohorts += r.Cells[0].Value.ToString() + ",";
                }
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("insert into classes (CourseCode, Lecturer, IsChild, ParentCourse, Cohorts) values (@CourseCode, @Lecturer, @IsChild, @ParentCourse, @Cohorts)", con);
                com.Parameters.AddWithValue("@CourseCode", textBox2.Text.Trim());
                com.Parameters.AddWithValue("@Lecturer", textBox5.Text.Trim());
                com.Parameters.AddWithValue("@IsChild", "false");
                com.Parameters.AddWithValue("@ParentCourse", textBox1.Text.Trim());
                com.Parameters.AddWithValue("@Cohorts", _Cohorts);
                int x = com.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show(this, "Class saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Failed to add the Class!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                GroupBox_MultipleGroups.Enabled = true;
                Btn_SaveDefault.Enabled = false;
                DataGridView_subgroups.Rows.Clear();
                BreakDownClass();
            }
            else
            {
                GroupBox_MultipleGroups.Enabled = false;
                Btn_SaveDefault.Enabled = true;
                DataGridView_subgroups.Rows.Clear();
            }
        }

        void BreakDownClass()
        {

        }

    
    }
}
