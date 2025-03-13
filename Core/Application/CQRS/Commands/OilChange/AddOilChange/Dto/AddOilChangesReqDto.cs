namespace Application.CQRS.Commands.OilChange.AddOilChange.Dto
{
    public class AddOilChangesReqDto
    {
        public int CustomersCarsMatrixId { get; set; }
        public int ServiceId { get; set; }
        public int? ProductId { get; set; }
        public int? SAEViscosityId { get; set; }
        public int? WinterViscosityId { get; set; }
        public string? Indicator { get; set; }
        public DateTime ChangeDate { get; set; }

        //yuruyus
        public int? KilometersTravelled { get; set; }

        //yag hecmi
        public decimal? Volume { get; set; }

        //istifade ede bileceyi km
        public int? Duration { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public List<AddOilChangeFilterReqDto?>? Filters { get; set; }
    }
}
