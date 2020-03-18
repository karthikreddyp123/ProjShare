namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MappingEventAttendeesTablewithRegisteredStudentTableandEventDetailsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_EventAttendees", "EventDetails_ID", c => c.Int());
            AddColumn("dbo.tbl_EventAttendees", "RegisteredStudents_ID", c => c.Int());
            CreateIndex("dbo.tbl_EventAttendees", "EventDetails_ID");
            CreateIndex("dbo.tbl_EventAttendees", "RegisteredStudents_ID");
            AddForeignKey("dbo.tbl_EventAttendees", "EventDetails_ID", "dbo.EventDetails", "ID");
            AddForeignKey("dbo.tbl_EventAttendees", "RegisteredStudents_ID", "dbo.tbl_RegisteredStudents", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_EventAttendees", "RegisteredStudents_ID", "dbo.tbl_RegisteredStudents");
            DropForeignKey("dbo.tbl_EventAttendees", "EventDetails_ID", "dbo.EventDetails");
            DropIndex("dbo.tbl_EventAttendees", new[] { "RegisteredStudents_ID" });
            DropIndex("dbo.tbl_EventAttendees", new[] { "EventDetails_ID" });
            DropColumn("dbo.tbl_EventAttendees", "RegisteredStudents_ID");
            DropColumn("dbo.tbl_EventAttendees", "EventDetails_ID");
        }
    }
}
