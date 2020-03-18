namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingOneToOneRelationfromCollegeDetailsTableToPointOfContactTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_CollegeDetails", "PointOfContact_ID", c => c.Int());
            CreateIndex("dbo.tbl_CollegeDetails", "PointOfContact_ID");
            AddForeignKey("dbo.tbl_CollegeDetails", "PointOfContact_ID", "dbo.tbl_PointOfContact", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_CollegeDetails", "PointOfContact_ID", "dbo.tbl_PointOfContact");
            DropIndex("dbo.tbl_CollegeDetails", new[] { "PointOfContact_ID" });
            DropColumn("dbo.tbl_CollegeDetails", "PointOfContact_ID");
        }
    }
}
