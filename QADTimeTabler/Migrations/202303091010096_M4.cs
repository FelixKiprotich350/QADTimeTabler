namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course", "Cohorts", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Course", "Cohorts", c => c.String(nullable: false, maxLength: 200, storeType: "nvarchar"));
        }
    }
}
