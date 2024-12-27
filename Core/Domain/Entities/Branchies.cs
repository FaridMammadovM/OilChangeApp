using Domain.Common;

namespace Domain.Entities
{
    public class Branchies : EntityBase
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public ICollection<Phones>? Phones { get; set; }
        public ICollection<OilChanges>? OilChanges { get; set; }
    }
}
