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

namespace QADTimeTabler.Courses
{
    public partial class ViewClasses : Form
    {
        readonly DatabaseLogic db=new DatabaseLogic();
        public ViewClasses()
        {
            InitializeComponent();
        }

        private void Btn_ViewAll_Click(object sender, EventArgs e)
        {
            LoadClasses();
        }
        void LoadClasses()
        {
            try
            {
                DataGridView_Classlist.Rows.Clear();
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from classes;", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        DataGridView_Classlist.Rows.Add(Dr["CourseCode"].ToString(), Dr["Lecturer"].ToString(), Dr["IsChild"].ToString(), Dr["ParentCourse"].ToString(), Dr["Cohorts"].ToString());
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
    }
}
