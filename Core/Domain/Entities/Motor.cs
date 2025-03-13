using Domain.Common;

namespace Domain.Entities
{
    public sealed class Motor : EntityBase
    {
        public decimal EngineCapacity { get; set; }
        //public ICollection<CustomersCarsMatrix> UsersCars { get; set; }
    }
}
