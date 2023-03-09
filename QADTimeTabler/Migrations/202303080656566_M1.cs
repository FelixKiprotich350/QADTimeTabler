namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LectureHall", "TeachingCapacity", c => c.Int(nullable: false));
            DropColumn("dbo.LectureHall", "Capacity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LectureHall", "Capacity", c => c.Int(nullable: false));
            DropColumn("dbo.LectureHall", "TeachingCapacity");
        }
    }
}
