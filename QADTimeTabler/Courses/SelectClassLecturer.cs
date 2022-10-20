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
                var db = new TimeDbContext();
                var items = db.Lecturers.AsNoTracking().ToList();
                if (items.Count>0)
                {
                   foreach(var x in items)
                    {
                        DataGridView_Lecturers.Rows.Add(x.LecturerID, x.LecFullName, x.Department);
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
