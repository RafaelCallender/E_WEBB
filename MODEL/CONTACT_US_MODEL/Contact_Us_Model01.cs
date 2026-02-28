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
        public string phonenumber { get; set; } = string.Empty;
        [BindProperty]
        public string Message { get; set; } = string.Empty;
        [BindProperty]
        public string dateSent { get; set; } = string.Empty;
        [BindProperty]
        public string client_phonenumber { get; set; } = string.Empty;
        [BindProperty]
        public string StatusMessage { get; set; }= string.Empty;
        [BindProperty]
        public string StatusMessage01 { get; set; } = string.Empty;
        [BindProperty]
        public string StatusMessage02 { get; set; } = string.Empty;
        [BindProperty]
        public string StatusMessage03 { get; set; } = string.Empty;
        public string data01 { get; set; } = string.Empty;
        public string data02 { get; set; } = string.Empty;
        public string data03 { get; set; } = string.Empty;
        public string data04 { get; set; } = string.Empty;
        public string data05 { get; set; } = string.Empty;
    }
}