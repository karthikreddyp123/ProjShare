//System namespace Imports
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Custom Namespace Imports

namespace Event_Attendees_Tracker_DAL.Models
{
    [Table("Master_DBRoles")]
   public class Master_DBRoles
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string RoleName { get; set; }
    }

}
