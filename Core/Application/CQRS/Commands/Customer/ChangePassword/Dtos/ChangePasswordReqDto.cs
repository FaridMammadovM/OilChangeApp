namespace Application.CQRS.Commands.Customer.ChangePassword.Dtos
{
    public sealed class ChangePasswordReqDto
    {
        public string Password { get; set; }
        public string OldPassword { get; set; }
    }
}
