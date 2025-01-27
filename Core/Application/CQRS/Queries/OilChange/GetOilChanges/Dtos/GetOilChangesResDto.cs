namespace Application.CQRS.Queries.OilChange.GetOilChanges.Dtos
{
    public sealed class GetOilChangesResDto
    {
        public int Id { get; set; }
        public int CustomersCarsMatrixId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ChangeDate { get; set; }
        public string CarNumber { get; set; }
    }
}
