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
using QADTimeTabler.Models;

namespace QADTimeTabler.Lecturers
{
    public partial class ManageLecturers : Form
    { 
        readonly Population P = new Population();
        public ManageLecturers()
        {
            InitializeComponent();
            GetDepartments();
        }
        void GetDepartments()
        {
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
                var db = new TimeDbContext();
                string preference = "";
                foreach (ListViewItem i in listView1.CheckedItems)
                {
                    preference += i.Text + ",";
                }
                Lecturer l = new Lecturer()
                { LecturerGuid = Guid.NewGuid().ToString(),
                    LecturerID = DateTime.Now.ToString("ffff"),
                    LecFullName = textBox1.Text.Trim(),
                    Department = comboBox2.Text.Trim(),
                    Preferences = preference
                };
                db.Lecturers.Add(l);
                db.SaveChanges();
                MessageBox.Show(this, "Lecturer saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                var db = new TimeDbContext();
                var items = db.Lecturers.AsNoTracking().ToList(); 
                if (items.Count>0)
                {
                    foreach (var x in items)
                    {
                        DataGridView_Lecturers.Rows.Add(x.LecturerID, x.LecFullName, x.Department, x.Preferences);
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
