namespace Application.CQRS.Queries.Car.GetAll.Dtos
{
    public sealed class GetAllCarsResDto
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal? Motor { get; set; }
        public int? Year { get; set; }        
        public string ColorName { get; set; }        
        public string FuelTypeName { get; set; }
    }
}
