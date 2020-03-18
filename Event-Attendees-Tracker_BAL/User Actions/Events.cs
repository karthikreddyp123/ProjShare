using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

//Custom namespace imports
using Event_Attendees_Tracker_BAL.Models.ResponseModels;
using Event_Attendees_Tracker_BAL.util;
using Event_Attendees_Tracker_DAL.DBQueries;

namespace Event_Attendees_Tracker_BAL.User_Actions
{
   public class Events:IEvents
    {
        private readonly IEventRegistration _eventRegistration;
        public Events(IEventRegistration eventRegistration)
        {
            _eventRegistration = eventRegistration;
        }
        public Dictionary<string,string> AddEvent(string EventName, string Description, string Venue, string posterImagePath, TimeSpan startTime, TimeSpan endTime, DateTime eventDate, DataTable StudentRegistrationData)
        {
            try
            {
                var responseAddEventData = EventQuery.AddEvent(EventName, Description, Venue, posterImagePath, startTime, endTime, eventDate);

                //Save the attendees data
                //Fetch Event ID and Name
                Dictionary<String,String> responseAddStudentRegistrationData = _eventRegistration.InsertTblRegisteredStudents(StudentRegistrationData, 60, "CodeInject");
                return responseAddStudentRegistrationData;
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
                return null;
            }
                
        }
    }
}
