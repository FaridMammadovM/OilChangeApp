namespace Application.CQRS.Queries.OilChange.GetOilChanges.Dtos
{
    public sealed class GetOilChangesReqDto
    {
        public string? CarNumber { get; set; }
        public int? ServiceId { get; set; }
        public int? ProductId { get; set; }
        public int? BranchId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
