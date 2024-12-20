namespace Application.CQRS.Commands.Customer.UpdateCustomer.Dtos
{
    public sealed class UpdateCustomerReqDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}
