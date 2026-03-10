using E_WEBB.MODEL.CONTACT_US_MODEL;
using E_WEBB.SERVICES.EMAIL_SERVICES;
using E_WEBB.SERVICES.FILE_SERVICES.TEXTFILE;
using E_WEBB.SERVICES.SECURITY_SERVICES;
using E_WEBB.SERVICES.SQL.SQL_SERVICES.SQL_CLIENT_SERVICES;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_WEBB.SERVICES.FILE_SERVICES.IMAGEFILE;
namespace E_WEBB.Pages
{
    public class Contact_UseModel : PageModel
    {
        [BindProperty]
        public Contact_Us_Model01 Contact_Us_M01 { get; set; }
        private static Email_Services01 Email_S01 = new Email_Services01();
        private static Read_Textfiles Read_T01 = new Read_Textfiles();
        private static Sql_Client_Services01 Sql_Client_S01 = new Sql_Client_Services01();
        private string[] resaults = new string[100];
        private static Security_Services01 Security_S01 = new Security_Services01();
        private static Sql_Client_Services02 Sql_Client_S02 = new Sql_Client_Services02();
		private static Read_Imagefiles Read_I=new Read_Imagefiles();
        public void OnGet()
        {  
            Contact_Us_M01 = new Contact_Us_Model01();
			 string clientid = Read_T01.Client_Textfile01.Split('\n')[0];
            Contact_Us_M01.data02 = Read_I.data01[0];
            Contact_Us_M01.data03 = Read_I.data01[1];
            Contact_Us_M01.data04 =  Read_I.data01[2];
            Contact_Us_M01.data05 =  Read_I.data01[3];
            Contact_Us_M01.data06 =  Read_I.data01[4];
			Contact_Us_M01.data07 =  Read_I.data01[5];
				Contact_Us_M01.data08 =  Read_I.data01[6];
					Contact_Us_M01.data10 =  Read_I.data01[7];
						Contact_Us_M01.data11 =  Read_I.data01[8];


            if (Sql_Client_S01.find_client_phonenumber_by_name(clientid.Trim(), out resaults[0]) == true)
            {
                Contact_Us_M01.client_phonenumber = resaults[0];
            }
            else
            {
                Contact_Us_M01.client_phonenumber = resaults[0];
            }

            if (Sql_Client_S01.find_client_cashapp_by_name(clientid.Trim(), out resaults[1]) == true)
            {
                Contact_Us_M01.data05 = resaults[1];
            }
            else
            {
                Contact_Us_M01.data05 = resaults[1];
            }
			    if (Sql_Client_S01.find_client_zelle_by_name(clientid.Trim(), out resaults[2]) == true)
            {
                Contact_Us_M01.data01 = resaults[2];
            }
            else
            {
                Contact_Us_M01.data01 = resaults[2];
            }
				    if (Sql_Client_S01.find_client_paypal_using_name(clientid.Trim(), out resaults[3]) == true)
            {
                Contact_Us_M01.data01 = resaults[3];
            }
            else
            {
                Contact_Us_M01.data01 = resaults[3];
            }
						    if (Sql_Client_S01.find_client_venmo_by_name(clientid.Trim(), out resaults[4]) == true)
            {
                Contact_Us_M01.data09 = resaults[4];
            }
            else
            {
                Contact_Us_M01.data09 = resaults[4];
            }
			
			


        }

        public IActionResult OnPostSendEmail()
        {
	 string clientid = Read_T01.Client_Textfile01.Split('\n')[0];

            if (Sql_Client_S01.find_client_email_by_name(clientid.Trim(), out resaults[4]) == true)
            {
                if (Sql_Client_S01.find_client_emailkey_by_name(clientid.Trim(), out resaults[5]) == true)
                {


                    if (Sql_Client_S02.insert_user01(Contact_Us_M01.Name, Contact_Us_M01.Email, Contact_Us_M01.phonenumber, Contact_Us_M01.Message, out resaults[6]) == true)
                    {

                        if (Email_S01.send_email(Contact_Us_M01.Name, Contact_Us_M01.Email, Contact_Us_M01.Message, resaults[4], resaults[5], out resaults[7]) == true)
                        {
                            Contact_Us_M01.StatusMessage03 = resaults[7];
                        }
                        else
                        {
                            Contact_Us_M01.StatusMessage03 = resaults[7];
                        }
                    }
                    else
                    {
                        Contact_Us_M01.StatusMessage03 = resaults[6];

                    }
                }
                else
                {
                    Contact_Us_M01.StatusMessage03 = resaults[5];


                }


            }
            else
            {
                Contact_Us_M01.StatusMessage03 = resaults[4];
            }




            return Page();
        }





        public IActionResult OnPostBack()
        {
            return RedirectToPage("/Index");
        }

    }
}
