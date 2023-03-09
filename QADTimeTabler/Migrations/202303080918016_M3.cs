namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cohort", "ShortCode", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cohort", new[] { "ShortCode" });
        }
    }
}
