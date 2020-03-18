//System Namespace Import
using System.Data.Entity;

//Custom Namespace Import
using Event_Attendees_Tracker_DAL.Models;

namespace Event_Attendees_Tracker_DAL.Database_Context
{
    /// <summary>
    /// Import ALl ORM in the DBSet Instance
    /// </summary>
    ///     
    public class EAT_DBContext : DbContext
    {
        public EAT_DBContext() : base()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EAT_DBContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<EventDetails> EventDetails { get; set; }
        public DbSet<PointOfContact> PointOfContacts { get; set; }
        public DbSet<Master_CollegeDetails> Master_CollegeDetails { get; set; }
        public DbSet<RegisteredStudents> RegisteredStudents { get; set; }
        public DbSet<EventAttendees> EventAttendees { get; set; }
        public DbSet<Master_DBRoles> Master_DBRoles { get; set; }        

    }
}
