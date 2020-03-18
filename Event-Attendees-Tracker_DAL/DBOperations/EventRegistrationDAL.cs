using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Event_Attendees_Tracker_DAL.Instances;
using Event_Attendees_Tracker_DAL.Models;
using System.Diagnostics;
using Event_Attendees_Tracker_DAL.DBQueries;

namespace Event_Attendees_Tracker_DAL.DBOperations
{
    public class EventRegistrationDAL
    {
        static Event_Attendees_Tracker_DAL.Database_Context.EAT_DBContext _eatDBContext = DBInstance.getDBInstance();
        public Dictionary<string, string> InsertTblRegisteredStudents(DataTable StudentsData)
        {
            var StudentList = new Dictionary<string, string>();

            foreach (DataRow student in StudentsData.Rows)
            {
                string EmailID = student.Field<string>("EmailID");
                if (CheckStudentExists.CheckStudent(EmailID))
                {
                    try
                    {
                        string collegeName = student.Field<string>("CollegeName");
                        _eatDBContext.RegisteredStudents.Add(new RegisteredStudents
                        {
                            FirstName = student.Field<string>("FirstName"),
                            LastName = student.Field<string>("LastName"),
                            ContactNumber = student.Field<string>("ContactNumber"),
                            EmailID = student.Field<string>("EmailID"),
                            StudentRollNumber = student.Field<string>("StudentRollNo"),
                            CollegeDetails = _eatDBContext.Master_CollegeDetails.Where(m => m.CollegeName.Equals(collegeName)).FirstOrDefault(),
                            CreatedBy = 1,//Update with user sessionID
                            CreatedDate = DateTime.Now
                        });
                        int returnvalue = _eatDBContext.SaveChanges();
                        if (!StudentList.ContainsKey(EmailID))
                        {
                            StudentList.Add(EmailID, "Successfully Inserted Data");
                        }
                    }
                    catch (System.Exception ex)
                    {
                        if (!StudentList.ContainsKey(EmailID))
                        {
                            StudentList.Add(EmailID, "Invalid Data");
                        }

                    }

                }
                else
                {
                    if (!StudentList.ContainsKey(EmailID))
                    {
                        StudentList.Add(EmailID, "Duplicate Data");
                    }
                }
            }
            return StudentList;
        }

        public List<string> InsertTblEventAttendees(List<string> StudentList, int EventID)
        {
            var EmailList = new List<string>();
            try
            {
                foreach (var EmailID in StudentList)
                {
                    if (CheckStudentExists.CheckAttendee(EmailID, EventID))
                    {
                        EmailList.Add(EmailID);
                        _eatDBContext.EventAttendees.Add(
                        new EventAttendees
                        {
                            RegisteredStudents = _eatDBContext.RegisteredStudents.Where(m => m.EmailID == EmailID).FirstOrDefault(),
                            EventDetails = _eatDBContext.EventDetails.Where(m => m.ID == EventID).FirstOrDefault(),
                            QRString = "",
                            isPresent = false,
                            MailSent = false
                        });
                    }

                }
                _eatDBContext.SaveChanges();
                return EmailList;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}