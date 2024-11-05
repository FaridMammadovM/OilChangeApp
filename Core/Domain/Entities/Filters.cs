namespace Domain.Entities
{
    public sealed class Filters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<OilChangeFiltersMatrix> OilChangeFilters { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }
}
