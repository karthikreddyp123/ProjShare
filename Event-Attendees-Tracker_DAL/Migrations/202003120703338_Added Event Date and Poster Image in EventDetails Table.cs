namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEventDateandPosterImageinEventDetailsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventDetails", "EventDate", c => c.String(nullable: false));
            AddColumn("dbo.EventDetails", "PosterImage", c => c.String());
            AddColumn("dbo.EventDetails", "UpdatedAt", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.EventDetails", "CreatedBy", c => c.Int(nullable: true));
            AlterColumn("dbo.EventDetails", "UpdatedBy", c => c.Int(nullable: true));
            DropColumn("dbo.EventDetails", "UpdatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventDetails", "UpdatedDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.EventDetails", "UpdatedBy", c => c.String());
            AlterColumn("dbo.EventDetails", "CreatedBy", c => c.String());
            DropColumn("dbo.EventDetails", "UpdatedAt");
            DropColumn("dbo.EventDetails", "PosterImage");
            DropColumn("dbo.EventDetails", "EventDate");
        }
    }
}
