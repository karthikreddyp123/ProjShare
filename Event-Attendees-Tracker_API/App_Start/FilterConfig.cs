using System.Web;
using System.Web.Mvc;

namespace Event_Attendees_Tracker_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
