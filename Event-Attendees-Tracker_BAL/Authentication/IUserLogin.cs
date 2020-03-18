using Event_Attendees_Tracker_BAL.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Attendees_Tracker_BAL.Authentication
{
    public interface IUserLogin
    {
        ILogin_ResponseModel LoginUserWithEmailAndPassword(string Email, string Password);

    }
}
