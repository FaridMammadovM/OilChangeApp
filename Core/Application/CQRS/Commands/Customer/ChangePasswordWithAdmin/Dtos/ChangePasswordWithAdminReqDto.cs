namespace Application.CQRS.Commands.Customer.ChangePasswordWithAdmin.Dtos
{
    public sealed class ChangePasswordWithAdminReqDto
    {
        public int CustomerId { get; set; }
        public string Password { get; set; }
    }
}
