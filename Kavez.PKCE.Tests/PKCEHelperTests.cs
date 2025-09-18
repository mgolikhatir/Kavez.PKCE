using Xunit;
using Kavez.PKCE.Core;

namespace Kavez.PKCE.Tests
{
    public class PKCEHelperTests
    {
        [Fact]
        public void GenerateCodeVerifier_ShouldReturn_NonEmptyString()
        {
            var verifier = PKCEHelper.GenerateCodeVerifier();
            Assert.False(string.IsNullOrWhiteSpace(verifier));
        }

        [Fact]
        public void GenerateCodeChallenge_S256_ShouldReturn_ValidChallenge()
        {
            var verifier = PKCEHelper.GenerateCodeVerifier();
            var challenge = PKCEHelper.GenerateCodeChallenge(verifier, "S256");

            Assert.False(string.IsNullOrWhiteSpace(challenge));
            Assert.NotEqual(verifier, challenge);
        }

        [Fact]
        public void GenerateCodeChallenge_Plain_ShouldReturn_SameAsVerifier()
        {
            var verifier = PKCEHelper.GenerateCodeVerifier();
            var challenge = PKCEHelper.GenerateCodeChallenge(verifier, "plain");

            Assert.Equal(verifier, challenge);
        }
    }
}