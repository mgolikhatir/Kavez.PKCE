using System.Security.Cryptography;
using System.Text;

namespace Kavez.PKCE.Utils
{
    public static class CryptoUtils
    {
        public static byte[] Sha256(string input)
        {
            using var sha256 = SHA256.Create();
            return sha256.ComputeHash(Encoding.ASCII.GetBytes(input));
        }

        public static string Base64UrlEncode(byte[] input)
        {
            return Convert.ToBase64String(input)
                .Replace("+", "-")
                .Replace("/", "_")
                .Replace("=", "");
        }
    }
}