namespace Application.CQRS.Commands.Customer.AddCustomer.Dtos
{
    public class AddCustomerReqDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
