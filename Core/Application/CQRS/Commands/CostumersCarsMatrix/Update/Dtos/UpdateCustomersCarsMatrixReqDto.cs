namespace Application.CQRS.Commands.CostumersCarsMatrix.Update.Dtos
{
    public sealed class UpdateCustomersCarsMatrixReqDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CarNumber { get; set; }
    }
}
