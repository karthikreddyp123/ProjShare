//System Namespace Import
using RestSharp;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Security;

//Custom Namespace Imports
using Event_Attendees_Tracker.Middlewares;

namespace Event_Attendees_Tracker.Controllers
{
    public class UserController : Controller
    {
        RestClient client = new RestClient("https://localhost:44360/");

        //GET: User/Login
        [HttpGet]
        [AllowAnonymous]
        public ViewResult Login()
        {
            return View();
        }

        //POST: /User/Login
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(FormCollection formData, string ReturnURL)
        {
            var request = new RestRequest("api/Login");
            request.Method = Method.POST;
            request.AddJsonBody(new { Email = formData.Get("emailID"), Password = formData.Get("password") });
            var response = client.Execute(request);            

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = new JsonDeserializer(response.Content);

                FormsAuthentication.SetAuthCookie(content.GetInt("UserID").ToString(), formData.Get("rememberMe")=="on"?true:false);            

                return RedirectToAction("Dashboard", content.GetString("RoleName"));
            }
            ModelState.AddModelError("", "Invalid Email or Password");
            ViewData["Error"] = "Invalid Email or Password";
            return View("Login");
            //return RedirectToAction("Organizer");

        }



    }
}