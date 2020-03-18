using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_Attendees_Tracker_DAL.Models
{
    [Table("tbl_RegisteredStudents")]
    public class RegisteredStudents
    {
        #region Properties     
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        public string StudentRollNumber { get; set; }

        public int CreatedBy { get; set; }

        [DataType(DataType.DateTime)]
        [Column(TypeName = "Date")]
        public DateTime CreatedDate { get; set; }

        public int UpdatedBy { get; set; }

        [DataType(DataType.DateTime)]
        [Column(TypeName = "Date")]
        public DateTime UpdatedDate { get; set; }
        
        public Master_CollegeDetails CollegeDetails { get; set; }
        #endregion
    }
}
