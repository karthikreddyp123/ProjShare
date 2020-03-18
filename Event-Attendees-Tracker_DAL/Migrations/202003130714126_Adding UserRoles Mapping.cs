namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUserRolesMapping : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbl_UserDetails", "Role_ID", "dbo.Master_DBRoles");
            DropIndex("dbo.tbl_UserDetails", new[] { "Role_ID" });
            DropColumn("dbo.tbl_UserDetails", "Role_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_UserDetails", "Role_ID", c => c.Int());
            CreateIndex("dbo.tbl_UserDetails", "Role_ID");
            AddForeignKey("dbo.tbl_UserDetails", "Role_ID", "dbo.Master_DBRoles", "ID");
        }
    }
}
