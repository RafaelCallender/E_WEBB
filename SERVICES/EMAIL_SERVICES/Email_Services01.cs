using E_WEBB.SERVICES.FILE_SERVICES.TEXTFILE;
using E_WEBB.SERVICES.SQL.SQL_SERVICES.SQL_CLIENT_SERVICES;
using System.Net;
using System.Net.Mail;

namespace E_WEBB.SERVICES.EMAIL_SERVICES
{
    public class Email_Services01
    {
        private static Read_TextFiles01 Read_T01 = new Read_TextFiles01();
        private static Sql_Client_Services01 Sql_Client_S01 = new Sql_Client_Services01();

        public bool send_email(string input, string input01, string input02,string input03,string input04, out string output)
        {
            try
            {

                string fromEmail = input03;
                string appPassword = input04;
                string to_add = input03;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail.Trim());
                mail.To.Add(to_add.Trim());
                mail.Subject = "Test";
                mail.Body = $"Email: {input01}\n" +
                            $"Name: {input}\n" +
                            $"Message:{input02}\n";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail.Trim(), appPassword.Trim());
                smtp.EnableSsl = true;

                smtp.Send(mail);
                output = "message sent";
                return true;
            }
            catch (Exception ex)

            {
                output = ex.Message;
                return false;

            }

        }
    }
}
