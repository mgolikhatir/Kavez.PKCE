using System.Security.Cryptography;
using System.Text;

namespace Kavez.PKCE.Core
{
    public static class PKCEHelper
    {
        public static string GenerateCodeVerifier(int length = 64)
        {
            var bytes = RandomNumberGenerator.GetBytes(length);
            return Base64UrlEncode(bytes);
        }

        public static string GenerateCodeChallenge(string codeVerifier, string method = "S256")
        {
            if (method == "plain")
                return codeVerifier;

            using var sha256 = SHA256.Create();
            var bytes = Encoding.ASCII.GetBytes(codeVerifier);
            var hash = sha256.ComputeHash(bytes);
            return Base64UrlEncode(hash);
        }

        private static string Base64UrlEncode(byte[] input)
        {
            return Convert.ToBase64String(input)
                .Replace("+", "-")
                .Replace("/", "_")
                .Replace("=", "");
        }
    }
}