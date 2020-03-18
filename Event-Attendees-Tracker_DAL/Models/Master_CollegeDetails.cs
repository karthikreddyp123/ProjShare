using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_Attendees_Tracker_DAL.Models
{
    [Table("Master_CollegeDetails")]
    public class Master_CollegeDetails
    {

        #region Properties

        public int ID { get; set; }

        [Required]//Required Column 
        public string CollegeName { get; set; }

        public string CollegeLocation { get; set; }

        public string CreatedBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }

        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime UpdatedDate { get; set; }

        public PointOfContact PointOfContact { get; set; }
        #endregion
    }
}
