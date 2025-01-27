namespace Application.CQRS.Queries.OilChange.GetAllOilChanges.Dtos
{
    public sealed class GetAllOilChangesReqDto
    {
        public int CustomersCarsMatrixId { get; set; }
        public int? ServiceId { get; set; }
    }
}
