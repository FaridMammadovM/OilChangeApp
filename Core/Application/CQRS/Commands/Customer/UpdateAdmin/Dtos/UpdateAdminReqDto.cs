namespace Application.CQRS.Commands.Customer.UpdateAdmin.Dtos
{
    public class UpdateAdminReqDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
    }
}
