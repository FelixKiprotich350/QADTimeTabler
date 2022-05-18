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
    public partial class SelectAddCohort : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        readonly ManageCourses MC = null;
        public SelectAddCohort(ManageCourses m)
        {
            InitializeComponent(); 
            MC = m;
        }

        private void Btn_ViewAll_Click_1(object sender, EventArgs e)
        {
            LoadCohorts();
        }

        void LoadCohorts()
        {
            try
            {
                DataGridView_CohortsList.Rows.Clear();
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from cohorts", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        DataGridView_CohortsList.Rows.Add(Dr["GroupID"].ToString(), Dr["ShortCode"].ToString(), Dr["Fullname"].ToString(), Dr["Count"].ToString(), Dr["School"].ToString());
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

        private void DataGridView_CohortsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in DataGridView_CohortsList.SelectedRows)
            {
                MC.GridView_Cohorts.Rows.Add(r.Cells[0].Value.ToString());
            }
            this.Close();
        }
    }
}
