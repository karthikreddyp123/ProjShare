using System.Web.Mvc;

using Event_Attendees_Tracker.Filters;

namespace Event_Attendees_Tracker.Controllers
{    
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}