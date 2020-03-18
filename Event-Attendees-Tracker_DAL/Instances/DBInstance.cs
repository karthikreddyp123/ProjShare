//System namespace Imports
using System;

//Custom namespace Imports
using Event_Attendees_Tracker_DAL.Database_Context;

namespace Event_Attendees_Tracker_DAL.Instances
{
    /// <summary>
    /// Return the DB Instance
    /// </summary>
    sealed class DBInstance
    {
        private static EAT_DBContext _DBContextInstance;
        /// <summary>
        /// Checks for the existing DB Instance if available then return it else create it and then return it
        /// </summary>
        /// <returns>Return the Instance of the DB</returns>
        public static EAT_DBContext getDBInstance()
        {
            if (_DBContextInstance == null)
            {
                _DBContextInstance = new EAT_DBContext();
            }
            return _DBContextInstance;
        }

    }
}
