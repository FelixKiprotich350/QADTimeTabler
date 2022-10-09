namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        SchoolGuid = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        DepartmentCode = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        DepartmentName = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.DepartmentGuid)
                .Index(t => t.DepartmentCode, unique: true);
            
            AlterColumn("dbo.Cohort", "Fullname", c => c.String(nullable: false, maxLength: 500, storeType: "nvarchar"));
            AlterColumn("dbo.School", "SchoolName", c => c.String(nullable: false, maxLength: 500, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropIndex("dbo.Department", new[] { "DepartmentCode" });
            AlterColumn("dbo.School", "SchoolName", c => c.String(nullable: false, maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Cohort", "Fullname", c => c.String(nullable: false, maxLength: 200, storeType: "nvarchar"));
            DropTable("dbo.Department");
        }
    }
}
