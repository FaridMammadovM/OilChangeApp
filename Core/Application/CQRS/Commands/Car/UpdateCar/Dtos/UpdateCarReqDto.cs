namespace Application.CQRS.Commands.Car.UpdateCar.Dtos
{
    public class UpdateCarReqDto
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Brand { get; set; }
    }
}
