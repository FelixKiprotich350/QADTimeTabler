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

namespace QADTimeTabler.Cohorts
{
    public partial class ManageCohorts : Form
    { 
        readonly Population P = new Population(); 
        public ManageCohorts()
        {
            InitializeComponent();
            LoadDepartments();
            Btn_Reset_Click(null, null);
        }
        private void LoadDepartments()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(P.GetStringDepartments().ToArray());
            comboBox1.Items.Add("test");
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
            LoadDepartments();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            { 
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
                var db = new TimeDbContext();
                foreach (DataGridViewRow Row in DataGridView_Groups.Rows)
                {
                    Int32.TryParse(Row.Cells[0].Value.ToString(), out int count);
                    Cohort c = new Cohort()
                    {
                        GroupID = Guid.NewGuid().ToString(),
                        ShortCode = textBox1.Text,
                        Fullname = textBox2.Text,
                        School = comboBox1.Text,
                        TotalCount = count,
                        Department = comboBox1.Text,
                        CreationDate = Program.CurrentDate()
                    };
                    db.Cohorts.Add(c);
                }
              
                if (db.SaveChanges() == DataGridView_Groups.RowCount)
                {
                    MessageBox.Show(this, "Cohorts saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCohorts();
                    Btn_Reset_Click(null, null);
                }
                else
                {
                    MessageBox.Show(this, "Failed to add the Cohorts", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 
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
                var db = new TimeDbContext();
                dataGridView2.Rows.Clear();
                var list = db.Cohorts.AsNoTracking(); 
                if (list.Count()>0)
                {
                    foreach (var x in list)
                    {
                        dataGridView2.Rows.Add(x.ShortCode, x.Fullname, x.TotalCount, x.School, x.Department);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No Cohorts found!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
