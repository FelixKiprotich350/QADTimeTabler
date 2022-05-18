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

namespace QADTimeTabler.Courses
{
    public partial class SelectClassCourse : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        public SelectClassCourse()
        {
            InitializeComponent();
        }

        private void Btn_ViewAll_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        void LoadCourses()
        {
            try
            {
                DataGridView_CourseList.Rows.Clear();
                MySqlConnection con = new MySqlConnection(db.DbConnectionString());
                con.Open();
                MySqlCommand com = new MySqlCommand("select * from courses;", con);

                MySqlDataReader Dr = com.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        DataGridView_CourseList.Rows.Add(Dr["CourseCode"].ToString(), Dr["CourseTitle"].ToString(), Dr["CourseNature"].ToString(), Dr["Department"].ToString(), Dr["Cohorts"].ToString());
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

        private void DataGridView_CourseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddClass a = new AddClass(DataGridView_CourseList.Rows[e.RowIndex]);
            a.ShowDialog();
        }
    }
}
