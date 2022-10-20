using MySql.Data.EntityFramework;
using QADTimeTabler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace QADTimeTabler
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class TimeDbContext: DbContext
    {
        public TimeDbContext() : base("server=localhost;port=3306;database=DbTimeTable;uid=root;password=toor;")
        {
            //this.Database.CommandTimeout=10; 
            //Database.Initialize(true);
            Database.CreateIfNotExists();
            Database.Log = s => Debug.WriteLine(s);
            //Database.Log = s => Trace.WriteLine(s); 
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Cohort> Cohorts { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<LectureHall> LectureHalls { get; set; }
        public DbSet<LHLocation> LHLocations { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; } 
        public DbSet<Course> Courses { get; set; } 
        public DbSet<ClassObject> ClassObjects { get; set; }  
        public DbSet<SystemUser> SystemUsers { get; set; } 
    }
}
