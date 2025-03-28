﻿namespace Application.CQRS.Queries.OilChange.GetByIdOilChanges.Dto
{
    public sealed class GetByIdOilChangesResDto
    {
        public int Id { get; set; }
        public int CustomersCarsMatrixId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? ProductId { get; set; }
        public int? SAEViscosityId { get; set; }
        public int? SAEViscosityName { get; set; }
        public int? WinterViscosityId { get; set; }
        public decimal? WinterViscosityName { get; set; }
        public string? Indicator { get; set; }
        public string ProductName { get; set; }
        public string ChangeDate { get; set; }
        public int? KilometersTravelled { get; set; }
        public int? Duration { get; set; }
        public decimal? Volume { get; set; }
        public string GeneralName { get; set; }
        public decimal Price { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string? CarNumber { get; set; }
        public bool OilOwn { get; set; } = false;
        public string? OilCode { get; set; }
        public string Description { get; set; }
        public IList<GetByIdOilChangeFilterDto> Filters { get; set; }


    }
}
