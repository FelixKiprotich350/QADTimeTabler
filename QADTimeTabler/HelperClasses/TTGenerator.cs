using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using QADTimeTabler.Models;

namespace QADTimeTabler.HelperClasses
{
    public class TTGenerator
    {
        readonly Random R = new Random();

        public List<PreClass> SortPreClasses(List<PreClass> plist)
        {            
            plist.OrderBy(p => p.CoursePriority);
            return plist;
        }

        public Timeslot RandomTimeSlot(PreClass pc)
        {
            Timeslot T = null;
            try
            {
                List<Timeslot> SessionList = new List<Timeslot>();
                string[] lecpref = pc.LecturerPreferences.Split(',').Where(n => !string.IsNullOrEmpty(n)).ToArray();
                foreach (string l in lecpref)
                {
                    SessionList.Add(new Timeslot() { Day = l, Session = "A" });
                    SessionList.Add(new Timeslot() { Day = l, Session = "B" });
                    SessionList.Add(new Timeslot() { Day = l, Session = "C" });
                    SessionList.Add(new Timeslot() { Day = l, Session = "D" });
                }
                while (SessionList.Count() > 0)
                {
                    int a = R.Next(0, SessionList.Count());
                    Timeslot t = SessionList[a];
                    if (IsTimeslotValid(t,pc.Lecturer,pc.Cohorts))
                    {
                        T = t;
                        break;
                    }
                    else
                    {
                        SessionList.Remove(t);
                    }
                }

            }
            catch
            {
                T= null;
            }
            return T;
        }

        private bool IsTimeslotValid(Timeslot T,string lec, List<Cohort> cohorts)
        {
            bool final = false;
            try
            {
                if (ModelsLists.PostClasses.Where(p => p.Timeslot == T & p.Lecturer == lec).Count() > 0)
                {
                    final = false;
                    return final;
                }
                int x = 0;
                foreach (Cohort c in cohorts)
                {
                    if (ModelsLists.PostClasses.Where(p => p.Timeslot == T & p.Cohorts.Contains(c)).Count() > 0)
                    {
                        final = false;
                        break;
                    }
                    else
                    {
                        x++;
                    }
                }
                if (x == cohorts.Count())
                {
                    final = true;
                }
                else
                {
                    final = false;
                }
            }
            catch
            {
                final = false;
            }
            return final;
        } 

        public LectureHall RandomLectureHall(Timeslot T,PreClass pc)
        {
            LectureHall L = null;
            try
            {
                if (ModelsLists.LectureHalls.Count > 0)
                {
                    //filter by capacity
                    List<LectureHall> l_list = ModelsLists.LectureHalls.Where(k=>k.TeachingCapacity>=pc.TotalStudents).ToList();
                    //filter by availability
                     
                    //check for concurrency
                    while (l_list.Count()>0)
                    {
                        int a = R.Next(0, l_list.Count);
                        LectureHall lh = l_list[a];
                        if (IsLectureHallValid(T, lh))
                        {
                            L = lh;
                            break;
                        }
                        else
                        {
                            
                            l_list.Remove(lh);
                            L = null;
                        }
                    }
                }
                
            }
            catch
            {
                L = null;
            }
            return L;
        }
        private bool IsLectureHallValid(Timeslot T, LectureHall lh)
        {
            bool final = false;
            try
            {
                if (ModelsLists.PostClasses.Where(p => p.Timeslot.Day == T.Day && p.Timeslot.Session == T.Session && p.LectureHall.FullName.ToUpper() == lh.FullName.ToUpper()).Count() > 0)
                {
                    final = false; 
                }
                else
                {
                    final = true;
                }
            }
            catch
            {
                final = false;
            }
            
            return final;
        }
    }
}
//better algorithm to solve timeslot functionality
//int a = R.Next(0, lecpref.Length);
//string Day = lecpref[a];
//string[] Sessions = { "A", "B", "C", "D" }; 
//int b = R.Next(0, Sessions.Length);
//string Session = Sessions[b];
//T = new Timeslot() { Day = Day, Session = Session };