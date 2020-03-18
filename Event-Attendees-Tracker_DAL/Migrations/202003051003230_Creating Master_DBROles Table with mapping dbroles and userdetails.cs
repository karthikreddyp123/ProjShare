namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingMaster_DBROlesTablewithmappingdbrolesanduserdetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Master_DBRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.UserDetails", "Role_ID", c => c.Int());
            CreateIndex("dbo.UserDetails", "Role_ID");
            AddForeignKey("dbo.UserDetails", "Role_ID", "dbo.tbl_Master_DBRoles", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDetails", "Role_ID", "dbo.tbl_Master_DBRoles");
            DropIndex("dbo.UserDetails", new[] { "Role_ID" });
            DropColumn("dbo.UserDetails", "Role_ID");
            DropTable("dbo.tbl_Master_DBRoles");
        }
    }
}
