using System;
using System.Diagnostics;

//Custom Namespace Imports
using Event_Attendees_Tracker_DAL.Models;

namespace Event_Attendees_Tracker_DAL.DBQueries
{
    public class EventQuery
    {
        static Event_Attendees_Tracker_DAL.Database_Context.EAT_DBContext _eatDBContext = Event_Attendees_Tracker_DAL.Instances.DBInstance.getDBInstance();
        public static bool AddEvent(string eventName, string description, string venue, string posterImage, TimeSpan startTime, TimeSpan endTime, DateTime eventDate)
        {
            try
            {
                var responseData = _eatDBContext.EventDetails.Add(new EventDetails()
                {
                    EventName = eventName,
                    Description = description,
                    Venue = venue,
                    StartTime = startTime,
                    EndTime = endTime,
                    EventDate = eventDate.ToString(),
                    PosterImage = posterImage,
                    CreatedAt = DateTime.Now                    
                });
                _eatDBContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Debug.Print("Exception Occured");
                return false;
            }           
            
        }
    }
}
