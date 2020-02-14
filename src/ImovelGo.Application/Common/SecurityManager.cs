using System;
using System.Security.Cryptography;
using System.Text;

namespace ImovelGo.Application.Common
{
    public static class SecurityManager
    {
        private const string SECRET = "greenbook";

        public static string CreateHash(string value)
        {
            var encoding = new System.Text.UTF8Encoding();
            var keyBytes = encoding.GetBytes(SECRET);
            var messageBytes = encoding.GetBytes(value);
            using (var hmacsha1 = new HMACSHA1(keyBytes))
            {
                var hashMessage = hmacsha1.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashMessage);
            }
        }
    }
}
