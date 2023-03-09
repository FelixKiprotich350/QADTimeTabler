namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Lecturer", new[] { "LecturerID" });
            AddColumn("dbo.Lecturer", "AutoID", c => c.String(nullable: false, maxLength: 100, storeType: "nvarchar"));
            CreateIndex("dbo.Lecturer", "AutoID", unique: true);
            DropColumn("dbo.Lecturer", "LecturerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lecturer", "LecturerID", c => c.String(nullable: false, maxLength: 100, storeType: "nvarchar"));
            DropIndex("dbo.Lecturer", new[] { "AutoID" });
            DropColumn("dbo.Lecturer", "AutoID");
            CreateIndex("dbo.Lecturer", "LecturerID", unique: true);
        }
    }
}
