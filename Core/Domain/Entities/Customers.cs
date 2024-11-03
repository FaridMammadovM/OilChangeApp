namespace Domain.Entities
{
    public sealed class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public ICollection<Commits> Commits { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
        public ICollection<UsersCarsMatrix> UsersCars { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }
}
