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

namespace QADTimeTabler.Cohorts
{
    public partial class ManageCohorts : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        public ManageCohorts()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            DataGridView_Groups.Rows.Clear();
            DataGridView_Groups.Rows.Add(1,0);
            DataGridView_Groups.Rows.Add(2,0);
            DataGridView_Groups.Rows.Add(3,0);
            DataGridView_Groups.Rows.Add(4,0);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlTransaction Tr;
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the CohortCode!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Enter the Cohort Name!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBox1.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Select the School!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DataGridView_Groups.Rows.Count<=0)
                {
                    MessageBox.Show(this, "Atleast one Group is required to save the cohorts!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                Tr = con.BeginTransaction();
                MySqlCommand com = new MySqlCommand("insert into cohorts (GroupID, ShortCode, Fullname,Count,School) values (@GroupID, @ShortCode, @Fullname,@Count,@School)", con,Tr);
                com.Parameters.Add("@GroupID", MySqlDbType.VarString);
                com.Parameters.Add("@ShortCode", MySqlDbType.VarString);
                com.Parameters.Add("@Fullname", MySqlDbType.VarString); 
                com.Parameters.Add("@School", MySqlDbType.VarString);
                com.Parameters.Add("@Count", MySqlDbType.Int32);
                int x = 0;
                foreach (DataGridViewRow R in DataGridView_Groups.Rows)
                {
                    string ID = R.Cells[0].Value.ToString();
                    Int32.TryParse(R.Cells[0].Value.ToString(),out int count);
                    com.Parameters["@ID"].Value= textBox1.Text.Trim()+"-"+ID;
                    com.Parameters["@ShortCode"].Value= textBox1.Text.Trim();
                    com.Parameters["@Fullname"].Value= textBox2.Text.Trim();
                    com.Parameters["@School"].Value= comboBox1.Text.Trim();
                    com.Parameters["@Count"].Value= count;
                    int y= com.ExecuteNonQuery();
                    if (y == 1)
                    {
                        x++;
                    }
                }
                if (x >= DataGridView_Groups.RowCount)
                {
                    MessageBox.Show(this, "Cohorts saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tr.Commit();
                    LoadCohorts();
                }
                else
                {
                    MessageBox.Show(this, "Failed to add the Cohorts", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Tr.Rollback();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadCohorts()
        {
            try
            {
                dataGridView2.Rows.Clear();
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from cohorts", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        dataGridView2.Rows.Add(Dr["GroupID"].ToString(), Dr["ShortCode"].ToString(), Dr["Fullname"].ToString(), Dr["Count"].ToString(), Dr["School"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show(this, "No Cohorts found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ViewAll_Click(object sender, EventArgs e)
        {
            LoadCohorts();
        }
    }
}
