using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitimer.Models;

namespace Unitimer
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class UTDbContext: DbContext
    {
        public UTDbContext() : base("server=localhost;port=3306;database=DbTimeTable;uid=root;password=toor;")
        {
            //this.Database.CommandTimeout=10; 
            //Database.Initialize(true);
            //Database.CreateIfNotExists();
            Database.Log = s => Debug.WriteLine(s);
            //Database.Log = s => Trace.WriteLine(s); 
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Cohort> Cohorts { get; set; }
    }
}
