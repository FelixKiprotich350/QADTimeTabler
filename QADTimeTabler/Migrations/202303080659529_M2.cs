﻿namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LectureHall", "ExaminationCapacity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LectureHall", "ExaminationCapacity");
        }
    }
}
