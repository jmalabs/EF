namespace EntityFramework.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConfigurationUsingFluentAPI : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagCourses", newName: "CourseTags");
            DropPrimaryKey("dbo.CourseTags");
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Id)
                .Index(t => t.Id);
            
            AddPrimaryKey("dbo.CourseTags", new[] { "Course_CourseId", "Tag_Id" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Covers", "Id", "dbo.Courses");
            DropIndex("dbo.Covers", new[] { "Id" });
            DropPrimaryKey("dbo.CourseTags");
            DropTable("dbo.Covers");
            AddPrimaryKey("dbo.CourseTags", new[] { "Tag_Id", "Course_CourseId" });
            RenameTable(name: "dbo.CourseTags", newName: "TagCourses");
        }
    }
}
