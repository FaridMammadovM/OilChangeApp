namespace Domain.Entities
{
    public class Cars
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Motor { get; set; }
        public int Year { get; set; }
        public int ColorId { get; set; }
        public int FuelTypeId { get; set; }
        public Colors Colors { get; set; }
        public FuelTypes FuelType { get; set; }
        public ICollection<UsersCarsMatrix> UsersCars { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedDate { get; set; }
    }

}
