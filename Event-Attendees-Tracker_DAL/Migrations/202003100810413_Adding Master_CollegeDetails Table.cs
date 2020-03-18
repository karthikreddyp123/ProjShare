namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMaster_CollegeDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_CollegeDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CollegeName = c.String(nullable: false),
                        CollegeLocation = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_CollegeDetails");
        }
    }
}
