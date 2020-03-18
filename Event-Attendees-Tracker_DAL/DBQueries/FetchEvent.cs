using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event_Attendees_Tracker_DAL.Models;

namespace Event_Attendees_Tracker_DAL.DBQueries
{
    public class FetchEvent
    {
        static Event_Attendees_Tracker_DAL.Database_Context.EAT_DBContext _eatDBContext = Event_Attendees_Tracker_DAL.Instances.DBInstance.getDBInstance();

        public static Dictionary<String, String> fetchEventData(int EventID)
        {
            var fetchEventDetails = _eatDBContext.EventDetails.Where(m => m.ID == EventID).FirstOrDefault();
            Dictionary<String,String> eventDetails = new Dictionary<string, string>();
            eventDetails.Add("EventName",fetchEventDetails.EventName);
            eventDetails.Add("EventDate",fetchEventDetails.EventDate);
            eventDetails.Add("EventVenue",fetchEventDetails.Venue);
            eventDetails.Add("EventTime",fetchEventDetails.StartTime.ToString());

            return eventDetails;
        }
    }
}
