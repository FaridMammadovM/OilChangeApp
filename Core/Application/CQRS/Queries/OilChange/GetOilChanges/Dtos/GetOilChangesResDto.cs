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
        public int? ProductId { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        internal DateTime ChangeDateAsDateTime { get; set; }

    }
}
