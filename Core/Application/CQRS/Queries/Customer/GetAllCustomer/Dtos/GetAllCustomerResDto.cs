namespace Application.CQRS.Queries.Customer.GetAllCustomer.Dtos
{
    public sealed class GetAllCustomerResDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        internal int? InsertedBy { get; set; }
        internal DateTime? InsertedDate { get; set; }

        public List<GetAllCustomerResListNumberDto> CustomersCars { get; set; }
    }
}
