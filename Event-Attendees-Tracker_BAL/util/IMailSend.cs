using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Attendees_Tracker_BAL.util
{
    public interface IMailSend
    {
        void SendRegistrationMail(List<String> Recepient, int EventID);
    }
}
