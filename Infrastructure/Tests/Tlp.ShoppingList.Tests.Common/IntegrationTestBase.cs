using NUnit.Framework;
using Tlp.ShoppingList.Data.Request.Contracts;

namespace Tlp.ShoppingList.Tests.Common
{
    public class IntegrationTestBase
    {
        public IntegrationTestBase()
        {
            var factory = new TlpApplicationFactory();
            Api = new WebApiWrapper(factory);
        }

        protected async Task Login(string userName)
        {
            var request = new LoginUserRequestDto
            {
                UserName = userName,
                Password = "123"
            };
            var result = await Api.Post<LoginUserRequestDto, LoginResultDto>("api/authentication/login", request);
            Api.AccessToken = result.Token;
        }

        public WebApiWrapper Api { get; }

        [OneTimeTearDown]
        protected void TearDown()
        {
            Api.DropDatabase();
        }
    }

}