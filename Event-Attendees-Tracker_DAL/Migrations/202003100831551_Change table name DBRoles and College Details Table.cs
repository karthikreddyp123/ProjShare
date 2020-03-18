namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangetablenameDBRolesandCollegeDetailsTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tbl_CollegeDetails", newName: "Master_CollegeDetails");
            RenameTable(name: "dbo.tbl_Master_DBRoles", newName: "Master_DBRoles");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Master_DBRoles", newName: "tbl_Master_DBRoles");
            RenameTable(name: "dbo.Master_CollegeDetails", newName: "tbl_CollegeDetails");
        }
    }
}
