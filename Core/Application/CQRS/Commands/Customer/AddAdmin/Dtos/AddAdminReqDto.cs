namespace Application.CQRS.Commands.Customer.AddAdmin.Dtos
{
    public class AddAdminReqDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string Username { get; set; }
    }
}
