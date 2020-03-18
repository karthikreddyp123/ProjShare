using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Attendees_Tracker_BAL.User_Actions
{
    public interface IEvents
    {
        Dictionary<string,string> AddEvent(string EventName, string Description, string Venue, string posterImagePath, TimeSpan startTime, TimeSpan endTime, DateTime eventDate, DataTable StudentRegistrationData);
    }
}
