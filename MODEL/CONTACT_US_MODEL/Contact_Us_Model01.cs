using Microsoft.AspNetCore.Mvc;


namespace E_WEBB.MODEL.CONTACT_US_MODEL
{
    public class Contact_Us_Model01
    {
        [BindProperty]
        public string Name { get; set; } = string.Empty;
        [BindProperty]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        public string Message { get; set; } = string.Empty;
        [BindProperty]
        public string dateSent { get; set; } = string.Empty;
        [BindProperty]
        public string phonenumber { get; set; } = string.Empty;
        [BindProperty]
        public string StatusMessage { get; set; } = string.Empty;
    }
}