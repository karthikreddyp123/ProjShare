//System Namespace imports
using System;

//Custom Namespace Imports
using Event_Attendees_Tracker_DAL.DBQueries;
using Event_Attendees_Tracker_BAL.Models.ResponseModels;
using Event_Attendees_Tracker_BAL.util;

namespace Event_Attendees_Tracker_BAL.Authentication
{
    public class UserLogin:IUserLogin
    {
        /// <summary>
        /// Authenticate User with Email And Password        
        /// </summary>
        /// <param name="Email">User Email</param>
        /// <param name="Password">User Password</param>
        /// <returns>User Data with Role Inof with User ID</returns>        
        public ILogin_ResponseModel LoginUserWithEmailAndPassword(string Email, string Password)
        {
            //TODO:
            //Step 1: Fetch User With given Email
            var responeUserData = UserQuery.FetchUserWithEmail(Email);

            //Step 2: If Data found match the password
            if (responeUserData != null)
            {
                //(Password.Equals(new EncryptDecrypt().Decrypt(responeUserData.Password)
                if (Password.Equals(responeUserData.Password))
                {
                    //Step 3: Return User Role with UserID
                    return new Login_ResponseModel() { RoleName = "Organizer", UserID = responeUserData.ID };
                }                
            }           

            return null ;
        }
    }
}
