using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_Attendees_Tracker_DAL.Models
{
    public class EventDetails
    {
        #region Properties        
        public int ID { get; set; }
        
        [Required]
        [StringLength(60, ErrorMessage ="Should be less than 60 characters")]
        public string EventName { get; set; }
        
        [StringLength(120, ErrorMessage ="Should be less than 120 character")]
        public string Description { get; set; }

        public string Venue { get; set; }
        
        public TimeSpan StartTime { get; set; }
        

        public TimeSpan EndTime { get; set; }

        [Required]
        [DataType(DataType.Date)]        
        public string EventDate { get; set; }

        public string PosterImage { get; set; }

        public bool isActive { get; set; }
        
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]        
        public DateTime CreatedAt { get; set; }

        //TODO:
        //Change to UserDetails
        public int? CreatedBy { get; set; }

        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]        
        public DateTime? UpdatedAt { get; set; }

        //TODO:
        //Change to UserDetails
        public int? UpdatedBy { get; set; }

        public bool CanRegister { get; set; }
        #endregion
    }
}
