namespace Tlp.ShoppingList.Data.Request.Contracts
{
    public class RegisterUserRequestDto
    {
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
