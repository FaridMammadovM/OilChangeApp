namespace Application.CQRS.Queries.Customer.GetCustomerById.Dtos
{
    public sealed class GetCustomerByIdResDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
