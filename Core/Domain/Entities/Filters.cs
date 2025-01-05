using Domain.Common;

namespace Domain.Entities
{
    public sealed class Filters : EntityBase
    {
        public string Name { get; set; }
        public ICollection<OilChangeFiltersMatrix> OilChangeFilters { get; set; }
    }
}

