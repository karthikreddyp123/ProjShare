using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Attendees_Tracker_BAL.util
{
    public interface IEventRegistration
    {
       Dictionary<String,String> InsertTblRegisteredStudents(DataTable StudentRegistrationData, int EventID, string EventName);
    }
}
