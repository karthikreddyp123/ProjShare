using System;
using System.Diagnostics;
using System.Linq;

//Custom namespace import
using Event_Attendees_Tracker_DAL.Models;

namespace Event_Attendees_Tracker_DAL.DBQueries
{
    public class UserQuery
    {
        static Event_Attendees_Tracker_DAL.Database_Context.EAT_DBContext _eatDBContext = Event_Attendees_Tracker_DAL.Instances.DBInstance.getDBInstance();

        /// <summary>
        /// Fetch User With Email
        /// </summary>
        /// <param name="email">Email of the User</param>
        /// <returns>User Details Object</returns>
        public static UserDetails FetchUserWithEmail(string email)
        {
            var responseUserData = _eatDBContext.UserDetails.FirstOrDefault(user=>user.EmailID.Equals(email));        
            if (responseUserData != null)
                return responseUserData;
            return null;
        }


        /// <summary>
        /// Fetch User With ID
        /// </summary>
        /// <param name="email">Email of the User</param>
        /// <returns>User Details Object</returns>
        //public static UserDetails FetchUserWithEmail(int UserID)
        //{
        //    //var responseUserData = _eatDBContext.
        //    if (responseUserData != null)
        //        return responseUserData;
        //    return null;
        //}
    }
}
