using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event_Attendees_Tracker.Modals
{
    public class EventModel
    {
        public string name { get; set; }
        public string venue { get; set; }
        public DateTime eventDate { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public string description { get; set; }
        public string volunteerEmail { get; set; }
        public HttpPostedFileBase posterImage { get; set; }
        public HttpPostedFileBase excelFile { get; set; }
    }
}