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

namespace QADTimeTabler.LecHalls
{
    public partial class ManageRooms : Form
    {
  
        readonly Population P=new Population();
        public ManageRooms()
        {
            InitializeComponent();
            RefreshLocationCombobox();
        }
         
        private void RefreshLocationCombobox()
        {
            comboBox2.Items.Clear(); 
            P.ReloadLHLocations();
            comboBox2.Items.AddRange(P.GetStringLHLocations().ToArray());
        }

        private void Btn_SaveLocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the Location's Name!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textBox3.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Location's Description!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LHLocation lhl = new LHLocation()
                {
                    LocationGuid = Guid.NewGuid().ToString(),
                    ShortName = textBox2.Text,
                    Description = textBox3.Text,
                };
                var db = new TimeDbContext();
                db.LHLocations.Add(lhl);
                db.SaveChanges();
                MessageBox.Show(this, "Location saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLocations();
                RefreshLocationCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_RefreshLocation_Click(object sender, EventArgs e)
        {
            LoadLocations();
        }

        void LoadLocations()
        {
            try
            {
                DataGridView_Locations.Rows.Clear();
                var db = new TimeDbContext();
                var items = db.LHLocations.AsNoTracking().ToList();
                if (items.Count>0)
                {
                    foreach (var x in items)
                    {
                        DataGridView_Locations.Rows.Add(x.ShortName, x.Description);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No Locations found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SaveHall_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the Name of the LectureHall!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Location of the LectureHall!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Nature of the LectureHall!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (numericUpDown1.Value<=0)
                {
                    MessageBox.Show(this, "The capacity must be greater than Zero!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var db = new TimeDbContext();
                LectureHall lh = new LectureHall()
                {
                    LHGuid = Guid.NewGuid().ToString(),

                    ShortName = textBox1.Text.Trim(),
                    FullName = comboBox2.Text.Trim() + "-" + textBox1.Text,
                    Location = comboBox2.Text.Trim(),
                    Nature = comboBox1.Text.Trim(),
                    TeachingCapacity = (int)(numericUpDown1.Value),

                };
                db.LectureHalls.Add(lh);
                db.SaveChanges();
                MessageBox.Show(this, "Lecture Hall saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLectureHalls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_RefreshHall_Click(object sender, EventArgs e)
        {
            LoadLectureHalls();
        }

        void LoadLectureHalls()
        {
            try
            {
                DataGridView_LecHalls.Rows.Clear();
                var db = new TimeDbContext();
                var items = db.LectureHalls.AsNoTracking().ToList();
                if (items.Count>0)
                {
                    foreach (var x in items)
                    {
                        DataGridView_LecHalls.Rows.Add(x.FullName, x.ShortName, x.Location, x.Nature, x.TeachingCapacity);

                    }
                }
                else
                {
                    MessageBox.Show(this, "No Lecture Halls found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
