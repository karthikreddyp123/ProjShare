namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Event_Attendees_Tracker_DAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Event_Attendees_Tracker_DAL.Database_Context.EAT_DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Event_Attendees_Tracker_DAL.Database_Context.EAT_DBContext context)
        {
            //Seeding Master DB Roles Table
            IList<Master_DBRoles> defaultMasterDBRoles = new List<Master_DBRoles>();
            defaultMasterDBRoles.Add(new Master_DBRoles() { RoleName = "Admin" });
            defaultMasterDBRoles.Add(new Master_DBRoles() { RoleName = "Organizer" });
            defaultMasterDBRoles.Add(new Master_DBRoles() { RoleName = "Volunteer" });

            //Seeding User Details Table
            IList<UserDetails> defaultUserDetails = new List<UserDetails>();
            defaultUserDetails.Add(new UserDetails() { UserUID = 560258, FirstName = "Jitender", LastName = "Rajput", EmailID = "jkrajput24@gmail.com", Password = "mydesire", CreatedBy = 1, CreatedDate = System.DateTime.Now, UpdatedBy = 1, UpdatedDate = System.DateTime.Now });

            context.Master_DBRoles.AddRange(defaultMasterDBRoles);
            context.UserDetails.AddRange(defaultUserDetails);

            base.Seed(context);
        }
    }
}
