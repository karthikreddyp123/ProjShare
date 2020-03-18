namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingEventDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false, maxLength: 60),
                        Description = c.String(maxLength: 120),
                        Venue = c.String(),
                        StartTime = c.Time(nullable: false, precision: 7),
                        EndTime = c.Time(nullable: false, precision: 7),
                        isActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, storeType: "date"),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedBy = c.String(),
                        CanRegister = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventDetails");
        }
    }
}
