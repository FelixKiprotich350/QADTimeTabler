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
using QADTimeTabler.Models;

namespace QADTimeTabler.Timetabling
{
    public partial class GenerateTimetable : Form
    {
        readonly Population P = new Population();
        readonly TTGenerator TGen = new TTGenerator();
        public GenerateTimetable()
        {

            InitializeComponent();
            DGV_Display.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                DGV_Display.Rows.Clear();
                P.ReloadPreClasses();
                ModelsLists.PostClasses.Clear();
                if (ModelsLists.Preclasses.Count()>0)
                {
                    //sort classes according to their priority
                    List<PreClass> Flist= TGen.SortPreClasses(ModelsLists.Preclasses);

                    //return the sorted list and assign it to main PreClassList
                    ModelsLists.Preclasses = Flist;

                    //foreach Course....
                    foreach(PreClass pc in ModelsLists.Preclasses)
                    {
                        // Assign Timeslot
                        Timeslot T=TGen.RandomTimeSlot(pc);
                        // Assign Lecture Hall
                        LectureHall L = TGen.RandomLectureHall(T,pc);
                        //add to post class list
                        ModelsLists.PostClasses.Add(new PostClass
                        {
                            CourseCode = pc.CourseCode,
                            Lecturer = pc.Lecturer,
                            CourseNature = pc.CourseNature,
                            IsChild = pc.IsChild,
                            ParentCourse = pc.ParentCourse,
                            Cohorts = pc.Cohorts,
                            TotalStudents = pc.TotalStudents,
                            Timeslot = T,
                            LectureHall = L
                        });
                    }

                    string[] Sessions = { "A", "B", "C", "D" };
                    foreach (string s in Sessions)
                    {
                        DataGridViewRow rs = new DataGridViewRow();
                        rs.SetValues(s);
                        DataGridViewCellStyle ds = new DataGridViewCellStyle
                        {
                            BackColor = Color.LightGray,
                            ForeColor = Color.Black,
                            SelectionBackColor = Color.OrangeRed
                        };
                        rs.DefaultCellStyle = ds;
                        DGV_Display.Rows.Add(rs);
                        List<PostClass> S_Classes = ModelsLists.PostClasses.Where(n => n.Timeslot.Session == s).ToList();
                        //ensure all columns are packed no space between rows of the same session same day
                        foreach (PostClass pc in S_Classes)
                        {

                            DefRow(pc);

                        }
                    }

                }
                else
                {
                    MessageBox.Show(this, "There is no Class to be scheduled!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


        private void DefRow(PostClass pos)
        {
            string d=pos.Timeslot.Day;
            switch (d)
            {
                case "Monday":
                    DGV_Display.Rows.Add("",pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
                    break;
                case "Tuesday":
                    DGV_Display.Rows.Add("","","", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
                    break;
                case "Wednesday":
                    DGV_Display.Rows.Add("","","","","", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
                    break;
                case "Thursday":
                    DGV_Display.Rows.Add("","","","","","","", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
                    break;
                case "Friday":
                    DGV_Display.Rows.Add("","","","","","","","","", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
                    break;
                default:
                    break;
            }
            
        }
       
    }
} 