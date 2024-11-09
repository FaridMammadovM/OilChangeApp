namespace Application.CQRS.Commands.Car.AddCar.Dtos
{
    public sealed class AddCarReqDto
    {
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public decimal? Motor { get; set; }
        public int? Year { get; set; }
        public int? ColorId { get; set; }
        public int? FuelTypeId { get; set; }
    }
}
