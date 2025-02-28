using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace DVLD_First.Global_Classes
{
    class clsUtil
    {
        public static bool SendEmail(string From, string To, string Subject,string Body)
        {

            //try
            //{
            //    MailMessage Mail = new MailMessage();
            //    Mail.From = new MailAddress(From);
            //    Mail.To.Add(To);

            //    Mail.Subject = Subject;
            //    Mail.Body = Body;

            ////    Mail.IsBodyHtml = true;// For HTML emails

            //    SmtpClient Smtp = new SmtpClient();
            //    Smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    Smtp.Host = "smtp.gmail.com"; // SMTP server
            //    Smtp.Port = 465; // Port

            //    Smtp.EnableSsl = true; // Enable SSL
            //    Smtp.Credentials = new System.Net.NetworkCredential(From, "Aa66Bb22pMAIL2@");
            //    Smtp.UseDefaultCredentials = false;

            //    Smtp.Send(Mail);

            //    return true;


            //}
            //catch (Exception e)
            //{
            //    string err = e.Message;
            //    return false;
            //}




        try
        {
            // إعداد تفاصيل البريد الإلكتروني
            //string fromEmail = "youremail@gmail.com"; // بريدك الإلكتروني في Gmail
            //string toEmail = "recipient@gmail.com"; // بريد المستقبل في Gmail
            //string emailPassword = "yourpassword"; // كلمة مرور بريدك الإلكتروني أو كلمة مرور التطبيق إذا كنت تستخدم 2FA
            //string subject = "Test Email from C#";
            //string body = "This is a test email sent from C# to Gmail.";

            // إعداد عميل SMTP مع خادم Gmail
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential(From, "Aa66Bb22pMAIL2@"),
                EnableSsl = true // تفعيل الاتصال المشفر
            };

            // إعداد رسالة البريد الإلكتروني
            MailMessage mailMessage = new MailMessage(From, To, Subject, Body);

            // إرسال البريد
            smtpClient.Send(mailMessage);
            return true;
           // Console.WriteLine("Email sent successfully!");
        }
        catch (Exception e)
        {
            return false;

           // Console.WriteLine("Error sending email: " + ex.Message);
        }




        }
    }
}
