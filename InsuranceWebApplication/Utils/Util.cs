using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace InsuranceWebApplication.Utils
{
    public static class Util
    {
        public static bool IsValidHexColor(string hexColor)
        {
            string pattern = "^#[0-9A-Fa-f]{6}$";
            return Regex.IsMatch(hexColor, pattern);
        }

        public static bool IsPasswordSecure(string password)
        {
            // Minimum length requirement
            if (password.Length < 8)
            {
                return false;
            }

            // Check for uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                return false;
            }

            // Check for lowercase letter
            if (!Regex.IsMatch(password, "[a-z]"))
            {
                return false;
            }

            // Check for digit
            if (!Regex.IsMatch(password, @"\d"))
            {
                return false;
            }

            // Check for special character
            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string ToSha256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x"));
                }
                return builder.ToString();
            }
        }
    }
}
