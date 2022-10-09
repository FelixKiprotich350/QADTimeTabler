namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cohort",
                c => new
                    {
                        GroupID = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        ShortCode = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Fullname = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        School = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Department = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        TotalCount = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.GroupID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cohort");
        }
    }
}
