//System namespace Imports
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Diagnostics;
using System;
using System.Collections.Generic;

//Custom Namespace Imports
using Event_Attendees_Tracker_API.Models;
using Event_Attendees_Tracker_BAL.User_Actions;


namespace Event_Attendees_Tracker_API.Controllers
{

    public class UserController : ApiController
    {
        private readonly IEvents _events;
        public UserController(IEvents events)
        {
            _events = events;
        }
        public Dictionary<string,string> CreateEvent(EventModel requestEventData)
        {
            Dictionary<string, string> response;
            try
            {
                response = _events.AddEvent(requestEventData.Name, requestEventData.Description, requestEventData.Venue, requestEventData.PosterImagePath, requestEventData.StartTime, requestEventData.EndTime, requestEventData.EventDate, requestEventData.AttendeesDataTable);
                if (response==null) return null;
            }


            catch(Exception ex)
            {
                Debug.Print(ex.Message);
                return null;
            }
            

            return response;           
        }
    }
}
