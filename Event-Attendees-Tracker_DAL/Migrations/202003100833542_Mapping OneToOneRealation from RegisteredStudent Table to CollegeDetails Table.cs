namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MappingOneToOneRealationfromRegisteredStudentTabletoCollegeDetailsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_RegisteredStudents", "CollegeDetails_ID", c => c.Int());
            CreateIndex("dbo.tbl_RegisteredStudents", "CollegeDetails_ID");
            AddForeignKey("dbo.tbl_RegisteredStudents", "CollegeDetails_ID", "dbo.Master_CollegeDetails", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_RegisteredStudents", "CollegeDetails_ID", "dbo.Master_CollegeDetails");
            DropIndex("dbo.tbl_RegisteredStudents", new[] { "CollegeDetails_ID" });
            DropColumn("dbo.tbl_RegisteredStudents", "CollegeDetails_ID");
        }
    }
}
