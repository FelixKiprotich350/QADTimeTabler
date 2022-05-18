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

namespace QADTimeTabler.LecHalls
{
    public partial class ManageRooms : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        readonly Population P=new Population();
        public ManageRooms()
        {
            InitializeComponent();
            comboBox2.Items.Clear();
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

                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("insert into locations (ShortName, Desciption) values (@ShortName, @Desciption)", con);
                com.Parameters.AddWithValue("@ShortName", textBox2.Text.Trim());
                com.Parameters.AddWithValue("@Desciption", textBox3.Text.Trim());
                int x = com.ExecuteNonQuery();
                if (x >= 0)
                {
                    MessageBox.Show(this, "Location saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLocations();
                }
                else
                {
                    MessageBox.Show(this, "Failed to save the Location!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from locations", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        DataGridView_Locations.Rows.Add(Dr["ShortName"].ToString(), Dr["Desciption"].ToString());
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
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("insert into lecrooms (FullName, ShortName, Location, Nature,Capacity) values (@FullName, @ShortName, @Location, @Nature,@Capacity)", con);
                com.Parameters.AddWithValue("@FullName", comboBox2.Text.Trim()+"/" + textBox1.Text.Trim());
                com.Parameters.AddWithValue("@ShortName", textBox1.Text.Trim());
                com.Parameters.AddWithValue("@Location", comboBox2.Text.Trim());
                com.Parameters.AddWithValue("@Nature", comboBox1.Text.Trim());
                com.Parameters.AddWithValue("@Capacity", numericUpDown1.Value);
                int x = com.ExecuteNonQuery();
                if (x >= 0)
                {
                    MessageBox.Show(this, "Lecture Hall saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLectureHalls();
                }
                else
                {
                    MessageBox.Show(this, "Failed to save the Lecture Hall!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from lecrooms", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        DataGridView_LecHalls.Rows.Add(Dr["FullName"].ToString(), Dr["ShortName"].ToString(), Dr["Location"].ToString(), Dr["Nature"].ToString(),Dr["Capacity"].ToString());
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
