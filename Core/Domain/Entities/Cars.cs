using Domain.Common;

namespace Domain.Entities
{
    public class Cars : EntityBase
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public ICollection<CustomersCarsMatrix> UsersCars { get; set; }
    }

}
