using Domain.Common;

namespace Domain.Entities
{
    public sealed class CustomersCarsMatrix : EntityBase
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CarNumber { get; set; }
        public decimal? Motor { get; set; }
        public int? Year { get; set; }
        public int? ColorsId { get; set; }
        public int? FuelTypeId { get; set; }
        public Colors Colors { get; set; }
        public FuelTypes FuelType { get; set; }
        public Cars Cars { get; set; }
        public Customers Customers { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }

    }
}
