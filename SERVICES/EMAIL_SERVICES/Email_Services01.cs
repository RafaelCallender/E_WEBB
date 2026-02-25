using E_WEBB.SERVICES.SQL.SQL_SERVICES.SQL_CLIENT_SERVICES;
using System.Net;
using System.Net.Mail;

namespace E_WEBB.SERVICES.EMAIL_SERVICES
{
    public class Email_Services01
    {
        private static Sql_Client_Services01 Sql_Client_S01 = new Sql_Client_Services01();
        public bool send_email(string input, string input01, string input02, out string input03)
        {
            try
            {
           
                string fromEmail ="callender.rafael92@gmail.com";
                string appPassword = "lfki bbvf ogld qupd";
                string to_add = "callender.rafael92@gmail.com";
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(to_add.Trim());
                mail.Subject = "Test";
                mail.Body = $"Email: {input}\n" +
                            $"Name: {input01}\n" +
                            $"Message:{input02}\n";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail.Trim(), appPassword.Trim());
                smtp.EnableSsl = true;

                smtp.Send(mail);
                input03 = "message sent";
                return true;
            }
            catch (Exception ex)
            {
                input03 = ex.Message;
                return false;

            }

        }
    }
}
