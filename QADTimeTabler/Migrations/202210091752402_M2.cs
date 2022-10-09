namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.School",
                c => new
                    {
                        SchoolGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        SchoolCode = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        SchoolName = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.SchoolGuid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.School");
        }
    }
}
