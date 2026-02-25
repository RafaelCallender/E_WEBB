using E_WEBB.TEMPLATE;
using System.Text.RegularExpressions;

namespace E_WEBB.SERVICES.SECURITY_SERVICES
{
    public class Security_Services01
    {
        private static string[] data01 = new string[100];
        private int encryptionkey = 1;
        private string key = "MySecretKey123";
        private string key2 = "UltraKey";

        public bool empty_string(string input)
        {
            if (input != string.Empty &&
                input != " " &&
                !string.IsNullOrEmpty(input) &&
               input != "" &&
               !string.IsNullOrWhiteSpace(input))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool string_only_digit(string input)
        {
            if (input.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool string_has_special_character(string input)
        {

            if (Regex.IsMatch(input, Reggex_Template01.Regex01[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool string_has_uppercase_character(string input)
        {
            if (input.Any(char.IsUpper))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool string_has_digit_character(string input)
        {
            if (input.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool string_has_length(string input)
        {
            int length = 15;
            if (input.Length >= length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool password_check(string input)
        {
            if (string_has_special_character(input) == true &&
                string_has_uppercase_character(input) == true &&
                string_has_digit_character(input) == true &&
                string_has_length(input) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool age_check(string input)
        {
            DateTime dateTime = DateTime.Now;
            int current_year = dateTime.Year;
            int birth_year = int.Parse(input);
            int age = current_year - birth_year;
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool email_check(string input)
        {
            if (Regex.IsMatch(input, Reggex_Template01.Regex01[1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool phone_check(string input)
        {
            if (Regex.IsMatch(input, Reggex_Template01.Regex01[2]))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool date_check(string input)
        {
            //any date formate
            DateTime temp;
            if (DateTime.TryParse(input, out temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string encrypt_text_file(string input)
        {

            char[] shiftedChars = new char[input.Length];

            int index = 0;

            foreach (char c in input)
            {
                shiftedChars[index] = (char)(c + encryptionkey);
                index++;
            }

            return new string(shiftedChars);
        }


        public string decrypt_text_file(string input)
        {


            char[] shiftedChars = new char[input.Length];

            int index = 0;

            foreach (char c in input)
            {
                shiftedChars[index] = (char)(c - encryptionkey);
                index++;
            }

            return new string(shiftedChars);
        }
        public string Position_Based_Encryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int dynamicKey = encryptionkey + (i % 7); // key changes every char
                result[i] = (char)(input[i] + dynamicKey);
            }

            return new string(result);
        }
        public string Position_Based_Deccryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int dynamicKey = encryptionkey + (i % 7);
                result[i] = (char)(input[i] - dynamicKey);
            }

            return new string(result);
        }
        public string XOR_Encryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = (char)(input[i] ^ key[i % key.Length]);
            }

            return new string(result);
        }
        public string XOR_Decryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = (char)(input[i] ^ key[i % key.Length]);
            }

            return new string(result);
        }
        public string Shift_XOR_Position_Encryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int dynamic = encryptionkey + (i % 5);
                char shifted = (char)(input[i] + dynamic);
                result[i] = (char)(shifted ^ key2[i % key2.Length]);
            }

            return new string(result);
        }

        public string Shift_XOR_Position_Decryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char unXor = (char)(input[i] ^ key2[i % key2.Length]);
                int dynamic = encryptionkey + (i % 5);
                result[i] = (char)(unXor - dynamic);
            }

            return new string(result);
        }
    }
}