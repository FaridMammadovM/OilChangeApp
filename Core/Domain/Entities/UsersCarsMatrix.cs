namespace Domain.Entities
{
    public sealed class UsersCarsMatrix
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustumerId { get; set; }
        public string CarNumber { get; set; }
        public Cars Cars { get; set; }
        public Customers Customers { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }
}
