using Application.CQRS.Commands.OilChange.AddOilChange.Dto;

namespace Application.CQRS.Commands.OilChange.UpdateOilChange.Dtos
{
    public sealed class UpdateOilChangeReqDto
    {
        public int Id { get; set; }
        public int CustomersCarsMatrixId { get; set; }
        public int ServiceId { get; set; }
        public int? ProductId { get; set; }
        public int? SAEViscosityId { get; set; }
        public int? WinterViscosityId { get; set; }
        public string? Indicator { get; set; }
        public DateTime ChangeDate { get; set; }
        public int? KilometersTravelled { get; set; }
        public decimal? Volume { get; set; }
        public int? Duration { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public decimal Price { get; set; }
        public bool OilOwn { get; set; } = false;
        public string? OilCode { get; set; }
        public string? Description { get; set; }
        public List<UpdateOilChangeFilterReqDto>? Filters { get; set; }       
      
    }
}
