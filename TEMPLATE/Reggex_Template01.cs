namespace E_WEBB.TEMPLATE
{
    public class Reggex_Template01
    {
        private static string[] Regex01_ = { @"[^a-zA-Z0-9]",//special character regex
                                             @"^[^@\s]+@[^@\s]+\.[^@\s]+$",//email regex
                                             @"^\+?\d{1,3}?[\s.-]?\(?\d{1,4}\)?([\s.-]?\d{1,4}){2,3}$"//phone number regex
        
        };

        public static string[] Regex01
        {
            get { return Regex01_; }
            set { Regex01_ = value; }
        }
    }
}
