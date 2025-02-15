namespace Application.CQRS.Queries.OilChange.LastOilChanges.Dtos
{
    public sealed class LastOilChangesResDto
    {
        public int Id { get; set; }
        public int CustomersCarsMatrixId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ChangeDate { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        internal DateTime ChangeDateAsDateTime { get; set; }
    }
}
