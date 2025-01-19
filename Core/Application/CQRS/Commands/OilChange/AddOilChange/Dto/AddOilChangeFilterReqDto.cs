namespace Application.CQRS.Commands.OilChange.AddOilChange.Dto
{
    public sealed class AddOilChangeFilterReqDto
    {
        public int FilterId { get; set; }
        public bool FilterOwn { get; set; } = false;
        public string? FilterCode { get; set; }
    }
}
