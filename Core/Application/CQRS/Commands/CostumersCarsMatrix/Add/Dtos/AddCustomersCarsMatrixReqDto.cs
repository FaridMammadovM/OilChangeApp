namespace Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos
{
    public sealed class AddCostumersCarsMatrixReqDto
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CarNumber { get; set; }
        public int MotorId { get; set; }
        public int Year { get; set; }
        public int? ColorsId { get; set; }
        public int FuelTypeId { get; set; }
        public string Description { get; set; }
    }
}
