namespace Domain.Entities
{
    public sealed class OilTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }
}
