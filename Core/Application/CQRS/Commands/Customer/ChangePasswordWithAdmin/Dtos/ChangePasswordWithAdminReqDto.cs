namespace Application.CQRS.Commands.Customer.ChangePasswordWithAdmin.Dtos
{
    public sealed class ChangePasswordWithAdminReqDto
    {
        public int Id { get; set; }
        public string Password { get; set; }
    }
}
