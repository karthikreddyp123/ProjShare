namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangetablenameUserDetailsandRegisteredStudentTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.RegisteredStudents", newName: "tbl_RegisteredStudents");
            RenameTable(name: "dbo.UserDetails", newName: "tbl_UserDetails");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tbl_UserDetails", newName: "UserDetails");
            RenameTable(name: "dbo.tbl_RegisteredStudents", newName: "RegisteredStudents");
        }
    }
}
