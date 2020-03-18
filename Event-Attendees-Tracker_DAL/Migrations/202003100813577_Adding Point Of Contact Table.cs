namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPointOfContactTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_PointOfContact",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        EmailID = c.String(),
                        ContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_PointOfContact");
        }
    }
}
