namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingEventAttendeesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_EventAttendees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QRString = c.String(),
                        isPresent = c.Boolean(nullable: false),
                        MailSent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_EventAttendees");
        }
    }
}
