namespace Application.CQRS.Commands.Customers.AddCustomer.Dtos
{
    public class AddCustomerReqDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string Phone { get; set; }
        public int RoleId { get; set; }
        public int CarId { get; set; }
        public int CustumerId { get; set; }
        public string CarNumber { get; set; }
        public decimal? Motor { get; set; }
        public int? Year { get; set; }
        public int? ColorId { get; set; }
        public int? FuelTypeId { get; set; }
    }
}
