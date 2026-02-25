using E_WEBB.MODEL.CONTACT_US_MODEL;
using E_WEBB.SERVICES.EMAIL_SERVICES;
using E_WEBB.SERVICES.SECURITY_SERVICES;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace E_WEBB.Pages
{
    public class Contact_UseModel : PageModel
    {
        [BindProperty]
        public Contact_Us_Model01 Contact_Us_M01 { get; set; }
        private static Email_Services01 Email_S01 = new Email_Services01();
        private string resaults=string.Empty;
        private static Security_Services01 Security_S01 = new Security_Services01();
        private int count = 0;  

        public void OnGet()
        {
            Contact_Us_M01 = new Contact_Us_Model01();
            Contact_Us_M01.phonenumber = "8176778761";
        }

        public IActionResult OnPostSendEmail()
        {


                if (Email_S01.send_email(Contact_Us_M01.Name, Contact_Us_M01.Email, Contact_Us_M01.Message, out resaults) == true)
                {
                    Contact_Us_M01.StatusMessage = resaults;
                }
                else
                {
                    Contact_Us_M01.StatusMessage = resaults;
                }


            return Page();          
        }
        public IActionResult OnPostBack()
        {



            return RedirectToPage("/Index");
        }

    }
}
