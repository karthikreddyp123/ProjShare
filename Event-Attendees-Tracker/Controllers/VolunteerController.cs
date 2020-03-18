using Event_Attendees_Tracker.Filters;
using System.Web.Mvc;

namespace Event_Attendees_Tracker.Controllers
{
    [Authorize(Roles ="Volunteer")]
    public class VolunteerController : Controller
    {        
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}