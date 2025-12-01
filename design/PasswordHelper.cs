using System.Security.Cryptography;
using System.Text;

namespace AttendanceTracker
{
    public static class PasswordHelper
    {
        public static string Hash(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public static bool Verify(string password, string storedHash)
        {
            return Hash(password) == storedHash;
        }
    }
}
