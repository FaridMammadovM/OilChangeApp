namespace Application.CQRS.Queries.Customer.Login.Dto
{
    public sealed class LoginReqDto
    {
        public string Phone { get; set; }
        public string Password { get; set; }
        public string? NotificationToken { get; set; }
    }
}
