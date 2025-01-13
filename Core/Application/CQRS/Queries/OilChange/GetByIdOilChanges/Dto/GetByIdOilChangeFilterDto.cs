namespace Application.CQRS.Queries.OilChange.GetByIdOilChanges.Dto
{
    public sealed class GetByIdOilChangeFilterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool FilterOwn { get; set; } = false;
        public string? FilterCode { get; set; }
    }
}
