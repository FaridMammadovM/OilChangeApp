using Domain.Common;

namespace Domain.Entities
{
    public class Cars : EntityBase, IEntityBase
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Motor { get; set; }
        public int Year { get; set; }
        public int ColorId { get; set; }
        public int FuelTypeId { get; set; }
        public int EngineDisplacement { get; set; }
        public Colors Colors { get; set; }
        public FuelTypes FuelType { get; set; }
        public ICollection<UsersCarsMatrix> UsersCars { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }

}
