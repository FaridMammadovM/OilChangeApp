namespace Domain.Entities
{
    public sealed class OilChangeFiltersMatrix
    {
        public int Id { get; set; }
        public int OilChangesId { get; set; }
        public int FiltersId { get; set; }
        public OilChanges OilChanges { get; set; }
        public Filters Filter { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }
}
