namespace Domain.Entities
{
    public class Branchies
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public ICollection<Phones>? Phones { get; set; }
        public ICollection<OilChanges>? OilChanges { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }
}
