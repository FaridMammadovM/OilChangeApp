﻿using Domain.Entities;

namespace Application.CQRS.Commands.OilChange.AddOilChange.Dto
{
    public class AddOilChangesReqDto
    {
        public int CustomersCarsMatrixId { get; set; }
        public int ServiceId { get; set; }
        public int ProductId { get; set; }
        public int SAEViscosityId { get; set; }
        public int WinterViscosityId { get; set; }
        public DateTime ChangeDate { get; set; }
        public int KilometersTravelled { get; set; }
        public int Duration { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public decimal? Price { get; set; }
        public decimal OilVolume { get; set; }
        public bool OilOwn { get; set; } = false;
        public string OilCode { get; set; }
        public string Description { get; set; }
        public ICollection<OilChangeFiltersMatrix> OilChangeFilters { get; set; }

    }
}
