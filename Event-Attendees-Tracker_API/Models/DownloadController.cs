using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Event_Attendees_Tracker_API.Models
{
    public class DownloadController : ApiController
    {        
        [HttpGet]
        public IHttpActionResult Get()
        {
            
            return Redirect(@"~/../Content/Template/Event_Attendees_Tracker_Student_Registration_Template.xlsx");
        }
    }
}
