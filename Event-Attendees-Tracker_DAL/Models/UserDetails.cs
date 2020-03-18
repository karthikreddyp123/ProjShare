//System namespace imports
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_Attendees_Tracker_DAL.Models
{
    [Table("tbl_UserDetails")]
    public class UserDetails
    {
        #region Properties
        [Required]
        public int ID { get; set; }

        [Required]
        public int UserUID { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at most {2} characters long.", MinimumLength = 6)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at most {2} characters long.", MinimumLength = 6)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }      

        public int CreatedBy { get; set; }

        [Column(TypeName = "Date")]
        public DateTime CreatedDate { get; set; }

        public int UpdatedBy { get; set; }

        [Column(TypeName = "Date")]
        public DateTime UpdatedDate { get; set; }
        #endregion

    }
}
