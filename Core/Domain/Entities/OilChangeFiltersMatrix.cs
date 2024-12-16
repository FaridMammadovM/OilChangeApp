using Domain.Common;

namespace Domain.Entities
{
    public sealed class OilChangeFiltersMatrix : EntityBase
    {
        public int OilChangesId { get; set; }
        public int FiltersId { get; set; }
        public bool FilterOwn { get; set; } = false;
        public string FilterCode { get; set; }
        public OilChanges OilChanges { get; set; }
        public Filters Filter { get; set; }
    }
}
