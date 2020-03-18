using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Attendees_Tracker_BAL.Models.ResponseModels
{
   public class Login_ResponseModel: ILogin_ResponseModel
    {
        public string RoleName { get; set; }
        public int UserID { get; set; }
    }
}
