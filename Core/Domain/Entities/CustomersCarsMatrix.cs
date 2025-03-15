using Domain.Common;

namespace Domain.Entities
{
    public sealed class CustomersCarsMatrix : EntityBase
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string? CarNumber { get; set; }
        public string? Description { get; set; }
        public Cars Cars { get; set; }
        public Customers Customers { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }

    }
}
