using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Event_Attendees_Tracker_DAL.Models
{
    [Table("tbl_EventAttendees")]
    //This class contains properties for Enity framework code first approach.
    public class EventAttendees
    {
        #region Properties
        
        public int ID { get; set; }
        
        public string QRString { get; set; }
        
        public bool isPresent { get; set; }
        
        public bool MailSent { get; set; }

        public RegisteredStudents RegisteredStudents { get; set; }

        //Event Details
        public EventDetails EventDetails { get; set; }

        #endregion
    }
}
