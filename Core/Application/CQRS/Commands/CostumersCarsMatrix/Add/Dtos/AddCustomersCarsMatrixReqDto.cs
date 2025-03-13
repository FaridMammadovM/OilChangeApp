namespace Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos
{
    public sealed class AddCostumersCarsMatrixReqDto
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CarNumber { get; set; }
    }
}
