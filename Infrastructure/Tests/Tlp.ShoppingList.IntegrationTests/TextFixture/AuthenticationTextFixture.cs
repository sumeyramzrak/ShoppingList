using NUnit.Framework;
using System.Threading.Tasks;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Tests.Common;

namespace Tlp.ShoppingList.IntegrationTests
{
    [TestFixture]
    public class AuthenticationTextFixture : IntegrationTestBase
    {
        [Test]
        public async Task ICan_Login()
        {
            var request = new LoginUserRequestDto
            {
                UserName = "admin",
                Password = "123"
            };
            var result = await Api.Post<LoginUserRequestDto, LoginResultDto>("api/authentication/login", request);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Token, Is.Not.Null);
            Assert.That(result.DisplayName, Is.EqualTo("System Account"));
        }

        [TestCase("admin", "wrongpassword")]
        [TestCase("unknownuser", "password")]
        public async Task ICannot_Login_With_InvalidCredentials(string username, string password)
        {
            var request = new LoginUserRequestDto
            {
                UserName = username,
                Password = password
            };
            var result = await Api.Post<LoginUserRequestDto, LoginResultDto>("api/authentication/login", request);
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task ICan_Create_User()
        {
            var user = new RegisterUserRequestDto
            {
                UserName = "New User",
                EMail = "newuser@mail.com",
                Password = "qwer"
            };
            var result = await Api.Post<RegisterUserRequestDto, bool>("api/authentication/register", user);
            Assert.That(result, Is.True);
        }

    }
}