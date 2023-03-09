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

namespace QADTimeTabler.dummydata
{
    public partial class cohorts : Form
    {
        public cohorts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] co = { "BIT", "EGC", "HR", "ECO", "ABC", "TRD", "BBM", "SKS", "OPJ", "HJD", "YDN", "UOK", "TRE", "PLU", "PUT", "BDJ", "LAW", "TEE" };
                var db = new TimeDbContext();
                foreach (string x in co)
                {
                    int pos = 1;
                    while (pos<5)
                    {
                        Cohort c = new Cohort()
                        {
                            //GroupID = Guid.NewGuid().ToString(),

                            Fullname = x + "-" + RandomString(10),
                            School = "SST",
                            Department = "SST",
                            CreationDate = Program.CurrentDate(),
                            ShortCode = x + "-" + pos,
                            TotalCount = random.Next(10, 500)
                        };
                        db.Cohorts.Add(c);
                        pos++;
                    }
                   
                }
                db.SaveChanges();
                MessageBox.Show(this, "Cohorts saved Successfully.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
