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
    public partial class UserManagement : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        readonly Population P = new Population();
        public UserManagement()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(P.GetStringDepartments().ToArray());
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim()=="")
                {
                    MessageBox.Show(this, "Enter the Name of the User!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Department!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the Role!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the password!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string ID = DateTime.Now.ToString("ffff"); 
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("insert into sysusers (Userid, Fullname, Role, Department, Password) values (@Userid, @Fullname, @Role, @Department, @Password)", con);
                com.Parameters.AddWithValue("@Userid", ID);
                com.Parameters.AddWithValue("@Fullname", textBox1.Text.Trim());
                com.Parameters.AddWithValue("@Role", comboBox2.Text.Trim());
                com.Parameters.AddWithValue("@Department", comboBox1.Text.Trim());
                com.Parameters.AddWithValue("@Password", textBox2.Text.Trim());
                int x = com.ExecuteNonQuery();
                if (x>=0)
                {
                    MessageBox.Show(this,"User saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this,"Failed to add the user", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_RefreshUsers_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from sysusers", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        dataGridView2.Rows.Add(Dr["Userid"].ToString(),Dr["Fullname"].ToString(),Dr["Department"].ToString(),Dr["Role"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show(this, "No users found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
