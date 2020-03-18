namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingUserDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserUID = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        EmailID = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 18),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDetails");
        }
    }
}
