using System;
using System.Collections.Generic;
using System.Web;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.IO;
using System.Net.Mime;
using System.Diagnostics;
using Event_Attendees_Tracker_DAL.DBQueries;

namespace Event_Attendees_Tracker_BAL.util
{
  

    public class MailSend : IMailSend
    {
        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int Description, int ReversedValue);

        public void SendRegistrationMail(List<String> Recepient,int EventID)
        {
            var eventDetails = FetchEvent.fetchEventData(EventID);
            int des;
            if (InternetGetConnectedState(out des, 0))
            {
                Debug.Print(AppDomain.CurrentDomain.BaseDirectory);
                string FilePath = HttpContext.Current.Server.MapPath("~/MailTemplate/Register.html");
                StreamReader str = new StreamReader(FilePath);
                string MailBody = str.ReadToEnd();
                MailBody = MailBody.Replace("cid:Name", eventDetails["EventName"]);
                MailBody = MailBody.Replace("cid:Date", eventDetails["EventDate"]);//Change Event Date
                MailBody = MailBody.Replace("cid:Time", eventDetails["EventTime"]);
                MailBody = MailBody.Replace("cid:Venue", eventDetails["EventVenue"]);

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("MAIL");
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                mail.From = new MailAddress(Environment.UserName + "@epam.com");
                foreach(string s in Recepient)
                {
                    mail.To.Add(s);
                }
                mail.Subject = eventDetails["EventName"] + " Registration Mail";
                mail.IsBodyHtml = true;
                SmtpServer.Port = 25;
                SmtpServer.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                string logoPath = HttpContext.Current.Server.MapPath("~/Images/EPAM_LOGO_WhiteAndBlue.png");
                string wallpaper = HttpContext.Current.Server.MapPath("~/Images/EPAM_winter_party-081_72DPIRGB.jpg");
                string ProjectLogo = HttpContext.Current.Server.MapPath("~/Images/ProjectLogo.png");
                mail.AlternateViews.Add(imageEmbedder(logoPath, MailBody, "logo"));
                mail.AlternateViews.Add(imageEmbedder(wallpaper, MailBody, "background"));
                mail.AlternateViews.Add(imageEmbedder(ProjectLogo, MailBody, "ProjectLogo"));
                try
                {
                    SmtpServer.Send(mail);
                }
                catch(Exception ex)
                {
                    Debug.Print(ex.Message);
                }
            }
        }

        private static AlternateView imageEmbedder(string SourcePath, string MailBody, string SourceId)
        {
            var htmlView = AlternateView.CreateAlternateViewFromString(MailBody, null, "text/html");
            var resource = new LinkedResource(SourcePath) { ContentId = SourceId };
            resource.TransferEncoding = TransferEncoding.Base64;
            htmlView.LinkedResources.Add(resource);
            return htmlView;
        }
    }
}
