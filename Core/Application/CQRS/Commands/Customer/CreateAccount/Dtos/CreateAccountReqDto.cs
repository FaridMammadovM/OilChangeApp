namespace Application.CQRS.Commands.Customer.CreateAccount.Dtos
{
    public class CreateAccountReqDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string? NotificationToken { get; set; }

    }
}
