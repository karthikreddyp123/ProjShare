using System;
using System.Data;

namespace Event_Attendees_Tracker_API.Models
{
    public class EventModel
    {
        public string Name { get; set; }
        public string Venue { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Description { get; set; }
        public string VolunteerEmail { get; set; }
        public string PosterImagePath { get; set; }
        public DataTable AttendeesDataTable { get; set; }
    }
}