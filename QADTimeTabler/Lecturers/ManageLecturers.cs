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

namespace QADTimeTabler.Lecturers
{
    public partial class ManageLecturers : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        readonly Population P = new Population();
        public ManageLecturers()
        {
            InitializeComponent();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(P.GetStringDepartments().ToArray());
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the Lecturer's Full Name!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Lecturer's Department!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (listView1.CheckedItems.Count <= 0)
                {
                    MessageBox.Show(this, "Atleast one Day is required under preferences!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open(); 
                MySqlCommand com = new MySqlCommand("insert into lecturers (lecid, LecName, Department, Preferences) values (@lecid, @LecName, @Department, @Preferences)", con);
                com.Parameters.AddWithValue("@lecid", DateTime.Now.ToString("ffff"));
                com.Parameters.AddWithValue("@LecName", textBox1.Text.Trim());
                com.Parameters.AddWithValue("@Department", comboBox2.Text.Trim());
                string preference = "";
                foreach(ListViewItem i in listView1.CheckedItems)
                {
                    preference += i.Text + ",";
                }
                com.Parameters.AddWithValue("@Preferences",preference);
                int x = com.ExecuteNonQuery();
                if (x >= 0)
                {
                    MessageBox.Show(this, "Lecturer saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Failed to save the Lecturer!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            textBox1.Text = "";
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = false;
            }
        }

        private void Btn_ViewAll_Click(object sender, EventArgs e)
        {
            LoadLecturers();
        }

       void LoadLecturers()
        {
            try
            {
                DataGridView_Lecturers.Rows.Clear();
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from lecturers", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        DataGridView_Lecturers.Rows.Add(Dr["lecid"].ToString(), Dr["LecName"].ToString(), Dr["Department"].ToString(), Dr["Preferences"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show(this, "No Lecturers found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
