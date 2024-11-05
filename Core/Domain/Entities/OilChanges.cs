namespace Domain.Entities
{
    public sealed class OilChanges
    {
        public int Id { get; set; }
        public int CustumerId { get; set; }
        public int CarId { get; set; }
        public int ServiceId { get; set; }
        public int ProductId { get; set; }
        public int OilTypeId { get; set; }
        public decimal LitersUsed { get; set; }
        public DateTime ChangeDate { get; set; }
        public int KilometersTravelled { get; set; }
        public int Duration { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Customers Customers { get; set; }
        public Cars Cars { get; set; }
        public Services Services { get; set; }
        public Products Products { get; set; }
        public OilTypes OilTypes { get; set; }
        public Employees Employees { get; set; }
        public Branchies Branchies { get; set; }
        public ICollection<OilChangeFiltersMatrix> OilChangeFilters { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }
}
