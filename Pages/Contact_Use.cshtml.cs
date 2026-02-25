using E_WEBB.MODEL.CONTACT_US_MODEL;
using E_WEBB.SERVICES.EMAIL_SERVICES;
using E_WEBB.SERVICES.FILE_SERVICES.TEXTFILE;
using E_WEBB.SERVICES.SECURITY_SERVICES;
using E_WEBB.SERVICES.SQL.SQL_SERVICES.SQL_CLIENT_SERVICES;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace E_WEBB.Pages
{
    public class Contact_UseModel : PageModel
    {
        [BindProperty]
        public Contact_Us_Model01 Contact_Us_M01 { get; set; }
        private static Email_Services01 Email_S01 = new Email_Services01();
        private static Read_TextFiles01 Read_T01 = new Read_TextFiles01();
        private static Sql_Client_Services01 Sql_Client_S01 = new Sql_Client_Services01();
        private string[] resaults = new string[100];
        private static Security_Services01 Security_S01 = new Security_Services01();
        private string clientid = Read_T01.client_textfile.Split('\n')[0];
        private int count = 0;

        public void OnGet()
        {
            Contact_Us_M01 = new Contact_Us_Model01();
            if (Sql_Client_S01.find_client_phonenumber_by_name(clientid.Trim(), out resaults[4]) == true)
            {
                Contact_Us_M01.phonenumber = resaults[4];
            }
            else
            {
                Contact_Us_M01.phonenumber = resaults[4];
            }



               

        }

        public IActionResult OnPostSendEmail()
        {

            if (Sql_Client_S01.find_client_email_by_name(clientid.Trim(), out resaults[0]) == true)
            {
                if (Sql_Client_S01.find_client_emailkey_by_name(clientid.Trim(), out resaults[1]) == true)
                {
                    if (Email_S01.send_email(Contact_Us_M01.Name, Contact_Us_M01.Email, Contact_Us_M01.Message,resaults[0],resaults[1], out resaults[2]) == true)
                    {
                        Contact_Us_M01.StatusMessage = resaults[2];
                    }
                    else
                    {
                        Contact_Us_M01.StatusMessage = resaults[2];
                    }
                }
                else
                {
                    Contact_Us_M01.StatusMessage = resaults[1];

                }
            }
            else
            {
                Contact_Us_M01.StatusMessage = resaults[0];
            }
                  
            return Page();          
        }
        public IActionResult OnPostBack()
        {



            return RedirectToPage("/Index");
        }

    }
}
