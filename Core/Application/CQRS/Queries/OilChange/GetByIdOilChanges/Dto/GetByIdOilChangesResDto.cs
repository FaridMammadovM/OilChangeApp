namespace Application.CQRS.Queries.OilChange.GetByIdOilChanges.Dto
{
    public sealed class GetByIdOilChangesResDto
    {
        public int Id { get; set; }
        public int CustomersCarsMatrixId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ProductName { get; set; }
        public string ChangeDate { get; set; }
        public int? KilometersTravelled { get; set; }
        public int? Duration { get; set; }
        public decimal? OilVolume { get; set; }
        public int? SAEViscosity { get; set; }
        public decimal WinterViscosity { get; set; }
        public decimal Price { get; set; }
        public string EmployeeName { get; set; }
        public string BranchName { get; set; }
        public string Description { get; set; }
        public IList<GetByIdOilChangeFilterDto> Filters { get; set; }


    }
}
