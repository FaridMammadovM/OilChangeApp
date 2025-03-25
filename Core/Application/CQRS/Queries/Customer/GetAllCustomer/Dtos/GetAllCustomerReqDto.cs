namespace Application.CQRS.Queries.Customer.GetAllCustomer.Dtos
{
    public class GetAllCustomerReqDto
    {
        public string? CarNumber { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public bool SortByDateAscending { get; set; }

    }
}
