namespace Domain.Entities
{
    public sealed class Filters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<OilChangeFiltersMatrix> OilChangeFilters { get; set; }
    }
}
