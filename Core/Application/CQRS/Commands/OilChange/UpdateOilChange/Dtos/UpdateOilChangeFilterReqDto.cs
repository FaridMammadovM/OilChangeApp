namespace Application.CQRS.Commands.OilChange.UpdateOilChange.Dtos
{
    public sealed class UpdateOilChangeFilterReqDto
    {
        public int Id { get; set; }
        public int FilterId { get; set; }
        public bool FilterOwn { get; set; } = false;
        public string? FilterCode { get; set; }
    }
}
