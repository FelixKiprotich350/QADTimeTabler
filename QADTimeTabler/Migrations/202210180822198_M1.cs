namespace QADTimeTabler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassObject",
                c => new
                    {
                        ClassGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        CourseCode = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Lecturer = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        IsChild = c.Boolean(nullable: false),
                        ParentCourse = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Cohorts = c.String(nullable: false, maxLength: 1000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ClassGuid)
                .Index(t => t.CourseCode, unique: true);
            
            CreateTable(
                "dbo.Cohort",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        ShortCode = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Fullname = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        School = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Department = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        TotalCount = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        CourseCode = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        CourseTitle = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        CourseNature = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Department = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Cohorts = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.CourseGuid)
                .Index(t => t.CourseCode, unique: true);
            
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
            
            CreateTable(
                "dbo.LectureHall",
                c => new
                    {
                        LHGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        ShortName = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        FullName = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Location = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Capacity = c.Int(nullable: false),
                        Nature = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.LHGuid);
            
            CreateTable(
                "dbo.Lecturer",
                c => new
                    {
                        LecturerGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        LecturerID = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        LecFullName = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Department = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Preferences = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.LecturerGuid)
                .Index(t => t.LecturerID, unique: true);
            
            CreateTable(
                "dbo.LHLocation",
                c => new
                    {
                        LocationGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        ShortName = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Description = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.LocationGuid)
                .Index(t => t.ShortName, unique: true);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        SchoolGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        SchoolCode = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        SchoolName = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.SchoolGuid);
            
            CreateTable(
                "dbo.SystemUser",
                c => new
                    {
                        UserGuid = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        UserID = c.Int(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Role = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Department = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Password = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.UserGuid);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.LHLocation", new[] { "ShortName" });
            DropIndex("dbo.Lecturer", new[] { "LecturerID" });
            DropIndex("dbo.Department", new[] { "DepartmentCode" });
            DropIndex("dbo.Course", new[] { "CourseCode" });
            DropIndex("dbo.ClassObject", new[] { "CourseCode" });
            DropTable("dbo.SystemUser");
            DropTable("dbo.School");
            DropTable("dbo.LHLocation");
            DropTable("dbo.Lecturer");
            DropTable("dbo.LectureHall");
            DropTable("dbo.Department");
            DropTable("dbo.Course");
            DropTable("dbo.Cohort");
            DropTable("dbo.ClassObject");
        }
    }
}
