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
    public partial class SelectClassLecturer : Form
    {
        readonly DatabaseLogic db = new DatabaseLogic();
        readonly AddClass a;
        public SelectClassLecturer(AddClass add)
        {
            a = add;
            InitializeComponent();
        }
        private void Btn_ViewAll_Click_1(object sender, EventArgs e)
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
                        DataGridView_Lecturers.Rows.Add(Dr["lecid"].ToString(), Dr["LecName"].ToString(),Dr["Department"].ToString());
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

        private void DataGridView_CohortsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            a.textBox4.Text = DataGridView_Lecturers.Rows[e.RowIndex].Cells[1].Value.ToString();
            a.textBox5.Text = DataGridView_Lecturers.Rows[e.RowIndex].Cells[0].Value.ToString();
           
            this.Close();
        }
    }
}
