using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QADTimeTabler.HelperClasses; 
using QADTimeTabler.Models;
using Microsoft.Office.Interop;

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
                        if (L == null)
                        {
                            L = new LectureHall();
                            L.FullName = "N/A";
                            L.TeachingCapacity = 0;
                        }
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
                    string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
                    Debug.WriteLine(ModelsLists.PostClasses.Count.ToString());
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
                        
                        List<PostClass> S_Classes = ModelsLists.PostClasses.Where(n => n.Timeslot.Session == s).ToList();
                        //ensure all columns are packed no space between rows of the same session same day
                        List<int> daycounts = new List<int>();
                        Days.ToList().ForEach(a => daycounts.Add(S_Classes.Where(b => b.Timeslot.Day == a).Count()));
                        DefRow1(S_Classes,daycounts.Max(),s);
                        DGV_Display.Rows.Add(rs);
                        //foreach (PostClass pc in S_Classes)
                        //{ 
                        //    DefRow(pc); 
                        //}
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

        private void DefRow(PostClass pos )
        {
            string d=pos.Timeslot.Day;
            switch (d)
            {
                case "Monday":
                    DGV_Display.Rows.Add("",pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.TeachingCapacity + "]");
                    break;
                case "Tuesday":
                    DGV_Display.Rows.Add("","","", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.TeachingCapacity + "]");
                    break;
                case "Wednesday":
                    DGV_Display.Rows.Add("","","","","", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.TeachingCapacity + "]");
                    break;
                case "Thursday":
                    DGV_Display.Rows.Add("","","","","","","", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.TeachingCapacity + "]");
                    break;
                case "Friday":
                    DGV_Display.Rows.Add("","","","","","","","","", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.TeachingCapacity + "]");
                    break;
                default:
                    break;
            }
            
        }

        private void DefRow1(List<PostClass> classes, int max,string session)
        {
            string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            int m = 0;
            foreach (string a in Days)
            {
                int count = classes.Where(k => k.Timeslot.Day == a).Count();
                if (count > m)
                {
                    m = count;
                }
            }
            //var monday = classes.Where(k => k.Timeslot.Day == "Monday").ToList();
            //var tuesday = classes.Where(k => k.Timeslot.Day == "Tuesday").ToList();
            //var wednesday = classes.Where(k => k.Timeslot.Day == "Wednesday").ToList();
            //var Friday = classes.Where(k => k.Timeslot.Day == "Friday").ToList();
            
            for (int x = 0; x < m; x++)
            {
                List<string> cl = new List<string>();
                if (x == 0)
                {
                    switch (session)
                    {
                        case "A":
                            cl.Add("7 AM-10 AM");
                            break;
                        case "B":
                            cl.Add("10 AM-1 PM");
                            break;
                        case "C":
                            cl.Add("1 PM-4 PM");
                            break;
                        case "D":
                            cl.Add("4 PM-7 PM");
                            break;
                        default:
                           // cl.Add("");
                            break;
                    }
                }
                else
                {
                    cl.Add("");
                }
                foreach (var y in Days)
                { 
                    PostClass pc = GetCourse(classes, y, x);
                    if (pc != null)
                    {
                        cl.Add(pc.CourseCode + "[" + pc.TotalStudents + "]");
                        cl.Add(pc.LectureHall.FullName);
                        
                    }
                    else
                    {
                        cl.Add("");
                        cl.Add("");
                    }
                }
                DGV_Display.Rows.Add(cl.ToArray());

            }
             
        }
 
        private PostClass GetCourse(List<PostClass> classes,string day,int pos)
        {
            if (classes.Where(k => k.Timeslot.Day == day).Count() > pos)
            {
                return classes.Where(k => k.Timeslot.Day == day).ToArray()[pos];
            }
            else
            {
                return null;
            }
            
        }

        private void DGV_Display_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_Display.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    return;
                }
                string code = DGV_Display.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                ViewClassInfo ec = new ViewClassInfo(code);
                ec.ShowDialog(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message Box", MessageBoxButtons.OK);
            }
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                //select destination path
                FolderBrowserDialog fb = new FolderBrowserDialog();
                fb.ShowDialog();
                if (fb.SelectedPath.Trim() == "")
                {
                    MessageBox.Show("You didnt select any path. The report will not be saved.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Initialize excel app;
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                
               
                // see the excel sheet behind the program  
                app.Visible = false;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;

                // changing the name of active sheet  
                worksheet.Name = "Generated Timetable";
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
                worksheet.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                worksheet.Cells.Borders.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbBlack;
                worksheet.Cells.Font.Size = 10;
               // worksheet.Cells.AutoFit();
                // storing header part in Excel  
                for (int i = 1; i < DGV_Display.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = DGV_Display.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < DGV_Display.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGV_Display.Columns.Count; j++)
                    {
                        if (DGV_Display.Rows[i].Cells[j].Value !=null)
                        {
                            worksheet.Cells[i + 2, j + 1] = DGV_Display.Rows[i].Cells[j].Value.ToString();
                        }
                        
                    }
                }

                // save the application  
                workbook.SaveAs(fb.SelectedPath + "\\GeneratedTable.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                workbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, fb.SelectedPath + "\\GeneratedTable.pdf");
                MessageBox.Show("File has been successfully saved.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Exit from the application
                app.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message Box", MessageBoxButtons.OK);
            } 
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine(ModelsLists.PostClasses.Count.ToString());          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message Box", MessageBoxButtons.OK);
            }
        }
    }
}
//var pos = classes[0];
//string d = classes[0].Timeslot.Day;

//if (d == "Monday")
//{

//}
//else if (d == "Tuesday")
//{

//}
//switch (d)
//{
//    case "Monday":
//        break;
//    case "Tuesday":
//        break;
//    case "Wednesday":
//        break;
//    case "Thursday":
//        break;
//    case "Friday":
//        break;
//    default:
//        break;
//}
//switch (d)
//{
//    case "Monday":
//        DGV_Display.Rows.Add("", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
//        break;
//    case "Tuesday":
//        DGV_Display.Rows.Add("", "", "", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
//        break;
//    case "Wednesday":
//        DGV_Display.Rows.Add("", "", "", "", "", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
//        break;
//    case "Thursday":
//        DGV_Display.Rows.Add("", "", "", "", "", "", "", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
//        break;
//    case "Friday":
//        DGV_Display.Rows.Add("", "", "", "", "", "", "", "", "", pos.CourseCode, pos.LectureHall.FullName + " [" + pos.LectureHall.Capacity + "]");
//        break;
//    default:
//        break;
//}