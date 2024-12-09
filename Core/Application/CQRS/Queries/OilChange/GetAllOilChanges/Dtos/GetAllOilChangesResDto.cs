namespace Application.CQRS.Queries.OilChange.GetAllOilChanges.Dtos
{
    public sealed class GetAllOilChangesResDto
    {
        public int Id { get; set; }
        public int CustomersCarsMatrixId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ChangeDate { get; set; }

    }
}
