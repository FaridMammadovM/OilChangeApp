namespace Domain.Entities
{
    public sealed class FuelTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Cars> Cars { get; set; }
    }
}
