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

namespace QADTimeTabler.Administration
{
    public partial class SchoolsDepartments : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        Population P = new Population();
        public SchoolsDepartments()
        {
            InitializeComponent();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(P.GetStringSchools().ToArray());
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(P.GetStringLHLocations().ToArray());
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
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("insert into schools (SchoolName,Code) values (@SchoolName, @Code)", con);

                com.Parameters.AddWithValue("@SchoolName", textBox1.Text.Trim());
                com.Parameters.AddWithValue("@Code", textBox3.Text.Trim());
                int x = com.ExecuteNonQuery();
                if (x>=0)
                {
                    MessageBox.Show(this,"School saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSchools();
                }
                else
                {
                    MessageBox.Show(this,"Failed to add the School!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                if (comboBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Priority Location!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("insert into departments (Department,School,PriorityLocation) values (@Department, @School,@PriorityLocation)", con);
                com.Parameters.AddWithValue("@Department", textBox2.Text.Trim());
                com.Parameters.AddWithValue("@School", comboBox2.Text.Trim());
                com.Parameters.AddWithValue("@PriorityLocation", comboBox1.Text.Trim());
                int x = com.ExecuteNonQuery();
                if (x >= 0)
                {
                    MessageBox.Show(this, "Department saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDepartments();
                }
                else
                {
                    MessageBox.Show(this, "Failed to add the Department!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from departments", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Gridview_Departments.Rows.Add(Dr["Department"].ToString(), Dr["School"].ToString(),Dr["PriorityLocation"].ToString());
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
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from schools", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        GridView_Schools.Rows.Add(Dr["Code"].ToString(), Dr["SchoolName"].ToString());
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
