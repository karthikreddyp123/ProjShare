namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRegisteredStudentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisteredStudents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(),
                        ContactNumber = c.String(nullable: false),
                        EmailID = c.String(nullable: false),
                        StudentRollNumber = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisteredStudents");
        }
    }
}
